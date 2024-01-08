using MySql.Data.MySqlClient;
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
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }

        public void loading()
        {
            DbConnect DoctorCountConnection = new DbConnect();
            DoctorCountConnection.connect();
            string sql =  "SELECT COUNT(DoctorID) FROM doctor";
            MySqlCommand cmd = new MySqlCommand(sql, DoctorCountConnection.conn);
            var doctorcount = cmd.ExecuteScalar();
            this.Doctor_count.Text = doctorcount.ToString();
            DoctorCountConnection.disconnect();
        }

        public void loading2()
        {
            DbConnect PatientCountConnection = new DbConnect();
            PatientCountConnection.connect();
            string sql = "SELECT COUNT(StudentID) FROM students";
            MySqlCommand cmd = new MySqlCommand(sql, PatientCountConnection.conn);
            var patientcount = cmd.ExecuteScalar();
            this.Patient_cd.Text = patientcount.ToString();
            PatientCountConnection.disconnect();

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            loading();
            loading2();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
