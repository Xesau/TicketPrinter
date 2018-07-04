using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrinter
{
    public class Project
    {
        //
        // CONNECTION
        //

        public string PortName = null;
        
        //
        // PROJECT
        //
        public string ProjectName;

        public List<Ticket> Tickets = new List<Ticket>();

        public int NextTicketNumber = 10001;
        public int XOffset = 200;
        public int YOffset = 50;

        public static Project Deserialize(IDictionary<string, object> dict)
        {
            Project project = new Project();
            project.ProjectName = dict["name"].ToString();
            project.PortName = (dict["port"] == null ? null : dict["port"].ToString());
            project.NextTicketNumber = int.Parse(dict["nextTicket"].ToString());
            List<Ticket> tickets = new List<Ticket>();
            var ticketDictList = dict["tickets"];
            foreach (object o in (IEnumerable<object>)ticketDictList)
            {
                IDictionary<string, object> ticketDict = (IDictionary<string, object>)o;
                tickets.Add(Ticket.Deserialize(ticketDict));
            }
            project.Tickets = tickets;
            return project;
        }

        public IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = new Dictionary<string, object>();
            dict["name"] = this.ProjectName;
            dict["port"] = this.PortName;
            dict["nextTicket"] = this.NextTicketNumber;
            List<IDictionary<string, object>> ticketDicts = new List<IDictionary<string, object>>();
            foreach (Ticket ticket in this.Tickets)
            {
                ticketDicts.Add(ticket.Serialize());
            }
            dict["tickets"] = ticketDicts;
            return dict;
        }
    }
}
