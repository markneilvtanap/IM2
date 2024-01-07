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

    
    public partial class doc_prescription : UserControl
    {
        public TextBox stud_id;
        public TextBox fname;
        public TextBox lname;
        public TextBox course;
        public TextBox yearlevel;
        public TextBox sex;
        public TextBox age;
        public TextBox bd;

        public doc_prescription()
        {
            InitializeComponent();
            loading();
            stud_id = this.textbox_stud_id;
            fname = this.textbox_fName;
            lname = this.textbox_Lname;
            course = this.textbox_courseProgram;
            yearlevel = this.textbox_yearlevel;
            sex = this.textbox_sex;
            age = this.textbox_studage;
            bd = this.textbox_bod;
        }

        private void courseProgram_TextChanged(object sender, EventArgs e)
        {

        }

        private void studage_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void parentAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void parentContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void parentNames_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void studagesss_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stud_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }

        private void stud_id_TextChanged(object sender, EventArgs e)
        {

        }

        public void loading()
        {
            DbConnect addingConnection = new DbConnect();
            addingConnection.connect();
            string sql = "SELECT * FROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON medical_records.Physical_id = physical.Physical_id JOIN doctor ON doctor.DoctorID = medical_records.Doctor_id;";
            MySqlCommand cmd = new MySqlCommand(sql, addingConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

        }
        private void doc_prescription_Load(object sender, EventArgs e)
        {
           
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           //  = int.Parse(this.Doc_datagridView.SelectedRows[0].Cells[0].Value.ToString());
         //   this.Doc_Fname.Text = this.Doc_datagridView.SelectedRows[0].Cells[1].Value.ToString();

           

             this.textbox_stud_id.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.textbox_fName.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textbox_Lname.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.textbox_courseProgram.Text = this.dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            this.textbox_yearlevel.Text = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            this.textbox_sex.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            this.textbox_studage.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.textbox_bod.Text = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString(); ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
