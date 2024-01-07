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


    public partial class doc_dashboard : UserControl
    {

        public Label welcome_doc_dashboard;
        public Label welcome_doc_patient;
        public Label welcome_doc_prescription;
        public Label welcome_doc_medical_records;
        public doc_dashboard()
        {
            InitializeComponent();
            welcome_doc_dashboard = this.doc_dash_welcome;
            welcome_doc_patient = this.doc_dash_patient;
            welcome_doc_prescription = this.doc_dash_prescription;
            welcome_doc_medical_records = this.doc_dash_med_rec;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void doc_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
