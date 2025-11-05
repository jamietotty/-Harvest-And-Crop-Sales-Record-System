using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Harvest_and_Crop_Sales_Record_System
{
    public partial class User_Management : Form
    {
        public User_Management()
        {
            InitializeComponent();

            this.Text = "Users Management";
            datagrid_Accounts.CellContentClick += datagrid_Accounts_CellContentClick;

        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            LoadUsers();

            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }
        }


        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string currentUsername = Session.LoggedInUser?.Username;

                string query = @" SELECT AccountID,
                                         FirstName,
                                         LastName,
                                         Email,
                                         Username,
                                         Role,
                                         DateCreated,
                                         LastLogin,
                                         Status
                FROM dbo.Accounts WHERE Username <> @currentUsername";   

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@currentUsername", currentUsername ?? "");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                datagrid_Accounts.AutoGenerateColumns = false;
                datagrid_Accounts.DataSource = dt;

                datagrid_Accounts.Columns.Clear();
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name" });
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name" });
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" });
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Username", HeaderText = "Username" });
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Role", HeaderText = "Role" });
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DateCreated", HeaderText = "Date Created" });
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastLogin", HeaderText = "Last Login" });
                datagrid_Accounts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status" });

                var idColumn = new DataGridViewTextBoxColumn { DataPropertyName = "AccountID", Visible = false, Name = "AccountID" };
                datagrid_Accounts.Columns.Add(idColumn);

                // Edit button
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };
                datagrid_Accounts.Columns.Add(editButton);



                // Delete button
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                datagrid_Accounts.Columns.Add(deleteButton);

                datagrid_Accounts.AllowUserToAddRows = false;
                datagrid_Accounts.CellContentClick -= datagrid_Accounts_CellContentClick;
                datagrid_Accounts.CellContentClick += datagrid_Accounts_CellContentClick;
            }
        }

        private void datagrid_Accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Skip header / invalid / new rows
            if (e.RowIndex < 0 || datagrid_Accounts.Rows[e.RowIndex].IsNewRow)
                return;

            var cellValue = datagrid_Accounts.Rows[e.RowIndex].Cells["AccountID"].Value;
            if (cellValue == null) return;

            int accountId = Convert.ToInt32(cellValue);

            string columnHeader = datagrid_Accounts.Columns[e.ColumnIndex].HeaderText;

            if (columnHeader == "Edit")
            {
                // Edit user
                AddNewUser form = new AddNewUser(accountId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
            else if (columnHeader == "Delete")
            {
                // Confirm deletion
                DialogResult result = MessageBox.Show(
                    "Deleting this user is permanent. Are you sure you want to continue?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM Accounts WHERE AccountID = @AccountID", conn))
                            {
                                cmd.Parameters.AddWithValue("@AccountID", accountId);
                                int rows = cmd.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadUsers();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //-----------------------------NAVBAR

        private void dashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard newAdmin = new Admin_Dashboard();
            newAdmin.Show();
            this.Hide();
        }

        private void usermanagement_Click(object sender, EventArgs e)
        {
            User_Management newUsers = new User_Management();
            newUsers.Show();
            this.Hide();
        }

        private void harvestrecords_Click(object sender, EventArgs e)
        {
            Harvest_Records newHarvest = new Harvest_Records();
            newHarvest.Show();
            this.Hide();
        }

        private void salesrecords_Click(object sender, EventArgs e)
        {
            Sales newSales = new Sales();
            newSales.Show();
            this.Hide();
        }

   

        private void lblUserInfo_Click(object sender, EventArgs e)
        {

            contextMenuStrip1.Show(lblUserInfo, new Point(0, lblUserInfo.Height));
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Example: confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.LoggedInUser = null;
                this.Hide();
                var login = new Login_Page();
                login.Show();
            }
        }

       

        private void addUser_Click(object sender, EventArgs e)
        {
            AddNewUser form = new AddNewUser();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void datagrid_Accounts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
