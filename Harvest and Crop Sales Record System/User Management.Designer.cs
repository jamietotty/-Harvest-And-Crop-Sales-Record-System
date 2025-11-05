namespace Harvest_and_Crop_Sales_Record_System
{
    partial class User_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            this.datagrid_Accounts = new System.Windows.Forms.DataGridView();
            this.hCSRSdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCSRSdbDataSet = new Harvest_and_Crop_Sales_Record_System.HCSRSdbDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salesrecords = new System.Windows.Forms.Label();
            this.harvestrecords = new System.Windows.Forms.Label();
            this.usermanagement = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nav_bar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_Accounts
            // 
            this.datagrid_Accounts.AutoGenerateColumns = false;
            this.datagrid_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Accounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_Accounts.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Accounts.DataSource = this.hCSRSdbDataSetBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Accounts.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Accounts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagrid_Accounts.Location = new System.Drawing.Point(396, 210);
            this.datagrid_Accounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid_Accounts.MultiSelect = false;
            this.datagrid_Accounts.Name = "datagrid_Accounts";
            this.datagrid_Accounts.ReadOnly = true;
            this.datagrid_Accounts.RowHeadersWidth = 51;
            this.datagrid_Accounts.RowTemplate.Height = 24;
            this.datagrid_Accounts.RowTemplate.ReadOnly = true;
            this.datagrid_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Accounts.Size = new System.Drawing.Size(1449, 677);
            this.datagrid_Accounts.TabIndex = 94;
            this.datagrid_Accounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Accounts_CellContentClick_1);
            // 
            // hCSRSdbDataSetBindingSource
            // 
            this.hCSRSdbDataSetBindingSource.DataSource = this.hCSRSdbDataSet;
            this.hCSRSdbDataSetBindingSource.Position = 0;
            // 
            // hCSRSdbDataSet
            // 
            this.hCSRSdbDataSet.DataSetName = "HCSRSdbDataSet";
            this.hCSRSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.salesrecords);
            this.panel1.Controls.Add(this.harvestrecords);
            this.panel1.Controls.Add(this.usermanagement);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1042);
            this.panel1.TabIndex = 96;
            // 
            // salesrecords
            // 
            this.salesrecords.AutoSize = true;
            this.salesrecords.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesrecords.ForeColor = System.Drawing.Color.DarkGreen;
            this.salesrecords.Location = new System.Drawing.Point(23, 430);
            this.salesrecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesrecords.Name = "salesrecords";
            this.salesrecords.Size = new System.Drawing.Size(166, 22);
            this.salesrecords.TabIndex = 4;
            this.salesrecords.Text = "SALES RECORDS";
            this.salesrecords.Click += new System.EventHandler(this.salesrecords_Click);
            // 
            // harvestrecords
            // 
            this.harvestrecords.AutoSize = true;
            this.harvestrecords.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harvestrecords.ForeColor = System.Drawing.Color.DarkGreen;
            this.harvestrecords.Location = new System.Drawing.Point(20, 350);
            this.harvestrecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harvestrecords.Name = "harvestrecords";
            this.harvestrecords.Size = new System.Drawing.Size(204, 22);
            this.harvestrecords.TabIndex = 3;
            this.harvestrecords.Text = "HARVEST RECORDS";
            this.harvestrecords.Click += new System.EventHandler(this.harvestrecords_Click);
            // 
            // usermanagement
            // 
            this.usermanagement.AutoSize = true;
            this.usermanagement.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.usermanagement.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usermanagement.ForeColor = System.Drawing.Color.Ivory;
            this.usermanagement.Location = new System.Drawing.Point(20, 270);
            this.usermanagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usermanagement.Name = "usermanagement";
            this.usermanagement.Size = new System.Drawing.Size(210, 22);
            this.usermanagement.TabIndex = 2;
            this.usermanagement.Text = "USER MANAGEMENT";
            this.usermanagement.Click += new System.EventHandler(this.usermanagement_Click);
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.dashboard.Location = new System.Drawing.Point(23, 186);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(137, 22);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(85, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nav_bar
            // 
            this.nav_bar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.nav_bar.Controls.Add(this.panel2);
            this.nav_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_bar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nav_bar.Location = new System.Drawing.Point(0, 0);
            this.nav_bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav_bar.Name = "nav_bar";
            this.nav_bar.Size = new System.Drawing.Size(1924, 94);
            this.nav_bar.TabIndex = 95;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblUserInfo);
            this.panel2.Controls.Add(this.picUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1571, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 94);
            this.panel2.TabIndex = 23;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUserInfo.Location = new System.Drawing.Point(75, 31);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(88, 23);
            this.lblUserInfo.TabIndex = 9;
            this.lblUserInfo.Text = "hahaha";
            this.lblUserInfo.Click += new System.EventHandler(this.lblUserInfo_Click);
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(17, 21);
            this.picUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(49, 41);
            this.picUser.TabIndex = 9;
            this.picUser.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 28);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.PaleGreen;
            this.addUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.Color.DarkGreen;
            this.addUser.Location = new System.Drawing.Point(1544, 130);
            this.addUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(301, 53);
            this.addUser.TabIndex = 117;
            this.addUser.Text = "+  Add New";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Location = new System.Drawing.Point(3, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 52);
            this.panel3.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(328, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 118;
            this.label1.Text = "USER MANAGEMENT";
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1924, 846);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nav_bar);
            this.Controls.Add(this.datagrid_Accounts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_Management";
            this.Text = "User_Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav_bar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagrid_Accounts;
        private System.Windows.Forms.BindingSource hCSRSdbDataSetBindingSource;
        private HCSRSdbDataSet hCSRSdbDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label salesrecords;
        private System.Windows.Forms.Label harvestrecords;
        private System.Windows.Forms.Label usermanagement;
        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel nav_bar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}