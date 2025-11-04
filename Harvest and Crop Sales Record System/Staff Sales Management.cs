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
    public partial class Staff_Sales_Management : Form
    {
        public Staff_Sales_Management()
        {
            InitializeComponent();
        }

        private void lblUserInfo_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(lblUserInfo, new Point(0, lblUserInfo.Height));

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

         
        private void Staff_Sales_Management_Load(object sender, EventArgs e)
        {
            LoadSales();

            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }
        }

        private void LoadSales()
        {
           

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string query = "SELECT * FROM dbo.Sales_Records";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                datagrid_Sales.AutoGenerateColumns = true;
                datagrid_Sales.DataSource = dt;
            }

           
        }

     
        private void datagrid_Sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Sales_Record addForm = new Add_New_Sales_Record();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadSales();
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard newAdmin = new Admin_Dashboard();
            newAdmin.Show();
            this.Hide();
        }

        private void harvestmanagement_Click(object sender, EventArgs e)
        {
            Staff_Harvest_Management newUsers = new Staff_Harvest_Management();
            newUsers.Show();
            this.Hide();
        }

        private void salesmanagement_Click(object sender, EventArgs e)
        {
            Staff_Sales_Management newHarvest = new Staff_Sales_Management();
            newHarvest.Show();
            this.Hide();
        }

        private void salesreports_Click(object sender, EventArgs e)
        {
            Staff_Sales_Reports newReports = new Staff_Sales_Reports();
            newReports.Show();
            this.Hide();
        }
    }
}
