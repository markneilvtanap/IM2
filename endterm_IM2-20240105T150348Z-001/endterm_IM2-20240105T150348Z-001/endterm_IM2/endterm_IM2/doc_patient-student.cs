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
    public partial class ParentName : UserControl
    {
        public TextBox age;
        public string sexx;
        public string yearlevel;
        //   public DateTimePicker stud_birth_date;
        public string birthDate;
        public TextBox stud_ID;
        public TextBox first_Name;
        public TextBox last_Name;
        public TextBox course;
        public TextBox contact_number;
        public TextBox parent_Name;
        public TextBox parent_Contact;
        public TextBox address;
        public TextBox parent_address;


        // public static add_patient_student form1Intance;
        public ParentName()
        {
            InitializeComponent();
            //   form1Intance = this;
           stud_ID = this.stud_id;
            first_Name = this.fName;
            last_Name = this.Lname;
            course = this.courseProgram;
            contact_number = this.contactNum;
            parent_Name = this.parentNames;
            parent_Contact = this.parentContact;
            address = this.stud_Address;
            parent_address = this.parentAddress;
            age = this.studage;
            dateTimePicker2.MinDate = new DateTime(1980, 1, 1);
            dateTimePicker2.MaxDate = new DateTime(2015, 12, 31);
            //   stud_birth_date = dateTimePicker2;
            birthDate = dateTimePicker2.Text;
    }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void add_patient_student_Load(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sexx = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sexx = "Female";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            yearlevel = this.comboBox1.GetItemText(comboBox1.SelectedItem.ToString());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            birthDate = this.dateTimePicker2.Text;
        }
    }
}
