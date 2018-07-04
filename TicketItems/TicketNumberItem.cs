using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrinter.TicketItems
{
    public class TicketNumberItem : TextItem
    {
        public override string GetText(Project project)
        {
            return project.NextTicketNumber.ToString();
        }

        public override string ToString()
        {
            return "Ticket Number";
        }

        public override bool CanEditText()
        {
            return false;
        }
        
        public override TicketItem Clone()
        {
            TicketNumberItem item = new TicketNumberItem();
            copyBaseSettingsInto(item);
            copyTextSettingsInto(item);
            return item;
        }

        public override IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = base.Serialize();
            dict.Remove("text");
            dict["type"] = "ticket_number";
            return dict;
        }

        public new static TicketItem Deserialize(IDictionary<string, object> dict)
        {
            TicketNumberItem item = new TicketNumberItem();
            TextItem.DeserializeInto(dict, item);
            return item;
        }

    }
}
