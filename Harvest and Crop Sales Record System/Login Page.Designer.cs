namespace Harvest_and_Crop_Sales_Record_System
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.system_name = new System.Windows.Forms.Label();
            this.nav_bar = new System.Windows.Forms.Panel();
            this.admin_loginbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closed = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nav_bar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).BeginInit();
            this.SuspendLayout();
            // 
            // system_name
            // 
            this.system_name.AutoSize = true;
            this.system_name.BackColor = System.Drawing.Color.Transparent;
            this.system_name.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_name.ForeColor = System.Drawing.Color.White;
            this.system_name.Location = new System.Drawing.Point(800, 23);
            this.system_name.Name = "system_name";
            this.system_name.Size = new System.Drawing.Size(650, 36);
            this.system_name.TabIndex = 1;
            this.system_name.Text = " Harvest And Crop Sales Record System";
            // 
            // nav_bar
            // 
            this.nav_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nav_bar.Controls.Add(this.admin_loginbtn);
            this.nav_bar.Controls.Add(this.system_name);
            this.nav_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav_bar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nav_bar.Location = new System.Drawing.Point(0, 0);
            this.nav_bar.Name = "nav_bar";
            this.nav_bar.Size = new System.Drawing.Size(1924, 83);
            this.nav_bar.TabIndex = 1;
            // 
            // admin_loginbtn
            // 
            this.admin_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.admin_loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_loginbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.admin_loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.admin_loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_loginbtn.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_loginbtn.ForeColor = System.Drawing.Color.Transparent;
            this.admin_loginbtn.Location = new System.Drawing.Point(1756, 0);
            this.admin_loginbtn.Name = "admin_loginbtn";
            this.admin_loginbtn.Size = new System.Drawing.Size(168, 83);
            this.admin_loginbtn.TabIndex = 2;
            this.admin_loginbtn.Text = "ABOUT";
            this.admin_loginbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closed);
            this.panel1.Controls.Add(this.open);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_role);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(152, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 733);
            this.panel1.TabIndex = 3;
            // 
            // closed
            // 
            this.closed.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.closed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closed.BackgroundImage")));
            this.closed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closed.Location = new System.Drawing.Point(525, 370);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(40, 30);
            this.closed.TabIndex = 13;
            this.closed.TabStop = false;
            this.closed.Click += new System.EventHandler(this.closed_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open.BackgroundImage")));
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open.Location = new System.Drawing.Point(525, 370);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(40, 30);
            this.open.TabIndex = 12;
            this.open.TabStop = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Log in As:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_role
            // 
            this.cmb_role.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(124, 474);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(450, 42);
            this.cmb_role.TabIndex = 10;
            this.cmb_role.SelectedIndexChanged += new System.EventHandler(this.cmb_role_SelectedIndexChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Green;
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(124, 576);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(446, 77);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "L O G I N";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_password.Location = new System.Drawing.Point(124, 363);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(450, 43);
            this.txt_password.TabIndex = 7;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_username.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_username.Location = new System.Drawing.Point(124, 259);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(450, 43);
            this.txt_username.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(189, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 92);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nav_bar);
            this.Name = "Login_Page";
            this.Text = "Login_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.nav_bar.ResumeLayout(false);
            this.nav_bar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label system_name;
        private System.Windows.Forms.Panel nav_bar;
        private System.Windows.Forms.Button admin_loginbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox open;
        private System.Windows.Forms.PictureBox closed;
    }
}