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
    public partial class Staff_Harvest_Management : Form
    {
        public Staff_Harvest_Management()
        {
            InitializeComponent();
        }

        private void Staff_Harvest_Management_Load(object sender, EventArgs e)
        {
            LoadHarvest();


            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }
        }

        private void LoadHarvest()
        {
            // Change connection string to match your setup
            string connectionString = @"Server=JMD\JAM;Database=HCSRSdb;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.Harvest_Records";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                datagrid_Harvestr.AutoGenerateColumns = true;
                datagrid_Harvestr.DataSource = dt;
            }
        }

        //----------------------------------------------------------NAVBAR

        private void datagrid_Harvestr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void harvestmanagement_Click_1(object sender, EventArgs e)
        {
            Staff_Harvest_Management newUsers = new Staff_Harvest_Management();
            newUsers.Show();
            this.Hide();
        }

        private void salesmanagement_Click_1(object sender, EventArgs e)
        {
            Staff_Sales_Management newHarvest = new Staff_Sales_Management();
            newHarvest.Show();
            this.Hide();
        }

    

        private void inventorymonitor_Click(object sender, EventArgs e)
        {
            Staff_Inventory_Monitoring newSales = new Staff_Inventory_Monitoring();
            newSales.Show();
            this.Hide();
        }

        private void salesreports_Click(object sender, EventArgs e)
        {
            Staff_Sales_Reports newReports = new Staff_Sales_Reports();
            newReports.Show();
            this.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Staff_Dashboard newAdmin = new Staff_Dashboard();
            newAdmin.Show();
            this.Hide();
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

      

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Harvest_Record addForm = new Add_New_Harvest_Record();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadHarvest(); 
            }

        }

        private void lblUserInfo_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(lblUserInfo, new Point(0, lblUserInfo.Height));
        }

     
    }
}
