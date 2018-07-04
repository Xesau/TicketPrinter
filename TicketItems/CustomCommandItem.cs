using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrinter.TicketItems
{
    class CustomCommandItem : TextItem
    {

        public override void DrawItem(System.Drawing.Graphics g, bool selected, Project project)
        {
        }

        protected override bool SupportsHorizontalScaling()
        {
            return false;
        }

        public override TicketItem Clone()
        {
            CustomCommandItem item = new CustomCommandItem();
            copyBaseSettingsInto(item);
            copyTextSettingsInto(item);
            return item;
        }

        public override string ToString()
        {
            return "Command:\t" + this.Text;
        }

        public override void WriteCommands(System.IO.Stream stream, Encoding encoding, Project project)
        {
            UsbUtil.WriteCommand(stream, encoding, "G0" + project.XOffset);
            UsbUtil.WriteCommand(stream, encoding, "I0" + project.YOffset);
            UsbUtil.WriteCommand(stream, encoding, this.Text);
        }
    }
}
