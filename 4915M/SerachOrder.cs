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
    public partial class SerachOrder : Form
    {
        public SerachOrder()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (orderNum.Text.Length == 0)
            {
                MessageBox.Show("Please input the order number!");
            }
            else
            {
                stockInfoDataGridView.DataSource = GetList();
            }
        }

        private DataTable GetList()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT salesorder.SalesOrderNo, staffNo, salesorder.CustNo, CustName, OrderDate, ManyDays, DeliveryDate, salesorder.status, salesorderlines.ProductID, ProductName, qty, UnitPrice FROM salesorder, salesorderlines, product, customer WHERE salesorder.SalesOrderNo = salesorderlines.SalesOrderNo AND salesorderlines.ProductID = product.ProductID AND salesorder.CustNo = customer.CustNo AND salesorder.SalesOrderNo = " + int.Parse(orderNum.Text), con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stockInfoDataGridView.DataSource = GetListAll();
        }

        private DataTable GetListAll()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT salesorder.SalesOrderNo, staffNo, salesorder.CustNo, CustName, OrderDate, ManyDays, DeliveryDate, salesorder.status, salesorderlines.ProductID, ProductName, qty, UnitPrice FROM salesorder, salesorderlines, product, customer WHERE salesorder.SalesOrderNo = salesorderlines.SalesOrderNo AND salesorderlines.ProductID = product.ProductID AND salesorder.CustNo = customer.CustNo ORDER BY SalesOrderNo ASC", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void SerachOrder_Load(object sender, EventArgs e)
        {
            stockInfoDataGridView.DataSource = GetListAll();
            if(Login.departIDValue== "SL")
            {
                confirmOrderBtn.Enabled = true;
                cancelOrderBtn.Enabled = true;
            }
        }

        private void stockInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.stockInfoDataGridView.Rows[e.RowIndex];

                orderNum.Text = row.Cells["SalesOrderNo"].Value.ToString();
                custNum.Text = row.Cells["CustNo"].Value.ToString();
                dateTimePicker1.Text = row.Cells["OrderDate"].Value.ToString();
            }
        }

        private void SearchDateBtn_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text.Length == 0)
            {
                MessageBox.Show("Please input the order date!");
            }
            else
            {
                stockInfoDataGridView.DataSource = GetListDate();
            }
        }

        private DataTable GetListDate()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT salesorder.SalesOrderNo, staffNo, salesorder.CustNo, CustName, OrderDate, ManyDays, DeliveryDate, salesorder.status, salesorderlines.ProductID, ProductName, qty, UnitPrice FROM salesorder, salesorderlines, product, customer WHERE salesorder.SalesOrderNo = salesorderlines.SalesOrderNo AND salesorderlines.ProductID = product.ProductID AND salesorder.CustNo = customer.CustNo AND OrderDate = '" + dateTimePicker1.Text + "'", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void SearchCustNoBtn_Click(object sender, EventArgs e)
        {
            if (custNum.Text.Length == 0)
            {
                MessageBox.Show("Please input the customer number!");
            }
            else
            {
                stockInfoDataGridView.DataSource = GetListCustNo();
            }            
        }

        private DataTable GetListCustNo()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT salesorder.SalesOrderNo, staffNo, salesorder.CustNo, CustName, OrderDate, ManyDays, DeliveryDate, salesorder.status, salesorderlines.ProductID, ProductName, qty, UnitPrice FROM salesorder, salesorderlines, product, customer WHERE salesorder.SalesOrderNo = salesorderlines.SalesOrderNo AND salesorderlines.ProductID = product.ProductID AND salesorder.CustNo = customer.CustNo AND salesorder.CustNo = '" + int.Parse(custNum.Text) + "'", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderNum.Text.Length == 0)
            {
                MessageBox.Show("Please input the order number!");
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE salesorder SET status = 'CNF' WHERE SalesOrderNo = " + int.Parse(orderNum.Text), con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }            

            stockInfoDataGridView.DataSource = GetList();
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderNum.Text.Length == 0)
            {
                MessageBox.Show("Please input the order number!");
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE salesorder SET status = 'CAN' WHERE SalesOrderNo = " + int.Parse(orderNum.Text), con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }            

            stockInfoDataGridView.DataSource = GetList();
        }
    }
}
