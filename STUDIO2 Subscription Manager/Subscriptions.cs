using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DGVPrinterHelper;

namespace STUDIO2_Subscription_Manager
{
    public partial class Subscriptions : Form
    {
        public Subscriptions()
        {
            InitializeComponent();
        }

        public int memberID;
        private static int searchingMemberID;
        bool viewingData = true;
        bool recurringValueNotChanged = true;

        private FormWindowState RetrieveWindowState()
        {
            return this.WindowState;
        }

        public static int searchingMemberIDCall()
        {
            int temp = searchingMemberID;
            searchingMemberID = 0;
            return temp;
        }

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

        private void toolStripButtonPlans_Click(object sender, EventArgs e)
        {
            grpPlans.Visible = true;
            grpCreateSubscription.Visible = false;
            grpUpdateSubscription.Visible = false;
            viewingData = false;
        }

        private void toolStripButtonCreateSubscription_Click(object sender, EventArgs e)
        {
            txtCreateMemberID.Text = "";
            cboCreatePlans.Text = null;
            txtCreatePlanPrice.Text = "";
            cboCreateRecurring.Text = null;

            grpCreateSubscription.Visible = true;
            grpUpdateSubscription.Visible = false;
            grpPlans.Visible = false;
            viewingData = false;
        }

        private void toolStripButtonViewAllSubscriptions_Click(object sender, EventArgs e)
        {
            cboSearchField.Text = "SubscriptionID";
            txtSearch.Text = "";

            dgvSQLOutput.DataSource = subscriptionBindingSource;
            dgvSQLOutput.ClearSelection();
            lblSearchResults.Text = (dgvSQLOutput.RowCount - 1).ToString() + " results found";
            grpPlans.Visible = false;
            grpUpdateSubscription.Visible = false;
            grpCreateSubscription.Visible = false;
            viewingData = true;

        }

