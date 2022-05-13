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
    public partial class Purchase_Order : Form
    {
        int id;
        string today;
        int custNo;

        public Purchase_Order()
        {
            InitializeComponent();
        }

        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;
        
        private void SearchPartsBtn_Click(object sender, EventArgs e)
        {
            if (PartsSearchTxtbox.Text.Length == 0)
            {
                MessageBox.Show("Please input the product number!");
            }
            else
            {
                PartsDataGridView.DataSource = GetList();
            }
        }

        private DataTable GetList()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT product.ProductID, Price, ProductName, CatID, QtyOnHand FROM product, storeinventory WHERE product.ProductID = storeinventory.ProductID AND product.ProductID = " + int.Parse(PartsSearchTxtbox.Text), con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PartsNumTxtbox.Text.Length == 0)
            {
                MessageBox.Show("Please select a product !");
            }
            else if (qtyTxtbox.Text.Length == 0)
            {
                MessageBox.Show("Please enter the quantity !");
            }
            else if (int.Parse(qtyTxtbox.Text) <= 0)
            {
                MessageBox.Show("Please enter positive integer !");
            }
            else
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        con.Open();
                        var qty = new MySqlCommand("SELECT QtyOnHand FROM storeinventory WHERE ProductID = " + int.Parse(PartsNumTxtbox.Text), con);
                        String QtyOH = qty.ExecuteScalar().ToString();
                        if(int.Parse(qtyTxtbox.Text)> int.Parse(QtyOH))
                        {
                            MessageBox.Show("Qty overload !");
                            return;
                        }
                        var myVariable = new MySqlCommand("SELECT Price FROM product WHERE ProductID = " + int.Parse(PartsNumTxtbox.Text), con);
                        String price = myVariable.ExecuteScalar().ToString();
                        var name = new MySqlCommand("SELECT ProductName FROM product WHERE ProductID = " + int.Parse(PartsNumTxtbox.Text), con);
                        String Product = name.ExecuteScalar().ToString();

                        con.Close();
                        orderData.Rows.Add(PartsNumTxtbox.Text, Product, qtyTxtbox.Text, price);

                        PartsNumTxtbox.Text = "";
                        qtyTxtbox.Text = "";
                    }
                    AddPartsBtn.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("There has no such item ! Please select the existing one !");
                }
            }            
        }

        private void checkNoBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                if (string.IsNullOrWhiteSpace(CusNoTxtbox.Text))
                {
                    MessageBox.Show("Please enter the Customer Number !");                    
                }
                else
                {
                    custNo = Convert.ToInt32(CusNoTxtbox.Text);

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM  customer WHERE CustNo = " + custNo, con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            AddressTxtbox.Text = (reader["InvoiceAddress"].ToString());
                            StreetTxtbox.Text = (reader["InvoiceStreet"].ToString());
                            AreaTxtbox.Text = (reader["InvoiceArea"].ToString());
                            TelTxtbox.Text = (reader["PhoneNum"].ToString());
                        }
                        con.Close();
                    }
                    AddBtn.Enabled = true;
                }
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartsDataGridView.DataSource = GetListAll();
        }

        private DataTable GetListAll()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT product.ProductID, Price, ProductName, CatID, QtyOnHand FROM product, storeinventory WHERE product.ProductID = storeinventory.ProductID;", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void PartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PartsDataGridView.Rows[e.RowIndex];

                PartsNumTxtbox.Text = row.Cells["ProductID"].Value.ToString();
            }
        }

        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            AddBtn.Enabled = false;
            AddPartsBtn.Enabled = false;
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();

                var myVariable = new MySqlCommand("SELECT MAX(SalesOrderNo) FROM salesorder;", con);
                id = (int)myVariable.ExecuteScalar() + 1;

                DateTime date = DateTime.Today;
                today = date.ToString("yyyy-MM-dd");

                con.Close();
            }
        }

        private void AddPartsBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO salesorder(SalesOrderNo, StaffNo, CustNo, OrderDate, status) VALUES('" + id + "', '" + Login.loginStaffNum + "', '" + custNo + "', '" + today + "', 'TBC')", con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                foreach (DataGridViewRow row in orderData.Rows)
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO salesorderlines (SalesOrderNo, qty, UnitPrice, ProductID) VALUES (" + id + ",@quantity, @UnitPrice, @PartNum)", con))
                    {
                        if (row.IsNewRow) continue;
                        {
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells["quantity"].Value));
                            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToInt32(row.Cells["UnitPrice"].Value));
                            cmd.Parameters.AddWithValue("@PartNum", Convert.ToInt32(row.Cells["PartNum"].Value));
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE storeinventory SET QtyOnHand = QtyOnHand - @quantity WHERE ProductID = @PartNum", con))
                    {
                        if (row.IsNewRow) continue;
                        {
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells["quantity"].Value));
                            cmd.Parameters.AddWithValue("@PartNum", Convert.ToInt32(row.Cells["PartNum"].Value));
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            MessageBox.Show("Order sucessfully!");
            this.Close();
        }
    }
}