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
using System.Runtime.Remoting.Messaging;

namespace endterm_IM2
{
    public partial class doc_layout_02 : Form
    {
        //doctor info
        public int doc_id;
        public String doc_Fname;
        public String doc_Lname;
        public String doc_Address;
        public int doc_Contact_num;
        public String doc_position;
        public String doc_Specialization;
        public String doc_Lincence_num;
        public String doc_Email;


        // for student personal Info form
        public bool personal_tochange = false;
        // for physical info form
        public bool physical_tochange = false;
        //for question1 form
        public bool questions1_tochange = false;
        //for question1 form
        public bool questions2_tochange = false;

        // Personal Info form

        public string stud_Id;
        public string previous_id_personal;
        public string Fname;
        public string Lname;
        public int age;
        public string course;
        public long contact_num;
        public string parent_name;
        public long parent_contact;
        public string stud_address;
        public string parent_add;
        public string sex;
        public string yearlevel;
        public string stud_birth_date;

        // Physical info
        public int incrementing_physical_id = 0;
        public int physical_id;
        public int previous_id_physical;
        public double stud_height;
        public double stud_weight;
        public string stud_blood_pressure;
        public double stud_heart_rate;
        public double stud_temperature;

        // question 1 info 
        public int incrementing_ques1_id = 0;
        public int ques1_id;
        public int previous_id_ques1;
        public string stud_med_history;
        public string stud_med_allergies;
        public string stud_medications;
        public string stud_family_his1;
        public string stud_family_his2;
        public string stud_chronic_con;

        // question 2 info
        public int ques2_id;
        public string stud_syntoms1;
        public string stud_syntoms2;
        public string stud_lifestyle;
        public string stud_habits;
        public string stud_mental;
        public string stud_mental2;
        public string stud_vaccine;
        //

        // precription
        public int incremental_pres_id;
        public int pres_id;


        //manage
        public bool manage_toChange = false;
        public string manage_id;
        public doc_layout_02()
        {
            InitializeComponent();
            doc_prescription1.get_doc_id = doc_id;
            doc_dashboard1.get_doc_id = doc_id;
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login login = new login();
            login.ShowDialog();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            login login = new login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manage_toChange = false;
            //   doc_dashboard1.Hide();
            //   add_patient_student1.Show();
            //   add_patient_student1.BringToFront();


            // displaying the add/Patient A.K.A for student personal Info form
            doc_manage_patient1.Hide(); 
            add_patient_student1.Show();
            add_patient_student1.BringToFront();


            button_dashboard.BackColor = Color.White;

            //disabling the back button and showing the button for student personal Info form, onward etc
            this.button_back.Enabled = false;
            this.button_back.Text = "UNBACKABLE";
            this.button_next.Text = "NEXT";
            this.button_submit.Text = "SUBMIT";
            add_patient_student1.first_Name.Clear();
            add_patient_student1.last_Name.Clear();
            add_patient_student1.stud_ID.Clear();
            add_patient_student1.course.Clear();
           add_patient_student1.age.Clear();
            add_patient_student1.contact_number.Clear();
            add_patient_student1.address.Clear();
            add_patient_student1.parent_Name.Clear();
            add_patient_student1.parent_Contact.Clear();
            add_patient_student1.parent_address.Clear();
            button_next.Enabled = true;
            this.button_back.Visible = true;
            this.button_next.Visible = true;
            this.button_submit.Visible = true;
            this.button_submit.Enabled = false;
           this.buttonGenerateInvoice.Visible = false;

            
   
            //changing for color button
            add_patient.BackColor = Color.Gold;
            manage_patient.BackColor = Color.White;
            button_prescription.BackColor = Color.White;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //changing for color button
            manage_patient.BackColor = Color.Gold;
            add_patient.BackColor = Color.White;
            button_prescription.BackColor = Color.White;
            button_dashboard.BackColor = Color.White;

            doc_manage_patient1.Show();
            doc_manage_patient1.BringToFront();

            button_back.Enabled= true;
            button_back.Visible= true;
            button_back.Text = "Edit";
            button_submit.Visible= true;
            button_submit.Enabled = true;
            button_next.Text = "Delete";
            button_next.Visible = true;



            button_submit.Visible = false;
            buttonGenerateInvoice.Visible = false;

            manage_id = doc_manage_patient1.manage_stud_id;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //changing for color button
            button_dashboard.BackColor= Color.White;
            button_prescription.BackColor = Color.Gold;
            add_patient.BackColor = Color.White;
            manage_patient.BackColor = Color.White;



            buttonGenerateInvoice.Visible = true;

            //here
            this.buttonGenerateInvoice.Text = "SAVE";
            
            button_back.Text = "Show Physical Info";
            button_next.Text = "Show Question1 Info";
            button_submit.Text = "Show Question2 Info";


            button_back.Visible = true; 
            button_back.Enabled = true;
            button_next.Enabled = true;
            button_submit.Enabled = true;
            button_next.Visible=true;
            button_submit.Visible=true;
            doc_prescription1.stud_id.Enabled = false;
            doc_prescription1.course.Enabled = false;
            doc_prescription1.fname.Enabled = false;
            doc_prescription1.lname.Enabled = false;
            doc_prescription1.sex.Enabled = false;
            doc_prescription1.age.Enabled = false;
            doc_prescription1.yearlevel.Enabled = false;
        //    doc_prescription1.bd.Enabled = false;   
        doc_manage_patient1.Hide();
            doc_prescription1.Show();
            doc_prescription1.BringToFront();
            doc_prescription1.loading();
           

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            //changing for color button
            doc_dashboard1.welcome_doc_dashboard.Text = "WELCOME DOC, " + doc_Fname;
            
            button_dashboard.BackColor = Color.Gold;
            this.button_back.Visible = false;
            this.button_next.Visible = false;
            this.button_submit.Visible = false;
            this.buttonGenerateInvoice.Visible = false;
            doc_dashboard1.get_doc_id = doc_id;


            //displaying the doctor dashboard form A.K.A doc_dashboard form
            doc_manage_patient1.Hide();
            doc_dashboard1.Show();
            doc_dashboard1.BringToFront();

            //for getting latest physical id
         

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button_back.Visible = false;
            this.button_next.Visible = false;
            this.button_submit.Visible = false;
            this.buttonGenerateInvoice.Visible = false;


            //     add_patient_student1.Hide();
            //     doc_dashboard1.Show();
            //   doc_dashboard1.BringToFront();
            //     doc_panel.Controls.Clear();
            //     doc_Dashboard.TopLevel = false;
            //     doc_Dashboard.BringToFront();
            //     doc_panel.Controls.Add(doc_Dashboard);
            //    doc_Dashboard.Show();
            add_patient.BackColor = Color.White;
           button_dashboard.BackColor = Color.Gold;
            manage_patient.BackColor = Color.White;
            button_prescription.BackColor = Color.White;

            doc_dashboard1.Show();
            doc_dashboard1.BringToFront();
        }

