namespace TicketPrinter.Windows
{
    partial class ConnectionSetupDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblConnectionOK = new System.Windows.Forms.Label();
            this.lblConnectionNotOK = new System.Windows.Forms.Label();
            this.tConnectionFailed = new System.Windows.Forms.Timer(this.components);
            this.lblTestingConnection = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(336, 157);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(228, 157);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbComPort
            // 
            this.cbComPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(18, 65);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(334, 24);
            this.cbComPort.TabIndex = 2;
            this.cbComPort.SelectedIndexChanged += new System.EventHandler(this.cbComPort_SelectedIndexChanged);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblConnection.Location = new System.Drawing.Point(14, 9);
            this.lblConnection.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(186, 20);
            this.lblConnection.TabIndex = 19;
            this.lblConnection.Text = "Connection configuration";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(15, 45);
            this.lblComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(129, 16);
            this.lblComPort.TabIndex = 20;
            this.lblComPort.Text = "Communication port:";
            // 
            // lblConnectionOK
            // 
            this.lblConnectionOK.AutoSize = true;
            this.lblConnectionOK.ForeColor = System.Drawing.Color.Green;
            this.lblConnectionOK.Location = new System.Drawing.Point(206, 104);
            this.lblConnectionOK.Name = "lblConnectionOK";
            this.lblConnectionOK.Size = new System.Drawing.Size(96, 16);
            this.lblConnectionOK.TabIndex = 23;
            this.lblConnectionOK.Text = "Connection OK";
            this.lblConnectionOK.Visible = false;
            // 
            // lblConnectionNotOK
            // 
            this.lblConnectionNotOK.AutoSize = true;
            this.lblConnectionNotOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConnectionNotOK.Location = new System.Drawing.Point(206, 104);
            this.lblConnectionNotOK.Name = "lblConnectionNotOK";
            this.lblConnectionNotOK.Size = new System.Drawing.Size(224, 16);
            this.lblConnectionNotOK.TabIndex = 24;
            this.lblConnectionNotOK.Text = "Connection could not be established";
            this.lblConnectionNotOK.Visible = false;
            // 
            // tConnectionFailed
            // 
            this.tConnectionFailed.Interval = 5000;
            this.tConnectionFailed.Tick += new System.EventHandler(this.tConnectionFailed_Tick);
            // 
            // lblTestingConnection
            // 
            this.lblTestingConnection.AutoSize = true;
            this.lblTestingConnection.Location = new System.Drawing.Point(206, 104);
            this.lblTestingConnection.Name = "lblTestingConnection";
            this.lblTestingConnection.Size = new System.Drawing.Size(130, 16);
            this.lblTestingConnection.TabIndex = 25;
            this.lblTestingConnection.Text = "Testing connection...";
            this.lblTestingConnection.Visible = false;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Enabled = false;
            this.btnTestConnection.Image = global::TicketPrinter.Properties.Resources.connection;
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(18, 96);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(182, 33);
            this.btnTestConnection.TabIndex = 22;
            this.btnTestConnection.Text = "Test connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Image = global::TicketPrinter.Properties.Resources.refresh_small;
            this.btnRefreshList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshList.Location = new System.Drawing.Point(359, 64);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(81, 24);
            this.btnRefreshList.TabIndex = 21;
            this.btnRefreshList.Text = "Refresh";
            this.btnRefreshList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // ConnectionSetupDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(452, 200);
            this.Controls.Add(this.lblTestingConnection);
            this.Controls.Add(this.lblConnectionOK);
            this.Controls.Add(this.lblConnectionNotOK);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.lblComPort);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.cbComPort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionSetupDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Connection setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionSetupDialog_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionSetupDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblConnectionOK;
        private System.Windows.Forms.Label lblConnectionNotOK;
        private System.Windows.Forms.Timer tConnectionFailed;
        private System.Windows.Forms.Label lblTestingConnection;
    }
}