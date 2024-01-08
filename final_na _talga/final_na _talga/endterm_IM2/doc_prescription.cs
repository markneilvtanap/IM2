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
        public TextBox age;
        public TextBox sex;
        // no need
        public TextBox course;
        public TextBox yearlevel;
      
        // no need

        public TextBox med;
        public TextBox med_dosages;
        public TextBox med_takee;
        public TextBox diagnosis;
        public TextBox treatment;
        public string stud_address;
        public string doc_Fname;
        public string doc_Lname;
        public string Visit_date;
        public string doc_name;


        public int get_phyc_id;
        public int get_med_rec_id;
        public int get_doc_id;

        public doc_prescription()
        {
            InitializeComponent();
           
            stud_id = this.textbox_stud_id;
            fname = this.textbox_fName;
            lname = this.textbox_Lname;
            sex = this.textbox_sex;
            age = this.textbox_studage;

            med = this.textbox_medicine;
            med_dosages = this.textbox_med_dosage;
            med_takee = this.textbox_med_take;
            diagnosis = this.textbox_diagnosis;
            treatment = this.textbox_treatment;

            // no need
            course = this.textbox_courseProgram;
            yearlevel = this.textbox_yearlevel;
           
         //   bd = this.textbox_bod;
        }

        private void courseProgram_TextChanged(object sender, EventArgs e)
        {

        }

        private void studage_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textbox_studage.Text, "^[0-9]+$"))
            {
                textbox_studage.Text = "";
            }
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
            string sql = "SELECT students.StudentID, students.FirstName, students.LastName, students.program_course, students.Year_Level, students.Sex, students.Age, physical.Physical_id, medical_records.Med_rec_ID, doctor.DoctorID, students.Address, doctor.FirstName, doctor.LastName, prescription.Visit_Date FROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON medical_records.Physical_id = physical.Physical_id JOIN doctor ON doctor.DoctorID = medical_records.Doctor_id JOIN prescription ON prescription.Doctor_id = doctor.DoctorID;";
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
            this.textbox_courseProgram.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.textbox_yearlevel.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            this.textbox_sex.Text = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            this.textbox_studage.Text = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
           // this.textbox_bod.Text = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            get_phyc_id =  int.Parse(this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            get_med_rec_id = int.Parse(this.dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            get_doc_id = int.Parse(this.dataGridView1.SelectedRows[0].Cells[9].Value.ToString());

            stud_address = this.dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            doc_Fname = this.dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            doc_Lname = this.dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            Visit_date = this.dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            
            doc_name = doc_Fname + " " + doc_Lname;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DbConnect search = new DbConnect();
            search.connect();


            string sql = "SELECT * FROM students WHERE Firstname LIKE @search OR Age LIKE @search OR Sex LIKE @search";
            MySqlCommand cmd = new MySqlCommand(sql, search.conn);
            cmd.Parameters.AddWithValue("@search", this.textBox1.Text + "%");
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            search.disconnect();
        }
    }
}
