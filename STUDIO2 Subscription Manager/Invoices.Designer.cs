namespace STUDIO2_Subscription_Manager
{
    partial class Invoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
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
            this.toolStripButtonAllInvoices = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaid = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPending = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNotPaid = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCanceled = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpdateInvoice = new System.Windows.Forms.ToolStripButton();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchField = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSQLOutput = new System.Windows.Forms.DataGridView();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDIO2_Subscription_ManagerDataSetInvoice = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSetInvoice();
            this.invoiceTableAdapter = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSetInvoiceTableAdapters.InvoiceTableAdapter();
            this.grpUpdateInvoice = new System.Windows.Forms.GroupBox();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.cboIStatus = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUpdateIssueDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUpdateSubscriptionID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateInvoiceID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStripMainNav.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2_Subscription_ManagerDataSetInvoice)).BeginInit();
            this.grpUpdateInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMainNav
            // 
            this.toolStripMainNav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMainNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonView,
            this.toolStripSeparator1,
            this.toolStripButtonAllInvoices,
            this.toolStripButtonPaid,
            this.toolStripButtonPending,
            this.toolStripButtonNotPaid,
            this.toolStripButtonCanceled,
            this.toolStripSeparator2,
            this.toolStripButtonUpdateInvoice});
            this.toolStripMainNav.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainNav.Name = "toolStripMainNav";
            this.toolStripMainNav.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMainNav.Size = new System.Drawing.Size(742, 25);
            this.toolStripMainNav.TabIndex = 7;
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
            // toolStripButtonAllInvoices
            // 
            this.toolStripButtonAllInvoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAllInvoices.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAllInvoices.Image")));
            this.toolStripButtonAllInvoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAllInvoices.Name = "toolStripButtonAllInvoices";
            this.toolStripButtonAllInvoices.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonAllInvoices.Tag = "All";
            this.toolStripButtonAllInvoices.Text = "All Invoices";
            this.toolStripButtonAllInvoices.Click += new System.EventHandler(this.toolStripButtonFilterSQL);
            // 
            // toolStripButtonPaid
            // 
            this.toolStripButtonPaid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPaid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaid.Image")));
            this.toolStripButtonPaid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaid.Name = "toolStripButtonPaid";
            this.toolStripButtonPaid.Size = new System.Drawing.Size(31, 22);
            this.toolStripButtonPaid.Tag = "Paid";
            this.toolStripButtonPaid.Text = "Paid";
            this.toolStripButtonPaid.Click += new System.EventHandler(this.toolStripButtonFilterSQL);
            // 
            // toolStripButtonPending
            // 
            this.toolStripButtonPending.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPending.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPending.Image")));
            this.toolStripButtonPending.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPending.Name = "toolStripButtonPending";
            this.toolStripButtonPending.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonPending.Tag = "Pending";
            this.toolStripButtonPending.Text = "Pending";
            this.toolStripButtonPending.Click += new System.EventHandler(this.toolStripButtonFilterSQL);
            // 
            // toolStripButtonNotPaid
            // 
            this.toolStripButtonNotPaid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNotPaid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNotPaid.Image")));
            this.toolStripButtonNotPaid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNotPaid.Name = "toolStripButtonNotPaid";
            this.toolStripButtonNotPaid.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonNotPaid.Tag = "Not Paid";
            this.toolStripButtonNotPaid.Text = "Not Paid";
            this.toolStripButtonNotPaid.Click += new System.EventHandler(this.toolStripButtonFilterSQL);
            // 
            // toolStripButtonCanceled
            // 
            this.toolStripButtonCanceled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCanceled.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCanceled.Image")));
            this.toolStripButtonCanceled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCanceled.Name = "toolStripButtonCanceled";
            this.toolStripButtonCanceled.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonCanceled.Tag = "Canceled";
            this.toolStripButtonCanceled.Text = "Canceled";
            this.toolStripButtonCanceled.Click += new System.EventHandler(this.toolStripButtonFilterSQL);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUpdateInvoice
            // 
            this.toolStripButtonUpdateInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateInvoice.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateInvoice.Image")));
            this.toolStripButtonUpdateInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateInvoice.Name = "toolStripButtonUpdateInvoice";
            this.toolStripButtonUpdateInvoice.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonUpdateInvoice.Text = "Update Invoice";
            this.toolStripButtonUpdateInvoice.Click += new System.EventHandler(this.toolStripButtonUpdateInvoice_Click);
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
            this.grpSearch.TabIndex = 9;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "SEARCH";
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(355, 23);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(0, 13);
            this.lblSearchResults.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(299, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearchField
            // 
            this.cboSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchField.FormattingEnabled = true;
            this.cboSearchField.Items.AddRange(new object[] {
            "InvoiceID",
            "IssueDate",
            "SubscriptionID",
            "IStatus"});
            this.cboSearchField.Location = new System.Drawing.Point(7, 19);
            this.cboSearchField.Name = "cboSearchField";
            this.cboSearchField.Size = new System.Drawing.Size(121, 21);
            this.cboSearchField.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(141, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvSQLOutput
            // 
            this.dgvSQLOutput.AutoGenerateColumns = false;
            this.dgvSQLOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSQLOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.subscriptionIDDataGridViewTextBoxColumn,
            this.iStatusDataGridViewTextBoxColumn});
            this.dgvSQLOutput.DataSource = this.invoiceBindingSource;
            this.dgvSQLOutput.Location = new System.Drawing.Point(13, 92);
            this.dgvSQLOutput.Name = "dgvSQLOutput";
            this.dgvSQLOutput.Size = new System.Drawing.Size(717, 379);
            this.dgvSQLOutput.TabIndex = 10;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            // 
            // subscriptionIDDataGridViewTextBoxColumn
            // 
            this.subscriptionIDDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionID";
            this.subscriptionIDDataGridViewTextBoxColumn.HeaderText = "SubscriptionID";
            this.subscriptionIDDataGridViewTextBoxColumn.Name = "subscriptionIDDataGridViewTextBoxColumn";
            // 
            // iStatusDataGridViewTextBoxColumn
            // 
            this.iStatusDataGridViewTextBoxColumn.DataPropertyName = "IStatus";
            this.iStatusDataGridViewTextBoxColumn.HeaderText = "IStatus";
            this.iStatusDataGridViewTextBoxColumn.Name = "iStatusDataGridViewTextBoxColumn";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource;
            // 
            // sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource
            // 
            this.sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource.DataSource = this.sTUDIO2_Subscription_ManagerDataSetInvoice;
            this.sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource.Position = 0;
            // 
            // sTUDIO2_Subscription_ManagerDataSetInvoice
            // 
            this.sTUDIO2_Subscription_ManagerDataSetInvoice.DataSetName = "STUDIO2_Subscription_ManagerDataSetInvoice";
            this.sTUDIO2_Subscription_ManagerDataSetInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // grpUpdateInvoice
            // 
            this.grpUpdateInvoice.Controls.Add(this.btnUpdateInvoice);
            this.grpUpdateInvoice.Controls.Add(this.cboIStatus);
            this.grpUpdateInvoice.Controls.Add(this.label17);
            this.grpUpdateInvoice.Controls.Add(this.txtUpdateIssueDate);
            this.grpUpdateInvoice.Controls.Add(this.label16);
            this.grpUpdateInvoice.Controls.Add(this.txtUpdateSubscriptionID);
            this.grpUpdateInvoice.Controls.Add(this.label6);
            this.grpUpdateInvoice.Controls.Add(this.txtUpdateInvoiceID);
            this.grpUpdateInvoice.Controls.Add(this.label7);
            this.grpUpdateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateInvoice.Location = new System.Drawing.Point(12, 28);
            this.grpUpdateInvoice.Name = "grpUpdateInvoice";
            this.grpUpdateInvoice.Size = new System.Drawing.Size(718, 442);
            this.grpUpdateInvoice.TabIndex = 11;
            this.grpUpdateInvoice.TabStop = false;
            this.grpUpdateInvoice.Text = "UPDATE INVOICE";
            this.grpUpdateInvoice.Visible = false;
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInvoice.Location = new System.Drawing.Point(75, 130);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(106, 23);
            this.btnUpdateInvoice.TabIndex = 32;
            this.btnUpdateInvoice.Text = "Update Invoice";
            this.btnUpdateInvoice.UseVisualStyleBackColor = true;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // cboIStatus
            // 
            this.cboIStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboIStatus.FormattingEnabled = true;
            this.cboIStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Not Paid",
            "Canceled"});
            this.cboIStatus.Location = new System.Drawing.Point(142, 98);
            this.cboIStatus.Name = "cboIStatus";
            this.cboIStatus.Size = new System.Drawing.Size(114, 21);
            this.cboIStatus.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "IStatus:";
            // 
            // txtUpdateIssueDate
            // 
            this.txtUpdateIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUpdateIssueDate.Location = new System.Drawing.Point(170, 47);
            this.txtUpdateIssueDate.Name = "txtUpdateIssueDate";
            this.txtUpdateIssueDate.ReadOnly = true;
            this.txtUpdateIssueDate.Size = new System.Drawing.Size(86, 20);
            this.txtUpdateIssueDate.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Issue Date:";
            // 
            // txtUpdateSubscriptionID
            // 
            this.txtUpdateSubscriptionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUpdateSubscriptionID.Location = new System.Drawing.Point(170, 73);
            this.txtUpdateSubscriptionID.Name = "txtUpdateSubscriptionID";
            this.txtUpdateSubscriptionID.ReadOnly = true;
            this.txtUpdateSubscriptionID.Size = new System.Drawing.Size(86, 20);
            this.txtUpdateSubscriptionID.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Subscription ID:";
            // 
            // txtUpdateInvoiceID
            // 
            this.txtUpdateInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateInvoiceID.Location = new System.Drawing.Point(170, 21);
            this.txtUpdateInvoiceID.Name = "txtUpdateInvoiceID";
            this.txtUpdateInvoiceID.ReadOnly = true;
            this.txtUpdateInvoiceID.Size = new System.Drawing.Size(86, 20);
            this.txtUpdateInvoiceID.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Invoice ID:";
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.grpUpdateInvoice);
            this.Controls.Add(this.dgvSQLOutput);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.toolStripMainNav);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Invoices";
            this.Text = "STUDIO2 Subscription Manager | Invoices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Invoices_FormClosing);
            this.Load += new System.EventHandler(this.Invoices_Load);
            this.Resize += new System.EventHandler(this.Invoices_Resize);
            this.toolStripMainNav.ResumeLayout(false);
            this.toolStripMainNav.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2_Subscription_ManagerDataSetInvoice)).EndInit();
            this.grpUpdateInvoice.ResumeLayout(false);
            this.grpUpdateInvoice.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAllInvoices;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaid;
        private System.Windows.Forms.ToolStripButton toolStripButtonNotPaid;
        private System.Windows.Forms.ToolStripButton toolStripButtonPending;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchField;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSQLOutput;
        private System.Windows.Forms.BindingSource sTUDIO2SubscriptionManagerDataSetInvoiceBindingSource;
        private STUDIO2_Subscription_ManagerDataSetInvoice sTUDIO2_Subscription_ManagerDataSetInvoice;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private STUDIO2_Subscription_ManagerDataSetInvoiceTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateInvoice;
        private System.Windows.Forms.GroupBox grpUpdateInvoice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUpdateIssueDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUpdateSubscriptionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateInvoiceID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton toolStripButtonCanceled;
        private System.Windows.Forms.ComboBox cboIStatus;
        private System.Windows.Forms.Button btnUpdateInvoice;
    }
}