using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace TicketPrinter.Windows
{
    public partial class ConnectionSetupDialog : Form
    {
        SerialPort testingPort;
        string currentPortName;
        const string SelectPort = "-- Select port --";

        public string ComPortName
        {
            get { return cbComPort.SelectedItem is ComPortInfo ? ((ComPortInfo)cbComPort.SelectedItem).PortName : null; }
            set { currentPortName = value; }
        }

        public ConnectionSetupDialog()
        {
            InitializeComponent();
        }

        private void cbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testingPort != null)
            {
                if (testingPort.IsOpen)
                    testingPort.Close();
                testingPort.Dispose();
                testingPort = null;
            }
            tConnectionFailed.Stop();
            lblTestingConnection.Visible = false;
            lblConnectionNotOK.Visible = false;
            lblConnectionOK.Visible = false;
            btnTestConnection.Enabled = cbComPort.SelectedItem.ToString() != SelectPort;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (testingPort != null)
            {
                testingPort.Close();
                testingPort = null;
            }
            
            lblConnectionOK.Visible = false;
            lblConnectionNotOK.Visible = false;
            lblTestingConnection.Visible = true;
            btnTestConnection.Enabled = false;

            testingPort = new SerialPort(((ComPortInfo)cbComPort.SelectedItem).PortName);
            testingPort.BaudRate = 9200;
            testingPort.Parity = Parity.None;
            testingPort.StopBits = StopBits.One;
            testingPort.DataBits = 8;
            testingPort.DtrEnable = true;
            testingPort.Encoding = Encoding.Default;
            testingPort.DataReceived += testingPort_DataReceived;

            tConnectionFailed.Start();

            try
            {
                testingPort.Open();
                string command = Encoding.Default.GetString(new byte[] { UsbUtil.BeginCommand }) + "y9;20;4" + Encoding.Default.GetString(new byte[] { UsbUtil.EndCommand });
                testingPort.Write(command);
                //testingPort.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Fail();
                return;
            }
        }

        private void testingPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)DataReceivedHandler);
        }

        private void testingPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            Invoke((MethodInvoker)Fail);
        }

        private void DataReceivedHandler()
        {
            if (testingPort.ReadExisting() == "Hello World" + Encoding.Default.GetString(new byte[] { 10, 13 }))
            {
                lblTestingConnection.Visible = false;
                lblConnectionOK.Visible = true;
                btnTestConnection.Enabled = true;
                tConnectionFailed.Stop();
            }
            else
                Fail();
        }

        private void Fail()
        {
            lblTestingConnection.Visible = false;
            lblConnectionNotOK.Visible = true;
            btnTestConnection.Enabled = true;

            if (this.testingPort != null && this.testingPort.IsOpen)
            {
                this.testingPort.Close();
                this.testingPort.Dispose();
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = false;
            cbComPort.Items.Clear();
            cbComPort.Items.Add(SelectPort);
            cbComPort.SelectedIndex = 0;

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                string[] portNames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());
                var portInfos = portNames.Select(n => new ComPortInfo(n, ports.FirstOrDefault(s => s.Contains(n)))).ToList();
                foreach (ComPortInfo portInfo in portInfos)
                {
                    cbComPort.Items.Add(portInfo);
                    if (portInfo.PortName == currentPortName)
                        cbComPort.SelectedItem = portInfo;
                }
            }


        }

        private void ConnectionSetupDialog_Load(object sender, EventArgs e)
        {
            btnRefreshList_Click(null, null);
        }

        private void tConnectionFailed_Tick(object sender, EventArgs e)
        {
            Fail();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private class ComPortInfo
        {
            public string PortName;
            public string PortInfo;

            public ComPortInfo(string name, string info)
            {
                PortName = name;
                PortInfo = info;
            }

            override public string ToString()
            {
                return PortInfo;
            }
        }

        private void ConnectionSetupDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.testingPort != null)
            {
                if (this.testingPort.IsOpen)
                    this.testingPort.Close();
                this.testingPort = null;
            }
        }
    }

}
