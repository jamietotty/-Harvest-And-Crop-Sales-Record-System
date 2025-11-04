using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;



namespace Harvest_and_Crop_Sales_Record_System
{
    public partial class Add_New_Sales_Record : Form
    {
        public Add_New_Sales_Record()
        {
            InitializeComponent();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

   
        private void Add_New_Sales_Record_Load(object sender, EventArgs e)
        {
            dtpDateofSale.Value = DateTime.Now;

        }



        private void savesales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCropname.Text) || string.IsNullOrWhiteSpace(total.Text) || string.IsNullOrWhiteSpace(location.Text) || string.IsNullOrWhiteSpace(priceperKg.Text))
            {
                MessageBox.Show("Please fill in Crop Name, Quantity, Location and Storage Details.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO sales_records (Crop, DateOfSale, Location, AmountSold, TotalAmount, CSAunits, MarketUnits, WholesaleUnits, RestaurantUnits, PaymentRecieved ) " +
                               "VALUES (@Crop, @DateofSale, @Location, @AmountSold, @TotalAmount, @CSAunits, @MarketUnits, @WholesaleUnits, @RestaurantUnits, @PaymentRecieved )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Crop", txtCropname.Text);
                cmd.Parameters.AddWithValue("@DateofSale", dtpDateofSale.Value);
                cmd.Parameters.AddWithValue("@Location", location.Text);
                cmd.Parameters.AddWithValue("@AmountSold", int.TryParse(priceperKg.Text, out int amtSold) ? amtSold : 0);
                cmd.Parameters.AddWithValue("@TotalAmount", decimal.TryParse(total.Text, out decimal totalAmt) ? totalAmt : 0);
                cmd.Parameters.AddWithValue("@CSAunits", int.TryParse(csaunits.Text, out int csaUnits) ? csaUnits : 0);
                cmd.Parameters.AddWithValue("@MarketUnits", int.TryParse(marketunits.Text, out int marketUnits) ? marketUnits : 0);
                cmd.Parameters.AddWithValue("@WholesaleUnits", int.TryParse(wholsesale.Text, out int wholesaleUnits) ? wholesaleUnits : 0);
                cmd.Parameters.AddWithValue("@RestaurantUnits", int.TryParse(restounits.Text, out int restoUnits) ? restoUnits : 0);
                cmd.Parameters.AddWithValue("@PaymentRecieved", decimal.TryParse(payment.Text, out decimal payRecv) ? payRecv : 0);



                cmd.ExecuteNonQuery();


                MessageBox.Show("New harvest record added successfully!", "Success", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void UpdateTotals()
        {
            int csa = string.IsNullOrWhiteSpace(csaunits.Text) ? 0 : int.Parse(csaunits.Text);
            int wholesale = string.IsNullOrWhiteSpace(wholsesale.Text) ? 0 : int.Parse(wholsesale.Text);
            int restaurant = string.IsNullOrWhiteSpace(restounits.Text) ? 0 : int.Parse(restounits.Text);
            int market = string.IsNullOrWhiteSpace(marketunits.Text) ? 0 : int.Parse(marketunits.Text);
            int priceperkg = string.IsNullOrWhiteSpace(priceperKg.Text) ? 0 : int.Parse(priceperKg.Text);


            // Compute total units sold
            int totalUnits = csa + wholesale + market + restaurant;
            priceperKg.Text = priceperkg.ToString();

            // Use PRICE PER KG, not total, to calculate amount
            if (decimal.TryParse(priceperKg.Text, out decimal price))
            {
                decimal totalAmount = totalUnits * priceperkg;
                total.Text = totalAmount.ToString("N2");
            }
            else
            {
                total.Text = "0.00";
            }
        }

        private void csaunits_TextChanged_1(object sender, EventArgs e) => UpdateTotals();

        private void wholsesale_TextChanged_1(object sender, EventArgs e) => UpdateTotals();

        private void restounits_TextChanged_1(object sender, EventArgs e) => UpdateTotals();

        private void marketunits_TextChanged_1(object sender, EventArgs e) => UpdateTotals();

        private void total_TextChanged(object sender, EventArgs e)
        { }

        private void priceperKg_TextChanged(object sender, EventArgs e) => UpdateTotals();
        

        
    }
}

