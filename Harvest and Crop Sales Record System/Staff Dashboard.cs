using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Harvest_and_Crop_Sales_Record_System
{
    public partial class Staff_Dashboard : Form
    {
        public Staff_Dashboard()
        {
            InitializeComponent();
        }

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
            LoadSalesChart();
            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }

        }

        private void LoadDashboardStats()
        {
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                string query = @"
            SELECT 
                (SELECT COUNT(*) FROM Harvest_Records) AS totalHarvest,
                (SELECT COUNT(*) FROM Accounts WHERE Role = 'Staff') AS totalStaff,
                (SELECT SUM(Totalamount) FROM Sales_Records WHERE CAST(DateOfSale AS DATE) = CAST(GETDATE() AS DATE)) AS totalIncomeToday,
                (SELECT SUM(Totalamount) FROM Sales_Records) AS totalIncome;
                ";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Handle potential nulls with DBNull check
                            int totalHarvest = reader["totalHarvest"] != DBNull.Value ? Convert.ToInt32(reader["totalHarvest"]) : 0;
                            int totalStaff = reader["totalStaff"] != DBNull.Value ? Convert.ToInt32(reader["totalStaff"]) : 0;
                            decimal totalIncomeToday = reader["totalIncomeToday"] != DBNull.Value ? Convert.ToDecimal(reader["totalIncomeToday"]) : 0;
                            decimal totalIncome = reader["totalIncome"] != DBNull.Value ? Convert.ToDecimal(reader["totalIncome"]) : 0;

                            // Assign to labels
                            label9.Text = totalHarvest.ToString();
                            label2.Text = totalIncomeToday.ToString();
                            label4.Text = totalIncome.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard stats: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSalesChart()
        {
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                // Group total sales by date
                string query = @"
            SELECT 
                CAST(DateOfSale AS DATE) AS SaleDate,
                SUM(Totalamount) AS TotalSales
            FROM Sales_Records
            GROUP BY CAST(DateOfSale AS DATE)
            ORDER BY SaleDate;
        ";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Clear previous chart data
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();

                // Create a chart area
                ChartArea chartArea = new ChartArea("SalesArea");
                chart1.ChartAreas.Add(chartArea);

                // Create a series for sales
                Series series = new Series("Daily Sales");
                series.ChartType = SeriesChartType.Line;  // You can also use Line, Area, etc.
                series.XValueType = ChartValueType.Date;

                // Bind data
                series.Points.DataBind(dt.DefaultView, "SaleDate", "TotalSales", "");

                chart1.Series.Add(series);

                // Format axis labels
                chart1.Series["Daily Sales"].ChartType = SeriesChartType.Spline;
                chart1.Series["Daily Sales"].BorderWidth = 3; // makes the line thicker
                chart1.Series["Daily Sales"].Color = Color.MediumSeaGreen; // nice color
                chart1.Series["Daily Sales"].MarkerStyle = MarkerStyle.Circle; // adds dots
                chart1.Series["Daily Sales"].MarkerSize = 8;
                chart1.Series["Daily Sales"].MarkerColor = Color.DarkGreen;
                chart1.ChartAreas[0].AxisX.Interval = 1; // show all labels on X axis
                chart1.ChartAreas["SalesArea"].AxisX.LabelStyle.Format = "MMM dd";
                chart1.ChartAreas["SalesArea"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chart1.ChartAreas["SalesArea"].AxisY.Title = "Total Sales";
                chart1.ChartAreas["SalesArea"].AxisX.Title = "Date of Sales";
            }
        }

        private void dashboard_Click_1(object sender, EventArgs e)
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
