using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace STUDIO2_Subscription_Manager
{
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        bool viewingData = true;
        int invoiceIDInput;
        string invoiceStatus;

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

        // search for value in dgvSQLOutput
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
                MessageBox.Show(errorMessage, "Search Invoices");
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
                DataSet ds = Invoice_DAL.SearchInvoice(field, input);
                dgvSQLOutput.DataSource = ds.Tables[0];
            }

            return dgvSQLOutput.RowCount;
        }

        private int Filter(string input)
        {
            try
            {
                DataSet ds = Invoice_DAL.FilterInvoices(input);
                dgvSQLOutput.DataSource = ds.Tables[0];

                return dgvSQLOutput.RowCount - 1;
            }
            catch
            {
                return 0;
            }

        }

        // executes search query against IStatus using the selected and fills dgvSQLOutput with the DataSet retrieved containing the results
        private void toolStripButtonFilterSQL(object sender, EventArgs e)
        {
            cboSearchField.Text = "InvoiceID";
            txtSearch.Text = "";
            
            ToolStripButton tspb = (ToolStripButton)sender;
            lblSearchResults.Text = Filter(tspb.Tag.ToString()).ToString() + " results found";
            grpUpdateInvoice.Visible = false;
            dgvSQLOutput.ClearSelection();
        }

        // 
        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDIO2_Subscription_ManagerDataSetInvoice.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.sTUDIO2_Subscription_ManagerDataSetInvoice.Invoice);
            // retrieve number of rows and display
            int rowCount = (dgvSQLOutput.RowCount - 1);
            if (rowCount < 0)
            {
                rowCount = 0;
            }
            lblSearchResults.Text = rowCount + " results found";

            cboSearchField.Text = "InvoiceID";
        }

        // displays a new instance of Start Form and hides the current form
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

        // method for updating invoice
        private void toolStripButtonUpdateInvoice_Click(object sender, EventArgs e)
        {
            int rowindex;
            int columnindex;
            if(viewingData == false)
            {
                MessageBox.Show("No invoice selected. Click a cell of the chosen invoice then click 'Update Invoice' to update invoice details.", "Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    rowindex = dgvSQLOutput.CurrentCell.RowIndex;
                    columnindex = dgvSQLOutput.CurrentCell.ColumnIndex;
                    invoiceIDInput = Convert.ToInt32(dgvSQLOutput.Rows[rowindex].Cells[0].Value);
                    if (Convert.ToInt32(invoiceIDInput) < 0)
                    {
                        MessageBox.Show("Ensure that the row/cell for the corresponding invoice has been selected", "Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpUpdateInvoice.Visible = false;
                        return;
                    }
                    Console.WriteLine(rowindex + " " + columnindex + " " + invoiceIDInput);
                    if (dgvSQLOutput.Rows[rowindex].Cells[3].Value.ToString() == "Pending")
                    {
                        // Fill 'Update Member' textboxes with appropriate information retrieved from DataGridView 
                        txtUpdateInvoiceID.Text = dgvSQLOutput.Rows[rowindex].Cells[0].Value.ToString();
                        txtUpdateIssueDate.Text = Convert.ToDateTime(dgvSQLOutput.Rows[rowindex].Cells[1].Value).ToString("yyyy-MM-dd");
                        txtUpdateSubscriptionID.Text = dgvSQLOutput.Rows[rowindex].Cells[2].Value.ToString();
                        cboIStatus.Text = dgvSQLOutput.Rows[rowindex].Cells[3].Value.ToString();
                        invoiceStatus = dgvSQLOutput.Rows[rowindex].Cells[3].Value.ToString();
                        grpUpdateInvoice.Visible = true;
                    }
                    else
                    {
                        string status = dgvSQLOutput.Rows[rowindex].Cells[3].Value.ToString();
                        MessageBox.Show("The currently selected invoice has been " + status.ToLower() + ". Details can no longer be updated.", "Update Subscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpUpdateInvoice.Visible = false;
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Ensure that the row/cell for the corresponding invoice has been selected", "Update Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }         
        }

        // click event for executing updating of invoice
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if(cboIStatus.Text != invoiceStatus)
            {
                int rowsAffected = Invoice_DAL.UpdateInvoice(txtUpdateInvoiceID.Text, cboIStatus.Text);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Invoice successfully updated.", "Update Invoice");
                    grpUpdateInvoice.Visible = false;
                    toolStripMenuItemInvoices.PerformClick();
                }
                else
                {
                    MessageBox.Show("Encountered error updating invoice.", "Update Invoice");
                }
            }
            else
            {
                MessageBox.Show("No changes have been selected.", "Update Invoice");
            }
            
        }

        // executes RedrawControls() when Form is resized to scale position and size of various controls to adjust to window size
        private void Invoices_Resize(object sender, EventArgs e)
        {
            RedrawControls();
        }

        // scales position and size of various controls to adjust to window size
        private void RedrawControls()
        {
            int width = this.Width;
            int height = this.Height;
            
            dgvSQLOutput.Width = width - 40;
            dgvSQLOutput.Height = height - 132;          

            grpSearch.Width = width - 40;

            grpUpdateInvoice.Width = width - 35;
            grpUpdateInvoice.Height = height - 65;
        }

        // method for carrying out printing
        private void printToolStripMenuItemFilePrint_Click(object sender, EventArgs e)
        {
            string searchField;
            string search;
            DGVPrinter printer = new DGVPrinter();
            printer.PageSettings.Landscape = true;
            // checks if any search was conducted to determine whether the search query needs added to print document
            if (cboSearchField.Text != "" && txtSearch.Text != "")
            {
                searchField = cboSearchField.Text;
                search = txtSearch.Text;
                printer.SubTitle = "Search Field: " + searchField + "\r\nSearch Query: " + search;
            }
            else
            {
                printer.SubTitle = "";
            }
            printer.Title = "Invoices";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "STUDIO2 - " + DateTime.Now;
            printer.FooterSpacing = 15;
            printer.PrintPreviewNoDisplaySize(this.Width, this.Height);
            // displays print settings dialog
            if (printer.DisplayPrintDialog() == DialogResult.OK)
            {
                // displays print preview dialog when user selects 'Print' in print settings
                dgvSQLOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                printer.PrintPreviewNoDisplay(dgvSQLOutput);
            }
            dgvSQLOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Invoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