        private void doc_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            //start for manage
            if (this.button_next.Text == "NEXT" &&  manage_toChange == true)
            {


                button_back.Enabled = true;
                stud_Id = add_patient_student1.stud_ID.Text;
                Fname = add_patient_student1.first_Name.Text;
                Lname = add_patient_student1.last_Name.Text;
                age = int.Parse(add_patient_student1.age.Text);
                course = add_patient_student1.course.Text;
                contact_num = long.Parse(add_patient_student1.contact_number.Text);
                parent_name = add_patient_student1.parent_Name.Text;
                parent_contact = long.Parse(add_patient_student1.parent_Contact.Text);
                stud_address = add_patient_student1.address.Text;
                parent_add = add_patient_student1.parent_address.Text;
                sex = add_patient_student1.sexx;
                yearlevel = add_patient_student1.yearlevel;
                stud_birth_date = add_patient_student1.birthDate;

                //    DateTimePicker stud_birth_date = add_patient_student1.stud_birth_date;

                if (personal_tochange == false && manage_toChange == true)
                {
                    DbConnect ManageupdatePatientConnection = new DbConnect();
                    ManageupdatePatientConnection.connect();

                    string sqlManagepersonal = "UPDATE `students` SET `StudentID` = '" + stud_Id + "', `FirstName` = '" + Fname + "', `LastName` = '" + Lname + "', `Age` = '" + age + "', `Sex` = '" + sex + "', `DateOfBirth` = '" + stud_birth_date + "', `Year_Level` = '" + yearlevel + "', `Contact_number` = '" + contact_num + "', `Address` = '" + stud_address + "', `program_course` = '" + course + "', `Emer_ContactName` = '" + parent_name + "', `Emer_ContactNum` = '" + parent_contact + "', `emerContactAddress` = '" + parent_add + "' WHERE `students`.`StudentID` = '" + doc_manage_patient1.manage_stud_id + "'";
                    MySqlCommand cmdmanage = new MySqlCommand(sqlManagepersonal, ManageupdatePatientConnection.conn);
                    MySqlDataReader reader = cmdmanage.ExecuteReader();
                    ManageupdatePatientConnection.disconnect();

                    doc_dashboard1.Hide();
                    add_patient_student1.Hide();
                    patient_student_physical1.Show();
                    patient_student_physical1.BringToFront();
                    patient_student_physical1.Height.Clear();
                    patient_student_physical1.Weight.Clear();
                    patient_student_physical1.Heart_rate.Clear();
                    patient_student_physical1.Blood_pressure.Clear();
                    patient_student_physical1.Body_temperature.Clear();
                    button_next.Text = "NEXT TO QUESTION";
                    button_back.Text = "BACK TO PERSONAL";
                }
                else
                {
                    doc_dashboard1.Hide();
                    add_patient_student1.Hide();
                    patient_student_physical1.Show();
                    patient_student_physical1.BringToFront();
                    button_next.Text = "NEXT TO QUESTION";
                    button_back.Text = "BACK TO PERSONAL";
                }




                //    patient_student_physical1.txtHeight.Text = add_patient_student1.stud_ID.Text;


                //     this.doc_Patient_physical.TopLevel = false;
                //   doc_panel.Controls.Add(doc_Patient_physical);

                //         add_patient_student1.Hide() ;
                //     patient_student_physical1.Show();
                //    patient_student_physical1.BringToFront();
                //     this.doc_Patient_physical.Hide();
                //     this.doc_Patient_physical.BringToFront();
                //   
                //      this.doc_Patient_physical.Show();

            }

            // end for manage

            //start for non manage
            else if (this.button_next.Text == "NEXT")
            {


                button_back.Enabled = true;
                stud_Id = add_patient_student1.stud_ID.Text;
                Fname = add_patient_student1.first_Name.Text;
                Lname = add_patient_student1.last_Name.Text;
                age = int.Parse(add_patient_student1.age.Text);
                course = add_patient_student1.course.Text;
                contact_num = long.Parse(add_patient_student1.contact_number.Text);
                parent_name = add_patient_student1.parent_Name.Text;
                parent_contact = long.Parse(add_patient_student1.parent_Contact.Text);
                stud_address = add_patient_student1.address.Text;
                parent_add = add_patient_student1.parent_address.Text;
                sex = add_patient_student1.sexx;
                yearlevel = add_patient_student1.yearlevel;
                stud_birth_date = add_patient_student1.birthDate;

                //    DateTimePicker stud_birth_date = add_patient_student1.stud_birth_date;

                if (personal_tochange == false)
                {
                    DbConnect addPatientConnection = new DbConnect();
                    addPatientConnection.connect();

                    string sql = "INSERT INTO students  VALUES('" + stud_Id + "', '" + Fname + "', '" + Lname + "', '" + age + "' , '" + sex + "', '" + stud_birth_date + "', '" + yearlevel + "', '" + contact_num + "', '" + stud_address + "', '" + course + "', '" + parent_name + "', '" + parent_contact + "', '" + parent_add + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, addPatientConnection.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    addPatientConnection.disconnect();

                    doc_dashboard1.Hide();
                    add_patient_student1.Hide();
                    patient_student_physical1.Show();
                    patient_student_physical1.BringToFront();
                    patient_student_physical1.Height.Clear();
                    patient_student_physical1.Weight.Clear();
                    patient_student_physical1.Heart_rate.Clear();
                    patient_student_physical1.Blood_pressure.Clear();
                    patient_student_physical1.Body_temperature.Clear();
                    button_next.Text = "NEXT TO QUESTION";
                    button_back.Text = "BACK TO PERSONAL";
                }
                else
                {
                    doc_dashboard1.Hide();
                    add_patient_student1.Hide();
                    patient_student_physical1.Show();
                    patient_student_physical1.BringToFront();
                    button_next.Text = "NEXT TO QUESTION";
                    button_back.Text = "BACK TO PERSONAL";
                }




                //    patient_student_physical1.txtHeight.Text = add_patient_student1.stud_ID.Text;


                //     this.doc_Patient_physical.TopLevel = false;
                //   doc_panel.Controls.Add(doc_Patient_physical);

                //         add_patient_student1.Hide() ;
                //     patient_student_physical1.Show();
                //    patient_student_physical1.BringToFront();
                //     this.doc_Patient_physical.Hide();
                //     this.doc_Patient_physical.BringToFront();
                //   
                //      this.doc_Patient_physical.Show();

            }

