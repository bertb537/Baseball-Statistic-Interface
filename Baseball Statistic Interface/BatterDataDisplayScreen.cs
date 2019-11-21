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
    public partial class BatterDataDisplayScreen : UserControl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string TeamName { get; set; }
        public string BatterName { get; set; }
        public BatterDataDisplayScreen BatterDataDisplayScreen1 { get; set; }
        public BatterDataDisplayScreenTwo BatterDataDisplayScreen2 { get; set; }

        public BatterDataDisplayScreen()
        {
            InitializeComponent();
        }

        public void UpdateTables(string username, string password, string teamName, string batterName, BatterDataDisplayScreen batterDataDisplayScreen, BatterDataDisplayScreenTwo batterDataDisplayScreen2)
        {
            Username = username;
            Password = password;
            TeamName = teamName;
            BatterName = batterName;
            BatterDataDisplayScreen1 = batterDataDisplayScreen;
            BatterDataDisplayScreen2 = batterDataDisplayScreen2;

            // Create Query and Connection Screens
            String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + username + "; password=" + password;
            String queryHeaderStats = "SELECT player.batting_arm, batting_average, on_base_percentage, slugging_percentage, on_base_plus_slugging, runners_batted_in, at_bats " +
                "FROM batting LEFT JOIN player ON player.player_name = batting.player_name WHERE batting.player_name='" + batterName + "';";

            // Create Connection String
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Query Header Stats
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(queryHeaderStats, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull and place Data
            myReader.Read();
            PLAYER_NAME_LABEL.Text = batterName + ":";
            string battingArm = myReader.GetString(0);
            double avg = myReader.GetDouble(1);
            double obp = myReader.GetDouble(2);
            double slg = myReader.GetDouble(3);
            double ops = myReader.GetDouble(4);
            int rbi = myReader.GetInt32(5);
            int ab = myReader.GetInt32(6);

            // Assign Batting Arm
            if (battingArm == "L")
                BATTING_ARM_LABEL.Text = "Lefty";
            else
                BATTING_ARM_LABEL.Text = "Righty";

            AVG_LABEL.Text = "AVG: " + avg;
            OBP_LABEL.Text = "OBP: " + obp;
            SLG_LABEL.Text = "SLG: " + slg;
            OPS_LABEL.Text = "OPS: " + ops;
            RBI_LABEL.Text = "RBI: " + rbi;
            AB_LABEL.Text = "AB: " + ab;

            myReader.Close();

            // Run Query Functions
            LeftStrikeOut(sqlConnection);
            RightStrikeOut(sqlConnection);
            LeftFastBall(sqlConnection);
            RightFastBall(sqlConnection);
            LeftCurveball(sqlConnection);
            RightCurveball(sqlConnection);

            /*LeftChangeUp(sqlConnection);
            RightChangeUp(sqlConnection);
            LeftSlider(sqlConnection);
            RightSlider(sqlConnection);*/
        }

        public void LeftStrikeOut(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM plateAppearances WHERE throwing_arm='L';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 final_pitch, final_pitch_quadrant, CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='L' AND result='K' " +
                "GROUP BY final_pitch, final_pitch_quadrant ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            LEFT_SO_PITCH_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void RightStrikeOut(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM plateAppearances WHERE throwing_arm='R';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 final_pitch, final_pitch_quadrant, CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='R' AND result='K' " +
                "GROUP BY final_pitch, final_pitch_quadrant ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            RIGHT_SO_PITCH_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void LeftFastBall(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM plateAppearances WHERE throwing_arm='L';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 result, CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='L' AND final_pitch='FB'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            LEFT_FASTBALL_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void RightFastBall(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM plateAppearances WHERE throwing_arm='R';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 result, CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='R' AND final_pitch='FB'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            RIGHT_FASTBALL_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void LeftCurveball(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM plateAppearances WHERE throwing_arm='L';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 result, CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='L' AND final_pitch='CV'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            LEFT_CURVEBALL_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void RightCurveball(SqlConnection sqlConnection)
        {
            String queryTotal = "SELECT COUNT(*) FROM plateAppearances WHERE throwing_arm='R';";

            // Query Header Stats
            SqlCommand sqlCommand = new SqlCommand(queryTotal, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();

            // Pull Data
            myReader.Read();
            int total = myReader.GetInt32(0);
            myReader.Close();

            String queryTable = "SELECT TOP 3 result, CAST( (( CAST(COUNT(*) as float)/ CAST(" + total + " as float)) * CAST(100 as float) ) as decimal(5, 2)) AS Avg " +
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='R' AND final_pitch='CV'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            RIGHT_CURVEBALL_DATAGRIDVIEW.DataSource = dataTable;
        }

        private void OPS_LABEL_Click(object sender, EventArgs e)
        {

        }

        private void BatterDataDisplayScreen_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LEFT_SO_PITCH_DATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RIGHT_FASTBALL_DATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NEXT_BUTTON_Click(object sender, EventArgs e)
        {
            BatterDataDisplayScreen2.UpdateTables(Username, Password, TeamName, BatterName, BatterDataDisplayScreen1, BatterDataDisplayScreen2);
            BatterDataDisplayScreen2.BringToFront();
        }
    }
}
