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
    public partial class StockInformationFrom : Form
    {
        public StockInformationFrom()
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
            stockInfoDataGridView.DataSource = GetList();
        }

        private DataTable GetList()
        {
            DataTable dtInfo = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM storeinventory WHERE ProductID = " + int.Parse(partsNum.Text), con))
                    {
                        con.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        dtInfo.Load(reader);
                    }
                }
            }
            
            catch
            {
                MessageBox.Show("Please enter the Product ID ");
            }
            return dtInfo;
        }

        private void stockInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private DataTable GetListAll()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM storeinventory", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void all_Click(object sender, EventArgs e)
        {
            stockInfoDataGridView.DataSource = GetListAll();
        }

        private void StockInfoDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockInformationFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
