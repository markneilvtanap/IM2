
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace endterm_IM2
{
  
    internal class DbConnect
    {
        private string server = Properties.Settings.Default.server;
        private string port = Properties.Settings.Default.port;
        private string username = Properties.Settings.Default.username;
        private string password = Properties.Settings.Default.password;
        private string dBase = Properties.Settings.Default.Dbase;

        public MySqlConnection conn = new MySqlConnection();

          public void connect()
        {
            string constring = "server=" + server + "; port= " + port + "; username= "+ username +"; database= "+ dBase + "; charset=utf8;";

            conn = new MySqlConnection(constring);
            conn.Open();
        }

        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
