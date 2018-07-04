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
    public class LineItem : TicketItem
    {
        public enum Direction
        {
            Horizontal,
            Vertical
        }

        public Direction LineDirection = Direction.Horizontal;
        public int Length = 70;
        public int Thickness = 1;

        public override void DrawItem(Graphics g, bool selected, Project project)
        {
            Size size = this.LineDirection == Direction.Horizontal ? new Size(this.Length / 2, 0) : new Size(0, this.Length / 2);
            Pen pen = new Pen(selected ? Color.Red : Color.Black, (int)Math.Ceiling((decimal)this.Thickness / 2));
            Point position = GetDrawingPosition(size);
            g.DrawLine(pen, position, position + size);
        }

        public override void WriteCommands(Stream stream, Encoding encoding, Project project)
        {
            int width = this.LineDirection == Direction.Horizontal ? this.Length : 1;
            int height = this.LineDirection == Direction.Vertical ? this.Length : 1;

            int realX = this.CalculatePrintingX(width, project);
            int realY = this.CalculatePrintingY(height, project);

            Console.WriteLine(this.Thickness + ";" + this.LineDirection.ToString());

            UsbUtil.WriteCommand(stream, encoding, "X" + realX + ";" + realY + ";" + (realX + width) + ";" + (realY + height) + ";" + this.Thickness);
        }

        protected override bool SupportsHorizontalScaling()
        {
            return false;
        }

        public override string ToString()
        {
            return "Line (" + this.Thickness + ")";
        }

        public override TicketItem Clone()
        {
            LineItem item = new LineItem();
            copyBaseSettingsInto(item);
            item.Thickness = this.Thickness;
            item.LineDirection = this.LineDirection;
            item.Length = this.Length;
            return item;
        }

        public override IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = base.Serialize();
            dict.Remove("text");
            dict["length"] = this.Length;
            dict["direction"] = GetDirectionName(this.LineDirection);
            dict["thickness"] = this.Thickness;
            dict["type"] = "line";
            return dict;
        }

        public string GetDirectionName(Direction direction)
        {
            if (direction == Direction.Horizontal) return "horizontal";
            return "vertical";
        }

        public static Direction GetDirection(string name)
        {
            if (name == "horizontal") return Direction.Horizontal;
            return Direction.Vertical;
        }

        public static TicketItem Deserialize(IDictionary<string, object> dict)
        {
            LineItem item = new LineItem();
            DeserializeInto(dict, item);
            return item;
        }

        protected new static void DeserializeInto(IDictionary<string, object> dict, TicketItem into)
        {
            TicketItem.DeserializeInto(dict, into);
            LineItem item = (LineItem)into;
            item.Thickness = int.Parse(dict["thickness"].ToString());
            item.Length = int.Parse(dict["length"].ToString());
            item.LineDirection = GetDirection(dict["direction"].ToString());
        }
    }
}
