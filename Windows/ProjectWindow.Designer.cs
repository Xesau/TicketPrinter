namespace TicketPrinter.Windows
{
    partial class ProjectWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectWindow));
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnReinitialise = new System.Windows.Forms.Button();
            this.lblNextTicketNumber = new System.Windows.Forms.Label();
            this.nudNewTicketNumber = new System.Windows.Forms.NumericUpDown();
            this.nudMagazine = new System.Windows.Forms.NumericUpDown();
            this.btnChooseMagazine = new System.Windows.Forms.Button();
            this.lblCommands = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbConnectionStatus = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnSetupConnection = new System.Windows.Forms.Button();
            this.lblPrinton = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTicketPrinter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnCloseEdit = new System.Windows.Forms.Button();
            this.pnlTicketEditor = new System.Windows.Forms.Panel();
            this.lblTicketPreview = new System.Windows.Forms.Label();
            this.pnlItemSettings = new System.Windows.Forms.Panel();
            this.pnlSpecificItemSettings = new System.Windows.Forms.Panel();
            this.pnlTextSettings = new System.Windows.Forms.Panel();
            this.cbTextSize = new System.Windows.Forms.ComboBox();
            this.nudTextSpacing = new System.Windows.Forms.NumericUpDown();
            this.lblTextSpacing = new System.Windows.Forms.Label();
            this.cbTextFont = new System.Windows.Forms.ComboBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.tbTextString = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlBorderSettings = new System.Windows.Forms.Panel();
            this.nudBorderThickness = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBorderSize = new System.Windows.Forms.Label();
            this.nudBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.nudBorderHeight = new System.Windows.Forms.NumericUpDown();
            this.pnlLineSettings = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLineDirection = new System.Windows.Forms.ComboBox();
            this.nudLineThickness = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLineLength = new System.Windows.Forms.Label();
            this.nudLineLength = new System.Windows.Forms.NumericUpDown();
            this.pnlDateSettings = new System.Windows.Forms.Panel();
            this.tbDateFormat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlHorizontalScaling = new System.Windows.Forms.Panel();
            this.nudHorizontalScaling = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlRotation = new System.Windows.Forms.Panel();
            this.cbRotation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGeneralItemSettings = new System.Windows.Forms.Panel();
            this.cbPositionAlignmentVertical = new System.Windows.Forms.ComboBox();
            this.cbPositionAlignmentHorizontal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItemSettings = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.nudPosX = new System.Windows.Forms.NumericUpDown();
            this.nudPosY = new System.Windows.Forms.NumericUpDown();
            this.pnlItemList = new System.Windows.Forms.Panel();
            this.btnDuplicateItem = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnMoveItemUp = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnMoveItemDown = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lblTicketEditor = new System.Windows.Forms.Label();
            this.pnlTicketBorder = new System.Windows.Forms.Panel();
            this.lblBottomRightCoords = new System.Windows.Forms.Label();
            this.lblTopLeftCoords = new System.Windows.Forms.Label();
            this.pnlTicketItems = new System.Windows.Forms.Panel();
            this.pnlTicketItemButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnAddRectangle = new System.Windows.Forms.Button();
            this.btnAddBarcode = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnAddTicketNumber = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.btnCustomCommand = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.tKeepConnection = new System.Windows.Forms.Timer(this.components);
            this.tWrongDeviceType = new System.Windows.Forms.Timer(this.components);
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewTicketNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagazine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTicketEditor.SuspendLayout();
            this.pnlItemSettings.SuspendLayout();
            this.pnlSpecificItemSettings.SuspendLayout();
            this.pnlTextSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTextSpacing)).BeginInit();
            this.pnlBorderSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderHeight)).BeginInit();
            this.pnlLineSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineLength)).BeginInit();
            this.pnlDateSettings.SuspendLayout();
            this.pnlHorizontalScaling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalScaling)).BeginInit();
            this.pnlRotation.SuspendLayout();
            this.pnlGeneralItemSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosY)).BeginInit();
            this.pnlItemList.SuspendLayout();
            this.pnlTicketBorder.SuspendLayout();
            this.pnlTicketItemButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblConnection.Location = new System.Drawing.Point(13, 103);
            this.lblConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(90, 20);
            this.lblConnection.TabIndex = 18;
            this.lblConnection.Text = "Connection";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Location = new System.Drawing.Point(51, 123);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(147, 32);
            this.lblConnectionStatus.TabIndex = 20;
            this.lblConnectionStatus.Text = "{connection.statusText}";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnReinitialise);
            this.pnlSidebar.Controls.Add(this.lblNextTicketNumber);
            this.pnlSidebar.Controls.Add(this.nudNewTicketNumber);
            this.pnlSidebar.Controls.Add(this.nudMagazine);
            this.pnlSidebar.Controls.Add(this.btnChooseMagazine);
            this.pnlSidebar.Controls.Add(this.lblCommands);
            this.pnlSidebar.Controls.Add(this.lblConnection);
            this.pnlSidebar.Controls.Add(this.lblConnectionStatus);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Controls.Add(this.pbConnectionStatus);
            this.pnlSidebar.Controls.Add(this.btnSave);
            this.pnlSidebar.Controls.Add(this.lblProjectName);
            this.pnlSidebar.Controls.Add(this.btnSetupConnection);
            this.pnlSidebar.Controls.Add(this.lblPrinton);
            this.pnlSidebar.Controls.Add(this.lblVersion);
            this.pnlSidebar.Controls.Add(this.lblTicketPrinter);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(228, 594);
            this.pnlSidebar.TabIndex = 23;
            // 
            // btnReinitialise
            // 
            this.btnReinitialise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReinitialise.Location = new System.Drawing.Point(12, 268);
            this.btnReinitialise.Name = "btnReinitialise";
            this.btnReinitialise.Size = new System.Drawing.Size(210, 22);
            this.btnReinitialise.TabIndex = 60;
            this.btnReinitialise.Text = "Reinitialise";
            this.btnReinitialise.UseVisualStyleBackColor = true;
            this.btnReinitialise.Click += new System.EventHandler(this.btnReinitialise_Click);
            // 
            // lblNextTicketNumber
            // 
            this.lblNextTicketNumber.AutoSize = true;
            this.lblNextTicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextTicketNumber.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNextTicketNumber.Location = new System.Drawing.Point(13, 301);
            this.lblNextTicketNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNextTicketNumber.Name = "lblNextTicketNumber";
            this.lblNextTicketNumber.Size = new System.Drawing.Size(145, 20);
            this.lblNextTicketNumber.TabIndex = 59;
            this.lblNextTicketNumber.Text = "Next ticket number:";
            // 
            // nudNewTicketNumber
            // 
            this.nudNewTicketNumber.Enabled = false;
            this.nudNewTicketNumber.Location = new System.Drawing.Point(12, 324);
            this.nudNewTicketNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudNewTicketNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNewTicketNumber.Name = "nudNewTicketNumber";
            this.nudNewTicketNumber.Size = new System.Drawing.Size(210, 22);
            this.nudNewTicketNumber.TabIndex = 58;
            this.nudNewTicketNumber.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudMagazine
            // 
            this.nudMagazine.Location = new System.Drawing.Point(174, 243);
            this.nudMagazine.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudMagazine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMagazine.Name = "nudMagazine";
            this.nudMagazine.Size = new System.Drawing.Size(48, 22);
            this.nudMagazine.TabIndex = 56;
            this.nudMagazine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnChooseMagazine
            // 
            this.btnChooseMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseMagazine.Location = new System.Drawing.Point(12, 243);
            this.btnChooseMagazine.Name = "btnChooseMagazine";
            this.btnChooseMagazine.Size = new System.Drawing.Size(157, 22);
            this.btnChooseMagazine.TabIndex = 55;
            this.btnChooseMagazine.Text = "Choose magazine";
            this.btnChooseMagazine.UseVisualStyleBackColor = true;
            this.btnChooseMagazine.Click += new System.EventHandler(this.btnChooseMagazine_Click);
            // 
            // lblCommands
            // 
            this.lblCommands.AutoSize = true;
            this.lblCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommands.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCommands.Location = new System.Drawing.Point(13, 220);
            this.lblCommands.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(90, 20);
            this.lblCommands.TabIndex = 54;
            this.lblCommands.Text = "Commands";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::TicketPrinter.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(12, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 35);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbConnectionStatus
            // 
            this.pbConnectionStatus.Image = global::TicketPrinter.Properties.Resources.status_error;
            this.pbConnectionStatus.Location = new System.Drawing.Point(20, 127);
            this.pbConnectionStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pbConnectionStatus.Name = "pbConnectionStatus";
            this.pbConnectionStatus.Size = new System.Drawing.Size(24, 24);
            this.pbConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbConnectionStatus.TabIndex = 19;
            this.pbConnectionStatus.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::TicketPrinter.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 506);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 35);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save project";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(95, 39);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(96, 16);
            this.lblProjectName.TabIndex = 32;
            this.lblProjectName.Text = "{project.name}";
            // 
            // btnSetupConnection
            // 
            this.btnSetupConnection.Image = global::TicketPrinter.Properties.Resources.configure;
            this.btnSetupConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetupConnection.Location = new System.Drawing.Point(12, 158);
            this.btnSetupConnection.Name = "btnSetupConnection";
            this.btnSetupConnection.Size = new System.Drawing.Size(210, 38);
            this.btnSetupConnection.TabIndex = 21;
            this.btnSetupConnection.Text = "Connection setup";
            this.btnSetupConnection.UseVisualStyleBackColor = true;
            this.btnSetupConnection.Click += new System.EventHandler(this.btnSetupConnection_Click);
            // 
            // lblPrinton
            // 
            this.lblPrinton.AutoSize = true;
            this.lblPrinton.ForeColor = System.Drawing.Color.Gray;
            this.lblPrinton.Location = new System.Drawing.Point(96, 71);
            this.lblPrinton.Name = "lblPrinton";
            this.lblPrinton.Size = new System.Drawing.Size(83, 16);
            this.lblPrinton.TabIndex = 25;
            this.lblPrinton.Text = "Priton PK115";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(95, 55);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(74, 16);
            this.lblVersion.TabIndex = 24;
            this.lblVersion.Text = "Version 1.0";
            // 
            // lblTicketPrinter
            // 
            this.lblTicketPrinter.AutoSize = true;
            this.lblTicketPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketPrinter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTicketPrinter.Location = new System.Drawing.Point(95, 12);
            this.lblTicketPrinter.Name = "lblTicketPrinter";
            this.lblTicketPrinter.Size = new System.Drawing.Size(114, 24);
            this.lblTicketPrinter.TabIndex = 23;
            this.lblTicketPrinter.Text = "TicketPrinter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketPrinter.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbTickets
            // 
            this.lbTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.IntegralHeight = false;
            this.lbTickets.ItemHeight = 16;
            this.lbTickets.Location = new System.Drawing.Point(11, 32);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(244, 503);
            this.lbTickets.TabIndex = 27;
            this.lbTickets.SelectedIndexChanged += new System.EventHandler(this.lbTickets_SelectedIndexChanged);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTickets.Location = new System.Drawing.Point(7, 9);
            this.lblTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(59, 20);
            this.lblTickets.TabIndex = 26;
            this.lblTickets.Text = "Tickets";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnRename);
            this.pnlMain.Controls.Add(this.btnCloseEdit);
            this.pnlMain.Controls.Add(this.pnlTicketEditor);
            this.pnlMain.Controls.Add(this.btnPrintTicket);
            this.pnlMain.Controls.Add(this.btnDeleteTicket);
            this.pnlMain.Controls.Add(this.lblTickets);
            this.pnlMain.Controls.Add(this.btnEditTicket);
            this.pnlMain.Controls.Add(this.lbTickets);
            this.pnlMain.Controls.Add(this.btnAddTicket);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(228, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(834, 594);
            this.pnlMain.TabIndex = 24;
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRename.Enabled = false;
            this.btnRename.Image = global::TicketPrinter.Properties.Resources.rename;
            this.btnRename.Location = new System.Drawing.Point(111, 541);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(44, 41);
            this.btnRename.TabIndex = 83;
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseEdit.Image = global::TicketPrinter.Properties.Resources.accept;
            this.btnCloseEdit.Location = new System.Drawing.Point(61, 541);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(44, 41);
            this.btnCloseEdit.TabIndex = 82;
            this.btnCloseEdit.UseVisualStyleBackColor = true;
            this.btnCloseEdit.Visible = false;
            this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
            // 
            // pnlTicketEditor
            // 
            this.pnlTicketEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTicketEditor.Controls.Add(this.lblTicketPreview);
            this.pnlTicketEditor.Controls.Add(this.pnlItemSettings);
            this.pnlTicketEditor.Controls.Add(this.lblTicketEditor);
            this.pnlTicketEditor.Controls.Add(this.pnlTicketBorder);
            this.pnlTicketEditor.Controls.Add(this.pnlTicketItemButtons);
            this.pnlTicketEditor.Controls.Add(this.label8);
            this.pnlTicketEditor.Location = new System.Drawing.Point(261, 0);
            this.pnlTicketEditor.Name = "pnlTicketEditor";
            this.pnlTicketEditor.Size = new System.Drawing.Size(573, 594);
            this.pnlTicketEditor.TabIndex = 81;
            // 
            // lblTicketPreview
            // 
            this.lblTicketPreview.AutoSize = true;
            this.lblTicketPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketPreview.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTicketPreview.Location = new System.Drawing.Point(4, 12);
            this.lblTicketPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketPreview.Name = "lblTicketPreview";
            this.lblTicketPreview.Size = new System.Drawing.Size(108, 20);
            this.lblTicketPreview.TabIndex = 80;
            this.lblTicketPreview.Text = "Ticket preview";
            // 
            // pnlItemSettings
            // 
            this.pnlItemSettings.Controls.Add(this.pnlSpecificItemSettings);
            this.pnlItemSettings.Controls.Add(this.pnlGeneralItemSettings);
            this.pnlItemSettings.Controls.Add(this.pnlItemList);
            this.pnlItemSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlItemSettings.Location = new System.Drawing.Point(274, 0);
            this.pnlItemSettings.Name = "pnlItemSettings";
            this.pnlItemSettings.Size = new System.Drawing.Size(299, 594);
            this.pnlItemSettings.TabIndex = 61;
            // 
            // pnlSpecificItemSettings
            // 
            this.pnlSpecificItemSettings.Controls.Add(this.pnlTextSettings);
            this.pnlSpecificItemSettings.Controls.Add(this.pnlBorderSettings);
            this.pnlSpecificItemSettings.Controls.Add(this.pnlLineSettings);
            this.pnlSpecificItemSettings.Controls.Add(this.pnlDateSettings);
            this.pnlSpecificItemSettings.Controls.Add(this.pnlHorizontalScaling);
            this.pnlSpecificItemSettings.Controls.Add(this.pnlRotation);
            this.pnlSpecificItemSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpecificItemSettings.Location = new System.Drawing.Point(0, 304);
            this.pnlSpecificItemSettings.Name = "pnlSpecificItemSettings";
            this.pnlSpecificItemSettings.Size = new System.Drawing.Size(299, 290);
            this.pnlSpecificItemSettings.TabIndex = 64;
            // 
            // pnlTextSettings
            // 
            this.pnlTextSettings.Controls.Add(this.cbTextSize);
            this.pnlTextSettings.Controls.Add(this.nudTextSpacing);
            this.pnlTextSettings.Controls.Add(this.lblTextSpacing);
            this.pnlTextSettings.Controls.Add(this.cbTextFont);
            this.pnlTextSettings.Controls.Add(this.lblFontSize);
            this.pnlTextSettings.Controls.Add(this.lblFont);
            this.pnlTextSettings.Controls.Add(this.tbTextString);
            this.pnlTextSettings.Controls.Add(this.lblText);
            this.pnlTextSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTextSettings.Location = new System.Drawing.Point(0, 320);
            this.pnlTextSettings.Name = "pnlTextSettings";
            this.pnlTextSettings.Size = new System.Drawing.Size(299, 160);
            this.pnlTextSettings.TabIndex = 0;
            // 
            // cbTextSize
            // 
            this.cbTextSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextSize.FormattingEnabled = true;
            this.cbTextSize.Items.AddRange(new object[] {
            "Arial, Bold",
            "Courier, Bold"});
            this.cbTextSize.Location = new System.Drawing.Point(8, 133);
            this.cbTextSize.Name = "cbTextSize";
            this.cbTextSize.Size = new System.Drawing.Size(143, 24);
            this.cbTextSize.TabIndex = 79;
            this.cbTextSize.SelectedIndexChanged += new System.EventHandler(this.cbTextSize_SelectedIndexChanged);
            // 
            // nudTextSpacing
            // 
            this.nudTextSpacing.Location = new System.Drawing.Point(157, 135);
            this.nudTextSpacing.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTextSpacing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTextSpacing.Name = "nudTextSpacing";
            this.nudTextSpacing.Size = new System.Drawing.Size(130, 22);
            this.nudTextSpacing.TabIndex = 78;
            this.nudTextSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTextSpacing.ValueChanged += new System.EventHandler(this.nudTextSpacing_ValueChanged);
            // 
            // lblTextSpacing
            // 
            this.lblTextSpacing.AutoSize = true;
            this.lblTextSpacing.Location = new System.Drawing.Point(154, 116);
            this.lblTextSpacing.Name = "lblTextSpacing";
            this.lblTextSpacing.Size = new System.Drawing.Size(88, 16);
            this.lblTextSpacing.TabIndex = 77;
            this.lblTextSpacing.Text = "Text spacing:";
            // 
            // cbTextFont
            // 
            this.cbTextFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextFont.FormattingEnabled = true;
            this.cbTextFont.Items.AddRange(new object[] {
            "Arial, Bold",
            "Courier, Bold"});
            this.cbTextFont.Location = new System.Drawing.Point(8, 89);
            this.cbTextFont.Name = "cbTextFont";
            this.cbTextFont.Size = new System.Drawing.Size(279, 24);
            this.cbTextFont.TabIndex = 76;
            this.cbTextFont.SelectedIndexChanged += new System.EventHandler(this.cbTextFont_SelectedIndexChanged);
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(6, 116);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(64, 16);
            this.lblFontSize.TabIndex = 74;
            this.lblFontSize.Text = "Font size:";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(6, 70);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(34, 16);
            this.lblFont.TabIndex = 75;
            this.lblFont.Text = "Font";
            // 
            // tbTextString
            // 
            this.tbTextString.Location = new System.Drawing.Point(9, 22);
            this.tbTextString.Multiline = true;
            this.tbTextString.Name = "tbTextString";
            this.tbTextString.Size = new System.Drawing.Size(278, 45);
            this.tbTextString.TabIndex = 62;
            this.tbTextString.TextChanged += new System.EventHandler(this.tbTextString_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(5, 3);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(37, 16);
            this.lblText.TabIndex = 74;
            this.lblText.Text = "Text:";
            // 
            // pnlBorderSettings
            // 
            this.pnlBorderSettings.Controls.Add(this.nudBorderThickness);
            this.pnlBorderSettings.Controls.Add(this.label4);
            this.pnlBorderSettings.Controls.Add(this.lblBorderSize);
            this.pnlBorderSettings.Controls.Add(this.nudBorderWidth);
            this.pnlBorderSettings.Controls.Add(this.nudBorderHeight);
            this.pnlBorderSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorderSettings.Location = new System.Drawing.Point(0, 235);
            this.pnlBorderSettings.Name = "pnlBorderSettings";
            this.pnlBorderSettings.Size = new System.Drawing.Size(299, 85);
            this.pnlBorderSettings.TabIndex = 79;
            // 
            // nudBorderThickness
            // 
            this.nudBorderThickness.Location = new System.Drawing.Point(9, 62);
            this.nudBorderThickness.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBorderThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBorderThickness.Name = "nudBorderThickness";
            this.nudBorderThickness.Size = new System.Drawing.Size(278, 22);
            this.nudBorderThickness.TabIndex = 75;
            this.nudBorderThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBorderThickness.ValueChanged += new System.EventHandler(this.nudBorderThickness_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Border thickness:";
            // 
            // lblBorderSize
            // 
            this.lblBorderSize.AutoSize = true;
            this.lblBorderSize.Location = new System.Drawing.Point(6, 2);
            this.lblBorderSize.Name = "lblBorderSize";
            this.lblBorderSize.Size = new System.Drawing.Size(154, 16);
            this.lblBorderSize.TabIndex = 67;
            this.lblBorderSize.Text = "Size: (horizontal, vertical)";
            // 
            // nudBorderWidth
            // 
            this.nudBorderWidth.Location = new System.Drawing.Point(8, 21);
            this.nudBorderWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBorderWidth.Name = "nudBorderWidth";
            this.nudBorderWidth.Size = new System.Drawing.Size(129, 22);
            this.nudBorderWidth.TabIndex = 68;
            this.nudBorderWidth.ValueChanged += new System.EventHandler(this.nudBorderWidth_ValueChanged);
            // 
            // nudBorderHeight
            // 
            this.nudBorderHeight.Location = new System.Drawing.Point(141, 21);
            this.nudBorderHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBorderHeight.Name = "nudBorderHeight";
            this.nudBorderHeight.Size = new System.Drawing.Size(144, 22);
            this.nudBorderHeight.TabIndex = 69;
            this.nudBorderHeight.ValueChanged += new System.EventHandler(this.nudBorderHeight_ValueChanged);
            // 
            // pnlLineSettings
            // 
            this.pnlLineSettings.Controls.Add(this.label11);
            this.pnlLineSettings.Controls.Add(this.cbLineDirection);
            this.pnlLineSettings.Controls.Add(this.nudLineThickness);
            this.pnlLineSettings.Controls.Add(this.label9);
            this.pnlLineSettings.Controls.Add(this.lblLineLength);
            this.pnlLineSettings.Controls.Add(this.nudLineLength);
            this.pnlLineSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineSettings.Location = new System.Drawing.Point(0, 145);
            this.pnlLineSettings.Name = "pnlLineSettings";
            this.pnlLineSettings.Size = new System.Drawing.Size(299, 90);
            this.pnlLineSettings.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 80;
            this.label11.Text = "Direction:";
            // 
            // cbLineDirection
            // 
            this.cbLineDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineDirection.FormattingEnabled = true;
            this.cbLineDirection.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.cbLineDirection.Location = new System.Drawing.Point(143, 19);
            this.cbLineDirection.Name = "cbLineDirection";
            this.cbLineDirection.Size = new System.Drawing.Size(144, 24);
            this.cbLineDirection.TabIndex = 74;
            this.cbLineDirection.SelectedIndexChanged += new System.EventHandler(this.cbLineDirection_SelectedIndexChanged);
            // 
            // nudLineThickness
            // 
            this.nudLineThickness.Location = new System.Drawing.Point(8, 64);
            this.nudLineThickness.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineThickness.Name = "nudLineThickness";
            this.nudLineThickness.Size = new System.Drawing.Size(278, 22);
            this.nudLineThickness.TabIndex = 79;
            this.nudLineThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineThickness.ValueChanged += new System.EventHandler(this.nudLineThickness_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Line thickness:";
            // 
            // lblLineLength
            // 
            this.lblLineLength.AutoSize = true;
            this.lblLineLength.Location = new System.Drawing.Point(6, 2);
            this.lblLineLength.Name = "lblLineLength";
            this.lblLineLength.Size = new System.Drawing.Size(37, 16);
            this.lblLineLength.TabIndex = 76;
            this.lblLineLength.Text = "Size:";
            // 
            // nudLineLength
            // 
            this.nudLineLength.Location = new System.Drawing.Point(8, 21);
            this.nudLineLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLineLength.Name = "nudLineLength";
            this.nudLineLength.Size = new System.Drawing.Size(129, 22);
            this.nudLineLength.TabIndex = 77;
            this.nudLineLength.ValueChanged += new System.EventHandler(this.nudLineLength_ValueChanged);
            // 
            // pnlDateSettings
            // 
            this.pnlDateSettings.Controls.Add(this.tbDateFormat);
            this.pnlDateSettings.Controls.Add(this.label10);
            this.pnlDateSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDateSettings.Location = new System.Drawing.Point(0, 95);
            this.pnlDateSettings.Name = "pnlDateSettings";
            this.pnlDateSettings.Size = new System.Drawing.Size(299, 50);
            this.pnlDateSettings.TabIndex = 79;
            // 
            // tbDateFormat
            // 
            this.tbDateFormat.Location = new System.Drawing.Point(8, 22);
            this.tbDateFormat.Name = "tbDateFormat";
            this.tbDateFormat.Size = new System.Drawing.Size(279, 22);
            this.tbDateFormat.TabIndex = 74;
            this.tbDateFormat.Text = "dd-mm-yyyy";
            this.tbDateFormat.TextChanged += new System.EventHandler(this.tbDateFormat_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 73;
            this.label10.Text = "Date format:";
            // 
            // pnlHorizontalScaling
            // 
            this.pnlHorizontalScaling.Controls.Add(this.nudHorizontalScaling);
            this.pnlHorizontalScaling.Controls.Add(this.label7);
            this.pnlHorizontalScaling.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHorizontalScaling.Location = new System.Drawing.Point(0, 45);
            this.pnlHorizontalScaling.Name = "pnlHorizontalScaling";
            this.pnlHorizontalScaling.Size = new System.Drawing.Size(299, 50);
            this.pnlHorizontalScaling.TabIndex = 80;
            // 
            // nudHorizontalScaling
            // 
            this.nudHorizontalScaling.Location = new System.Drawing.Point(9, 21);
            this.nudHorizontalScaling.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHorizontalScaling.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHorizontalScaling.Name = "nudHorizontalScaling";
            this.nudHorizontalScaling.Size = new System.Drawing.Size(278, 22);
            this.nudHorizontalScaling.TabIndex = 75;
            this.nudHorizontalScaling.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Horizontal scaling:";
            // 
            // pnlRotation
            // 
            this.pnlRotation.Controls.Add(this.cbRotation);
            this.pnlRotation.Controls.Add(this.label2);
            this.pnlRotation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRotation.Location = new System.Drawing.Point(0, 0);
            this.pnlRotation.Name = "pnlRotation";
            this.pnlRotation.Size = new System.Drawing.Size(299, 45);
            this.pnlRotation.TabIndex = 72;
            // 
            // cbRotation
            // 
            this.cbRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRotation.FormattingEnabled = true;
            this.cbRotation.Items.AddRange(new object[] {
            "0°",
            "180°",
            "90°",
            "270°"});
            this.cbRotation.Location = new System.Drawing.Point(7, 20);
            this.cbRotation.Name = "cbRotation";
            this.cbRotation.Size = new System.Drawing.Size(279, 24);
            this.cbRotation.TabIndex = 70;
            this.cbRotation.SelectedIndexChanged += new System.EventHandler(this.cbRotation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Rotation:";
            // 
            // pnlGeneralItemSettings
            // 
            this.pnlGeneralItemSettings.Controls.Add(this.cbPositionAlignmentVertical);
            this.pnlGeneralItemSettings.Controls.Add(this.cbPositionAlignmentHorizontal);
            this.pnlGeneralItemSettings.Controls.Add(this.label6);
            this.pnlGeneralItemSettings.Controls.Add(this.lblItemSettings);
            this.pnlGeneralItemSettings.Controls.Add(this.lblPosition);
            this.pnlGeneralItemSettings.Controls.Add(this.nudPosX);
            this.pnlGeneralItemSettings.Controls.Add(this.nudPosY);
            this.pnlGeneralItemSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGeneralItemSettings.Location = new System.Drawing.Point(0, 188);
            this.pnlGeneralItemSettings.Name = "pnlGeneralItemSettings";
            this.pnlGeneralItemSettings.Size = new System.Drawing.Size(299, 116);
            this.pnlGeneralItemSettings.TabIndex = 63;
            // 
            // cbPositionAlignmentVertical
            // 
            this.cbPositionAlignmentVertical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPositionAlignmentVertical.FormattingEnabled = true;
            this.cbPositionAlignmentVertical.Items.AddRange(new object[] {
            "Top",
            "Center",
            "Bottom"});
            this.cbPositionAlignmentVertical.Location = new System.Drawing.Point(143, 86);
            this.cbPositionAlignmentVertical.Name = "cbPositionAlignmentVertical";
            this.cbPositionAlignmentVertical.Size = new System.Drawing.Size(144, 24);
            this.cbPositionAlignmentVertical.TabIndex = 71;
            this.cbPositionAlignmentVertical.SelectedIndexChanged += new System.EventHandler(this.cbPositionAlignmentVertical_SelectedIndexChanged);
            // 
            // cbPositionAlignmentHorizontal
            // 
            this.cbPositionAlignmentHorizontal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPositionAlignmentHorizontal.FormattingEnabled = true;
            this.cbPositionAlignmentHorizontal.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.cbPositionAlignmentHorizontal.Location = new System.Drawing.Point(8, 86);
            this.cbPositionAlignmentHorizontal.Name = "cbPositionAlignmentHorizontal";
            this.cbPositionAlignmentHorizontal.Size = new System.Drawing.Size(129, 24);
            this.cbPositionAlignmentHorizontal.TabIndex = 70;
            this.cbPositionAlignmentHorizontal.SelectedIndexChanged += new System.EventHandler(this.cbPositionAlignmentHorizontal_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Position alignment: (horizontal, vertical)";
            // 
            // lblItemSettings
            // 
            this.lblItemSettings.AutoSize = true;
            this.lblItemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSettings.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblItemSettings.Location = new System.Drawing.Point(5, 0);
            this.lblItemSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemSettings.Name = "lblItemSettings";
            this.lblItemSettings.Size = new System.Drawing.Size(101, 20);
            this.lblItemSettings.TabIndex = 63;
            this.lblItemSettings.Text = "Item settings";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(5, 23);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(176, 16);
            this.lblPosition.TabIndex = 64;
            this.lblPosition.Text = "Position: (horizontal, vertical)";
            // 
            // nudPosX
            // 
            this.nudPosX.Location = new System.Drawing.Point(8, 42);
            this.nudPosX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPosX.Name = "nudPosX";
            this.nudPosX.Size = new System.Drawing.Size(129, 22);
            this.nudPosX.TabIndex = 65;
            this.nudPosX.ValueChanged += new System.EventHandler(this.nudPosX_ValueChanged);
            // 
            // nudPosY
            // 
            this.nudPosY.Location = new System.Drawing.Point(143, 42);
            this.nudPosY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPosY.Name = "nudPosY";
            this.nudPosY.Size = new System.Drawing.Size(144, 22);
            this.nudPosY.TabIndex = 66;
            this.nudPosY.ValueChanged += new System.EventHandler(this.nudPosY_ValueChanged);
            // 
            // pnlItemList
            // 
            this.pnlItemList.Controls.Add(this.btnDuplicateItem);
            this.pnlItemList.Controls.Add(this.lblItems);
            this.pnlItemList.Controls.Add(this.btnMoveItemUp);
            this.pnlItemList.Controls.Add(this.btnRemoveItem);
            this.pnlItemList.Controls.Add(this.btnMoveItemDown);
            this.pnlItemList.Controls.Add(this.lbItems);
            this.pnlItemList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemList.Location = new System.Drawing.Point(0, 0);
            this.pnlItemList.Name = "pnlItemList";
            this.pnlItemList.Size = new System.Drawing.Size(299, 188);
            this.pnlItemList.TabIndex = 74;
            // 
            // btnDuplicateItem
            // 
            this.btnDuplicateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuplicateItem.Enabled = false;
            this.btnDuplicateItem.Image = global::TicketPrinter.Properties.Resources.copy;
            this.btnDuplicateItem.Location = new System.Drawing.Point(248, 95);
            this.btnDuplicateItem.Name = "btnDuplicateItem";
            this.btnDuplicateItem.Size = new System.Drawing.Size(39, 39);
            this.btnDuplicateItem.TabIndex = 61;
            this.btnDuplicateItem.UseVisualStyleBackColor = true;
            this.btnDuplicateItem.Click += new System.EventHandler(this.btnDuplicateItem_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblItems.Location = new System.Drawing.Point(4, 12);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(49, 20);
            this.lblItems.TabIndex = 53;
            this.lblItems.Text = "Items";
            // 
            // btnMoveItemUp
            // 
            this.btnMoveItemUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveItemUp.Enabled = false;
            this.btnMoveItemUp.Image = global::TicketPrinter.Properties.Resources.up;
            this.btnMoveItemUp.Location = new System.Drawing.Point(248, 35);
            this.btnMoveItemUp.Name = "btnMoveItemUp";
            this.btnMoveItemUp.Size = new System.Drawing.Size(39, 39);
            this.btnMoveItemUp.TabIndex = 46;
            this.btnMoveItemUp.UseVisualStyleBackColor = true;
            this.btnMoveItemUp.Visible = false;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Image = global::TicketPrinter.Properties.Resources.delete;
            this.btnRemoveItem.Location = new System.Drawing.Point(248, 138);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(39, 39);
            this.btnRemoveItem.TabIndex = 60;
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnMoveItemDown
            // 
            this.btnMoveItemDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveItemDown.Enabled = false;
            this.btnMoveItemDown.Image = global::TicketPrinter.Properties.Resources.down;
            this.btnMoveItemDown.Location = new System.Drawing.Point(248, 35);
            this.btnMoveItemDown.Name = "btnMoveItemDown";
            this.btnMoveItemDown.Size = new System.Drawing.Size(39, 39);
            this.btnMoveItemDown.TabIndex = 47;
            this.btnMoveItemDown.UseVisualStyleBackColor = true;
            this.btnMoveItemDown.Visible = false;
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.IntegralHeight = false;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(8, 35);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(234, 142);
            this.lbItems.TabIndex = 52;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // lblTicketEditor
            // 
            this.lblTicketEditor.AutoSize = true;
            this.lblTicketEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketEditor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTicketEditor.Location = new System.Drawing.Point(4, 12);
            this.lblTicketEditor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketEditor.Name = "lblTicketEditor";
            this.lblTicketEditor.Size = new System.Drawing.Size(95, 20);
            this.lblTicketEditor.TabIndex = 32;
            this.lblTicketEditor.Text = "Ticket editor";
            // 
            // pnlTicketBorder
            // 
            this.pnlTicketBorder.BackgroundImage = global::TicketPrinter.Properties.Resources.ticket_editor;
            this.pnlTicketBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTicketBorder.Controls.Add(this.lblBottomRightCoords);
            this.pnlTicketBorder.Controls.Add(this.lblTopLeftCoords);
            this.pnlTicketBorder.Controls.Add(this.pnlTicketItems);
            this.pnlTicketBorder.Location = new System.Drawing.Point(8, 32);
            this.pnlTicketBorder.Name = "pnlTicketBorder";
            this.pnlTicketBorder.Size = new System.Drawing.Size(180, 420);
            this.pnlTicketBorder.TabIndex = 33;
            // 
            // lblBottomRightCoords
            // 
            this.lblBottomRightCoords.AutoSize = true;
            this.lblBottomRightCoords.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomRightCoords.Location = new System.Drawing.Point(97, 398);
            this.lblBottomRightCoords.Name = "lblBottomRightCoords";
            this.lblBottomRightCoords.Size = new System.Drawing.Size(64, 16);
            this.lblBottomRightCoords.TabIndex = 85;
            this.lblBottomRightCoords.Text = "(280, 750)";
            // 
            // lblTopLeftCoords
            // 
            this.lblTopLeftCoords.AutoSize = true;
            this.lblTopLeftCoords.BackColor = System.Drawing.Color.Transparent;
            this.lblTopLeftCoords.Location = new System.Drawing.Point(21, 2);
            this.lblTopLeftCoords.Name = "lblTopLeftCoords";
            this.lblTopLeftCoords.Size = new System.Drawing.Size(36, 16);
            this.lblTopLeftCoords.TabIndex = 84;
            this.lblTopLeftCoords.Text = "(0, 0)";
            // 
            // pnlTicketItems
            // 
            this.pnlTicketItems.BackColor = System.Drawing.Color.Transparent;
            this.pnlTicketItems.Location = new System.Drawing.Point(20, 20);
            this.pnlTicketItems.Name = "pnlTicketItems";
            this.pnlTicketItems.Size = new System.Drawing.Size(140, 375);
            this.pnlTicketItems.TabIndex = 62;
            this.pnlTicketItems.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTicketItems_Paint);
            // 
            // pnlTicketItemButtons
            // 
            this.pnlTicketItemButtons.Controls.Add(this.btnAddText);
            this.pnlTicketItemButtons.Controls.Add(this.btnAddLine);
            this.pnlTicketItemButtons.Controls.Add(this.btnAddRectangle);
            this.pnlTicketItemButtons.Controls.Add(this.btnAddBarcode);
            this.pnlTicketItemButtons.Controls.Add(this.btnAddImage);
            this.pnlTicketItemButtons.Controls.Add(this.btnAddTicketNumber);
            this.pnlTicketItemButtons.Controls.Add(this.btnAddDate);
            this.pnlTicketItemButtons.Controls.Add(this.btnCustomCommand);
            this.pnlTicketItemButtons.Location = new System.Drawing.Point(194, 32);
            this.pnlTicketItemButtons.Name = "pnlTicketItemButtons";
            this.pnlTicketItemButtons.Size = new System.Drawing.Size(44, 420);
            this.pnlTicketItemButtons.TabIndex = 63;
            // 
            // btnAddText
            // 
            this.btnAddText.Image = global::TicketPrinter.Properties.Resources.text;
            this.btnAddText.Location = new System.Drawing.Point(3, 3);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(39, 39);
            this.btnAddText.TabIndex = 44;
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Image = global::TicketPrinter.Properties.Resources.line;
            this.btnAddLine.Location = new System.Drawing.Point(3, 48);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(39, 39);
            this.btnAddLine.TabIndex = 45;
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnAddRectangle
            // 
            this.btnAddRectangle.Image = global::TicketPrinter.Properties.Resources.border;
            this.btnAddRectangle.Location = new System.Drawing.Point(3, 93);
            this.btnAddRectangle.Name = "btnAddRectangle";
            this.btnAddRectangle.Size = new System.Drawing.Size(39, 39);
            this.btnAddRectangle.TabIndex = 49;
            this.btnAddRectangle.UseVisualStyleBackColor = true;
            this.btnAddRectangle.Click += new System.EventHandler(this.btnAddRectangle_Click);
            // 
            // btnAddBarcode
            // 
            this.btnAddBarcode.Image = global::TicketPrinter.Properties.Resources.barcode;
            this.btnAddBarcode.Location = new System.Drawing.Point(3, 138);
            this.btnAddBarcode.Name = "btnAddBarcode";
            this.btnAddBarcode.Size = new System.Drawing.Size(39, 39);
            this.btnAddBarcode.TabIndex = 48;
            this.btnAddBarcode.UseVisualStyleBackColor = true;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Image = global::TicketPrinter.Properties.Resources.image;
            this.btnAddImage.Location = new System.Drawing.Point(3, 183);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(39, 39);
            this.btnAddImage.TabIndex = 50;
            this.btnAddImage.UseVisualStyleBackColor = true;
            // 
            // btnAddTicketNumber
            // 
            this.btnAddTicketNumber.Image = global::TicketPrinter.Properties.Resources.numbers;
            this.btnAddTicketNumber.Location = new System.Drawing.Point(3, 228);
            this.btnAddTicketNumber.Name = "btnAddTicketNumber";
            this.btnAddTicketNumber.Size = new System.Drawing.Size(39, 39);
            this.btnAddTicketNumber.TabIndex = 51;
            this.btnAddTicketNumber.UseVisualStyleBackColor = true;
            this.btnAddTicketNumber.Click += new System.EventHandler(this.btnAddTicketNumber_Click);
            // 
            // btnAddDate
            // 
            this.btnAddDate.Image = global::TicketPrinter.Properties.Resources.calendar;
            this.btnAddDate.Location = new System.Drawing.Point(3, 273);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(39, 39);
            this.btnAddDate.TabIndex = 52;
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // btnCustomCommand
            // 
            this.btnCustomCommand.Image = global::TicketPrinter.Properties.Resources.configure;
            this.btnCustomCommand.Location = new System.Drawing.Point(3, 318);
            this.btnCustomCommand.Name = "btnCustomCommand";
            this.btnCustomCommand.Size = new System.Drawing.Size(39, 39);
            this.btnCustomCommand.TabIndex = 53;
            this.btnCustomCommand.UseVisualStyleBackColor = true;
            this.btnCustomCommand.Visible = false;
            this.btnCustomCommand.Click += new System.EventHandler(this.btnCustomCommand_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 119);
            this.label8.TabIndex = 79;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintTicket.Enabled = false;
            this.btnPrintTicket.Image = global::TicketPrinter.Properties.Resources.print;
            this.btnPrintTicket.Location = new System.Drawing.Point(211, 541);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(44, 41);
            this.btnPrintTicket.TabIndex = 31;
            this.btnPrintTicket.UseVisualStyleBackColor = true;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTicket.Enabled = false;
            this.btnDeleteTicket.Image = global::TicketPrinter.Properties.Resources.delete;
            this.btnDeleteTicket.Location = new System.Drawing.Point(161, 541);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(44, 41);
            this.btnDeleteTicket.TabIndex = 30;
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTicket.Enabled = false;
            this.btnEditTicket.Image = global::TicketPrinter.Properties.Resources.edit;
            this.btnEditTicket.Location = new System.Drawing.Point(61, 541);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(44, 41);
            this.btnEditTicket.TabIndex = 29;
            this.btnEditTicket.UseVisualStyleBackColor = true;
            this.btnEditTicket.Click += new System.EventHandler(this.btnEditTicket_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTicket.Image = global::TicketPrinter.Properties.Resources.add;
            this.btnAddTicket.Location = new System.Drawing.Point(11, 541);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(44, 41);
            this.btnAddTicket.TabIndex = 28;
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // tKeepConnection
            // 
            this.tKeepConnection.Interval = 5000;
            this.tKeepConnection.Tick += new System.EventHandler(this.tKeepConnection_Tick);
            // 
            // tWrongDeviceType
            // 
            this.tWrongDeviceType.Interval = 5000;
            this.tWrongDeviceType.Tick += new System.EventHandler(this.tWrongDeviceType_Tick);
            // 
            // ProjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 594);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectWindow";
            this.Text = "TicketPrinter - Project: {project.name} ({file})";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectWindow_FormClosed);
            this.Load += new System.EventHandler(this.ProjectWindow_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewTicketNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagazine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTicketEditor.ResumeLayout(false);
            this.pnlTicketEditor.PerformLayout();
            this.pnlItemSettings.ResumeLayout(false);
            this.pnlSpecificItemSettings.ResumeLayout(false);
            this.pnlTextSettings.ResumeLayout(false);
            this.pnlTextSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTextSpacing)).EndInit();
            this.pnlBorderSettings.ResumeLayout(false);
            this.pnlBorderSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderHeight)).EndInit();
            this.pnlLineSettings.ResumeLayout(false);
            this.pnlLineSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineLength)).EndInit();
            this.pnlDateSettings.ResumeLayout(false);
            this.pnlDateSettings.PerformLayout();
            this.pnlHorizontalScaling.ResumeLayout(false);
            this.pnlHorizontalScaling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalScaling)).EndInit();
            this.pnlRotation.ResumeLayout(false);
            this.pnlRotation.PerformLayout();
            this.pnlGeneralItemSettings.ResumeLayout(false);
            this.pnlGeneralItemSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosY)).EndInit();
            this.pnlItemList.ResumeLayout(false);
            this.pnlItemList.PerformLayout();
            this.pnlTicketBorder.ResumeLayout(false);
            this.pnlTicketBorder.PerformLayout();
            this.pnlTicketItemButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.PictureBox pbConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnSetupConnection;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblPrinton;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTicketPrinter;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Timer tKeepConnection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer tWrongDeviceType;
        private System.Windows.Forms.Panel pnlTicketBorder;
        private System.Windows.Forms.Label lblTicketEditor;
        private System.Windows.Forms.Button btnAddTicketNumber;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnAddRectangle;
        private System.Windows.Forms.Button btnAddBarcode;
        private System.Windows.Forms.Button btnMoveItemDown;
        private System.Windows.Forms.Button btnMoveItemUp;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.NumericUpDown nudMagazine;
        private System.Windows.Forms.Button btnChooseMagazine;
        private System.Windows.Forms.Label lblCommands;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel pnlItemSettings;
        private System.Windows.Forms.Panel pnlSpecificItemSettings;
        private System.Windows.Forms.Panel pnlGeneralItemSettings;
        private System.Windows.Forms.ComboBox cbPositionAlignmentVertical;
        private System.Windows.Forms.ComboBox cbPositionAlignmentHorizontal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItemSettings;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.NumericUpDown nudPosX;
        private System.Windows.Forms.NumericUpDown nudPosY;
        private System.Windows.Forms.Panel pnlItemList;
        private System.Windows.Forms.NumericUpDown nudNewTicketNumber;
        private System.Windows.Forms.Panel pnlTextSettings;
        private System.Windows.Forms.NumericUpDown nudTextSpacing;
        private System.Windows.Forms.Label lblTextSpacing;
        private System.Windows.Forms.ComboBox cbTextFont;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TextBox tbTextString;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel pnlTicketItems;
        private System.Windows.Forms.FlowLayoutPanel pnlTicketItemButtons;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.Panel pnlDateSettings;
        private System.Windows.Forms.TextBox tbDateFormat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNextTicketNumber;
        private System.Windows.Forms.Panel pnlBorderSettings;
        private System.Windows.Forms.NumericUpDown nudBorderThickness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBorderSize;
        private System.Windows.Forms.NumericUpDown nudBorderWidth;
        private System.Windows.Forms.NumericUpDown nudBorderHeight;
        private System.Windows.Forms.ComboBox cbTextSize;
        private System.Windows.Forms.Panel pnlLineSettings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLineDirection;
        private System.Windows.Forms.NumericUpDown nudLineThickness;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLineLength;
        private System.Windows.Forms.NumericUpDown nudLineLength;
        private System.Windows.Forms.Panel pnlHorizontalScaling;
        private System.Windows.Forms.NumericUpDown nudHorizontalScaling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlTicketEditor;
        private System.Windows.Forms.Panel pnlRotation;
        private System.Windows.Forms.ComboBox cbRotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTicketPreview;
        private System.Windows.Forms.Button btnCloseEdit;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnDuplicateItem;
        private System.Windows.Forms.Label lblBottomRightCoords;
        private System.Windows.Forms.Label lblTopLeftCoords;
        private System.Windows.Forms.Button btnReinitialise;
        private System.Windows.Forms.Button btnCustomCommand;
    }
}