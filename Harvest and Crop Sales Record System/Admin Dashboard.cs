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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            LoadSalesChart();
            LoadDashboardStats();
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
                            decimal totalIncome = reader["totalIncome"] != DBNull.Value ? Convert.ToDecimal(reader["totalIncome"]) : 0;

                            // Assign to labels
                            label9.Text = totalHarvest.ToString();
                            label10.Text = totalStaff.ToString();
                            label11.Text = totalIncome.ToString("C", new CultureInfo("en-PH")); // "C" = Currency format
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

        //---------------------------------SIDE NAVBAR----------------------
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            Admin_Dashboard newDashboard = new Admin_Dashboard();
            newDashboard.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUserInfo_Click(object sender, EventArgs e)
        {

            contextMenuStrip1.Show(lblUserInfo, new Point(0, lblUserInfo.Height));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_Dashboard newAdmin = new Admin_Dashboard();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Sales newSales = new Sales();
            newSales.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Harvest_Records newHarvest = new Harvest_Records();
            newHarvest.Show();
            this.Hide();
        }

   

        private void label5_Click(object sender, EventArgs e)
        {
            User_Management newUsers = new User_Management();
            newUsers.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
