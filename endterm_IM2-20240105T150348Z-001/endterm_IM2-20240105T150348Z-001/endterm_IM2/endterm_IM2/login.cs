using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endterm_IM2
{

    public partial class login : Form
    {


        public static TextBox username;
        public static TextBox password;
        public login()
        {
            InitializeComponent();
           
            username = txtUsername;
            password = txtPassword;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {


                DbConnect connectionLoginAdmin = new DbConnect();

                connectionLoginAdmin.connect();

                string selectQuery = "SELECT * FROM admin WHERE Username = '" + username.Text + "' AND Password = '" + password.Text + "';";
                MySqlCommand command = new MySqlCommand(selectQuery, connectionLoginAdmin.conn);
                MySqlDataReader mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    connectionLoginAdmin.conn.Close();

                  
                    this.Hide();

                    
                    admin admin = new admin();
                    admin.ShowDialog();
                }
                else
                {
                    mdr.Close();
                    DbConnect connectionLoginDoctor = new DbConnect();
                    string selectQuery2 = "SELECT * FROM doctor WHERE Username = '" + username.Text + "' AND Password = '" + password.Text + "';";
                    MySqlCommand command2 = new MySqlCommand(selectQuery2, connectionLoginAdmin.conn);
                    MySqlDataReader mdr2 = command2.ExecuteReader();
                 

                    if (mdr2.Read())
                    {
                        DbConnect connectionInfoDoctor = new DbConnect();
                        connectionInfoDoctor.connect();
                        string GetQuery3 = "SELECT DoctorID, FirstName,LastName, Address, ContactNumber, Email, Licence_number, Position, Specialization FROM doctor WHERE Username = '" + username.Text + "' AND Password = '" + password.Text + "';";
                        MySqlCommand command3 = new MySqlCommand(GetQuery3, connectionInfoDoctor.conn);
                        MySqlDataReader mdr3 = command3.ExecuteReader();

                        


                        this.Hide();
                        doc_layout_02 doctorForm = new doc_layout_02();

                        if (mdr3.Read())
                        {
                            doctorForm.doc_id = int.Parse(mdr3.GetValue(0).ToString());
                            doctorForm.doc_Fname = mdr3.GetValue(1).ToString();
                            doctorForm.doc_Lname = mdr3.GetValue(2).ToString();
                            doctorForm.doc_Address = mdr3.GetValue(3).ToString();
                            doctorForm.doc_Contact_num = int.Parse(mdr3.GetValue(4).ToString());
                            doctorForm.doc_Email = mdr3.GetValue(5).ToString();
                            doctorForm.doc_Lincence_num = mdr3.GetValue(6).ToString();
                            doctorForm.doc_position = mdr3.GetValue(7).ToString();
                            doctorForm.doc_Specialization = mdr3.GetValue(8).ToString();

                            

                            doctorForm.ShowDialog();

                            
                        }

                       
                       

                        
                    }
                    else
                    {
                        MessageBox.Show("You Are Not Authorized to Log-in", "Error");
                    }



                }
            }


        }
    }
}
