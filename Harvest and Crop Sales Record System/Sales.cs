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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }

            LoadSales_Records();
        }

        private void LoadSales_Records()
        {
            // Change connection string to match your setup

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string query = @"
            SELECT 
                Crop,
                DateOfSale,
                Location AS [Sold To],
                AmountSold AS [Quantity Sold],
                TotalAmount AS [Total Amount],
                MarketUnits AS [Market Units]
            FROM dbo.Sales_Records";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                datagrid_Salesr.AutoGenerateColumns = false;
                datagrid_Salesr.Columns.Clear();
                datagrid_Salesr.DataSource = dt;

                // Manually add columns to control order and header text
                datagrid_Salesr.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Crop", HeaderText = "Crop" });
                datagrid_Salesr.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DateOfSale", HeaderText = "Date of Sale" });
                datagrid_Salesr.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Sold To", HeaderText = "Sold To" });
                datagrid_Salesr.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity Sold", HeaderText = "Quantity Sold (kg)" });
                datagrid_Salesr.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Total Amount", HeaderText = "Total Amount (₱)" });
                datagrid_Salesr.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Market Units", HeaderText = "Market Units" });
            }
        }

        //-----------------------------NAVBAR

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Dashboard newAdmin = new Admin_Dashboard();
            newAdmin.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            User_Management newUsers = new User_Management();
            newUsers.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Harvest_Records newHarvest = new Harvest_Records();
            newHarvest.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Sales newSales = new Sales();
            newSales.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Reports newReports = new Reports();
            newReports.Show();
            this.Hide();
        }

        private void lblUserInfo_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(lblUserInfo, new Point(0, lblUserInfo.Height));

        }

        private void inventoryrecords_Click(object sender, EventArgs e)
        {
            Reports newReports = new Reports();
            newReports.Show();
            this.Hide();
        }
    }
}
