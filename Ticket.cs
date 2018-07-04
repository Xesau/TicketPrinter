using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TicketPrinter.TicketItems;

namespace TicketPrinter
{
    public class Ticket
    {
        public List<TicketItem> Items;
        public string Name;

        public Ticket(string name, List<TicketItem> items)
        {
            this.Name = name;
            this.Items = items;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = new Dictionary<string, object>();
            dict["name"] = this.Name;
            List<IDictionary<string, object>> items = new List<IDictionary<string, object>>();
            foreach (TicketItem item in this.Items)
            {
                items.Add(item.Serialize());
            }
            dict["items"] = items;
            return dict;
        }

        public static Ticket Deserialize(IDictionary<string, object> dict)
        {
            string name = dict["name"].ToString();
            IList<object> itemDicts = (IList<object>)dict["items"];
            List<TicketItem> items = new List<TicketItem>();
            foreach (IDictionary<string, object> itemDict in itemDicts)
            {
                TicketItem item = null;
                switch (itemDict["type"].ToString())
                {
                    case "date":
                        item = DateItem.Deserialize(itemDict);
                        break;
                    case "text":
                        item = TextItem.Deserialize(itemDict);
                        break;
                    case "ticket_number":
                        item = TicketNumberItem.Deserialize(itemDict);
                        break;
                    case "line":
                        item = LineItem.Deserialize(itemDict);
                        break;
                    case "border":
                        item = BorderItem.Deserialize(itemDict);
                        break;
                }
                if (item != null)
                    items.Add(item);
            }
            return new Ticket(name, items);
        }

    }
}
