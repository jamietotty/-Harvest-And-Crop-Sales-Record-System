namespace Harvest_and_Crop_Sales_Record_System
{
    partial class Staff_Harvest_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Harvest_Management));
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_Harvestr = new System.Windows.Forms.DataGridView();
            this.hCSRSdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCSRSdbDataSet = new Harvest_and_Crop_Sales_Record_System.HCSRSdbDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.harvestmanagement = new System.Windows.Forms.Label();
            this.salesreports = new System.Windows.Forms.Label();
            this.inventorymonitor = new System.Windows.Forms.Label();
            this.salesmanagement = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nav_bar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Harvestr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(313, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 74);
            this.label1.TabIndex = 104;
            this.label1.Text = "HARVEST RECORDS\r\n\r\n";
            // 
            // datagrid_Harvestr
            // 
            this.datagrid_Harvestr.AutoGenerateColumns = false;
            this.datagrid_Harvestr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Harvestr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_Harvestr.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Harvestr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Harvestr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Harvestr.DataSource = this.hCSRSdbDataSetBindingSource;
            this.datagrid_Harvestr.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagrid_Harvestr.Location = new System.Drawing.Point(385, 223);
            this.datagrid_Harvestr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid_Harvestr.Name = "datagrid_Harvestr";
            this.datagrid_Harvestr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.datagrid_Harvestr.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Harvestr.RowTemplate.Height = 24;
            this.datagrid_Harvestr.Size = new System.Drawing.Size(1449, 677);
            this.datagrid_Harvestr.TabIndex = 105;
            this.datagrid_Harvestr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Harvestr_CellContentClick);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(1533, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 53);
            this.button1.TabIndex = 107;
            this.button1.Text = "+  Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.harvestmanagement);
            this.panel1.Controls.Add(this.salesreports);
            this.panel1.Controls.Add(this.inventorymonitor);
            this.panel1.Controls.Add(this.salesmanagement);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1042);
            this.panel1.TabIndex = 109;
            // 
            // harvestmanagement
            // 
            this.harvestmanagement.AutoSize = true;
            this.harvestmanagement.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harvestmanagement.ForeColor = System.Drawing.Color.DarkGreen;
            this.harvestmanagement.Location = new System.Drawing.Point(15, 267);
            this.harvestmanagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harvestmanagement.Name = "harvestmanagement";
            this.harvestmanagement.Size = new System.Drawing.Size(256, 22);
            this.harvestmanagement.TabIndex = 103;
            this.harvestmanagement.Text = "HARVEST MANAGEMENT\r\n";
            this.harvestmanagement.Click += new System.EventHandler(this.harvestmanagement_Click_1);
            // 
            // salesreports
            // 
            this.salesreports.AutoSize = true;
            this.salesreports.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesreports.ForeColor = System.Drawing.Color.DarkGreen;
            this.salesreports.Location = new System.Drawing.Point(51, 508);
            this.salesreports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesreports.Name = "salesreports";
            this.salesreports.Size = new System.Drawing.Size(162, 22);
            this.salesreports.TabIndex = 5;
            this.salesreports.Text = "SALES REPORTS";
            // 
            // inventorymonitor
            // 
            this.inventorymonitor.AutoSize = true;
            this.inventorymonitor.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorymonitor.ForeColor = System.Drawing.Color.DarkGreen;
            this.inventorymonitor.Location = new System.Drawing.Point(5, 430);
            this.inventorymonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventorymonitor.Name = "inventorymonitor";
            this.inventorymonitor.Size = new System.Drawing.Size(269, 22);
            this.inventorymonitor.TabIndex = 4;
            this.inventorymonitor.Text = "INVENTORY MONITORING";
            // 
            // salesmanagement
            // 
            this.salesmanagement.AutoSize = true;
            this.salesmanagement.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesmanagement.ForeColor = System.Drawing.Color.DarkGreen;
            this.salesmanagement.Location = new System.Drawing.Point(28, 350);
            this.salesmanagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesmanagement.Name = "salesmanagement";
            this.salesmanagement.Size = new System.Drawing.Size(218, 22);
            this.salesmanagement.TabIndex = 3;
            this.salesmanagement.Text = "SALES MANAGEMENT\r\n";
            this.salesmanagement.Click += new System.EventHandler(this.salesmanagement_Click_1);
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.dashboard.Location = new System.Drawing.Point(62, 186);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(137, 22);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(85, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nav_bar
            // 
            this.nav_bar.BackColor = System.Drawing.Color.SeaGreen;
            this.nav_bar.Controls.Add(this.panel2);
            this.nav_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_bar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nav_bar.Location = new System.Drawing.Point(0, 0);
            this.nav_bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav_bar.Name = "nav_bar";
            this.nav_bar.Size = new System.Drawing.Size(1924, 94);
            this.nav_bar.TabIndex = 108;
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
            this.lblUserInfo.ForeColor = System.Drawing.Color.Honeydew;
            this.lblUserInfo.Location = new System.Drawing.Point(75, 31);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(88, 23);
            this.lblUserInfo.TabIndex = 9;
            this.lblUserInfo.Text = "hahaha";
            this.lblUserInfo.Click += new System.EventHandler(this.lblUserInfo_Click_1);
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
            // Staff_Harvest_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nav_bar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagrid_Harvestr);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Staff_Harvest_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Harvest_Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Staff_Harvest_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Harvestr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCSRSdbDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav_bar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_Harvestr;
        private System.Windows.Forms.BindingSource hCSRSdbDataSetBindingSource;
        private HCSRSdbDataSet hCSRSdbDataSet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label harvestmanagement;
        private System.Windows.Forms.Label salesreports;
        private System.Windows.Forms.Label inventorymonitor;
        private System.Windows.Forms.Label salesmanagement;
        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel nav_bar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.PictureBox picUser;
    }
}