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

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
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


        private void dashboard_Click_1(object sender, EventArgs e)
        {
            Admin_Dashboard newAdmin = new Admin_Dashboard();
            newAdmin.Show();
            this.Hide();
        }

        private void usermanagement_Click_1(object sender, EventArgs e)
        {
            User_Management newUsers = new User_Management();
            newUsers.Show();
            this.Hide();
        }

        private void harvestrecords_Click_1(object sender, EventArgs e)
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

        private void lblUserInfo_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(lblUserInfo, new Point(0, lblUserInfo.Height));
        }
    }
}
