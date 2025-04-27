using Storages_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storages.Items
{
    public partial class frmItemContentInStorage : Form
    {

        private int _ItemID = -1;



        public frmItemContentInStorage(int ItemID)
        {
            InitializeComponent();
            _ItemID = ItemID;   
        }

       
        private static DataTable _dtAllItemContentinStorages;


        private DataTable _dtItemContentinStorages;


     


        private void _SumTotalSellAndBuy()
        {
            //sum
            decimal SumTotalBuy = 0;
            for (int i = 0; i < dgvItemContentInStorages.Rows.Count; i++)
            {

                SumTotalBuy += Convert.ToDecimal(dgvItemContentInStorages.Rows[i].Cells[5].Value);

            }
            lblSumTotalBuy.Text = SumTotalBuy.ToString();




            decimal SumTolalSell = 0;
            for (int i = 0; i < dgvItemContentInStorages.Rows.Count; i++)
            {

                SumTolalSell += Convert.ToDecimal(dgvItemContentInStorages.Rows[i].Cells[7].Value);

            }



            lblSumTotalSell.Text = SumTolalSell.ToString();

        }
    


        private void frmItemContentInStorage_Load(object sender, EventArgs e)
        {

            _dtAllItemContentinStorages = clsStorageContent.GetAllStorageContentsByItemID(_ItemID);

            _dtItemContentinStorages = _dtAllItemContentinStorages.DefaultView.ToTable(false, "ItemName", "UnitName", "Amount", "StorageName", "BuyPrice", "TotalBuyPrice", "SellPrice", "TotalSellPrice");





            dgvItemContentInStorages.DataSource = _dtItemContentinStorages;
            cbFilterBy.SelectedIndex = 0;


            _SumTotalSellAndBuy();


            if (dgvItemContentInStorages.Rows.Count > 0)
            {

                dgvItemContentInStorages.Columns[0].HeaderText = "اسم المنتج";
                dgvItemContentInStorages.Columns[0].Width = 110;

                dgvItemContentInStorages.Columns[1].HeaderText = "اسم الوحدة";
                dgvItemContentInStorages.Columns[1].Width = 110;



                dgvItemContentInStorages.Columns[2].HeaderText = "الكمية";
                dgvItemContentInStorages.Columns[2].Width = 160;

                dgvItemContentInStorages.Columns[3].HeaderText = "اسم المخزن";
                dgvItemContentInStorages.Columns[3].Width = 160;

                dgvItemContentInStorages.Columns[4].HeaderText = "سعر الشراء";
                dgvItemContentInStorages.Columns[4].Width = 160;

                dgvItemContentInStorages.Columns[5].HeaderText = "اجمالي سعر الشراء";
                dgvItemContentInStorages.Columns[5].Width = 160;

                dgvItemContentInStorages.Columns[6].HeaderText = "سعر البيع";
                dgvItemContentInStorages.Columns[6].Width = 160;

                dgvItemContentInStorages.Columns[7].HeaderText = "اجمالي سعر البيع";
                dgvItemContentInStorages.Columns[7].Width = 160;

            }
        }



        private void _RefreshStorageContentList()
        {

            _dtAllItemContentinStorages = clsStorageContent.GetAllStorageContentsByItemID(_ItemID);

            _dtItemContentinStorages = _dtItemContentinStorages.DefaultView.ToTable(false, "ItemName", "UnitName", "Amount","StorageName", "BuyPrice", "TotalBuyPrice", "SellPrice", "TotalSellPrice");

            dgvItemContentInStorages.DataSource = _dtItemContentinStorages;
            _SumTotalSellAndBuy();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {

                case "اسم المستودع":
                    FilterColumn = "StorageName";
                    break;

                case "اسم الوحدة":
                    FilterColumn = "UnitName";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }



            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtItemContentinStorages.DefaultView.RowFilter = "";
                _SumTotalSellAndBuy();




                return;

            }

            if (FilterColumn == "StoreContentID")
            {
                _dtItemContentinStorages.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtItemContentinStorages.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            _SumTotalSellAndBuy();
        }




       
        //private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //only input number for Person ID
        //    if (cbFilterBy.Text == "رقم المستودع" || cbFilterBy.Text == "رقم المستودع")
        //        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "لا شيء");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

       


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
