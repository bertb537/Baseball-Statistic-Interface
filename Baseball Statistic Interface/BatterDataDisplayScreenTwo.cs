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
    public partial class BatterDataDisplayScreenTwo : UserControl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string TeamName { get; set; }
        public string BatterName { get; set; }
        public BatterDataDisplayScreen BatterDataDisplayScreen1 { get; set; }
        public BatterDataDisplayScreenTwo BatterDataDisplayScreen2 { get; set; }

        public BatterDataDisplayScreenTwo()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BatterDataDisplayScreenTwo_Load(object sender, EventArgs e)
        {

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
            LeftChangeUp(sqlConnection);
            RightChangeUp(sqlConnection);
            LeftSlider(sqlConnection);
            RightSlider(sqlConnection);
        }
        public void LeftChangeUp(SqlConnection sqlConnection)
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
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='L' AND final_pitch='CH'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            LEFT_CHANGE_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void RightChangeUp(SqlConnection sqlConnection)
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
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='R' AND final_pitch='CH'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            RIGHT_CHANGE_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void LeftSlider(SqlConnection sqlConnection)
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
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='L' AND final_pitch='SL'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            LEFT_SLIDER_DATAGRIDVIEW.DataSource = dataTable;
        }

        public void RightSlider(SqlConnection sqlConnection)
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
                "FROM plateAppearances WHERE player_name = '" + BatterName + "' AND throwing_arm='R' AND final_pitch='SL'" +
                "GROUP BY result ORDER BY Avg DESC;";

            // Pull and Display Data
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTable, sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            RIGHT_SLIDER_DATAGRIDVIEW.DataSource = dataTable;
        }

        private void PREVIOUS_BUTTON_Click(object sender, EventArgs e)
        {
            BatterDataDisplayScreen1.UpdateTables(Username, Password, TeamName, BatterName, BatterDataDisplayScreen1, BatterDataDisplayScreen2);
            BatterDataDisplayScreen1.BringToFront();
        }
    }
}
