using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace TicketPrinter
{
    public class UsbUtil
    {
        public const byte BeginLayout = 2; // <STX>
        public const byte EndLayout = 4; // <EOT>
        public const byte ENQ = 5;
        public const byte ACK = 6;
        public const byte BEL = 7;
        public const byte EndCommand = 13; // <CR>
        public const byte BeginCommand = 27; // <ESC>

        public static void WriteCommand(Stream stream, Encoding enc, string command)
        {
            byte[] buffer = enc.GetBytes(enc.GetString(new byte[] { BeginCommand }) + command + enc.GetString(new byte[] { EndCommand }));
            stream.Write(buffer, 0, buffer.Length);
        }

        public static void PrepareSerialPort(SerialPort port)
        {
            port.BaudRate = 9200;
            port.DataBits = 8;
            port.Handshake = Handshake.XOnXOff;
            port.StopBits = StopBits.One;
            port.Parity = Parity.None;
            port.DtrEnable = false;
            port.Encoding = Encoding.Default;
            port.RtsEnable = true;
        }

    }
}
