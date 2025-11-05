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
    public partial class Staff_Dashboard : Form
    {
        public Staff_Dashboard()
        {
            InitializeComponent();
        }

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
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
