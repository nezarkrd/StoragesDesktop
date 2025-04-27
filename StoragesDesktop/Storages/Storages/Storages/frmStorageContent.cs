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

namespace Storages.Storages
{
    public partial class frmStorageContent : Form
    {

        private static int _StorageID = -1;
        private static DataTable _dtAllStorageContent; 


        private DataTable _dtStorageContent;


        public frmStorageContent(int storageID)
        {
            InitializeComponent();
            _StorageID = storageID;
           
          
        }


    private void _SumTotalSellAndBuy()
        {
            //sum
            decimal SumTotalBuy = 0;
            for (int i = 0; i < dgvStoragesContent.Rows.Count; i++)
            {

                SumTotalBuy += Convert.ToDecimal(dgvStoragesContent.Rows[i].Cells[4].Value);

            }
            lblSumTotalBuy.Text = SumTotalBuy.ToString();




            decimal SumTolalSell = 0;
            for (int i = 0; i < dgvStoragesContent.Rows.Count; i++)
            {

                SumTolalSell += Convert.ToDecimal(dgvStoragesContent.Rows[i].Cells[6].Value);

            }



            lblSumTotalSell.Text = SumTolalSell.ToString();

        }
    private void frmStorageContent_Load(object sender, EventArgs e)
        {

            _dtAllStorageContent= clsStorageContent.GetAllStorageContentsByStorageID(_StorageID);
          
            if (_dtAllStorageContent.Rows.Count == 0)
            {
                MessageBox.Show("المخزن فارغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
            else
            {
                _dtStorageContent = _dtAllStorageContent.DefaultView.ToTable(false, "ItemName", "UnitName", "Amount", "BuyPrice", "TotalBuyPrice", "SellPrice", "TotalSellPrice");





                dgvStoragesContent.DataSource = _dtStorageContent;
                cbFilterBy.SelectedIndex = 0;


                _SumTotalSellAndBuy();


                if (dgvStoragesContent.Rows.Count > 0)
                {

                    dgvStoragesContent.Columns[0].HeaderText = "اسم المنتج";
                    dgvStoragesContent.Columns[0].Width = 110;

                    dgvStoragesContent.Columns[1].HeaderText = "اسم الوحدة";
                    dgvStoragesContent.Columns[1].Width = 110;



                    dgvStoragesContent.Columns[2].HeaderText = "الكمية";
                    dgvStoragesContent.Columns[2].Width = 160;

                    dgvStoragesContent.Columns[3].HeaderText = "سعر الشراء";
                    dgvStoragesContent.Columns[3].Width = 160;

                    dgvStoragesContent.Columns[4].HeaderText = "اجمالي سعر الشراء";
                    dgvStoragesContent.Columns[4].Width = 160;

                    dgvStoragesContent.Columns[5].HeaderText = "سعر البيع";
                    dgvStoragesContent.Columns[5].Width = 160;

                    dgvStoragesContent.Columns[6].HeaderText = "اجمالي سعر البيع";
                    dgvStoragesContent.Columns[6].Width = 160;

                }


            }



        }



        
       
        
        private void _RefreshStorageContentList()
        {

            _dtAllStorageContent = clsStorageContent.GetAllStorageContentsByStorageID(_StorageID);

            _dtStorageContent = _dtAllStorageContent.DefaultView.ToTable(false, "ItemName", "UnitName", "Amount", "BuyPrice", "TotalBuyPrice", "SellPrice", "TotalSellPrice");

            dgvStoragesContent.DataSource = _dtStorageContent;
            _SumTotalSellAndBuy();
        }


     
        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
              
                case "اسم المنتج":
                    FilterColumn = "ItemName";
                    break;

          

                default:
                    FilterColumn = "None";
                    break;

            }



            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtStorageContent.DefaultView.RowFilter = "";
                _SumTotalSellAndBuy();




                return;

            }

            if (FilterColumn == "StoreContentID")
            {
                _dtStorageContent.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtStorageContent.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            _SumTotalSellAndBuy();
        }


        //private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //only input number for Person ID
        //    if (cbFilterBy.Text == "رقم المخزن")
        //        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}




        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "لا شيء");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
