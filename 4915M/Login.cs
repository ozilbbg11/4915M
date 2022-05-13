using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _4915M
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string departIDValue;
        public static string loginStaffNum;
        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connString);
            MySqlDataAdapter reader = new MySqlDataAdapter("SELECT COUNT(*) FROM staff WHERE StaffNo = '" + UserTxtbox.Text + "' AND pw = '" + PwTxtbox.Text + "'", con);
            DataTable dt = new DataTable();
            reader.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                string query = "SELECT DepartID FROM staff WHERE StaffNo = '" + UserTxtbox.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader readerID = cmd.ExecuteReader();
                if (readerID.Read())
                {
                    departIDValue = readerID.GetString(0);
                    loginStaffNum = UserTxtbox.Text.ToString();
                }
                con.Close();

                MainMenu mm = new MainMenu();
                mm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your staff ID and password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
