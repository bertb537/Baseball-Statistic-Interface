using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baseball_Statistic_Interface
{
    public partial class MoundAppearanceEntryScreen : UserControl
    {
        public MoundAppearanceEntryScreen()
        {
            InitializeComponent();
        }

        private void MoundAppearanceEntryScreen_Load(object sender, EventArgs e)
        {

        }
        
        public void PopulatePitchersComboBox(string username, string password, string teamName)
        {
            // Initialize Connection Strings
            String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + username + "; password=" + password;
            String query = "SELECT pitching.player_name FROM pitching LEFT JOIN player ON pitching.player_name = player.player_name WHERE team_name = '" + teamName +"';";

            // Initialize SQL Objects
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Read Values
            while (myReader.Read())
            {
                string pitcherName = myReader.GetString(0);
                PITCHER_SELECT_COMBOBOX.Items.Add(pitcherName);
            }
            sqlConnection.Close();
        }
    }
}
