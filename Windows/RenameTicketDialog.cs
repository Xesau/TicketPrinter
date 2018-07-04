using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketPrinter.TicketItems;

namespace TicketPrinter.Windows
{
    public partial class RenameTicketDialog : Form
    {
        public string TicketName
        {
            get { return this.tbTicketName.Text; }
            set { this.tbTicketName.Text = value; }
        }

        public RenameTicketDialog()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbTicketName.Text.Length < 1)
            {
                lblEnterTicketName.Visible = true;
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
