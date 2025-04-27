using Storages.Employees;
using Storages.Items;
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

namespace Storages
{
    public partial class frmAddUpdateItem : Form
    {

        public enum enMode { AddMode = 0, UpdateMode = 1 };
        private enMode _Mode;
        clsItem _Item;
        clsItemUnits _ItemUnits;
        private int _ItemID = -1;
        

        public frmAddUpdateItem()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

    

        public frmAddUpdateItem(int ItemID)
        {
            InitializeComponent();
            _ItemID = ItemID;
            _Mode = enMode.UpdateMode;
        }




        private void _FillCatogriesInComboBox()
        {
            DataTable dtCatogries = new DataTable();
            dtCatogries = clsCategory.GetAllCategories();
            foreach (DataRow Row in dtCatogries.Rows)
            {
                cbxItemCategory.Items.Add(Row["CategoryName"]);
            }



        }

        private void _FillUnitsInComboBox()
        {
            DataTable dtUnits = new DataTable();
            dtUnits = clsUnit.GetAllUnits();
            foreach (DataRow Row in dtUnits.Rows)
            {
                cbxUnits.Items.Add(Row["UnitName"]);
            }



        }




        private void _ResetDefaultValue()
        {

            _FillCatogriesInComboBox();
            _FillUnitsInComboBox();
            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "اضافة منتج جديد";
                _Item = new clsItem();
            }
            else
            {
                lblTitle.Text = "تعديل معلومات المنتج";

            }



            txtItemName.Text = "";
            txtItemInfo.Text = "";
            cbxItemCategory.SelectedIndex = 0;
            txtItemUnitBuyPrice.Text = "";
            txtItemUnitSellPrice.Text = "";

        }

        /*
        
        private static DataTable _dtItemsUnits = clsItemUnits.GetAllItemsUnitsByItemID(_Item.ItemID);
        private void _RefreshItemsList()
        {

            _dtAllItems = clsItem.GetAllItems();



            dgvItems.DataSource = _dtAllItems;
            lblRecordsCount.Text = dgvItems.Rows.Count.ToString();
        }

        */
        private void _LoadData()
        {
            _Item = clsItem.Find(_ItemID);
            lblItemID.Text = _Item.ItemID.ToString();
            if (_Item == null)
            {
                MessageBox.Show("لا يوجد منتج بهذا الرقم= " + _ItemID, "المنتج غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            _Item.CategoryInfo=clsCategory.Find(_Item.CategoryID);
            txtItemName.Text = _Item.ItemName;
            txtItemInfo.Text = _Item.Description;
            cbxItemCategory.SelectedIndex = cbxItemCategory.FindString(_Item.CategoryInfo.CategoryName);
            txtItemUnitBuyPrice.Text = "";
            txtItemUnitSellPrice.Text = "";
            _RefreshItemsUnitsList();

        }



        private void frmAddUpdateItem_Load(object sender, EventArgs e)
        {

            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
            tapUnitesPrices.Enabled = false;
            if (_Mode == enMode.UpdateMode) { btnNext.Enabled = true; }
            else { btnNext.Enabled = false; }  










        }


        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "الحقل غير مطلوب");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }


        private void btnSaveItem1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        
            _Item.ItemName = txtItemName.Text.Trim();
            _Item.Description = txtItemInfo.Text.Trim();
            _Item.CategoryID = clsCategory.Find(cbxItemCategory.Text).CategoryID;
            _Item.CategoryInfo = clsCategory.Find(_Item.CategoryID);

            if (_Item.Save())
            {
                lblTitle.Text = "تحديث معلومات المنتج";
                lblItemID.Text = _Item.ItemID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show(".تم حفظ المنتج بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DataBack?.Invoke(this, _Person.PersonID);
                btnNext.Enabled = true;
                
            }

            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         

        }



        private void tapItemDetails_Click(object sender, EventArgs e)
        {

        }









        //page 2

        DataTable _dtAllItemsUnits;
        private void btnNext_Click(object sender, EventArgs e)
        {
            tapItemDetails.Enabled=true;   
            tapUnitesPrices.Enabled = true;
            tabControl1.SelectedIndex = 1;
            _RefreshItemsUnitsList();


        }





        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmAddUpdateUnit frm=new frmAddUpdateUnit();
            frm.ShowDialog();
            _FillUnitsInComboBox();
        }






        private void _RefreshItemsUnitsList()
        {


            _dtAllItemsUnits = clsItemUnits.GetAllItemsUnitsByItemID(_Item.ItemID);
            //DataTable _dtItemsUnits = _dtAllItemsUnits.DefaultView.ToTable(false, "ItemUnitID", "ItemID", "UnitID", "BuyPrice", "SellPrice");
            dgvUnitsItems.DataSource = _dtAllItemsUnits;

            if (dgvUnitsItems.Rows.Count > 0)
            {
                dgvUnitsItems.Columns[0].HeaderText = "الرقم";
                dgvUnitsItems.Columns[0].Width = 120;



                dgvUnitsItems.Columns[1].HeaderText = "اسم المنتج";
                dgvUnitsItems.Columns[1].Width = 120;



                dgvUnitsItems.Columns[2].HeaderText = "اسم الوحدة";
                dgvUnitsItems.Columns[2].Width = 150;

                dgvUnitsItems.Columns[3].HeaderText = "سعر الشراء";
                dgvUnitsItems.Columns[3].Width = 150;


                dgvUnitsItems.Columns[4].HeaderText = "سعر البيع";
                dgvUnitsItems.Columns[4].Width = 170;







            }





        }

        private void btnAddUnitItem_Click(object sender, EventArgs e)
        {
            if(cbxUnits.Text=="اختر الوحدة") 
            { MessageBox.Show("الرجاء اختيار الوحدة", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtItemUnitBuyPrice.Text == "")
            { MessageBox.Show("الرجاء كتابة سعر الشراء", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtItemUnitSellPrice.Text == "")
            { MessageBox.Show("الرجاء كتابة سعر البيع", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            _ItemUnits =new clsItemUnits();

            _ItemUnits.UnitID =clsUnit.Find(cbxUnits.Text).UnitID;
            _ItemUnits.ItemID = _Item.ItemID;
            _ItemUnits.BuyPrice = decimal.Parse( txtItemUnitBuyPrice.Text.Trim());
            _ItemUnits.SellPrice = decimal.Parse(txtItemUnitSellPrice.Text.Trim());

            if (_ItemUnits.Save())
            {
               // lblTitle.Text = "تحديث معلومات المنتج";
                //lblItemID.Text = _Item.ItemID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم اضافة الوحدة للمنتج بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshItemsUnitsList();
                //DataBack?.Invoke(this, _Person.PersonID);
            }

            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void txtNumberOfContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUnitItem frm=new frmUpdateUnitItem((int)dgvUnitsItems.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshItemsUnitsList();
         
        }

        private void dgvUnitsItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsItemUnits.DeleteItemUnit((int)dgvUnitsItems.CurrentRow.Cells[0].Value);
            _RefreshItemsUnitsList();
        }
    }
}
