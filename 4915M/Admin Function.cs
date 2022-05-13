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
    public partial class Admin_Function : Form
    {
        public Admin_Function()
        {
            InitializeComponent();
        }

        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;

        private void Admin_Function_Load(object sender, EventArgs e)
        {
            staffDataGridView.DataSource = GetList();
        }

        private DataTable GetList()
        {
            DataTable dtCustomer = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM staff", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtCustomer.Load(reader);
                }
            }

            return dtCustomer;
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM staff WHERE StaffNo = " + int.Parse(StaffNoTxtbox.Text), con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            StaffNameTxtbox.Text = (reader["StaffName"].ToString());
                            DepartIDTxtbox.Text = (reader["DepartID"].ToString());
                            StoreIDTxtbox.Text = (reader["StoreID"].ToString());
                            pwTxtbox.Text = (reader["pw"].ToString());
                        }
                        con.Close();
                    }
                }

                staffDataGridView.DataSource = GetList();
            }
            catch
            {
                MessageBox.Show("Please check the input! ");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();

                    String query = "INSERT INTO staff (StaffNo, StaffName, DepartID, StoreID, pw) "
                        + "VALUES ('" + int.Parse(StaffNoTxtbox.Text) + "', '" + StaffNameTxtbox.Text + "', '" + DepartIDTxtbox.Text + "', '" + StoreIDTxtbox.Text + "', '" + pwTxtbox.Text + "')";

                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, con);

                    cmd.SelectCommand.ExecuteNonQuery();

                    con.Close();
                }

                staffDataGridView.DataSource = GetList();
            }
            catch
            {
                MessageBox.Show("Please check the input! ");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();

                    String query = "UPDATE staff SET StaffName = '" + StaffNameTxtbox.Text + "', DepartID = '" + DepartIDTxtbox.Text +
                        "', StoreID = '" + StoreIDTxtbox.Text + "', pw = '" + pwTxtbox.Text + "' WHERE StaffNo = '" + int.Parse(StaffNoTxtbox.Text) + "'";

                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, con);

                    cmd.SelectCommand.ExecuteNonQuery();

                    con.Close();
                }

                staffDataGridView.DataSource = GetList();
            }
            catch
            {
                MessageBox.Show("Please check the input! ");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();

                    String query = "DELETE FROM staff WHERE StaffNo = '" + int.Parse(StaffNoTxtbox.Text) + "'";

                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, con);

                    cmd.SelectCommand.ExecuteNonQuery();

                    con.Close();
                }

                staffDataGridView.DataSource = GetList();
            }
            catch
            {
                MessageBox.Show("Please check the input! ");
            }
}

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
