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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCropname = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.AmountSold = new System.Windows.Forms.TextBox();
            this.csaunits = new System.Windows.Forms.TextBox();
            this.restounits = new System.Windows.Forms.TextBox();
            this.marketunits = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.wholsesale = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.dtpDateofSale = new System.Windows.Forms.DateTimePicker();
            this.savesales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.AutoSize = true;
            this.dashboard.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.DarkGreen;
            this.dashboard.Location = new System.Drawing.Point(94, 30);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(295, 31);
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
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date of Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crop Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(13, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
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
            this.label5.Location = new System.Drawing.Point(13, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(13, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "CSA Units";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(13, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Market Units";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(13, 349);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Wholesale Units";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(13, 391);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Restaurant Units";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(13, 477);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Payment Received";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCropname
            // 
            this.txtCropname.Location = new System.Drawing.Point(170, 139);
            this.txtCropname.Name = "txtCropname";
            this.txtCropname.Size = new System.Drawing.Size(283, 22);
            this.txtCropname.TabIndex = 14;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(170, 181);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(283, 22);
            this.location.TabIndex = 15;
            // 
            // AmountSold
            // 
            this.AmountSold.Location = new System.Drawing.Point(247, 225);
            this.AmountSold.Name = "AmountSold";
            this.AmountSold.Size = new System.Drawing.Size(206, 22);
            this.AmountSold.TabIndex = 16;
            this.AmountSold.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // csaunits
            // 
            this.csaunits.Location = new System.Drawing.Point(170, 307);
            this.csaunits.Name = "csaunits";
            this.csaunits.Size = new System.Drawing.Size(173, 22);
            this.csaunits.TabIndex = 18;
            // 
            // restounits
            // 
            this.restounits.Location = new System.Drawing.Point(199, 394);
            this.restounits.Name = "restounits";
            this.restounits.Size = new System.Drawing.Size(144, 22);
            this.restounits.TabIndex = 19;
            // 
            // marketunits
            // 
            this.marketunits.Location = new System.Drawing.Point(199, 433);
            this.marketunits.Name = "marketunits";
            this.marketunits.Size = new System.Drawing.Size(144, 22);
            this.marketunits.TabIndex = 21;
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(233, 480);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(110, 22);
            this.payment.TabIndex = 22;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(247, 264);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(206, 22);
            this.total.TabIndex = 23;
            // 
            // wholsesale
            // 
            this.wholsesale.Location = new System.Drawing.Point(199, 349);
            this.wholsesale.Name = "wholsesale";
            this.wholsesale.Size = new System.Drawing.Size(144, 22);
            this.wholsesale.TabIndex = 24;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Firebrick;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.Location = new System.Drawing.Point(344, 558);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(123, 36);
            this.cancelbtn.TabIndex = 26;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            // 
            // dtpDateofSale
            // 
            this.dtpDateofSale.Location = new System.Drawing.Point(170, 98);
            this.dtpDateofSale.Name = "dtpDateofSale";
            this.dtpDateofSale.Size = new System.Drawing.Size(282, 22);
            this.dtpDateofSale.TabIndex = 27;
            // 
            // savesales
            // 
            this.savesales.BackColor = System.Drawing.Color.ForestGreen;
            this.savesales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesales.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savesales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savesales.Location = new System.Drawing.Point(199, 558);
            this.savesales.Name = "savesales";
            this.savesales.Size = new System.Drawing.Size(123, 36);
            this.savesales.TabIndex = 28;
            this.savesales.Text = "Save";
            this.savesales.UseVisualStyleBackColor = false;
            this.savesales.Click += new System.EventHandler(this.savesales_Click);
            // 
            // Add_New_Sales_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(492, 621);
            this.Controls.Add(this.savesales);
            this.Controls.Add(this.dtpDateofSale);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.wholsesale);
            this.Controls.Add(this.total);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.marketunits);
            this.Controls.Add(this.restounits);
            this.Controls.Add(this.csaunits);
            this.Controls.Add(this.AmountSold);
            this.Controls.Add(this.location);
            this.Controls.Add(this.txtCropname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboard);
            this.Name = "Add_New_Sales_Record";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCropname;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox AmountSold;
        private System.Windows.Forms.TextBox csaunits;
        private System.Windows.Forms.TextBox restounits;
        private System.Windows.Forms.TextBox marketunits;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox wholsesale;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.DateTimePicker dtpDateofSale;
        private System.Windows.Forms.Button savesales;
    }
}