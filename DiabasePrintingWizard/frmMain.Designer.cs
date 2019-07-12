namespace DiabasePrintingWizard
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.awContent = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.awpWelcome = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.lblVersion = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbAdditiveSubstractive = new System.Windows.Forms.RadioButton();
            this.rbAdditive = new System.Windows.Forms.RadioButton();
            this.gbMachine = new System.Windows.Forms.GroupBox();
            this.lstMachine = new System.Windows.Forms.ListBox();
            this.chkConfigureManually = new System.Windows.Forms.CheckBox();
            this.gbGeometry = new System.Windows.Forms.GroupBox();
            this.rbRotary = new System.Windows.Forms.RadioButton();
            this.rbTwoSided = new System.Windows.Forms.RadioButton();
            this.rbOneSided = new System.Windows.Forms.RadioButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.awpActions = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.gbIDRotaryPrinting = new System.Windows.Forms.GroupBox();
            this.nudModelID = new System.Windows.Forms.NumericUpDown();
            this.gbIslandCombining = new System.Windows.Forms.GroupBox();
            this.cbIslandCombining = new System.Windows.Forms.CheckBox();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.dgvCustomActions = new System.Windows.Forms.DataGridView();
            this.dgcTool = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcLayer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcRegion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcSpeedFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcExtrusionFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awpTopSide = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.gbTopFiles = new System.Windows.Forms.GroupBox();
            this.btnTopBrowseSubstractive = new System.Windows.Forms.Button();
            this.btnTopBrowseAdditive = new System.Windows.Forms.Button();
            this.txtTopFileSubstractive = new System.Windows.Forms.TextBox();
            this.lblTopFileSubstractive = new System.Windows.Forms.Label();
            this.txtTopFileAdditive = new System.Windows.Forms.TextBox();
            this.lblTopFileAdditive = new System.Windows.Forms.Label();
            this.gbTopSlicing = new System.Windows.Forms.GroupBox();
            this.chkTopGenerateSupport = new System.Windows.Forms.CheckBox();
            this.btnTopSlice = new System.Windows.Forms.Button();
            this.tlpTopFileButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnTopRemoveFiles = new System.Windows.Forms.Button();
            this.btnTopAddFiles = new System.Windows.Forms.Button();
            this.lstTopInputFiles = new System.Windows.Forms.ListBox();
            this.chkTopUseOwnSettings = new System.Windows.Forms.CheckBox();
            this.chkTopUnwrap = new System.Windows.Forms.CheckBox();
            this.lblTopInputFiles = new System.Windows.Forms.Label();
            this.awpBottomSide = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.gbBottomFiles = new System.Windows.Forms.GroupBox();
            this.btnBottomBrowseSubstractive = new System.Windows.Forms.Button();
            this.btnBottomBrowseAdditive = new System.Windows.Forms.Button();
            this.txtBottomFileSubstractive = new System.Windows.Forms.TextBox();
            this.lblBottomFileSubstractive = new System.Windows.Forms.Label();
            this.txtBottomFileAdditive = new System.Windows.Forms.TextBox();
            this.lblBottomFileAdditive = new System.Windows.Forms.Label();
            this.gbBottomSlicing = new System.Windows.Forms.GroupBox();
            this.chkBottomGenerateSupport = new System.Windows.Forms.CheckBox();
            this.btnBottomSlice = new System.Windows.Forms.Button();
            this.tlpBottomFileButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnBottomRemoveFiles = new System.Windows.Forms.Button();
            this.btnBottomAddFiles = new System.Windows.Forms.Button();
            this.lstBottomInputFiles = new System.Windows.Forms.ListBox();
            this.chkBottomUseOwnSettings = new System.Windows.Forms.CheckBox();
            this.chkBottomUnwrap = new System.Windows.Forms.CheckBox();
            this.lblBottomFiles = new System.Windows.Forms.Label();
            this.awpMachineProperties = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tlpHeads = new System.Windows.Forms.TableLayoutPanel();
            this.cboTool1 = new System.Windows.Forms.ComboBox();
            this.gbTool3 = new System.Windows.Forms.GroupBox();
            this.lblS1 = new System.Windows.Forms.Label();
            this.nudPreheat3 = new System.Windows.Forms.NumericUpDown();
            this.lblPreheat3 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.chkAutoClean3 = new System.Windows.Forms.CheckBox();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.nudTemp3 = new System.Windows.Forms.NumericUpDown();
            this.cboTool2 = new System.Windows.Forms.ComboBox();
            this.gbTool5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudPreheat5 = new System.Windows.Forms.NumericUpDown();
            this.lblPreheat5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkAutoClean5 = new System.Windows.Forms.CheckBox();
            this.lblTemp5 = new System.Windows.Forms.Label();
            this.nudTemp5 = new System.Windows.Forms.NumericUpDown();
            this.cboTool3 = new System.Windows.Forms.ComboBox();
            this.gbTool4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudPreheat4 = new System.Windows.Forms.NumericUpDown();
            this.lblPreheat4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkAutoClean4 = new System.Windows.Forms.CheckBox();
            this.lblTemp4 = new System.Windows.Forms.Label();
            this.nudTemp4 = new System.Windows.Forms.NumericUpDown();
            this.cboTool4 = new System.Windows.Forms.ComboBox();
            this.gbTool1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPreheat1 = new System.Windows.Forms.NumericUpDown();
            this.lblPreheat1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAutoClean1 = new System.Windows.Forms.CheckBox();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.nudTemp1 = new System.Windows.Forms.NumericUpDown();
            this.cboTool5 = new System.Windows.Forms.ComboBox();
            this.gbTool2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPreheat2 = new System.Windows.Forms.NumericUpDown();
            this.lblPreheat2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAutoClean2 = new System.Windows.Forms.CheckBox();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.nudTemp2 = new System.Windows.Forms.NumericUpDown();
            this.awpProgress = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.btnUploadPrint = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
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
            this.ofdInputs = new System.Windows.Forms.OpenFileDialog();
            this.ofdGCode = new System.Windows.Forms.OpenFileDialog();
            this.sfdGCode = new System.Windows.Forms.SaveFileDialog();
            this.sfdFactory = new System.Windows.Forms.SaveFileDialog();
            this.awContent.SuspendLayout();
            this.awpWelcome.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbMachine.SuspendLayout();
            this.gbGeometry.SuspendLayout();
            this.awpActions.SuspendLayout();
            this.gbIDRotaryPrinting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelID)).BeginInit();
            this.gbIslandCombining.SuspendLayout();
            this.gbRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomActions)).BeginInit();
            this.awpTopSide.SuspendLayout();
            this.gbTopFiles.SuspendLayout();
            this.gbTopSlicing.SuspendLayout();
            this.tlpTopFileButtons.SuspendLayout();
            this.awpBottomSide.SuspendLayout();
            this.gbBottomFiles.SuspendLayout();
            this.gbBottomSlicing.SuspendLayout();
            this.tlpBottomFileButtons.SuspendLayout();
            this.awpMachineProperties.SuspendLayout();
            this.tlpHeads.SuspendLayout();
            this.gbTool3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp3)).BeginInit();
            this.gbTool5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp5)).BeginInit();
            this.gbTool4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp4)).BeginInit();
            this.gbTool1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp1)).BeginInit();
            this.gbTool2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp2)).BeginInit();
            this.awpProgress.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // awContent
            // 
            this.awContent.BackButtonEnabled = false;
            this.awContent.BackButtonText = "< Back";
            this.awContent.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.awContent.ButtonsVisible = false;
            this.awContent.CancelButtonText = "&Cancel";
            this.awContent.Controls.Add(this.awpWelcome);
            this.awContent.Controls.Add(this.awpActions);
            this.awContent.Controls.Add(this.awpTopSide);
            this.awContent.Controls.Add(this.awpBottomSide);
            this.awContent.Controls.Add(this.awpMachineProperties);
            this.awContent.Controls.Add(this.awpProgress);
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
            this.awContent.NextButtonEnabled = true;
            this.awContent.NextButtonText = "Next >";
            this.awContent.ProcessKeys = false;
            this.awContent.Size = new System.Drawing.Size(586, 384);
            this.awContent.TabIndex = 11;
            this.awContent.TouchScreen = true;
            this.awContent.WizardPages.Add(this.awpWelcome);
            this.awContent.WizardPages.Add(this.awpMachineProperties);
            this.awContent.WizardPages.Add(this.awpTopSide);
            this.awContent.WizardPages.Add(this.awpBottomSide);
            this.awContent.WizardPages.Add(this.awpActions);
            this.awContent.WizardPages.Add(this.awpProgress);
            // 
            // awpWelcome
            // 
            this.awpWelcome.Controls.Add(this.lblVersion);
            this.awpWelcome.Controls.Add(this.gbType);
            this.awpWelcome.Controls.Add(this.gbMachine);
            this.awpWelcome.Controls.Add(this.gbGeometry);
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
            this.awpWelcome.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.AwpWelcome_PageShow);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = false;
            this.lblVersion.Location = new System.Drawing.Point(471, 106);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 13);
            this.lblVersion.TabIndex = 30;
            this.lblVersion.Text = "vDEV";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbAdditiveSubstractive);
            this.gbType.Controls.Add(this.rbAdditive);
            this.gbType.Location = new System.Drawing.Point(376, 178);
            this.gbType.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.gbType.Name = "gbType";
            this.gbType.Padding = new System.Windows.Forms.Padding(2);
            this.gbType.Size = new System.Drawing.Size(197, 123);
            this.gbType.TabIndex = 29;
            this.gbType.TabStop = false;
            this.gbType.Text = "Manufacturing Type";
            // 
            // rbAdditiveSubstractive
            // 
            this.rbAdditiveSubstractive.AutoSize = true;
            this.rbAdditiveSubstractive.Location = new System.Drawing.Point(17, 67);
            this.rbAdditiveSubstractive.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdditiveSubstractive.Name = "rbAdditiveSubstractive";
            this.rbAdditiveSubstractive.Size = new System.Drawing.Size(134, 30);
            this.rbAdditiveSubstractive.TabIndex = 9;
            this.rbAdditiveSubstractive.Text = "Additive + Substractive\r\nManufacturing";
            this.rbAdditiveSubstractive.UseVisualStyleBackColor = true;
            // 
            // rbAdditive
            // 
            this.rbAdditive.AutoSize = true;
            this.rbAdditive.Checked = true;
            this.rbAdditive.Location = new System.Drawing.Point(17, 33);
            this.rbAdditive.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdditive.Name = "rbAdditive";
            this.rbAdditive.Size = new System.Drawing.Size(160, 17);
            this.rbAdditive.TabIndex = 8;
            this.rbAdditive.TabStop = true;
            this.rbAdditive.Text = "Standard Print (additive only)";
            this.rbAdditive.UseVisualStyleBackColor = true;
            // 
            // gbMachine
            // 
            this.gbMachine.Controls.Add(this.lstMachine);
            this.gbMachine.Controls.Add(this.chkConfigureManually);
            this.gbMachine.Location = new System.Drawing.Point(11, 178);
            this.gbMachine.Margin = new System.Windows.Forms.Padding(2);
            this.gbMachine.Name = "gbMachine";
            this.gbMachine.Padding = new System.Windows.Forms.Padding(7, 5, 7, 7);
            this.gbMachine.Size = new System.Drawing.Size(220, 123);
            this.gbMachine.TabIndex = 26;
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
            this.lstMachine.Size = new System.Drawing.Size(201, 69);
            this.lstMachine.TabIndex = 25;
            this.lstMachine.SelectedIndexChanged += new System.EventHandler(this.LstMachine_SelectedIndexChanged);
            // 
            // chkConfigureManually
            // 
            this.chkConfigureManually.AutoSize = true;
            this.chkConfigureManually.Location = new System.Drawing.Point(9, 96);
            this.chkConfigureManually.Margin = new System.Windows.Forms.Padding(2);
            this.chkConfigureManually.Name = "chkConfigureManually";
            this.chkConfigureManually.Size = new System.Drawing.Size(115, 17);
            this.chkConfigureManually.TabIndex = 26;
            this.chkConfigureManually.Text = "Configure manually";
            this.chkConfigureManually.UseVisualStyleBackColor = true;
            this.chkConfigureManually.CheckedChanged += new System.EventHandler(this.ChkConfigureManually_CheckedChanged);
            // 
            // gbGeometry
            // 
            this.gbGeometry.Controls.Add(this.rbRotary);
            this.gbGeometry.Controls.Add(this.rbTwoSided);
            this.gbGeometry.Controls.Add(this.rbOneSided);
            this.gbGeometry.Location = new System.Drawing.Point(241, 178);
            this.gbGeometry.Margin = new System.Windows.Forms.Padding(2);
            this.gbGeometry.Name = "gbGeometry";
            this.gbGeometry.Padding = new System.Windows.Forms.Padding(2);
            this.gbGeometry.Size = new System.Drawing.Size(126, 123);
            this.gbGeometry.TabIndex = 28;
            this.gbGeometry.TabStop = false;
            this.gbGeometry.Text = "Geometry";
            // 
            // rbRotary
            // 
            this.rbRotary.AutoSize = true;
            this.rbRotary.Location = new System.Drawing.Point(20, 84);
            this.rbRotary.Margin = new System.Windows.Forms.Padding(2);
            this.rbRotary.Name = "rbRotary";
            this.rbRotary.Size = new System.Drawing.Size(56, 17);
            this.rbRotary.TabIndex = 2;
            this.rbRotary.Text = "Rotary";
            this.rbRotary.UseVisualStyleBackColor = true;
            // 
            // rbTwoSided
            // 
            this.rbTwoSided.AutoSize = true;
            this.rbTwoSided.Location = new System.Drawing.Point(20, 56);
            this.rbTwoSided.Margin = new System.Windows.Forms.Padding(2);
            this.rbTwoSided.Name = "rbTwoSided";
            this.rbTwoSided.Size = new System.Drawing.Size(76, 17);
            this.rbTwoSided.TabIndex = 1;
            this.rbTwoSided.Text = "Two-Sided";
            this.rbTwoSided.UseVisualStyleBackColor = true;
            // 
            // rbOneSided
            // 
            this.rbOneSided.AutoSize = true;
            this.rbOneSided.Checked = true;
            this.rbOneSided.Location = new System.Drawing.Point(20, 27);
            this.rbOneSided.Margin = new System.Windows.Forms.Padding(2);
            this.rbOneSided.Name = "rbOneSided";
            this.rbOneSided.Size = new System.Drawing.Size(75, 17);
            this.rbOneSided.TabIndex = 0;
            this.rbOneSided.TabStop = true;
            this.rbOneSided.Text = "One-Sided";
            this.rbOneSided.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 110);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(450, 39);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Welcome to the Diabase toolpath generation wizard!\r\n\r\nPlease follow these instruc" +
    "tions to generate a new toolpath for a working piece of your choice.";
            // 
            // awpActions
            // 
            this.awpActions.Controls.Add(this.gbIDRotaryPrinting);
            this.awpActions.Controls.Add(this.gbIslandCombining);
            this.awpActions.Controls.Add(this.gbRules);
            this.awpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpActions.Header = true;
            this.awpActions.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpActions.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpActions.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpActions.HeaderImage")));
            this.awpActions.HeaderImageVisible = true;
            this.awpActions.HeaderTitle = "Welcome to Advanced Wizard";
            this.awpActions.Location = new System.Drawing.Point(0, 0);
            this.awpActions.Name = "awpActions";
            this.awpActions.PreviousPage = 0;
            this.awpActions.Size = new System.Drawing.Size(586, 384);
            this.awpActions.SubTitle = "Your page description goes here";
            this.awpActions.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpActions.TabIndex = 5;
            this.awpActions.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.AwpActions_PageShow);
            // 
            // gbIDRotaryPrinting
            // 
            this.gbIDRotaryPrinting.Controls.Add(this.nudModelID);
            this.gbIDRotaryPrinting.Location = new System.Drawing.Point(293, 284);
            this.gbIDRotaryPrinting.Name = "gbIDRotaryPrinting";
            this.gbIDRotaryPrinting.Size = new System.Drawing.Size(282, 41);
            this.gbIDRotaryPrinting.TabIndex = 0;
            this.gbIDRotaryPrinting.TabStop = false;
            this.gbIDRotaryPrinting.Text = "Inner Diameter of Model (in mm)";
            // 
            // nudModelID
            // 
            this.nudModelID.DecimalPlaces = 3;
            this.nudModelID.Location = new System.Drawing.Point(11, 16);
            this.nudModelID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudModelID.Name = "nudModelID";
            this.nudModelID.Size = new System.Drawing.Size(120, 20);
            this.nudModelID.TabIndex = 1;
            this.nudModelID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudModelID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // gbIslandCombining
            // 
            this.gbIslandCombining.Controls.Add(this.cbIslandCombining);
            this.gbIslandCombining.Location = new System.Drawing.Point(8, 284);
            this.gbIslandCombining.Name = "gbIslandCombining";
            this.gbIslandCombining.Size = new System.Drawing.Size(279, 41);
            this.gbIslandCombining.TabIndex = 22;
            this.gbIslandCombining.TabStop = false;
            this.gbIslandCombining.Text = "Tool Change Reduction";
            // 
            // cbIslandCombining
            // 
            this.cbIslandCombining.AutoSize = true;
            this.cbIslandCombining.Checked = true;
            this.cbIslandCombining.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIslandCombining.Location = new System.Drawing.Point(8, 17);
            this.cbIslandCombining.Name = "cbIslandCombining";
            this.cbIslandCombining.Size = new System.Drawing.Size(239, 17);
            this.cbIslandCombining.TabIndex = 0;
            this.cbIslandCombining.Text = "Enable combining of tool segements per layer";
            this.cbIslandCombining.UseVisualStyleBackColor = true;
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.dgvCustomActions);
            this.gbRules.Location = new System.Drawing.Point(8, 108);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(566, 167);
            this.gbRules.TabIndex = 21;
            this.gbRules.TabStop = false;
            this.gbRules.Text = "Overridden Parameters for Specific Print Regions:";
            // 
            // dgvCustomActions
            // 
            this.dgvCustomActions.AllowUserToResizeRows = false;
            this.dgvCustomActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcTool,
            this.dgcLayer,
            this.dgcRegion,
            this.dgcSpeedFactor,
            this.dgcExtrusionFactor});
            this.dgvCustomActions.Location = new System.Drawing.Point(8, 19);
            this.dgvCustomActions.MultiSelect = false;
            this.dgvCustomActions.Name = "dgvCustomActions";
            this.dgvCustomActions.Size = new System.Drawing.Size(554, 139);
            this.dgvCustomActions.TabIndex = 2;
            // 
            // dgcTool
            // 
            this.dgcTool.DataPropertyName = "Tool";
            this.dgcTool.HeaderText = "Tool";
            this.dgcTool.Items.AddRange(new object[] {
            "Any",
            "Tool 1",
            "Tool 2",
            "Tool 3",
            "Tool 4",
            "Tool 5"});
            this.dgcTool.Name = "dgcTool";
            this.dgcTool.Width = 65;
            // 
            // dgcLayer
            // 
            this.dgcLayer.DataPropertyName = "Layer";
            this.dgcLayer.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgcLayer.HeaderText = "Layer";
            this.dgcLayer.Items.AddRange(new object[] {
            "Any"});
            this.dgcLayer.Name = "dgcLayer";
            this.dgcLayer.Width = 65;
            // 
            // dgcRegion
            // 
            this.dgcRegion.DataPropertyName = "Region";
            this.dgcRegion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgcRegion.HeaderText = "Print Region";
            this.dgcRegion.Items.AddRange(new object[] {
            "Any",
            "Skirt",
            "Inner Perimeter",
            "Outer Perimeter",
            "Solid Layer",
            "Infill",
            "Internal Single Extrusion",
            "Bridge",
            "Material Intersection"});
            this.dgcRegion.Name = "dgcRegion";
            this.dgcRegion.Width = 125;
            // 
            // dgcSpeedFactor
            // 
            this.dgcSpeedFactor.DataPropertyName = "SpeedFactor";
            this.dgcSpeedFactor.HeaderText = "Speed Factor (%)";
            this.dgcSpeedFactor.Name = "dgcSpeedFactor";
            this.dgcSpeedFactor.Width = 115;
            // 
            // dgcExtrusionFactor
            // 
            this.dgcExtrusionFactor.DataPropertyName = "ExtrusionFactor";
            this.dgcExtrusionFactor.HeaderText = "Extrusion Factor (%)";
            this.dgcExtrusionFactor.Name = "dgcExtrusionFactor";
            this.dgcExtrusionFactor.Width = 130;
            // 
            // awpTopSide
            // 
            this.awpTopSide.Controls.Add(this.gbTopFiles);
            this.awpTopSide.Controls.Add(this.gbTopSlicing);
            this.awpTopSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpTopSide.Header = true;
            this.awpTopSide.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpTopSide.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpTopSide.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpTopSide.HeaderImage")));
            this.awpTopSide.HeaderImageVisible = true;
            this.awpTopSide.HeaderTitle = "Welcome to Advanced Wizard";
            this.awpTopSide.Location = new System.Drawing.Point(0, 0);
            this.awpTopSide.Margin = new System.Windows.Forms.Padding(2);
            this.awpTopSide.Name = "awpTopSide";
            this.awpTopSide.PreviousPage = 0;
            this.awpTopSide.Size = new System.Drawing.Size(586, 384);
            this.awpTopSide.SubTitle = "Your page description goes here";
            this.awpTopSide.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpTopSide.TabIndex = 3;
            this.awpTopSide.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.AwpTopSide_PageShow);
            // 
            // gbTopFiles
            // 
            this.gbTopFiles.Controls.Add(this.btnTopBrowseSubstractive);
            this.gbTopFiles.Controls.Add(this.btnTopBrowseAdditive);
            this.gbTopFiles.Controls.Add(this.txtTopFileSubstractive);
            this.gbTopFiles.Controls.Add(this.lblTopFileSubstractive);
            this.gbTopFiles.Controls.Add(this.txtTopFileAdditive);
            this.gbTopFiles.Controls.Add(this.lblTopFileAdditive);
            this.gbTopFiles.Location = new System.Drawing.Point(13, 258);
            this.gbTopFiles.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.gbTopFiles.Name = "gbTopFiles";
            this.gbTopFiles.Padding = new System.Windows.Forms.Padding(2);
            this.gbTopFiles.Size = new System.Drawing.Size(562, 67);
            this.gbTopFiles.TabIndex = 15;
            this.gbTopFiles.TabStop = false;
            this.gbTopFiles.Text = "Manufacturing Files for the Top Side";
            // 
            // btnTopBrowseSubstractive
            // 
            this.btnTopBrowseSubstractive.Location = new System.Drawing.Point(522, 37);
            this.btnTopBrowseSubstractive.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopBrowseSubstractive.Name = "btnTopBrowseSubstractive";
            this.btnTopBrowseSubstractive.Size = new System.Drawing.Size(32, 22);
            this.btnTopBrowseSubstractive.TabIndex = 16;
            this.btnTopBrowseSubstractive.Text = "...";
            this.btnTopBrowseSubstractive.UseVisualStyleBackColor = true;
            this.btnTopBrowseSubstractive.Click += new System.EventHandler(this.BtnTopBrowseSubstractive_Click);
            // 
            // btnTopBrowseAdditive
            // 
            this.btnTopBrowseAdditive.Location = new System.Drawing.Point(242, 37);
            this.btnTopBrowseAdditive.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopBrowseAdditive.Name = "btnTopBrowseAdditive";
            this.btnTopBrowseAdditive.Size = new System.Drawing.Size(32, 22);
            this.btnTopBrowseAdditive.TabIndex = 15;
            this.btnTopBrowseAdditive.Text = "...";
            this.btnTopBrowseAdditive.UseVisualStyleBackColor = true;
            this.btnTopBrowseAdditive.Click += new System.EventHandler(this.BtnTopBrowseAdditive_Click);
            // 
            // txtTopFileSubstractive
            // 
            this.txtTopFileSubstractive.Location = new System.Drawing.Point(290, 38);
            this.txtTopFileSubstractive.Margin = new System.Windows.Forms.Padding(2);
            this.txtTopFileSubstractive.Name = "txtTopFileSubstractive";
            this.txtTopFileSubstractive.Size = new System.Drawing.Size(229, 20);
            this.txtTopFileSubstractive.TabIndex = 14;
            this.txtTopFileSubstractive.TextChanged += new System.EventHandler(this.TxtTopGCodeFiles_TextChanged);
            // 
            // lblTopFileSubstractive
            // 
            this.lblTopFileSubstractive.AutoSize = true;
            this.lblTopFileSubstractive.Location = new System.Drawing.Point(288, 19);
            this.lblTopFileSubstractive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopFileSubstractive.Name = "lblTopFileSubstractive";
            this.lblTopFileSubstractive.Size = new System.Drawing.Size(197, 13);
            this.lblTopFileSubstractive.TabIndex = 13;
            this.lblTopFileSubstractive.Text = "G-Code File for Substractive Processing:";
            // 
            // txtTopFileAdditive
            // 
            this.txtTopFileAdditive.Location = new System.Drawing.Point(10, 38);
            this.txtTopFileAdditive.Margin = new System.Windows.Forms.Padding(2);
            this.txtTopFileAdditive.Name = "txtTopFileAdditive";
            this.txtTopFileAdditive.Size = new System.Drawing.Size(229, 20);
            this.txtTopFileAdditive.TabIndex = 12;
            this.txtTopFileAdditive.TextChanged += new System.EventHandler(this.TxtTopGCodeFiles_TextChanged);
            // 
            // lblTopFileAdditive
            // 
            this.lblTopFileAdditive.AutoSize = true;
            this.lblTopFileAdditive.Location = new System.Drawing.Point(8, 19);
            this.lblTopFileAdditive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopFileAdditive.Name = "lblTopFileAdditive";
            this.lblTopFileAdditive.Size = new System.Drawing.Size(176, 13);
            this.lblTopFileAdditive.TabIndex = 11;
            this.lblTopFileAdditive.Text = "G-Code File for Additive Processing:";
            // 
            // gbTopSlicing
            // 
            this.gbTopSlicing.Controls.Add(this.chkTopGenerateSupport);
            this.gbTopSlicing.Controls.Add(this.btnTopSlice);
            this.gbTopSlicing.Controls.Add(this.tlpTopFileButtons);
            this.gbTopSlicing.Controls.Add(this.lstTopInputFiles);
            this.gbTopSlicing.Controls.Add(this.chkTopUseOwnSettings);
            this.gbTopSlicing.Controls.Add(this.chkTopUnwrap);
            this.gbTopSlicing.Controls.Add(this.lblTopInputFiles);
            this.gbTopSlicing.Location = new System.Drawing.Point(13, 106);
            this.gbTopSlicing.Margin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.gbTopSlicing.Name = "gbTopSlicing";
            this.gbTopSlicing.Padding = new System.Windows.Forms.Padding(2);
            this.gbTopSlicing.Size = new System.Drawing.Size(562, 142);
            this.gbTopSlicing.TabIndex = 14;
            this.gbTopSlicing.TabStop = false;
            this.gbTopSlicing.Text = "Slicing for the Top Side (optional if you already have a G-Code File)";
            // 
            // chkTopGenerateSupport
            // 
            this.chkTopGenerateSupport.AutoSize = true;
            this.chkTopGenerateSupport.Enabled = false;
            this.chkTopGenerateSupport.Location = new System.Drawing.Point(391, 77);
            this.chkTopGenerateSupport.Margin = new System.Windows.Forms.Padding(2);
            this.chkTopGenerateSupport.Name = "chkTopGenerateSupport";
            this.chkTopGenerateSupport.Size = new System.Drawing.Size(148, 17);
            this.chkTopGenerateSupport.TabIndex = 21;
            this.chkTopGenerateSupport.Text = "Generate Special Support";
            this.chkTopGenerateSupport.UseVisualStyleBackColor = true;
            this.chkTopGenerateSupport.CheckedChanged += new System.EventHandler(this.ChkTopGenerateSupport_CheckedChanged);
            // 
            // btnTopSlice
            // 
            this.btnTopSlice.Enabled = false;
            this.btnTopSlice.Image = ((System.Drawing.Image)(resources.GetObject("btnTopSlice.Image")));
            this.btnTopSlice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTopSlice.Location = new System.Drawing.Point(391, 102);
            this.btnTopSlice.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopSlice.Name = "btnTopSlice";
            this.btnTopSlice.Size = new System.Drawing.Size(163, 32);
            this.btnTopSlice.TabIndex = 20;
            this.btnTopSlice.Text = "Process via Simplify3D®";
            this.btnTopSlice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopSlice.UseVisualStyleBackColor = true;
            this.btnTopSlice.Click += new System.EventHandler(this.BtnSlice_Click);
            // 
            // tlpTopFileButtons
            // 
            this.tlpTopFileButtons.ColumnCount = 2;
            this.tlpTopFileButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpTopFileButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpTopFileButtons.Controls.Add(this.btnTopRemoveFiles, 0, 0);
            this.tlpTopFileButtons.Controls.Add(this.btnTopAddFiles, 0, 0);
            this.tlpTopFileButtons.Location = new System.Drawing.Point(10, 108);
            this.tlpTopFileButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTopFileButtons.Name = "tlpTopFileButtons";
            this.tlpTopFileButtons.RowCount = 1;
            this.tlpTopFileButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopFileButtons.Size = new System.Drawing.Size(365, 26);
            this.tlpTopFileButtons.TabIndex = 19;
            // 
            // btnTopRemoveFiles
            // 
            this.btnTopRemoveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTopRemoveFiles.Enabled = false;
            this.btnTopRemoveFiles.Image = global::DiabasePrintingWizard.Properties.Resources.Remove_8x_16x;
            this.btnTopRemoveFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTopRemoveFiles.Location = new System.Drawing.Point(184, 0);
            this.btnTopRemoveFiles.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnTopRemoveFiles.Name = "btnTopRemoveFiles";
            this.btnTopRemoveFiles.Size = new System.Drawing.Size(181, 26);
            this.btnTopRemoveFiles.TabIndex = 19;
            this.btnTopRemoveFiles.Text = "Remove File(s)";
            this.btnTopRemoveFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopRemoveFiles.UseVisualStyleBackColor = true;
            this.btnTopRemoveFiles.Click += new System.EventHandler(this.BtnTopRemoveFiles_Click);
            // 
            // btnTopAddFiles
            // 
            this.btnTopAddFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTopAddFiles.Image = global::DiabasePrintingWizard.Properties.Resources.Add_thin_10x_16x;
            this.btnTopAddFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTopAddFiles.Location = new System.Drawing.Point(0, 0);
            this.btnTopAddFiles.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnTopAddFiles.Name = "btnTopAddFiles";
            this.btnTopAddFiles.Size = new System.Drawing.Size(180, 26);
            this.btnTopAddFiles.TabIndex = 18;
            this.btnTopAddFiles.Text = "Add File(s)";
            this.btnTopAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopAddFiles.UseVisualStyleBackColor = true;
            this.btnTopAddFiles.Click += new System.EventHandler(this.BtnTopAddFiles_Click);
            // 
            // lstTopInputFiles
            // 
            this.lstTopInputFiles.FormattingEnabled = true;
            this.lstTopInputFiles.Location = new System.Drawing.Point(10, 35);
            this.lstTopInputFiles.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.lstTopInputFiles.Name = "lstTopInputFiles";
            this.lstTopInputFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTopInputFiles.Size = new System.Drawing.Size(366, 69);
            this.lstTopInputFiles.TabIndex = 16;
            // 
            // chkTopUseOwnSettings
            // 
            this.chkTopUseOwnSettings.AutoSize = true;
            this.chkTopUseOwnSettings.Location = new System.Drawing.Point(391, 35);
            this.chkTopUseOwnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.chkTopUseOwnSettings.Name = "chkTopUseOwnSettings";
            this.chkTopUseOwnSettings.Size = new System.Drawing.Size(167, 17);
            this.chkTopUseOwnSettings.TabIndex = 15;
            this.chkTopUseOwnSettings.Text = "Use own Simplify3D® settings";
            this.chkTopUseOwnSettings.UseVisualStyleBackColor = true;
            this.chkTopUseOwnSettings.CheckedChanged += new System.EventHandler(this.ChkTopUseOwnSettings_CheckedChanged);
            // 
            // chkTopUnwrap
            // 
            this.chkTopUnwrap.AutoSize = true;
            this.chkTopUnwrap.Location = new System.Drawing.Point(391, 57);
            this.chkTopUnwrap.Margin = new System.Windows.Forms.Padding(2);
            this.chkTopUnwrap.Name = "chkTopUnwrap";
            this.chkTopUnwrap.Size = new System.Drawing.Size(110, 17);
            this.chkTopUnwrap.TabIndex = 14;
            this.chkTopUnwrap.Text = "Unwrap STL Files";
            this.chkTopUnwrap.UseVisualStyleBackColor = true;
            this.chkTopUnwrap.CheckedChanged += new System.EventHandler(this.ChkTopUnwrap_CheckedChanged);
            // 
            // lblTopInputFiles
            // 
            this.lblTopInputFiles.AutoSize = true;
            this.lblTopInputFiles.Location = new System.Drawing.Point(8, 19);
            this.lblTopInputFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopInputFiles.Name = "lblTopInputFiles";
            this.lblTopInputFiles.Size = new System.Drawing.Size(89, 13);
            this.lblTopInputFiles.TabIndex = 11;
            this.lblTopInputFiles.Text = "List of Input Files:";
            // 
            // awpBottomSide
            // 
            this.awpBottomSide.Controls.Add(this.gbBottomFiles);
            this.awpBottomSide.Controls.Add(this.gbBottomSlicing);
            this.awpBottomSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpBottomSide.Header = true;
            this.awpBottomSide.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpBottomSide.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpBottomSide.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpBottomSide.HeaderImage")));
            this.awpBottomSide.HeaderImageVisible = true;
            this.awpBottomSide.HeaderTitle = "Welcome to Advanced Wizard";
            this.awpBottomSide.Location = new System.Drawing.Point(0, 0);
            this.awpBottomSide.Margin = new System.Windows.Forms.Padding(2);
            this.awpBottomSide.Name = "awpBottomSide";
            this.awpBottomSide.PreviousPage = 2;
            this.awpBottomSide.Size = new System.Drawing.Size(586, 384);
            this.awpBottomSide.SubTitle = "Your page description goes here";
            this.awpBottomSide.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpBottomSide.TabIndex = 3;
            this.awpBottomSide.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.AwpBottomSide_PageShow);
            // 
            // gbBottomFiles
            // 
            this.gbBottomFiles.Controls.Add(this.btnBottomBrowseSubstractive);
            this.gbBottomFiles.Controls.Add(this.btnBottomBrowseAdditive);
            this.gbBottomFiles.Controls.Add(this.txtBottomFileSubstractive);
            this.gbBottomFiles.Controls.Add(this.lblBottomFileSubstractive);
            this.gbBottomFiles.Controls.Add(this.txtBottomFileAdditive);
            this.gbBottomFiles.Controls.Add(this.lblBottomFileAdditive);
            this.gbBottomFiles.Location = new System.Drawing.Point(13, 258);
            this.gbBottomFiles.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.gbBottomFiles.Name = "gbBottomFiles";
            this.gbBottomFiles.Padding = new System.Windows.Forms.Padding(2);
            this.gbBottomFiles.Size = new System.Drawing.Size(562, 67);
            this.gbBottomFiles.TabIndex = 15;
            this.gbBottomFiles.TabStop = false;
            this.gbBottomFiles.Text = "Manufacturing Files for the Bottom Side";
            // 
            // btnBottomBrowseSubstractive
            // 
            this.btnBottomBrowseSubstractive.Location = new System.Drawing.Point(522, 37);
            this.btnBottomBrowseSubstractive.Margin = new System.Windows.Forms.Padding(2);
            this.btnBottomBrowseSubstractive.Name = "btnBottomBrowseSubstractive";
            this.btnBottomBrowseSubstractive.Size = new System.Drawing.Size(32, 22);
            this.btnBottomBrowseSubstractive.TabIndex = 16;
            this.btnBottomBrowseSubstractive.Text = "...";
            this.btnBottomBrowseSubstractive.UseVisualStyleBackColor = true;
            this.btnBottomBrowseSubstractive.Click += new System.EventHandler(this.BtnBottomBrowseSubstractive_Click);
            // 
            // btnBottomBrowseAdditive
            // 
            this.btnBottomBrowseAdditive.Location = new System.Drawing.Point(242, 37);
            this.btnBottomBrowseAdditive.Margin = new System.Windows.Forms.Padding(2);
            this.btnBottomBrowseAdditive.Name = "btnBottomBrowseAdditive";
            this.btnBottomBrowseAdditive.Size = new System.Drawing.Size(32, 22);
            this.btnBottomBrowseAdditive.TabIndex = 15;
            this.btnBottomBrowseAdditive.Text = "...";
            this.btnBottomBrowseAdditive.UseVisualStyleBackColor = true;
            this.btnBottomBrowseAdditive.Click += new System.EventHandler(this.BtnBottomBrowseAdditive_Click);
            // 
            // txtBottomFileSubstractive
            // 
            this.txtBottomFileSubstractive.Location = new System.Drawing.Point(290, 38);
            this.txtBottomFileSubstractive.Margin = new System.Windows.Forms.Padding(2);
            this.txtBottomFileSubstractive.Name = "txtBottomFileSubstractive";
            this.txtBottomFileSubstractive.Size = new System.Drawing.Size(229, 20);
            this.txtBottomFileSubstractive.TabIndex = 14;
            this.txtBottomFileSubstractive.Click += new System.EventHandler(this.TxtBottomGCodeFiles_TextChanged);
            // 
            // lblBottomFileSubstractive
            // 
            this.lblBottomFileSubstractive.AutoSize = true;
            this.lblBottomFileSubstractive.Location = new System.Drawing.Point(288, 19);
            this.lblBottomFileSubstractive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBottomFileSubstractive.Name = "lblBottomFileSubstractive";
            this.lblBottomFileSubstractive.Size = new System.Drawing.Size(197, 13);
            this.lblBottomFileSubstractive.TabIndex = 13;
            this.lblBottomFileSubstractive.Text = "G-Code File for Substractive Processing:";
            // 
            // txtBottomFileAdditive
            // 
            this.txtBottomFileAdditive.Location = new System.Drawing.Point(10, 38);
            this.txtBottomFileAdditive.Margin = new System.Windows.Forms.Padding(2);
            this.txtBottomFileAdditive.Name = "txtBottomFileAdditive";
            this.txtBottomFileAdditive.Size = new System.Drawing.Size(229, 20);
            this.txtBottomFileAdditive.TabIndex = 12;
            this.txtBottomFileAdditive.Click += new System.EventHandler(this.TxtBottomGCodeFiles_TextChanged);
            // 
            // lblBottomFileAdditive
            // 
            this.lblBottomFileAdditive.AutoSize = true;
            this.lblBottomFileAdditive.Location = new System.Drawing.Point(8, 19);
            this.lblBottomFileAdditive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBottomFileAdditive.Name = "lblBottomFileAdditive";
            this.lblBottomFileAdditive.Size = new System.Drawing.Size(176, 13);
            this.lblBottomFileAdditive.TabIndex = 11;
            this.lblBottomFileAdditive.Text = "G-Code File for Additive Processing:";
            // 
            // gbBottomSlicing
            // 
            this.gbBottomSlicing.Controls.Add(this.chkBottomGenerateSupport);
            this.gbBottomSlicing.Controls.Add(this.btnBottomSlice);
            this.gbBottomSlicing.Controls.Add(this.tlpBottomFileButtons);
            this.gbBottomSlicing.Controls.Add(this.lstBottomInputFiles);
            this.gbBottomSlicing.Controls.Add(this.chkBottomUseOwnSettings);
            this.gbBottomSlicing.Controls.Add(this.chkBottomUnwrap);
            this.gbBottomSlicing.Controls.Add(this.lblBottomFiles);
            this.gbBottomSlicing.Location = new System.Drawing.Point(13, 106);
            this.gbBottomSlicing.Margin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.gbBottomSlicing.Name = "gbBottomSlicing";
            this.gbBottomSlicing.Padding = new System.Windows.Forms.Padding(2);
            this.gbBottomSlicing.Size = new System.Drawing.Size(562, 142);
            this.gbBottomSlicing.TabIndex = 14;
            this.gbBottomSlicing.TabStop = false;
            this.gbBottomSlicing.Text = "Slicing for the Bottom Side (optional if you already have a G-Code File)";
            // 
            // chkBottomGenerateSupport
            // 
            this.chkBottomGenerateSupport.AutoSize = true;
            this.chkBottomGenerateSupport.Enabled = false;
            this.chkBottomGenerateSupport.Location = new System.Drawing.Point(391, 77);
            this.chkBottomGenerateSupport.Margin = new System.Windows.Forms.Padding(2);
            this.chkBottomGenerateSupport.Name = "chkBottomGenerateSupport";
            this.chkBottomGenerateSupport.Size = new System.Drawing.Size(148, 17);
            this.chkBottomGenerateSupport.TabIndex = 21;
            this.chkBottomGenerateSupport.Text = "Generate Special Support";
            this.chkBottomGenerateSupport.UseVisualStyleBackColor = true;
            this.chkBottomGenerateSupport.CheckedChanged += new System.EventHandler(this.ChkBottomGenerateSupport_CheckedChanged);
            // 
            // btnBottomSlice
            // 
            this.btnBottomSlice.Enabled = false;
            this.btnBottomSlice.Image = ((System.Drawing.Image)(resources.GetObject("btnBottomSlice.Image")));
            this.btnBottomSlice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBottomSlice.Location = new System.Drawing.Point(391, 102);
            this.btnBottomSlice.Margin = new System.Windows.Forms.Padding(2);
            this.btnBottomSlice.Name = "btnBottomSlice";
            this.btnBottomSlice.Size = new System.Drawing.Size(163, 32);
            this.btnBottomSlice.TabIndex = 20;
            this.btnBottomSlice.Text = "Process via Simplify3D®";
            this.btnBottomSlice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBottomSlice.UseVisualStyleBackColor = true;
            this.btnBottomSlice.Click += new System.EventHandler(this.BtnSlice_Click);
            // 
            // tlpBottomFileButtons
            // 
            this.tlpBottomFileButtons.ColumnCount = 2;
            this.tlpBottomFileButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBottomFileButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpBottomFileButtons.Controls.Add(this.btnBottomRemoveFiles, 0, 0);
            this.tlpBottomFileButtons.Controls.Add(this.btnBottomAddFiles, 0, 0);
            this.tlpBottomFileButtons.Location = new System.Drawing.Point(10, 108);
            this.tlpBottomFileButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tlpBottomFileButtons.Name = "tlpBottomFileButtons";
            this.tlpBottomFileButtons.RowCount = 1;
            this.tlpBottomFileButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottomFileButtons.Size = new System.Drawing.Size(365, 26);
            this.tlpBottomFileButtons.TabIndex = 19;
            // 
            // btnBottomRemoveFiles
            // 
            this.btnBottomRemoveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBottomRemoveFiles.Enabled = false;
            this.btnBottomRemoveFiles.Image = global::DiabasePrintingWizard.Properties.Resources.Remove_8x_16x;
            this.btnBottomRemoveFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBottomRemoveFiles.Location = new System.Drawing.Point(184, 0);
            this.btnBottomRemoveFiles.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnBottomRemoveFiles.Name = "btnBottomRemoveFiles";
            this.btnBottomRemoveFiles.Size = new System.Drawing.Size(181, 26);
            this.btnBottomRemoveFiles.TabIndex = 19;
            this.btnBottomRemoveFiles.Text = "Remove File(s)";
            this.btnBottomRemoveFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBottomRemoveFiles.UseVisualStyleBackColor = true;
            this.btnBottomRemoveFiles.Click += new System.EventHandler(this.BtnBottomRemoveFiles_Click);
            // 
            // btnBottomAddFiles
            // 
            this.btnBottomAddFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBottomAddFiles.Image = global::DiabasePrintingWizard.Properties.Resources.Add_thin_10x_16x;
            this.btnBottomAddFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBottomAddFiles.Location = new System.Drawing.Point(0, 0);
            this.btnBottomAddFiles.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnBottomAddFiles.Name = "btnBottomAddFiles";
            this.btnBottomAddFiles.Size = new System.Drawing.Size(180, 26);
            this.btnBottomAddFiles.TabIndex = 18;
            this.btnBottomAddFiles.Text = "Add File(s)";
            this.btnBottomAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBottomAddFiles.UseVisualStyleBackColor = true;
            this.btnBottomAddFiles.Click += new System.EventHandler(this.BtnBottomAddFiles_Click);
            // 
            // lstBottomInputFiles
            // 
            this.lstBottomInputFiles.FormattingEnabled = true;
            this.lstBottomInputFiles.Location = new System.Drawing.Point(10, 35);
            this.lstBottomInputFiles.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.lstBottomInputFiles.Name = "lstBottomInputFiles";
            this.lstBottomInputFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBottomInputFiles.Size = new System.Drawing.Size(366, 69);
            this.lstBottomInputFiles.TabIndex = 16;
            // 
            // chkBottomUseOwnSettings
            // 
            this.chkBottomUseOwnSettings.AutoSize = true;
            this.chkBottomUseOwnSettings.Location = new System.Drawing.Point(391, 35);
            this.chkBottomUseOwnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.chkBottomUseOwnSettings.Name = "chkBottomUseOwnSettings";
            this.chkBottomUseOwnSettings.Size = new System.Drawing.Size(167, 17);
            this.chkBottomUseOwnSettings.TabIndex = 15;
            this.chkBottomUseOwnSettings.Text = "Use own Simplify3D® settings";
            this.chkBottomUseOwnSettings.UseVisualStyleBackColor = true;
            this.chkBottomUseOwnSettings.CheckedChanged += new System.EventHandler(this.ChkBottomUseOwnSettings_CheckedChanged);
            // 
            // chkBottomUnwrap
            // 
            this.chkBottomUnwrap.AutoSize = true;
            this.chkBottomUnwrap.Location = new System.Drawing.Point(391, 57);
            this.chkBottomUnwrap.Margin = new System.Windows.Forms.Padding(2);
            this.chkBottomUnwrap.Name = "chkBottomUnwrap";
            this.chkBottomUnwrap.Size = new System.Drawing.Size(110, 17);
            this.chkBottomUnwrap.TabIndex = 14;
            this.chkBottomUnwrap.Text = "Unwrap STL Files";
            this.chkBottomUnwrap.UseVisualStyleBackColor = true;
            this.chkBottomUnwrap.CheckedChanged += new System.EventHandler(this.ChkBottomUnwrap_CheckedChanged);
            // 
            // lblBottomFiles
            // 
            this.lblBottomFiles.AutoSize = true;
            this.lblBottomFiles.Location = new System.Drawing.Point(8, 19);
            this.lblBottomFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBottomFiles.Name = "lblBottomFiles";
            this.lblBottomFiles.Size = new System.Drawing.Size(89, 13);
            this.lblBottomFiles.TabIndex = 11;
            this.lblBottomFiles.Text = "List of Input Files:";
            // 
            // awpMachineProperties
            // 
            this.awpMachineProperties.Controls.Add(this.lblWelcome);
            this.awpMachineProperties.Controls.Add(this.tlpHeads);
            this.awpMachineProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awpMachineProperties.Header = false;
            this.awpMachineProperties.HeaderBackgroundColor = System.Drawing.Color.White;
            this.awpMachineProperties.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.awpMachineProperties.HeaderImage = ((System.Drawing.Image)(resources.GetObject("awpMachineProperties.HeaderImage")));
            this.awpMachineProperties.HeaderImageVisible = true;
            this.awpMachineProperties.HeaderTitle = "Post Processing";
            this.awpMachineProperties.Location = new System.Drawing.Point(0, 0);
            this.awpMachineProperties.Margin = new System.Windows.Forms.Padding(2);
            this.awpMachineProperties.Name = "awpMachineProperties";
            this.awpMachineProperties.PreviousPage = 0;
            this.awpMachineProperties.Size = new System.Drawing.Size(586, 384);
            this.awpMachineProperties.SubTitle = "Your page description goes here";
            this.awpMachineProperties.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpMachineProperties.TabIndex = 2;
            this.awpMachineProperties.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.AwpMachineProperties_PageShow);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(7, 108);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(305, 13);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "Please choose your preferences for the manufacturing process:";
            // 
            // tlpHeads
            // 
            this.tlpHeads.ColumnCount = 5;
            this.tlpHeads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHeads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHeads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHeads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHeads.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHeads.Controls.Add(this.cboTool1, 0, 0);
            this.tlpHeads.Controls.Add(this.gbTool3, 0, 1);
            this.tlpHeads.Controls.Add(this.cboTool2, 1, 0);
            this.tlpHeads.Controls.Add(this.gbTool5, 0, 1);
            this.tlpHeads.Controls.Add(this.cboTool3, 2, 0);
            this.tlpHeads.Controls.Add(this.gbTool4, 0, 1);
            this.tlpHeads.Controls.Add(this.cboTool4, 3, 0);
            this.tlpHeads.Controls.Add(this.gbTool1, 0, 1);
            this.tlpHeads.Controls.Add(this.cboTool5, 4, 0);
            this.tlpHeads.Controls.Add(this.gbTool2, 0, 1);
            this.tlpHeads.Location = new System.Drawing.Point(9, 124);
            this.tlpHeads.Margin = new System.Windows.Forms.Padding(2);
            this.tlpHeads.Name = "tlpHeads";
            this.tlpHeads.RowCount = 2;
            this.tlpHeads.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHeads.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeads.Size = new System.Drawing.Size(568, 194);
            this.tlpHeads.TabIndex = 20;
            // 
            // cboTool1
            // 
            this.cboTool1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTool1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTool1.FormattingEnabled = true;
            this.cboTool1.Items.AddRange(new object[] {
            "Not present",
            "Nozzle",
            "Spindle"});
            this.cboTool1.Location = new System.Drawing.Point(7, 2);
            this.cboTool1.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.cboTool1.Name = "cboTool1";
            this.cboTool1.Size = new System.Drawing.Size(99, 21);
            this.cboTool1.TabIndex = 5;
            this.cboTool1.SelectedIndexChanged += new System.EventHandler(this.CboTool1_SelectedIndexChanged);
            // 
            // gbTool3
            // 
            this.gbTool3.Controls.Add(this.lblS1);
            this.gbTool3.Controls.Add(this.nudPreheat3);
            this.gbTool3.Controls.Add(this.lblPreheat3);
            this.gbTool3.Controls.Add(this.lblC1);
            this.gbTool3.Controls.Add(this.chkAutoClean3);
            this.gbTool3.Controls.Add(this.lblTemp3);
            this.gbTool3.Controls.Add(this.nudTemp3);
            this.gbTool3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTool3.Enabled = false;
            this.gbTool3.Location = new System.Drawing.Point(233, 32);
            this.gbTool3.Margin = new System.Windows.Forms.Padding(7);
            this.gbTool3.Name = "gbTool3";
            this.gbTool3.Padding = new System.Windows.Forms.Padding(2);
            this.gbTool3.Size = new System.Drawing.Size(99, 155);
            this.gbTool3.TabIndex = 0;
            this.gbTool3.TabStop = false;
            this.gbTool3.Text = "Tool 3";
            // 
            // lblS1
            // 
            this.lblS1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(83, 99);
            this.lblS1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(12, 13);
            this.lblS1.TabIndex = 6;
            this.lblS1.Text = "s";
            // 
            // nudPreheat3
            // 
            this.nudPreheat3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPreheat3.Location = new System.Drawing.Point(7, 97);
            this.nudPreheat3.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreheat3.Name = "nudPreheat3";
            this.nudPreheat3.Size = new System.Drawing.Size(74, 20);
            this.nudPreheat3.TabIndex = 5;
            this.nudPreheat3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblPreheat3
            // 
            this.lblPreheat3.AutoSize = true;
            this.lblPreheat3.Location = new System.Drawing.Point(4, 80);
            this.lblPreheat3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreheat3.Name = "lblPreheat3";
            this.lblPreheat3.Size = new System.Drawing.Size(87, 13);
            this.lblPreheat3.TabIndex = 4;
            this.lblPreheat3.Text = "Preheating Time:";
            // 
            // lblC1
            // 
            this.lblC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(81, 51);
            this.lblC1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(14, 13);
            this.lblC1.TabIndex = 3;
            this.lblC1.Text = "C";
            // 
            // chkAutoClean3
            // 
            this.chkAutoClean3.AutoSize = true;
            this.chkAutoClean3.Location = new System.Drawing.Point(7, 128);
            this.chkAutoClean3.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoClean3.Name = "chkAutoClean3";
            this.chkAutoClean3.Size = new System.Drawing.Size(78, 17);
            this.chkAutoClean3.TabIndex = 2;
            this.chkAutoClean3.Text = "Auto-Clean";
            this.chkAutoClean3.UseVisualStyleBackColor = true;
            // 
            // lblTemp3
            // 
            this.lblTemp3.AutoSize = true;
            this.lblTemp3.Location = new System.Drawing.Point(4, 19);
            this.lblTemp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(70, 26);
            this.lblTemp3.TabIndex = 1;
            this.lblTemp3.Text = "Standby\r\nTemperature:";
            // 
            // nudTemp3
            // 
            this.nudTemp3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTemp3.DecimalPlaces = 1;
            this.nudTemp3.Location = new System.Drawing.Point(7, 49);
            this.nudTemp3.Margin = new System.Windows.Forms.Padding(2);
            this.nudTemp3.Maximum = new decimal(new int[] {
            290,
            0,
            0,
            0});
            this.nudTemp3.Name = "nudTemp3";
            this.nudTemp3.Size = new System.Drawing.Size(72, 20);
            this.nudTemp3.TabIndex = 0;
            this.nudTemp3.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // cboTool2
            // 
            this.cboTool2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTool2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTool2.FormattingEnabled = true;
            this.cboTool2.Items.AddRange(new object[] {
            "Not present",
            "Nozzle",
            "Spindle"});
            this.cboTool2.Location = new System.Drawing.Point(120, 2);
            this.cboTool2.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.cboTool2.Name = "cboTool2";
            this.cboTool2.Size = new System.Drawing.Size(99, 21);
            this.cboTool2.TabIndex = 6;
            this.cboTool2.SelectedIndexChanged += new System.EventHandler(this.CboTool2_SelectedIndexChanged);
            // 
            // gbTool5
            // 
            this.gbTool5.Controls.Add(this.label14);
            this.gbTool5.Controls.Add(this.nudPreheat5);
            this.gbTool5.Controls.Add(this.lblPreheat5);
            this.gbTool5.Controls.Add(this.label16);
            this.gbTool5.Controls.Add(this.chkAutoClean5);
            this.gbTool5.Controls.Add(this.lblTemp5);
            this.gbTool5.Controls.Add(this.nudTemp5);
            this.gbTool5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTool5.Enabled = false;
            this.gbTool5.Location = new System.Drawing.Point(459, 32);
            this.gbTool5.Margin = new System.Windows.Forms.Padding(7);
            this.gbTool5.Name = "gbTool5";
            this.gbTool5.Padding = new System.Windows.Forms.Padding(2);
            this.gbTool5.Size = new System.Drawing.Size(102, 155);
            this.gbTool5.TabIndex = 13;
            this.gbTool5.TabStop = false;
            this.gbTool5.Text = "Tool 5";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "s";
            // 
            // nudPreheat5
            // 
            this.nudPreheat5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPreheat5.Location = new System.Drawing.Point(7, 97);
            this.nudPreheat5.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreheat5.Name = "nudPreheat5";
            this.nudPreheat5.Size = new System.Drawing.Size(75, 20);
            this.nudPreheat5.TabIndex = 5;
            this.nudPreheat5.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblPreheat5
            // 
            this.lblPreheat5.AutoSize = true;
            this.lblPreheat5.Location = new System.Drawing.Point(4, 80);
            this.lblPreheat5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreheat5.Name = "lblPreheat5";
            this.lblPreheat5.Size = new System.Drawing.Size(87, 13);
            this.lblPreheat5.TabIndex = 4;
            this.lblPreheat5.Text = "Preheating Time:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(85, 51);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "C";
            // 
            // chkAutoClean5
            // 
            this.chkAutoClean5.AutoSize = true;
            this.chkAutoClean5.Location = new System.Drawing.Point(7, 128);
            this.chkAutoClean5.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoClean5.Name = "chkAutoClean5";
            this.chkAutoClean5.Size = new System.Drawing.Size(78, 17);
            this.chkAutoClean5.TabIndex = 2;
            this.chkAutoClean5.Text = "Auto-Clean";
            this.chkAutoClean5.UseVisualStyleBackColor = true;
            // 
            // lblTemp5
            // 
            this.lblTemp5.AutoSize = true;
            this.lblTemp5.Location = new System.Drawing.Point(4, 19);
            this.lblTemp5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp5.Name = "lblTemp5";
            this.lblTemp5.Size = new System.Drawing.Size(70, 26);
            this.lblTemp5.TabIndex = 1;
            this.lblTemp5.Text = "Standby\r\nTemperature:";
            // 
            // nudTemp5
            // 
            this.nudTemp5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTemp5.DecimalPlaces = 1;
            this.nudTemp5.Location = new System.Drawing.Point(7, 49);
            this.nudTemp5.Margin = new System.Windows.Forms.Padding(2);
            this.nudTemp5.Maximum = new decimal(new int[] {
            290,
            0,
            0,
            0});
            this.nudTemp5.Name = "nudTemp5";
            this.nudTemp5.Size = new System.Drawing.Size(75, 20);
            this.nudTemp5.TabIndex = 0;
            this.nudTemp5.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // cboTool3
            // 
            this.cboTool3.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTool3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTool3.FormattingEnabled = true;
            this.cboTool3.Items.AddRange(new object[] {
            "Not present",
            "Nozzle",
            "Spindle"});
            this.cboTool3.Location = new System.Drawing.Point(233, 2);
            this.cboTool3.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.cboTool3.Name = "cboTool3";
            this.cboTool3.Size = new System.Drawing.Size(99, 21);
            this.cboTool3.TabIndex = 7;
            this.cboTool3.SelectedIndexChanged += new System.EventHandler(this.CboTool3_SelectedIndexChanged);
            // 
            // gbTool4
            // 
            this.gbTool4.Controls.Add(this.label10);
            this.gbTool4.Controls.Add(this.nudPreheat4);
            this.gbTool4.Controls.Add(this.lblPreheat4);
            this.gbTool4.Controls.Add(this.label12);
            this.gbTool4.Controls.Add(this.chkAutoClean4);
            this.gbTool4.Controls.Add(this.lblTemp4);
            this.gbTool4.Controls.Add(this.nudTemp4);
            this.gbTool4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTool4.Enabled = false;
            this.gbTool4.Location = new System.Drawing.Point(346, 32);
            this.gbTool4.Margin = new System.Windows.Forms.Padding(7);
            this.gbTool4.Name = "gbTool4";
            this.gbTool4.Padding = new System.Windows.Forms.Padding(2);
            this.gbTool4.Size = new System.Drawing.Size(99, 155);
            this.gbTool4.TabIndex = 12;
            this.gbTool4.TabStop = false;
            this.gbTool4.Text = "Tool 4";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "s";
            // 
            // nudPreheat4
            // 
            this.nudPreheat4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPreheat4.Location = new System.Drawing.Point(7, 97);
            this.nudPreheat4.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreheat4.Name = "nudPreheat4";
            this.nudPreheat4.Size = new System.Drawing.Size(74, 20);
            this.nudPreheat4.TabIndex = 5;
            this.nudPreheat4.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblPreheat4
            // 
            this.lblPreheat4.AutoSize = true;
            this.lblPreheat4.Location = new System.Drawing.Point(4, 80);
            this.lblPreheat4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreheat4.Name = "lblPreheat4";
            this.lblPreheat4.Size = new System.Drawing.Size(87, 13);
            this.lblPreheat4.TabIndex = 4;
            this.lblPreheat4.Text = "Preheating Time:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "C";
            // 
            // chkAutoClean4
            // 
            this.chkAutoClean4.AutoSize = true;
            this.chkAutoClean4.Location = new System.Drawing.Point(7, 128);
            this.chkAutoClean4.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoClean4.Name = "chkAutoClean4";
            this.chkAutoClean4.Size = new System.Drawing.Size(78, 17);
            this.chkAutoClean4.TabIndex = 2;
            this.chkAutoClean4.Text = "Auto-Clean";
            this.chkAutoClean4.UseVisualStyleBackColor = true;
            // 
            // lblTemp4
            // 
            this.lblTemp4.AutoSize = true;
            this.lblTemp4.Location = new System.Drawing.Point(4, 19);
            this.lblTemp4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp4.Name = "lblTemp4";
            this.lblTemp4.Size = new System.Drawing.Size(70, 26);
            this.lblTemp4.TabIndex = 1;
            this.lblTemp4.Text = "Standby\r\nTemperature:";
            // 
            // nudTemp4
            // 
            this.nudTemp4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTemp4.DecimalPlaces = 1;
            this.nudTemp4.Location = new System.Drawing.Point(7, 49);
            this.nudTemp4.Margin = new System.Windows.Forms.Padding(2);
            this.nudTemp4.Maximum = new decimal(new int[] {
            290,
            0,
            0,
            0});
            this.nudTemp4.Name = "nudTemp4";
            this.nudTemp4.Size = new System.Drawing.Size(74, 20);
            this.nudTemp4.TabIndex = 0;
            this.nudTemp4.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // cboTool4
            // 
            this.cboTool4.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTool4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTool4.FormattingEnabled = true;
            this.cboTool4.Items.AddRange(new object[] {
            "Not present",
            "Nozzle",
            "Spindle"});
            this.cboTool4.Location = new System.Drawing.Point(346, 2);
            this.cboTool4.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.cboTool4.Name = "cboTool4";
            this.cboTool4.Size = new System.Drawing.Size(99, 21);
            this.cboTool4.TabIndex = 8;
            this.cboTool4.SelectedIndexChanged += new System.EventHandler(this.CboTool4_SelectedIndexChanged);
            // 
            // gbTool1
            // 
            this.gbTool1.Controls.Add(this.label2);
            this.gbTool1.Controls.Add(this.nudPreheat1);
            this.gbTool1.Controls.Add(this.lblPreheat1);
            this.gbTool1.Controls.Add(this.label4);
            this.gbTool1.Controls.Add(this.chkAutoClean1);
            this.gbTool1.Controls.Add(this.lblTemp1);
            this.gbTool1.Controls.Add(this.nudTemp1);
            this.gbTool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTool1.Enabled = false;
            this.gbTool1.Location = new System.Drawing.Point(7, 32);
            this.gbTool1.Margin = new System.Windows.Forms.Padding(7);
            this.gbTool1.Name = "gbTool1";
            this.gbTool1.Padding = new System.Windows.Forms.Padding(2);
            this.gbTool1.Size = new System.Drawing.Size(99, 155);
            this.gbTool1.TabIndex = 10;
            this.gbTool1.TabStop = false;
            this.gbTool1.Text = "Tool 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "s";
            // 
            // nudPreheat1
            // 
            this.nudPreheat1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPreheat1.Location = new System.Drawing.Point(7, 97);
            this.nudPreheat1.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreheat1.Name = "nudPreheat1";
            this.nudPreheat1.Size = new System.Drawing.Size(73, 20);
            this.nudPreheat1.TabIndex = 5;
            this.nudPreheat1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblPreheat1
            // 
            this.lblPreheat1.AutoSize = true;
            this.lblPreheat1.Location = new System.Drawing.Point(4, 80);
            this.lblPreheat1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreheat1.Name = "lblPreheat1";
            this.lblPreheat1.Size = new System.Drawing.Size(87, 13);
            this.lblPreheat1.TabIndex = 4;
            this.lblPreheat1.Text = "Preheating Time:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "C";
            // 
            // chkAutoClean1
            // 
            this.chkAutoClean1.AutoSize = true;
            this.chkAutoClean1.Location = new System.Drawing.Point(7, 128);
            this.chkAutoClean1.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoClean1.Name = "chkAutoClean1";
            this.chkAutoClean1.Size = new System.Drawing.Size(78, 17);
            this.chkAutoClean1.TabIndex = 2;
            this.chkAutoClean1.Text = "Auto-Clean";
            this.chkAutoClean1.UseVisualStyleBackColor = true;
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Location = new System.Drawing.Point(4, 19);
            this.lblTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(70, 26);
            this.lblTemp1.TabIndex = 1;
            this.lblTemp1.Text = "Standby\r\nTemperature:";
            // 
            // nudTemp1
            // 
            this.nudTemp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTemp1.DecimalPlaces = 1;
            this.nudTemp1.Location = new System.Drawing.Point(7, 49);
            this.nudTemp1.Margin = new System.Windows.Forms.Padding(2);
            this.nudTemp1.Maximum = new decimal(new int[] {
            290,
            0,
            0,
            0});
            this.nudTemp1.Name = "nudTemp1";
            this.nudTemp1.Size = new System.Drawing.Size(73, 20);
            this.nudTemp1.TabIndex = 0;
            this.nudTemp1.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // cboTool5
            // 
            this.cboTool5.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTool5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTool5.FormattingEnabled = true;
            this.cboTool5.Items.AddRange(new object[] {
            "Not present",
            "Nozzle",
            "Spindle"});
            this.cboTool5.Location = new System.Drawing.Point(459, 2);
            this.cboTool5.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.cboTool5.Name = "cboTool5";
            this.cboTool5.Size = new System.Drawing.Size(102, 21);
            this.cboTool5.TabIndex = 9;
            this.cboTool5.SelectedIndexChanged += new System.EventHandler(this.CboTool5_SelectedIndexChanged);
            // 
            // gbTool2
            // 
            this.gbTool2.Controls.Add(this.label6);
            this.gbTool2.Controls.Add(this.nudPreheat2);
            this.gbTool2.Controls.Add(this.lblPreheat2);
            this.gbTool2.Controls.Add(this.label8);
            this.gbTool2.Controls.Add(this.chkAutoClean2);
            this.gbTool2.Controls.Add(this.lblTemp2);
            this.gbTool2.Controls.Add(this.nudTemp2);
            this.gbTool2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTool2.Enabled = false;
            this.gbTool2.Location = new System.Drawing.Point(120, 32);
            this.gbTool2.Margin = new System.Windows.Forms.Padding(7);
            this.gbTool2.Name = "gbTool2";
            this.gbTool2.Padding = new System.Windows.Forms.Padding(2);
            this.gbTool2.Size = new System.Drawing.Size(99, 155);
            this.gbTool2.TabIndex = 11;
            this.gbTool2.TabStop = false;
            this.gbTool2.Text = "Tool 2";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "s";
            // 
            // nudPreheat2
            // 
            this.nudPreheat2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPreheat2.Location = new System.Drawing.Point(7, 97);
            this.nudPreheat2.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreheat2.Name = "nudPreheat2";
            this.nudPreheat2.Size = new System.Drawing.Size(74, 20);
            this.nudPreheat2.TabIndex = 5;
            this.nudPreheat2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblPreheat2
            // 
            this.lblPreheat2.AutoSize = true;
            this.lblPreheat2.Location = new System.Drawing.Point(4, 80);
            this.lblPreheat2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreheat2.Name = "lblPreheat2";
            this.lblPreheat2.Size = new System.Drawing.Size(87, 13);
            this.lblPreheat2.TabIndex = 4;
            this.lblPreheat2.Text = "Preheating Time:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "C";
            // 
            // chkAutoClean2
            // 
            this.chkAutoClean2.AutoSize = true;
            this.chkAutoClean2.Location = new System.Drawing.Point(7, 128);
            this.chkAutoClean2.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoClean2.Name = "chkAutoClean2";
            this.chkAutoClean2.Size = new System.Drawing.Size(78, 17);
            this.chkAutoClean2.TabIndex = 2;
            this.chkAutoClean2.Text = "Auto-Clean";
            this.chkAutoClean2.UseVisualStyleBackColor = true;
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Location = new System.Drawing.Point(4, 19);
            this.lblTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(70, 26);
            this.lblTemp2.TabIndex = 1;
            this.lblTemp2.Text = "Standby\r\nTemperature:";
            // 
            // nudTemp2
            // 
            this.nudTemp2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTemp2.DecimalPlaces = 1;
            this.nudTemp2.Location = new System.Drawing.Point(7, 49);
            this.nudTemp2.Margin = new System.Windows.Forms.Padding(2);
            this.nudTemp2.Maximum = new decimal(new int[] {
            290,
            0,
            0,
            0});
            this.nudTemp2.Name = "nudTemp2";
            this.nudTemp2.Size = new System.Drawing.Size(74, 20);
            this.nudTemp2.TabIndex = 0;
            this.nudTemp2.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // awpProgress
            // 
            this.awpProgress.Controls.Add(this.btnUploadPrint);
            this.awpProgress.Controls.Add(this.btnUpload);
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
            this.awpProgress.PreviousPage = 4;
            this.awpProgress.Size = new System.Drawing.Size(586, 384);
            this.awpProgress.SubTitle = "Your page description goes here";
            this.awpProgress.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.awpProgress.TabIndex = 4;
            this.awpProgress.PageShow += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageEventArgs>(this.AwpProgress_PageShow);
            // 
            // btnUploadPrint
            // 
            this.btnUploadPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadPrint.Image")));
            this.btnUploadPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploadPrint.Location = new System.Drawing.Point(240, 271);
            this.btnUploadPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadPrint.Name = "btnUploadPrint";
            this.btnUploadPrint.Size = new System.Drawing.Size(106, 31);
            this.btnUploadPrint.TabIndex = 7;
            this.btnUploadPrint.Text = "Upload && Print";
            this.btnUploadPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadPrint.UseVisualStyleBackColor = true;
            this.btnUploadPrint.Visible = false;
            this.btnUploadPrint.Click += new System.EventHandler(this.BtnUploadPrint_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::DiabasePrintingWizard.Properties.Resources.UploadFile_16x;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpload.Location = new System.Drawing.Point(130, 271);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(106, 31);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Visible = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(351, 271);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Toolpath";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.lblPleaseStandBy.Size = new System.Drawing.Size(303, 13);
            this.lblPleaseStandBy.TabIndex = 3;
            this.lblPleaseStandBy.Text = "Please stand by while your G-Code Files are being processed...";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Image = global::DiabasePrintingWizard.Properties.Resources.Forward_16x;
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
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Enabled = false;
            this.btnBack.Image = global::DiabasePrintingWizard.Properties.Resources.Backward_16x;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(400, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::DiabasePrintingWizard.Properties.Resources.Exit_16x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(9, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.pbBanner.Image = global::DiabasePrintingWizard.Properties.Resources.LogoOnLeftforBlackBackgorund;
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(586, 98);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 20;
            this.pbBanner.TabStop = false;
            // 
            // ofdInputs
            // 
            this.ofdInputs.Filter = "STL, OBJ and Factory Files (*.stl, *.obj, *.factory)|*.stl;*.obj;*.factory|All Fi" +
    "les (*.*)|*.*";
            this.ofdInputs.Multiselect = true;
            this.ofdInputs.RestoreDirectory = true;
            this.ofdInputs.Title = "Select STL file...";
            // 
            // ofdGCode
            // 
            this.ofdGCode.Filter = "G-Code Files (*.g, *.gcode, *.nc)|*.g;*.gcode;*.nc|All Files (*.*)|*.*";
            this.ofdGCode.RestoreDirectory = true;
            this.ofdGCode.Title = "Select G-Code File...";
            // 
            // sfdGCode
            // 
            this.sfdGCode.Filter = "G-Code Files (*.g, *.gcode, *.nc)|*.g;*.gcode;*.nc|All Files (*.*)|*.*";
            this.sfdGCode.RestoreDirectory = true;
            // 
            // sfdFactory
            // 
            this.sfdFactory.Filter = "Simplify3D Factory Files (*.factory)|*.factory|All Files (*.*)|*.*";
            this.sfdFactory.RestoreDirectory = true;
            // 
            // FrmMain
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
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diabase Printing Wizard";
            this.Deactivate += new System.EventHandler(this.FrmMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.awContent.ResumeLayout(false);
            this.awpWelcome.ResumeLayout(false);
            this.awpWelcome.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbMachine.ResumeLayout(false);
            this.gbMachine.PerformLayout();
            this.gbGeometry.ResumeLayout(false);
            this.gbGeometry.PerformLayout();
            this.awpActions.ResumeLayout(false);
            this.gbIDRotaryPrinting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudModelID)).EndInit();
            this.gbIslandCombining.ResumeLayout(false);
            this.gbIslandCombining.PerformLayout();
            this.gbRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomActions)).EndInit();
            this.awpTopSide.ResumeLayout(false);
            this.gbTopFiles.ResumeLayout(false);
            this.gbTopFiles.PerformLayout();
            this.gbTopSlicing.ResumeLayout(false);
            this.gbTopSlicing.PerformLayout();
            this.tlpTopFileButtons.ResumeLayout(false);
            this.awpBottomSide.ResumeLayout(false);
            this.gbBottomFiles.ResumeLayout(false);
            this.gbBottomFiles.PerformLayout();
            this.gbBottomSlicing.ResumeLayout(false);
            this.gbBottomSlicing.PerformLayout();
            this.tlpBottomFileButtons.ResumeLayout(false);
            this.awpMachineProperties.ResumeLayout(false);
            this.awpMachineProperties.PerformLayout();
            this.tlpHeads.ResumeLayout(false);
            this.gbTool3.ResumeLayout(false);
            this.gbTool3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp3)).EndInit();
            this.gbTool5.ResumeLayout(false);
            this.gbTool5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp5)).EndInit();
            this.gbTool4.ResumeLayout(false);
            this.gbTool4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp4)).EndInit();
            this.gbTool1.ResumeLayout(false);
            this.gbTool1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp1)).EndInit();
            this.gbTool2.ResumeLayout(false);
            this.gbTool2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreheat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp2)).EndInit();
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
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpMachineProperties;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TableLayoutPanel tlpHeads;
        private System.Windows.Forms.ComboBox cboTool5;
        private System.Windows.Forms.ComboBox cboTool4;
        private System.Windows.Forms.ComboBox cboTool3;
        private System.Windows.Forms.ComboBox cboTool2;
        private System.Windows.Forms.GroupBox gbTool3;
        private System.Windows.Forms.ComboBox cboTool1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.NumericUpDown nudPreheat3;
        private System.Windows.Forms.Label lblPreheat3;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.CheckBox chkAutoClean3;
        private System.Windows.Forms.Label lblTemp3;
        private System.Windows.Forms.NumericUpDown nudTemp3;
        private System.Windows.Forms.GroupBox gbTool5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudPreheat5;
        private System.Windows.Forms.Label lblPreheat5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkAutoClean5;
        private System.Windows.Forms.Label lblTemp5;
        private System.Windows.Forms.NumericUpDown nudTemp5;
        private System.Windows.Forms.GroupBox gbTool4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudPreheat4;
        private System.Windows.Forms.Label lblPreheat4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkAutoClean4;
        private System.Windows.Forms.Label lblTemp4;
        private System.Windows.Forms.NumericUpDown nudTemp4;
        private System.Windows.Forms.GroupBox gbTool2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPreheat2;
        private System.Windows.Forms.Label lblPreheat2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAutoClean2;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.NumericUpDown nudTemp2;
        private System.Windows.Forms.GroupBox gbTool1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPreheat1;
        private System.Windows.Forms.Label lblPreheat1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAutoClean1;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.NumericUpDown nudTemp1;
        private System.Windows.Forms.OpenFileDialog ofdInputs;
        private System.Windows.Forms.GroupBox gbMachine;
        private System.Windows.Forms.ListBox lstMachine;
        private System.Windows.Forms.CheckBox chkConfigureManually;
        private System.Windows.Forms.GroupBox gbGeometry;
        private System.Windows.Forms.RadioButton rbRotary;
        private System.Windows.Forms.RadioButton rbTwoSided;
        private System.Windows.Forms.RadioButton rbOneSided;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbAdditiveSubstractive;
        private System.Windows.Forms.RadioButton rbAdditive;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpTopSide;
        private System.Windows.Forms.GroupBox gbTopFiles;
        private System.Windows.Forms.Button btnTopBrowseSubstractive;
        private System.Windows.Forms.Button btnTopBrowseAdditive;
        private System.Windows.Forms.TextBox txtTopFileSubstractive;
        private System.Windows.Forms.Label lblTopFileSubstractive;
        private System.Windows.Forms.TextBox txtTopFileAdditive;
        private System.Windows.Forms.Label lblTopFileAdditive;
        private System.Windows.Forms.GroupBox gbTopSlicing;
        private System.Windows.Forms.Button btnTopSlice;
        private System.Windows.Forms.TableLayoutPanel tlpTopFileButtons;
        private System.Windows.Forms.Button btnTopRemoveFiles;
        private System.Windows.Forms.Button btnTopAddFiles;
        private System.Windows.Forms.ListBox lstTopInputFiles;
        private System.Windows.Forms.CheckBox chkTopUseOwnSettings;
        private System.Windows.Forms.CheckBox chkTopUnwrap;
        private System.Windows.Forms.Label lblTopInputFiles;
        private System.Windows.Forms.OpenFileDialog ofdGCode;
        private System.Windows.Forms.CheckBox chkTopGenerateSupport;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpBottomSide;
        private System.Windows.Forms.GroupBox gbBottomFiles;
        private System.Windows.Forms.Button btnBottomBrowseSubstractive;
        private System.Windows.Forms.Button btnBottomBrowseAdditive;
        private System.Windows.Forms.TextBox txtBottomFileSubstractive;
        private System.Windows.Forms.Label lblBottomFileSubstractive;
        private System.Windows.Forms.TextBox txtBottomFileAdditive;
        private System.Windows.Forms.Label lblBottomFileAdditive;
        private System.Windows.Forms.GroupBox gbBottomSlicing;
        private System.Windows.Forms.CheckBox chkBottomGenerateSupport;
        private System.Windows.Forms.Button btnBottomSlice;
        private System.Windows.Forms.TableLayoutPanel tlpBottomFileButtons;
        private System.Windows.Forms.Button btnBottomRemoveFiles;
        private System.Windows.Forms.Button btnBottomAddFiles;
        private System.Windows.Forms.ListBox lstBottomInputFiles;
        private System.Windows.Forms.CheckBox chkBottomUseOwnSettings;
        private System.Windows.Forms.CheckBox chkBottomUnwrap;
        private System.Windows.Forms.Label lblBottomFiles;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpProgress;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbTotal;
        private System.Windows.Forms.ProgressBar pbStep;
        private System.Windows.Forms.Label lblPleaseStandBy;
        private System.Windows.Forms.Button btnUploadPrint;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdGCode;
        private System.Windows.Forms.SaveFileDialog sfdFactory;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage awpActions;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.DataGridView dgvCustomActions;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcTool;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcLayer;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSpeedFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcExtrusionFactor;
        private System.Windows.Forms.GroupBox gbIDRotaryPrinting;
        private System.Windows.Forms.GroupBox gbIslandCombining;
        private System.Windows.Forms.CheckBox cbIslandCombining;
        private System.Windows.Forms.NumericUpDown nudModelID;
    }
}

