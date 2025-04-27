using Storages.Properties;
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
    public partial class frmShowItem : Form
    {



        private clsItem _Item;
        private int _ItemID = -1;

        public int ItemID
        {

            get { return _ItemID; }
        }

        public clsItem ItemInfo
        {

            get { return _Item; }
        }





        public frmShowItem(int ItemID)
        {
            InitializeComponent();
            _ItemID= ItemID;
            _Item = clsItem.Find(ItemID);
            //LoadItemInfo(_ItemID);
        }


        public void ResetItemInfo()
        {
            _ItemID = -1;
            lblItemID.Text = "[????]";
            lblItemName.Text = "[????]";
            lblCategory.Text = "[????]";
            txtDiscription.Text = "[????]";
          



        }
        private void _FillItemInfo()
        {
            _ItemID = _Item.ItemID;
            lblItemID.Text = _Item.ItemID.ToString();
            lblItemName.Text = _Item.ItemName;
            lblCategory.Text = clsCategory.Find(_Item.CategoryID).CategoryName;
            txtDiscription.Text = _Item.Description;
      



        }


        private static DataTable _dtAllItemsUnits;

        private void _RefreshItemsUnitsList()
        {


            _dtAllItemsUnits = clsItemUnits.GetAllItemsUnitsByItemID(_Item.ItemID);
            //DataTable _dtItemsUnits = _dtAllItemsUnits.DefaultView.ToTable(false, "ItemUnitID", "ItemID", "UnitID", "BuyPrice", "SellPrice");
            dgvUnitsItems.DataSource = _dtAllItemsUnits;

            if (dgvUnitsItems.Rows.Count > 0)
            {

               



                dgvUnitsItems.Columns[0].HeaderText = "رقم وحدة-منتج";
                dgvUnitsItems.Columns[0].Width = 150;

                dgvUnitsItems.Columns[1].HeaderText = "اسم المنتج";
                dgvUnitsItems.Columns[1].Width = 150;


                dgvUnitsItems.Columns[2].HeaderText = "اسم الوحدة";
                dgvUnitsItems.Columns[2].Width = 170;


                dgvUnitsItems.Columns[3].HeaderText = "سعر الشراء";
                dgvUnitsItems.Columns[3].Width = 190;

                dgvUnitsItems.Columns[4].HeaderText = "سعر البيع";
                dgvUnitsItems.Columns[4].Width = 190;



            }





        }

        private void frmShowItem_Load(object sender, EventArgs e)
        {
            _Item = clsItem.Find(ItemID);
            if (_Item == null)
            {
                ResetItemInfo();
                MessageBox.Show("لا يوجد شخص بهذا الرقم=" + _ItemID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillItemInfo();
            _RefreshItemsUnitsList();

        }


        public void LoadItemInfo(int ItemID)
        {



        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStorageContent_Click(object sender, EventArgs e)
        {

            if (clsStorageContent.isItemInStoragesExist(_ItemID))
            {

                frmItemContentInStorage frm = new frmItemContentInStorage(_ItemID);
                frm.ShowDialog();


            }
            else
            {
                MessageBox.Show("المنتج غير متوفر");

            }



        }

        private void dgvUnitsItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
