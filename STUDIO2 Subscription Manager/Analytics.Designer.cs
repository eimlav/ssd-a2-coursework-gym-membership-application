namespace STUDIO2_Subscription_Manager
{
    partial class Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STUDIO2_Subscription_ManagerDataSet = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSet();
            this.SubscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpSubscriptions = new System.Windows.Forms.GroupBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblConcessionaryOffPeak = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblConcessionary = new System.Windows.Forms.Label();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.lblIndividual = new System.Windows.Forms.Label();
            this.lblSubscriptionsCreated = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grpInvoices = new System.Windows.Forms.GroupBox();
            this.lblCanceledInvoices = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPaidInvoices = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPendingInvoices = new System.Windows.Forms.Label();
            this.lblNotPaidInvoices = new System.Windows.Forms.Label();
            this.lblTotalInvoices = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpAnalytics = new System.Windows.Forms.GroupBox();
            this.lblActiveMembers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblFemaleMembers = new System.Windows.Forms.Label();
            this.lblMaleMembers = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMainNav = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemFileConnectToDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAnalytics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSubscriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxReportSource = new System.Windows.Forms.ToolStripComboBox();
            //this.reportViewerMember = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MemberTableAdapter = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSetTableAdapters.MemberTableAdapter();
            //this.reportViewerSubscription = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SubscriptionTableAdapter = new STUDIO2_Subscription_Manager.STUDIO2_Subscription_ManagerDataSetTableAdapters.SubscriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDIO2_Subscription_ManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionBindingSource)).BeginInit();
            this.grpSubscriptions.SuspendLayout();
            this.grpInvoices.SuspendLayout();
            this.grpAnalytics.SuspendLayout();
            this.toolStripMainNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberBindingSource
            // 
            this.MemberBindingSource.DataMember = "Member";
            this.MemberBindingSource.DataSource = this.STUDIO2_Subscription_ManagerDataSet;
            // 
            // STUDIO2_Subscription_ManagerDataSet
            // 
            this.STUDIO2_Subscription_ManagerDataSet.DataSetName = "STUDIO2_Subscription_ManagerDataSet";
            this.STUDIO2_Subscription_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SubscriptionBindingSource
            // 
            this.SubscriptionBindingSource.DataMember = "Subscription";
            this.SubscriptionBindingSource.DataSource = this.STUDIO2_Subscription_ManagerDataSet;
            // 
            // grpSubscriptions
            // 
            this.grpSubscriptions.Controls.Add(this.lblStudent);
            this.grpSubscriptions.Controls.Add(this.lblConcessionaryOffPeak);
            this.grpSubscriptions.Controls.Add(this.label20);
            this.grpSubscriptions.Controls.Add(this.label12);
            this.grpSubscriptions.Controls.Add(this.lblActive);
            this.grpSubscriptions.Controls.Add(this.label8);
            this.grpSubscriptions.Controls.Add(this.lblConcessionary);
            this.grpSubscriptions.Controls.Add(this.lblOffPeak);
            this.grpSubscriptions.Controls.Add(this.lblIndividual);
            this.grpSubscriptions.Controls.Add(this.lblSubscriptionsCreated);
            this.grpSubscriptions.Controls.Add(this.label16);
            this.grpSubscriptions.Controls.Add(this.label17);
            this.grpSubscriptions.Controls.Add(this.label18);
            this.grpSubscriptions.Controls.Add(this.label19);
            this.grpSubscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSubscriptions.Location = new System.Drawing.Point(12, 264);
            this.grpSubscriptions.Name = "grpSubscriptions";
            this.grpSubscriptions.Size = new System.Drawing.Size(203, 146);
            this.grpSubscriptions.TabIndex = 7;
            this.grpSubscriptions.TabStop = false;
            this.grpSubscriptions.Text = "SUBSCRIPTIONS";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(166, 123);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 13);
            this.lblStudent.TabIndex = 13;
            // 
            // lblConcessionaryOffPeak
            // 
            this.lblConcessionaryOffPeak.AutoSize = true;
            this.lblConcessionaryOffPeak.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcessionaryOffPeak.Location = new System.Drawing.Point(166, 105);
            this.lblConcessionaryOffPeak.Name = "lblConcessionaryOffPeak";
            this.lblConcessionaryOffPeak.Size = new System.Drawing.Size(0, 13);
            this.lblConcessionaryOffPeak.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Student:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Concessionary Off Peak:";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(166, 34);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(0, 13);
            this.lblActive.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Active subscriptions:";
            // 
            // lblConcessionary
            // 
            this.lblConcessionary.AutoSize = true;
            this.lblConcessionary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcessionary.Location = new System.Drawing.Point(166, 88);
            this.lblConcessionary.Name = "lblConcessionary";
            this.lblConcessionary.Size = new System.Drawing.Size(0, 13);
            this.lblConcessionary.TabIndex = 7;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeak.Location = new System.Drawing.Point(166, 70);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(0, 13);
            this.lblOffPeak.TabIndex = 6;
            // 
            // lblIndividual
            // 
            this.lblIndividual.AutoSize = true;
            this.lblIndividual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndividual.Location = new System.Drawing.Point(166, 52);
            this.lblIndividual.Name = "lblIndividual";
            this.lblIndividual.Size = new System.Drawing.Size(0, 13);
            this.lblIndividual.TabIndex = 5;
            // 
            // lblSubscriptionsCreated
            // 
            this.lblSubscriptionsCreated.AutoSize = true;
            this.lblSubscriptionsCreated.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionsCreated.Location = new System.Drawing.Point(166, 18);
            this.lblSubscriptionsCreated.Name = "lblSubscriptionsCreated";
            this.lblSubscriptionsCreated.Size = new System.Drawing.Size(0, 13);
            this.lblSubscriptionsCreated.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Concessionary:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Off Peak:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Individual:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Subscriptions created:";
            // 
            // grpInvoices
            // 
            this.grpInvoices.Controls.Add(this.lblCanceledInvoices);
            this.grpInvoices.Controls.Add(this.label10);
            this.grpInvoices.Controls.Add(this.lblPaidInvoices);
            this.grpInvoices.Controls.Add(this.label7);
            this.grpInvoices.Controls.Add(this.lblPendingInvoices);
            this.grpInvoices.Controls.Add(this.lblNotPaidInvoices);
            this.grpInvoices.Controls.Add(this.lblTotalInvoices);
            this.grpInvoices.Controls.Add(this.label13);
            this.grpInvoices.Controls.Add(this.label14);
            this.grpInvoices.Controls.Add(this.label15);
            this.grpInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvoices.Location = new System.Drawing.Point(12, 143);
            this.grpInvoices.Name = "grpInvoices";
            this.grpInvoices.Size = new System.Drawing.Size(203, 113);
            this.grpInvoices.TabIndex = 6;
            this.grpInvoices.TabStop = false;
            this.grpInvoices.Text = "INVOICES";
            // 
            // lblCanceledInvoices
            // 
            this.lblCanceledInvoices.AutoSize = true;
            this.lblCanceledInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceledInvoices.Location = new System.Drawing.Point(166, 89);
            this.lblCanceledInvoices.Name = "lblCanceledInvoices";
            this.lblCanceledInvoices.Size = new System.Drawing.Size(0, 13);
            this.lblCanceledInvoices.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Canceled Invoices:";
            // 
            // lblPaidInvoices
            // 
            this.lblPaidInvoices.AutoSize = true;
            this.lblPaidInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidInvoices.Location = new System.Drawing.Point(166, 34);
            this.lblPaidInvoices.Name = "lblPaidInvoices";
            this.lblPaidInvoices.Size = new System.Drawing.Size(0, 13);
            this.lblPaidInvoices.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Paid invoices:";
            // 
            // lblPendingInvoices
            // 
            this.lblPendingInvoices.AutoSize = true;
            this.lblPendingInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingInvoices.Location = new System.Drawing.Point(166, 70);
            this.lblPendingInvoices.Name = "lblPendingInvoices";
            this.lblPendingInvoices.Size = new System.Drawing.Size(0, 13);
            this.lblPendingInvoices.TabIndex = 6;
            // 
            // lblNotPaidInvoices
            // 
            this.lblNotPaidInvoices.AutoSize = true;
            this.lblNotPaidInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotPaidInvoices.Location = new System.Drawing.Point(166, 52);
            this.lblNotPaidInvoices.Name = "lblNotPaidInvoices";
            this.lblNotPaidInvoices.Size = new System.Drawing.Size(0, 13);
            this.lblNotPaidInvoices.TabIndex = 5;
            // 
            // lblTotalInvoices
            // 
            this.lblTotalInvoices.AutoSize = true;
            this.lblTotalInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoices.Location = new System.Drawing.Point(166, 18);
            this.lblTotalInvoices.Name = "lblTotalInvoices";
            this.lblTotalInvoices.Size = new System.Drawing.Size(0, 13);
            this.lblTotalInvoices.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Pending invoices:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Not Paid invoices:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Total invoices:";
            // 
            // grpAnalytics
            // 
            this.grpAnalytics.Controls.Add(this.lblActiveMembers);
            this.grpAnalytics.Controls.Add(this.label5);
            this.grpAnalytics.Controls.Add(this.lblAverageAge);
            this.grpAnalytics.Controls.Add(this.lblFemaleMembers);
            this.grpAnalytics.Controls.Add(this.lblMaleMembers);
            this.grpAnalytics.Controls.Add(this.lblMembers);
            this.grpAnalytics.Controls.Add(this.label4);
            this.grpAnalytics.Controls.Add(this.label3);
            this.grpAnalytics.Controls.Add(this.label2);
            this.grpAnalytics.Controls.Add(this.label1);
            this.grpAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalytics.Location = new System.Drawing.Point(12, 28);
            this.grpAnalytics.Name = "grpAnalytics";
            this.grpAnalytics.Size = new System.Drawing.Size(203, 108);
            this.grpAnalytics.TabIndex = 5;
            this.grpAnalytics.TabStop = false;
            this.grpAnalytics.Text = "MEMBERS";
            // 
            // lblActiveMembers
            // 
            this.lblActiveMembers.AutoSize = true;
            this.lblActiveMembers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMembers.Location = new System.Drawing.Point(166, 34);
            this.lblActiveMembers.Name = "lblActiveMembers";
            this.lblActiveMembers.Size = new System.Drawing.Size(0, 13);
            this.lblActiveMembers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Active members:";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.Location = new System.Drawing.Point(166, 88);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(0, 13);
            this.lblAverageAge.TabIndex = 7;
            // 
            // lblFemaleMembers
            // 
            this.lblFemaleMembers.AutoSize = true;
            this.lblFemaleMembers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleMembers.Location = new System.Drawing.Point(166, 70);
            this.lblFemaleMembers.Name = "lblFemaleMembers";
            this.lblFemaleMembers.Size = new System.Drawing.Size(0, 13);
            this.lblFemaleMembers.TabIndex = 6;
            // 
            // lblMaleMembers
            // 
            this.lblMaleMembers.AutoSize = true;
            this.lblMaleMembers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaleMembers.Location = new System.Drawing.Point(166, 52);
            this.lblMaleMembers.Name = "lblMaleMembers";
            this.lblMaleMembers.Size = new System.Drawing.Size(0, 13);
            this.lblMaleMembers.TabIndex = 5;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.Location = new System.Drawing.Point(166, 18);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(0, 13);
            this.lblMembers.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Female members:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Male members:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members created:";
            // 
            // toolStripMainNav
            // 
            this.toolStripMainNav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMainNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonView,
            this.toolStripSeparator1,
            this.toolStripComboBoxReportSource});
            this.toolStripMainNav.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainNav.Name = "toolStripMainNav";
            this.toolStripMainNav.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMainNav.Size = new System.Drawing.Size(750, 25);
            this.toolStripMainNav.TabIndex = 8;
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileConnectToDatabase});
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
            // toolStripComboBoxReportSource
            // 
            this.toolStripComboBoxReportSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxReportSource.Items.AddRange(new object[] {
            "ReportMembers.rdlc",
            "ReportSubscriptions.rdlc"});
            this.toolStripComboBoxReportSource.Name = "toolStripComboBoxReportSource";
            this.toolStripComboBoxReportSource.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxReportSource.DropDownClosed += new System.EventHandler(this.toolStripComboBoxReportSource_DropDownClosed);
            // 
            // reportViewerMember
            // 
            //reportDataSource1.Name = "MemberDataset";
            //reportDataSource1.Value = this.MemberBindingSource;
            //this.reportViewerMember.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewerMember.LocalReport.DisplayName = "Member Report";
            //this.reportViewerMember.LocalReport.ReportEmbeddedResource = "STUDIO2_Subscription_Manager.ReportMembers.rdlc";
            //this.reportViewerMember.LocalReport.ReportPath = "";
            //this.reportViewerMember.Location = new System.Drawing.Point(221, 28);
            //this.reportViewerMember.Name = "reportViewerMember";
            //this.reportViewerMember.Size = new System.Drawing.Size(529, 447);
            //this.reportViewerMember.TabIndex = 9;
            // 
            // MemberTableAdapter
            // 
            this.MemberTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerSubscription
            // 
            //reportDataSource2.Name = "SubscriptionDataSet";
            //reportDataSource2.Value = this.SubscriptionBindingSource;
            //this.reportViewerSubscription.LocalReport.DataSources.Add(reportDataSource2);
            //this.reportViewerSubscription.LocalReport.ReportEmbeddedResource = "STUDIO2_Subscription_Manager.ReportSubscriptions.rdlc";
            //this.reportViewerSubscription.Location = new System.Drawing.Point(221, 28);
            //this.reportViewerSubscription.Name = "reportViewerSubscription";
            //this.reportViewerSubscription.Size = new System.Drawing.Size(529, 447);
            //this.reportViewerSubscription.TabIndex = 10;
            //this.reportViewerSubscription.Visible = false;
            // 
            // SubscriptionTableAdapter
            // 
            this.SubscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 484);
            //this.Controls.Add(this.reportViewerSubscription);
            //this.Controls.Add(this.reportViewerMember);
            this.Controls.Add(this.toolStripMainNav);
            this.Controls.Add(this.grpAnalytics);
            this.Controls.Add(this.grpInvoices);
            this.Controls.Add(this.grpSubscriptions);
            this.MinimumSize = new System.Drawing.Size(758, 511);
            this.Name = "Analytics";
            this.Text = "STUDIO2 Subscription Manager | Analytics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Analytics_FormClosing);
            this.Load += new System.EventHandler(this.Analytics_Load);
            this.Resize += new System.EventHandler(this.Analytics_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDIO2_Subscription_ManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionBindingSource)).EndInit();
            this.grpSubscriptions.ResumeLayout(false);
            this.grpSubscriptions.PerformLayout();
            this.grpInvoices.ResumeLayout(false);
            this.grpInvoices.PerformLayout();
            this.grpAnalytics.ResumeLayout(false);
            this.grpAnalytics.PerformLayout();
            this.toolStripMainNav.ResumeLayout(false);
            this.toolStripMainNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSubscriptions;
        private System.Windows.Forms.Label lblConcessionaryOffPeak;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblConcessionary;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.Label lblIndividual;
        private System.Windows.Forms.Label lblSubscriptionsCreated;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grpInvoices;
        private System.Windows.Forms.Label lblPaidInvoices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPendingInvoices;
        private System.Windows.Forms.Label lblNotPaidInvoices;
        private System.Windows.Forms.Label lblTotalInvoices;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpAnalytics;
        private System.Windows.Forms.Label lblActiveMembers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblFemaleMembers;
        private System.Windows.Forms.Label lblMaleMembers;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripMainNav;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileConnectToDatabase;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAnalytics;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMembers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInvoices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblStudent;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewerMember;
        private System.Windows.Forms.BindingSource MemberBindingSource;
        private STUDIO2_Subscription_ManagerDataSet STUDIO2_Subscription_ManagerDataSet;
        private STUDIO2_Subscription_ManagerDataSetTableAdapters.MemberTableAdapter MemberTableAdapter;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxReportSource;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewerSubscription;
        private System.Windows.Forms.BindingSource SubscriptionBindingSource;
        private STUDIO2_Subscription_ManagerDataSetTableAdapters.SubscriptionTableAdapter SubscriptionTableAdapter;
        private System.Windows.Forms.Label lblCanceledInvoices;
        private System.Windows.Forms.Label label10;
    }
}