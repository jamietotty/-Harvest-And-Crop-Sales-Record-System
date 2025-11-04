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
            // Change connection string to match your setup
            string connectionString = @"Server=JMD\JAM;Database=HCSRSdb;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.Accounts"; 
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                datagrid_Accounts.AutoGenerateColumns = true;
                datagrid_Accounts.DataSource = dt;
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

        private void inventoryrecords_Click(object sender, EventArgs e)
        {
            Reports newReports = new Reports();
            newReports.Show();
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
    }
}
