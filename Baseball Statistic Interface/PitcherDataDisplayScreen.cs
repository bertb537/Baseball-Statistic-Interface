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
    public partial class PitcherDataDisplayScreen : UserControl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string TeamName { get; set; }
        public string PitcherName { get; set; }

        public PitcherDataDisplayScreen()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void PitcherDataDisplayScreen_Load(object sender, EventArgs e)
        {

        }

        public void UpdateTables(string username, string password, string teamName, string pitcherName)
        {
            Username = username;
            Password = password;
            TeamName = teamName;
            PitcherName = pitcherName;

            // Create Query and Connection Screens
            String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + username + "; password=" + password;
            String queryHeaderStats = "SELECT throwing_arm, mound_appearances, earned_runs_allowed FROM pitching" +
                " JOIN player ON player.player_name=pitching.player_name WHERE pitching.player_name='" + pitcherName + "';";

            // Create Connection String
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Query Header Stats
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(queryHeaderStats, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull and place Data
            myReader.Read();
            PLAYER_NAME_LABEL.Text = pitcherName + ":";
            string throwingArm = myReader.GetString(0);
            int ma = myReader.GetInt32(1);
            double era =  myReader.GetDouble(2);

            // Assign Throwing Arm
            if (throwingArm == "L")
                THROWING_ARM_LABEL.Text = "Lefty";
            else
                THROWING_ARM_LABEL.Text = "Righty";

            ERA_LABEL.Text = "ERA: " + era;
            MA_LABEL.Text = "MA: " + ma;

            myReader.Close();

            // Run Query Functions
            QueryLeftOpener(sqlConnection);
            QueryRightOpener(sqlConnection);
            QueryLeftO2(sqlConnection);
            QueryRightO2(sqlConnection);

            sqlConnection.Close();
        }

        public void QueryLeftOpener(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM moundAppearances WHERE batter_batting_arm='L';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 opening_pitch, opening_pitch_quadrant, " +
                "CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM moundAppearances WHERE pitcher_name = '" + PitcherName + "' AND batter_batting_arm='L' " +
                "GROUP BY opening_pitch, opening_pitch_quadrant ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            LEFT_OPENER_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void QueryRightOpener(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM moundAppearances WHERE batter_batting_arm='R';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 opening_pitch, opening_pitch_quadrant, " +
                "CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM moundAppearances WHERE pitcher_name = '" + PitcherName + "' AND batter_batting_arm='R' " +
                "GROUP BY opening_pitch, opening_pitch_quadrant ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            
            RIGHT_OPENER_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void QueryLeftO2(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM moundAppearances WHERE batter_batting_arm='L';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 count_02_pitch, count_02_pitch_quadrant, " +
                "CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM moundAppearances WHERE pitcher_name = '" + PitcherName + "' AND batter_batting_arm='L' " +
                "GROUP BY count_02_pitch, count_02_pitch_quadrant ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            LEFT_O_TWO_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void QueryRightO2(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM moundAppearances WHERE batter_batting_arm='R';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 count_02_pitch, count_02_pitch_quadrant, " +
                "CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM moundAppearances WHERE pitcher_name = '" + PitcherName + "' AND batter_batting_arm='R' " +
                "GROUP BY count_02_pitch, count_02_pitch_quadrant ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            RIGHT_O_TWO_DATAGRIDVIEW.DataSource = dataTable;
        }

        private void PLAYER_NAME_LABEL_Click(object sender, EventArgs e)
        {

        }
    }
}
