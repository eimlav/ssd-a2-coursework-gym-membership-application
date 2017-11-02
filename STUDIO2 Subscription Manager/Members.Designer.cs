namespace STUDIO2_Subscription_Manager
{
    partial class Members
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.toolStripMainNav = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemFileConnectToDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItemFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAnalytics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSubscriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCreateMember = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateMember = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewMembers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSubSelectMember = new System.Windows.Forms.ToolStripButton();
            this.dgvSQLOutput = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCountyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDIO2_Subscription_ManagerDataSet = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSet();
            this.grpCreateMember = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUpdateMember = new System.Windows.Forms.GroupBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.txtUpPhone = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cboUpTitle = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtUpEmergencyContact = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUpMemberID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.txtUpPostcode = new System.Windows.Forms.TextBox();
            this.lblUpPostcode = new System.Windows.Forms.Label();
            this.txtUpCounty = new System.Windows.Forms.TextBox();
            this.lblUpCounty = new System.Windows.Forms.Label();
            this.txtUpCity = new System.Windows.Forms.TextBox();
            this.lblUpCity = new System.Windows.Forms.Label();
            this.txtUpStreet = new System.Windows.Forms.TextBox();
            this.lblUpStreet = new System.Windows.Forms.Label();
            this.cboUpGender = new System.Windows.Forms.ComboBox();
            this.txtUpEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpUpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUpSurname = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUpFirstName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchField = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.memberTableAdapter = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSetTableAdapters.MemberTableAdapter();
            this.toolStripMainNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2_Subscription_ManagerDataSet)).BeginInit();
            this.grpCreateMember.SuspendLayout();
            this.grpUpdateMember.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMainNav
            // 
            this.toolStripMainNav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMainNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonView,
            this.toolStripSeparator1,
            this.toolStripButtonCreateMember,
            this.toolStripButtonUpdateMember,
            this.toolStripButtonViewMembers,
            this.toolStripButtonSubSelectMember});
            this.toolStripMainNav.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainNav.Name = "toolStripMainNav";
            this.toolStripMainNav.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMainNav.Size = new System.Drawing.Size(750, 25);
            this.toolStripMainNav.TabIndex = 9;
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileConnectToDatabase,
            this.printToolStripMenuItemFilePrint});
            this.toolStripDropDownButtonFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(36, 22);
            this.toolStripDropDownButtonFile.Text = "File";
            // 
            // toolStripMenuItemFileConnectToDatabase
            // 
            this.toolStripMenuItemFileConnectToDatabase.Name = "toolStripMenuItemFileConnectToDatabase";
            this.toolStripMenuItemFileConnectToDatabase.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItemFileConnectToDatabase.Text = "Connect to database";
            this.toolStripMenuItemFileConnectToDatabase.ToolTipText = "Connect to database";
            this.toolStripMenuItemFileConnectToDatabase.Click += new System.EventHandler(this.toolStripMenuItemFileConnectToDatabase_Click);
            // 
            // printToolStripMenuItemFilePrint
            // 
            this.printToolStripMenuItemFilePrint.Name = "printToolStripMenuItemFilePrint";
            this.printToolStripMenuItemFilePrint.Size = new System.Drawing.Size(175, 22);
            this.printToolStripMenuItemFilePrint.Text = "Print";
            this.printToolStripMenuItemFilePrint.ToolTipText = "Print";
            this.printToolStripMenuItemFilePrint.Click += new System.EventHandler(this.printToolStripMenuItemFilePrint_Click);
            // 
            // toolStripDropDownButtonView
            // 
            this.toolStripDropDownButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAnalytics,
            this.toolStripMenuItemMembers,
            this.toolStripMenuItemSubscriptions,
            this.toolStripMenuItemInvoices});
            this.toolStripDropDownButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonView.Image")));
            this.toolStripDropDownButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonView.Name = "toolStripDropDownButtonView";
            this.toolStripDropDownButtonView.Size = new System.Drawing.Size(42, 22);
            this.toolStripDropDownButtonView.Text = "View";
            // 
            // toolStripMenuItemAnalytics
            // 
            this.toolStripMenuItemAnalytics.Name = "toolStripMenuItemAnalytics";
            this.toolStripMenuItemAnalytics.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemAnalytics.Text = "Analytics";
            this.toolStripMenuItemAnalytics.ToolTipText = "Analytics";
            this.toolStripMenuItemAnalytics.Click += new System.EventHandler(this.toolStripMenuItemAnalytics_Click);
            // 
            // toolStripMenuItemMembers
            // 
            this.toolStripMenuItemMembers.Name = "toolStripMenuItemMembers";
            this.toolStripMenuItemMembers.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemMembers.Text = "Members";
            this.toolStripMenuItemMembers.ToolTipText = "Members";
            this.toolStripMenuItemMembers.Click += new System.EventHandler(this.toolStripMenuItemMembers_Click);
            // 
            // toolStripMenuItemSubscriptions
            // 
            this.toolStripMenuItemSubscriptions.Name = "toolStripMenuItemSubscriptions";
            this.toolStripMenuItemSubscriptions.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemSubscriptions.Text = "Subscriptions";
            this.toolStripMenuItemSubscriptions.ToolTipText = "Subscriptions";
            this.toolStripMenuItemSubscriptions.Click += new System.EventHandler(this.toolStripMenuItemSubscriptions_Click);
            // 
            // toolStripMenuItemInvoices
            // 
            this.toolStripMenuItemInvoices.Name = "toolStripMenuItemInvoices";
            this.toolStripMenuItemInvoices.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItemInvoices.Text = "Invoices";
            this.toolStripMenuItemInvoices.ToolTipText = "Invoices";
            this.toolStripMenuItemInvoices.Click += new System.EventHandler(this.toolStripMenuItemInvoices_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCreateMember
            // 
            this.toolStripButtonCreateMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCreateMember.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateMember.Image")));
            this.toolStripButtonCreateMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateMember.Name = "toolStripButtonCreateMember";
            this.toolStripButtonCreateMember.Size = new System.Drawing.Size(85, 22);
            this.toolStripButtonCreateMember.Text = "Create Member";
            this.toolStripButtonCreateMember.Click += new System.EventHandler(this.toolStripButtonCreateMember_Click);
            // 
            // toolStripButtonUpdateMember
            // 
            this.toolStripButtonUpdateMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateMember.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateMember.Image")));
            this.toolStripButtonUpdateMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateMember.Name = "toolStripButtonUpdateMember";
            this.toolStripButtonUpdateMember.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonUpdateMember.Text = "Update Member";
            this.toolStripButtonUpdateMember.Click += new System.EventHandler(this.toolStripButtonUpdateExisting_Click);
            // 
            // toolStripButtonViewMembers
            // 
            this.toolStripButtonViewMembers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonViewMembers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewMembers.Image")));
            this.toolStripButtonViewMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewMembers.Name = "toolStripButtonViewMembers";
            this.toolStripButtonViewMembers.Size = new System.Drawing.Size(93, 22);
            this.toolStripButtonViewMembers.Text = "View All Members";
            this.toolStripButtonViewMembers.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // toolStripButtonSubSelectMember
            // 
            this.toolStripButtonSubSelectMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSubSelectMember.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSubSelectMember.Image")));
            this.toolStripButtonSubSelectMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSubSelectMember.Name = "toolStripButtonSubSelectMember";
            this.toolStripButtonSubSelectMember.Size = new System.Drawing.Size(81, 22);
            this.toolStripButtonSubSelectMember.Text = "Select Member";
            this.toolStripButtonSubSelectMember.Click += new System.EventHandler(this.toolStripButtonSubSelectMember_Click);
            // 
            // dgvSQLOutput
            // 
            this.dgvSQLOutput.AutoGenerateColumns = false;
            this.dgvSQLOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSQLOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSQLOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressLineDataGridViewTextBoxColumn,
            this.addressCityDataGridViewTextBoxColumn,
            this.addressCountyDataGridViewTextBoxColumn,
            this.addressPostcodeDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.EmergencyContactNumber,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvSQLOutput.DataSource = this.memberBindingSource;
            this.dgvSQLOutput.Location = new System.Drawing.Point(13, 92);
            this.dgvSQLOutput.Name = "dgvSQLOutput";
            this.dgvSQLOutput.ReadOnly = true;
            this.dgvSQLOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSQLOutput.Size = new System.Drawing.Size(717, 379);
            this.dgvSQLOutput.TabIndex = 10;
            this.dgvSQLOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSQLOutput_CellClick);
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressLineDataGridViewTextBoxColumn
            // 
            this.addressLineDataGridViewTextBoxColumn.DataPropertyName = "AddressLine";
            this.addressLineDataGridViewTextBoxColumn.HeaderText = "AddressLine";
            this.addressLineDataGridViewTextBoxColumn.Name = "addressLineDataGridViewTextBoxColumn";
            this.addressLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressCityDataGridViewTextBoxColumn
            // 
            this.addressCityDataGridViewTextBoxColumn.DataPropertyName = "AddressCity";
            this.addressCityDataGridViewTextBoxColumn.HeaderText = "AddressCity";
            this.addressCityDataGridViewTextBoxColumn.Name = "addressCityDataGridViewTextBoxColumn";
            this.addressCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressCountyDataGridViewTextBoxColumn
            // 
            this.addressCountyDataGridViewTextBoxColumn.DataPropertyName = "AddressCounty";
            this.addressCountyDataGridViewTextBoxColumn.HeaderText = "AddressCounty";
            this.addressCountyDataGridViewTextBoxColumn.Name = "addressCountyDataGridViewTextBoxColumn";
            this.addressCountyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressPostcodeDataGridViewTextBoxColumn
            // 
            this.addressPostcodeDataGridViewTextBoxColumn.DataPropertyName = "AddressPostcode";
            this.addressPostcodeDataGridViewTextBoxColumn.HeaderText = "AddressPostcode";
            this.addressPostcodeDataGridViewTextBoxColumn.Name = "addressPostcodeDataGridViewTextBoxColumn";
            this.addressPostcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmergencyContactNumber
            // 
            this.EmergencyContactNumber.DataPropertyName = "EmergencyContactNumber";
            this.EmergencyContactNumber.HeaderText = "EmergencyContactNumber";
            this.EmergencyContactNumber.Name = "EmergencyContactNumber";
            this.EmergencyContactNumber.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.sTUDIO2_Subscription_ManagerDataSet;
            // 
            // sTUDIO2_Subscription_ManagerDataSet
            // 
            this.sTUDIO2_Subscription_ManagerDataSet.DataSetName = "STUDIO2_Subscription_ManagerDataSet";
            this.sTUDIO2_Subscription_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpCreateMember
            // 
            this.grpCreateMember.Controls.Add(this.txtPhone);
            this.grpCreateMember.Controls.Add(this.label30);
            this.grpCreateMember.Controls.Add(this.cboTitle);
            this.grpCreateMember.Controls.Add(this.label29);
            this.grpCreateMember.Controls.Add(this.txtEmergencyContact);
            this.grpCreateMember.Controls.Add(this.label21);
            this.grpCreateMember.Controls.Add(this.btnCreateMember);
            this.grpCreateMember.Controls.Add(this.txtPostcode);
            this.grpCreateMember.Controls.Add(this.lblPostcode);
            this.grpCreateMember.Controls.Add(this.txtCounty);
            this.grpCreateMember.Controls.Add(this.lblCounty);
            this.grpCreateMember.Controls.Add(this.txtCity);
            this.grpCreateMember.Controls.Add(this.lblCity);
            this.grpCreateMember.Controls.Add(this.txtStreet);
            this.grpCreateMember.Controls.Add(this.lblStreet);
            this.grpCreateMember.Controls.Add(this.cboGender);
            this.grpCreateMember.Controls.Add(this.txtEmail);
            this.grpCreateMember.Controls.Add(this.label5);
            this.grpCreateMember.Controls.Add(this.label4);
            this.grpCreateMember.Controls.Add(this.dtpDateOfBirth);
            this.grpCreateMember.Controls.Add(this.label3);
            this.grpCreateMember.Controls.Add(this.txtSurname);
            this.grpCreateMember.Controls.Add(this.label2);
            this.grpCreateMember.Controls.Add(this.txtFirstName);
            this.grpCreateMember.Controls.Add(this.label1);
            this.grpCreateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreateMember.Location = new System.Drawing.Point(12, 28);
            this.grpCreateMember.Name = "grpCreateMember";
            this.grpCreateMember.Size = new System.Drawing.Size(717, 442);
            this.grpCreateMember.TabIndex = 11;
            this.grpCreateMember.TabStop = false;
            this.grpCreateMember.Text = "CREATE MEMBER";
            this.grpCreateMember.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(142, 173);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 21);
            this.txtPhone.TabIndex = 35;
            this.txtPhone.Tag = "4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(8, 174);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 16);
            this.label30.TabIndex = 30;
            this.label30.Text = "Phone:";
            // 
            // cboTitle
            // 
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Miss",
            "Advocate",
            "Ambassador",
            "Baron",
            "Baroness",
            "Brigadier",
            "Canon",
            "Captain",
            "Chancellor",
            "Chief",
            "Col",
            "Comdr",
            "Commodore",
            "Councillor",
            "Count",
            "Countess",
            "Dame",
            "Dr",
            "Duke of",
            "Earl",
            "Earl of",
            "Father",
            "General",
            "Group Captain",
            "H R H the Duchess of",
            "H R H the Duke of",
            "H R H The Princess",
            "HE Mr",
            "HE Senora",
            "HE The French Ambassador M",
            "His Highness",
            "His Hon",
            "His Hon Judge",
            "Hon",
            "Hon Ambassador",
            "Hon Dr",
            "Hon Lady",
            "Hon Mrs",
            "HRH",
            "HRH Sultan Shah",
            "HRH The",
            "HRH The Prince",
            "HRH The Princess",
            "HSH Princess",
            "HSH The Prince",
            "Judge",
            "King",
            "Lady",
            "Lord",
            "Lord Justice",
            "Lt Cdr",
            "Lt Col",
            "Madam",
            "Madame",
            "Maj",
            "Maj Gen",
            "Major",
            "Marchesa",
            "Marchese",
            "Marchioness",
            "Marchioness of",
            "Marquess",
            "Marquess of",
            "Marquis",
            "Marquise",
            "Master",
            "President",
            "Prince",
            "Princess",
            "Princessin",
            "Prof",
            "Prof Emeritus",
            "Prof Dame",
            "Professor",
            "Queen",
            "Rabbi",
            "Representative",
            "Rev Canon",
            "Rev Dr",
            "Rev Mgr",
            "Rev Preb",
            "Reverend",
            "Reverend Father",
            "Right Rev",
            "Rt Hon",
            "Rt Hon Baroness",
            "Rt Hon Lord",
            "Rt Hon Sir",
            "Rt Hon The Earl",
            "Rt Hon Viscount",
            "Senator",
            "Sir",
            "Sister",
            "Sultan",
            "The Baroness",
            "The Countess",
            "The Countess of",
            "The Dowager Marchioness of",
            "The Duchess",
            "The Duchess of",
            "The Duke of",
            "The Earl of",
            "The Hon",
            "The Hon Mr",
            "The Hon Mrs",
            "The Hon Ms",
            "The Hon Sir",
            "The Lady",
            "The Lord",
            "The Marchioness of",
            "The Princess",
            "The Reverend",
            "The Rt Hon",
            "The Rt Hon Lord",
            "The Rt Hon Sir",
            "The Rt Hon The Lord",
            "The Rt Hon the Viscount",
            "The Rt Hon Viscount",
            "The Venerable",
            "The Very Rev Dr",
            "Very Reverend",
            "Viscondessa",
            "Viscount",
            "Viscountess",
            "W Baron",
            "W/Cdr"});
            this.cboTitle.Location = new System.Drawing.Point(113, 18);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(152, 21);
            this.cboTitle.TabIndex = 29;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(8, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 16);
            this.label29.TabIndex = 28;
            this.label29.Text = "Title:";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContact.Location = new System.Drawing.Point(142, 200);
            this.txtEmergencyContact.MaxLength = 15;
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(123, 21);
            this.txtEmergencyContact.TabIndex = 36;
            this.txtEmergencyContact.Tag = "5";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 201);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 16);
            this.label21.TabIndex = 25;
            this.label21.Text = "Emergency Contact:";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.Location = new System.Drawing.Point(457, 125);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(254, 23);
            this.btnCreateMember.TabIndex = 41;
            this.btnCreateMember.Text = "CREATE MEMBER";
            this.btnCreateMember.UseVisualStyleBackColor = false;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(559, 95);
            this.txtPostcode.MaxLength = 8;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(152, 21);
            this.txtPostcode.TabIndex = 40;
            this.txtPostcode.Tag = "9";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(454, 96);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(64, 16);
            this.lblPostcode.TabIndex = 18;
            this.lblPostcode.Text = "Postcode:";
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(559, 69);
            this.txtCounty.MaxLength = 30;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(152, 21);
            this.txtCounty.TabIndex = 39;
            this.txtCounty.Tag = "8";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(454, 70);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(52, 16);
            this.lblCounty.TabIndex = 16;
            this.lblCounty.Text = "County:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(559, 43);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(152, 21);
            this.txtCity.TabIndex = 38;
            this.txtCity.Tag = "7";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(454, 44);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(559, 17);
            this.txtStreet.MaxLength = 45;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(152, 21);
            this.txtStreet.TabIndex = 37;
            this.txtStreet.Tag = "6";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(454, 18);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(48, 16);
            this.lblStreet.TabIndex = 12;
            this.lblStreet.Text = "Street:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(113, 122);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(152, 21);
            this.cboGender.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(113, 148);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 21);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Tag = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(113, 96);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(152, 21);
            this.dtpDateOfBirth.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of birth:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(113, 69);
            this.txtSurname.MaxLength = 30;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(152, 21);
            this.txtSurname.TabIndex = 31;
            this.txtSurname.Tag = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(113, 43);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 21);
            this.txtFirstName.TabIndex = 30;
            this.txtFirstName.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // grpUpdateMember
            // 
            this.grpUpdateMember.Controls.Add(this.btnDeleteMember);
            this.grpUpdateMember.Controls.Add(this.txtUpPhone);
            this.grpUpdateMember.Controls.Add(this.label31);
            this.grpUpdateMember.Controls.Add(this.cboUpTitle);
            this.grpUpdateMember.Controls.Add(this.label28);
            this.grpUpdateMember.Controls.Add(this.txtUpEmergencyContact);
            this.grpUpdateMember.Controls.Add(this.label20);
            this.grpUpdateMember.Controls.Add(this.txtUpMemberID);
            this.grpUpdateMember.Controls.Add(this.label19);
            this.grpUpdateMember.Controls.Add(this.btnUpdateMember);
            this.grpUpdateMember.Controls.Add(this.txtUpPostcode);
            this.grpUpdateMember.Controls.Add(this.lblUpPostcode);
            this.grpUpdateMember.Controls.Add(this.txtUpCounty);
            this.grpUpdateMember.Controls.Add(this.lblUpCounty);
            this.grpUpdateMember.Controls.Add(this.txtUpCity);
            this.grpUpdateMember.Controls.Add(this.lblUpCity);
            this.grpUpdateMember.Controls.Add(this.txtUpStreet);
            this.grpUpdateMember.Controls.Add(this.lblUpStreet);
            this.grpUpdateMember.Controls.Add(this.cboUpGender);
            this.grpUpdateMember.Controls.Add(this.txtUpEmail);
            this.grpUpdateMember.Controls.Add(this.label14);
            this.grpUpdateMember.Controls.Add(this.label15);
            this.grpUpdateMember.Controls.Add(this.dtpUpDateOfBirth);
            this.grpUpdateMember.Controls.Add(this.label16);
            this.grpUpdateMember.Controls.Add(this.txtUpSurname);
            this.grpUpdateMember.Controls.Add(this.label17);
            this.grpUpdateMember.Controls.Add(this.txtUpFirstName);
            this.grpUpdateMember.Controls.Add(this.label18);
            this.grpUpdateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateMember.Location = new System.Drawing.Point(12, 28);
            this.grpUpdateMember.Name = "grpUpdateMember";
            this.grpUpdateMember.Size = new System.Drawing.Size(717, 442);
            this.grpUpdateMember.TabIndex = 12;
            this.grpUpdateMember.TabStop = false;
            this.grpUpdateMember.Text = "UPDATE MEMBER";
            this.grpUpdateMember.Visible = false;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.Red;
            this.btnDeleteMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteMember.Location = new System.Drawing.Point(457, 154);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(254, 23);
            this.btnDeleteMember.TabIndex = 56;
            this.btnDeleteMember.Text = "DELETE MEMBER";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // txtUpPhone
            // 
            this.txtUpPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpPhone.Location = new System.Drawing.Point(111, 226);
            this.txtUpPhone.MaxLength = 15;
            this.txtUpPhone.Name = "txtUpPhone";
            this.txtUpPhone.Size = new System.Drawing.Size(152, 21);
            this.txtUpPhone.TabIndex = 50;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 227);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 16);
            this.label31.TabIndex = 36;
            this.label31.Text = "Phone:";
            // 
            // cboUpTitle
            // 
            this.cboUpTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpTitle.FormattingEnabled = true;
            this.cboUpTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Miss",
            "Advocate",
            "Ambassador",
            "Baron",
            "Baroness",
            "Brigadier",
            "Canon",
            "Captain",
            "Chancellor",
            "Chief",
            "Col",
            "Comdr",
            "Commodore",
            "Councillor",
            "Count",
            "Countess",
            "Dame",
            "Dr",
            "Duke of",
            "Earl",
            "Earl of",
            "Father",
            "General",
            "Group Captain",
            "H R H the Duchess of",
            "H R H the Duke of",
            "H R H The Princess",
            "HE Mr",
            "HE Senora",
            "HE The French Ambassador M",
            "His Highness",
            "His Hon",
            "His Hon Judge",
            "Hon",
            "Hon Ambassador",
            "Hon Dr",
            "Hon Lady",
            "Hon Mrs",
            "HRH",
            "HRH Sultan Shah",
            "HRH The",
            "HRH The Prince",
            "HRH The Princess",
            "HSH Princess",
            "HSH The Prince",
            "Judge",
            "King",
            "Lady",
            "Lord",
            "Lord Justice",
            "Lt Cdr",
            "Lt Col",
            "Madam",
            "Madame",
            "Maj",
            "Maj Gen",
            "Major",
            "Marchesa",
            "Marchese",
            "Marchioness",
            "Marchioness of",
            "Marquess",
            "Marquess of",
            "Marquis",
            "Marquise",
            "Master",
            "President",
            "Prince",
            "Princess",
            "Princessin",
            "Prof",
            "Prof Emeritus",
            "Prof Dame",
            "Professor",
            "Queen",
            "Rabbi",
            "Representative",
            "Rev Canon",
            "Rev Dr",
            "Rev Mgr",
            "Rev Preb",
            "Reverend",
            "Reverend Father",
            "Right Rev",
            "Rt Hon",
            "Rt Hon Baroness",
            "Rt Hon Lord",
            "Rt Hon Sir",
            "Rt Hon The Earl",
            "Rt Hon Viscount",
            "Senator",
            "Sir",
            "Sister",
            "Sultan",
            "The Baroness",
            "The Countess",
            "The Countess of",
            "The Dowager Marchioness of",
            "The Duchess",
            "The Duchess of",
            "The Duke of",
            "The Earl of",
            "The Hon",
            "The Hon Mr",
            "The Hon Mrs",
            "The Hon Ms",
            "The Hon Sir",
            "The Lady",
            "The Lord",
            "The Marchioness of",
            "The Princess",
            "The Reverend",
            "The Rt Hon",
            "The Rt Hon Lord",
            "The Rt Hon Sir",
            "The Rt Hon The Lord",
            "The Rt Hon the Viscount",
            "The Rt Hon Viscount",
            "The Venerable",
            "The Very Rev Dr",
            "Very Reverend",
            "Viscondessa",
            "Viscount",
            "Viscountess",
            "W Baron",
            "W/Cdr"});
            this.cboUpTitle.Location = new System.Drawing.Point(111, 42);
            this.cboUpTitle.MaxLength = 30;
            this.cboUpTitle.Name = "cboUpTitle";
            this.cboUpTitle.Size = new System.Drawing.Size(152, 21);
            this.cboUpTitle.TabIndex = 43;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 44);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 16);
            this.label28.TabIndex = 34;
            this.label28.Text = "Title:";
            // 
            // txtUpEmergencyContact
            // 
            this.txtUpEmergencyContact.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpEmergencyContact.Location = new System.Drawing.Point(140, 199);
            this.txtUpEmergencyContact.MaxLength = 15;
            this.txtUpEmergencyContact.Name = "txtUpEmergencyContact";
            this.txtUpEmergencyContact.Size = new System.Drawing.Size(123, 21);
            this.txtUpEmergencyContact.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 16);
            this.label20.TabIndex = 23;
            this.label20.Text = "Emergency Contact:";
            // 
            // txtUpMemberID
            // 
            this.txtUpMemberID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpMemberID.Location = new System.Drawing.Point(111, 15);
            this.txtUpMemberID.Name = "txtUpMemberID";
            this.txtUpMemberID.ReadOnly = true;
            this.txtUpMemberID.Size = new System.Drawing.Size(152, 21);
            this.txtUpMemberID.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "Member ID:";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMember.Location = new System.Drawing.Point(457, 125);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(254, 23);
            this.btnUpdateMember.TabIndex = 55;
            this.btnUpdateMember.Text = "UPDATE MEMBER";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // txtUpPostcode
            // 
            this.txtUpPostcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpPostcode.Location = new System.Drawing.Point(559, 95);
            this.txtUpPostcode.MaxLength = 8;
            this.txtUpPostcode.Name = "txtUpPostcode";
            this.txtUpPostcode.Size = new System.Drawing.Size(152, 21);
            this.txtUpPostcode.TabIndex = 54;
            // 
            // lblUpPostcode
            // 
            this.lblUpPostcode.AutoSize = true;
            this.lblUpPostcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpPostcode.Location = new System.Drawing.Point(454, 96);
            this.lblUpPostcode.Name = "lblUpPostcode";
            this.lblUpPostcode.Size = new System.Drawing.Size(64, 16);
            this.lblUpPostcode.TabIndex = 18;
            this.lblUpPostcode.Text = "Postcode:";
            // 
            // txtUpCounty
            // 
            this.txtUpCounty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpCounty.Location = new System.Drawing.Point(559, 69);
            this.txtUpCounty.MaxLength = 30;
            this.txtUpCounty.Name = "txtUpCounty";
            this.txtUpCounty.Size = new System.Drawing.Size(152, 21);
            this.txtUpCounty.TabIndex = 53;
            // 
            // lblUpCounty
            // 
            this.lblUpCounty.AutoSize = true;
            this.lblUpCounty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpCounty.Location = new System.Drawing.Point(454, 70);
            this.lblUpCounty.Name = "lblUpCounty";
            this.lblUpCounty.Size = new System.Drawing.Size(52, 16);
            this.lblUpCounty.TabIndex = 16;
            this.lblUpCounty.Text = "County:";
            // 
            // txtUpCity
            // 
            this.txtUpCity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpCity.Location = new System.Drawing.Point(559, 43);
            this.txtUpCity.MaxLength = 30;
            this.txtUpCity.Name = "txtUpCity";
            this.txtUpCity.Size = new System.Drawing.Size(152, 21);
            this.txtUpCity.TabIndex = 52;
            // 
            // lblUpCity
            // 
            this.lblUpCity.AutoSize = true;
            this.lblUpCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpCity.Location = new System.Drawing.Point(454, 44);
            this.lblUpCity.Name = "lblUpCity";
            this.lblUpCity.Size = new System.Drawing.Size(34, 16);
            this.lblUpCity.TabIndex = 14;
            this.lblUpCity.Text = "City:";
            // 
            // txtUpStreet
            // 
            this.txtUpStreet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpStreet.Location = new System.Drawing.Point(559, 17);
            this.txtUpStreet.MaxLength = 45;
            this.txtUpStreet.Name = "txtUpStreet";
            this.txtUpStreet.Size = new System.Drawing.Size(152, 21);
            this.txtUpStreet.TabIndex = 51;
            // 
            // lblUpStreet
            // 
            this.lblUpStreet.AutoSize = true;
            this.lblUpStreet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpStreet.Location = new System.Drawing.Point(454, 18);
            this.lblUpStreet.Name = "lblUpStreet";
            this.lblUpStreet.Size = new System.Drawing.Size(48, 16);
            this.lblUpStreet.TabIndex = 12;
            this.lblUpStreet.Text = "Street:";
            // 
            // cboUpGender
            // 
            this.cboUpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpGender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpGender.FormattingEnabled = true;
            this.cboUpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboUpGender.Location = new System.Drawing.Point(111, 147);
            this.cboUpGender.Name = "cboUpGender";
            this.cboUpGender.Size = new System.Drawing.Size(152, 21);
            this.cboUpGender.TabIndex = 47;
            // 
            // txtUpEmail
            // 
            this.txtUpEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpEmail.Location = new System.Drawing.Point(111, 173);
            this.txtUpEmail.MaxLength = 30;
            this.txtUpEmail.Name = "txtUpEmail";
            this.txtUpEmail.Size = new System.Drawing.Size(152, 21);
            this.txtUpEmail.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Gender:";
            // 
            // dtpUpDateOfBirth
            // 
            this.dtpUpDateOfBirth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUpDateOfBirth.Location = new System.Drawing.Point(111, 121);
            this.dtpUpDateOfBirth.Name = "dtpUpDateOfBirth";
            this.dtpUpDateOfBirth.Size = new System.Drawing.Size(152, 21);
            this.dtpUpDateOfBirth.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Date of birth:";
            // 
            // txtUpSurname
            // 
            this.txtUpSurname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpSurname.Location = new System.Drawing.Point(111, 94);
            this.txtUpSurname.MaxLength = 30;
            this.txtUpSurname.Name = "txtUpSurname";
            this.txtUpSurname.Size = new System.Drawing.Size(152, 21);
            this.txtUpSurname.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Surname:";
            // 
            // txtUpFirstName
            // 
            this.txtUpFirstName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpFirstName.Location = new System.Drawing.Point(111, 68);
            this.txtUpFirstName.MaxLength = 30;
            this.txtUpFirstName.Name = "txtUpFirstName";
            this.txtUpFirstName.Size = new System.Drawing.Size(152, 21);
            this.txtUpFirstName.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "First name:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearchResults);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.cboSearchField);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(13, 29);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(717, 57);
            this.grpSearch.TabIndex = 35;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "SEARCH";
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(355, 23);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(0, 13);
            this.lblSearchResults.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(299, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearchField
            // 
            this.cboSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchField.FormattingEnabled = true;
            this.cboSearchField.Location = new System.Drawing.Point(7, 19);
            this.cboSearchField.Name = "cboSearchField";
            this.cboSearchField.Size = new System.Drawing.Size(121, 21);
            this.cboSearchField.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(141, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 484);
            this.Controls.Add(this.grpCreateMember);
            this.Controls.Add(this.grpUpdateMember);
            this.Controls.Add(this.dgvSQLOutput);
            this.Controls.Add(this.toolStripMainNav);
            this.Controls.Add(this.grpSearch);
            this.MinimumSize = new System.Drawing.Size(758, 511);
            this.Name = "Members";
            this.Text = "STUDIO2 Subscription Manager | Members";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Members_FormClosing);
            this.Load += new System.EventHandler(this.Members_Load);
            this.Resize += new System.EventHandler(this.Members_Resize);
            this.toolStripMainNav.ResumeLayout(false);
            this.toolStripMainNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2_Subscription_ManagerDataSet)).EndInit();
            this.grpCreateMember.ResumeLayout(false);
            this.grpCreateMember.PerformLayout();
            this.grpUpdateMember.ResumeLayout(false);
            this.grpUpdateMember.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMainNav;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileConnectToDatabase;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItemFilePrint;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAnalytics;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMembers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInvoices;
        private System.Windows.Forms.DataGridView dgvSQLOutput;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateMember;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateMember;
        private System.Windows.Forms.GroupBox grpCreateMember;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox grpUpdateMember;
        private System.Windows.Forms.TextBox txtUpEmergencyContact;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtUpMemberID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.TextBox txtUpPostcode;
        private System.Windows.Forms.Label lblUpPostcode;
        private System.Windows.Forms.TextBox txtUpCounty;
        private System.Windows.Forms.Label lblUpCounty;
        private System.Windows.Forms.TextBox txtUpCity;
        private System.Windows.Forms.Label lblUpCity;
        private System.Windows.Forms.TextBox txtUpStreet;
        private System.Windows.Forms.Label lblUpStreet;
        private System.Windows.Forms.ComboBox cboUpGender;
        private System.Windows.Forms.TextBox txtUpEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpUpDateOfBirth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUpSurname;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUpFirstName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSearchField;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewMembers;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cboUpTitle;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtUpPhone;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.ToolStripButton toolStripButtonSubSelectMember;
        private STUDIO2_Subscription_ManagerDataSet sTUDIO2_Subscription_ManagerDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private STUDIO2_Subscription_ManagerDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCountyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}