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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace endterm_IM2
{


    public partial class doc_dashboard : UserControl
    {

        public Label welcome_doc_dashboard;
        public Label welcome_doc_patient;
        public Label welcome_doc_prescription;
        public Label welcome_doc_medical_records;
        public int get_doc_id;
        public doc_dashboard()
        {
            InitializeComponent();
            welcome_doc_dashboard = this.doc_dash_welcome;
            welcome_doc_patient = this.doc_dash_patient;
            welcome_doc_prescription = this.doc_dash_prescription;
            
        }

        public void loading()
        {
            DbConnect DoctorCountConnection = new DbConnect();
            DoctorCountConnection.connect();
            string sql = "SELECT COUNT(Pres_ID) FROM prescription";
            MySqlCommand cmd = new MySqlCommand(sql, DoctorCountConnection.conn);
            var doctorcount = cmd.ExecuteScalar();
            this.doc_dash_prescription.Text = doctorcount.ToString();
            DoctorCountConnection.disconnect();
        }

        public void loading2()
        {
            DbConnect PatientCountConnection = new DbConnect();
            PatientCountConnection.connect();
            string sql = "SELECT COUNT(StudentID) FROM students";
            MySqlCommand cmd = new MySqlCommand(sql, PatientCountConnection.conn);
            var patientcount = cmd.ExecuteScalar();
            this.doc_dash_patient.Text = patientcount.ToString();
            PatientCountConnection.disconnect();

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void doc_dashboard_Load(object sender, EventArgs e)
        {
            loading();
            loading2();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
