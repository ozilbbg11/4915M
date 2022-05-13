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
    public partial class DealerAdmin : Form
    {
        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;
        public DealerAdmin()
        {
            InitializeComponent();
        }

        private void DealerAdmin_Load(object sender, EventArgs e)
        {
            staffDataGridView.DataSource = GetList();
        }
        private DataTable GetList()
        {
            DataTable dtCustomer = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer", con))
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer WHERE CustNo = " + int.Parse(StaffNoTxtbox.Text), con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            StaffNameTxtbox.Text = (reader["CustName"].ToString());
                            contOne.Text = (reader["ContactPerson1"].ToString());
                            contTwo.Text = (reader["ContactPerson2"].ToString());
                            address.Text = (reader["InvoiceAddress"].ToString());
                            street.Text = (reader["InvoiceStreet"].ToString());
                            area.Text = (reader["InvoiceArea"].ToString());
                            num.Text = (reader["PhoneNum"].ToString());
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

                    String query = "INSERT INTO customer (CustNo, CustName, ContactPerson1,ContactPerson2,InvoiceAddress,InvoiceStreet,InvoiceArea, PhoneNum) "
                        + "VALUES ('" + int.Parse(StaffNoTxtbox.Text) + "', '" + StaffNameTxtbox.Text + "', '" + contOne.Text + "', '" + contTwo.Text + "', '" + address.Text + "', '" + street.Text + "', '" + area.Text + "', '" + num.Text + "')";

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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();

                    String query = "UPDATE customer SET CustName = '" + StaffNameTxtbox.Text + "', ContactPerson1 = '" + contOne.Text + "', ContactPerson2 = '" + contTwo.Text +
                        "', InvoiceAddress = '" + address.Text + "', InvoiceStreet = '" + street.Text + "', InvoiceArea = '" + area.Text + "', PhoneNum = '" + num.Text + "' WHERE CustNo = '" + int.Parse(StaffNoTxtbox.Text) + "'";

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

                    String query = "DELETE FROM customer WHERE CustNo = '" + int.Parse(StaffNoTxtbox.Text) + "'";

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
    }
}

