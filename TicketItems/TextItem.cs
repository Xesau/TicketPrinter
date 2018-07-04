using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;

namespace TicketPrinter.TicketItems
{
    public class TextItem : TicketItem
    {
        public enum TextFont
        {
            ArialBold,
            CourierBold
        }

        public string Text = "Text";
        public int TextSpacing = 1;
        public TextFont FontType = TextFont.ArialBold;
        public int FontSize = 14;

        public virtual string GetText(Project project)
        {
            return this.Text;
        }

        public virtual bool CanEditText()
        {
            return true;
        }

        protected override bool SupportsHorizontalScaling()
        {
            return true;
        }


        public override void DrawItem(Graphics g, bool selected, Project project)
        {
            Font f = this.GetFont();
            string text = this.GetText(project);
            SizeF sizeF = g.MeasureString(text, f);
            Point position = this.GetDrawingPosition(new Size((int)sizeF.Width, (int)sizeF.Height));

            Rectangle rect = GetDrawingRectangle(SizeFToSize(sizeF));
            if (selected)
            {
                g.FillRectangle(TicketItem.SelectedBrush, rect);
            }

            System.Drawing.Drawing2D.GraphicsState s = g.Save();
            g.ResetTransform();
            g.RotateTransform((int)this.Rotation, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.TranslateTransform(rect.X, rect.Y, System.Drawing.Drawing2D.MatrixOrder.Append);
            //g.ScaleTransform(this.HorizontalScaling, 1f, System.Drawing.Drawing2D.MatrixOrder.Append);
            g.DrawString(text, f, Brushes.Black, RotatedTextPosition(rect));
            g.Restore(s);
        }

        protected Point RotatedTextPosition(Rectangle rect)
        {
            switch (this.Rotation)
            {
                case ItemRotation.R0:
                    return new Point(0, 0);
                case ItemRotation.R180:
                    return new Point(-rect.Width, -rect.Height);
                case ItemRotation.R270:
                    return new Point(-rect.Height, 0);
                default:
                    return new Point(0, -rect.Width);

            }
        }
        private Font GetFont(bool dubble = false)
        {
            string fontName = "Courier New";
            if (FontType == TextFont.ArialBold)
                fontName = "Arial";
            FontStyle style = FontStyle.Bold;
            return new Font(fontName, (int) (this.FontSize * 1.1f), style);
        }

        public override string ToString()
        {
            return "Text: " + this.Text.Substring(0, Math.Min(this.Text.Length, 10)) + "...";
        }

        public virtual string GetVariableName()
        {
            return null;
        }

        public override void WriteCommands(System.IO.Stream stream, Encoding encoding, Project project)
        {
            /*string varName = this.GetVariableName();
            if (varName != null)
            {
                base.WriteCommands(stream, encoding, project);
                Util.WriteCommand(stream, encoding, "F" + this.TextSpacing);
                Util.WriteCommand(stream, encoding, "V" + varName);
                Util.WriteCommand(stream, encoding, "T" + GetCommandFontName(this.FontType, this.FontSize) + ";" + this.GetText(project));
            }
            else*/

            Point oldPos = this.Position;
            Font f = GetFont();
            string[] lines = GetText(project).Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int cumulativeHeight = 0;
            foreach (string line in lines)
                cumulativeHeight += (int)TextRenderer.MeasureText(line, f).Height;
            cumulativeHeight += (int)(FontSize / 2 * (lines.Length - 1));
            
            // Fix starting position of 'inverse' printing directions
            if (Rotation == ItemRotation.R180)
            {
                if (HorizontalAlignment == Alignment.Begin)
                    this.Position += new Size(0, cumulativeHeight);
                else if (HorizontalAlignment == Alignment.Center)
                    this.Position += new Size(0, cumulativeHeight / 2);
            }
            else if (Rotation == ItemRotation.R90)
            {
                if (HorizontalAlignment == Alignment.Begin)
                    this.Position += new Size(cumulativeHeight, 0);
                else if (HorizontalAlignment == Alignment.Center)
                    this.Position += new Size(cumulativeHeight / 2, 0);
            }

            foreach (string line in lines)
            {
                if (line.Trim() != "")
                {
                    base.WriteCommands(stream, encoding, project);
                    UsbUtil.WriteCommand(stream, encoding, "F" + this.TextSpacing);
                    UsbUtil.WriteCommand(stream, encoding, "T" + GetCommandFontName(this.FontType, this.FontSize) + ";" + line);
                }
                switch (Rotation)
                {
                    case ItemRotation.R0:
                        this.Position += new Size(0, (int)TextRenderer.MeasureText(line, f).Height + this.FontSize);
                        break;
                    case ItemRotation.R180:
                        this.Position -= new Size(0, (int)TextRenderer.MeasureText(line, f).Height + this.FontSize);
                        break;
                    case ItemRotation.R90:
                        this.Position -= new Size((int)TextRenderer.MeasureText(line, f).Height + this.FontSize, 0);
                        break;
                    case ItemRotation.R270:
                        this.Position += new Size((int)TextRenderer.MeasureText(line, f).Height + this.FontSize, 0);
                        break;
                }
            }
            this.Position = oldPos;

        }

        protected string GetCommandFontName(TextFont font, int size)
        {
            if (font == TextFont.ArialBold)
                return "Arial" + (size < 10 ? "0" : "") + size + "f";
            
            return "Courier" + (size < 10 ? "0" : "") + size + "f";
        }

        public override TicketItem Clone()
        {
            TextItem item = new TextItem();
            copyBaseSettingsInto(item);
            copyTextSettingsInto(item);
            return item;
        }

        protected void copyTextSettingsInto(TextItem item)
        {
            item.Text = this.Text;
            item.FontSize = this.FontSize;
            item.FontType = this.FontType;
            item.TextSpacing = this.TextSpacing;
        }

        public override IDictionary<string, object> Serialize()
        {
            IDictionary<string, object> dict = base.Serialize();
            dict["font"] = GetFontName(this.FontType);
            dict["size"] = this.FontSize;
            dict["spacing"] = this.TextSpacing;
            dict["text"] = this.Text;
            dict["type"] = "text";
            return dict;
        }

        public string GetFontName(TextFont font)
        {
            if (font == TextFont.ArialBold) return "ArialBold";
            return "CourierBold";
        }

        public static TextFont GetFont(string name)
        {
            if (name == "ArialBold") return TextFont.ArialBold;
            return TextFont.CourierBold;
        }

        public static TicketItem Deserialize(IDictionary<string, object> dict)
        {
            TextItem item = new TextItem();
            DeserializeInto(dict, item);
            return item;
        }

        protected new static void DeserializeInto(IDictionary<string, object> dict, TicketItem into)
        {
            TicketItem.DeserializeInto(dict, into);
            TextItem text = (TextItem)into;
            
            // TicketNumber, Date, etc. don't have a text property
            if (dict.ContainsKey("text"))
                text.Text = dict["text"].ToString();

            text.TextSpacing = int.Parse(dict["spacing"].ToString());
            text.FontSize = int.Parse(dict["size"].ToString());
            text.FontType = GetFont(dict["font"].ToString());
        }
    }
}
