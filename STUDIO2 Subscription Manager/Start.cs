using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace STUDIO2_Subscription_Manager
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        // used when moving onto another form to pass on the current WindowState
        private FormWindowState RetrieveWindowState()
        {
            return this.WindowState;
        }

        // to connect to database and build connection string
        public int connectDatabase()
        {
            try
            {
                StringBuilder Con = new StringBuilder("Data Source=");
                Con.Append(txtServer.Text);
                Con.Append(";Initial Catalog=");
                Con.Append(txtDatabase.Text);
                Con.Append(";Integrated Security=True;");
                Con.Append("Connection Timeout=5;");            
                string strCon = Con.ToString();
                updateConfigurationFile(strCon);
                ConfigurationManager.RefreshSection("connectionStrings");

                using (SqlConnection connection = new SqlConnection(strCon))
                {
                    try
                    {
                        connection.Open();
                        return 1;
                    }
                    catch (SqlException)
                    {  
                        return 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show(ConfigurationManager.ConnectionStrings["con"].ToString() + "Connection failed. Ensure that server/database is entered correctly", "Connect to database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
        }

        // used to update app.config with new connection string
        public void updateConfigurationFile(string con)
        {
            try
            {
                string configPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\App.config";
                Console.WriteLine(configPath);

                XmlDocument XmlDoc = new XmlDocument();

                XmlDoc.Load(configPath);

                foreach (XmlElement xElement in XmlDoc.DocumentElement)
                {
                    if (xElement.Name == "connectionStrings")
                    {
                        foreach (XmlElement xElementChild in xElement)
                        {
                            xElementChild.Attributes[1].Value = con;
                        }
                    }
                }

                XmlDoc.Save(configPath);                            
            }
            catch
            {
                MessageBox.Show(ConfigurationManager.ConnectionStrings["con"].ToString() + "Connection failed. Ensure that server/database is entered correctly", "Connect to database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }        

        // executes connectDatabase() and returns to user whether operation was successful
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(connectDatabase() == 1)
            {
                int fullSystemCheckReturn = FullSystemCheck();
                if(fullSystemCheckReturn == 1)
                {
                    MessageBox.Show("Connection successful.\r\n- Server: " + txtServer.Text + "\r\n- Database: " + txtDatabase.Text + "\r\n\r\n" + fullSystemCheckMessage + "\r\n\r\nRedirecting to Member form.", "Connect to database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Members Members = new Members();
                    Members.Show();
                    Members.Activate();
                    Members.Location = this.Location;
                    Members.Width = this.Width;
                    Members.Height = this.Height;
                    Members.WindowState = RetrieveWindowState();
                    this.Hide(); 
                }
                else if (fullSystemCheckReturn == 2)
                {
                    MessageBox.Show("Connection successful.\r\n- Server: " + txtServer.Text + "\r\n- Database: " + txtDatabase.Text + "\r\n\r\nApplication restarting to save changes.", "Connect to database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // write to autoStart.txt so that new instance knows to automatically connect to database
                    StreamWriter writeAutoStart = new StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\autoStart.txt");
                    writeAutoStart.WriteLine("1");
                    writeAutoStart.WriteLine(txtServer.Text);
                    writeAutoStart.WriteLine(txtDatabase.Text);
                    writeAutoStart.Close();
                    // new instance of application initiated and current instance closed
                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    Info.CreateNoWindow = true;
                    Info.FileName = "STUDIO2 Subscription Manager.exe";
                    Process.Start(Info);
                    Application.Exit();
                }  
                else
                {
                    MessageBox.Show("Connection successful.\r\n- Server: " + txtServer.Text + "\r\n- Database: " + txtDatabase.Text + "\r\n\r\n" + fullSystemCheckMessage + "\r\n\r\nEnsure that the corect database/server have been selected", "Connect to database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Connection failed.\r\n- Server: " + txtServer.Text + "\r\n- Database: " + txtDatabase.Text + "\r\n\r\nEnsure that the corect database/server have been selected", "Connect to database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        // executes operation to check for expiring subscriptions, unpaid invoices and generation of new invoices
        string fullSystemCheckMessage;
        private int FullSystemCheck()
        {
            int fullSystemCheckReturn = Start_DAL.FullSystemCheck();
            if(fullSystemCheckReturn == 1)
            {
                fullSystemCheckMessage = "Full system check successful.";
                return 1;
            }
            else if(fullSystemCheckReturn == 2)
            {
                return 2;
            }
            else
            {
                fullSystemCheckMessage = "Full system check failed.";
                return 0;
            }
        }        

        // scales position and size of various controls to adjust to window size
        private void RedrawControls()
        {
            int width = this.Width;
            int height = this.Height;
            Point point = new Point();

            point.X = (width - pnlConnect.Width) / 2;
            point.Y = pnlConnect.Location.Y;
            pnlConnect.Location = point;

            point.X = (width - pboxStudio2.Width) / 2;
            point.Y = pboxStudio2.Location.Y;
            pboxStudio2.Location = point;

            pboxBackground.Width = this.Width;
            pboxBackground.Height = this.Height;
            pboxBackground.Refresh();
        }

        // executes RedrawControls() when Form is resized to scale position and size of various controls to adjust to window size
        private void Start_Resize(object sender, EventArgs e)
        {
            RedrawControls();
        }

        // WindowState automatically set to Maximized
        private void Start_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;  
            // values read in from autoStart.txt to determine whether to automatically connect to database 
            // due to a new connection string being generated in a previous instance of the application
            StreamReader readAutoStart = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\autoStart.txt");
            string[] autoStartValues = new string[3];
            autoStartValues[0] = readAutoStart.ReadLine();
            if(autoStartValues[0] == "1")
            {
                autoStartValues[1] = readAutoStart.ReadLine();
                autoStartValues[2] = readAutoStart.ReadLine();
                txtServer.Text = autoStartValues[1];
                txtDatabase.Text = autoStartValues[2];
                readAutoStart.Close();
                StreamWriter writeAutoStart = new StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\autoStart.txt");
                writeAutoStart.WriteLine("0");
                writeAutoStart.Close();
                btnConnect.PerformClick();
            }

            readAutoStart.Close();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
