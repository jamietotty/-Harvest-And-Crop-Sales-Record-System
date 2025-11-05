namespace Harvest_and_Crop_Sales_Record_System
{
    partial class Add_New_Sales_Record
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.marketunits = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.dtpDateofSale = new System.Windows.Forms.DateTimePicker();
            this.savesales = new System.Windows.Forms.Button();
            this.priceperKg = new System.Windows.Forms.TextBox();
            this.cropName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.dashboard.Location = new System.Drawing.Point(70, 24);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(241, 25);
            this.dashboard.TabIndex = 3;
            this.dashboard.Text = "Sales Record Details";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date of Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crop Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sold To";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount Sold (kg)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Market Units";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(128, 147);
            this.location.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(213, 20);
            this.location.TabIndex = 15;
            // 
            // marketunits
            // 
            this.marketunits.Location = new System.Drawing.Point(151, 219);
            this.marketunits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.marketunits.Name = "marketunits";
            this.marketunits.Size = new System.Drawing.Size(144, 20);
            this.marketunits.TabIndex = 21;
            this.marketunits.TextChanged += new System.EventHandler(this.marketunits_TextChanged_1);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(151, 250);
            this.total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(144, 20);
            this.total.TabIndex = 23;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Firebrick;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.Location = new System.Drawing.Point(258, 453);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(92, 29);
            this.cancelbtn.TabIndex = 26;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // dtpDateofSale
            // 
            this.dtpDateofSale.Location = new System.Drawing.Point(128, 80);
            this.dtpDateofSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateofSale.Name = "dtpDateofSale";
            this.dtpDateofSale.Size = new System.Drawing.Size(212, 20);
            this.dtpDateofSale.TabIndex = 27;
            // 
            // savesales
            // 
            this.savesales.BackColor = System.Drawing.Color.ForestGreen;
            this.savesales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesales.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savesales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savesales.Location = new System.Drawing.Point(149, 453);
            this.savesales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savesales.Name = "savesales";
            this.savesales.Size = new System.Drawing.Size(92, 29);
            this.savesales.TabIndex = 28;
            this.savesales.Text = "Save";
            this.savesales.UseVisualStyleBackColor = false;
            this.savesales.Click += new System.EventHandler(this.savesales_Click);
            // 
            // priceperKg
            // 
            this.priceperKg.Location = new System.Drawing.Point(153, 183);
            this.priceperKg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceperKg.Name = "priceperKg";
            this.priceperKg.Size = new System.Drawing.Size(140, 20);
            this.priceperKg.TabIndex = 30;
            this.priceperKg.TextChanged += new System.EventHandler(this.priceperKg_TextChanged);
            // 
            // cropName
            // 
            this.cropName.FormattingEnabled = true;
            this.cropName.Location = new System.Drawing.Point(128, 113);
            this.cropName.Name = "cropName";
            this.cropName.Size = new System.Drawing.Size(212, 21);
            this.cropName.TabIndex = 31;
            this.cropName.Text = "Crop Name";
            // 
            // Add_New_Sales_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(369, 505);
            this.Controls.Add(this.cropName);
            this.Controls.Add(this.priceperKg);
            this.Controls.Add(this.savesales);
            this.Controls.Add(this.dtpDateofSale);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.total);
            this.Controls.Add(this.marketunits);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Add_New_Sales_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_New_Sales_Record";
            this.Load += new System.EventHandler(this.Add_New_Sales_Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox marketunits;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.DateTimePicker dtpDateofSale;
        private System.Windows.Forms.Button savesales;
        private System.Windows.Forms.TextBox priceperKg;
        private System.Windows.Forms.ComboBox cropName;
    }
}