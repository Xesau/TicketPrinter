using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicketPrinter.Windows
{
    public partial class NewProjectDialog : Form
    {
        public string ProjectName
        {
            get { return this.tbProjectName.Text; }
            set { this.tbProjectName.Text = value; }
        }

        public string FilePath
        {
            get { return this.tbFilePath.Text; }
        }

        public NewProjectDialog()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            lblFileAlreadyExists.Visible = false;
            lblEnterProjectName.Visible = false;
            lblEnterFilePath.Visible = false;

            if (tbProjectName.Text.Length < 1)
            {
                lblEnterProjectName.Visible = true;
                return;
            }

            if (tbFilePath.Text.Length < 1)
            {
                lblEnterFilePath.Visible = true;
                return;
            }

            if (File.Exists(tbFilePath.Text))
            {
                lblFileAlreadyExists.Visible = true;
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "TicketPrinter project file|*.tpp|All files|*";
            dialog.Title = "Choose a path for the project file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = dialog.FileName;
            }
        }
    }
}
