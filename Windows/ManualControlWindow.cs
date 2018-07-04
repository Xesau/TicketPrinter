using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
namespace TicketPrinter.Windows
{
    public partial class ManualControlWindow : Form
    {

        SerialPort port;

        public ManualControlWindow()
        {
            InitializeComponent();
            updateConnectLayout();
        }

        private void btnPortNameRefresh_Click(object sender, EventArgs e)
        {
            lbPortName.Items.Clear();
            foreach (string portName in SerialPort.GetPortNames())
                lbPortName.Items.Add(portName);

            updateConnectLayout();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            port = new SerialPort(this.lbPortName.SelectedItem.ToString());
            UsbUtil.PrepareSerialPort(port);
            port.ReadTimeout = 500;
            port.WriteTimeout = 500;
            port.DataReceived += WriteReceivedData;
            port.PinChanged += port_PinChanged;
            
            port.ErrorReceived += port_ErrorReceived;
            port.WriteBufferSize = 16;
            port.ReadBufferSize = 14;
            port.ReceivedBytesThreshold = 1;
            port.Open();

            tbLog.Text = "[TicketPrinterTest] Connected to printer on port " + this.lbPortName.SelectedItem.ToString();
            updateConnectLayout();
        }

        void port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            tbLog.Invoke((MethodInvoker)delegate { tbLog.Text += "\r\n[**] " + "Error received: " + e.EventType.ToString(); });
        }

        void port_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            tbLog.Invoke((MethodInvoker)delegate { tbLog.Text += "\r\n[**] " + "Pin changed: " + e.EventType.ToString(); });
        }

        private void WriteReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            tbLog.Invoke((MethodInvoker)delegate { tbLog.Text += "\r\n[<<] " + formatOutput(port.ReadExisting()); });
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            port.Close();
            port = null;
            updateConnectLayout();
        }

        private void updateConnectLayout()
        {
            bool connected = this.port != null;
            btnConnect.Enabled = !connected && lbPortName.SelectedItem != null;
            btnDisconnect.Enabled = connected;
            btnPortNameRefresh.Enabled = !connected;
            lbPortName.Enabled = !connected;
            pnlConnected.Visible = connected;
        }

        private void lbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateConnectLayout();
        }

        private void WriteByteBuffer(byte[] buffer)
        {
            if (!cbOnlyLog.Checked)
            {
                port.Write(buffer, 0, buffer.Length);
                tbLog.Text += "\r\n[**] " + formatOutput(Encoding.Default.GetString(buffer));
            }
            else
            {
                tbLog.Text += "\r\n[??] " + formatOutput(Encoding.Default.GetString(buffer));
            }
        }

        public static string formatOutput(string output)
        {
            return output
                .Replace(Convert.ToChar(27).ToString(), "<ESC>")
                .Replace(Convert.ToChar(13).ToString(), "<CR>")
                .Replace(Convert.ToChar(2).ToString(), "<STX>")
                .Replace(Convert.ToChar(4).ToString(), "<EOT>")
                .Replace(Convert.ToChar(5).ToString(), "<ENQ>")
                .Replace(Convert.ToChar(6).ToString(), "<ACK>")
                .Replace(Convert.ToChar(7).ToString(), "<BEL>");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string data = Encoding.Default.GetString(new byte[] { UsbUtil.BeginCommand }) + tbRawCmd.Text + Encoding.Default.GetString(new byte[] { UsbUtil.EndCommand });
            byte[] buffer = Encoding.Default.GetBytes(data);

            for (int i = 0; i < (int)nudRawCmdTimes.Value; i++)
                WriteByteBuffer(buffer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbLog.Text += "\r\n" + formatOutput(port.ReadExisting());
        }

        private void tCheckPortClosed_Tick(object sender, EventArgs e)
        {
            if (port == null || !port.IsOpen)
            {
                
                tCheckPortClosed.Enabled = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(formatOutput(this.port.ReadExisting()));
        }
    }

}
