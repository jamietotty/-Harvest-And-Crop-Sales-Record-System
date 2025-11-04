namespace Harvest_and_Crop_Sales_Record_System
{
    partial class Harvest_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Harvest_Records));
            this.datagrid_Harvestr = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventoryrecords = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Harvestr)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_Harvestr
            // 
            this.datagrid_Harvestr.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Harvestr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Harvestr.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagrid_Harvestr.Location = new System.Drawing.Point(378, 120);
            this.datagrid_Harvestr.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid_Harvestr.Name = "datagrid_Harvestr";
            this.datagrid_Harvestr.RowHeadersWidth = 51;
            this.datagrid_Harvestr.RowTemplate.Height = 24;
            this.datagrid_Harvestr.Size = new System.Drawing.Size(1087, 609);
            this.datagrid_Harvestr.TabIndex = 95;
            this.datagrid_Harvestr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Harvestr_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.inventoryrecords);
            this.panel1.Controls.Add(this.salesrecords);
            this.panel1.Controls.Add(this.harvestrecords);
            this.panel1.Controls.Add(this.usermanagement);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 847);
            this.panel1.TabIndex = 98;
            // 
            // inventoryrecords
            // 
            this.inventoryrecords.AutoSize = true;
            this.inventoryrecords.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryrecords.ForeColor = System.Drawing.Color.DarkGreen;
            this.inventoryrecords.Location = new System.Drawing.Point(17, 413);
            this.inventoryrecords.Name = "inventoryrecords";
            this.inventoryrecords.Size = new System.Drawing.Size(175, 17);
            this.inventoryrecords.TabIndex = 5;
            this.inventoryrecords.Text = "INVENTORY REPORTS";
            this.inventoryrecords.Click += new System.EventHandler(this.inventoryrecords_Click);
            // 
            // salesrecords
            // 
            this.salesrecords.AutoSize = true;
            this.salesrecords.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesrecords.ForeColor = System.Drawing.Color.DarkGreen;
            this.salesrecords.Location = new System.Drawing.Point(17, 349);
            this.salesrecords.Name = "salesrecords";
            this.salesrecords.Size = new System.Drawing.Size(132, 17);
            this.salesrecords.TabIndex = 4;
            this.salesrecords.Text = "SALES RECORDS";
            this.salesrecords.Click += new System.EventHandler(this.salesrecords_Click);
            // 
            // harvestrecords
            // 
            this.harvestrecords.AutoSize = true;
            this.harvestrecords.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harvestrecords.ForeColor = System.Drawing.Color.DarkGreen;
            this.harvestrecords.Location = new System.Drawing.Point(15, 284);
            this.harvestrecords.Name = "harvestrecords";
            this.harvestrecords.Size = new System.Drawing.Size(159, 17);
            this.harvestrecords.TabIndex = 3;
            this.harvestrecords.Text = "HARVEST RECORDS";
            this.harvestrecords.Click += new System.EventHandler(this.harvestrecords_Click_1);
            // 
            // usermanagement
            // 
            this.usermanagement.AutoSize = true;
            this.usermanagement.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usermanagement.ForeColor = System.Drawing.Color.DarkGreen;
            this.usermanagement.Location = new System.Drawing.Point(15, 219);
            this.usermanagement.Name = "usermanagement";
            this.usermanagement.Size = new System.Drawing.Size(164, 17);
            this.usermanagement.TabIndex = 2;
            this.usermanagement.Text = "USER MANAGEMENT";
            this.usermanagement.Click += new System.EventHandler(this.usermanagement_Click_1);
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.dashboard.Location = new System.Drawing.Point(17, 151);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(107, 17);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(64, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
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
            this.nav_bar.Margin = new System.Windows.Forms.Padding(2);
            this.nav_bar.Name = "nav_bar";
            this.nav_bar.Size = new System.Drawing.Size(1155, 76);
            this.nav_bar.TabIndex = 97;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblUserInfo);
            this.panel2.Controls.Add(this.picUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(890, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 76);
            this.panel2.TabIndex = 23;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUserInfo.Location = new System.Drawing.Point(56, 25);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(68, 18);
            this.lblUserInfo.TabIndex = 9;
            this.lblUserInfo.Text = "hahaha";
            this.lblUserInfo.Click += new System.EventHandler(this.lblUserInfo_Click);
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(13, 17);
            this.picUser.Margin = new System.Windows.Forms.Padding(2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(37, 33);
            this.picUser.TabIndex = 9;
            this.picUser.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Harvest_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nav_bar);
            this.Controls.Add(this.datagrid_Harvestr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Harvest_Records";
            this.Text = "Harvest_Records";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Harvest_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Harvestr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav_bar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datagrid_Harvestr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label inventoryrecords;
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
    }
}