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
using System.IO;
using TicketPrinter.TicketItems;
using Newtonsoft.Json;

namespace TicketPrinter.Windows
{
    public partial class ProjectWindow : Form
    {
        Project Project;
        SerialPort connection;
        bool isConnected = false;
        bool isChanged = false;

        private string FilePath;

        Ticket SelectedTicket { get { return (Ticket)lbTickets.SelectedItem; } }
        TicketItem SelectedItem { get { return (TicketItem)lbItems.SelectedItem; } set { lbItems.SelectedItem = value; } }

        public ProjectWindow(Project project, string filePath)
        {
            this.Project = project;
            this.FilePath = filePath;
            InitializeComponent();
        }

        #region Connection
        private void btnSetupConnection_Click(object sender, EventArgs e)
        {
            bool wasOpen = connection != null && connection.IsOpen;
            if (wasOpen)
                connection.Close();
            tKeepConnection.Stop();
            ConnectionSetupDialog dialog = new ConnectionSetupDialog();
            dialog.ComPortName = this.Project.PortName;
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                // Save settings
                this.Project.PortName = dialog.ComPortName;

                isChanged = true;
                UpdateSaveButton();
                CheckConnection();
            }
            else
            {
                if (wasOpen)
                    connection.Open();
            }
            tKeepConnection.Start();
        }

        private void tWrongDeviceType_Tick(object sender, EventArgs e)
        {
            pbConnectionStatus.Image = TicketPrinter.Properties.Resources.status_error;
            lblConnectionStatus.Text = "Incorrect device. Check setup";
        }

        private void tKeepConnection_Tick(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void CheckConnection()
        {
            if (this.Project.PortName == null)
            {
                pbConnectionStatus.Image = TicketPrinter.Properties.Resources.status_error;
                lblConnectionStatus.Text = "No connection set up.";
                this.isConnected = false;
            }

            else if (this.connection == null)
            {
                // Try connecting
                string[] portNames = SerialPort.GetPortNames();
                List<string> portNameList = new List<string>(portNames);
                if (portNameList.Contains(this.Project.PortName))
                {
                    this.connection = new SerialPort(this.Project.PortName);
                    UsbUtil.PrepareSerialPort(this.connection);
                    TryEstablishConnection(false);
                }
                else
                {
                    pbConnectionStatus.Image = TicketPrinter.Properties.Resources.status_error;
                    lblConnectionStatus.Text = this.Project.PortName + " not connected. Check setup or cable";
                    this.isConnected = false;
                }
            }
            else if (!this.connection.IsOpen)
            {
                TryEstablishConnection(true);
            }

            UpdateLayoutConnected();
        }

        void UpdateLayoutConnected()
        {
            btnChooseMagazine.Enabled = this.isConnected;
        }

        void TryEstablishConnection(bool wasOpenBefore)
        {
            pbConnectionStatus.Image = TicketPrinter.Properties.Resources.refresh;
            lblConnectionStatus.Text = "Connecting...";

            try
            {
                this.connection.Open();
                // Write USB check command (<ESC>y9;20;4<CR>), returns Hello World\r\n
                lblConnectionStatus.Text = "Attempting handshake";
                tWrongDeviceType.Start();
                this.connection.DataReceived += connection_DataReceived_Handshake;
                string command = Encoding.Default.GetString(new byte[] { UsbUtil.BeginCommand }) + "y9;20;4" + Encoding.Default.GetString(new byte[] { UsbUtil.EndCommand });
                this.connection.Write(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (wasOpenBefore)
                {
                    pbConnectionStatus.Image = TicketPrinter.Properties.Resources.alert;
                    lblConnectionStatus.Text = "Connection was closed. Check device or cable";
                    new ConnectionClosedDialog().ShowDialog();
                }
                else
                {
                    pbConnectionStatus.Image = TicketPrinter.Properties.Resources.error;
                    lblConnectionStatus.Text = "Could not connect. Check setup";
                }
                this.isConnected = false;
                UpdateLayoutConnected();
            }
        }

        void connection_DataReceived_Handshake(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)ConnectedHandler);
            // Only handle once
            this.connection.DataReceived -= connection_DataReceived_Handshake;
        }

        private void ConnectedHandler()
        {
            if (this.connection.ReadExisting() == "Hello World" + Encoding.Default.GetString(new byte[] { 10, 13 }))
            {
                pbConnectionStatus.Image = TicketPrinter.Properties.Resources.status_ok;
                lblConnectionStatus.Text = "Connected";
                tWrongDeviceType.Stop();
                this.isConnected = true;
                UpdateLayoutConnected();
            }
            else
            {
                pbConnectionStatus.Image = TicketPrinter.Properties.Resources.alert;
                lblConnectionStatus.Text = "Incorrect device. Check setup!";
                this.isConnected = false;
                UpdateLayoutConnected();
            }
        }
        #endregion

