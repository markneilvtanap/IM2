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
        public string stud_syntoms1;
        public string stud_syntoms2;
        public string stud_lifestyle;
        public string stud_habits;
        public string stud_mental;
        public string stud_mental2;
        public string stud_vaccine;

        public doc_layout_02()
        {
            InitializeComponent();
            
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
            //   doc_dashboard1.Hide();
            //   add_patient_student1.Show();
            //   add_patient_student1.BringToFront();


            // displaying the add/Patient A.K.A for student personal Info form
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //changing for color button
            button_dashboard.BackColor= Color.White;
            button_prescription.BackColor = Color.Gold;
            add_patient.BackColor = Color.White;
            manage_patient.BackColor = Color.White;



            buttonGenerateInvoice.Visible = true;
            this.buttonGenerateInvoice.Text = "PRINT";
            
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
            doc_prescription1.bd.Enabled = false;   
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
            

            //displaying the doctor dashboard form A.K.A doc_dashboard form
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
            if (this.button_next.Text == "NEXT")
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




            else if (this.button_next.Text == "UPDATE PERSONAL")

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
                string sql = "UPDATE `students` SET `StudentID` = '" + stud_Id + "', `FirstName` = '" + Fname + "', `LastName` = '" + Lname + "', `Age` = '" + age + "', `Sex` = '" + sex + "', `DateOfBirth` = '" + stud_birth_date + "', `Year_Level` = '" + yearlevel + "', `Contact_number` = '" + contact_num + "', `Address` = '" + stud_address + "', `program/course` = '" + course + "', `Emer_ContactName` = '" + parent_name + "', `Emer_ContactNum` = '" + parent_contact + "', `emerContactAddress` = '" + parent_add + "' WHERE `students`.`StudentID` = '" + previous_id_personal + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updatePatientConnection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                updatePatientConnection.disconnect();
                button_next.Text = "NEXT";


            }



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
            else if (button_next.Text == "UPDATE PHYSICAL")
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

                    string sqlques1 = "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`, `Physical_id`, `Doctor_id`, `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES ('"+ques1_id+ "', '"+stud_Id+ "', '"+physical_id+ "', '" + doc_id+ "',  '" + stud_med_history+"', '"+stud_family_his1+"', '"+stud_family_his2+"', '"+stud_chronic_con+"', '"+stud_med_allergies+"', '"+stud_medications+"', NULL, '', NULL, '', NULL, '', NULL)";
                // "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`, `Physical_id`, 'Doctor_id', `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES ('"+ques1_id+ "', '"+stud_Id+ "', '"+physical_id+ "',  '"+doc_id+ "',  '" + stud_med_history+"', '"+stud_family_his1+"', '"+stud_family_his2+"', '"+stud_chronic_con+"', '"+stud_med_allergies+"', '"+stud_medications+"', NULL, '', NULL, '', NULL, '', NULL)";
                 //   "INSERT INTO `medical_records` (`Med_rec_ID`, `StudentID`,'Physical_id', `Medical_history`, `family_history`, `family_history2`, `ChronicConditions`, `Allergies`, `Medications`, `Symptoms`, `Symptoms2`, `LifeStyle`, `habits`, `Mental`, `Mental2`, `Vaccine`) VALUES('"+ques1_id+"', '"+stud_Id+"',,  '"+stud_med_history+"', '"+stud_family_his1+"', '"+stud_family_his2+"', '"+stud_chronic_con+"', '"+stud_med_allergies+"', '"+stud_medications+"', NULL, '', NULL, '', NULL, '', NULL)";
                    MySqlCommand cmd = new MySqlCommand(sqlques1, getAddques1Connection.conn);
                    MySqlDataReader reader2 = cmd.ExecuteReader();

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
                string sql = "UPDATE `medical_records` SET `Medical_history` = '"+stud_med_history+"', `family_history` = '"+stud_family_his1+"', `family_history2` = '"+stud_family_his2+"', `ChronicConditions` = '"+stud_chronic_con+"', `Allergies` = '"+stud_med_allergies+"', `Medications` = '"+stud_medications+"' WHERE `medical_records`.`Med_rec_ID` = '"+ ques1_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, updateques1Connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                button_next.Text = "NEXT TO QUESTION 2";
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
                DbConnect showPhysicalConnection = new DbConnect();
                showPhysicalConnection.connect();
                string sql = "SELECT * FROM physical WHERE Physical_id = 1";
                MySqlCommand cmd = new MySqlCommand(sql, showPhysicalConnection.conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                patient_student_physical1.Height.Enabled = false;
                patient_student_physical1.Weight.Enabled = false;
                patient_student_physical1.Heart_rate.Enabled = false;
                patient_student_physical1.Blood_pressure.Enabled = false;
                patient_student_physical1.Body_temperature.Enabled = false;

                patient_student_physical1.Show();
                patient_student_physical1.BringToFront();

                button_back.Text = "Hide Physical Info";
            }

            else if (this.button_back.Text == "Hide Physical Info")
            {
                doc_prescription1.Show();
                doc_prescription1.BringToFront();
                button_back.Text = "Show Physical Info";

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
                updateques2Connection.disconnect();
                MessageBox.Show("RECORD HAS BEEN ADDED!", "Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         //   DbConnect addPrecriptionConnection = new DbConnect();
         //   addPrecriptionConnection.connect();
         //   string sql = "INSERT INTO ";
         //   MySqlCommand cmd = new MySqlCommand(sql, addPrecriptionConnection.conn);
        //    MySqlDataReader reader = cmd.ExecuteReader();

            print_prescription print_presrip = new print_prescription();
          //  print_presrip.stud_ffname.Text = "Mark";

            print_presrip.ShowDialog();
        }

        private void doc_Patient_student_ques_21_Load(object sender, EventArgs e)
        {

        }

        private void doc_prescription1_Load(object sender, EventArgs e)
        {

        }
    }
}
