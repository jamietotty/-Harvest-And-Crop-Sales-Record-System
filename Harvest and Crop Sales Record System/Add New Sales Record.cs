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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_Sales_Record_Load(object sender, EventArgs e)
        {
            dtpDateofSale.Value = DateTime.Now;

        }

       

        private void savesales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCropname.Text) || string.IsNullOrWhiteSpace(total.Text) || string.IsNullOrWhiteSpace(location.Text) || string.IsNullOrWhiteSpace(AmountSold.Text))
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
                cmd.Parameters.AddWithValue("@DateOfSale", dtpDateofSale.Value);
                cmd.Parameters.AddWithValue("@Location", AmountSold.Text);
                cmd.Parameters.AddWithValue("@AmountSold", total.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", wholsesale.Text);
                cmd.Parameters.AddWithValue("@CSAunits", csaunits.Text);
                cmd.Parameters.AddWithValue("@MarketUnits", marketunits.Text);
                cmd.Parameters.AddWithValue("@WholesaleUnits", wholsesale.Text);
                cmd.Parameters.AddWithValue("@RestaurantUnits", restounits.Text);
                cmd.Parameters.AddWithValue("@PaymentRecieved", payment.Text);



                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("New harvest record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
