using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endterm_IM2
{
    public partial class doctor_admin : Form
    {
        public int doc_id;
        public string sex;
        public doctor_admin()
        {
            InitializeComponent();

            loading();
        }

        public void loading()
        {
            DbConnect addingConnection = new DbConnect();
            addingConnection.connect();
            string sql = "SELECT * FROM doctor";
            MySqlCommand cmd = new MySqlCommand(sql, addingConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.Doc_datagridView.DataSource = dt;
        }




        private void doctor_admin_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Doc_add_Click(object sender, EventArgs e)
        {
           // this.Doc_Fname.Enabled = true;
           // this.Doc_LName.Enabled = true;
            //this.Doc_age.Enabled = true;
          //  this.Doc_sex.Enabled = true;
           // this.dateTimePicker1.Enabled = true;
          //  this.Doc_address.Enabled = true;
          //  this.Doc_email.Enabled = true;
          //  this.Doc_position.Enabled = true;
          //  this.Doc_specialization.Enabled = true;
          //  this.Doc_experience.Enabled = true;
          //  this.Doc_username.Enabled = true;
          
            this.doc_pass.Enabled = true;
            int docAge = int.Parse(this.Doc_age.Text);
            int docNum = int.Parse(this.Doc_contact_no.Text);

            DbConnect connectionadding = new DbConnect();
            connectionadding.connect();

            string sqlAdding = "INSERT INTO `doctor` (`DoctorID`, `FirstName`, `LastName`, `Age`, `Sex`, `DateOfBirth`, `Address`, `ContactNumber`, `Email`, `Position`, `Specialization`, `Experience`, `Username`, `Password`) VALUES (NULL, '" + this.Doc_Fname.Text + "', '" + this.Doc_LName.Text + "', '" + docAge + "', '" + this.sex + "', '" + this.dateTimePicker1.Text + "', '" + this.Doc_address.Text + "', '" + docNum + "', '" + this.Doc_email.Text + "', '" + this.Doc_position.Text + "', '" + this.Doc_specialization.Text + "', '" + this.Doc_experience.Text + "', '" + this.Doc_username.Text + "', '" + this.doc_pass.Text + "');";
            MySqlCommand cmdAdding = new MySqlCommand(sqlAdding, connectionadding.conn);
            MySqlDataReader reader = cmdAdding.ExecuteReader();

            this.Doc_Fname.Text = "";
            this.Doc_LName.Text = "";
            this.Doc_age.Text = "";
            this.Doc_address.Text = "";
            this.Doc_contact_no.Text = "";
            this.Doc_email.Text = "";
            this.Doc_position.Text = "";
            this.Doc_specialization.Text = "";
            this.Doc_experience.Text = "";
            this.Doc_username.Text = "";
            this.doc_pass.Text = "";

            MessageBox.Show("RECORD HAS BEEN ADDED!", "Error");
            loading();
            connectionadding.disconnect();

        }

        private void Doc_cancel_Click(object sender, EventArgs e)
        {
          //  this.Doc_Fname.Enabled = false;
          //  this.Doc_LName.Enabled = false;
         //   this.Doc_age.Enabled = false;
          //  this.Doc_sex.Enabled = false;
          //  this.dateTimePicker1.Enabled = false;
          //  this.Doc_address.Enabled = false;
          //  this.Doc_email.Enabled = false;
           // this.Doc_position.Enabled = false;
           // this.Doc_specialization.Enabled = false;
           // this.Doc_experience.Enabled = false;
          //  this.Doc_username.Enabled = false;
          //  this.doc_pass.Enabled = false;

            this.Doc_Fname.Text = "";
            this.Doc_LName.Text = "";
            this.Doc_age.Text = "";
            this.Doc_address.Text = "";
            this.Doc_contact_no.Text = "";
            this.Doc_email.Text = "";
            this.Doc_position.Text = "";
            this.Doc_specialization.Text = "";
            this.Doc_experience.Text = "";
            this.Doc_username.Text = "";
            this.doc_pass.Text = "";
        }

        private void Doc_datagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Doc_datagridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             doc_id = int.Parse(this.Doc_datagridView.SelectedRows[0].Cells[0].Value.ToString());
            this.Doc_Fname.Text = this.Doc_datagridView.SelectedRows[0].Cells[1].Value.ToString(); 
            this.Doc_LName.Text = this.Doc_datagridView.SelectedRows[0].Cells[2].Value.ToString();
            this.Doc_age.Text = this.Doc_datagridView.SelectedRows[0].Cells[3].Value.ToString();
            if (this.Doc_datagridView.SelectedRows[0].Cells[4].Value.ToString() == "Male")
            {
                this.radioButton1.Checked = true;
            }else if (this.Doc_datagridView.SelectedRows[0].Cells[4].Value.ToString() == "Female")
            {

                this.radioButton2.Checked = true;
            }
          
            this.Doc_address.Text = this.Doc_datagridView.SelectedRows[0].Cells[6].Value.ToString();
            this.Doc_contact_no.Text = this.Doc_datagridView.SelectedRows[0].Cells[7].Value.ToString();
            this.Doc_email.Text = this.Doc_datagridView.SelectedRows[0].Cells[8].Value.ToString();
            this.Doc_position.Text = this.Doc_datagridView.SelectedRows[0].Cells[9].Value.ToString();
            this.Doc_specialization.Text = this.Doc_datagridView.SelectedRows[0].Cells[10].Value.ToString(); 
            this.Doc_experience.Text = this.Doc_datagridView.SelectedRows[0].Cells[11].Value.ToString(); 
            this.Doc_username.Text = this.Doc_datagridView.SelectedRows[0].Cells[12].Value.ToString();
            this.doc_pass.Text = this.Doc_datagridView.SelectedRows[0].Cells[13].Value.ToString();
            
        }

        private void Doc_edit_Click(object sender, EventArgs e)
        {

            int docAge = int.Parse(this.Doc_age.Text);
            int docNum = int.Parse(this.Doc_contact_no.Text);

            DbConnect connectionUpdate = new DbConnect();
            connectionUpdate.connect();
            string sqlUpdate = "UPDATE `doctor` SET FirstName = '" + this.Doc_Fname.Text + "', LastName = '" + this.Doc_LName.Text + "', Age = '" + docAge + "', Sex = '" + sex + "', DateOfBirth = '" + this.dateTimePicker1.Text + "', Address = '" + this.Doc_address.Text + "', ContactNumber = '" + docNum + "', Email='" + this.Doc_email.Text + "', Position= '" + this.Doc_position.Text + "', Specialization = '" + Doc_specialization.Text + "', Experience= '" + this.Doc_experience.Text + "', Username= '" + this.Doc_username.Text + "' , Password= '" + this.doc_pass.Text + "' WHERE DoctorID = '"+doc_id +"'";
            MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, connectionUpdate.conn);
            MySqlDataReader reader = cmdUpdate.ExecuteReader();
            MessageBox.Show("RECORD HAS BEEN UPDATED!", "Error");
            loading();
            connectionUpdate.disconnect();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Female";
        }

        private void Doc_delete_Click(object sender, EventArgs e)
        {

            //  this.Doc_Fname.Enabled = false;
            //  this.Doc_LName.Enabled = false;
            //   this.Doc_age.Enabled = false;
            //  this.Doc_sex.Enabled = false;
            //  this.dateTimePicker1.Enabled = false;
            //  this.Doc_address.Enabled = false;
            //  this.Doc_email.Enabled = false;
            // this.Doc_position.Enabled = false;
            // this.Doc_specialization.Enabled = false;
            // this.Doc_experience.Enabled = false;
            //  this.Doc_username.Enabled = false;
            //  this.doc_pass.Enabled = false;
            DbConnect connectionDelete = new DbConnect();
            connectionDelete.connect();
            string sqlDelete = "DELETE FROM doctor WHERE DoctorID = '" + doc_id + "'";
            MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, connectionDelete.conn);
            MySqlDataReader reader = cmdDelete.ExecuteReader();
            MessageBox.Show("RECORD HAS BEEN DELETED!", "Error");
            loading();
            connectionDelete.disconnect();
        }

        private void Doc_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Doc_contact_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doc_contact_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
