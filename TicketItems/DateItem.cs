using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPrinter.TicketItems
{
    public class DateItem : TextItem
    {
        public string DateFormat = "dd MMM. yyyy";

        public override string GetText(Project project)
        {
            return DateTime.Now.ToString(this.DateFormat);
        }

        public override string ToString()
        {
            return "Date (" + this.DateFormat + ")";
        }

        public override bool CanEditText()
        {
            return false;
        }

        public override TicketItem Clone()
        {
            DateItem item = new DateItem();
            copyBaseSettingsInto(item);
            copyTextSettingsInto(item);
            item.DateFormat = this.DateFormat;
            return item;
        }

        public override IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = base.Serialize();
            dict.Remove("text");
            dict["format"] = this.DateFormat;
            dict["type"] = "date";
            return dict;
        }

        protected new static void DeserializeInto(IDictionary<string, object> dict, TicketItem into)
        {
            TextItem.DeserializeInto(dict, into);
            DateItem item = (DateItem)into;
            item.DateFormat = dict["format"].ToString();
        }

        public new static TicketItem Deserialize(IDictionary<string, object> dict)
        {
            DateItem item = new DateItem();
            DeserializeInto(dict, item);
            return item;
        }

    }
}
