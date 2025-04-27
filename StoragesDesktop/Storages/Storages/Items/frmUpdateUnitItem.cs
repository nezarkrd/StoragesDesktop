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
    public partial class frmUpdateUnitItem : Form
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 };

        private enMode _Mode;
        clsItemUnits _ItemUnit;
        private int _UnitItemID = -1;


        private void _FillUnitsInComboBox()
        {
            DataTable dtUnits = new DataTable();
            dtUnits = clsUnit.GetAllUnits();
            foreach (DataRow Row in dtUnits.Rows)
            {
                cbxUnits.Items.Add(Row["UnitName"]);
            }



        }

        public frmUpdateUnitItem(int UnitItemID)
        {
            InitializeComponent();
            _UnitItemID = UnitItemID;
            _Mode = enMode.UpdateMode;
        }
      

        private void frmUpdateUnitItem_Load(object sender, EventArgs e)
        {
            _FillUnitsInComboBox();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
        }



        
        private void _LoadData()
        {
            _ItemUnit=clsItemUnits.Find(_UnitItemID);
            
            
            if (_ItemUnit == null)
            {
                MessageBox.Show("لا يوجد وحدة منتج بهذا الرقم" + _UnitItemID, "وحدة المنتج غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            
            txtItemUnitBuyPrice.Text=_ItemUnit.BuyPrice.ToString();
            txtItemUnitSellPrice.Text=_ItemUnit.SellPrice.ToString();
            cbxUnits.Text = clsUnit.Find(_ItemUnit.UnitID).UnitName;




        }
        










        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "الحقل مطلوب!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }



        

        private void btnAddUnitItem_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _ItemUnit.UnitID = clsUnit.Find(cbxUnits.Text).UnitID;
            _ItemUnit.BuyPrice = Decimal.Parse(txtItemUnitBuyPrice.Text.Trim());
            _ItemUnit.SellPrice = Decimal.Parse(txtItemUnitSellPrice.Text.Trim());



            if (_ItemUnit.Save())
            {


                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم حفظ وحدة المنتج  بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DataBack?.Invoke(this, _Person.PersonID);
            }

            else
            {
                MessageBox.Show("خطأ: لم يتم الحفظ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
