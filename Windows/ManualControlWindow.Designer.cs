namespace TicketPrinter.Windows
{
    partial class ManualControlWindow
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbPortName = new System.Windows.Forms.ListBox();
            this.btnPortNameRefresh = new System.Windows.Forms.Button();
            this.pnlConnected = new System.Windows.Forms.Panel();
            this.nudRawCmdTimes = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbRawCmd = new System.Windows.Forms.TextBox();
            this.cbOnlyLog = new System.Windows.Forms.CheckBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tCheckPortClosed = new System.Windows.Forms.Timer(this.components);
            this.pnlConnected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCmdTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(12, 227);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(166, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbPortName
            // 
            this.lbPortName.FormattingEnabled = true;
            this.lbPortName.Location = new System.Drawing.Point(12, 12);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(166, 95);
            this.lbPortName.TabIndex = 1;
            this.lbPortName.SelectedIndexChanged += new System.EventHandler(this.lbPortName_SelectedIndexChanged);
            // 
            // btnPortNameRefresh
            // 
            this.btnPortNameRefresh.Location = new System.Drawing.Point(12, 113);
            this.btnPortNameRefresh.Name = "btnPortNameRefresh";
            this.btnPortNameRefresh.Size = new System.Drawing.Size(166, 23);
            this.btnPortNameRefresh.TabIndex = 2;
            this.btnPortNameRefresh.Text = "Refresh";
            this.btnPortNameRefresh.UseVisualStyleBackColor = true;
            this.btnPortNameRefresh.Click += new System.EventHandler(this.btnPortNameRefresh_Click);
            // 
            // pnlConnected
            // 
            this.pnlConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlConnected.Controls.Add(this.nudRawCmdTimes);
            this.pnlConnected.Controls.Add(this.btnRun);
            this.pnlConnected.Controls.Add(this.tbRawCmd);
            this.pnlConnected.Controls.Add(this.cbOnlyLog);
            this.pnlConnected.Controls.Add(this.tbLog);
            this.pnlConnected.Location = new System.Drawing.Point(199, 7);
            this.pnlConnected.Name = "pnlConnected";
            this.pnlConnected.Size = new System.Drawing.Size(902, 542);
            this.pnlConnected.TabIndex = 3;
            // 
            // nudRawCmdTimes
            // 
            this.nudRawCmdTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRawCmdTimes.Location = new System.Drawing.Point(736, 6);
            this.nudRawCmdTimes.Name = "nudRawCmdTimes";
            this.nudRawCmdTimes.Size = new System.Drawing.Size(52, 20);
            this.nudRawCmdTimes.TabIndex = 15;
            this.nudRawCmdTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(630, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 23);
            this.btnRun.TabIndex = 14;
            this.btnRun.Text = "Run cmd x times:";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbRawCmd
            // 
            this.tbRawCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRawCmd.Location = new System.Drawing.Point(3, 5);
            this.tbRawCmd.Name = "tbRawCmd";
            this.tbRawCmd.Size = new System.Drawing.Size(621, 20);
            this.tbRawCmd.TabIndex = 13;
            // 
            // cbOnlyLog
            // 
            this.cbOnlyLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOnlyLog.AutoSize = true;
            this.cbOnlyLog.Location = new System.Drawing.Point(834, 8);
            this.cbOnlyLog.Name = "cbOnlyLog";
            this.cbOnlyLog.Size = new System.Drawing.Size(65, 17);
            this.cbOnlyLog.TabIndex = 9;
            this.cbOnlyLog.Text = "OnlyLog";
            this.cbOnlyLog.UseVisualStyleBackColor = true;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(3, 31);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(896, 508);
            this.tbLog.TabIndex = 5;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(12, 256);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(166, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tCheckPortClosed
            // 
            this.tCheckPortClosed.Tick += new System.EventHandler(this.tCheckPortClosed_Tick);
            // 
            // ManualControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 561);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.pnlConnected);
            this.Controls.Add(this.btnPortNameRefresh);
            this.Controls.Add(this.lbPortName);
            this.Controls.Add(this.btnConnect);
            this.Name = "ManualControlWindow";
            this.Text = "Manual control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.pnlConnected.ResumeLayout(false);
            this.pnlConnected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCmdTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lbPortName;
        private System.Windows.Forms.Button btnPortNameRefresh;
        private System.Windows.Forms.Panel pnlConnected;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.CheckBox cbOnlyLog;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbRawCmd;
        private System.Windows.Forms.NumericUpDown nudRawCmdTimes;
        private System.Windows.Forms.Timer tCheckPortClosed;
    }
}

