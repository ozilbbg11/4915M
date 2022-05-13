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
    public partial class SaveStock : Form
    {
        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;
        public SaveStock()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabProd_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            String prodName = addPartName.Text;
            String prodPrice = addPrice.Text;
            String prodQty = addQty.Text;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        con.Open();
                        var myVariable = new MySqlCommand("SELECT MAX(ProductID) FROM product;", con);
                        int id = (int)myVariable.ExecuteScalar() + 1;
                        MySqlCommand cm = new MySqlCommand("INSERT INTO product VALUES("+id+", "+prodPrice+", '"+prodName+"', 'TR-01', 28273, null); ", con);
                        cm.ExecuteNonQuery();
                        cm = new MySqlCommand("INSERT INTO storeinventory VALUES(" + id + ", 1238, " + prodQty + ", 3000000, 200000,'KTC', null)", con);
                        cm.ExecuteNonQuery();
                    MessageBox.Show("Record is updated successfully! ");
                        this.Close();
                    }

        }
            catch
            {
                MessageBox.Show("Please input a valid amount! ");
            }
}

        private void Button6_Click(object sender, EventArgs e)
        {
            String edPID = EdID.Text;
            EdName.Text = null;
            EdPrice.Text = null;
            EdDL.Text = null;
            EdRL.Text = null;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    var pName = new MySqlCommand("SELECT ProductName FROM product WHERE ProductID = " + edPID + ";", con);
                    EdName.Text = pName.ExecuteScalar().ToString();
                    var QOH = new MySqlCommand("SELECT Price FROM product WHERE ProductID = " + edPID + ";", con);
                    EdPrice.Text = QOH.ExecuteScalar().ToString();
                    var Reorder = new MySqlCommand("SELECT ReorderLevel FROM storeinventory WHERE ProductID = " + edPID + ";", con);
                    EdRL.Text = Reorder.ExecuteScalar().ToString();
                    var Danger = new MySqlCommand("SELECT DangerLevel FROM storeinventory WHERE ProductID = " + edPID + ";", con);
                    EdDL.Text = Danger.ExecuteScalar().ToString();
                    EdName.ReadOnly = false;
                    EdPrice.ReadOnly = false;
                    EdDL.ReadOnly = false;
                    EdRL.ReadOnly = false;
                    button3.Enabled = true;

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException er)
            {
                MessageBox.Show("There is so such ProductID! ");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String ePID = EdID.Text;
            String eName = EdName.Text;
            String ePrice = EdPrice.Text;
            String RL = EdRL.Text;
            String DL = EdDL.Text;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    MySqlCommand cm = new MySqlCommand("UPDATE product SET ProductName= '"+eName+"', price= "+ePrice+" WHERE ProductID =" + ePID + ";", con);
                    cm.ExecuteNonQuery();
                    cm = new MySqlCommand("UPDATE storeinventory SET ReorderLevel= '" + RL + "', DangerLevel= " + DL + " WHERE ProductID =" + ePID + ";", con);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record is updated successfully! ");
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Please input a valid amount! ");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
