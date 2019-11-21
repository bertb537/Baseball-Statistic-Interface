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
    public partial class BatterInfoSelectScreen : UserControl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string TeamName { get; set; }
        public PitcherDataDisplayScreen pitcherDataDisplayScreen1 { get; set; }

        public BatterInfoSelectScreen()
        {
            InitializeComponent();
        }

        private void BatterInfoSelectScreen_Load(object sender, EventArgs e)
        {

        }

        public void PopulatePitcherComboBox(string username, string password, string teamName, PitcherDataDisplayScreen pitcherDataDisplayScreen)
        {
            Username = username;
            Password = password;
            TeamName = teamName;
            pitcherDataDisplayScreen1 = pitcherDataDisplayScreen;

            // Initialize Connection Strings
            String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + username + "; password=" + password;
            String query = "SELECT batting.player_name FROM batting LEFT JOIN player ON batting.player_name = player.player_name WHERE team_name = '" + teamName + "';";

            // Initialize SQL Objects
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Read Values
            BATTER_SELECT_COMBOBOX.Items.Clear();
            while (myReader.Read())
            {
                string batterName = myReader.GetString(0);
                BATTER_SELECT_COMBOBOX.Items.Add(batterName);
            }
            sqlConnection.Close();
        }

        private void BATTER_SELECT_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
