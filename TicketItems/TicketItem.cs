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
    public abstract class TicketItem
    {
        private static Brush cachedBrush;
        public static Brush SelectedBrush
        {
            get
            {
                if (cachedBrush == null)
                    cachedBrush = new SolidBrush(Color.FromArgb(100, 214, 214, 147));
                return cachedBrush;
            }
        }

        public static Color SelectedBackColor = Color.LightCyan;

        public enum Alignment
        {
            Begin,
            Center,
            End
        }

        public enum ItemRotation : int
        {
            R0 = 0,
            R270 = 270,
            R90 = 90,
            R180 = 180
        }

        public Point Position = new Point(0, 0);
        public int HorizontalScaling = 1;
        public Alignment HorizontalAlignment = Alignment.Begin;
        public Alignment VerticalAlignment = Alignment.Begin;
        public ItemRotation Rotation = ItemRotation.R0;

        public abstract void DrawItem(Graphics g, bool selected, Project project);

        protected int CalculateDrawingX(int width)
        {
            width *= this.HorizontalScaling;
            if (HorizontalAlignment == Alignment.Begin) return this.Position.X / 2;
            if (HorizontalAlignment == Alignment.Center) return (this.Position.X - width / 2) / 2;
            return (this.Position.X - width) / 2;
        }

        protected int CalculateDrawingY(int height)
        {
            if (VerticalAlignment == Alignment.Begin) return this.Position.Y / 2;
            if (VerticalAlignment == Alignment.Center) return (this.Position.Y - height / 2) / 2;
            return (this.Position.Y - height) / 2;
        }

        protected int drawingCoordHelper(Alignment align, int pos, int len)
        {
            if (align == Alignment.Begin) return pos / 2;
            if (align == Alignment.Center) return (pos - len / 2) / 2;
            return (pos - len) / 2;
        }

        protected Point GetDrawingPosition(Size drawingSize)
        {
            return new Point(CalculateDrawingX(drawingSize.Width * 2), CalculateDrawingY(drawingSize.Height * 2));
        }

        protected Size SizeFToSize(SizeF sizeF)
        {
            return new Size((int)sizeF.Width, (int)sizeF.Height);
        }

        protected Rectangle GetDrawingRectangle(Size drawingSize)
        {
            int x = 0;
            int y = 0;
            int width = 0;
            int height = 0;
            switch (Rotation)
            {
                case ItemRotation.R0:
                case ItemRotation.R180:
                    width = drawingSize.Width;
                    height = drawingSize.Height;
                    x = CalculateDrawingX(width * 2);
                    y = CalculateDrawingY(height * 2);
                    break;
                case ItemRotation.R90:
                    width = drawingSize.Height;
                    height = drawingSize.Width;
                    x = CalculateDrawingX(width * 2);
                    y = CalculateDrawingY(height * 2);
                    break;
                case ItemRotation.R270:
                    width = drawingSize.Height;
                    height = drawingSize.Width;
                    x = CalculateDrawingX(width * 2);
                    y = CalculateDrawingY(height * 2);
                    break;
            }

            return new Rectangle(x, y, width, height);
        }

        protected abstract bool SupportsHorizontalScaling();

        protected int CalculatePrintingX(int width, Project project)
        {
            if (this.SupportsHorizontalScaling())   
                width *= this.HorizontalScaling;
            if (HorizontalAlignment == Alignment.Begin) return project.XOffset + this.Position.X;
            if (HorizontalAlignment == Alignment.Center) return project.XOffset + this.Position.X - width / 2;
            return project.XOffset + this.Position.X - width;
        }

        protected int CalculatePrintingY(int height, Project project)
        {
            if (VerticalAlignment == Alignment.Begin) return project.YOffset + this.Position.Y;
            if (VerticalAlignment == Alignment.Center) return project.YOffset + this.Position.Y - height / 2;
            return project.YOffset + this.Position.Y - height;
        }

        public virtual void WriteCommands(Stream stream, Encoding encoding, Project project)
        {
            UsbUtil.WriteCommand(stream, encoding, "G" + (project.XOffset + this.Position.X) + ";" + GetAlignmentChar(this.HorizontalAlignment));
            UsbUtil.WriteCommand(stream, encoding, "I" + (project.YOffset + this.Position.Y) + ";" + GetAlignmentChar(this.VerticalAlignment));
            UsbUtil.WriteCommand(stream, encoding, "R" + GetRotationDegrees(this.Rotation));
            if (this.SupportsHorizontalScaling())
                UsbUtil.WriteCommand(stream, encoding, "D" + this.HorizontalScaling);
        }

        private static string GetAlignmentChar(Alignment a)
        {
            if (a == Alignment.Begin) return "l";
            if (a == Alignment.Center) return "z";
            return "r";
        }

        protected static int GetRotationDegrees(ItemRotation rot)
        {
            if (rot == ItemRotation.R0) return 0;
            if (rot == ItemRotation.R270) return 270;
            if (rot == ItemRotation.R90) return 90;
            return 180;
        }

        public abstract TicketItem Clone();

        protected void copyBaseSettingsInto(TicketItem into)
        {
            into.HorizontalAlignment = this.HorizontalAlignment;
            into.VerticalAlignment = this.VerticalAlignment;
            into.HorizontalScaling = this.HorizontalScaling;
            into.Position = this.Position;
            into.Rotation = this.Rotation;
        }

        public virtual IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = new Dictionary<string, object>();
            dict["hAlign"] = GetAlignmentName(this.HorizontalAlignment);
            dict["vAlign"] = GetAlignmentName(this.VerticalAlignment);
            dict["rotation"] = (int)this.Rotation;
            dict["hScale"] = this.HorizontalScaling;
            dict["x"] = this.Position.X;
            dict["y"] = this.Position.Y;
            return dict;
        }

        protected static void DeserializeInto(IDictionary<string, object> dict, TicketItem into)
        {
            into.Position = new Point(
                int.Parse(dict["x"].ToString()),
                int.Parse(dict["y"].ToString())
            );
            into.HorizontalAlignment = GetAlignment(dict["hAlign"].ToString());
            into.VerticalAlignment = GetAlignment(dict["vAlign"].ToString());
            into.HorizontalScaling = int.Parse(dict["hScale"].ToString());
            into.Rotation = GetRotation(int.Parse(dict["rotation"].ToString()));
        }

        public static ItemRotation GetRotation(int degrees)
        {
            if (degrees == 270) return ItemRotation.R270;
            if (degrees == 90) return ItemRotation.R90;
            if (degrees == 180) return ItemRotation.R180;
            return ItemRotation.R0;
        }

        public static Alignment GetAlignment(string name) {
            if (name == "begin") return Alignment.Begin;
            else if (name == "center") return Alignment.Center;
            return Alignment.End;
        }

        public string GetAlignmentName(Alignment alignment)
        {
            if (alignment == Alignment.Begin) return "begin";
            else if (alignment == Alignment.Center) return "center";
            return "end";
        }
    }
}