            // end non- manage


            //start for manage
            else if (this.button_next.Text == "UPDATE PERSONAL"   && manage_toChange == true)

            {

                stud_Id = add_patient_student1.stud_ID.Text;
                Fname = add_patient_student1.first_Name.Text;
                Lname = add_patient_student1.last_Name.Text;
                age = int.Parse(add_patient_student1.age.Text);
                course = add_patient_student1.course.Text;
                contact_num = long.Parse(add_patient_student1.contact_number.Text);
                parent_name = add_patient_student1.parent_Name.Text;
                parent_contact = long.Parse(add_patient_student1.parent_Contact.Text);
                stud_address = add_patient_student1.address.Text;
                parent_add = add_patient_student1.parent_address.Text;
                sex = add_patient_student1.sexx;
                yearlevel = add_patient_student1.yearlevel;
                DbConnect updatePatientConnection = new DbConnect();
                updatePatientConnection.connect();
                // string sql = "UPDATE `students` SET  `FirstName` =  , `LastName` = , `Age` =  , `Sex` =, `DateOfBirth` =, `Year_Level` =                                                    , `Contact_number` = , `Address` = , `program/course` = , `Emer_ContactName` =                                   , `Emer_ContactNum` = , `emerContactAddress` =  WHERE `StudentID` = `" + previous_id_personal + "'";
                string sql = "UPDATE `students` SET `StudentID` = '" + stud_Id + "', `FirstName` = '" + Fname + "', `LastName` = '" + Lname + "', `Age` = '" + age + "', `Sex` = '" + sex + "', `DateOfBirth` = '" + stud_birth_date + "', `Year_Level` = '" + yearlevel + "', `Contact_number` = '" + contact_num + "', `Address` = '" + stud_address + "', `program_course` = '" + course + "', `Emer_ContactName` = '" + parent_name + "', `Emer_ContactNum` = '" + parent_contact + "', `emerContactAddress` = '" + parent_add + "' WHERE `students`.`StudentID` = '" + doc_manage_patient1.manage_stud_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updatePatientConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                updatePatientConnection.disconnect();
                button_next.Text = "NEXT";


            }
            //end for manage


            //start for non-manage
            else if (this.button_next.Text == "UPDATE PERSONAL" )

            {

                stud_Id = add_patient_student1.stud_ID.Text;
                Fname = add_patient_student1.first_Name.Text;
                Lname = add_patient_student1.last_Name.Text;
                age = int.Parse(add_patient_student1.age.Text);
                course = add_patient_student1.course.Text;
                contact_num = long.Parse(add_patient_student1.contact_number.Text);
                parent_name = add_patient_student1.parent_Name.Text;
                parent_contact = long.Parse(add_patient_student1.parent_Contact.Text);
                stud_address = add_patient_student1.address.Text;
                parent_add = add_patient_student1.parent_address.Text;
                sex = add_patient_student1.sexx;
                yearlevel = add_patient_student1.yearlevel;
                DbConnect updatePatientConnection = new DbConnect();
                updatePatientConnection.connect();
                // string sql = "UPDATE `students` SET  `FirstName` =  , `LastName` = , `Age` =  , `Sex` =, `DateOfBirth` =, `Year_Level` =                                                    , `Contact_number` = , `Address` = , `program/course` = , `Emer_ContactName` =                                   , `Emer_ContactNum` = , `emerContactAddress` =  WHERE `StudentID` = `" + previous_id_personal + "'";
                string sql = "UPDATE `students` SET `StudentID` = '" + stud_Id + "', `FirstName` = '" + Fname + "', `LastName` = '" + Lname + "', `Age` = '" + age + "', `Sex` = '" + sex + "', `DateOfBirth` = '" + stud_birth_date + "', `Year_Level` = '" + yearlevel + "', `Contact_number` = '" + contact_num + "', `Address` = '" + stud_address + "', `program_course` = '" + course + "', `Emer_ContactName` = '" + parent_name + "', `Emer_ContactNum` = '" + parent_contact + "', `emerContactAddress` = '" + parent_add + "' WHERE `students`.`StudentID` = '" + previous_id_personal + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updatePatientConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                updatePatientConnection.disconnect();
                button_next.Text = "NEXT";


            }
            //end for non-manage

            //start for manage

            else if (button_next.Text == "NEXT TO QUESTION" && manage_toChange == true)
            {

                if (physical_tochange == false && manage_toChange == true)
                {
                    DbConnect getLatestPhysicalConnection = new DbConnect();
                    getLatestPhysicalConnection.connect();
                    string sqlphysical = "SELECT  Physical_id FROM physical ORDER BY Physical_id DESC";
                    MySqlCommand cmd2 = new MySqlCommand(sqlphysical, getLatestPhysicalConnection.conn);
                    MySqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        incrementing_physical_id = int.Parse(reader.GetValue(0).ToString());
                    }
                    getLatestPhysicalConnection.disconnect();
                    incrementing_physical_id++;
                    physical_id = incrementing_physical_id;
                    stud_height = double.Parse(patient_student_physical1.Height.Text);
                    stud_weight = double.Parse(patient_student_physical1.Weight.Text);
                    stud_heart_rate = double.Parse(patient_student_physical1.Heart_rate.Text);
                    stud_blood_pressure = patient_student_physical1.Blood_pressure.Text;
                    stud_temperature = double.Parse(patient_student_physical1.Body_temperature.Text);

                    DbConnect addPhysicalConnection = new DbConnect();
                    addPhysicalConnection.connect();
                    string sql = "UPDATE `physical` SET `StudentID` = '" + stud_Id + "', `Height` = '" + stud_height + "', `Weight` = '" + stud_weight + "', `Heart_Rate` = '" + stud_heart_rate + "', `Blood_Pressure` = '" + stud_blood_pressure + "', `Body_Temperature` = '" + stud_temperature + "' WHERE `physical`.`Physical_id` = '" + doc_manage_patient1.manage_phy_id + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, addPhysicalConnection.conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    addPhysicalConnection.disconnect();
                      incrementing_physical_id = physical_id;
                    doc_patient_student_ques1.Show();
                    doc_patient_student_ques1.BringToFront();
                    doc_patient_student_ques1.medHistory.Clear();
                    doc_patient_student_ques1.famhis1.Clear();
                    doc_patient_student_ques1.famhis2.Clear();
                    doc_patient_student_ques1.chronicCon.Clear();
                    doc_patient_student_ques1.medicationsx.Clear();
                    doc_patient_student_ques1.suplimenets.Clear();
                    button_next.Text = "NEXT TO QUESTION 2";
                    button_back.Text = "BACK TO PHYSICAL";
                }
                else
                {

                    doc_patient_student_ques1.Show();
                    doc_patient_student_ques1.BringToFront();
                    button_next.Text = "NEXT TO QUESTION 2";
                    button_back.Text = "BACK TO PHYSICAL";
                }

            }


