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
    public partial class PickParts : Form
    {
        public PickParts()
        {
            InitializeComponent();
        }

        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;

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
                    if (sta == "GDN"|| sta == "PIC")
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

                        MySqlCommand cm = new MySqlCommand("SELECT product.ProductName,salesorderlines.ProductID,salesorderlines.qty,salesorderlines.UnitPrice FROM product, salesorderlines WHERE salesorderlines.ProductID=product.ProductID and salesorderlines.SalesOrderNo = " + soNo + ";", con);
                        MySqlDataReader dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            ListViewItem item = new ListViewItem(dr["qty"].ToString());
                            item.SubItems.Add(dr["qty"].ToString());
                            item.SubItems.Add(dr["ProductID"].ToString());
                            item.SubItems.Add(dr["ProductName"].ToString());
                            item.SubItems.Add(dr["UnitPrice"].ToString());
                            listView1.Items.Add(item);
                        }

                        brnCon.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("There is so such sales order number which ready for Picking! ");
                    }
                }
            }
            catch
            {
                MessageBox.Show("There is so such sales order number which ready for Picking! ");
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


       

        private void PickParts_Load(object sender, EventArgs e)
        {
            listView1.LabelEdit = true;

        }

        private void BrnCon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                int real = int.Parse(listView1.Items[i].SubItems[0].Text);
                int qty = int.Parse(listView1.Items[i].SubItems[1].Text);
                if (real > qty)
                {
                    MessageBox.Show("Qty overloaded !");
                    listView1.Items[i].SubItems[0].Text = qty.ToString();
                    return;
                }
            }
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                var soNo = soNumTxtbox.Text;
                MySqlCommand cm = new MySqlCommand("UPDATE salesorder set status='PIC' where SalesOrderNo=" + soNo, con); 
                cm.ExecuteNonQuery();
                cm = new MySqlCommand("SELECT ProductID, qty from salesorderlines where SalesOrderNo= " + soNo + ";", con);
                MySqlDataReader dr = cm.ExecuteReader();
                String ProductID;
                String Quantity;
                String RealQty;
                int i = 0;
                String code="";
                while (dr.Read()) {
                    ProductID = dr["ProductID"].ToString();
                    Quantity = dr["qty"].ToString();
                    RealQty = listView1.Items[i].SubItems[0].Text;
                    code += "UPDATE salesorderlines set qty="+ (int.Parse(Quantity)- int.Parse(RealQty)) + ", Picked=" + RealQty + " where ProductID = " + ProductID + " AND SalesOrderNo= " + soNo + " ;";
                    i++;
                }
                dr.Close();
                cm = new MySqlCommand(code, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record is updated successfully");
                this.Close();


            }
        }


        private void ListView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    int real = int.Parse(listView1.Items[i].SubItems[0].Text);
                    int qty = int.Parse(listView1.Items[i].SubItems[1].Text);
                    if (real > qty)
                    {
                        MessageBox.Show("Qty overloaded !");
                        listView1.Items[i].SubItems[0].Text = qty.ToString();
                    }
                }
        }
    }
}
