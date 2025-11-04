namespace Harvest_and_Crop_Sales_Record_System
{
    partial class Add_New_Harvest_Record
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
            this.dashboard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.storagedetails = new System.Windows.Forms.Label();
            this.txtCropname = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.harvestlocation = new System.Windows.Forms.TextBox();
            this.storage = new System.Windows.Forms.TextBox();
            this.saveharvest = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.dtpHarvestDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.dashboard.Location = new System.Drawing.Point(115, 47);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(335, 31);
            this.dashboard.TabIndex = 2;
            this.dashboard.Text = "Harvest Record Details";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(34, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Crop Name\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(34, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Harvested";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(34, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // storagedetails
            // 
            this.storagedetails.AutoSize = true;
            this.storagedetails.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storagedetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.storagedetails.Location = new System.Drawing.Point(34, 376);
            this.storagedetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storagedetails.Name = "storagedetails";
            this.storagedetails.Size = new System.Drawing.Size(161, 23);
            this.storagedetails.TabIndex = 7;
            this.storagedetails.Text = "Storage Details";
            this.storagedetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCropname
            // 
            this.txtCropname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCropname.Location = new System.Drawing.Point(177, 155);
            this.txtCropname.Name = "txtCropname";
            this.txtCropname.Size = new System.Drawing.Size(314, 22);
            this.txtCropname.TabIndex = 8;
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtquantity.Location = new System.Drawing.Point(177, 214);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(314, 22);
            this.txtquantity.TabIndex = 9;
            // 
            // harvestlocation
            // 
            this.harvestlocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.harvestlocation.Location = new System.Drawing.Point(208, 324);
            this.harvestlocation.Name = "harvestlocation";
            this.harvestlocation.Size = new System.Drawing.Size(283, 22);
            this.harvestlocation.TabIndex = 11;
            // 
            // storage
            // 
            this.storage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.storage.Location = new System.Drawing.Point(208, 379);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(283, 22);
            this.storage.TabIndex = 12;
            // 
            // saveharvest
            // 
            this.saveharvest.BackColor = System.Drawing.Color.ForestGreen;
            this.saveharvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveharvest.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveharvest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveharvest.Location = new System.Drawing.Point(222, 471);
            this.saveharvest.Name = "saveharvest";
            this.saveharvest.Size = new System.Drawing.Size(123, 36);
            this.saveharvest.TabIndex = 13;
            this.saveharvest.Text = "Save";
            this.saveharvest.UseVisualStyleBackColor = false;
            this.saveharvest.Click += new System.EventHandler(this.saveharvest_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Firebrick;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.Location = new System.Drawing.Point(368, 471);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(123, 36);
            this.cancelbtn.TabIndex = 14;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // dtpHarvestDate
            // 
            this.dtpHarvestDate.Location = new System.Drawing.Point(209, 271);
            this.dtpHarvestDate.Name = "dtpHarvestDate";
            this.dtpHarvestDate.Size = new System.Drawing.Size(282, 22);
            this.dtpHarvestDate.TabIndex = 15;
            // 
            // Add_New_Harvest_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 538);
            this.Controls.Add(this.dtpHarvestDate);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.saveharvest);
            this.Controls.Add(this.storage);
            this.Controls.Add(this.harvestlocation);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtCropname);
            this.Controls.Add(this.storagedetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboard);
            this.Name = "Add_New_Harvest_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Harvest_Record";
            this.Load += new System.EventHandler(this.Add_New_Harvest_Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label storagedetails;
        private System.Windows.Forms.TextBox txtCropname;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox harvestlocation;
        private System.Windows.Forms.TextBox storage;
        private System.Windows.Forms.Button saveharvest;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.DateTimePicker dtpHarvestDate;
    }
}