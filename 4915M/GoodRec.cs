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
    public partial class GoodRec : Form
    {
        public GoodRec()
        {
            InitializeComponent();
        }
        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;
        private Boolean backOrder = false;
        private void GoodRec_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var soNo = soNumTxtbox.Text;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    var status = new MySqlCommand("SELECT status FROM salesorder WHERE SalesOrderNo = " + soNo + ";", con);
                    String sta = status.ExecuteScalar().ToString();
                    if (sta == "PIC")
                    {
                        var dNum = new MySqlCommand("SELECT CustNo FROM salesorder WHERE SalesOrderNo = " + soNo + ";", con);
                        dNoTxtbox.Text = dNum.ExecuteScalar().ToString();
                        String dNo = dNoTxtbox.Text;
                        var staff = new MySqlCommand("SELECT StaffNo FROM salesorder WHERE SalesOrderNo = " + soNo + ";", con);
                        staffTxtbox.Text = staff.ExecuteScalar().ToString();
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

                        MySqlCommand cm = new MySqlCommand("SELECT salesorderlines.Qty, product.ProductName,salesorderlines.ProductID,salesorderlines.picked,salesorderlines.UnitPrice FROM product, salesorderlines WHERE salesorderlines.ProductID=product.ProductID and salesorderlines.SalesOrderNo = " + soNo + ";", con);
                        MySqlDataReader dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            if (int.Parse(dr["Qty"].ToString()) != 0)
                            {
                                backOrder = true;
                            }
                            ListViewItem item = new ListViewItem(dr["picked"].ToString());
                            item.SubItems.Add(dr["ProductID"].ToString());
                            item.SubItems.Add(dr["ProductName"].ToString());
                            item.SubItems.Add(dr["UnitPrice"].ToString());
                            listView1.Items.Add(item);
                        }

                        brnCon.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong sales order number ! ");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wrong sales order number ! ");
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrnCon_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                var soNo = soNumTxtbox.Text;
                if (backOrder == false) { 
                    MySqlCommand cm = new MySqlCommand("UPDATE salesorder set status='REC' where SalesOrderNo=" + soNo, con);
                    cm.ExecuteNonQuery();
                }
                MessageBox.Show("Record is updated successfully");
                this.Close();

            }
        }
    }
}
