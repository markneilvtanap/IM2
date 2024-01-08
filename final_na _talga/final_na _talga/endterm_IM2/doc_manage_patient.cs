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
    public partial class doc_manage_patient : UserControl
    {
        public string manage_stud_id;
        public string manage_phy_id;
        public string manage_med_rec_id;
        public doc_manage_patient()
        {
            InitializeComponent();
            loading();
        }
        public void loading()
        {
            DbConnect addingConnection = new DbConnect();
            addingConnection.connect();
            string sql = "SELECT students.StudentID, students.FirstName, students.LastName, students.Age, students.Sex, students.DateOfBirth, students.Year_Level, students.Contact_number, students.Address, students.program_course, students.Emer_ContactName, students.Emer_ContactNum, students.emerContactAddress, physical.Physical_id, medical_records.Med_rec_ID\tFROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON medical_records.Physical_id = physical.Physical_id;";
            MySqlCommand cmd = new MySqlCommand(sql, addingConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
        }

        private void doc_manage_patient_Load(object sender, EventArgs e)
        {

        }

        private void stud_search_TextChanged(object sender, EventArgs e)
        {

            DbConnect search = new DbConnect();
            search.connect();


            string sql = "SELECT students.StudentID, students.FirstName, students.LastName, students.Age, students.Sex, students.DateOfBirth, students.Year_Level, students.Contact_number, students.Address, students.program_course, students.Emer_ContactName, students.Emer_ContactNum, students.emerContactAddress, physical.Physical_id, medical_records.Med_rec_ID\tFROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON medical_records.Physical_id = physical.Physical_id WHERE Firstname LIKE @search OR Age LIKE @search OR Sex LIKE @search";
            MySqlCommand cmd = new MySqlCommand(sql, search.conn);
            cmd.Parameters.AddWithValue("@search", this.stud_search.Text + "%");
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
            search.disconnect();
        }

        private void stud_datagridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            manage_stud_id = this.stud_datagridView.CurrentRow.Cells[0].Value.ToString();
            manage_phy_id = this.stud_datagridView.CurrentRow.Cells[13].Value.ToString();
            manage_med_rec_id = this.stud_datagridView.CurrentRow.Cells[14].Value.ToString();
        }
    }
}
