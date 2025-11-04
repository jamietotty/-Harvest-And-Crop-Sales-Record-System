using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Harvest_and_Crop_Sales_Record_System
{
    public partial class AddNewUser : Form
    {
        private int? editingUserId = null;

        public AddNewUser()
        {
            InitializeComponent();
        }

        public AddNewUser(int accountId)
        {
            InitializeComponent();
            dashboard.Text = "Edit User Account";
            editingUserId = accountId;
            LoadUserData(accountId);
        }

        private void LoadUserData(int accountId)
        {
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string query = "SELECT * FROM Accounts WHERE AccountID = @AccountID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", accountId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        firstname.Text = reader["FirstName"].ToString();
                        lastname.Text = reader["LastName"].ToString();
                        emailTxt.Text = reader["Email"].ToString();
                        usernameTxt.Text = reader["Username"].ToString();
                        passwordTxt.Text = reader["Password"].ToString();
                        roleTxt.Text = reader["Role"].ToString();
                    }
                }
            }
        }
        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void saveharvest_Click(object sender, EventArgs e)
        {
            string lastName = lastname.Text.Trim();
            string firstName = firstname.Text.Trim();
            string email = emailTxt.Text.Trim();
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            string role = roleTxt.Text.Trim();       

            if (string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();

                    string query;

                    if (editingUserId.HasValue)
                    {
                        // Update existing account
                        query = @"UPDATE Accounts 
                          SET LastName = @LastName,
                              FirstName = @FirstName,
                              Email = @Email,
                              Username = @Username,
                              Password = @Password,
                              Role = @Role
                          WHERE AccountID = @AccountID";
                    }
                    else
                    {
                        // Insert new account
                        query = @"INSERT INTO Accounts 
                          (LastName, FirstName, Email, Username, Password, Role, DateCreated)
                          VALUES (@LastName, @FirstName, @Email, @Username, @Password, @Role, GETDATE())";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);

                        if (editingUserId.HasValue)
                            cmd.Parameters.AddWithValue("@AccountID", editingUserId.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                editingUserId.HasValue ? "Account updated successfully!" : "Account saved successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                            );

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
