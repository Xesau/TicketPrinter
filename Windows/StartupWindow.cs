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
using Newtonsoft.Json;
using System.Dynamic;

namespace TicketPrinter.Windows
{
    public partial class StartupWindow : Form
    {
        public StartupWindow()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            NewProjectDialog dialog = new NewProjectDialog();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                // Create new project
                Project project = new Project();
                project.ProjectName = dialog.ProjectName;
                File.WriteAllText(dialog.FilePath, JsonConvert.SerializeObject(project.Serialize(), Formatting.None));

                TicketPrinter.Properties.Settings.Default.RecentFiles.Remove(dialog.FilePath);
                TicketPrinter.Properties.Settings.Default.RecentFiles.Insert(0, dialog.FilePath);
                TicketPrinter.Properties.Settings.Default.Save();

                new ProjectWindow(project, dialog.FilePath).Show();
                Close();
            }
        }

        private void btnOpenProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open project file";
            dialog.Filter = "TicketPrinter project|*.tpp|All files|*.*";
            dialog.CheckFileExists = true;
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                // Open file
                OpenFile(dialog.FileName);
            }
        }

        private bool OpenFile(string filePath)
        {
            if (!File.Exists(filePath)) return false;

            string json = File.ReadAllText(filePath);
            IDictionary<string, object> dict = JsonConvert.DeserializeObject<ExpandoObject>(json);
            Project project = Project.Deserialize(dict);

            TicketPrinter.Properties.Settings.Default.RecentFiles.Remove(filePath);
            TicketPrinter.Properties.Settings.Default.RecentFiles.Insert(0, filePath);
            TicketPrinter.Properties.Settings.Default.Save();

            new ProjectWindow(project, filePath).Show();
            Close();
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartupWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void StartupWindow_Load(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] { btnRecentProject1, btnRecentProject2, btnRecentProject3, btnRecentProject4, btnRecentProject5, btnRecentProject6, btnRecentProject7, btnRecentProject8 };
            int i = 0;
            foreach (string recentFile in TicketPrinter.Properties.Settings.Default.RecentFiles)
            {
                buttons[i].Text = Path.GetFileName(recentFile);
                buttons[i].Enabled = true;
                i++;
            }
        }

        private void btnRecentProject1_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[0]);
        }

        private void btnRecentProject2_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[1]);
        }

        private void btnRecentProject3_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[2]);
        }

        private void btnRecentProject4_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[3]);
        }

        private void btnRecentProject5_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[4]);
        }

        private void btnRecentProject6_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[5]);
        }

        private void btnRecentProject7_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[6]);
        }

        private void btnRecentProject8_Click(object sender, EventArgs e)
        {
            OpenFile(TicketPrinter.Properties.Settings.Default.RecentFiles[7]);
        }

        private void btnOpenManualControl_Click(object sender, EventArgs e)
        {
            new ManualControlWindow().Show();
        }
    }
}
