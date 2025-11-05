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

                datagrid_Sales.AutoGenerateColumns = false;
                datagrid_Sales.Columns.Clear();
                datagrid_Sales.DataSource = dt;

                // Manually add columns to control order and header text
                datagrid_Sales.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Crop", HeaderText = "Crop" });
                datagrid_Sales.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DateOfSale", HeaderText = "Date of Sale" });
                datagrid_Sales.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Sold To", HeaderText = "Sold To" });
                datagrid_Sales.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity Sold", HeaderText = "Quantity Sold (kg)" });
                datagrid_Sales.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Total Amount", HeaderText = "Total Amount (₱)" });
                datagrid_Sales.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Market Units", HeaderText = "Market Units" });
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
            Staff_Dashboard newAdmin = new Staff_Dashboard();
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
