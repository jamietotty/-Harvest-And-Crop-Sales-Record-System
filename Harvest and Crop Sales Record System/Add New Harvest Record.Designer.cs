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
            this.dashboard.Location = new System.Drawing.Point(86, 38);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(272, 25);
            this.dashboard.TabIndex = 2;
            this.dashboard.Text = "Harvest Record Details";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Crop Name\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Harvested";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // storagedetails
            // 
            this.storagedetails.AutoSize = true;
            this.storagedetails.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storagedetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.storagedetails.Location = new System.Drawing.Point(26, 306);
            this.storagedetails.Name = "storagedetails";
            this.storagedetails.Size = new System.Drawing.Size(130, 18);
            this.storagedetails.TabIndex = 7;
            this.storagedetails.Text = "Storage Details";
            this.storagedetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.storagedetails.Click += new System.EventHandler(this.storagedetails_Click);
            // 
            // txtCropname
            // 
            this.txtCropname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCropname.Location = new System.Drawing.Point(133, 126);
            this.txtCropname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCropname.Name = "txtCropname";
            this.txtCropname.Size = new System.Drawing.Size(236, 20);
            this.txtCropname.TabIndex = 8;
            this.txtCropname.TextChanged += new System.EventHandler(this.txtCropname_TextChanged);
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtquantity.Location = new System.Drawing.Point(133, 174);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(236, 20);
            this.txtquantity.TabIndex = 9;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // harvestlocation
            // 
            this.harvestlocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.harvestlocation.Location = new System.Drawing.Point(156, 263);
            this.harvestlocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.harvestlocation.Name = "harvestlocation";
            this.harvestlocation.Size = new System.Drawing.Size(213, 20);
            this.harvestlocation.TabIndex = 11;
            this.harvestlocation.TextChanged += new System.EventHandler(this.harvestlocation_TextChanged);
            // 
            // storage
            // 
            this.storage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.storage.Location = new System.Drawing.Point(156, 308);
            this.storage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(213, 20);
            this.storage.TabIndex = 12;
            this.storage.TextChanged += new System.EventHandler(this.storage_TextChanged);
            // 
            // saveharvest
            // 
            this.saveharvest.BackColor = System.Drawing.Color.ForestGreen;
            this.saveharvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveharvest.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveharvest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveharvest.Location = new System.Drawing.Point(166, 383);
            this.saveharvest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveharvest.Name = "saveharvest";
            this.saveharvest.Size = new System.Drawing.Size(92, 29);
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
            this.cancelbtn.Location = new System.Drawing.Point(276, 383);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(92, 29);
            this.cancelbtn.TabIndex = 14;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // dtpHarvestDate
            // 
            this.dtpHarvestDate.Location = new System.Drawing.Point(157, 220);
            this.dtpHarvestDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHarvestDate.Name = "dtpHarvestDate";
            this.dtpHarvestDate.Size = new System.Drawing.Size(212, 20);
            this.dtpHarvestDate.TabIndex = 15;
            this.dtpHarvestDate.ValueChanged += new System.EventHandler(this.dtpHarvestDate_ValueChanged);
            // 
            // Add_New_Harvest_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 437);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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