using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endterm_IM2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            admin_dashboard admin_Dashboard = new admin_dashboard();
            admin_Dashboard.TopLevel = false;
            admin_Dashboard.BringToFront();
            panel5.Controls.Add(admin_Dashboard);
            admin_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            admin_dashboard admin_Dashboard = new admin_dashboard();
            admin_Dashboard.TopLevel = false;
            admin_Dashboard.BringToFront();
            panel5.Controls.Add(admin_Dashboard);
            admin_Dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login login = new login();
            login.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            doctor_admin doctor_Admin = new doctor_admin();
            doctor_Admin.TopLevel = false;
            doctor_Admin.BringToFront();
            panel5.Controls.Add(doctor_Admin);
            doctor_Admin.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
