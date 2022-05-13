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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private DataTable GetList()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM salesorder WHERE OrderDate = '" + CreationDate.Value.ToString("yyyy-MM-dd")+"' and status = 'CNF'", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        button1.Enabled = true;
                        GenOrderBtn.Enabled = true;
                    }

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }


        private void Delivery_Load(object sender, EventArgs e)
        {
           
        }


        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            dataBatchOrder.DataSource = GetList();
            tabControl1.SelectedTab = tabDispatchBatch;
        }

        private void GenOrderBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int index = dataBatchOrder.CurrentCell.RowIndex;
            String soNo = dataBatchOrder.Rows[index].Cells[0].Value.ToString();
            String dNo = dataBatchOrder.Rows[index].Cells[2].Value.ToString();
            soNoTxtbox.Text = soNo;
            dNoTxtbox.Text = dNo;
            staffTxtbox.Text = dataBatchOrder.Rows[index].Cells[1].Value.ToString();
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();

                var addtess = new MySqlCommand("SELECT InvoiceAddress FROM customer WHERE CustNo = " + dNo + ";", con);
                AddressTxtbox.Text = addtess.ExecuteScalar().ToString();
                var street = new MySqlCommand("SELECT InvoiceStreet FROM customer WHERE CustNo = " + dNo + ";", con);
                StreetTxtbox.Text = street.ExecuteScalar().ToString();
                var area = new MySqlCommand("SELECT InvoiceArea FROM customer WHERE CustNo = " + dNo + ";", con);
                AreaTxtbox.Text = area.ExecuteScalar().ToString();
                var tel = new MySqlCommand("SELECT PhoneNum FROM customer WHERE CustNo = " + dNo + ";", con);
                TelTxtbox.Text = tel.ExecuteScalar().ToString();
                var oDate = new MySqlCommand("SELECT OrderDate FROM salesorder WHERE SalesOrderNo = " + soNo + ";", con);
                oDateTxtbox.Text = ((DateTime)oDate.ExecuteScalar()).ToString("yyyy-MM-dd");
                var dDate = new MySqlCommand("SELECT OrderDate FROM salesorder WHERE SalesOrderNo = " + soNo + ";", con);
                dDateTxtbox.Text = ((DateTime)dDate.ExecuteScalar()).ToString("yyyy-MM-dd");

                MySqlCommand cm = new MySqlCommand("SELECT product.ProductName,salesorderlines.ProductID,salesorderlines.qty,salesorderlines.UnitPrice FROM product, salesorderlines WHERE salesorderlines.ProductID=product.ProductID and salesorderlines.SalesOrderNo = " + soNo + ";", con);
                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["ProductID"].ToString());
                    item.SubItems.Add(dr["ProductName"].ToString());
                    item.SubItems.Add(dr["qty"].ToString());
                    item.SubItems.Add(dr["UnitPrice"].ToString());
                    item.SubItems.Add((int.Parse(dr["qty"].ToString())* int.Parse(dr["UnitPrice"].ToString())).ToString());
                    listView1.Items.Add(item);  
                }
                btnCon.Enabled = true;
                tabControl1.SelectedTab = tabDispatchOrder;



            }

        }

        private void BtnCon_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                String soNo = soNoTxtbox.Text;
                MySqlCommand cm = new MySqlCommand("UPDATE salesorder SET status='GDN' WHERE SalesOrderNo=" + soNo, con);
                MySqlDataReader dr = cm.ExecuteReader();
                con.Close();
                MessageBox.Show("The Dispatch Note of salesorder number: "+ soNo+" has been generated! ");
                this.Close();

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                String soNo = soNoTxtbox.Text;
                MySqlCommand cm = new MySqlCommand("UPDATE salesorder SET status='GDN' WHERE OrderDate='" + CreationDate.Value.ToString("yyyy-MM-dd")+"';", con);
                MySqlDataReader dr = cm.ExecuteReader();
                con.Close();
                MessageBox.Show("The Dispatch Notes of this patch of orders has been generated! ");
                this.Close();

            }
        }

        private void TabDispatchOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
