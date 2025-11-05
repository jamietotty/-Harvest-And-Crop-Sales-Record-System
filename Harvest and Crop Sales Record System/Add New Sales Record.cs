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
            LoadHarvestCrops();

        }

        private void LoadHarvestCrops()
        {
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                string query = "SELECT HarvestID, CropName, QuantityKG FROM Harvest_Records WHERE QuantityKG > 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cropName.DataSource = dt;
                cropName.DisplayMember = "CropName"; // what user sees
                cropName.ValueMember = "HarvestID";  // the real ID in DB
                cropName.SelectedIndex = -1; // no default selection
            }
        }

        private void savesales_Click(object sender, EventArgs e)
        {
            if (cropName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a crop.", "Missing Crop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amountSold = 0;
            if (!decimal.TryParse(priceperKg.Text, out amountSold))
            {
                MessageBox.Show("Please enter a valid Amount Sold value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected crop ID
            int selectedHarvestId = Convert.ToInt32(cropName.SelectedValue);

            // Check remaining quantity in Harvest_Records
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                string checkQuery = "SELECT QuantityKG FROM Harvest_Records WHERE HarvestID = @HarvestID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@HarvestID", selectedHarvestId);

                object result = checkCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Selected crop not found in records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal currentStock = Convert.ToDecimal(result);

                // Validation: make sure stock is enough
                if (amountSold > currentStock)
                {
                    MessageBox.Show($"Cannot sell {amountSold} kg — only {currentStock} kg available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceed with insert if stock is sufficient
                string insertQuery = "INSERT INTO Sales_Records (Crop, DateOfSale, Location, AmountSold, TotalAmount, MarketUnits) " +
                                     "VALUES (@Crop, @DateofSale, @Location, @AmountSold, @TotalAmount, @MarketUnits)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Crop", cropName.Text);
                cmd.Parameters.AddWithValue("@DateofSale", dtpDateofSale.Value);
                cmd.Parameters.AddWithValue("@Location", location.Text);
                cmd.Parameters.AddWithValue("@AmountSold", amountSold);
                cmd.Parameters.AddWithValue("@TotalAmount", decimal.TryParse(total.Text, out decimal totalAmt) ? totalAmt : 0);
                cmd.Parameters.AddWithValue("@MarketUnits", int.TryParse(marketunits.Text, out int marketUnits) ? marketUnits : 0);

                cmd.ExecuteNonQuery();

                // Deduct sold quantity from Harvest_Records
                string updateQuery = "UPDATE Harvest_Records SET QuantityKG = QuantityKG - @AmountSold WHERE HarvestID = @HarvestID";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@AmountSold", amountSold);
                updateCmd.Parameters.AddWithValue("@HarvestID", selectedHarvestId);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Sale saved successfully and stock updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void UpdateTotals()
        {
            int market = string.IsNullOrWhiteSpace(marketunits.Text) ? 0 : int.Parse(marketunits.Text);
            int priceperkg = string.IsNullOrWhiteSpace(priceperKg.Text) ? 0 : int.Parse(priceperKg.Text);


            // Compute total units sold
            priceperKg.Text = priceperkg.ToString();

            // Use PRICE PER KG, not total, to calculate amount
            if (decimal.TryParse(priceperKg.Text, out decimal price))
            {
                decimal totalAmount = market * priceperkg;
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

