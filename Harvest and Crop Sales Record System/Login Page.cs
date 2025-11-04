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

            cmb_role.Items.Add("Admin");
            cmb_role.Items.Add("Staff");

        }

        private bool isPasswordVisible = false;

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                string selectedRole = cmb_role.SelectedItem.ToString();
                MessageBox.Show("You are logging in as " + selectedRole + ".");
            
                
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text;
            string password = txt_password.Text;

            if (cmb_role.SelectedItem == null)
            {
                MessageBox.Show("Please select a role before logging in.");
                return;
            }

            string role = cmb_role.SelectedItem.ToString();

            string connectionString = @"Server=JMD\JAM;Database=HCSRSdb;Trusted_Connection=True;";
            string query = "SELECT TOP 1 AccountID, Username, Role FROM Accounts " +
                           "WHERE Username = @username AND Password = @password AND Role = @role";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // ⚠️ plain text for now
                    cmd.Parameters.AddWithValue("@role", role);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        string loggedInUsername = reader["Username"].ToString();
                        string loggedInRole = reader["Role"].ToString();

                        // ✅ Close reader before another query
                        reader.Close();

                        // ✅ Update LastLogin to current time
                        using (SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Accounts SET LastLogin = GETDATE() WHERE Username = @username", conn))
                        {
                            updateCmd.Parameters.AddWithValue("@username", loggedInUsername);
                            updateCmd.ExecuteNonQuery();
                        }



                        // Create user object from database
                        User user = new User(
                            loggedInUsername.ToString(),
                            "", // we don’t need to carry the password around
                           loggedInRole.ToString()
                        );

                        Session.LoggedInUser = user; // store globally

                        // ✅ Role-based navigation
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
                        MessageBox.Show("Invalid username, password, or role. Please try again.");
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

