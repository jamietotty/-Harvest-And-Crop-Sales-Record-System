using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harvest_and_Crop_Sales_Record_System
{
    public partial class Staff_Inventory_Monitoring : Form
    {
        public Staff_Inventory_Monitoring()
        {
            InitializeComponent();
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

    }
}
