namespace STUDIO2_Subscription_Manager
{
    partial class Subscriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subscriptions));
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
            this.toolStripButtonPlans = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCreateSubscription = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateSubscription = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewAllSubscriptions = new System.Windows.Forms.ToolStripButton();
            this.grpPlans = new System.Windows.Forms.GroupBox();
            this.pnlChangePrice = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.planIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDIO2_Subscription_ManagerDataSet = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreateMemberID = new System.Windows.Forms.TextBox();
            this.btnCreateSearchMemberID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCreatePlans = new System.Windows.Forms.ComboBox();
            this.btnCreateSubscription = new System.Windows.Forms.Button();
            this.grpCreateSubscription = new System.Windows.Forms.GroupBox();
            this.txtCreatePlanPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboCreateRecurring = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchField = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSQLOutput = new System.Windows.Forms.DataGridView();
            this.subscriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriptionStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceledDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpUpdateSubscription = new System.Windows.Forms.GroupBox();
            this.txtPeriodStartDate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSubscriptionID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancelSubscription = new System.Windows.Forms.Button();
            this.cboRecurring = new System.Windows.Forms.ComboBox();
            this.txtSStatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNextInvoice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPeriodEndDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubStartDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.btnUpdateSubscription = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateMemberID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.planTableAdapter = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSetTableAdapters.PlanTableAdapter();
            this.subscriptionTableAdapter = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSetTableAdapters.SubscriptionTableAdapter();
            this.toolStripMainNav.SuspendLayout();
            this.grpPlans.SuspendLayout();
            this.pnlChangePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2_Subscription_ManagerDataSet)).BeginInit();
            this.grpCreateSubscription.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).BeginInit();
            this.grpUpdateSubscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMainNav
            // 
            this.toolStripMainNav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMainNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonView,
            this.toolStripSeparator1,
            this.toolStripButtonPlans,
            this.toolStripButtonCreateSubscription,
            this.toolStripButtonUpdateSubscription,
            this.toolStripButtonViewAllSubscriptions});
            this.toolStripMainNav.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainNav.Name = "toolStripMainNav";
            this.toolStripMainNav.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMainNav.Size = new System.Drawing.Size(750, 25);
            this.toolStripMainNav.TabIndex = 6;
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
            // toolStripButtonPlans
            // 
            this.toolStripButtonPlans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPlans.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlans.Image")));
            this.toolStripButtonPlans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlans.Name = "toolStripButtonPlans";
            this.toolStripButtonPlans.Size = new System.Drawing.Size(36, 22);
            this.toolStripButtonPlans.Text = "Plans";
            this.toolStripButtonPlans.Click += new System.EventHandler(this.toolStripButtonPlans_Click);
            // 
            // toolStripButtonCreateSubscription
            // 
            this.toolStripButtonCreateSubscription.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCreateSubscription.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateSubscription.Image")));
            this.toolStripButtonCreateSubscription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateSubscription.Name = "toolStripButtonCreateSubscription";
            this.toolStripButtonCreateSubscription.Size = new System.Drawing.Size(105, 22);
            this.toolStripButtonCreateSubscription.Text = "Create Subscription";
            this.toolStripButtonCreateSubscription.Click += new System.EventHandler(this.toolStripButtonCreateSubscription_Click);
            // 
            // toolStripButtonUpdateSubscription
            // 
            this.toolStripButtonUpdateSubscription.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateSubscription.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateSubscription.Image")));
            this.toolStripButtonUpdateSubscription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateSubscription.Name = "toolStripButtonUpdateSubscription";
            this.toolStripButtonUpdateSubscription.Size = new System.Drawing.Size(107, 22);
            this.toolStripButtonUpdateSubscription.Text = "Update Subscription";
            this.toolStripButtonUpdateSubscription.Click += new System.EventHandler(this.toolStripButtonUpdateSubscription_Click);
            // 
            // toolStripButtonViewAllSubscriptions
            // 
            this.toolStripButtonViewAllSubscriptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonViewAllSubscriptions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewAllSubscriptions.Image")));
            this.toolStripButtonViewAllSubscriptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewAllSubscriptions.Name = "toolStripButtonViewAllSubscriptions";
            this.toolStripButtonViewAllSubscriptions.Size = new System.Drawing.Size(113, 22);
            this.toolStripButtonViewAllSubscriptions.Text = "View All Subscriptions";
            this.toolStripButtonViewAllSubscriptions.Click += new System.EventHandler(this.toolStripButtonViewAllSubscriptions_Click);
            // 
            // grpPlans
            // 
            this.grpPlans.Controls.Add(this.pnlChangePrice);
            this.grpPlans.Controls.Add(this.dgvPlans);
            this.grpPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlans.Location = new System.Drawing.Point(13, 29);
            this.grpPlans.Name = "grpPlans";
            this.grpPlans.Size = new System.Drawing.Size(717, 440);
            this.grpPlans.TabIndex = 7;
            this.grpPlans.TabStop = false;
            this.grpPlans.Text = "PLANS";
            this.grpPlans.Visible = false;
            // 
            // pnlChangePrice
            // 
            this.pnlChangePrice.Controls.Add(this.label1);
            this.pnlChangePrice.Controls.Add(this.label9);
            this.pnlChangePrice.Controls.Add(this.cboPlan);
            this.pnlChangePrice.Controls.Add(this.label10);
            this.pnlChangePrice.Controls.Add(this.txtCurrentPrice);
            this.pnlChangePrice.Controls.Add(this.txtNewPrice);
            this.pnlChangePrice.Controls.Add(this.label2);
            this.pnlChangePrice.Controls.Add(this.label8);
            this.pnlChangePrice.Controls.Add(this.label3);
            this.pnlChangePrice.Controls.Add(this.btnChangePrice);
            this.pnlChangePrice.Location = new System.Drawing.Point(7, 359);
            this.pnlChangePrice.Name = "pnlChangePrice";
            this.pnlChangePrice.Size = new System.Drawing.Size(706, 75);
            this.pnlChangePrice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "£";
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "individual-monthly-twelve-month",
            "individual-single-twelve-month",
            "individual-monthly-six-month",
            "individual-single-six-month",
            "off-peak-monthly-twelve-month",
            "off-peak-single-twelve-month",
            "off-peak-monthly-six-month",
            "off-peak-single-six-month",
            "concessionary-monthly-twelve-month",
            "concessionary-single-twelve-month",
            "concessionary-monthly-six-month",
            "concessionary-single-six-month",
            "concessionary-off-peak-monthly-twelve-month",
            "concessionary-off-peak-single-twelve-month",
            "concessionary-off-peak-monthly-twelve-month",
            "concessionary-off-peak-single-twelve-month",
            "student-monthly-twelve-month",
            "student-single-twelve-month",
            "student-monthly-six-month",
            "student-single-six-month"});
            this.cboPlan.Location = new System.Drawing.Point(6, 46);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(195, 21);
            this.cboPlan.TabIndex = 2;
            this.cboPlan.TextChanged += new System.EventHandler(this.cboPlan_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "New Price";
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPrice.Location = new System.Drawing.Point(221, 46);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.ReadOnly = true;
            this.txtCurrentPrice.Size = new System.Drawing.Size(89, 20);
            this.txtCurrentPrice.TabIndex = 3;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(332, 46);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(89, 20);
            this.txtNewPrice.TabIndex = 8;
            this.txtNewPrice.TextChanged += new System.EventHandler(this.txtNewPrice_TextChanged);
            this.txtNewPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "£";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Price";
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePrice.Location = new System.Drawing.Point(429, 43);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(90, 23);
            this.btnChangePrice.TabIndex = 6;
            this.btnChangePrice.Text = "Save Changes";
            this.btnChangePrice.UseVisualStyleBackColor = true;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // dgvPlans
            // 
            this.dgvPlans.AutoGenerateColumns = false;
            this.dgvPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.monthsDataGridViewTextBoxColumn,
            this.intervalDataGridViewTextBoxColumn});
            this.dgvPlans.DataSource = this.planBindingSource;
            this.dgvPlans.Location = new System.Drawing.Point(7, 20);
            this.dgvPlans.Name = "dgvPlans";
            this.dgvPlans.ReadOnly = true;
            this.dgvPlans.Size = new System.Drawing.Size(704, 333);
            this.dgvPlans.TabIndex = 0;
            // 
            // planIDDataGridViewTextBoxColumn
            // 
            this.planIDDataGridViewTextBoxColumn.DataPropertyName = "PlanID";
            this.planIDDataGridViewTextBoxColumn.HeaderText = "PlanID";
            this.planIDDataGridViewTextBoxColumn.Name = "planIDDataGridViewTextBoxColumn";
            this.planIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthsDataGridViewTextBoxColumn
            // 
            this.monthsDataGridViewTextBoxColumn.DataPropertyName = "Months";
            this.monthsDataGridViewTextBoxColumn.HeaderText = "Months";
            this.monthsDataGridViewTextBoxColumn.Name = "monthsDataGridViewTextBoxColumn";
            this.monthsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intervalDataGridViewTextBoxColumn
            // 
            this.intervalDataGridViewTextBoxColumn.DataPropertyName = "Interval";
            this.intervalDataGridViewTextBoxColumn.HeaderText = "Interval";
            this.intervalDataGridViewTextBoxColumn.Name = "intervalDataGridViewTextBoxColumn";
            this.intervalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planBindingSource
            // 
            this.planBindingSource.DataMember = "Plan";
            this.planBindingSource.DataSource = this.sTUDIO2_Subscription_ManagerDataSet;
            // 
            // sTUDIO2_Subscription_ManagerDataSet
            // 
            this.sTUDIO2_Subscription_ManagerDataSet.DataSetName = "STUDIO2_Subscription_ManagerDataSet";
            this.sTUDIO2_Subscription_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Member ID:";
            // 
            // txtCreateMemberID
            // 
            this.txtCreateMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateMemberID.Location = new System.Drawing.Point(163, 19);
            this.txtCreateMemberID.Name = "txtCreateMemberID";
            this.txtCreateMemberID.ReadOnly = true;
            this.txtCreateMemberID.Size = new System.Drawing.Size(59, 20);
            this.txtCreateMemberID.TabIndex = 1;
            // 
            // btnCreateSearchMemberID
            // 
            this.btnCreateSearchMemberID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSearchMemberID.Location = new System.Drawing.Point(228, 17);
            this.btnCreateSearchMemberID.Name = "btnCreateSearchMemberID";
            this.btnCreateSearchMemberID.Size = new System.Drawing.Size(48, 23);
            this.btnCreateSearchMemberID.TabIndex = 2;
            this.btnCreateSearchMemberID.Tag = "1";
            this.btnCreateSearchMemberID.Text = "Search";
            this.btnCreateSearchMemberID.UseVisualStyleBackColor = true;
            this.btnCreateSearchMemberID.Click += new System.EventHandler(this.btnSearchMemberID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Plan Name:";
            // 
            // cboCreatePlans
            // 
            this.cboCreatePlans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCreatePlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCreatePlans.FormattingEnabled = true;
            this.cboCreatePlans.Items.AddRange(new object[] {
            "individual-monthly-twelve-month",
            "individual-single-twelve-month",
            "individual-monthly-six-month",
            "individual-single-six-month",
            "off-peak-monthly-twelve-month",
            "off-peak-single-twelve-month",
            "off-peak-monthly-six-month",
            "off-peak-single-six-month",
            "concessionary-monthly-twelve-month",
            "concessionary-single-twelve-month",
            "concessionary-monthly-six-month",
            "concessionary-single-six-month",
            "concessionary-off-peak-monthly-twelve-month",
            "concessionary-off-peak-single-twelve-month",
            "concessionary-off-peak-monthly-twelve-month",
            "concessionary-off-peak-single-twelve-month",
            "student-monthly-twelve-month",
            "student-single-twelve-month",
            "student-monthly-six-month",
            "student-single-six-month"});
            this.cboCreatePlans.Location = new System.Drawing.Point(93, 47);
            this.cboCreatePlans.Name = "cboCreatePlans";
            this.cboCreatePlans.Size = new System.Drawing.Size(181, 21);
            this.cboCreatePlans.TabIndex = 4;
            this.cboCreatePlans.TextChanged += new System.EventHandler(this.cboCreatePlans_TextChanged);
            // 
            // btnCreateSubscription
            // 
            this.btnCreateSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubscription.Location = new System.Drawing.Point(13, 126);
            this.btnCreateSubscription.Name = "btnCreateSubscription";
            this.btnCreateSubscription.Size = new System.Drawing.Size(150, 23);
            this.btnCreateSubscription.TabIndex = 5;
            this.btnCreateSubscription.Text = "Create Subscription";
            this.btnCreateSubscription.UseVisualStyleBackColor = true;
            this.btnCreateSubscription.Click += new System.EventHandler(this.btnCreateSubscription_Click);
            // 
            // grpCreateSubscription
            // 
            this.grpCreateSubscription.Controls.Add(this.txtCreatePlanPrice);
            this.grpCreateSubscription.Controls.Add(this.label20);
            this.grpCreateSubscription.Controls.Add(this.cboCreateRecurring);
            this.grpCreateSubscription.Controls.Add(this.label19);
            this.grpCreateSubscription.Controls.Add(this.btnCreateSubscription);
            this.grpCreateSubscription.Controls.Add(this.cboCreatePlans);
            this.grpCreateSubscription.Controls.Add(this.label5);
            this.grpCreateSubscription.Controls.Add(this.btnCreateSearchMemberID);
            this.grpCreateSubscription.Controls.Add(this.txtCreateMemberID);
            this.grpCreateSubscription.Controls.Add(this.label4);
            this.grpCreateSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreateSubscription.Location = new System.Drawing.Point(13, 29);
            this.grpCreateSubscription.Name = "grpCreateSubscription";
            this.grpCreateSubscription.Size = new System.Drawing.Size(717, 440);
            this.grpCreateSubscription.TabIndex = 8;
            this.grpCreateSubscription.TabStop = false;
            this.grpCreateSubscription.Text = "CREATE SUBSCRIPTION";
            this.grpCreateSubscription.Visible = false;
            // 
            // txtCreatePlanPrice
            // 
            this.txtCreatePlanPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePlanPrice.Location = new System.Drawing.Point(215, 74);
            this.txtCreatePlanPrice.Name = "txtCreatePlanPrice";
            this.txtCreatePlanPrice.ReadOnly = true;
            this.txtCreatePlanPrice.Size = new System.Drawing.Size(59, 20);
            this.txtCreatePlanPrice.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "Payment Due:";
            // 
            // cboCreateRecurring
            // 
            this.cboCreateRecurring.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCreateRecurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCreateRecurring.FormattingEnabled = true;
            this.cboCreateRecurring.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboCreateRecurring.Location = new System.Drawing.Point(192, 100);
            this.cboCreateRecurring.Name = "cboCreateRecurring";
            this.cboCreateRecurring.Size = new System.Drawing.Size(82, 21);
            this.cboCreateRecurring.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "Recurring:";
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
            this.grpSearch.TabIndex = 10;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "SEARCH";
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(355, 23);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(0, 13);
            this.lblSearchResults.TabIndex = 8;
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
            "SubscriptionID",
            "MemberID",
            "PlanID",
            "Recurring",
            "SubscriptionStartDate",
            "PeriodStartDate",
            "PeriodEndDate",
            "CanceledDate",
            "NextInvoice",
            "SStatus"});
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
            this.dgvSQLOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSQLOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriptionIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.planIDDataGridViewTextBoxColumn1,
            this.recurringDataGridViewTextBoxColumn,
            this.SubscriptionStartDate,
            this.PeriodStartDate,
            this.PeriodEndDate,
            this.canceledDateDataGridViewTextBoxColumn,
            this.nextInvoiceDataGridViewTextBoxColumn,
            this.sStatusDataGridViewTextBoxColumn});
            this.dgvSQLOutput.DataSource = this.subscriptionBindingSource;
            this.dgvSQLOutput.Location = new System.Drawing.Point(13, 92);
            this.dgvSQLOutput.Name = "dgvSQLOutput";
            this.dgvSQLOutput.ReadOnly = true;
            this.dgvSQLOutput.Size = new System.Drawing.Size(717, 379);
            this.dgvSQLOutput.TabIndex = 9;
            // 
            // subscriptionIDDataGridViewTextBoxColumn
            // 
            this.subscriptionIDDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionID";
            this.subscriptionIDDataGridViewTextBoxColumn.HeaderText = "SubscriptionID";
            this.subscriptionIDDataGridViewTextBoxColumn.Name = "subscriptionIDDataGridViewTextBoxColumn";
            this.subscriptionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planIDDataGridViewTextBoxColumn1
            // 
            this.planIDDataGridViewTextBoxColumn1.DataPropertyName = "PlanID";
            this.planIDDataGridViewTextBoxColumn1.HeaderText = "PlanID";
            this.planIDDataGridViewTextBoxColumn1.Name = "planIDDataGridViewTextBoxColumn1";
            this.planIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // recurringDataGridViewTextBoxColumn
            // 
            this.recurringDataGridViewTextBoxColumn.DataPropertyName = "Recurring";
            this.recurringDataGridViewTextBoxColumn.HeaderText = "Recurring";
            this.recurringDataGridViewTextBoxColumn.Name = "recurringDataGridViewTextBoxColumn";
            this.recurringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SubscriptionStartDate
            // 
            this.SubscriptionStartDate.DataPropertyName = "SubscriptionStartDate";
            this.SubscriptionStartDate.HeaderText = "SubscriptionStartDate";
            this.SubscriptionStartDate.Name = "SubscriptionStartDate";
            this.SubscriptionStartDate.ReadOnly = true;
            // 
            // PeriodStartDate
            // 
            this.PeriodStartDate.DataPropertyName = "PeriodStartDate";
            this.PeriodStartDate.HeaderText = "PeriodStartDate";
            this.PeriodStartDate.Name = "PeriodStartDate";
            this.PeriodStartDate.ReadOnly = true;
            // 
            // PeriodEndDate
            // 
            this.PeriodEndDate.DataPropertyName = "PeriodEndDate";
            this.PeriodEndDate.HeaderText = "PeriodEndDate";
            this.PeriodEndDate.Name = "PeriodEndDate";
            this.PeriodEndDate.ReadOnly = true;
            // 
            // canceledDateDataGridViewTextBoxColumn
            // 
            this.canceledDateDataGridViewTextBoxColumn.DataPropertyName = "CanceledDate";
            this.canceledDateDataGridViewTextBoxColumn.HeaderText = "CanceledDate";
            this.canceledDateDataGridViewTextBoxColumn.Name = "canceledDateDataGridViewTextBoxColumn";
            this.canceledDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextInvoiceDataGridViewTextBoxColumn
            // 
            this.nextInvoiceDataGridViewTextBoxColumn.DataPropertyName = "NextInvoice";
            this.nextInvoiceDataGridViewTextBoxColumn.HeaderText = "NextInvoice";
            this.nextInvoiceDataGridViewTextBoxColumn.Name = "nextInvoiceDataGridViewTextBoxColumn";
            this.nextInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sStatusDataGridViewTextBoxColumn
            // 
            this.sStatusDataGridViewTextBoxColumn.DataPropertyName = "SStatus";
            this.sStatusDataGridViewTextBoxColumn.HeaderText = "SStatus";
            this.sStatusDataGridViewTextBoxColumn.Name = "sStatusDataGridViewTextBoxColumn";
            this.sStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscriptionBindingSource
            // 
            this.subscriptionBindingSource.DataMember = "Subscription";
            this.subscriptionBindingSource.DataSource = this.sTUDIO2_Subscription_ManagerDataSet;
            // 
            // grpUpdateSubscription
            // 
            this.grpUpdateSubscription.Controls.Add(this.txtPeriodStartDate);
            this.grpUpdateSubscription.Controls.Add(this.label18);
            this.grpUpdateSubscription.Controls.Add(this.txtPlanName);
            this.grpUpdateSubscription.Controls.Add(this.label17);
            this.grpUpdateSubscription.Controls.Add(this.txtSubscriptionID);
            this.grpUpdateSubscription.Controls.Add(this.label16);
            this.grpUpdateSubscription.Controls.Add(this.btnCancelSubscription);
            this.grpUpdateSubscription.Controls.Add(this.cboRecurring);
            this.grpUpdateSubscription.Controls.Add(this.txtSStatus);
            this.grpUpdateSubscription.Controls.Add(this.label15);
            this.grpUpdateSubscription.Controls.Add(this.txtNextInvoice);
            this.grpUpdateSubscription.Controls.Add(this.label14);
            this.grpUpdateSubscription.Controls.Add(this.txtPeriodEndDate);
            this.grpUpdateSubscription.Controls.Add(this.label13);
            this.grpUpdateSubscription.Controls.Add(this.txtSubStartDate);
            this.grpUpdateSubscription.Controls.Add(this.label12);
            this.grpUpdateSubscription.Controls.Add(this.label11);
            this.grpUpdateSubscription.Controls.Add(this.txtPlanID);
            this.grpUpdateSubscription.Controls.Add(this.btnUpdateSubscription);
            this.grpUpdateSubscription.Controls.Add(this.label6);
            this.grpUpdateSubscription.Controls.Add(this.txtUpdateMemberID);
            this.grpUpdateSubscription.Controls.Add(this.label7);
            this.grpUpdateSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateSubscription.Location = new System.Drawing.Point(13, 29);
            this.grpUpdateSubscription.Name = "grpUpdateSubscription";
            this.grpUpdateSubscription.Size = new System.Drawing.Size(717, 440);
            this.grpUpdateSubscription.TabIndex = 11;
            this.grpUpdateSubscription.TabStop = false;
            this.grpUpdateSubscription.Text = "UPDATE SUBSCRIPTION";
            this.grpUpdateSubscription.Visible = false;
            // 
            // txtPeriodStartDate
            // 
            this.txtPeriodStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPeriodStartDate.Location = new System.Drawing.Point(159, 176);
            this.txtPeriodStartDate.Name = "txtPeriodStartDate";
            this.txtPeriodStartDate.ReadOnly = true;
            this.txtPeriodStartDate.Size = new System.Drawing.Size(96, 20);
            this.txtPeriodStartDate.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "Period Start Date:";
            // 
            // txtPlanName
            // 
            this.txtPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPlanName.Location = new System.Drawing.Point(93, 98);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.ReadOnly = true;
            this.txtPlanName.Size = new System.Drawing.Size(162, 20);
            this.txtPlanName.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "Plan Name:";
            // 
            // txtSubscriptionID
            // 
            this.txtSubscriptionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSubscriptionID.Location = new System.Drawing.Point(169, 46);
            this.txtSubscriptionID.Name = "txtSubscriptionID";
            this.txtSubscriptionID.ReadOnly = true;
            this.txtSubscriptionID.Size = new System.Drawing.Size(86, 20);
            this.txtSubscriptionID.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Sub ID:";
            // 
            // btnCancelSubscription
            // 
            this.btnCancelSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSubscription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelSubscription.Location = new System.Drawing.Point(57, 288);
            this.btnCancelSubscription.Name = "btnCancelSubscription";
            this.btnCancelSubscription.Size = new System.Drawing.Size(150, 23);
            this.btnCancelSubscription.TabIndex = 19;
            this.btnCancelSubscription.Tag = "Cancel";
            this.btnCancelSubscription.Text = "Cancel Subscription";
            this.btnCancelSubscription.UseVisualStyleBackColor = true;
            this.btnCancelSubscription.Click += new System.EventHandler(this.UpdateSubscription_Click);
            // 
            // cboRecurring
            // 
            this.cboRecurring.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboRecurring.FormattingEnabled = true;
            this.cboRecurring.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboRecurring.Location = new System.Drawing.Point(169, 124);
            this.cboRecurring.Name = "cboRecurring";
            this.cboRecurring.Size = new System.Drawing.Size(86, 21);
            this.cboRecurring.TabIndex = 18;
            this.cboRecurring.TextChanged += new System.EventHandler(this.cboRecurring_TextChanged);
            // 
            // txtSStatus
            // 
            this.txtSStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSStatus.Location = new System.Drawing.Point(159, 254);
            this.txtSStatus.Name = "txtSStatus";
            this.txtSStatus.ReadOnly = true;
            this.txtSStatus.Size = new System.Drawing.Size(96, 20);
            this.txtSStatus.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Status:";
            // 
            // txtNextInvoice
            // 
            this.txtNextInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNextInvoice.Location = new System.Drawing.Point(159, 228);
            this.txtNextInvoice.Name = "txtNextInvoice";
            this.txtNextInvoice.ReadOnly = true;
            this.txtNextInvoice.Size = new System.Drawing.Size(96, 20);
            this.txtNextInvoice.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Next Invoice:";
            // 
            // txtPeriodEndDate
            // 
            this.txtPeriodEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPeriodEndDate.Location = new System.Drawing.Point(159, 202);
            this.txtPeriodEndDate.Name = "txtPeriodEndDate";
            this.txtPeriodEndDate.ReadOnly = true;
            this.txtPeriodEndDate.Size = new System.Drawing.Size(96, 20);
            this.txtPeriodEndDate.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Period End Date:";
            // 
            // txtSubStartDate
            // 
            this.txtSubStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSubStartDate.Location = new System.Drawing.Point(159, 150);
            this.txtSubStartDate.Name = "txtSubStartDate";
            this.txtSubStartDate.ReadOnly = true;
            this.txtSubStartDate.Size = new System.Drawing.Size(96, 20);
            this.txtSubStartDate.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sub Start Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Recurring:";
            // 
            // txtPlanID
            // 
            this.txtPlanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPlanID.Location = new System.Drawing.Point(169, 72);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.ReadOnly = true;
            this.txtPlanID.Size = new System.Drawing.Size(86, 20);
            this.txtPlanID.TabIndex = 7;
            // 
            // btnUpdateSubscription
            // 
            this.btnUpdateSubscription.Enabled = false;
            this.btnUpdateSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSubscription.Location = new System.Drawing.Point(57, 317);
            this.btnUpdateSubscription.Name = "btnUpdateSubscription";
            this.btnUpdateSubscription.Size = new System.Drawing.Size(150, 23);
            this.btnUpdateSubscription.TabIndex = 5;
            this.btnUpdateSubscription.Tag = "Update";
            this.btnUpdateSubscription.Text = "Update Subscription";
            this.btnUpdateSubscription.UseVisualStyleBackColor = true;
            this.btnUpdateSubscription.Click += new System.EventHandler(this.UpdateSubscription_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Plan ID:";
            // 
            // txtUpdateMemberID
            // 
            this.txtUpdateMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateMemberID.Location = new System.Drawing.Point(169, 20);
            this.txtUpdateMemberID.Name = "txtUpdateMemberID";
            this.txtUpdateMemberID.ReadOnly = true;
            this.txtUpdateMemberID.Size = new System.Drawing.Size(86, 20);
            this.txtUpdateMemberID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Member ID:";
            // 
            // planTableAdapter
            // 
            this.planTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionTableAdapter
            // 
            this.subscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // Subscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 484);
            this.Controls.Add(this.grpCreateSubscription);
            this.Controls.Add(this.grpPlans);
            this.Controls.Add(this.grpUpdateSubscription);
            this.Controls.Add(this.toolStripMainNav);
            this.Controls.Add(this.dgvSQLOutput);
            this.Controls.Add(this.grpSearch);
            this.MinimumSize = new System.Drawing.Size(758, 511);
            this.Name = "Subscriptions";
            this.Text = "STUDIO2 Subscription Manager | Subscriptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subscriptions_FormClosing);
            this.Load += new System.EventHandler(this.Subscriptions_Load);
            this.Resize += new System.EventHandler(this.Subscriptions_Resize);
            this.toolStripMainNav.ResumeLayout(false);
            this.toolStripMainNav.PerformLayout();
            this.grpPlans.ResumeLayout(false);
            this.pnlChangePrice.ResumeLayout(false);
            this.pnlChangePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDIO2_Subscription_ManagerDataSet)).EndInit();
            this.grpCreateSubscription.ResumeLayout(false);
            this.grpCreateSubscription.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).EndInit();
            this.grpUpdateSubscription.ResumeLayout(false);
            this.grpUpdateSubscription.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonPlans;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateSubscription;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateSubscription;
        private System.Windows.Forms.GroupBox grpPlans;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewAllSubscriptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreateMemberID;
        private System.Windows.Forms.Button btnCreateSearchMemberID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCreatePlans;
        private System.Windows.Forms.Button btnCreateSubscription;
        private System.Windows.Forms.GroupBox grpCreateSubscription;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchField;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSQLOutput;
        private System.Windows.Forms.GroupBox grpUpdateSubscription;
        private System.Windows.Forms.Button btnUpdateSubscription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateMemberID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewPrice;
        private STUDIO2_Subscription_ManagerDataSet sTUDIO2_Subscription_ManagerDataSet;
        private System.Windows.Forms.BindingSource planBindingSource;
        private STUDIO2_Subscription_ManagerDataSetTableAdapters.PlanTableAdapter planTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subscriptionBindingSource;
        private STUDIO2_Subscription_ManagerDataSetTableAdapters.SubscriptionTableAdapter subscriptionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelSubscription;
        private System.Windows.Forms.ComboBox cboRecurring;
        private System.Windows.Forms.TextBox txtSStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNextInvoice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPeriodEndDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSubStartDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.TextBox txtSubscriptionID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlChangePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn canceledDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPeriodStartDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboCreateRecurring;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCreatePlanPrice;
        private System.Windows.Forms.Label label20;
    }
}