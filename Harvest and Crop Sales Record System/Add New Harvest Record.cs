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
    public partial class Add_New_Harvest_Record : Form
    {
        string connectionString = @"Server=JMD\JAM;Database=HCSRSdb;Trusted_Connection=True;";


        public string CropName { get; private set; }
        public string Quantity { get; private set; }
        public DateTime HarvestDate { get; private set; }
        public string Location { get; private set; }
        public string Storage { get; private set; }

        public Add_New_Harvest_Record()
        {
            InitializeComponent();
        }

    


        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Harvest_Record_Load(object sender, EventArgs e)
        {
            dtpHarvestDate.Value = DateTime.Now;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveharvest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCropname.Text) || string.IsNullOrWhiteSpace(txtquantity.Text) || string.IsNullOrWhiteSpace(harvestlocation.Text) || string.IsNullOrWhiteSpace(storage.Text))
            {
                MessageBox.Show("Please fill in Crop Name, Quantity, Location and Storage Details.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO harvest_records (CropName, QuantityKG, DateHarvested, Location, StorageDetails) " +
                               "VALUES (@CropName, @QuantityKG, @DateHarvested, @Location, @StorageDetails)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CropName", txtCropname.Text);
                cmd.Parameters.AddWithValue("@QuantityKG", txtquantity.Text);
                cmd.Parameters.AddWithValue("@DateHarvested", dtpHarvestDate.Value);
                cmd.Parameters.AddWithValue("@Location", harvestlocation.Text);
                cmd.Parameters.AddWithValue("@StorageDetails", storage.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("New harvest record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }


    }
}
