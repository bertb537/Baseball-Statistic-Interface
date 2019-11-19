using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball_Statistic_Interface
{
    public partial class Baseball_Statistics_Interface : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool TeamSelected { get; set; }

        public Baseball_Statistics_Interface(Login LoginScreen)
        {
            InitializeComponent();
            Username = LoginScreen.GetUsername;
            Password = LoginScreen.GetPassword;
        }

        private void Baseball_Statistics_Interface_Load(object sender, EventArgs e)
        {
            ///Query Team Table for Team Names and populate TEAM_SELECT_COMBOBOX
            
            // Initialize Connection Strings
            String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + Username + "; password=" + Password;
            String query = "SELECT team_name FROM team";
           
            // Initialize SQL Objects
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            while(myReader.Read())
            {
                string teamName = myReader.GetString(0);
                TEAM_SELECT_COMBOBOX.Items.Add(teamName);
            }
            sqlConnection.Close();
        }

        private void TEAM_SELECT_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
