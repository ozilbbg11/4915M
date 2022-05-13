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
    public partial class ChangeStock : Form
    {
        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;
        public ChangeStock()
        {
            InitializeComponent();
        }

        private void ChangeStock_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchPartsBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnConAdd.Enabled = true;
            txtAdd.ReadOnly = false;
            btnConRed.Enabled = false;
            txtReduce.ReadOnly = true;
        }

        private void BtnConAdd_Click(object sender, EventArgs e)
        {
            String prodID = PartsNumTxtbox.Text;
            try
            {
                if (int.Parse(txtAdd.Text) > 0)
                {
                    String adding = txtAdd.Text;

                    using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        con.Open();
                        MySqlCommand cm = new MySqlCommand("UPDATE storeinventory SET QtyOnHand = (QtyOnHand + " + int.Parse(adding) + ") WHERE ProductID =" + prodID + ";", con);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Record is updated successfully! ");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please input a valid amount! ");
                }
            }
            catch
            {
                MessageBox.Show("Please input a valid amount! ");
            }
        }

        private void BtnReduce_Click(object sender, EventArgs e)
        {
            btnConRed.Enabled = true;
            txtReduce.ReadOnly = false;
            btnConAdd.Enabled = false;
            txtAdd.ReadOnly = true;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String prodID = PartsNumTxtbox.Text;
            ProductNameTxtbox.Text = null;
            qtyTxt.Text = null;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    var pName = new MySqlCommand("SELECT ProductName FROM product WHERE ProductID = " + prodID + ";", con);
                    ProductNameTxtbox.Text = pName.ExecuteScalar().ToString();
                    var QOH = new MySqlCommand("SELECT QtyOnHand FROM storeinventory WHERE ProductID = " + prodID + ";", con);
                    qtyTxt.Text = QOH.ExecuteScalar().ToString();
                    btnAdd.Enabled = true;
                    btnReduce.Enabled = true;
                    
                }
            }
            catch
            {
                MessageBox.Show("There is so such ProductID! ");
            }        

        }

        private void BtnConRed_Click(object sender, EventArgs e)
        {
            String prodID = PartsNumTxtbox.Text;
            try
            {
                if (int.Parse(txtReduce.Text) > 0&& int.Parse(qtyTxt.Text)> int.Parse(txtReduce.Text))
                {
                    String reduce = txtReduce.Text;

                    using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        con.Open();
                        MySqlCommand cm = new MySqlCommand("UPDATE storeinventory SET QtyOnHand = (QtyOnHand - " + reduce + ") WHERE ProductID =" + prodID + ";", con);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Record is updated successfully! ");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please input a valid amount! ");
                }
            }
            catch
            {
                MessageBox.Show("Please input a valid amount! ");
            }
        }
    }
}
