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

        public Baseball_Statistics_Interface(Login LoginScreen)
        {
            InitializeComponent();
            Username = LoginScreen.GetUsername;
            Password = LoginScreen.GetPassword;
        }

        private void Baseball_Statistics_Interface_Load(object sender, EventArgs e)
        {           
            
        }
    }
}