        private void toolStripButtonUpdateSubscription_Click(object sender, EventArgs e)
        {            
            int rowindex;
            int columnindex;
            string subIDInput;
            if (viewingData == false)
            {
                grpUpdateSubscription.Visible = false;
                grpCreateSubscription.Visible = false;
                grpPlans.Visible = false;
                viewingData = true;
                MessageBox.Show("No subscription selected. Click a cell of the chosen subscription then click 'Update Subscription' to update subscription details.", "Update Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    rowindex = dgvSQLOutput.CurrentCell.RowIndex;
                    columnindex = dgvSQLOutput.CurrentCell.ColumnIndex;
                    subIDInput = dgvSQLOutput.Rows[rowindex].Cells[0].Value.ToString();
                    if (Convert.ToInt32(subIDInput) < 0)
                    {
                        MessageBox.Show("Ensure that the row/cell for the corresponding subscription has been selected", "Update Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpUpdateSubscription.Visible = false;
                        return;
                    }
                    Console.WriteLine(rowindex + " " + columnindex + " " + subIDInput);

                    if(dgvSQLOutput.Rows[rowindex].Cells[9].Value.ToString() == "Active")
                    {
                        // Fill 'Update Member' textboxes with appropriate information retrieved from DataGridView 
                        txtSubscriptionID.Text = dgvSQLOutput.Rows[rowindex].Cells[0].Value.ToString();
                        txtUpdateMemberID.Text = dgvSQLOutput.Rows[rowindex].Cells[1].Value.ToString();
                        txtPlanID.Text = dgvSQLOutput.Rows[rowindex].Cells[2].Value.ToString();
                        txtPlanName.Text = Subscription_DAL.RetrievePlanName(Convert.ToInt32(dgvSQLOutput.Rows[rowindex].Cells[2].Value));
                        cboRecurring.Text = dgvSQLOutput.Rows[rowindex].Cells[3].Value.ToString();
                        txtSubStartDate.Text = Convert.ToDateTime(dgvSQLOutput.Rows[rowindex].Cells[4].Value).ToString("yyyy-MM-dd");
                        txtPeriodStartDate.Text = Convert.ToDateTime(dgvSQLOutput.Rows[rowindex].Cells[5].Value).ToString("yyyy-MM-dd");
                        txtPeriodEndDate.Text = Convert.ToDateTime(dgvSQLOutput.Rows[rowindex].Cells[6].Value.ToString()).ToString("yyyy-MM-dd");
                        txtNextInvoice.Text = Convert.ToDateTime(dgvSQLOutput.Rows[rowindex].Cells[8].Value.ToString()).ToString("yyyy-MM-dd");
                        txtSStatus.Text = dgvSQLOutput.Rows[rowindex].Cells[9].Value.ToString();

                        grpPlans.Visible = false;
                        grpCreateSubscription.Visible = false;
                        grpUpdateSubscription.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("The currently selected subscription has been canceled or suspended. Details can no longer be updated.", "Update Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpUpdateSubscription.Visible = false;
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Ensure that the row/cell for the corresponding subscription has been selected", "Update Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpCreateSubscription.Visible = false;
                    grpUpdateSubscription.Visible = false;
                    viewingData = true;
                    return;
                }
            }

            viewingData = true;
        }

        private void Subscriptions_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'sTUDIO2_Subscription_ManagerDataSet.Plan' table. You can move, or remove it, as needed.
            this.planTableAdapter.Fill(this.sTUDIO2_Subscription_ManagerDataSet.Plan);
            // TODO: This line of code loads data into the 'sTUDIO2_Subscription_ManagerDataSet.Subscription' table. You can move, or remove it, as needed.
            this.subscriptionTableAdapter.Fill(this.sTUDIO2_Subscription_ManagerDataSet.Subscription);
            memberID = Members.retrieveMemberID();
            Console.WriteLine("MEMBER ID SELECTED: " + memberID.ToString());
            Console.WriteLine(searchingMemberID.ToString());
            dgvSQLOutput.AutoResizeColumns();
            searchingMemberID = Members.searchingMemberIDCall();
            if(searchingMemberID != 0)
            {                
                if (searchingMemberID == 1)
                {
                    Console.WriteLine("IN SEARCHINGMEMBERID == 1");
                    txtCreateMemberID.Text = memberID.ToString();
                    grpCreateSubscription.Visible = true;
                    viewingData = false;
                }
                else if (searchingMemberID == 2)
                {
                    txtUpdateMemberID.Text = memberID.ToString();
                    grpUpdateSubscription.Visible = true;
                    viewingData = false;
                }
                else
                {
                    txtCreateMemberID.Text = "";
                    cboCreatePlans.Text = "";
                }

                dgvSQLOutput.ClearSelection();
            }
            
            searchingMemberID = 0;
           
            // Retrieve number of rows and display
            int rowCount = (dgvSQLOutput.RowCount - 1);
            if (rowCount < 0)
            {
                rowCount = 0;
            }
            lblSearchResults.Text = rowCount + " results found";
            cboSearchField.Text = "SubscriptionID";
        }

        private void btnSearchMemberID_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            searchingMemberID = Convert.ToInt32(btn.Tag);
            Console.WriteLine("SEARCHING MEMBER ID: " + searchingMemberID.ToString());
            toolStripMenuItemMembers.PerformClick();
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

        private void cboPlan_TextChanged(object sender, EventArgs e)
        {
            string plan = cboPlan.Text;
            DataGridViewRow dgvRow = new DataGridViewRow();
            foreach(DataGridViewRow row in dgvPlans.Rows)
            {
                if(row.Cells[1].Value.ToString() == plan)
                {
                    
                    decimal price = Convert.ToDecimal(row.Cells[2].Value);
                    txtCurrentPrice.Text = String.Format("{0:0.00}", price);
                    return;
                }            
            }           
        }

        private void txtNewPrice_TextChanged(object sender, EventArgs e)
        {           
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            if(cboPlan.Text != "" && txtNewPrice.Text != "")
            {
                try
                {                    
                    STUDIO2_Subscription_Manager.Subscription_DAL.UpdatePlan(cboPlan.Text, Convert.ToDecimal(txtNewPrice.Text));
                    MessageBox.Show("Plan " + cboPlan.Text + " successfully updated", "Plan Pricing");
                    Subscriptions Subscriptions = new Subscriptions();
                    Subscriptions.Show();
                    Subscriptions.Activate();
                    Subscriptions.Location = this.Location;
                    Subscriptions.Width = this.Width;
                    Subscriptions.Height = this.Height;
                    Subscriptions.WindowState = RetrieveWindowState();
                    this.Hide();                                                                                    
                }
                catch
                {
                    MessageBox.Show("Please ensure that a plan has been selected and a new valid price entered", "Plan Pricing");
                }

            }
            else
            {
                MessageBox.Show("Please ensure that a plan has been selected and a new valid price entered","Plan Pricing");
            }
        }

        private void btnCreateSubscription_Click(object sender, EventArgs e)
        {      
            if (txtCreateMemberID.Text != "" && cboCreatePlans.Text != "" && cboCreateRecurring.Text != "")
            {               
                int rowsAffected = Subscription_DAL.CreateSubscription(Convert.ToInt32(txtCreateMemberID.Text), cboCreatePlans.Text, cboCreateRecurring.Text);
                string message = "";
                switch(rowsAffected)
                {
                    case 0:
                        message = "Unexpected error occured.";
                        break;
                    case 1:
                        message = "Subscription successfully created.";
                        break;
                    case 2:
                        message = "The selected member already has an active subscription. Please cancel the current subscription if you wish to change the subscription.";
                        break;
                }

                MessageBox.Show(message, "Create Subscription");
                Subscriptions Subscriptions = new Subscriptions();
                Subscriptions.Show();
                Subscriptions.Activate();
                Subscriptions.Location = this.Location;
                Subscriptions.Width = this.Width;
                Subscriptions.Height = this.Height;
                Subscriptions.WindowState = RetrieveWindowState();
                this.Hide();
            }
            else
            {
                Console.WriteLine("#########" + txtCreateMemberID.Text + "##########" + cboCreatePlans.Text);
                MessageBox.Show("Please ensure that all fields have been filled in.", "Create Subscription");
                return;
            }
        }

        private void cboRecurring_TextChanged(object sender, EventArgs e)
        {
            if (recurringValueNotChanged == true)
            {
                recurringValueNotChanged = false;
                btnUpdateSubscription.Enabled = false;
            }
            else
            {
                recurringValueNotChanged = true;
                btnUpdateSubscription.Enabled = true;
            }
        }

        private void UpdateSubscription_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tag = btn.Tag.ToString();
            int subID = Convert.ToInt32(txtSubscriptionID.Text);
            if (tag == "Cancel")
            {
                if (MessageBox.Show("Are you sure you wish to cancel this subscription? Once performed it cannot be reversed.", "Update Subscription", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int rowsAffected = Subscription_DAL.UpdateSubscription(subID, "Cancel");
                    if (rowsAffected >= 1)
                    {
                        string invoiceMessage = "";
                        if(rowsAffected == 3)
                        {
                            invoiceMessage = "Pending invoice also successfully canceled.";
                        }
                        MessageBox.Show("Subscription successfully canceled. " + invoiceMessage, "Cancel Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        toolStripMenuItemSubscriptions.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Encountered error canceling subscription", "Cancel Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        toolStripMenuItemSubscriptions.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Subscription cancelation suspended.", "Cancel Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toolStripMenuItemSubscriptions.PerformClick();
                }                                                                
            }
            else
            {
                if (Subscription_DAL.UpdateSubscription(subID, cboRecurring.Text) == 2)
                {
                    MessageBox.Show("Subscription successfully updated", "Update Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toolStripMenuItemSubscriptions.PerformClick();
                }
                else
                {
                    MessageBox.Show("Encountered error updating subscription", "Update Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toolStripMenuItemSubscriptions.PerformClick();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (txtSearch.Text == "")
            {
                errorMessage += "- Please enter a value into the search box\r\n";
            }

            if (cboSearchField.Text == "")
            {
                errorMessage += "- Please select a value for the search field\r\n";
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Search Subscriptions");
            }
            else
            {
                lblSearchResults.Text = (Search(cboSearchField.Text, txtSearch.Text) - 1).ToString() + " results found";
            }

            dgvSQLOutput.ClearSelection();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private int Search(string field, string input)
        {
            if (txtSearch.Text == "")
            {
                return 1;
            }
            else
            {
                DataSet ds = Subscription_DAL.SearchSubscription(field, input);
                dgvSQLOutput.DataSource = ds.Tables[0];
            }

            return dgvSQLOutput.RowCount;
        }

        private void Subscriptions_Resize(object sender, EventArgs e)
        {
            RedrawControls();
        }

        private void RedrawControls()
        {
            int width = this.Width;
            int height = this.Height;
            Point point = new Point();
            dgvSQLOutput.Width = width - 40;
            dgvSQLOutput.Height = height - 132;            

            grpSearch.Width = width - 40;

            grpCreateSubscription.Width = width - 40;
            grpCreateSubscription.Height = height - 70;

            grpUpdateSubscription.Width = width - 40;
            grpUpdateSubscription.Height = height - 70;

            grpPlans.Width = width - 40;
            grpPlans.Height = height - 70;           

            dgvPlans.Width = grpPlans.Width - 26;
            dgvPlans.Height = grpPlans.Height - 107;            

            pnlChangePrice.Width = grpPlans.Width - 26;
            point.X = 7;
            point.Y = dgvPlans.Location.X + dgvPlans.Height + 6;
            pnlChangePrice.Location = point;
            
        }

        private void printToolStripMenuItemFilePrint_Click(object sender, EventArgs e)
        {
            string searchField;
            string search;
            DGVPrinter printer = new DGVPrinter();
            printer.PageSettings.Landscape = true;
            DataGridView dataGrid;
            string title;
            if (grpPlans.Visible == true)
            {
                dataGrid = dgvPlans;
                title = "Plans";
            }
            else
            {
                dataGrid = dgvSQLOutput;
                title = "Subscriptions";
            }            

            if (cboSearchField.Text != "" && txtSearch.Text != "" && dgvPlans.Visible == false)
            {
                searchField = cboSearchField.Text;
                search = txtSearch.Text;
                printer.SubTitle = "Search Field: " + searchField + "\r\nSearch Query: " + search;
            }
            else
            {
                printer.SubTitle = "";
            }

            printer.Title = title;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "STUDIO2 - " + DateTime.Now;
            printer.FooterSpacing = 15;
            printer.PrintPreviewNoDisplaySize(this.Width, this.Height);
            if (printer.DisplayPrintDialog() == DialogResult.OK)
            {
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                printer.PrintPreviewNoDisplay(dataGrid);
            }
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void txtNewPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if ((Regex.IsMatch(txtNewPrice.Text,"^\\d*\\.\\d{2}$")))
                {
                    e.Handled = true;               
                }
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            } 
        }

        private void cboCreatePlans_TextChanged(object sender, EventArgs e)
        {
            txtCreatePlanPrice.Text = "£" + String.Format("{0:0.00}", Subscription_DAL.RetrievePlanPrice(cboCreatePlans.Text));
        }

        private void Subscriptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
