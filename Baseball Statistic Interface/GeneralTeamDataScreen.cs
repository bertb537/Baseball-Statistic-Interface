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
    public partial class GeneralTeamDataScreen : UserControl
    {
        public GeneralTeamDataScreen()
        {
            InitializeComponent();
        }

        private void GeneralTeamDataScreen_Load(object sender, EventArgs e)
        {
            
        }

        public void PopulateGridview(string username, string password, string teamName)
        {
            // Initialize Connection Strings
            String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + username + "; password=" + password;
            String query = "SELECT player.player_name AS Player, primary_position AS Pos, batting_average AS AVG, on_base_percentage AS OBP," +
                " slugging_percentage AS SLG, on_base_plus_slugging AS OPS, throwing_arm AS TA, batting_arm AS BA" +
                " FROM player JOIN batting ON batting.player_name = player.player_name WHERE player.team_name ='" + teamName + "';";
            String query2 = "SELECT win_count, tie_count, loss_count FROM team WHERE team_name = '" + teamName + "';";

            // Initialize SQL Objects
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            SqlDataReader myReader;
            myReader = sqlCommand2.ExecuteReader();

            // Pull and Display Title Data
            myReader.Read();
            
            int winCount = myReader.GetInt32(0);
            int tieCount = myReader.GetInt32(1);
            int lossCount = myReader.GetInt32(2);
            TEAM_NAME_RATIO_DISPLAY.Text = teamName + ": " + winCount + "/" + tieCount + "/" + lossCount;
            

            // Display Data Table
            GENERAL_DATAGRIDVIEW.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void TEAM_NAME_RATIO_DISPLAY_Click(object sender, EventArgs e)
        {

        }
    }
}
