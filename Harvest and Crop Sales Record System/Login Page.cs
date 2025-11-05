using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harvest_and_Crop_Sales_Record_System
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();

            this.Text = "Login Page";

        }

        private bool isPasswordVisible = false;


        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
        SELECT TOP 1 AccountID, Username, Role, Status 
        FROM Accounts 
        WHERE Username = @username AND Password = @password";

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); 

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string loggedInUsername = reader["Username"].ToString();
                        string loggedInRole = reader["Role"].ToString();
                        string status = reader["Status"].ToString();

                        // 
                        if (!status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Your account is inactive. Please contact the admin for help",
                                            "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reader.Close();
                            return;
                        }

                        reader.Close();

                        using (SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Accounts SET LastLogin = GETDATE() WHERE Username = @username", conn))
                        {
                            updateCmd.Parameters.AddWithValue("@username", loggedInUsername);
                            updateCmd.ExecuteNonQuery();
                        }

                        User user = new User(
                            loggedInUsername,
                            "", 
                            loggedInRole
                        );

                        Session.LoggedInUser = user;

                        if (user.Role == "Admin")
                        {
                            Admin_Dashboard newAdmin = new Admin_Dashboard();
                            newAdmin.Show();
                            this.Hide();
                        }
                        else if (user.Role == "Staff")
                        {
                            Staff_Dashboard newStaff = new Staff_Dashboard();
                            newStaff.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            isPasswordVisible = true; // force visible
            txt_password.UseSystemPasswordChar = false;
            closed.BringToFront();
        }

        private void closed_Click(object sender, EventArgs e)
        {
            isPasswordVisible = false; // force hidden
            txt_password.UseSystemPasswordChar = true;
            open.BringToFront();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

