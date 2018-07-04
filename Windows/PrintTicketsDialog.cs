using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using TicketPrinter.TicketItems;

namespace TicketPrinter.Windows
{
    public partial class PrintTicketsDialog : Form
    {
        private Project project;
        private Ticket selectedTicket;

        public Ticket SelectedTicket
        {
            get { return (Ticket)cbTicket.SelectedItem; }
        }

        public int Amount
        {
            get { return (int)nudAmount.Value; }
        }

        public PrintTicketsDialog(Project project, Ticket selectedTicked)
        {
            this.project = project;
            this.selectedTicket = selectedTicked;

            InitializeComponent();
        }

        private void PrintTicketsDialog_Load(object sender, EventArgs e)
        {
            foreach (Ticket ticket in project.Tickets)
            {
                cbTicket.Items.Add(ticket);
            }
            if (selectedTicket != null) 
                cbTicket.SelectedItem = selectedTicket;
        }
    }
}
