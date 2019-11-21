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
    public partial class PlateAppearanceEntryScreen : UserControl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string TeamName { get; set; }

        public PlateAppearanceEntryScreen()
        {
            InitializeComponent();
        }

        private void PlateAppearanceEntryScreen_Load(object sender, EventArgs e)
        {

        }

        public void PopulateBatterComboBox(string username, string password, string teamName)
        {
            Username = username;
            Password = password;
            TeamName = teamName;

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
            while (myReader.Read())
            {
                string batterName = myReader.GetString(0);
                BATTER_SELECT_COMBOBOX.Items.Add(batterName);
            }
            sqlConnection.Close();
        }

        private void SUBMIT_BUTTON_Click(object sender, EventArgs e)
        {
            if (BATTER_SELECT_COMBOBOX.Text == "" || BATTER_SELECT_COMBOBOX.Text == null || TOTAL_PITCHES_TEXTBOX.Text == ""
                || RESULT_TEXTBOX.Text == "" || FINAL_PITCH_TEXTBOX.Text == "" || FINAL_QUADRANT_TEXTBOX.Text == ""
                || (!LEFT_RADIOBUTTON.Checked && !RIGHT_RADIOBUTTON.Checked))
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                // Initialize Connection Strings
                String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + Username + "; password=" + Password;

                // Initialize Connection
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string pitchingArm;
                if (LEFT_RADIOBUTTON.Checked)
                    pitchingArm = "L";
                else
                    pitchingArm = "R";

                // Query to Insert
                
                String queryInsert2 = "INSERT INTO plateAppearances VALUES ('" + BATTER_SELECT_COMBOBOX.Text + "', " + Int32.Parse(TOTAL_PITCHES_TEXTBOX.Text) +
                    ", '" + FINAL_PITCH_TEXTBOX.Text + "', " + Int32.Parse(FINAL_QUADRANT_TEXTBOX.Text) + ", '" + RESULT_TEXTBOX.Text + "', '" + pitchingArm + "');";


                bool passed = false;
                try
                {
                    SqlCommand sqlCommand2 = new SqlCommand(queryInsert2, sqlConnection);
                    sqlCommand2.ExecuteNonQuery();
                    passed = true;
                }
                catch
                {
                    MessageBox.Show("Entry Failed");
                }
                if (passed)
                {
                    MessageBox.Show("Successfully Entered");
                    TOTAL_PITCHES_TEXTBOX.Text = "";
                    FINAL_PITCH_TEXTBOX.Text = "";
                    FINAL_QUADRANT_TEXTBOX.Text = "";
                    RESULT_TEXTBOX.Text = "";
                    BATTER_SELECT_COMBOBOX.Text = "";
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
                sqlConnection.Close();
            }
        }

        private void TOTAL_PITCHES_TEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void FINAL_QUADRANT_TEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOTAL_PITCHES_TEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pulled From StackOverFlow:https://stackoverflow.com/questions/15882766/how-to-set-a-data-type-for-a-textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void FINAL_QUADRANT_TEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pulled From StackOverFlow:https://stackoverflow.com/questions/15882766/how-to-set-a-data-type-for-a-textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
