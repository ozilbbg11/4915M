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
    public partial class SearchDealer : Form
    {
        public SearchDealer()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        String connString = ConfigurationManager.ConnectionStrings["4915M.Properties.Settings.slmcConnectionString"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            stockInfoDataGridView.DataSource = GetListAll();
        }

        private DataTable GetListAll()
        {
            DataTable dtInfo = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (partsNum.Text.Length == 0)
            {
                MessageBox.Show("Please enter the dealer number !");
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
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer WHERE CustNo = "+ int.Parse(partsNum.Text), con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtInfo.Load(reader);
                }
            }

            return dtInfo;
        }

        private void SearchDealer_Load(object sender, EventArgs e)
        {
            stockInfoDataGridView.DataSource = GetListAll();
        }

        private void stockInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.stockInfoDataGridView.Rows[e.RowIndex];

                partsNum.Text = row.Cells["CustNo"].Value.ToString();
            }
        }
    }
}
