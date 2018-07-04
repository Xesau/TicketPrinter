namespace TicketPrinter.Windows
{
    partial class StartupWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupWindow));
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.lbRecentProjects = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRecentProject8 = new System.Windows.Forms.Button();
            this.btnRecentProject7 = new System.Windows.Forms.Button();
            this.btnRecentProject6 = new System.Windows.Forms.Button();
            this.btnRecentProject5 = new System.Windows.Forms.Button();
            this.btnRecentProject4 = new System.Windows.Forms.Button();
            this.btnRecentProject3 = new System.Windows.Forms.Button();
            this.btnRecentProject2 = new System.Windows.Forms.Button();
            this.btnRecentProject1 = new System.Windows.Forms.Button();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.btnShowAbout = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnOpenManualControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.Location = new System.Drawing.Point(233, 42);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(428, 35);
            this.lblWelcomeText.TabIndex = 1;
            this.lblWelcomeText.Text = "To start TicketPrinter, select a project file, or create a new one. Profject file" +
    "s are used to save printer settings, ticket designs and more information.";
            // 
            // lbRecentProjects
            // 
            this.lbRecentProjects.AutoSize = true;
            this.lbRecentProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecentProjects.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbRecentProjects.Location = new System.Drawing.Point(232, 91);
            this.lbRecentProjects.Name = "lbRecentProjects";
            this.lbRecentProjects.Size = new System.Drawing.Size(189, 20);
            this.lbRecentProjects.TabIndex = 15;
            this.lbRecentProjects.Text = "Recently opened projects";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbWelcome.Location = new System.Drawing.Point(232, 9);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(349, 20);
            this.lbWelcome.TabIndex = 16;
            this.lbWelcome.Text = "Welcome to TicketPrinter 1.0 (for Printon PK115)";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::TicketPrinter.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(12, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 35);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRecentProject8
            // 
            this.btnRecentProject8.Enabled = false;
            this.btnRecentProject8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject8.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject8.Location = new System.Drawing.Point(559, 220);
            this.btnRecentProject8.Name = "btnRecentProject8";
            this.btnRecentProject8.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject8.TabIndex = 14;
            this.btnRecentProject8.Text = "(no file)";
            this.btnRecentProject8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject8.UseVisualStyleBackColor = true;
            this.btnRecentProject8.Click += new System.EventHandler(this.btnRecentProject8_Click);
            // 
            // btnRecentProject7
            // 
            this.btnRecentProject7.Enabled = false;
            this.btnRecentProject7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject7.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject7.Location = new System.Drawing.Point(451, 220);
            this.btnRecentProject7.Name = "btnRecentProject7";
            this.btnRecentProject7.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject7.TabIndex = 13;
            this.btnRecentProject7.Text = "(no file)";
            this.btnRecentProject7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject7.UseVisualStyleBackColor = true;
            this.btnRecentProject7.Click += new System.EventHandler(this.btnRecentProject7_Click);
            // 
            // btnRecentProject6
            // 
            this.btnRecentProject6.Enabled = false;
            this.btnRecentProject6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject6.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject6.Location = new System.Drawing.Point(343, 220);
            this.btnRecentProject6.Name = "btnRecentProject6";
            this.btnRecentProject6.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject6.TabIndex = 12;
            this.btnRecentProject6.Text = "(no file)";
            this.btnRecentProject6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject6.UseVisualStyleBackColor = true;
            this.btnRecentProject6.Click += new System.EventHandler(this.btnRecentProject6_Click);
            // 
            // btnRecentProject5
            // 
            this.btnRecentProject5.Enabled = false;
            this.btnRecentProject5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject5.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject5.Location = new System.Drawing.Point(235, 220);
            this.btnRecentProject5.Name = "btnRecentProject5";
            this.btnRecentProject5.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject5.TabIndex = 11;
            this.btnRecentProject5.Text = "(no file)";
            this.btnRecentProject5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject5.UseVisualStyleBackColor = true;
            this.btnRecentProject5.Click += new System.EventHandler(this.btnRecentProject5_Click);
            // 
            // btnRecentProject4
            // 
            this.btnRecentProject4.Enabled = false;
            this.btnRecentProject4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject4.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject4.Location = new System.Drawing.Point(559, 118);
            this.btnRecentProject4.Name = "btnRecentProject4";
            this.btnRecentProject4.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject4.TabIndex = 10;
            this.btnRecentProject4.Text = "(no file)";
            this.btnRecentProject4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject4.UseVisualStyleBackColor = true;
            this.btnRecentProject4.Click += new System.EventHandler(this.btnRecentProject4_Click);
            // 
            // btnRecentProject3
            // 
            this.btnRecentProject3.Enabled = false;
            this.btnRecentProject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject3.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject3.Location = new System.Drawing.Point(451, 118);
            this.btnRecentProject3.Name = "btnRecentProject3";
            this.btnRecentProject3.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject3.TabIndex = 9;
            this.btnRecentProject3.Text = "(no file)";
            this.btnRecentProject3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject3.UseVisualStyleBackColor = true;
            this.btnRecentProject3.Click += new System.EventHandler(this.btnRecentProject3_Click);
            // 
            // btnRecentProject2
            // 
            this.btnRecentProject2.Enabled = false;
            this.btnRecentProject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject2.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject2.Location = new System.Drawing.Point(343, 118);
            this.btnRecentProject2.Name = "btnRecentProject2";
            this.btnRecentProject2.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject2.TabIndex = 8;
            this.btnRecentProject2.Text = "(no file)";
            this.btnRecentProject2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject2.UseVisualStyleBackColor = true;
            this.btnRecentProject2.Click += new System.EventHandler(this.btnRecentProject2_Click);
            // 
            // btnRecentProject1
            // 
            this.btnRecentProject1.Enabled = false;
            this.btnRecentProject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentProject1.Image = global::TicketPrinter.Properties.Resources.document_large;
            this.btnRecentProject1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecentProject1.Location = new System.Drawing.Point(235, 118);
            this.btnRecentProject1.Name = "btnRecentProject1";
            this.btnRecentProject1.Size = new System.Drawing.Size(102, 96);
            this.btnRecentProject1.TabIndex = 7;
            this.btnRecentProject1.Text = "(no file)";
            this.btnRecentProject1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecentProject1.UseVisualStyleBackColor = true;
            this.btnRecentProject1.Click += new System.EventHandler(this.btnRecentProject1_Click);
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProject.Image = global::TicketPrinter.Properties.Resources.folder;
            this.btnOpenProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenProject.Location = new System.Drawing.Point(12, 53);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(199, 35);
            this.btnOpenProject.TabIndex = 6;
            this.btnOpenProject.Text = "Open project file";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // btnShowAbout
            // 
            this.btnShowAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAbout.Image = global::TicketPrinter.Properties.Resources.information;
            this.btnShowAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAbout.Location = new System.Drawing.Point(12, 240);
            this.btnShowAbout.Name = "btnShowAbout";
            this.btnShowAbout.Size = new System.Drawing.Size(199, 35);
            this.btnShowAbout.TabIndex = 4;
            this.btnShowAbout.Text = "About";
            this.btnShowAbout.UseVisualStyleBackColor = true;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProject.Image = global::TicketPrinter.Properties.Resources.add;
            this.btnCreateProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateProject.Location = new System.Drawing.Point(12, 12);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(199, 35);
            this.btnCreateProject.TabIndex = 2;
            this.btnCreateProject.Text = "Create new project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnOpenManualControl
            // 
            this.btnOpenManualControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenManualControl.Location = new System.Drawing.Point(12, 94);
            this.btnOpenManualControl.Name = "btnOpenManualControl";
            this.btnOpenManualControl.Size = new System.Drawing.Size(199, 22);
            this.btnOpenManualControl.TabIndex = 58;
            this.btnOpenManualControl.Text = "Open manual mode";
            this.btnOpenManualControl.UseVisualStyleBackColor = true;
            this.btnOpenManualControl.Click += new System.EventHandler(this.btnOpenManualControl_Click);
            // 
            // StartupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 328);
            this.Controls.Add(this.btnOpenManualControl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbRecentProjects);
            this.Controls.Add(this.btnRecentProject8);
            this.Controls.Add(this.btnRecentProject7);
            this.Controls.Add(this.btnRecentProject6);
            this.Controls.Add(this.btnRecentProject5);
            this.Controls.Add(this.btnRecentProject4);
            this.Controls.Add(this.btnRecentProject3);
            this.Controls.Add(this.btnRecentProject2);
            this.Controls.Add(this.btnRecentProject1);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.btnShowAbout);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.lblWelcomeText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartupWindow";
            this.Text = "TicketPrinter - Select project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartupWindow_FormClosed);
            this.Load += new System.EventHandler(this.StartupWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnShowAbout;
        private System.Windows.Forms.Button btnOpenProject;
        private System.Windows.Forms.Button btnRecentProject1;
        private System.Windows.Forms.Button btnRecentProject2;
        private System.Windows.Forms.Button btnRecentProject3;
        private System.Windows.Forms.Button btnRecentProject4;
        private System.Windows.Forms.Button btnRecentProject8;
        private System.Windows.Forms.Button btnRecentProject7;
        private System.Windows.Forms.Button btnRecentProject6;
        private System.Windows.Forms.Button btnRecentProject5;
        private System.Windows.Forms.Label lbRecentProjects;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenManualControl;
    }
}