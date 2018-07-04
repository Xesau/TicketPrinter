using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TicketPrinter.TicketItems
{
    public class BorderItem : TicketItem
    {
        public int Width = 70;
        public int Height = 70;
        public int Thickness = 1;

        public override void DrawItem(Graphics g, bool selected, Project project)
        {
            int previewThickness = (int)Math.Ceiling((decimal)this.Thickness / 2);
            Pen pen = new Pen(Color.Black, 1);
            Size size = new Size(this.Width / 2, this.Height / 2);
            Point topLeft = this.GetDrawingPosition(size);
            Point bottomRight = topLeft + size - new Size(1, 1);
            Point topRight = topLeft + new Size(this.Width / 2 - 1, 0);
            Point bottomLeft = topLeft + new Size(0, this.Height / 2 - 1);
            if (selected)
                g.FillRectangle(TicketItem.SelectedBrush, new Rectangle(topLeft, size));

            for (int i = 0; i < previewThickness; i++)
                g.DrawLine(pen, topLeft + new Size(0, i), topRight + new Size(0, i));
            for (int i = 0; i < previewThickness; i++)
                g.DrawLine(pen, bottomLeft - new Size(0, i), bottomRight - new Size(0, i));
            for (int i = 0; i < previewThickness; i++)
                g.DrawLine(pen, topLeft + new Size(i, 0), bottomLeft + new Size(i, 0));
            for (int i = 0; i < previewThickness; i++)
                g.DrawLine(pen, topRight - new Size(i, 0), bottomRight - new Size(i, 0));
            
        }

        public override void WriteCommands(Stream stream, Encoding encoding, Project project)
        {
            int realX = this.CalculatePrintingX(this.Width, project);
            int realY = this.CalculatePrintingY(this.Height, project);

            UsbUtil.WriteCommand(stream, encoding, "X" + realX + ";" + realY + ";" + (realX + this.Width) + ";" + (realY + this.Height) + ";" + this.Thickness);
        }

        protected override bool SupportsHorizontalScaling()
        {
            return false;
        }

        public override string ToString()
        {
            return "Border (" + this.Thickness + ")";
        }

        public override TicketItem Clone()
        {
            BorderItem item = new BorderItem();
            copyBaseSettingsInto(item);
            item.Thickness = this.Thickness;
            item.Height = this.Height;
            item.Width = this.Width;
            return item;
        }

        public override IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = base.Serialize();
            dict["width"] = this.Width;
            dict["height"] = this.Height;
            dict["thickness"] = this.Thickness;
            dict["type"] = "border";
            return dict;
        }

        public static TicketItem Deserialize(IDictionary<string, object> dict)
        {
            BorderItem item = new BorderItem();
            DeserializeInto(dict, item);
            return item;
        }

        protected new static void DeserializeInto(IDictionary<string, object> dict, TicketItem into)
        {
            BorderItem item = (BorderItem)into;
            TicketItem.DeserializeInto(dict, into);
            item.Thickness = int.Parse(dict["thickness"].ToString());
            item.Width = int.Parse(dict["width"].ToString());
            item.Height = int.Parse(dict["height"].ToString());
        }
    }
}
