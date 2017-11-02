using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Reporting.WinForms;

namespace STUDIO2_Subscription_Manager
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        // used when moving onto another form to pass on the current WindowState
        private FormWindowState RetrieveWindowState()
        {
            return this.WindowState;
        }

        // displays new instance of Analytics Form and hides the current Form
        private void toolStripMenuItemAnalytics_Click(object sender, EventArgs e)
        {
            Analytics Analytics = new Analytics();
            Analytics.Show();
            Analytics.Activate();
            Analytics.Location = this.Location;
            Analytics.Width = this.Width;
            Analytics.Height = this.Height;
            Analytics.WindowState = RetrieveWindowState();
            this.Hide();
        }

        // displays new instance of Members Form and hides the current Form
        private void toolStripMenuItemMembers_Click(object sender, EventArgs e)
        {
            Members Members = new Members();
            Members.Show();
            Members.Activate();
            Members.Location = this.Location;
            Members.Width = this.Width;
            Members.Height = this.Height;
            Members.WindowState = RetrieveWindowState();
            this.Hide();
        }

        // displays new instance of Subscriptions Form and hides the current Form
        private void toolStripMenuItemSubscriptions_Click(object sender, EventArgs e)
        {
            Subscriptions Subscriptions = new Subscriptions();
            Subscriptions.Show();
            Subscriptions.Activate();
            Subscriptions.Location = this.Location;
            Subscriptions.Width = this.Width;
            Subscriptions.Height = this.Height;
            Subscriptions.WindowState = RetrieveWindowState();
            this.Hide();
        }

        // displays new instance of Invoices Form and hides the current Form
        private void toolStripMenuItemInvoices_Click(object sender, EventArgs e)
        {
            Invoices Invoices = new Invoices();
            Invoices.Show();
            Invoices.Activate();
            Invoices.Location = this.Location;
            Invoices.Width = this.Width;
            Invoices.Height = this.Height;
            Invoices.WindowState = RetrieveWindowState();
            this.Hide();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'STUDIO2_Subscription_ManagerDataSet.Subscription' table. You can move, or remove it, as needed.
            this.SubscriptionTableAdapter.Fill(this.STUDIO2_Subscription_ManagerDataSet.Subscription);
            // TODO: This line of code loads data into the 'STUDIO2_Subscription_ManagerDataSet.Member' table. You can move, or remove it, as needed.
            this.MemberTableAdapter.Fill(this.STUDIO2_Subscription_ManagerDataSet.Member);
            
            // retrieve member analytics and fill in labels
            int[] values = new int[5];
            values = Member_DAL.RetrieveAnalytics();
            lblMembers.Text = values[0].ToString();
            lblActiveMembers.Text = values[1].ToString();
            lblMaleMembers.Text = values[2].ToString();
            lblFemaleMembers.Text = values[3].ToString();
            lblAverageAge.Text = values[4].ToString();

            // retrieve invoice analytics and fill in labels
            values = new int[5];
            values = Invoice_DAL.RetrieveAnalytics();
            lblTotalInvoices.Text = values[0].ToString();
            lblPaidInvoices.Text = values[1].ToString();
            lblNotPaidInvoices.Text = values[2].ToString();
            lblPendingInvoices.Text = values[3].ToString();
            lblCanceledInvoices.Text = values[4].ToString();

            // retrieve subscription analytics and fill in labels
            int[] subValues = new int[7];
            subValues = Subscription_DAL.RetrieveAnalytics();
            lblSubscriptionsCreated.Text = subValues[0].ToString();
            lblActive.Text = subValues[1].ToString();
            lblIndividual.Text = subValues[2].ToString();
            lblOffPeak.Text = subValues[3].ToString();
            lblConcessionary.Text = subValues[4].ToString();
            lblConcessionaryOffPeak.Text = subValues[5].ToString();
            lblStudent.Text = subValues[6].ToString();

            toolStripComboBoxReportSource.Text = "ReportMembers.rdlc";

            //this.reportViewerMember.RefreshReport();
            //this.reportViewerSubscription.RefreshReport();
        }

        private void toolStripMenuItemFileConnectToDatabase_Click(object sender, EventArgs e)
        {
            Start Start = new Start();
            Start.Show();
            Start.Activate();
            Start.Location = this.Location;
            Start.Width = this.Width;
            Start.Height = this.Height;
            Start.WindowState = RetrieveWindowState();
            this.Hide();
        }

        private void Analytics_Resize(object sender, EventArgs e)
        {
            RedrawControls();
        }

        private void RedrawControls()
        {
            int width = this.Width - 235;
            int height = this.Height - 60;

            //reportViewerMember.Width = width;
            //reportViewerMember.Height = height;
            //reportViewerSubscription.Width = width;
            //reportViewerSubscription.Height = height;
        }

        private void toolStripComboBoxReportSource_DropDownClosed(object sender, EventArgs e)
        {
            //if (toolStripComboBoxReportSource.Text == "ReportMembers.rdlc")
            //{
            //    reportViewerMember.Visible = true;
            //    reportViewerSubscription.Visible = false;
            //}
            //else
            //{
            //    reportViewerMember.Visible = false;
            //    reportViewerSubscription.Visible = true;
            //}
        }

        private void Analytics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }       
    }
}
