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
    public partial class Harvest_Records : Form
    {
        public Harvest_Records()
        {
            InitializeComponent();

            this.Text = "Harvest Records";

            
        }
        private void Harvest_Records_Load(object sender, EventArgs e)
        {
            LoadHarvest();

            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }
        }

        private void datagrid_Harvestr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        //-----------------------------NAVBAR

    
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            Admin_Dashboard newAdmin = new Admin_Dashboard();
            newAdmin.Show();
            this.Hide();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            User_Management newUsers = new User_Management();
            newUsers.Show();
            this.Hide();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            Sales newSales = new Sales();
            newSales.Show();
            this.Hide();
        }

        private void reports_btn_Click(object sender, EventArgs e)
        {
            Reports newReports = new Reports();
            newReports.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Session.LoggedInUser = null;
            this.Hide();
            var login = new Login_Page();
            login.Show();
        }

        private void system_name_Click(object sender, EventArgs e)
        {

        }
    }
}
