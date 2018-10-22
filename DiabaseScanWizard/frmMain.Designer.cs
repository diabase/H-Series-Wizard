namespace DiabaseScanWizard
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.awContent = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.awpWelcome = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.gbScannedFile = new System.Windows.Forms.GroupBox();
            this.btnBrowseScan = new System.Windows.Forms.Button();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.gbMachine = new System.Windows.Forms.GroupBox();
            this.lstMachine = new System.Windows.Forms.ListBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.awpParameters = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.gbWidth = new System.Windows.Forms.GroupBox();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.lblParameters = new System.Windows.Forms.Label();
            this.awpScans = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.lblChooseScan = new System.Windows.Forms.Label();
            this.lvScans = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.awpProgress = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbTotal = new System.Windows.Forms.ProgressBar();
            this.pbStep = new System.Windows.Forms.ProgressBar();
            this.lblPleaseStandBy = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.ofdScan = new System.Windows.Forms.OpenFileDialog();
            this.sfdOBJ = new System.Windows.Forms.SaveFileDialog();
            this.awContent.SuspendLayout();
            this.awpWelcome.SuspendLayout();
            this.gbScannedFile.SuspendLayout();
            this.gbMachine.SuspendLayout();
            this.awpParameters.SuspendLayout();
            this.gbWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.awpScans.SuspendLayout();
            this.awpProgress.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // awContent
            // 
            this.awContent.BackButtonEnabled = true;
            this.awContent.BackButtonText = "< Back";
            this.awContent.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.awContent.ButtonsVisible = false;
            this.awContent.CancelButtonText = "&Cancel";
            this.awContent.Controls.Add(this.awpProgress);
            this.awContent.Controls.Add(this.awpParameters);
            this.awContent.Controls.Add(this.awpScans);
            this.awContent.Controls.Add(this.awpWelcome);
            this.awContent.CurrentPageIsFinishPage = false;
            this.awContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awContent.FinishButton = true;
            this.awContent.FinishButtonEnabled = true;
            this.awContent.FinishButtonText = "&Finish";
            this.awContent.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.awContent.HelpButton = false;
            this.awContent.HelpButtonText = "&Help";
            this.awContent.Location = new System.Drawing.Point(0, 0);
            this.awContent.Margin = new System.Windows.Forms.Padding(2);
            this.awContent.Name = "awContent";
            this.awContent.NextButtonEnabled = false;
            this.awContent.NextButtonText = "Next >";
            this.awContent.ProcessKeys = false;
            this.awContent.Size = new System.Drawing.Size(586, 384);
            this.awContent.TabIndex = 11;
            this.awContent.TouchScreen = true;
            this.awContent.WizardPages.Add(this.awpWelcome);
            this.awContent.WizardPages.Add(this.awpScans);
            this.awContent.WizardPages.Add(this.awpParameters);
            this.awContent.WizardPages.Add(this.awpProgress);
            // 
            // awpWelcome
            // 
            this.awpWelcome.Controls.Add(this.gbScannedFile);
            this.awpWelcome.Controls.Add(this.lblOr);
            this.awpWelcome.Controls.Add(this.gbMachine);
            this.awpWelcome.Controls.Add(this.lblDescription);
            this.awpWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpWelcome.Header = false;
            this.awpWelcome.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpWelcome.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpWelcome.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpWelcome.HeaderImage")));
            this.awpWelcome.HeaderImageVisible = true;
            this.awpWelcome.HeaderTitle = "Welcome to Advanced Wizard";
            this.awpWelcome.Location = new System.Drawing.Point(0, 0);
            this.awpWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.awpWelcome.Name = "awpWelcome";
            this.awpWelcome.PreviousPage = 0;
            this.awpWelcome.Size = new System.Drawing.Size(586, 384);
            this.awpWelcome.SubTitle = "Your page description goes here";
            this.awpWelcome.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpWelcome.TabIndex = 1;
            this.awpWelcome.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.awpWelcome_PageShow);
            // 
            // gbScannedFile
            // 
            this.gbScannedFile.Controls.Add(this.btnBrowseScan);
            this.gbScannedFile.Controls.Add(this.txtScan);
            this.gbScannedFile.Location = new System.Drawing.Point(310, 178);
            this.gbScannedFile.Margin = new System.Windows.Forms.Padding(2);
            this.gbScannedFile.Name = "gbScannedFile";
            this.gbScannedFile.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.gbScannedFile.Size = new System.Drawing.Size(264, 130);
            this.gbScannedFile.TabIndex = 28;
            this.gbScannedFile.TabStop = false;
            this.gbScannedFile.Text = "Scanned File";
            // 
            // btnBrowseScan
            // 
            this.btnBrowseScan.Location = new System.Drawing.Point(94, 75);
            this.btnBrowseScan.Name = "btnBrowseScan";
            this.btnBrowseScan.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseScan.TabIndex = 2;
            this.btnBrowseScan.Text = "Browse...";
            this.btnBrowseScan.UseVisualStyleBackColor = true;
            this.btnBrowseScan.Click += new System.EventHandler(this.btnBrowseScan_Click);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(11, 49);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(240, 20);
            this.txtScan.TabIndex = 1;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.Enter += new System.EventHandler(this.txtScannedFile_Enter);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(277, 230);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(28, 13);
            this.lblOr.TabIndex = 28;
            this.lblOr.Text = "- or -";
            // 
            // gbMachine
            // 
            this.gbMachine.Controls.Add(this.lstMachine);
            this.gbMachine.Location = new System.Drawing.Point(11, 178);
            this.gbMachine.Margin = new System.Windows.Forms.Padding(2);
            this.gbMachine.Name = "gbMachine";
            this.gbMachine.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.gbMachine.Size = new System.Drawing.Size(261, 130);
            this.gbMachine.TabIndex = 27;
            this.gbMachine.TabStop = false;
            this.gbMachine.Text = "Machine";
            // 
            // lstMachine
            // 
            this.lstMachine.Enabled = false;
            this.lstMachine.FormattingEnabled = true;
            this.lstMachine.Items.AddRange(new object[] {
            "Searching..."});
            this.lstMachine.Location = new System.Drawing.Point(9, 23);
            this.lstMachine.Margin = new System.Windows.Forms.Padding(2);
            this.lstMachine.Name = "lstMachine";
            this.lstMachine.Size = new System.Drawing.Size(243, 95);
            this.lstMachine.TabIndex = 0;
            this.lstMachine.SelectedIndexChanged += new System.EventHandler(this.lstMachine_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 110);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(474, 39);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Welcome to the Diabase Scan Wizard!\r\n\r\nPlease choose a Diabase machine or a 3D Sc" +
    "an that you downloaded before to create an STL file.";
            // 
            // awpParameters
            // 
            this.awpParameters.Controls.Add(this.gbWidth);
            this.awpParameters.Controls.Add(this.lblParameters);
            this.awpParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpParameters.Header = true;
            this.awpParameters.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpParameters.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpParameters.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpParameters.HeaderImage")));
            this.awpParameters.HeaderImageVisible = true;
            this.awpParameters.HeaderTitle = "Welcome to Advanced Wizard";
            this.awpParameters.Location = new System.Drawing.Point(0, 0);
            this.awpParameters.Name = "awpParameters";
            this.awpParameters.PreviousPage = 1;
            this.awpParameters.Size = new System.Drawing.Size(586, 384);
            this.awpParameters.SubTitle = "Your page description goes here";
            this.awpParameters.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpParameters.TabIndex = 5;
            this.awpParameters.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.awpParameters_PageShow);
            // 
            // gbWidth
            // 
            this.gbWidth.Controls.Add(this.tbWidth);
            this.gbWidth.Location = new System.Drawing.Point(14, 138);
            this.gbWidth.Name = "gbWidth";
            this.gbWidth.Size = new System.Drawing.Size(280, 71);
            this.gbWidth.TabIndex = 2;
            this.gbWidth.TabStop = false;
            this.gbWidth.Text = "Resolution (Width)";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(6, 22);
            this.tbWidth.Maximum = 250;
            this.tbWidth.Minimum = 50;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(268, 45);
            this.tbWidth.TabIndex = 0;
            this.tbWidth.TickFrequency = 50;
            this.tbWidth.Value = 50;
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(12, 110);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(276, 13);
            this.lblParameters.TabIndex = 1;
            this.lblParameters.Text = "Please choose your Parameters for the Scan Conversion:";
            // 
            // awpScans
            // 
            this.awpScans.Controls.Add(this.lblChooseScan);
            this.awpScans.Controls.Add(this.lvScans);
            this.awpScans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpScans.Header = false;
            this.awpScans.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpScans.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpScans.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpScans.HeaderImage")));
            this.awpScans.HeaderImageVisible = true;
            this.awpScans.HeaderTitle = "Post Processing";
            this.awpScans.Location = new System.Drawing.Point(0, 0);
            this.awpScans.Margin = new System.Windows.Forms.Padding(2);
            this.awpScans.Name = "awpScans";
            this.awpScans.PreviousPage = 0;
            this.awpScans.Size = new System.Drawing.Size(586, 384);
            this.awpScans.SubTitle = "Your page description goes here";
            this.awpScans.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpScans.TabIndex = 2;
            this.awpScans.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.awpScans_PageShow);
            // 
            // lblChooseScan
            // 
            this.lblChooseScan.AutoSize = true;
            this.lblChooseScan.Location = new System.Drawing.Point(7, 107);
            this.lblChooseScan.Name = "lblChooseScan";
            this.lblChooseScan.Size = new System.Drawing.Size(287, 13);
            this.lblChooseScan.TabIndex = 2;
            this.lblChooseScan.Text = "Choose a 3D Scan that you want to convert to an STL File:";
            // 
            // lvScans
            // 
            this.lvScans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSize,
            this.chDateCreated});
            this.lvScans.FullRowSelect = true;
            this.lvScans.Location = new System.Drawing.Point(11, 123);
            this.lvScans.MultiSelect = false;
            this.lvScans.Name = "lvScans";
            this.lvScans.Size = new System.Drawing.Size(563, 197);
            this.lvScans.TabIndex = 1;
            this.lvScans.UseCompatibleStateImageBehavior = false;
            this.lvScans.View = System.Windows.Forms.View.Details;
            this.lvScans.SelectedIndexChanged += new System.EventHandler(this.lvScans_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 205;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.Width = 100;
            // 
            // chDateCreated
            // 
            this.chDateCreated.Text = "Date Created";
            this.chDateCreated.Width = 225;
            // 
            // awpProgress
            // 
            this.awpProgress.Controls.Add(this.btnSave);
            this.awpProgress.Controls.Add(this.pnlProgress);
            this.awpProgress.Controls.Add(this.lblPleaseStandBy);
            this.awpProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpProgress.Header = true;
            this.awpProgress.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpProgress.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpProgress.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpProgress.HeaderImage")));
            this.awpProgress.HeaderImageVisible = true;
            this.awpProgress.HeaderTitle = "Welcome to Advanced Wizard";
            this.awpProgress.Location = new System.Drawing.Point(0, 0);
            this.awpProgress.Margin = new System.Windows.Forms.Padding(2);
            this.awpProgress.Name = "awpProgress";
            this.awpProgress.PreviousPage = 2;
            this.awpProgress.Size = new System.Drawing.Size(586, 384);
            this.awpProgress.SubTitle = "Your page description goes here";
            this.awpProgress.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpProgress.TabIndex = 4;
            this.awpProgress.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.awpProgress_PageShow);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(220, 252);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save OBJ File";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlProgress
            // 
            this.pnlProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgress.Controls.Add(this.lblProgress);
            this.pnlProgress.Controls.Add(this.pbTotal);
            this.pnlProgress.Controls.Add(this.pbStep);
            this.pnlProgress.Location = new System.Drawing.Point(22, 148);
            this.pnlProgress.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(543, 94);
            this.pnlProgress.TabIndex = 4;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(10, 11);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(61, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Initializing...";
            // 
            // pbTotal
            // 
            this.pbTotal.Location = new System.Drawing.Point(12, 60);
            this.pbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.pbTotal.Name = "pbTotal";
            this.pbTotal.Size = new System.Drawing.Size(514, 19);
            this.pbTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTotal.TabIndex = 4;
            // 
            // pbStep
            // 
            this.pbStep.Location = new System.Drawing.Point(12, 31);
            this.pbStep.Margin = new System.Windows.Forms.Padding(2);
            this.pbStep.Name = "pbStep";
            this.pbStep.Size = new System.Drawing.Size(514, 19);
            this.pbStep.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbStep.TabIndex = 3;
            // 
            // lblPleaseStandBy
            // 
            this.lblPleaseStandBy.AutoSize = true;
            this.lblPleaseStandBy.Location = new System.Drawing.Point(20, 120);
            this.lblPleaseStandBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPleaseStandBy.Name = "lblPleaseStandBy";
            this.lblPleaseStandBy.Size = new System.Drawing.Size(274, 13);
            this.lblPleaseStandBy.TabIndex = 3;
            this.lblPleaseStandBy.Text = "Please stand by while your 3D scan is being converted...";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Image = global::DiabaseScanWizard.Properties.Resources.Forward_16x;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(491, 8);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 32);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "&Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Enabled = false;
            this.btnBack.Image = global::DiabaseScanWizard.Properties.Resources.Backward_16x;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(400, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::DiabaseScanWizard.Properties.Resources.Exit_16x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(9, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnBack);
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 335);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(586, 49);
            this.pnlButtons.TabIndex = 12;
            // 
            // pbBanner
            // 
            this.pbBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBanner.Image = global::DiabaseScanWizard.Properties.Resources.LogoOnLeftforBlackBackgorund;
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(586, 98);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 20;
            this.pbBanner.TabStop = false;
            // 
            // ofdScan
            // 
            this.ofdScan.Filter = "3D-Scans (*.ply)|*.ply;|All Files (*.*)|*.*";
            this.ofdScan.RestoreDirectory = true;
            this.ofdScan.Title = "Select STL file...";
            // 
            // sfdOBJ
            // 
            this.sfdOBJ.Filter = "OBJ Files (*.obj)|*.obj|All Files (*.*)|*.*";
            this.sfdOBJ.RestoreDirectory = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(586, 384);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.awContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diabase Scan Wizard";
            this.awContent.ResumeLayout(false);
            this.awpWelcome.ResumeLayout(false);
            this.awpWelcome.PerformLayout();
            this.gbScannedFile.ResumeLayout(false);
            this.gbScannedFile.PerformLayout();
            this.gbMachine.ResumeLayout(false);
            this.awpParameters.ResumeLayout(false);
            this.awpParameters.PerformLayout();
            this.gbWidth.ResumeLayout(false);
            this.gbWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.awpScans.ResumeLayout(false);
            this.awpScans.PerformLayout();
            this.awpProgress.ResumeLayout(false);
            this.awpProgress.PerformLayout();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard awContent;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpWelcome;
        private System.Windows.Forms.Label lblDescription;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpScans;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.OpenFileDialog ofdScan;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpProgress;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbTotal;
        private System.Windows.Forms.ProgressBar pbStep;
        private System.Windows.Forms.Label lblPleaseStandBy;
        private System.Windows.Forms.SaveFileDialog sfdOBJ;
        private System.Windows.Forms.ListView lvScans;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chDateCreated;
        private System.Windows.Forms.GroupBox gbMachine;
        private System.Windows.Forms.ListBox lstMachine;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.GroupBox gbScannedFile;
        private System.Windows.Forms.Button btnBrowseScan;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblChooseScan;
        private System.Windows.Forms.Button btnSave;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpParameters;
        private System.Windows.Forms.GroupBox gbWidth;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.Label lblParameters;
    }
}

