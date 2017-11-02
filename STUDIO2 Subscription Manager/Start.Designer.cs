namespace STUDIO2_Subscription_Manager
{
    partial class Start
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
            this.toolStripMainNav = new System.Windows.Forms.ToolStrip();
            this.pboxStudio2 = new System.Windows.Forms.PictureBox();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStudio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            this.pnlConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMainNav
            // 
            this.toolStripMainNav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMainNav.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainNav.Name = "toolStripMainNav";
            this.toolStripMainNav.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMainNav.Size = new System.Drawing.Size(750, 25);
            this.toolStripMainNav.TabIndex = 5;
            // 
            // pboxStudio2
            // 
            this.pboxStudio2.Image = global::STUDIO2_Subscription_Manager.Properties.Resources.studio2_sub_logo;
            this.pboxStudio2.Location = new System.Drawing.Point(234, 175);
            this.pboxStudio2.Name = "pboxStudio2";
            this.pboxStudio2.Size = new System.Drawing.Size(274, 122);
            this.pboxStudio2.TabIndex = 6;
            this.pboxStudio2.TabStop = false;
            // 
            // pboxBackground
            // 
            this.pboxBackground.BackgroundImage = global::STUDIO2_Subscription_Manager.Properties.Resources.LA_Fitness;
            this.pboxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxBackground.Location = new System.Drawing.Point(0, 28);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(742, 444);
            this.pboxBackground.TabIndex = 7;
            this.pboxBackground.TabStop = false;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(7, 57);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(236, 20);
            this.txtServer.TabIndex = 8;
            this.txtServer.Text = "LOCALHOST";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(7, 97);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(236, 20);
            this.txtDatabase.TabIndex = 9;
            this.txtDatabase.Text = "STUDIO2 Subscription Manager";
            // 
            // pnlConnect
            // 
            this.pnlConnect.Controls.Add(this.btnConnect);
            this.pnlConnect.Controls.Add(this.label3);
            this.pnlConnect.Controls.Add(this.label2);
            this.pnlConnect.Controls.Add(this.label1);
            this.pnlConnect.Controls.Add(this.txtServer);
            this.pnlConnect.Controls.Add(this.txtDatabase);
            this.pnlConnect.Location = new System.Drawing.Point(246, 303);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(250, 157);
            this.pnlConnect.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(88, 124);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "CONNECT TO DATABASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "D A T A B A S E";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "S E R V E R";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 484);
            this.Controls.Add(this.pnlConnect);
            this.Controls.Add(this.pboxStudio2);
            this.Controls.Add(this.toolStripMainNav);
            this.Controls.Add(this.pboxBackground);
            this.MinimumSize = new System.Drawing.Size(758, 511);
            this.Name = "Start";
            this.Text = "STUDIO2 Subscription Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.Load += new System.EventHandler(this.Start_Load);
            this.Resize += new System.EventHandler(this.Start_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pboxStudio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            this.pnlConnect.ResumeLayout(false);
            this.pnlConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMainNav;
        private System.Windows.Forms.PictureBox pboxStudio2;
        private System.Windows.Forms.PictureBox pboxBackground;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

