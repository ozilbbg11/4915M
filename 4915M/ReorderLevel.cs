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
    public partial class ReorderLevel : Form
    {
        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;
        public ReorderLevel()
        {
            InitializeComponent();
        }

        private void ReorderLevel_Load(object sender, EventArgs e)
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT ProductID, QtyOnHand,ReorderLevel, DangerLevel FROM storeinventory WHERE QtyOnHand<ReorderLevel", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                    dataRnD.DataSource = dtInfo;
                    button1.Enabled = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                MySqlCommand cm = new MySqlCommand("SELECT product.ProductName, storeinventory.ProductID, storeinventory.QtyOnHand, storeinventory.ReorderLevel, storeinventory.DangerLevel FROM storeinventory, product WHERE storeinventory.ProductID=product.ProductID AND QtyOnHand<ReorderLevel ; ", con);
                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["ProductID"].ToString());
                    item.SubItems.Add(dr["ProductName"].ToString());
                    item.SubItems.Add(dr["QtyOnHand"].ToString());
                    if (int.Parse(dr["QtyOnHand"].ToString()) < int.Parse(dr["DangerLevel"].ToString()))
                    {
                        item.SubItems.Add("Danger Level");
                    }
                    else
                    {
                        item.SubItems.Add("Re-order Level");
                    }
                    listView1.Items.Add(item);
                }
                tabControl1.SelectedTab = tabDispatchOrder;
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
