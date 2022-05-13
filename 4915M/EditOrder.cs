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
    public partial class EditOrder : Form
    {
        int id;
        string today;
        int price;
        int qty;

        public EditOrder()
        {
            InitializeComponent();
        }

        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        if (int.Parse(qtyTxtbox.Text) > int.Parse(QtyOH))
                        {
                            MessageBox.Show("Qty overload !");
                            return;
                        }
                        using (MySqlCommand cmd = new MySqlCommand("SELECT Price FROM product WHERE ProductID = " + int.Parse(PartsNumTxtbox.Text), con))
                        {
                            MySqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                price = Convert.ToInt32(reader["Price"]);
                            }

                            con.Close();
                        }

                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO salesorderlines (SalesOrderNo, qty, UnitPrice, ProductID) VALUES (" + id + "," + int.Parse(qtyTxtbox.Text) + "," + price + " , " + int.Parse(PartsNumTxtbox.Text) + ")", con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        using (MySqlCommand cmd = new MySqlCommand("UPDATE storeinventory SET QtyOnHand = QtyOnHand - " + Convert.ToInt32(qtyTxtbox.Text) + " WHERE ProductID = " + int.Parse(PartsNumTxtbox.Text), con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
            }
                catch
            {
                MessageBox.Show("Duplicate item, please remove the previous one !");
            }

            orderData.DataSource = GetOrderDetail();
            }    
        }

        private void AddPartsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change sucessfully !");
        }

        private void SearchPartsBtn_Click(object sender, EventArgs e)
        {
            if (PartsSearchTxtbox.Text.Length == 0)
            {
                MessageBox.Show("Please input the product number !");
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

        private void checkNoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OrderNoTxtbox.Text))
            {
                MessageBox.Show("Please enter the Order Number !");
            }
            else
            {
                id = Convert.ToInt32(OrderNoTxtbox.Text);
                orderData.DataSource = GetOrderDetail();

                AddBtn.Enabled = true;
                RemoveBtn.Enabled = true;
                AddPartsBtn.Enabled = true;
            }
        }

        private DataTable GetOrderDetail()
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                DataTable dtInfo = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand("SELECT salesorderlines.ProductID, ProductName, qty, UnitPrice  FROM salesorderlines, product WHERE salesorderlines.ProductID = product.ProductID AND SalesOrderNo = " + id, con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }

                return dtInfo;
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (PartsNumTxtbox.Text.Length == 0)
            {
                MessageBox.Show("Please select a product !");
            }
            else
            {
                //try
                //{
                    using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT qty FROM salesorderlines WHERE SalesOrderNo = " + id + " AND ProductID = " + int.Parse(PartsNumTxtbox.Text), con))
                        {                            
                            con.Open();

                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                qty = Convert.ToInt32((reader["qty"].ToString()));
                            }                           

                            con.Close();
                            
                        }
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM salesorderlines WHERE (SalesOrderNo = " + id + ") AND (ProductID = " + int.Parse(PartsNumTxtbox.Text) + ")", con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE storeinventory SET QtyOnHand = QtyOnHand + " + qty + " WHERE ProductID = " + int.Parse(PartsNumTxtbox.Text), con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                //}
                //catch
                //{
                //    MessageBox.Show("There is no such item in your order !");
                //}               
                qty = 0;
                orderData.DataSource = GetOrderDetail();
            }
        }

        string orderNo;
        string ProdNo;
        private void OrderData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.orderData.Rows[e.RowIndex];

                orderNo = row.Cells["SalesOrderNo"].Value.ToString();
                ProdNo = row.Cells["ProductID"].Value.ToString();
            }
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

        private void orderData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.orderData.Rows[e.RowIndex];

                PartsNumTxtbox.Text = row.Cells["ProductID"].Value.ToString();
                qtyTxtbox.Text = row.Cells["qty"].Value.ToString();
            }
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            AddBtn.Enabled = false;
            RemoveBtn.Enabled = false;
            AddPartsBtn.Enabled = false;
        }
    }
}
