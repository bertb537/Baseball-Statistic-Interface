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
    public partial class Login : Form
    {

        public string GetUsername { get { return USERNAME_TEXTBOX.Text; } }
        public string GetPassword { get { return PASSWORD_TEXTBOX.Text; } }

        public Login()
        {
            InitializeComponent();
        }

        private void LOGIN_SUBMIT_BUTTON_Click(object sender, EventArgs e)
        {
            bool valid_login = true;
            // Connect to server 
            String connectionString = "server=aura.cset.oit.edu, 5433; database=BonBon; UID=" + USERNAME_TEXTBOX.Text +"; password=" + PASSWORD_TEXTBOX.Text;
            String query = "SELECT * FROM translate";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch
            {
                valid_login = false;
            }

            if(valid_login)
            {
                MessageBox.Show("Connection Successful");
                this.Hide();
                Baseball_Statistics_Interface bapo = new Baseball_Statistics_Interface(this);
                bapo.Show();
            }
            else
            {
                USERNAME_TEXTBOX.Text = String.Empty;
                PASSWORD_TEXTBOX.Text = String.Empty;
                MessageBox.Show("Login Failed: " + USERNAME_TEXTBOX.Text + ", " + PASSWORD_TEXTBOX.Text);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