        private Ticket previousSelectedTicket;
        private void lbTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.previousSelectedTicket == lbTickets.SelectedItem)
                return;
            this.previousSelectedTicket = (Ticket)lbTickets.SelectedItem;
            
            btnEditTicket.Enabled = true;
            btnRename.Enabled = true;
            btnPrintTicket.Enabled = true;
            btnDeleteTicket.Enabled = true;
            ShowTicketEditor(false);
            UpdateTicketLayout();
        }

        private void btnChooseMagazine_Click(object sender, EventArgs e)
        {
            UsbUtil.WriteCommand(this.connection.BaseStream, this.connection.Encoding, "y9;30;2;" + (int)(nudMagazine.Value - 1));
        }

        public void UpdateTicketList()
        {
            Ticket previousSelected = SelectedTicket;
            lbTickets.Items.Clear();
            foreach (Ticket ticket in Project.Tickets)
            {
                    lbTickets.Items.Add(ticket);
            }
            if (Project.Tickets.Contains(previousSelected))
                lbTickets.SelectedItem = previousSelected;
        }

        #region Ticket layout
        private bool UpdatingTicketLayout = false;
        public void UpdateTicketLayout()
        {
            if (UpdatingTicketLayout) return;
            UpdatingTicketLayout = true;

            // Assumping no action removes a ticket and adds one too
            if (lbTickets.Items.Count != Project.Tickets.Count)
                UpdateTicketList();

            Ticket selectedTicket = SelectedTicket;
            pnlTicketEditor.Visible = selectedTicket != null;

            btnEditTicket.Enabled = selectedTicket != null;
            btnDeleteTicket.Enabled = selectedTicket != null;
            pnlTicketItemButtons.Enabled = selectedTicket != null;
            pnlItemSettings.Enabled = selectedTicket != null;

            pnlTicketItems.Controls.Clear();
            
            if (selectedTicket != null && this.pnlTicketEditor.Visible)
            {
                TicketItem previousItem = SelectedItem;

                // Assuming no action removes an item and adds one too
                if (lbItems.Items.Count != selectedTicket.Items.Count)
                {
                    lbItems.Items.Clear();
                    foreach (TicketItem item in selectedTicket.Items)
                        lbItems.Items.Add(item);
                    if (selectedTicket.Items.Contains(previousItem))
                        lbItems.SelectedItem = previousItem;
                    lbItems.Refresh();
                }
                else 
                    lbItems.Refresh();

                TicketItem selectedItem = SelectedItem;

                btnMoveItemDown.Enabled = selectedItem != null;
                btnDuplicateItem.Enabled = selectedItem != null;
                btnMoveItemUp.Enabled = selectedItem != null;
                btnRemoveItem.Enabled = selectedItem != null;

                if (selectedItem != null)
                {
                    
                    // Make sure selected index is good
                    int index = SelectedTicket.Items.IndexOf(selectedItem);
                    if (lbItems.SelectedIndex != index)
                        lbItems.SelectedIndex = index;

                    pnlGeneralItemSettings.Enabled = true;

                    // Settings page visibility
                    pnlSpecificItemSettings.Visible = true;
                    pnlTextSettings.Visible = selectedItem is TextItem;
                    pnlDateSettings.Visible = selectedItem is DateItem;
                    pnlBorderSettings.Visible = selectedItem is BorderItem;
                    pnlLineSettings.Visible = selectedItem is LineItem;
                    pnlHorizontalScaling.Visible = false;// selectedItem is TextItem;

                    // Field value depending on type
                    if (selectedItem is TextItem)
                    {
                        TextItem text = (TextItem)selectedItem;
                        cbTextFont.SelectedIndex = text.FontType == TextItem.TextFont.ArialBold ? 0 : 1;
                        if (!text.CanEditText())
                        {
                            tbTextString.Enabled = false;
                            tbTextString.Text = "Automatic";
                        }
                        else
                        {
                            tbTextString.Enabled = true;
                            tbTextString.Text = text.Text;
                        }
                        nudTextSpacing.Value = text.TextSpacing;
                        cbTextSize.Items.Clear();
                        if (text.FontType == TextItem.TextFont.ArialBold)
                        {
                            foreach (int i in new int[] {  8, 9, 10, 11, 12, 14, 16, 18})
                                cbTextSize.Items.Add(i);
                        }
                        else
                        {
                            foreach (int i in new int[] { 8, 10, 12, 14 })
                                cbTextSize.Items.Add(i);
                        }
                        cbTextSize.SelectedItem = text.FontSize;
                        if (cbTextSize.SelectedItem == null)
                        {
                            cbTextSize.SelectedIndex = 0;
                            text.FontSize = (int)cbTextSize.SelectedItem;
                        }

                        if (selectedItem is DateItem)
                        {
                            tbDateFormat.Text = ((DateItem)selectedItem).DateFormat;
                        }
                    }
                    else if (selectedItem is BorderItem)
                    {
                        BorderItem border = (BorderItem)selectedItem;
                        nudBorderWidth.Value = border.Width;
                        nudBorderHeight.Value = border.Height;
                        nudBorderThickness.Value = border.Thickness;
                    }
                    else if (selectedItem is LineItem)
                    {
                        LineItem line = (LineItem)selectedItem;
                        nudLineThickness.Value = line.Thickness;
                        nudLineLength.Value = line.Length;
                        cbLineDirection.SelectedIndex = line.LineDirection == LineItem.Direction.Horizontal ? 0 : 1;
                    }

                    // General settings
                    nudPosX.Value = selectedItem.Position.X;
                    nudPosY.Value = selectedItem.Position.Y;
                    nudHorizontalScaling.Value = selectedItem.HorizontalScaling;

                    if (selectedItem.HorizontalAlignment == TicketItem.Alignment.Begin)
                        cbPositionAlignmentHorizontal.SelectedIndex = 0;
                    else if (selectedItem.HorizontalAlignment == TicketItem.Alignment.Center)
                        cbPositionAlignmentHorizontal.SelectedIndex = 1;
                    else
                        cbPositionAlignmentHorizontal.SelectedIndex = 2;

                    if (selectedItem.VerticalAlignment == TicketItem.Alignment.Begin)
                        cbPositionAlignmentVertical.SelectedIndex = 0;
                    else if (selectedItem.VerticalAlignment == TicketItem.Alignment.Center)
                        cbPositionAlignmentVertical.SelectedIndex = 1;
                    else
                        cbPositionAlignmentVertical.SelectedIndex = 2;

                    if (selectedItem.Rotation == TicketItem.ItemRotation.R0)
                        cbRotation.SelectedIndex = 0;
                    else if (selectedItem.Rotation == TicketItem.ItemRotation.R270)
                        cbRotation.SelectedIndex = 3;
                    else if (selectedItem.Rotation == TicketItem.ItemRotation.R90)
                        cbRotation.SelectedIndex = 2;
                    else
                        cbRotation.SelectedIndex = 1;
                }
                else
                {
                    previousItem = null;
                    pnlSpecificItemSettings.Visible = false;
                    pnlGeneralItemSettings.Enabled = false;
                }

                // Redraw every item NOW HANDLED BY event pnlTicketItems.Paint
                //foreach(TicketItem item in selectedTicket.Items) 
                //    item.AddControl(pnlTicketItems.Controls, handler, item == previousItem);
                pnlTicketItems.Refresh();
            }
            else
            {
                pnlTicketEditor.Visible = false;
            }

            UpdatingTicketLayout = false;
        }

        #endregion

        #region Add item buttons
        private void btnAddText_Click(object sender, EventArgs e)
        {
            TextItem item = new TextItem();
            SelectedTicket.Items.Insert(0, item);
            UpdateTicketLayout();
            SelectedItem = item;
            isChanged = true;
            UpdateSaveButton();
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            BorderItem item = new BorderItem();
            SelectedTicket.Items.Insert(0, item);
            UpdateTicketLayout();
            SelectedItem = item;
            isChanged = true;
            UpdateSaveButton();
        }

        private void btnAddTicketNumber_Click(object sender, EventArgs e)
        {
            TicketNumberItem item = new TicketNumberItem();
            item.Position = new Point(140, 750);
            item.HorizontalAlignment = TicketItem.Alignment.Center;
            item.VerticalAlignment = TicketItem.Alignment.End;
            SelectedTicket.Items.Insert(0, item);
            UpdateTicketLayout();
            SelectedItem = item;
            isChanged = true;
            UpdateSaveButton();
        }

        private void btnAddDate_Click(object sender, EventArgs e)
        {
            DateItem item = new DateItem();
            SelectedTicket.Items.Insert(0, item);
            UpdateTicketLayout();
            SelectedItem = item;
            isChanged = true;
            UpdateSaveButton();
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            LineItem item = new LineItem();
            SelectedTicket.Items.Insert(0, item);
            UpdateTicketLayout();
            SelectedItem = item;
            isChanged = true;
            UpdateSaveButton();
        }
        #endregion

        #region Item property changed

        private void nudBorderThickness_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is BorderItem)) return;
            ((BorderItem)SelectedItem).Thickness = (int)nudBorderThickness.Value;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void tbTextString_TextChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is TextItem)) return;
            TextItem item = (TextItem)SelectedItem;
            if (item.CanEditText())
            {
                item.Text = tbTextString.Text;
                UpdateTicketLayout();
                isChanged = true;
                UpdateSaveButton();
            }
            else
                tbTextString.Text = item.GetText(this.Project);
        }

        private void nudPosX_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            SelectedItem.Position = new Point((int)nudPosX.Value, (int)SelectedItem.Position.Y);
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void nudPosY_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            SelectedItem.Position = new Point((int)SelectedItem.Position.X, (int)nudPosY.Value);
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void nudBorderWidth_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is BorderItem)) return;
            ((BorderItem)SelectedItem).Width = (int)nudBorderWidth.Value;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void nudBorderHeight_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is BorderItem)) return;
            ((BorderItem)SelectedItem).Height = (int)nudBorderHeight.Value;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void cbTextFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is TextItem)) return;
            TextItem text = (TextItem)SelectedItem;
            if (cbTextFont.SelectedIndex == 0)
                text.FontType = TextItem.TextFont.ArialBold;
            else
                text.FontType = TextItem.TextFont.CourierBold;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void cbPositionAlignmentHorizontal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            int index = cbPositionAlignmentHorizontal.SelectedIndex;
            if (index == 0)
                SelectedItem.HorizontalAlignment = TicketItem.Alignment.Begin;
            else if (index == 1)
                SelectedItem.HorizontalAlignment = TicketItem.Alignment.Center;
            else
                SelectedItem.HorizontalAlignment = TicketItem.Alignment.End;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void cbPositionAlignmentVertical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            int index = cbPositionAlignmentVertical.SelectedIndex;
            if (index == 0)
                SelectedItem.VerticalAlignment = TicketItem.Alignment.Begin;
            else if (index == 1)
                SelectedItem.VerticalAlignment = TicketItem.Alignment.Center;
            else
                SelectedItem.VerticalAlignment = TicketItem.Alignment.End;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void cbTextSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is TextItem)) return;
            ((TextItem)SelectedItem).FontSize = (int)cbTextSize.SelectedItem;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void nudHorizontalScaling_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            SelectedItem.HorizontalScaling = (int)nudHorizontalScaling.Value;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void nudTextSpacing_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is TextItem)) return;
            ((TextItem)SelectedItem).TextSpacing = (int)nudTextSpacing.Value;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void nudLineLength_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is LineItem)) return;
            ((LineItem)SelectedItem).Length = (int)nudLineLength.Value;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void cbLineDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is LineItem)) return;
            ((LineItem)SelectedItem).LineDirection = cbLineDirection.SelectedIndex == 0 ? LineItem.Direction.Horizontal : LineItem.Direction.Vertical;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void nudLineThickness_ValueChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is LineItem)) return;
            ((LineItem)SelectedItem).Thickness = (int)nudLineThickness.Value;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void tbDateFormat_TextChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (!(SelectedItem is DateItem)) return;
            ((DateItem)SelectedItem).DateFormat = tbDateFormat.Text;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void cbRotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            if (cbRotation.SelectedIndex == 0)
                SelectedItem.Rotation = TicketItem.ItemRotation.R0;
            if (cbRotation.SelectedIndex == 1)
                SelectedItem.Rotation = TicketItem.ItemRotation.R180;
            if (cbRotation.SelectedIndex == 2)
                SelectedItem.Rotation = TicketItem.ItemRotation.R90;
            if (cbRotation.SelectedIndex == 3)
                SelectedItem.Rotation = TicketItem.ItemRotation.R270;
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        #endregion

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdatingTicketLayout) return;
            UpdateTicketLayout();
        }

        #region Ticket buttons
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            SelectedTicket.Items.Remove(SelectedItem);
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

        private void btnDuplicateItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                SelectedTicket.Items.Add(SelectedItem.Clone());
                UpdateTicketLayout();
            }
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            if (!this.isConnected)
            {
                new PrinterNotConnectedDialog().ShowDialog();
                return;
            }

            PrintTicketsDialog dialog = new PrintTicketsDialog(Project, SelectedTicket);
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Ticket ticket = dialog.SelectedTicket;
            int amount = dialog.Amount;

            // Configuration
            UsbUtil.WriteCommand(this.connection.BaseStream, Encoding.Default, "k1;0");

            // Layout
            for (int i = 0; i < amount; i++)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    stream.WriteByte(UsbUtil.BeginLayout);
                    foreach (TicketItem item in ticket.Items)
                        item.WriteCommands(stream, Encoding.Default, Project);

                    stream.WriteByte(UsbUtil.EndLayout);
                    byte[] buffer = stream.GetBuffer();
                    this.connection.Write(buffer, 0, buffer.Length);
                    Console.WriteLine(ManualControlWindow.formatOutput(Encoding.Default.GetString(buffer)));
                    //stream.WriteTo(this.connection.BaseStream);
                }

                UsbUtil.WriteCommand(this.connection.BaseStream, Encoding.Default, "#1");
                this.Project.NextTicketNumber++;
            }

            isChanged = true;
            UpdateSaveButton();
            nudNewTicketNumber.Value = Project.NextTicketNumber;
            pnlTicketItems.Refresh();
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            NewTicketDialog dialog = new NewTicketDialog(this.Project);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Ticket t = new Ticket(dialog.TicketName, dialog.Template);
                Project.Tickets.Add(t);
                UpdateTicketLayout();
                lbTickets.SelectedItem = t;
                isChanged = true;
                UpdateSaveButton();
            }
        }

        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            ShowTicketEditor(true);
        }

        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            ShowTicketEditor(false);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            RenameTicketDialog dialog = new RenameTicketDialog();
            dialog.TicketName = SelectedTicket.Name;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedTicket.Name = dialog.TicketName;
                isChanged = true;
                UpdateSaveButton();
            }
            UpdateTicketList();
        }
        #endregion

        #region General form things

        private void ProjectWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.connection != null && this.connection.IsOpen)
                this.connection.Close();
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void ProjectWindow_Load(object sender, EventArgs e)
        {
            CheckConnection();
            tKeepConnection.Start();
            lblProjectName.Text = this.Project.ProjectName;
            nudNewTicketNumber.Value = this.Project.NextTicketNumber;
            UpdateTicketLayout();
            UpdateSaveButton();
            this.Text = this.Text.Replace("{project.name}", this.Project.ProjectName).Replace("{file}", this.FilePath);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(this.Project.Serialize(), Formatting.None);
            File.WriteAllText(this.FilePath, json);
            isChanged = false;
            UpdateSaveButton();
        }

        private void UpdateSaveButton()
        {
            btnSave.Enabled = this.isChanged;
        }

        private void ProjectWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isChanged)
            {
                DialogResult res = MessageBox.Show("Do you want to save this project?", "File modified", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    btnSave_Click(null, null);
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        private void pnlTicketItems_Paint(object sender, PaintEventArgs e)
        {
            if (SelectedTicket == null)
            {
                e.Graphics.FillRectangle(Brushes.White, 0, 0, 140, 375);
                return;
            }

            TicketItem selected = SelectedItem;
            foreach (TicketItem item in SelectedTicket.Items)
                item.DrawItem(e.Graphics, selected == item, Project);
        }

        public void ShowTicketEditor(bool visible)
        {
            pnlItemSettings.Visible = visible;
            lblTicketEditor.Visible = visible;
            pnlTicketItemButtons.Visible = visible;
            lblTicketPreview.Visible = !visible;
            btnCloseEdit.Visible = visible;
            btnEditTicket.Visible = !visible;
            lblTopLeftCoords.Visible = visible;
            lblBottomRightCoords.Visible = visible;
            lbItems.Items.Clear();
            pnlTicketBorder.BackgroundImage = visible ? TicketPrinter.Properties.Resources.ticket_editor : null;

            if (visible)
                UpdateTicketLayout();
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete the ticket layout " + SelectedTicket.Name + "?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Project.Tickets.Remove(SelectedTicket);
                UpdateTicketLayout();
            }
        }

        private void btnReinitialise_Click(object sender, EventArgs e)
        {
            UsbUtil.WriteCommand(this.connection.BaseStream, Encoding.Default, "y9;30;0");
        }

        private void btnCustomCommand_Click(object sender, EventArgs e)
        {
            SelectedTicket.Items.Insert(0, new CustomCommandItem());
            UpdateTicketLayout();
            isChanged = true;
            UpdateSaveButton();
        }

    }
}
