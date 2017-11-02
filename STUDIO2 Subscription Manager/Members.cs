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
using System.Text.RegularExpressions;
using DGVPrinterHelper;

namespace STUDIO2_Subscription_Manager
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        DateTime today = new DateTime();
        private static int memberIDValue;
        string memberIDInput;
        private static int searchingMemberID = 0;
        Member Member = new Member();
        bool viewingData = true;

        // retrieved by Subscription Form to determine if the user was previously selecting a member for a new subscription
        public static int searchingMemberIDCall()
        {
            int temp = searchingMemberID;
            searchingMemberID = 0;
            return temp;
        }

        // grpCreateMember displays with all fields empty
        private void toolStripButtonCreateMember_Click(object sender, EventArgs e)
        {
            DateTime today = new DateTime();
            today = DateTime.Today;
            cboTitle.Text = null;
            txtFirstName.Text = "";
            txtSurname.Text = "";
            dtpDateOfBirth.Value = today;
            cboGender.Text = null;
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtEmergencyContact.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";
            grpCreateMember.Visible = true;            
            grpUpdateMember.Visible = false;
            viewingData = false;
            dgvSQLOutput.ClearSelection();
            dgvSQLOutput.Visible = false;
        }

        // valid cell/row selected - displays grpUpdateInvoice with all fields filled in
        // invalid cell/row selected - MessageBox displays indicating that a valid cell/row must be selected
        private void toolStripButtonUpdateExisting_Click(object sender, EventArgs e)
        {
            int rowindex;
            int columnindex;
            if(viewingData == false)
            {
                grpCreateMember.Visible = false;
                MessageBox.Show("No member selected. Click a cell of the chosen member then click 'Update Member' to update member details.", "Update Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSQLOutput.Visible = true;
                return;
            }
            else
            {
                try
                {
                    rowindex = dgvSQLOutput.CurrentCell.RowIndex;
                    columnindex = dgvSQLOutput.CurrentCell.ColumnIndex;
                    memberIDInput = dgvSQLOutput.Rows[rowindex].Cells[0].Value.ToString();
                    if (Convert.ToInt32(memberIDInput) < 0)
                    {
                        MessageBox.Show("Ensure that the row/cell for the corresponding member has been selected", "Update Member");
                        return;
                    }
                    Console.WriteLine(rowindex + " " + columnindex + " " + memberIDInput);

                    // Fill 'Update Member' textboxes with appropriate information retrieved from DataGridView 
                    txtUpMemberID.Text = dgvSQLOutput.Rows[rowindex].Cells[0].Value.ToString();
                    cboUpTitle.Text = dgvSQLOutput.Rows[rowindex].Cells[1].Value.ToString();
                    txtUpFirstName.Text = dgvSQLOutput.Rows[rowindex].Cells[2].Value.ToString();
                    txtUpSurname.Text = dgvSQLOutput.Rows[rowindex].Cells[3].Value.ToString();
                    txtUpStreet.Text = dgvSQLOutput.Rows[rowindex].Cells[4].Value.ToString();
                    txtUpCity.Text = dgvSQLOutput.Rows[rowindex].Cells[5].Value.ToString();
                    txtUpCounty.Text = dgvSQLOutput.Rows[rowindex].Cells[6].Value.ToString();
                    txtUpPostcode.Text = dgvSQLOutput.Rows[rowindex].Cells[7].Value.ToString();
                    dtpUpDateOfBirth.Value = Convert.ToDateTime(dgvSQLOutput.Rows[rowindex].Cells[8].Value);
                    txtUpEmergencyContact.Text = dgvSQLOutput.Rows[rowindex].Cells[9].Value.ToString();
                    cboUpGender.Text = dgvSQLOutput.Rows[rowindex].Cells[10].Value.ToString();
                    txtUpPhone.Text = dgvSQLOutput.Rows[rowindex].Cells[11].Value.ToString();
                    txtUpEmail.Text = dgvSQLOutput.Rows[rowindex].Cells[12].Value.ToString();                  

                    grpUpdateMember.Visible = true;
                    dgvSQLOutput.Visible = false;
                    grpCreateMember.Visible = false;
                    
                }
                catch
                {
                    MessageBox.Show("Ensure that the row/cell for the corresponding member has been selected", "Update Member");
                    return;
                }      
            }                              
        }

        
        
        private void Members_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'sTUDIO2_Subscription_ManagerDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.sTUDIO2_Subscription_ManagerDataSet.Member);

            today = DateTime.Today;
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;

            // cboSearchField Items retrieved from the columns in dgvSQLOutput DataGridView           
            List<DataGridViewColumn> listOfColumns = new List<DataGridViewColumn>();
            dgvSQLOutput.SelectAll();
            foreach (DataGridViewCell cell in dgvSQLOutput.SelectedCells)
            {
                DataGridViewColumn col = dgvSQLOutput.Columns[cell.ColumnIndex] as DataGridViewColumn;
                if (!listOfColumns.Contains(col))
                {
                    listOfColumns.Add(col);
                }
            }
          
            List<string> sb = new List<string>();
            foreach (DataGridViewColumn col in listOfColumns)
            {
                sb.Add(col.HeaderText);
                Console.WriteLine(col.HeaderText);
            }
            
            foreach (string str in sb)
            {
                cboSearchField.Items.Add(str);
            }         
         
            // retrieve number of rows present to display in lblSearchResults
            int rowCount = (dgvSQLOutput.RowCount - 1);
            if (rowCount < 0)
            {
                rowCount = 0;
            }            
            lblSearchResults.Text = rowCount + " results found";
            
            cboSearchField.Text = "MemberID";

            // searchingMemberIDCall() to determine if user selected 'Search' Button when creating subscription in Subscription Form
            // If true, toolStripButtonSubSelectMember is the only one left visible
            // If false, toolStripButtonSubSelectMember is the only one set invisible
            bool buttonsVisible = true;
            this.Text = "STUDIO2 Subscription Manager | Members";
            searchingMemberID = Subscriptions.searchingMemberIDCall();
            Console.WriteLine("MEMBER SEARCHING MEMBER ID: " + searchingMemberID.ToString());
            if(searchingMemberID == 1 || searchingMemberID == 2)
            {
                buttonsVisible = false;
                this.Text = "STUDIO2 Subscription Manager | Subscriptions - Select a Member";
            }
            else
            {
                buttonsVisible = true;
            }
            
            toolStripButtonCreateMember.Visible = buttonsVisible;
            toolStripButtonUpdateMember.Visible = buttonsVisible;
            toolStripButtonViewMembers.Visible = buttonsVisible;
            toolStripButtonSubSelectMember.Visible = !buttonsVisible;

            dgvSQLOutput.ClearSelection();
        }

        // used when moving onto another form to pass on the current WindowState
        private FormWindowState RetrieveWindowState()
        {
            return this.WindowState;
        }

        // displays new instance of Analytics Form and hides the current Form
        private void toolStripMenuItemAnalytics_Click(object sender, EventArgs e)
        {
            searchingMemberID = 0;
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
            searchingMemberID = 0;
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
            searchingMemberID = 0;
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
            searchingMemberID = 0;
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
            // no text present in txtSearch
            if(txtSearch.Text == "")
            {
                errorMessage += "- Please enter a value into the search box\r\n";
            }
            
            // no selection made in cboSearchField
            if (cboSearchField.Text == "")
            {
                errorMessage += "- Please select a value for the search field\r\n";
            }
            
            // any error message present, display MessageBox with error
            // else execute Search() with selected values
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Search Members"); 
            }
            else
            {
                lblSearchResults.Text = (Search(cboSearchField.Text, txtSearch.Text) - 1).ToString() + " results found";
            }

            dgvSQLOutput.ClearSelection();            
        }   

        // resets dgvSQLOutput to display all member records
        // resets cboSearchField and txtSearch
        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            cboSearchField.Text = "MemberID";
            txtSearch.Text = "";
            
            dgvSQLOutput.DataSource = memberBindingSource;
            dgvSQLOutput.ClearSelection();
            lblSearchResults.Text = (dgvSQLOutput.RowCount - 1).ToString() + " results found";
            grpCreateMember.Visible = false;
            grpUpdateMember.Visible = false;
            dgvSQLOutput.Visible = true;            
        }
        
        // method for creation of a member
        private void btnCreateMember_Click(object sender, EventArgs e)
        {            
            string[] inputs = new string[13];
            DateTime age = dtpDateOfBirth.Value.Date.AddYears(16);
            // check that all TextBoxes and ComboBoxes are filled in
            foreach(Control control in grpCreateMember.Controls)
            {
                if(control is TextBox)
                {
                    if (control.Text == "")
                    {
                        MessageBox.Show("Ensure all fields have been filled in", "Create Member");
                        return;
                    }
                }
                else if (control is ComboBox)
                {
                    if (control.Text == "")
                    {
                        MessageBox.Show("Ensure all fields have been filled in", "Create Member");
                        return;
                    }
                }                
            }

            // check that date of birth entered by user is greater than 16 years old
            if(age < today.Date)
            {
                Member = new Member(cboTitle.Text, txtFirstName.Text, txtSurname.Text, txtStreet.Text, txtCity.Text, txtCounty.Text, txtPostcode.Text, dtpDateOfBirth.Value.ToString("yyyy-MM-dd"), txtEmergencyContact.Text, cboGender.Text, txtPhone.Text, txtEmail.Text);
                int rowsAffected = Member_DAL.CreateMember(Member.Title, Member.FirstName, Member.Surname, Member.AddressLine, Member.AddressCity, Member.AddressCounty, Member.AddressPostcode, Member.DateOfBirth, Member.EmergencyContactNumber, Member.Gender, Member.Phone, Member.Email);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Member successfully created","Create Member");
                    grpCreateMember.Visible = false;
                    dgvSQLOutput.DataSource = typeof(SqlDbType);
                    dgvSQLOutput.DataSource = memberBindingSource;
                    toolStripMenuItemMembers.PerformClick();
                }
                else
                {
                    MessageBox.Show("Encountered error creating member\r\n ", "Create Member");
                }  
            }
            else
            {
                MessageBox.Show("The minimum age to sign up to a gym membership is 16.", "Create Subscription");
            }        
        }

        // method for updating member
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            // check that all TextBoxes and ComboBoxes are filled in
            foreach (Control control in grpUpdateMember.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                        MessageBox.Show("Ensure all fields have been filled in", "Update Member");
                        return;
                    }
                }
                else if (control is ComboBox)
                {
                    if(control.Text == "")
                    {
                        MessageBox.Show("Ensure all fields have been filled in", "Update Member");
                        return;
                    }
                }
            }

            // if date of birth entered by user is greater than 16 years, update member
            DateTime age = dtpUpDateOfBirth.Value.Date.AddYears(16);
            if (age < today.Date)
            {
                Member = new Member(cboUpTitle.Text, txtUpFirstName.Text, txtUpSurname.Text, txtUpStreet.Text, txtUpCity.Text, txtUpCounty.Text, txtUpPostcode.Text, dtpUpDateOfBirth.Value.ToString("yyyy-MM-dd"), txtUpEmergencyContact.Text, cboUpGender.Text, txtUpPhone.Text, txtUpEmail.Text);
                Member.ID = Convert.ToInt32(memberIDInput);
                int rowsAffected = Member_DAL.UpdateMember(Member.Title, Member.FirstName, Member.Surname, Member.AddressLine, Member.AddressCity, Member.AddressCounty, Member.AddressPostcode, Member.DateOfBirth, Member.EmergencyContactNumber, Member.Gender, Member.Phone, Member.Email, Member.ID);
                // rows affected == 1 : operation successful
                // any other value indicates failure
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Member successfully updated","Update Member");
                    grpUpdateMember.Visible = false;
                    dgvSQLOutput.DataSource = typeof(SqlDbType);
                    dgvSQLOutput.DataSource = memberBindingSource;
                    toolStripMenuItemMembers.PerformClick();
                }
                else
                {
                    MessageBox.Show("Encountered error updating member:\r\n ", "Update Member");
                }
            }
            else
            {
                MessageBox.Show("The minimum age to sign up to a gym membership is 16.", "Update Member");
            }    
        }

        // when keyDown on Enter key detected, is programmatically clicked to conduct a search
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                btnSearch.PerformClick();
            }
        }

        // executes search query and fills dgvSQLOutput with the DataSet retrieved containing the results
        private int Search(string field, string input)
        {
            if (txtSearch.Text == "")
            {
                return 1;
            }
            else
            {
                DataSet ds = Member_DAL.SearchMember(field, input);
                dgvSQLOutput.DataSource = ds.Tables[0];                
            }

            return dgvSQLOutput.RowCount;
        }

        // method for deleting member
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            // MessageBox displays to ensure that user wishes to delete member record
            if(MessageBox.Show("Are you sure you wish to delete member " + txtUpFirstName.Text + " " + txtUpSurname.Text + " permanently from database?", "Delete Member", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int i = Member_DAL.DeleteMember(Convert.ToInt32(txtUpMemberID.Text));                    
                    if(i == 1)
                    {
                        MessageBox.Show("Member and all references have now been deleted", "Delete Member");
                        toolStripMenuItemMembers.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Encountered error deleting member", "Delete Member");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Encountered error deleting member", "Delete Member");
                }
                MessageBox.Show("Encountered error deleting member", "Delete Member");
            }
        }
        
        // method used for selecting a member to be passed to Subscription Form when creating a subscription
        private void toolStripButtonSubSelectMember_Click(object sender, EventArgs e)
        {            
            try
            {
                int rowindex = dgvSQLOutput.CurrentCell.RowIndex;
                int columnindex = dgvSQLOutput.CurrentCell.ColumnIndex;               
                memberIDValue = Convert.ToInt32(dgvSQLOutput.Rows[rowindex].Cells[0].Value);
                if (Convert.ToInt32(memberIDValue) < 0)
                {
                    MessageBox.Show("Ensure that the row/cell for the corresponding member has been selected", "Select a Member");
                    return;
                }

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
                MessageBox.Show("Encountered error retrieving member details.", "Select a Member");
                return;
            }         
        }        
       
        // method called by Subscription Form to retrieve MemberID for creating a subscription
        public static int retrieveMemberID()
        {
            return memberIDValue;
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

        // used to check if user is viewing dgvSQLOutput
        private void dgvSQLOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewingData = true;
        }

        // scales position and size of various controls to adjust to window size
        private void RedrawControls()
        {            
            int width = this.Width;
            int height = this.Height;      
            dgvSQLOutput.Width = width - 40;
            dgvSQLOutput.Height = height - 132;
             
            grpSearch.Width = width - 40;

            grpCreateMember.Width = width - 40;
            grpCreateMember.Height = height - 70;

            grpUpdateMember.Width = width - 40;
            grpUpdateMember.Height = height - 70;
        }

        // executes RedrawControls() when Form is resized to scale position and size of various controls to adjust to window size
        private void Members_Resize(object sender, EventArgs e)
        {
            RedrawControls();
        }      

        // method for carrying out printing
        private void printToolStripMenuItemFilePrint_Click(object sender, EventArgs e)
        {
            string searchField;
            string search;          
            DGVPrinter printer = new DGVPrinter();
            printer.PageSettings.Landscape = true;     
            // checks if any search was conducted to determine whether the search query needs added to print document
            if(cboSearchField.Text != "" && txtSearch.Text != "")
            {
                searchField = cboSearchField.Text;
                search = txtSearch.Text;
                printer.SubTitle = "Search Field: " + searchField + "\r\nSearch Query: " + search;
            } 
            else
            {
                printer.SubTitle = "";
            }
            printer.Title = "Members";            
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "STUDIO2 - " + DateTime.Now;
            printer.FooterSpacing = 15;
            printer.PrintPreviewNoDisplaySize(this.Width, this.Height);
            // displays print settings dialog
            if(printer.DisplayPrintDialog() == DialogResult.OK)
            {
                // displays print preview dialog when user selects 'Print' in print settings
                dgvSQLOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                
                printer.PrintPreviewNoDisplay(dgvSQLOutput);
            }
        }

        private void Members_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }       

    }
}
