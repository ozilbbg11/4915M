using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            Login li = new Login();

            li.Show();
        }

        private void AdminFunction_Click(object sender, EventArgs e)
        {
            Admin_Function af = new Admin_Function();

            af.Show();
        }

        private void DeliveryListBtn_Click(object sender, EventArgs e)
        {
            Delivery dy = new Delivery();

            dy.Show();
        }


        private void ChangeStockBtn_Click(object sender, EventArgs e)
        {
            ChangeStock cs = new ChangeStock();

            cs.Show();
        }

        
        private void SaveStockBtn_Click(object sender, EventArgs e)
        {
            SaveStock st = new SaveStock();

            st.Show();
        }

        private void StockInformationBtn_Click(object sender, EventArgs e)
        {
            StockInformationFrom sif = new StockInformationFrom();

            sif.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            switch (Login.departIDValue)
            {
                case "FA":
                    EditOrderBtn.Enabled = false;
                    DeliveryListBtn.Enabled = false;
                    ChangeStockBtn.Enabled = false;
                    PurchaseOrderBtn.Enabled = false;
                    SaveStockBtn.Enabled = false;
                    AdminFunction.Enabled = false;
                    PickPartBtn.Enabled = false;
                    GoodRecBtn.Enabled = false;
                    RnDLvBtn.Enabled = false;
                    DealerAdminBtn.Enabled = false;
                    SearchOrderBtn.Enabled = false;
                    break;
                case "PD":
                    EditOrderBtn.Enabled = false;
                    DeliveryListBtn.Enabled = false;
                    PurchaseOrderBtn.Enabled = false;
                    AdminFunction.Enabled = false;
                    DealerAdminBtn.Enabled = false;
                    PickPartBtn.Enabled = false;
                    GoodRecBtn.Enabled = false;
                    break;
                case "SH":
                    EditOrderBtn.Enabled = false;
                    ChangeStockBtn.Enabled = false;
                    PurchaseOrderBtn.Enabled = false;
                    SaveStockBtn.Enabled = false;
                    AdminFunction.Enabled = false;
                    DealerAdminBtn.Enabled = false;
                    RnDLvBtn.Enabled = false;
                    break;
                case "HR":
                    EditOrderBtn.Enabled = false;
                    DeliveryListBtn.Enabled = false;
                    ChangeStockBtn.Enabled = false;
                    PurchaseOrderBtn.Enabled = false;
                    SaveStockBtn.Enabled = false;
                    PickPartBtn.Enabled = false;
                    GoodRecBtn.Enabled = false;
                    RnDLvBtn.Enabled = false;
                    SearchOrderBtn.Enabled = false;
                    SearchCustBtn.Enabled = false;
                    StockInformationBtn.Enabled = false;
                    break;
                case "SL":
                    AdminFunction.Enabled = false;
                    DealerAdminBtn.Enabled = false;
                    DeliveryListBtn.Enabled = false;
                    ChangeStockBtn.Enabled = false;
                    SaveStockBtn.Enabled = false;
                    SaveStockBtn.Enabled = false;
                    PickPartBtn.Enabled = false;
                    GoodRecBtn.Enabled = false;
                    RnDLvBtn.Enabled = false;

                    break;
                default:
                    AdminFunction.Enabled = false;
                    DealerAdminBtn.Enabled = false;
                    break;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
        private void PickPartBtn_Click(object sender, EventArgs e)
        {
            PickParts pps = new PickParts();
            pps.Show();
        }

        private void GoodRecBtn_Click(object sender, EventArgs e)
        {
            GoodRec grc = new GoodRec();
            grc.Show();
        }

        private void RnDLvBtn_Click(object sender, EventArgs e)
        {
            ReorderLevel rol = new ReorderLevel();
            rol.Show();
        }

        private void DealerAdminBtn_Click(object sender, EventArgs e)
        {
            DealerAdmin dadm = new DealerAdmin();
            dadm.Show();
        }

        private void PurchaseOrderBtn_Click(object sender, EventArgs e)
        {
            Purchase_Order PO = new Purchase_Order();
            PO.Show();
        }

        private void EditOrderBtn_Click(object sender, EventArgs e)
        {
            EditOrder EO = new EditOrder();
            EO.Show();
        }

        private void SearchOrderBtn_Click(object sender, EventArgs e)
        {
            SerachOrder sod = new SerachOrder();
            sod.Show();
        }

        private void SearchCustBtn_Click(object sender, EventArgs e)
        {
            SearchDealer sdl = new SearchDealer();
            sdl.Show();
        }
    }
}
