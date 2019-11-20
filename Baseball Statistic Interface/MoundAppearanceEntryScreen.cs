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
        public string Username { get; set; }
        public string Password { get; set; }
        public string TeamName { get; set; }

        public MoundAppearanceEntryScreen()
        {
            InitializeComponent();
        }

        private void MoundAppearanceEntryScreen_Load(object sender, EventArgs e)
        {

        }
        
        public void PopulatePitchersComboBox(string username, string password, string teamName)
        {
            Username = username;
            Password = password;
            TeamName = teamName;

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

        private void LEFT_CHECKBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (RIGHT_CHECKBOX.Checked)
            {
                RIGHT_CHECKBOX.Checked = false;
            }
        }

        private void RIGHT_CHECKBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (LEFT_CHECKBOX.Checked)
            {
                LEFT_CHECKBOX.Checked = false;
            }
        }
        private void OPENER_TEXTBOX_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SUBMIT_BUTTON_Click(object sender, EventArgs e)
        {
            if (PITCHER_SELECT_COMBOBOX.Text == "" || PITCHER_SELECT_COMBOBOX.Text == null || OPENER_TEXTBOX.Text == ""
                || OPENER_QUADRANT_TEXTBOX.Text == "" || O_TWO_TEXTBOX.Text == "" || O_TWO_QUADRANT_TEXTBOX.Text == ""
                || (!LEFT_CHECKBOX.Checked && !RIGHT_CHECKBOX.Checked))
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                // Initialize Connection Strings
                String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + Username + "; password=" + Password;
                String queryThrowingArm = "SELECT throwing_arm FROM player WHERE player_name='" + PITCHER_SELECT_COMBOBOX.Text + "';";

                // Initialize Connection
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                // Query for Pitchers Throwing Arm
                SqlCommand sqlCommand = new SqlCommand(queryThrowingArm, sqlConnection);
                SqlDataReader myReader;
                myReader = sqlCommand.ExecuteReader();
                myReader.Read();
                string throwingArm = myReader.GetString(0);
                myReader.Close();

                string battingArm;
                bool checkBoxW = true;
                if (LEFT_CHECKBOX.Checked)
                {
                    battingArm = "L";
                    // Just an Extra Check
                    if (RIGHT_CHECKBOX.Checked)
                    {
                        MessageBox.Show("You broke the checkbox... again");
                        checkBoxW = false;
                        sqlConnection.Close();
                    }
                }
                else
                {
                    battingArm = "R";
                    // Just an Extra Check
                    if (LEFT_CHECKBOX.Checked)
                    {

                        MessageBox.Show("You broke the checkbox... again");
                        checkBoxW = false;
                        sqlConnection.Close();
                    }
                }
                if (checkBoxW)
                {
                    // Query to Insert
                    String queryInsert = "INSERT INTO moundAppearances VALUES ('" + PITCHER_SELECT_COMBOBOX.Text + "', '" + throwingArm + "', '" + battingArm +
                        "', '" + OPENER_TEXTBOX.Text + "', " + Int32.Parse(OPENER_QUADRANT_TEXTBOX.Text) + ", '" + O_TWO_TEXTBOX.Text + "', " +
                        Int32.Parse(O_TWO_QUADRANT_TEXTBOX.Text) + ");";

                    bool passed = false;
                    try
                    {
                        SqlCommand sqlCommand2 = new SqlCommand(queryInsert, sqlConnection);
                        sqlCommand2.ExecuteNonQuery();
                        passed = true;
                    }
                    catch
                    {
                        MessageBox.Show("Entry Failed");
                        sqlConnection.Close();
                    }

                    if (passed)
                    {
                        MessageBox.Show("Successfully Entered");
                        OPENER_TEXTBOX.Text = "";
                        OPENER_QUADRANT_TEXTBOX.Text = "";
                        O_TWO_TEXTBOX.Text = "";
                        O_TWO_QUADRANT_TEXTBOX.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Try Again");
                    }
                    sqlConnection.Close();
                }
            }
        }

        private void OPENER_QUADRANT_TEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pulled From StackOverFlow:https://stackoverflow.com/questions/15882766/how-to-set-a-data-type-for-a-textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void O_TWO_QUADRANT_TEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pulled From StackOverFlow:https://stackoverflow.com/questions/15882766/how-to-set-a-data-type-for-a-textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
