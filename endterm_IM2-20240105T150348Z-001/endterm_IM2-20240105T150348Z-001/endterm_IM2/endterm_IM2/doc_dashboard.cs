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

            DbConnect addPatientConnection = new DbConnect();
            addPatientConnection.connect();
            string sql = "SELECT COUNT(students.StudentID) FROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON  medical_records.Physical_id = physical.Physical_id JOIN doctor ON doctor.DoctorID = medical_records.Doctor_id WHERE doctor.DoctorID = '"+get_doc_id+"';";
            MySqlCommand cmd = new MySqlCommand(sql, addPatientConnection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            addPatientConnection.disconnect();
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void doc_dashboard_Load(object sender, EventArgs e)
        {
            loading();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
