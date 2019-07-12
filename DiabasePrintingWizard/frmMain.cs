using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Media;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiabasePrintingWizard
{
    public partial class FrmMain : Form
    {
        public static readonly string version = "v1.0.2-dev";
        public static readonly NumberFormatInfo numberFormat = CultureInfo.CreateSpecificCulture("en-US").NumberFormat;

        private Duet.Observer observer;
        private List<Duet.MachineInfo> boards = new List<Duet.MachineInfo>();

        private Process s3dProcess;
        private NamedPipeServerStream pipeServer;

        private string outFilePath;
        private bool outFileSaved = true;
        private Task postProcessingTask;

        private Duet.MachineInfo SelectedMachine
        {
            get => (lstMachine.SelectedIndex == -1) ?
                Duet.MachineInfo.DefaultMachineInfo : boards[lstMachine.SelectedIndex];
        }

        private BindingList<OverrideRule> overrideRules = new BindingList<OverrideRule>();

        public FrmMain()
        {
            numberFormat.NumberGroupSeparator = "";
            InitializeComponent();
            lblVersion.Text = version;
            dgvCustomActions.AutoGenerateColumns = false;
            dgvCustomActions.DataSource = overrideRules;

            // Check if the factory file was restored properly last time
            if (File.Exists(Simplify3D.SavedStateFileBackup) &&
                MessageBox.Show("It looks like your own Simplify3D factory file was not restored last time. Would you like to do this now?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Simplify3D.RestoreSavedState();
            }

            // Initialize mDNS discoverer
            observer = new Duet.Observer(chkConfigureManually, lstMachine, boards);

            // Initialize IPC subsystem
            InitIPC();

            // Load settings
            if (Properties.Settings.Default.Storage != "")
            {
                Settings = JsonConvert.DeserializeObject<SettingsContainer>(Properties.Settings.Default.Storage);
            }
        }

        private void FrmMain_Deactivate(object sender, EventArgs e)
        {
            UseWaitCursor = false;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Try to restore Simplify3D settings before leaving
            if (!chkTopUseOwnSettings.Checked && s3dProcess != null &&
                MessageBox.Show("You have not finished slicing your STL files yet. This means that your own Simplify3D settings will remain overwritten if you close this application now. Do you want to continue?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            // Remind users to save their toolpath before leaving
            if (!outFileSaved)
            {
                DialogResult result = MessageBox.Show("You have neither uploaded nor saved your post-processed G-Code file yet. Would you like to save it before you exit?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                    if (!outFileSaved)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }

            // Save settings before leaving
            Properties.Settings.Default.Storage = JsonConvert.SerializeObject(Settings);
            Properties.Settings.Default.Save();
        }

        #region Settings
        private RotaryPrintingSettings rotaryPrintingSettings = null;

        private SettingsContainer Settings
        {
            get => new SettingsContainer
            {
                ConfigureManually = chkConfigureManually.Checked,
                Tools = new ToolSettings[]
                {
                    new ToolSettings
                    {
                        Type = (ToolType)cboTool1.SelectedIndex,
                        PreheatTime = nudPreheat1.Value,
                        StandbyTemperature = nudTemp1.Value,
                        AutoClean = chkAutoClean1.Checked
                    },
                    new ToolSettings
                    {
                        Type = (ToolType)cboTool2.SelectedIndex,
                        PreheatTime = nudPreheat2.Value,
                        StandbyTemperature = nudTemp2.Value,
                        AutoClean = chkAutoClean2.Checked
                    },
                    new ToolSettings
                    {
                        Type = (ToolType)cboTool3.SelectedIndex,
                        PreheatTime = nudPreheat3.Value,
                        StandbyTemperature = nudTemp3.Value,
                        AutoClean = chkAutoClean3.Checked
                    },
                    new ToolSettings
                    {
                        Type = (ToolType)cboTool4.SelectedIndex,
                        PreheatTime = nudPreheat4.Value,
                        StandbyTemperature = nudTemp4.Value,
                        AutoClean = chkAutoClean4.Checked
                    },
                    new ToolSettings
                    {
                        Type = (ToolType)cboTool5.SelectedIndex,
                        PreheatTime = nudPreheat5.Value,
                        StandbyTemperature = nudTemp5.Value,
                        AutoClean = chkAutoClean5.Checked
                    }
                },
                UseOwnSettings = chkTopUseOwnSettings.Checked,
                GenerateSpecialSupport = chkTopGenerateSupport.Checked,
                RotaryPrinting = rotaryPrintingSettings
            };

            set
            {
                chkConfigureManually.Checked = value.ConfigureManually;
                cboTool1.SelectedIndex = (int)value.Tools[0].Type;
                nudPreheat1.Value = value.Tools[0].PreheatTime;
                nudTemp1.Value = value.Tools[0].StandbyTemperature;
                chkAutoClean1.Checked = value.Tools[0].AutoClean;
                cboTool2.SelectedIndex = (int)value.Tools[1].Type;
                nudPreheat2.Value = value.Tools[1].PreheatTime;
                nudTemp2.Value = value.Tools[1].StandbyTemperature;
                chkAutoClean2.Checked = value.Tools[1].AutoClean;
                cboTool3.SelectedIndex = (int)value.Tools[2].Type;
                nudPreheat3.Value = value.Tools[2].PreheatTime;
                nudTemp3.Value = value.Tools[2].StandbyTemperature;
                chkAutoClean3.Checked = value.Tools[2].AutoClean;
                cboTool4.SelectedIndex = (int)value.Tools[3].Type;
                nudPreheat4.Value = value.Tools[3].PreheatTime;
                nudTemp4.Value = value.Tools[3].StandbyTemperature;
                chkAutoClean4.Checked = value.Tools[3].AutoClean;
                cboTool5.SelectedIndex = (int)value.Tools[4].Type;
                nudPreheat5.Value = value.Tools[4].PreheatTime;
                nudTemp5.Value = value.Tools[4].StandbyTemperature;
                chkAutoClean5.Checked = value.Tools[4].AutoClean;
                chkTopUseOwnSettings.Checked = value.UseOwnSettings;
                chkTopGenerateSupport.Checked = value.GenerateSpecialSupport;
            }
        }
        #endregion

        #region IPC
        private bool postProcessorCalled;

        private void InitIPC()
        {
            pipeServer = new NamedPipeServerStream("Diabase.PostProcessor", PipeDirection.In, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);
            pipeServer.BeginWaitForConnection(new AsyncCallback(PipeCallback), null);
        }

        private void PipeCallback(IAsyncResult asyncResult)
        {
            pipeServer.EndWaitForConnection(asyncResult);

            StreamString ss = new StreamString(pipeServer);
            string filename = ss.ReadString();
            pipeServer.Close();

            BeginInvoke((Action)delegate ()
            {
                postProcessorCalled = true;

                // Try to set new G-Code filename
                if (awContent.CurrentPage == awpTopSide || !rbTwoSided.Checked)
                {
                    txtTopFileAdditive.Text = filename;
                }
                else if (awContent.CurrentPage == awpBottomSide)
                {
                    txtBottomFileAdditive.Text = filename;
                }
                else
                {
                    MessageBox.Show("Failed to assign G-Code Filename. Please change to either the top or bottom processing page and export your G-Code File again.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            });

            InitIPC();
        }
        #endregion

        #region Navigation
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            awContent.ClickBack();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (s3dProcess != null)
            {
                MessageBox.Show("Please close Simplify3D before you continue.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((awContent.CurrentPage == awpTopSide && !rbTwoSided.Checked) ||
                (awContent.CurrentPage == awpBottomSide))
            {
                awContent.GoToPage(awpActions);
            }
            else if (awContent.CurrentPage == awpActions)
            {
                if (this.nudModelID.Enabled && this.nudModelID.Value < 0)
                {
                    MessageBox.Show("Inner diameter has to be >= 0.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.nudModelID.Focus();
                    return;
                }
                StartPostProcessor();
            }
            else
            {
                awContent.ClickNext();
            }
        }

        private int GetToolSelection(int toolNumber)
        {
            if (SelectedMachine.Tools.Any(t => t.Number == toolNumber && t.NumHeaters > 0))
                return 1;                   // FFF tool
            if (rbAdditiveSubstractive.Checked && SelectedMachine.Tools.Any(t => t.Number == toolNumber && t.HasSpindle))
                return 2;                   // CNC tool
            return 0;                       // Not present
        }

        // Welcome page
        private void AwpWelcome_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            btnBack.Enabled = false;
            btnNext.Enabled = chkConfigureManually.Checked || lstMachine.SelectedIndex != -1;
        }

        private void LstMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = lstMachine.SelectedIndex != -1;
        }
        #endregion

        #region Machine Configuration page
        private bool IsToolSelected()
        {
            return cboTool1.SelectedIndex + cboTool2.SelectedIndex + cboTool3.SelectedIndex +
                cboTool4.SelectedIndex + cboTool5.SelectedIndex > 0;
        }

        private void AwpMachineProperties_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            btnBack.Enabled = true;
            btnNext.Enabled = IsToolSelected();

            // Allow tool selection only in manual mode
            cboTool1.Enabled = chkConfigureManually.Checked;
            cboTool2.Enabled = chkConfigureManually.Checked;
            cboTool3.Enabled = chkConfigureManually.Checked;
            cboTool4.Enabled = chkConfigureManually.Checked;
            cboTool5.Enabled = chkConfigureManually.Checked;

            // Set allowed tool options
            if (rbAdditiveSubstractive.Checked)
            {
                if (cboTool1.Items.Count == 2)
                {
                    cboTool1.Items.Add("Spindle");
                    cboTool2.Items.Add("Spindle");
                    cboTool3.Items.Add("Spindle");
                    cboTool4.Items.Add("Spindle");
                    cboTool5.Items.Add("Spindle");
                }
            }
            else
            {
                if (cboTool1.Items.Count == 3)
                {
                    cboTool1.Items.RemoveAt(2);
                    cboTool2.Items.RemoveAt(2);
                    cboTool3.Items.RemoveAt(2);
                    cboTool4.Items.RemoveAt(2);
                    cboTool5.Items.RemoveAt(2);
                }
            }

            // Attempt auto-configuration of the selected machine
            if (chkConfigureManually.Checked)
            {
                // Select some values for the tool options
                if (cboTool1.SelectedIndex == -1) { cboTool1.SelectedIndex = 0; }
                if (cboTool2.SelectedIndex == -1) { cboTool2.SelectedIndex = 0; }
                if (cboTool3.SelectedIndex == -1) { cboTool3.SelectedIndex = 0; }
                if (cboTool4.SelectedIndex == -1) { cboTool4.SelectedIndex = 0; }
                if (cboTool5.SelectedIndex == -1) { cboTool5.SelectedIndex = 0; }
            }
            else
            {
                // Check if this machine has any print heads for tools 1..5
                if (!SelectedMachine.Tools.Any(tool => tool.Number >= 1 && tool.NumHeaters <= 5 && tool.NumHeaters > 0))
                {
                    MessageBox.Show("Sorry, you cannot print with this machine because it does not have any nozzles installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if this machine has any spindles assigned to tools 1..5 if substractive mode is selected
                if (rbAdditiveSubstractive.Checked && !SelectedMachine.Tools.Any(tool => tool.Number >= 1 && tool.NumHeaters <= 5 && tool.HasSpindle))
                {
                    MessageBox.Show("Sorry, you cannot mill with this machine because it does not have any spindles installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if this machine has the A axis configured
                if (rbRotary.Checked && SelectedMachine.Axes < 5)
                {
                    MessageBox.Show("Sorry, you cannot make rotary parts with this machine because it does not have the A axis configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Set tool configurations
                cboTool1.SelectedIndex = GetToolSelection(1);
                cboTool2.SelectedIndex = GetToolSelection(2);
                cboTool3.SelectedIndex = GetToolSelection(3);
                cboTool4.SelectedIndex = GetToolSelection(4);
                cboTool5.SelectedIndex = GetToolSelection(5);
            }
        }

        private void ChkConfigureManually_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfigureManually.Checked)
            {
                btnNext.Enabled = true;
                lstMachine.Enabled = false;
            }
            else
            {
                lstMachine.Enabled = true;
                btnNext.Enabled = lstMachine.SelectedIndex != -1;
            }
        }

        private void CboTool1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTool1.Enabled = cboTool1.SelectedIndex == 1;
            btnNext.Enabled = IsToolSelected();
        }

        private void CboTool2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTool2.Enabled = cboTool2.SelectedIndex == 1;
            btnNext.Enabled = IsToolSelected();
        }

        private void CboTool3_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTool3.Enabled = cboTool3.SelectedIndex == 1;
            btnNext.Enabled = IsToolSelected();
        }

        private void CboTool4_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTool4.Enabled = cboTool4.SelectedIndex == 1;
            btnNext.Enabled = IsToolSelected();
        }

        private void CboTool5_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTool5.Enabled = cboTool5.SelectedIndex == 1;
            btnNext.Enabled = IsToolSelected();
        }
        #endregion

        #region Top Side page
        private bool TopGCodeFilesAreValid()
        {
            bool valid = File.Exists(txtTopFileAdditive.Text);
            valid &= (!rbAdditiveSubstractive.Checked || File.Exists(txtTopFileSubstractive.Text));
            return valid;
        }

        private void AwpTopSide_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            // Allow unwrapping only in rotary printing mode
            chkTopUnwrap.Enabled = rbRotary.Checked;

            // Enable slicing option only if S3D is actually installed
            gbTopSlicing.Enabled = Simplify3D.ExecutablePath != null;

            // Substractive G-Code is only needed for hybrid operations
            lblTopFileSubstractive.Enabled = rbAdditiveSubstractive.Checked;
            txtTopFileSubstractive.Enabled = rbAdditiveSubstractive.Checked;
            btnTopBrowseSubstractive.Enabled = rbAdditiveSubstractive.Checked;

            // See if we can proceed
            btnNext.Enabled = TopGCodeFilesAreValid();
        }

        private void BtnTopAddFiles_Click(object sender, EventArgs e)
        {
            if (ofdInputs.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofdInputs.FileNames)
                {
                    btnTopRemoveFiles.Enabled = true;
                    btnTopSlice.Enabled = true;

                    if (Path.GetExtension(filename).Equals(".factory", StringComparison.CurrentCultureIgnoreCase))
                    {
                        lstTopInputFiles.Items.Clear();
                        lstTopInputFiles.Items.Add(filename);
                        btnTopAddFiles.Enabled = false;
                        break;
                    }
                    else
                    {
                        lstTopInputFiles.Items.Add(filename);
                    }
                }
            }
        }

        private void BtnTopRemoveFiles_Click(object sender, EventArgs e)
        {
            if (lstTopInputFiles.SelectedIndex == -1)
            {
                lstTopInputFiles.Items.Clear();
                btnTopAddFiles.Enabled = true;
            }
            else
            {
                while (lstTopInputFiles.SelectedIndex != -1)
                {
                    lstTopInputFiles.Items.RemoveAt(lstTopInputFiles.SelectedIndex);
                }
            }

            if (lstTopInputFiles.Items.Count == 0)
            {
                lstTopInputFiles.Items.Clear();
                btnTopRemoveFiles.Enabled = false;
                btnTopSlice.Enabled = false;
            }
        }
        private void ChkTopUseOwnSettings_CheckedChanged(object sender, EventArgs e)
        {
            chkBottomUseOwnSettings.Checked = chkTopUseOwnSettings.Checked;
        }

        private void ChkTopUnwrap_CheckedChanged(object sender, EventArgs e)
        {
            chkBottomUnwrap.Checked = chkTopUnwrap.Checked;
        }

        private void ChkTopGenerateSupport_CheckedChanged(object sender, EventArgs e)
        {
            chkBottomGenerateSupport.Checked = chkTopGenerateSupport.Checked;
        }

        private void BtnTopBrowseAdditive_Click(object sender, EventArgs e)
        {
            if (ofdGCode.ShowDialog() == DialogResult.OK)
            {
                txtTopFileAdditive.Text = ofdGCode.FileName;
            }
        }

        private void BtnTopBrowseSubstractive_Click(object sender, EventArgs e)
        {
            if (ofdGCode.ShowDialog() == DialogResult.OK)
            {
                txtTopFileSubstractive.Text = ofdGCode.FileName;
            }
        }

        private void TxtTopGCodeFiles_TextChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = TopGCodeFilesAreValid();
        }
        #endregion

        #region Bottom Side page
        private bool BottomGCodeFilesAreValid()
        {
            bool valid = File.Exists(txtBottomFileAdditive.Text);
            valid &= (!rbAdditiveSubstractive.Checked || File.Exists(txtBottomFileSubstractive.Text));
            return valid;
        }

        private void AwpBottomSide_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            // Allow unwrapping only in rotary printing mode
            chkBottomUnwrap.Enabled = rbRotary.Checked;

            // Enable slicing option only if S3D is actually installed
            gbBottomSlicing.Enabled = Simplify3D.ExecutablePath != null;

            // Substractive G-Code is only needed for hybrid operations
            lblBottomFileSubstractive.Enabled = rbAdditiveSubstractive.Checked;
            txtBottomFileSubstractive.Enabled = rbAdditiveSubstractive.Checked;
            btnBottomBrowseSubstractive.Enabled = rbAdditiveSubstractive.Checked;

            // See if we can proceed
            btnNext.Enabled = BottomGCodeFilesAreValid();
        }

        private void BtnBottomAddFiles_Click(object sender, EventArgs e)
        {
            if (ofdInputs.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofdInputs.FileNames)
                {
                    if (!lstBottomInputFiles.Items.Contains(filename))
                    {
                        btnBottomRemoveFiles.Enabled = true;
                        btnBottomSlice.Enabled = true;

                        if (Path.GetExtension(filename).Equals(".factory", StringComparison.CurrentCultureIgnoreCase))
                        {
                            lstBottomInputFiles.Items.Clear();
                            lstBottomInputFiles.Items.Add(filename);
                            btnBottomAddFiles.Enabled = false;
                            break;
                        }
                        else
                        {
                            lstBottomInputFiles.Items.Add(filename);
                        }
                    }
                }
            }
        }

        private void BtnBottomRemoveFiles_Click(object sender, EventArgs e)
        {
            if (lstBottomInputFiles.SelectedIndex == -1)
            {
                lstBottomInputFiles.Items.Clear();
                btnBottomAddFiles.Enabled = true;
            }
            else
            {
                while (lstBottomInputFiles.SelectedIndex != -1)
                {
                    lstBottomInputFiles.Items.RemoveAt(lstBottomInputFiles.SelectedIndex);
                }
            }

            if (lstBottomInputFiles.Items.Count == 0)
            {
                lstBottomInputFiles.Items.Clear();
                btnBottomRemoveFiles.Enabled = false;
                btnBottomSlice.Enabled = false;
            }
        }
        private void ChkBottomUseOwnSettings_CheckedChanged(object sender, EventArgs e)
        {
            chkTopUseOwnSettings.Checked = chkBottomUseOwnSettings.Checked;
        }

        private void ChkBottomUnwrap_CheckedChanged(object sender, EventArgs e)
        {
            chkTopUnwrap.Checked = chkBottomUnwrap.Checked;
        }

        private void ChkBottomGenerateSupport_CheckedChanged(object sender, EventArgs e)
        {
            chkTopGenerateSupport.Checked = chkBottomGenerateSupport.Checked;
        }

        private void BtnBottomBrowseAdditive_Click(object sender, EventArgs e)
        {
            if (ofdGCode.ShowDialog() == DialogResult.OK)
            {
                txtBottomFileAdditive.Text = ofdGCode.FileName;
            }
        }

        private void BtnBottomBrowseSubstractive_Click(object sender, EventArgs e)
        {
            if (ofdGCode.ShowDialog() == DialogResult.OK)
            {
                txtBottomFileSubstractive.Text = ofdGCode.FileName;
            }
        }

        private void TxtBottomGCodeFiles_TextChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = BottomGCodeFilesAreValid();
        }
        #endregion

        #region Simplify3D Slicing
        private bool UseSimplifyPreset
        {
            get => (awContent.CurrentPage == awpTopSide && btnTopAddFiles.Enabled) ||
                (awContent.CurrentPage == awpBottomSide && btnBottomAddFiles.Enabled);
        }

        private void BtnSlice_Click(object sender, EventArgs e)
        {
            postProcessorCalled = false;

            if (!chkTopUseOwnSettings.Checked)
            {
                // Check if S3D is still installed
                string s3dPath = Simplify3D.ExecutablePath;
                if (s3dPath == null)
                {
                    MessageBox.Show("Simplify3D does not seem to be installed any more. If it is, please attempt to reinstall it and try again.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if S3D is still running
                if (Process.GetProcessesByName("Simplify3D").Length > 0)
                {
                    MessageBox.Show("Simplify3D is still running. Please close all other instances before you attempt to slice STL files.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Move user's current savedState.factory to savedState.factory.bak
                Simplify3D.BackupSavedState();

                if (UseSimplifyPreset)
                {
                    // Copy own factory peset to savedState.factory
                    File.Copy(Path.Combine(Directory.GetCurrentDirectory(), "preset.factory"), Simplify3D.SavedStateFile);
                }
            }

            // See if the files need to be unwrapped
            var files = (awContent.CurrentPage == awpTopSide) ? lstTopInputFiles.Items : lstBottomInputFiles.Items;
            if (UseSimplifyPreset && awContent.CurrentPage == awpTopSide ? chkTopUnwrap.Checked : chkBottomUnwrap.Checked)
            {
                foreach (string filename in files)
                {
                    string unwrappedFile = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(filename) + "-unwrapped.stl");
                    var processStartInfo = new ProcessStartInfo
                    {
                        FileName = @"VTK\warp.exe",
                        Arguments = $"\"{filename}\" \"{unwrappedFile}\" 0",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    var process = Process.Start(processStartInfo);
                    var output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    bool foundFirst = false;
                    double? zMin = null;
                    foreach (var line in output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (!line.StartsWith("zmin:"))
                        {
                            continue;
                        }
                        if (!foundFirst)
                        {
                            foundFirst = true;
                            continue;
                        }
                        var split = line.Split(new char[] { ' ' });
                        zMin = double.Parse(split[1]);
                        break;
                    }

                    if (zMin.HasValue)
                    {
                        double innerRadius = Math.Round(zMin.Value, 3);
                        if (rotaryPrintingSettings == null)
                        {
                            rotaryPrintingSettings = new RotaryPrintingSettings
                            {
                                InnerRadius = innerRadius
                            };
                        }
                        else if (innerRadius < rotaryPrintingSettings.InnerRadius)
                        {
                            rotaryPrintingSettings.InnerRadius = innerRadius;
                        }
                    }
                }
            }

            // Invoke S3D with given input files
            string parameters = "";
            foreach (string filename in files)
            {
                if (parameters != "")
                {
                    parameters += ' ';
                }

                if (UseSimplifyPreset && awContent.CurrentPage == awpTopSide ? chkTopUnwrap.Checked : chkBottomUnwrap.Checked)
                {
                    string unwrappedFile = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(filename) + "-unwrapped.stl");
                    parameters += '"' + unwrappedFile + '"';
                }
                else
                {
                    parameters += '"' + filename + '"';
                }
            }

            gbTopSlicing.Enabled = false;
            gbBottomSlicing.Enabled = false;

            ProcessStartInfo startInfo = new ProcessStartInfo(Simplify3D.ExecutablePath)
            {
                Arguments = parameters,
                UseShellExecute = false
            };
            startInfo.EnvironmentVariables["Path"] += ';' + Directory.GetCurrentDirectory();
            try
            {
                s3dProcess = Process.Start(startInfo);
                s3dProcess.EnableRaisingEvents = true;
                s3dProcess.Exited += Simplify3D_Exited;
                UseWaitCursor = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to launch Simplify3D: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Simplify3D_Exited(sender, e);
            }
        }

        private void Simplify3D_Exited(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate ()
            {
                // Reset UI
                s3dProcess = null;
                gbTopSlicing.Enabled = true;
                gbBottomSlicing.Enabled = true;

                // Ask users if they want to save the factory file
                if (UseSimplifyPreset && postProcessorCalled &&
                    MessageBox.Show("Would you like to save the Simplify3D factory file?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (sfdFactory.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.Copy(Simplify3D.SavedStateFile, sfdFactory.FileName, true);
                            Simplify3D.RestoreSavedState();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (!chkTopUseOwnSettings.Checked)
                {
                    // Restore user settings if required
                    Simplify3D.RestoreSavedState();
                }
            });
        }
        #endregion

        #region Rules


        private void AwpActions_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            this.nudModelID.Enabled = this.rbRotary.Checked && this.rotaryPrintingSettings == null;
            if (this.rotaryPrintingSettings != null)
            {
                this.nudModelID.Value = (decimal)rotaryPrintingSettings.InnerRadius;
            }
            btnBack.Enabled = true;
            btnNext.Enabled = true;
        }

        private void DgvCustomActions_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewColumn selectedColumn = dgvCustomActions.CurrentCell?.OwningColumn;
            if (selectedColumn == dgcLayer || selectedColumn == dgcRegion)
            {
                ComboBox box = (ComboBox)e.Control;
                box.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void DgvCustomActions_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgcLayer.Index || e.ColumnIndex == dgcRegion.Index)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dgvCustomActions.CurrentCell;
                if (!cell.Items.Contains(e.FormattedValue))
                {
                    DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)cell.OwningColumn;
                    column.Items.Add(e.FormattedValue);
                    cell.Value = e.FormattedValue;
                }
            }
        }

        private void DgvCustomActions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid value!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Progress page
        private void AwpProgress_PageShow(object sender, AdvancedWizardControl.EventArguments.WizardPageEventArgs e)
        {
            btnUpload.Enabled = !chkConfigureManually.Checked;
            btnUploadPrint.Enabled = !chkConfigureManually.Checked;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void StartPostProcessor()
        {
            string method = "Additive";
            string sides = "one-sided";

            FileStream topAdditiveFile;
            FileStream topSubstractiveFile = null, bottomAdditiveFile = null, bottomSubstractiveFile = null;
            FileStream outFile;

            // Open top additive file
            try
            {
                topAdditiveFile = new FileStream(txtTopFileAdditive.Text, FileMode.Open);
                pbTotal.Maximum = PostProcessor.StepsPerAdditiveFile;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to open file " + Path.GetFileName(txtTopFileAdditive.Text) + ": " + e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open top substractive file
            if (rbAdditiveSubstractive.Checked)
            {
                method = "Hybrid";

                try
                {
                    topSubstractiveFile = new FileStream(txtTopFileSubstractive.Text, FileMode.Open);
                    pbTotal.Maximum += PostProcessor.StepsPerSubstractiveFile;
                }
                catch (Exception e)
                {
                    topAdditiveFile.Close();
                    MessageBox.Show("Failed to open file " + Path.GetFileName(txtTopFileSubstractive.Text) + ": " + e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (rbTwoSided.Checked)
            {
                sides = "two-sided";

                // Open bottom additive file
                try
                {
                    bottomAdditiveFile = new FileStream(txtBottomFileAdditive.Text, FileMode.Open);
                    pbTotal.Maximum += PostProcessor.StepsPerAdditiveFile;
                }
                catch (Exception e)
                {
                    topAdditiveFile.Close();
                    topSubstractiveFile?.Close();
                    MessageBox.Show("Failed to open file " + Path.GetFileName(txtBottomFileAdditive.Text) + ": " + e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Open bottom substractive file
                if (rbAdditiveSubstractive.Checked)
                {
                    try
                    {
                        bottomSubstractiveFile = new FileStream(txtBottomFileSubstractive.Text, FileMode.Open);
                        pbTotal.Maximum += PostProcessor.StepsPerSubstractiveFile;
                    }
                    catch (Exception e)
                    {
                        topAdditiveFile.Close();
                        topSubstractiveFile?.Close();
                        bottomAdditiveFile.Close();
                        MessageBox.Show("Failed to open file " + Path.GetFileName(txtBottomFileSubstractive.Text) + ": " + e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else if (rbRotary.Checked)
            {
                sides = "rotary";
                if (rotaryPrintingSettings == null)
                {
                    rotaryPrintingSettings = new RotaryPrintingSettings
                    {
                        InnerRadius = Math.Round((double)this.nudModelID.Value / 2, 3)
                    };
                }
            }

            // Try to open a temporary file to write to and write header
            try
            {
                outFilePath = Path.GetTempFileName();
                outFile = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter sw = new StreamWriter(outFile);
                sw.WriteLine($"; Toolpath generated by Diabase Printing Wizard on {DateTime.Now}");
                sw.WriteLine($"; Manufacturing method: {method} ({sides})");
                sw.Flush();
            }
            catch (Exception e)
            {
                topAdditiveFile.Close();
                topSubstractiveFile?.Close();
                bottomAdditiveFile.Close();
                bottomSubstractiveFile?.Close();
                MessageBox.Show("Failed to create temporary file: " + e.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Go to next page
            UseWaitCursor = true;
            lblProgress.Text = "Initializing...";
            awContent.GoToPage(awpProgress);

            // Start actual post-processing
            Progress<string> textProgress = new Progress<string>(SetTextProgress);
            Progress<int> progress = new Progress<int>(SetProgress);
            Progress<int> maxProgress = new Progress<int>(SetMaxProgress);
            Progress<int> totalProgress = new Progress<int>(SetTotalProgress);
            SettingsContainer currentSettings = Settings;
            currentSettings.IslandCombining = this.cbIslandCombining.Checked;
            Duet.MachineInfo machineInfo = SelectedMachine;
            Task.Run(async () =>
            {
                await Task.Delay(250);
                postProcessingTask = PostProcessor.CreateTask(topAdditiveFile, topSubstractiveFile,
                    bottomAdditiveFile, bottomSubstractiveFile,
                    outFile, currentSettings, overrideRules, machineInfo,
                    textProgress, progress, maxProgress, totalProgress);
                try
                {
                    await postProcessingTask;
                }
                catch
                {
                    // error handling is done in the callback
                }
                Invoke((Action)PostProcessingComplete);
            });
        }

        private void SetTextProgress(string value) => lblProgress.Text = value;
        private void SetProgress(int value) => pbStep.Value = value;
        private void SetMaxProgress(int value) => pbStep.Maximum = value;
        private void SetTotalProgress(int value) => pbTotal.Value = value;

        private void PostProcessingComplete()
        {
            lblPleaseStandBy.Visible = false;
            UseWaitCursor = false;
            if (postProcessingTask.IsFaulted)
            {
                Exception exception = postProcessingTask.Exception.InnerException.InnerException;
                if (exception is ProcessorException)
                {
                    MessageBox.Show("Error: " + exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + exception, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lblProgress.Text = "Error: " + exception.Message;
                pbStep.Value = 0;
                btnBack.Enabled = true;
            }
            else
            {
                btnCancel.Text = "Exit";
                btnUpload.Visible = true;
                btnUploadPrint.Visible = true;
                btnSave.Visible = true;
                outFileSaved = false;
                SystemSounds.Beep.Play();
            }
            btnCancel.Enabled = true;

            postProcessingTask = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (sfdGCode.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(outFilePath, sfdGCode.FileName, true);
                    outFileSaved = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failed to copy output file to selected file path!\r\n\r\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string jobName;
        private bool runPrintAfterUpload;

        private void SetUploading(bool isUploading)
        {
            Cursor = isUploading ? Cursors.WaitCursor : Cursors.Default;
            btnUpload.Enabled = !isUploading;
            btnUploadPrint.Enabled = !isUploading;
            btnCancel.Enabled = !isUploading;

            if (isUploading)
            {
                frmJobName jobNameDialog = new frmJobName();
                if (jobNameDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set job name for upload target
                    jobName = jobNameDialog.txtName.Text;
                    if (!Path.HasExtension(jobName))
                    {
                        jobName = Path.ChangeExtension(jobName, ".gcode");
                    }
                }
                else
                {
                    // Cannot proceed without a proper file name
                    return;
                }

                lblProgress.Text = $"Uploading job {jobName} to {SelectedMachine.Name}...";
                pbTotal.Maximum = pbStep.Maximum = 100;
                pbTotal.Value = pbStep.Value = 0;
            }
        }

        private void UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            BeginInvoke((Action)delegate ()
            {
                pbTotal.Value = e.ProgressPercentage;
                pbStep.Value = e.ProgressPercentage;
            });
        }

        private async void DoUpload(string ipAddress)
        {
            WebClient client = new WebClient();
            client.UploadProgressChanged += UploadProgressChanged;

            try
            {
                // Perform simple POST upload
                string timeString = DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss");
                byte[] uploadBytes = File.ReadAllBytes(outFilePath);
                byte[] responseBytes = await client.UploadDataTaskAsync(new Uri($"http://{ipAddress}/rr_upload?name=0:/gcodes/{jobName}&time={timeString}"), uploadBytes);
                string responseString = System.Text.Encoding.UTF8.GetString(responseBytes);

                // See if that worked
                Duet.UploadResponse response = JsonConvert.DeserializeObject<Duet.UploadResponse>(responseString);
                if (response.Err != 0)
                {
                    throw new WebException($"The machine responded with error code {response.Err}");
                }
            }
            catch (WebException e)
            {
                // Something didn't work...
                BeginInvoke((Action)delegate
                {
                    SetUploading(false);
                    lblProgress.Text = "Error: " + e.Message;
                });
                return;
            }

            // Upload complete, check if the print needs to be started
            if (runPrintAfterUpload)
            {
                try
                {
                    HttpWebRequest request = WebRequest.CreateHttp($"http://{SelectedMachine.IPAddress}/rr_gcode?gcode=M32 \"0:/gcodes/{jobName}\"");
                    await request.GetResponseAsync();
                }
                catch (WebException e)
                {
                    MessageBox.Show($"Failed to start print after upload:\r\n{e.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Update UI
            BeginInvoke((Action)delegate
            {
                SetUploading(false);
                lblProgress.Text = "Done!";

                if (MessageBox.Show("Your upload has finished. Would you like to open the web interface now?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // OPTIONAL: If this does not work, use the IP address instead of the machine name
                    Process.Start("http://" + SelectedMachine.Name + "/");
                }

                outFileSaved = true;
                Close();
            });
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            runPrintAfterUpload = false;
            SetUploading(true);
            DoUpload(SelectedMachine.IPAddress);
        }

        private void BtnUploadPrint_Click(object sender, EventArgs e)
        {
            runPrintAfterUpload = true;
            SetUploading(true);
            DoUpload(SelectedMachine.IPAddress);
        }
        #endregion
    }
}
