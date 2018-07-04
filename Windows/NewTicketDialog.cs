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
    public partial class NewTicketDialog : Form
    {
        public string TicketName
        {
            get { return this.tbTicketName.Text; }
            set { this.tbTicketName.Text = value; }
        }

        public List<TicketItem> Template
        {
            get
            {
                return this.cbTemplate.SelectedItem == null ? null : ((TicketTemplate)cbTemplate.SelectedItem).Items;
            }
        }

        public NewTicketDialog(Project project)
        {
            InitializeComponent();

            cbTemplate.Items.Add(new TicketTemplate("Empty template", new List<TicketItem>()));
            foreach (Ticket ticket in project.Tickets)
            {
                cbTemplate.Items.Add(new TicketTemplate(ticket));
            }
            cbTemplate.SelectedIndex = 0;
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

        class TicketTemplate
        {
            public string Name;
            public List<TicketItem> Items;

            public TicketTemplate(string name, List<TicketItem> items)
            {
                this.Name = name;
                this.Items = items;
            }

            public TicketTemplate(Ticket ticket)
            {
                this.Name = ticket.Name;
                this.Items = new List<TicketItem>();
                foreach (TicketItem item in ticket.Items)
                {
                    this.Items.Add(item.Clone());
                }
            }

            public override string ToString()
            {
                return Name;
            }
        }

    }
}
