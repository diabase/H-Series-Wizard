using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace DiabaseScanWizard
{
    public partial class frmMain : Form
    {
        private Duet.Observer observer;
        private List<Duet.MachineInfo> boards = new List<Duet.MachineInfo>();

        public frmMain()
        {
            InitializeComponent();

            // Initialize mDNS discoverer
            observer = new Duet.Observer(lstMachine, boards);
        }

        private string formatSize(int bytes)
        {
            if (bytes > 1073741824)
            {
                return (bytes / 1073741824).ToString("F1") + " GiB";
            }
            if (bytes > 1048576)
            {
                return (bytes / 1048576).ToString("F1") + " MiB";
            }
            if (bytes > 1024)
            {
                return (bytes / 1024).ToString("F1") + " KiB";
            }
            return bytes.ToString();
        }

        #region Navigation
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            awContent.ClickBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (awContent.CurrentPage == awpWelcome)
            {
                if (lstMachine.SelectedIndex != -1)
                {
                    // Get 3D scans from the Duet
                    GetScans();
                }
                else
                {
                    // Let user choose parameters
                    awContent.GoToPage(awpParameters);
                }
            }
            else if (awContent.CurrentPage == awpParameters)
            {
                if (lstMachine.SelectedIndex == -1)
                {
                    // Convert given PLY file
                    ConvertFile(txtScan.Text, tbWidth.Value);
                }
                else
                {
                    // Download selected scan and convert it
                    DownloadAndConvertFile(lvScans.SelectedItems[0].Text, long.Parse(lvScans.SelectedItems[0].SubItems[3].Text), tbWidth.Value);
                }
            }
            else
            {
                // Go to the next page
                awContent.ClickNext();
            }
        }
        #endregion

        #region Welcome page
        private void awpWelcome_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            btnBack.Enabled = false;
            btnNext.Enabled = lstMachine.SelectedIndex != -1 || File.Exists(txtScan.Text);
        }

        private void lstMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = lstMachine.SelectedIndex != -1 || File.Exists(txtScan.Text);
        }

        private void txtScannedFile_Enter(object sender, EventArgs e)
        {
            lstMachine.SelectedIndex = -1;
        }

        private void btnBrowseScan_Click(object sender, EventArgs e)
        {
            if (ofdScan.ShowDialog() == DialogResult.OK)
            {
                txtScan.Text = ofdScan.FileName;
                lstMachine.SelectedIndex = -1;
            }
        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = File.Exists(txtScan.Text);
        }
        #endregion

        #region Scans page
        private void GetScans()
        {
            Enabled = false;
            UseWaitCursor = true;

            Duet.FileListResponse.Get(boards[lstMachine.SelectedIndex].IPAddress, "0:/scans").ContinueWith((task) =>
            {
                BeginInvoke((Action)delegate ()
                {
                    Enabled = true;
                    UseWaitCursor = false;

                    if (task.IsFaulted)
                    {
                        MessageBox.Show("Failed to retrieve 3D Scans from the selected machine!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lvScans.Items.Clear();
                        foreach (Duet.FileListResponse.FileListItem file in task.Result.Files)
                        {
                            if (file.Type == "f" && file.Size > 0)
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = file.Name;
                                item.SubItems.Add(formatSize(file.Size));
                                item.SubItems.Add(file.Date.ToString());
                                item.SubItems.Add(file.Size.ToString());
                                lvScans.Items.Add(item);
                            }
                        }
                        awContent.GoToPage(awpScans);
                    }
                });
            });
        }

        private void awpScans_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            btnBack.Enabled = true;
            btnNext.Enabled = lvScans.SelectedItems.Count > 0;
        }

        private void lvScans_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = lvScans.SelectedItems.Count > 0;
        }
        #endregion

        #region Parameters page
        private void awpParameters_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            btnBack.Enabled = true;
            btnNext.Enabled = true;
        }
        #endregion

        #region Progress page
        private void awpProgress_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            btnBack.Enabled = false;
            btnNext.Enabled = false;
        }
        #endregion

        #region Conversion
        private long fileSize;
        private void SetProgress(long bytesReceived)
        {
            long progress = (bytesReceived * 100 / fileSize);
            pbStep.Value = (int)progress;
            pbTotal.Value = (int)(progress / 2);
        }

        private void DownloadAndConvertFile(string file, long size, int scanWidth)
        {
            lblProgress.Text = $"Downloading {file}...";
            pbStep.Value = 0;
            awContent.GoToPage(awpProgress);
            UseWaitCursor = true;

            fileSize = size;
            string tmpFile = Path.GetTempFileName();
            Progress<long> progressIndicator = new Progress<long>(SetProgress);
            Duet.FileDownload.Start(boards[lstMachine.SelectedIndex].IPAddress, "0:/scans/" + file, tmpFile, progressIndicator).ContinueWith((task) =>
            {
                BeginInvoke((Action) delegate()
                {
                    if (task.IsFaulted)
                    {
                        // Something went wrong
                        lblProgress.Text = $"Failed to download {file}!";
                        pnlButtons.Enabled = true;
                        UseWaitCursor = false;
                        MessageBox.Show("Failed to download file!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Got the file, convert it next
                        ConvertFile(file, scanWidth);
                    }
                });
            });
        }

        private string outFile;
        private Process quadProcess;

        private void ConvertFile(string file, int scanWidth)
        {
            lblProgress.Text = "Converting file...";
            pbStep.Value = 0;
            awContent.GoToPage(awpProgress);
            //btnSave.Visible = false;
            UseWaitCursor = true;

            outFile = Path.GetTempFileName();
            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(Directory.GetCurrentDirectory(), @"VTK\quad.exe"));
            startInfo.Arguments = $"\"{file},{outFile},{scanWidth},90,0,0,0,0,1,99,1,99,\"";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            try
            {
                quadProcess = Process.Start(startInfo);
                quadProcess.EnableRaisingEvents = true;
                quadProcess.Exited += QuadProcess_Exited;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch converter: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuadProcess_Exited(this, null);
            }
        }

        private void QuadProcess_Exited(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate ()
            {
                quadProcess = null;
                lblPleaseStandBy.Visible = false;
                lblProgress.Text = "Conversion complete!";
                pbStep.Value = 100;
                pbTotal.Value = 100;
                btnCancel.Text = "Exit";
                btnCancel.Enabled = true;
                UseWaitCursor = false;
                if (e != null)
                {
                    btnSave.Visible = true;
                    SystemSounds.Beep.Play();
                }
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfdOBJ.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(outFile, sfdOBJ.FileName, true);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failed to copy output file to selected file path!\r\n\r\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