            // for non- manage
            else if (button_next.Text == "NEXT TO QUESTION")
            {

                if (physical_tochange == false)
                {
                    DbConnect getLatestPhysicalConnection = new DbConnect();
                    getLatestPhysicalConnection.connect();
                    string sqlphysical = "SELECT  Physical_id FROM physical ORDER BY Physical_id DESC";
                    MySqlCommand cmd2 = new MySqlCommand(sqlphysical, getLatestPhysicalConnection.conn);
                    MySqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        incrementing_physical_id = int.Parse(reader.GetValue(0).ToString());
                    }
                    getLatestPhysicalConnection.disconnect();
                    incrementing_physical_id++;
                    physical_id = incrementing_physical_id;
                    stud_height = double.Parse(patient_student_physical1.Height.Text);
                    stud_weight = double.Parse(patient_student_physical1.Weight.Text);
                    stud_heart_rate = double.Parse(patient_student_physical1.Heart_rate.Text);
                    stud_blood_pressure = patient_student_physical1.Blood_pressure.Text;
                    stud_temperature = double.Parse(patient_student_physical1.Body_temperature.Text);

                    DbConnect addPhysicalConnection = new DbConnect();
                    addPhysicalConnection.connect();
                    string sql = "INSERT INTO `physical` (`Physical_id`, `StudentID`, `Height`, `Weight`, `Heart_Rate`, `Blood_Pressure`, `Body_Temperature`) VALUES ('" + physical_id + "', '" + stud_Id + "' ,'" + stud_height + "', '" + stud_weight + "', '" + stud_heart_rate + "', '" + stud_blood_pressure + "', '" + stud_temperature + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, addPhysicalConnection.conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    addPhysicalConnection.disconnect();
                    incrementing_physical_id = physical_id;
                    doc_patient_student_ques1.Show();
                    doc_patient_student_ques1.BringToFront();
                    doc_patient_student_ques1.medHistory.Clear();
                    doc_patient_student_ques1.famhis1.Clear();
                    doc_patient_student_ques1.famhis2.Clear();
                    doc_patient_student_ques1.chronicCon.Clear();
                    doc_patient_student_ques1.medicationsx.Clear();
                    doc_patient_student_ques1.suplimenets.Clear();
                    button_next.Text = "NEXT TO QUESTION 2";
                    button_back.Text = "BACK TO PHYSICAL";
                }
                else
                {

                    doc_patient_student_ques1.Show();
                    doc_patient_student_ques1.BringToFront();
                    button_next.Text = "NEXT TO QUESTION 2";
                    button_back.Text = "BACK TO PHYSICAL";
                }

            }

            //start manage
            else if (button_next.Text == "UPDATE PHYSICAL"  && manage_toChange == true)
            {
                stud_height = double.Parse(patient_student_physical1.Height.Text);
                stud_weight = double.Parse(patient_student_physical1.Weight.Text);
                stud_heart_rate = double.Parse(patient_student_physical1.Heart_rate.Text);
                stud_blood_pressure = patient_student_physical1.Blood_pressure.Text;
                stud_temperature = double.Parse(patient_student_physical1.Body_temperature.Text);
                DbConnect updatePhysicalConnection = new DbConnect();
                updatePhysicalConnection.connect();
                string sql = "UPDATE `physical` SET `StudentID` = '" + stud_Id + "', `Height` = '" + stud_height + "', `Weight` = '" + stud_weight + "', `Heart_Rate` = '" + stud_heart_rate + "', `Blood_Pressure` = '" + stud_blood_pressure + "', `Body_Temperature` = '" + stud_temperature + "' WHERE `physical`.`Physical_id` = '" + doc_manage_patient1.manage_phy_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updatePhysicalConnection.conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                updatePhysicalConnection.disconnect();
                button_next.Text = "NEXT TO QUESTION";

            }
            //end of manage

            //start non manage
            else if (button_next.Text == "UPDATE PHYSICAL" )
            {
                stud_height = double.Parse(patient_student_physical1.Height.Text);
                stud_weight = double.Parse(patient_student_physical1.Weight.Text);
                stud_heart_rate = double.Parse(patient_student_physical1.Heart_rate.Text);
                stud_blood_pressure = patient_student_physical1.Blood_pressure.Text;
                stud_temperature = double.Parse(patient_student_physical1.Body_temperature.Text);
                DbConnect updatePhysicalConnection = new DbConnect();
                updatePhysicalConnection.connect();
                string sql = "UPDATE `physical` SET `StudentID` = '" + stud_Id + "', `Height` = '" + stud_height + "', `Weight` = '" + stud_weight + "', `Heart_Rate` = '" + stud_heart_rate + "', `Blood_Pressure` = '" + stud_blood_pressure + "', `Body_Temperature` = '" + stud_temperature + "' WHERE `physical`.`Physical_id` = '" + physical_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updatePhysicalConnection.conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                updatePhysicalConnection.disconnect();
                button_next.Text = "NEXT TO QUESTION";

            }
            //end of non manage


            //start manage
            else if (button_next.Text == "NEXT TO QUESTION 2" && manage_toChange == true)
            {
                if (questions1_tochange == false && manage_toChange == true)
                {
                    stud_med_history = doc_patient_student_ques1.medHistory.Text;
                    stud_med_allergies = doc_patient_student_ques1.suplimenets.Text;
                    stud_medications = doc_patient_student_ques1.medicationsx.Text;
                    stud_family_his1 = doc_patient_student_ques1.famhis1.Text;
                    stud_family_his2 = doc_patient_student_ques1.famhis2.Text;
                    stud_chronic_con = doc_patient_student_ques1.chronicCon.Text;
                    DbConnect getLatestques1Connection = new DbConnect();
                    getLatestques1Connection.connect();
                    string sqlques01 = "SELECT  Med_rec_ID FROM medical_records ORDER BY Med_rec_ID DESC";
                    MySqlCommand cmd2 = new MySqlCommand(sqlques01, getLatestques1Connection.conn);
                    MySqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        incrementing_ques1_id = int.Parse(reader.GetValue(0).ToString());
                    }
                    incrementing_ques1_id++;
                    ques1_id = incrementing_ques1_id;
                    getLatestques1Connection.disconnect();

                    DbConnect getAddques1Connection = new DbConnect();
                    getAddques1Connection.connect();

                    string sqlques1 = "UPDATE `medical_records` SET `Medical_history` = '" + stud_med_history + "', `family_history` = '" + stud_family_his1 + "', `family_history2` = '" + stud_family_his2 + "', `ChronicConditions` = '" + stud_chronic_con + "', `Allergies` = '" + stud_med_allergies + "', `Medications` = '" + stud_medications + "' WHERE `medical_records`.`Med_rec_ID` = '" + doc_manage_patient1.manage_med_rec_id + "'";
                    // "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`, `Physical_id`, 'Doctor_id', `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES ('"+ques1_id+ "', '"+stud_Id+ "', '"+physical_id+ "',  '"+doc_id+ "',  '" + stud_med_history+"', '"+stud_family_his1+"', '"+stud_family_his2+"', '"+stud_chronic_con+"', '"+stud_med_allergies+"', '"+stud_medications+"', NULL, '', NULL, '', NULL, '', NULL)";
                    //   "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`,'Physical_id', `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES('"+ques1_id+"', '"+stud_Id+"',,  '"+stud_med_history+"', '"+stud_family_his1+"', '"+stud_family_his2+"', '"+stud_chronic_con+"', '"+stud_med_allergies+"', '"+stud_medications+"', NULL, '', NULL, '', NULL, '', NULL)";
                    MySqlCommand cmdrr = new MySqlCommand(sqlques1, getAddques1Connection.conn);
                    MySqlDataReader reader2 = cmdrr.ExecuteReader();

                    doc_Patient_student_ques_21.Show();
                    doc_Patient_student_ques_21.BringToFront();
                    doc_Patient_student_ques_21.currsymp1.Clear();
                    doc_Patient_student_ques_21.currsymp2.Clear();
                    doc_Patient_student_ques_21.lifeStyle.Clear();
                    doc_Patient_student_ques_21.habitsx.Clear();
                    doc_Patient_student_ques_21.men_health1.Clear();
                    doc_Patient_student_ques_21.men_health2.Clear();
                    doc_Patient_student_ques_21.vac_history.Clear();

                    button_next.Text = "NO MORE";
                    button_next.Enabled = false;
                    button_back.Text = "BACK TO QUESTION 1";
                    this.button_submit.Enabled = true;




                }
                else
                {
                    doc_Patient_student_ques_21.Show();
                    doc_Patient_student_ques_21.BringToFront();
                    button_next.Text = "NO MORE";
                    button_next.Enabled = false;
                    button_back.Text = "BACK TO QUESTION 1";
                    this.button_submit.Enabled = true;
                }

            }
            //end manage

            //start non manage
            else if (button_next.Text == "NEXT TO QUESTION 2")
            {
                if (questions1_tochange == false)
                {
                    stud_med_history = doc_patient_student_ques1.medHistory.Text;
                    stud_med_allergies = doc_patient_student_ques1.suplimenets.Text;
                    stud_medications = doc_patient_student_ques1.medicationsx.Text;
                    stud_family_his1 = doc_patient_student_ques1.famhis1.Text;
                    stud_family_his2 = doc_patient_student_ques1.famhis2.Text;
                    stud_chronic_con = doc_patient_student_ques1.chronicCon.Text;
                    DbConnect getLatestques1Connection = new DbConnect();
                    getLatestques1Connection.connect();
                    string sqlques01 = "SELECT  Med_rec_ID FROM medical_records ORDER BY Med_rec_ID DESC";
                    MySqlCommand cmd2 = new MySqlCommand(sqlques01, getLatestques1Connection.conn);
                    MySqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        incrementing_ques1_id = int.Parse(reader.GetValue(0).ToString());
                    }
                    incrementing_ques1_id++;
                    ques1_id = incrementing_ques1_id;
                    getLatestques1Connection.disconnect();

                    DbConnect getAddques1Connection = new DbConnect();
                    getAddques1Connection.connect();

                    string sqlques1 = "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`, `Physical_id`, `Doctor_id`, `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES ('" + ques1_id + "', '" + stud_Id + "', '" + physical_id + "', '" + doc_id + "',  '" + stud_med_history + "', '" + stud_family_his1 + "', '" + stud_family_his2 + "', '" + stud_chronic_con + "', '" + stud_med_allergies + "', '" + stud_medications + "', NULL, '', NULL, '', NULL, '', NULL)";
                    // "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`, `Physical_id`, 'Doctor_id', `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES ('"+ques1_id+ "', '"+stud_Id+ "', '"+physical_id+ "',  '"+doc_id+ "',  '" + stud_med_history+"', '"+stud_family_his1+"', '"+stud_family_his2+"', '"+stud_chronic_con+"', '"+stud_med_allergies+"', '"+stud_medications+"', NULL, '', NULL, '', NULL, '', NULL)";
                    //   "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`,'Physical_id', `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES('"+ques1_id+"', '"+stud_Id+"',,  '"+stud_med_history+"', '"+stud_family_his1+"', '"+stud_family_his2+"', '"+stud_chronic_con+"', '"+stud_med_allergies+"', '"+stud_medications+"', NULL, '', NULL, '', NULL, '', NULL)";
                    MySqlCommand cmdrr = new MySqlCommand(sqlques1, getAddques1Connection.conn);
                    MySqlDataReader reader2 = cmdrr.ExecuteReader();

                    doc_Patient_student_ques_21.Show();
                    doc_Patient_student_ques_21.BringToFront();
                    doc_Patient_student_ques_21.currsymp1.Clear();
                    doc_Patient_student_ques_21.currsymp2.Clear();
                    doc_Patient_student_ques_21.lifeStyle.Clear();
                    doc_Patient_student_ques_21.habitsx.Clear();
                    doc_Patient_student_ques_21.men_health1.Clear();
                    doc_Patient_student_ques_21.men_health2.Clear();
                    doc_Patient_student_ques_21.vac_history.Clear();

                    button_next.Text = "NO MORE";
                    button_next.Enabled = false;
                    button_back.Text = "BACK TO QUESTION 1";
                    this.button_submit.Enabled = true;




                }
                else
                {
                    doc_Patient_student_ques_21.Show();
                    doc_Patient_student_ques_21.BringToFront();
                    button_next.Text = "NO MORE";
                    button_next.Enabled = false;
                    button_back.Text = "BACK TO QUESTION 1";
                    this.button_submit.Enabled = true;
                }

            }
            //end non manage


            // start manage
            else if (button_next.Text == "UPDATE QUESTION 1" && manage_toChange == true)
            {
                stud_med_history = doc_patient_student_ques1.medHistory.Text;
                stud_med_allergies = doc_patient_student_ques1.suplimenets.Text;
                stud_medications = doc_patient_student_ques1.medicationsx.Text;
                stud_family_his1 = doc_patient_student_ques1.famhis1.Text;
                stud_family_his2 = doc_patient_student_ques1.famhis2.Text;
                stud_chronic_con = doc_patient_student_ques1.chronicCon.Text;
                DbConnect updateques1Connection = new DbConnect();
                updateques1Connection.connect();
                string sql = "UPDATE `medical_records` SET `Medical_history` = '" + stud_med_history + "', `family_history` = '" + stud_family_his1 + "', `family_history2` = '" + stud_family_his2 + "', `ChronicConditions` = '" + stud_chronic_con + "', `Allergies` = '" + stud_med_allergies + "', `Medications` = '" + stud_medications + "' WHERE `medical_records`.`Med_rec_ID` = '" + doc_manage_patient1.manage_med_rec_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updateques1Connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                button_next.Text = "NEXT TO QUESTION 2";
            }
            //end manage

            // start non manage
            else if (button_next.Text == "UPDATE QUESTION 1")
            {
                stud_med_history = doc_patient_student_ques1.medHistory.Text;
                stud_med_allergies = doc_patient_student_ques1.suplimenets.Text;
                stud_medications = doc_patient_student_ques1.medicationsx.Text;
                stud_family_his1 = doc_patient_student_ques1.famhis1.Text;
                stud_family_his2 = doc_patient_student_ques1.famhis2.Text;
                stud_chronic_con = doc_patient_student_ques1.chronicCon.Text;
                DbConnect updateques1Connection = new DbConnect();
                updateques1Connection.connect();
                string sql = "UPDATE `medical_records` SET `Medical_history` = '" + stud_med_history + "', `family_history` = '" + stud_family_his1 + "', `family_history2` = '" + stud_family_his2 + "', `ChronicConditions` = '" + stud_chronic_con + "', `Allergies` = '" + stud_med_allergies + "', `Medications` = '" + stud_medications + "' WHERE `medical_records`.`Med_rec_ID` = '" + ques1_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updateques1Connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                button_next.Text = "NEXT TO QUESTION 2";
            }
            //end non manage


            
         //   else if (button_next.Text == "UPDATE QUESTION 1")
          //  {
          //      stud_med_history = doc_patient_student_ques1.medHistory.Text;
          //      stud_med_allergies = doc_patient_student_ques1.suplimenets.Text;
          //      stud_medications = doc_patient_student_ques1.medicationsx.Text;
          //      stud_family_his1 = doc_patient_student_ques1.famhis1.Text;
          //      stud_family_his2 = doc_patient_student_ques1.famhis2.Text;
          //      stud_chronic_con = doc_patient_student_ques1.chronicCon.Text;
          //      DbConnect updateques1Connection = new DbConnect();
          //      updateques1Connection.connect();
           //     string sql = "UPDATE `medical_records` SET `Medical_history` = '"+stud_med_history+"', `family_history` = '"+stud_family_his1+"', `family_history2` = '"+stud_family_his2+"', `ChronicConditions` = '"+stud_chronic_con+"', `Allergies` = '"+stud_med_allergies+"', `Medications` = '"+stud_medications+"' WHERE `medical_records`.`Med_rec_ID` = '"+ ques1_id + "'";
           //     MySqlCommand cmd = new MySqlCommand(sql, updateques1Connection.conn);
           //     MySqlDataReader reader = cmd.ExecuteReader();

            //    button_next.Text = "NEXT TO QUESTION 2";
           // }

            else if (button_next.Text == "Show Question1 Info")
            {
                ques1_id = doc_prescription1.get_med_rec_id;


                DbConnect showPhysicalConnection = new DbConnect();
                showPhysicalConnection.connect();
                string sql = "SELECT Medical_history, family_history, family_history2, Medications, Allergies, ChronicConditions FROM medical_records WHERE medical_records.Med_rec_ID = '"+ques1_id+"';";
                MySqlCommand cmd = new MySqlCommand(sql, showPhysicalConnection.conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    doc_patient_student_ques1.medHistory.Text = dr.GetValue(0).ToString();
                    doc_patient_student_ques1.famhis1.Text = dr.GetValue(1).ToString();
                    doc_patient_student_ques1.famhis2.Text = dr.GetValue(2).ToString();
                    doc_patient_student_ques1.medicationsx.Text = dr.GetValue(3).ToString();
                    doc_patient_student_ques1.suplimenets.Text = dr.GetValue(4).ToString();
                    doc_patient_student_ques1.chronicCon.Text = dr.GetValue(5).ToString();

                    doc_patient_student_ques1.medHistory.Enabled = false;
                    doc_patient_student_ques1.famhis1.Enabled = false;
                    doc_patient_student_ques1.famhis2.Enabled = false;
                    doc_patient_student_ques1.medicationsx.Enabled = false;
                    doc_patient_student_ques1.suplimenets.Enabled = false;
                    doc_patient_student_ques1.chronicCon.Enabled = false;
                    doc_patient_student_ques1.Show();
                    doc_patient_student_ques1.BringToFront();

                    button_next.Text = "Hide Question1 Info";

                   
                    button_back.Text = "Show Physical Info";
                    button_submit.Text = "Show Question2 Info";

                    button_submit.Enabled = true;
                    button_next.Enabled = true;
                    button_back.Enabled = true;
                }
            }


            else if (button_next.Text == "Hide Question1 Info")
            {
                doc_prescription1.Show();
                doc_prescription1.BringToFront();
                button_next.Text = "Show Question1 Info";
            }
            else if (button_next.Text == "Delete")
            {
                DbConnect DeletePatientConnection = new DbConnect();
                DeletePatientConnection.connect();
                string sql = "DELETE FROM `students` WHERE `students`.`StudentID` = '"+doc_manage_patient1.manage_stud_id+"'";
                MySqlCommand cmd = new MySqlCommand(sql , DeletePatientConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                doc_manage_patient1.loading();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            
            if (this.button_back.Text == "BACK TO PERSONAL") {

                personal_tochange = true;
                previous_id_personal = stud_Id;
                add_patient_student1.Show();
                add_patient_student1.BringToFront();
                button_back.Enabled = false;
                button_next.Text = "UPDATE PERSONAL";
                button_back.Text = "UNBACKABLE";


                //doc_Patient_physical = new Doc_patient_physical_info();
                //  doc_Patient_physical.TopLevel = false;
                //    doc_panel.Controls.Add(doc_Patient_physical);
                //       doc_Patient_physical.BringToFront();
                //       doc_Patient_physical.Show();
               

            }else if (this.button_back.Text == "BACK TO PHYSICAL")
            {
                previous_id_physical = physical_id;
                patient_student_physical1.Show();
                patient_student_physical1.BringToFront();
                physical_tochange = true;
                button_next.Text = "UPDATE PHYSICAL";
                button_back.Text = "BACK TO PERSONAL";
            } else if (this.button_back.Text == "BACK TO QUESTION 1")
            {
                previous_id_ques1 = ques1_id;
                questions1_tochange= true;
                doc_patient_student_ques1.Show();
                doc_patient_student_ques1.BringToFront();
                button_next.Text = "UPDATE QUESTION 1";
                button_next.Enabled = true;
                button_back.Text = "BACK TO PHYSICAL";
                button_submit.Enabled = false;
            }

            else if (this.button_back.Text == "Show Physical Info")
            {
                physical_id = doc_prescription1.get_phyc_id;


                  DbConnect showPhysicalConnection = new DbConnect();
                showPhysicalConnection.connect();
                string sql = "SELECT * FROM physical WHERE Physical_id = '"+physical_id+"'";
                MySqlCommand cmd = new MySqlCommand(sql, showPhysicalConnection.conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    patient_student_physical1.Height.Enabled = false;
                    patient_student_physical1.Weight.Enabled = false;
                    patient_student_physical1.Heart_rate.Enabled = false;
                    patient_student_physical1.Blood_pressure.Enabled = false;
                    patient_student_physical1.Body_temperature.Enabled = false;

                    patient_student_physical1.Height.Text = dr.GetValue(2).ToString();
                    patient_student_physical1.Weight.Text = dr.GetValue(3).ToString();
                    patient_student_physical1.Heart_rate.Text = dr.GetValue(4).ToString();
                    patient_student_physical1.Blood_pressure.Text = dr.GetValue(5).ToString();
                    patient_student_physical1.Body_temperature.Text = dr.GetValue(6).ToString();

                patient_student_physical1.Show();
                    patient_student_physical1.BringToFront();
                    button_next.Text = "Show Question1 Info";
                    button_back.Text = "Hide Physical Info";
                    button_submit.Text = "Show Question2 Info";

                    button_submit.Enabled = true;
                    button_next.Enabled = true;
                    button_back.Enabled = true;
                }
            
            }

            else if (this.button_back.Text == "Hide Physical Info")
            {
                doc_prescription1.Show();
                doc_prescription1.BringToFront();
                button_back.Text = "Show Physical Info";

            }
            else if (this.button_back.Text == "Edit")
            {
                manage_toChange = true;
                doc_manage_patient1.Hide();
                add_patient_student1.Show();
                add_patient_student1.BringToFront();

                manage_toChange = true;

                button_dashboard.BackColor = Color.White;

                //disabling the back button and showing the button for student personal Info form, onward etc
                this.button_back.Enabled = false;
                this.button_back.Text = "UNBACKABLE";
                this.button_next.Text = "NEXT";
                this.button_submit.Text = "SUBMIT";
                add_patient_student1.first_Name.Clear();
                add_patient_student1.last_Name.Clear();
                add_patient_student1.stud_ID.Clear();
                add_patient_student1.course.Clear();
                add_patient_student1.age.Clear();
                add_patient_student1.contact_number.Clear();
                add_patient_student1.address.Clear();
                add_patient_student1.parent_Name.Clear();
                add_patient_student1.parent_Contact.Clear();
                add_patient_student1.parent_address.Clear();
                button_next.Enabled = true;
                this.button_back.Visible = true;
                this.button_next.Visible = true;
                this.button_submit.Visible = true;
                this.button_submit.Enabled = false;
                this.buttonGenerateInvoice.Visible = false;

                add_patient_student1.stud_ID.Enabled = false;
                add_patient_student1.stud_ID.Text = doc_manage_patient1.manage_stud_id.ToString();
            }
        }

        private void doc_patient_student_ques1_Load(object sender, EventArgs e)
        {

        }

        private void doc_dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void doc_dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (button_submit.Text == "SUBMIT" && manage_toChange == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    stud_syntoms1 = doc_Patient_student_ques_21.currsymp1.Text;
                    stud_syntoms2 = doc_Patient_student_ques_21.currsymp2.Text;
                    stud_lifestyle = doc_Patient_student_ques_21.lifeStyle.Text;
                    stud_habits = doc_Patient_student_ques_21.habitsx.Text;
                    stud_mental = doc_Patient_student_ques_21.men_health1.Text;
                    stud_mental2 = doc_Patient_student_ques_21.men_health2.Text;
                    stud_vaccine = doc_Patient_student_ques_21.vac_history.Text;

                    DbConnect updateques2Connection = new DbConnect();
                    updateques2Connection.connect();
                    string sql = "UPDATE `medical_records` SET `Symptoms` = '" + stud_syntoms1 + "', `Symptoms2` = '" + stud_syntoms2 + "', `LifeStyle` = '" + stud_lifestyle + "', `habits` = '" + stud_habits + "', `Mental` = '" + stud_mental + "', `Mental2` = '" + stud_mental2 + "', `Vaccine` = '" + stud_vaccine + "' WHERE `medical_records`.`Med_rec_ID` = '" + doc_manage_patient1.manage_med_rec_id + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, updateques2Connection.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    ques2_id = ques1_id;
                    updateques2Connection.disconnect();
                    MessageBox.Show("RECORD HAS BEEN UPDATES!", "Updated Successfully");
                    button_back.Enabled = false;
                    button_submit.Enabled = false;
                    manage_toChange = false;
                }




            }
            else  if (button_submit.Text == "SUBMIT")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to submit this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    stud_syntoms1 = doc_Patient_student_ques_21.currsymp1.Text;
                    stud_syntoms2 = doc_Patient_student_ques_21.currsymp2.Text;
                    stud_lifestyle = doc_Patient_student_ques_21.lifeStyle.Text;
                    stud_habits = doc_Patient_student_ques_21.habitsx.Text;
                    stud_mental = doc_Patient_student_ques_21.men_health1.Text;
                    stud_mental2 = doc_Patient_student_ques_21.men_health2.Text;
                    stud_vaccine = doc_Patient_student_ques_21.vac_history.Text;

                    DbConnect updateques2Connection = new DbConnect();
                    updateques2Connection.connect();
                    string sql = "UPDATE `medical_records` SET `Symptoms` = '" + stud_syntoms1 + "', `Symptoms2` = '" + stud_syntoms2 + "', `LifeStyle` = '" + stud_lifestyle + "', `habits` = '" + stud_habits + "', `Mental` = '" + stud_mental + "', `Mental2` = '" + stud_mental2 + "', `Vaccine` = '" + stud_vaccine + "' WHERE `medical_records`.`Med_rec_ID` = '" + ques1_id + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, updateques2Connection.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    ques2_id = ques1_id;
                    updateques2Connection.disconnect();
                    MessageBox.Show("RECORD HAS BEEN ADDED!", "Added Successfully");
                    button_back.Enabled = false;
                    button_submit.Enabled = false;
                }




            }

           
            else if (button_submit.Text == "Show Question2 Info")
            {
                ques2_id = doc_prescription1.get_med_rec_id;
                DbConnect showQues2Connection = new DbConnect();
                showQues2Connection.connect();
                string sql = "SELECT  Symptoms, Symptoms2, LifeStyle, habits, Mental, Mental2, Vaccine FROM medical_records WHERE medical_records.Med_rec_ID = '"+ ques2_id + "';";
                MySqlCommand cmd = new MySqlCommand(sql, showQues2Connection.conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    doc_Patient_student_ques_21.currsymp1.Text = dr.GetValue(0).ToString();
                    doc_Patient_student_ques_21.currsymp2.Text = dr.GetValue(1).ToString();
                    doc_Patient_student_ques_21.lifeStyle.Text = dr.GetValue(2).ToString();
                    doc_Patient_student_ques_21.habitsx.Text = dr.GetValue(3).ToString();
                    doc_Patient_student_ques_21.men_health1.Text = dr.GetValue(4).ToString();
                    doc_Patient_student_ques_21.men_health2.Text = dr.GetValue(5).ToString();
                    doc_Patient_student_ques_21.vac_history.Text = dr.GetValue(6).ToString();

                    doc_Patient_student_ques_21.currsymp1.Enabled = false;
                    doc_Patient_student_ques_21.currsymp2.Enabled = false;
                    doc_Patient_student_ques_21.lifeStyle.Enabled = false;
                    doc_Patient_student_ques_21.habitsx.Enabled = false;
                    doc_Patient_student_ques_21.men_health1.Enabled = false;
                    doc_Patient_student_ques_21.men_health2.Enabled = false;

                    doc_Patient_student_ques_21.Show();
                    doc_Patient_student_ques_21.BringToFront();

                    button_submit.Text = "Hide Question2 Info";
                    button_next.Text = "Show Question1 Info";
                    button_back.Text = "Show Physical Info";

                    button_submit.Enabled = true;
                    button_next.Enabled = true;
                    button_back.Enabled = true;
                }
               
            }
            else if (button_submit.Text == "Hide Question2 Info")
            {
                doc_prescription1.Show();
                doc_prescription1.BringToFront();
                button_submit.Text = "Show Question2 Info";
            }

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (buttonGenerateInvoice.Text == "SAVE")
            {
                DbConnect getLatestPres_IdConnection = new DbConnect();
                getLatestPres_IdConnection.connect();
                string sqlques01 = "SELECT  Med_rec_ID FROM medical_records ORDER BY Med_rec_ID DESC";
                MySqlCommand cmd2 = new MySqlCommand(sqlques01, getLatestPres_IdConnection.conn);
                MySqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    incremental_pres_id = int.Parse(reader.GetValue(0).ToString());
                }
                incremental_pres_id++;
                pres_id = incremental_pres_id;
                getLatestPres_IdConnection.disconnect();
                DbConnect addPrecriptionConnection = new DbConnect();
                   addPrecriptionConnection.connect();
                  string sqlx = "INSERT INTO `prescription` (`Pres_ID`, `Doctor_id`, `Med_rec_ID`, `student_id`, `Visit_Date`, `Medicine`, `Medicine_Dosage`, `Medicine Take`, `Diagnosis`, `Treatment`) VALUES ('NULL', '"+ doc_prescription1.get_doc_id + "', '"+ doc_prescription1.get_med_rec_id + "', '"+ doc_prescription1.stud_id.Text+ "', current_timestamp(), '"+ doc_prescription1.med.Text+"', '"+ doc_prescription1.med_dosages.Text+ "', '"+ doc_prescription1.med_takee.Text + "', '"+ doc_prescription1.diagnosis.Text + "', '"+ doc_prescription1.treatment.Text+ "');";
                  MySqlCommand cmdx = new MySqlCommand(sqlx, addPrecriptionConnection.conn);
                  MySqlDataReader reader2 = cmdx.ExecuteReader();

                buttonGenerateInvoice.Text = "PRINT";
            }

            else if (buttonGenerateInvoice.Text == "PRINT")
            {


                print_prescription print_presrip = new print_prescription();
                print_presrip.labelStudFname.Text = doc_prescription1.fname.Text;
                print_presrip.labelStudLname.Text = doc_prescription1.lname.Text;
                print_presrip.labelStudAge.Text = doc_prescription1.age.Text;
                print_presrip.labelStudSex.Text = doc_prescription1.sex.Text;
                print_presrip.labelStudMed.Text = doc_prescription1.med.Text;
                print_presrip.labelStudtreatment.Text = doc_prescription1.treatment.Text;
                print_presrip.labelStudDosage.Text = doc_prescription1.med_dosages.Text;
                print_presrip.labelStudIntake.Text = doc_prescription1.med_takee.Text;
                print_presrip.labelStudDiagnosis.Text = doc_prescription1.diagnosis.Text;
                print_presrip.labelStudDate.Text = doc_prescription1.Visit_date;
                print_presrip.labelStudAddress.Text = doc_prescription1.stud_address;
                print_presrip.labelDocName.Text = doc_prescription1.doc_name;
               // print_presrip.labelStudAddress.Text = doc_prescription1.

                // print_presrip.labelStudAddress.Text = doc_prescription1.

                print_presrip.ShowDialog();
            }
           
        }

        private void doc_Patient_student_ques_21_Load(object sender, EventArgs e)
        {

        }

        private void doc_prescription1_Load(object sender, EventArgs e)
        {

        }

        private void doc_manage_patient1_Load(object sender, EventArgs e)
        {

        }
    }
}
