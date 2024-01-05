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
                    connectionLoginAdmin.conn.Close();
                    this.Hide();
                    Admin admin = new Admin();
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
                        
                        this.Hide();
                        Doctor doctorForm = new Doctor();
                        doctorForm.ShowDialog();
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
