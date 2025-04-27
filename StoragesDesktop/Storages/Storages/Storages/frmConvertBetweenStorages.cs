using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BANK_Desktop.Global_Classes;
using Storages_BuisnessLayer;

namespace Storages
{
    public partial class frmConvertBetweenStorages : Form
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 };

        

        private enMode _Mode;
        clsOperationConvertStorgaes _OperationConvertStorgaes=new clsOperationConvertStorgaes();
        private int _OperationConvertStorageID = -1;

        public frmConvertBetweenStorages()
        {
            _Mode = enMode.AddMode;
            InitializeComponent();
        }



        private void _FillFromStoragesInComboBox()
        {
            DataTable dtStorages = new DataTable();
            dtStorages = clsStorage.GetAllStorages();
            foreach (DataRow Row in dtStorages.Rows)
            {
                cbxStorage1.Items.Add(Row["StorageName"]);
            }

        }

        private void _FillToStoragesInComboBox()
        {
            DataTable dtStorages = new DataTable();
            dtStorages = clsStorage.GetAllStorages();
            foreach (DataRow Row in dtStorages.Rows)
            {
                cbxStorage2.Items.Add(Row["StorageName"]);
            }

        }

        private void _FillEmployeesInComboBox()
        {
            DataTable dtEmployee = new DataTable();
            dtEmployee = clsEmployee.GetAllEmployees();
            foreach (DataRow Row in dtEmployee.Rows)
            {
                cbxEmployees.Items.Add(Row["UserNameEmployee"]);
            }


    

        }

        private void _FillItemsInComboBox()
        {
            DataTable dtItems = new DataTable();
            dtItems = clsItem.GetAllItems();
            foreach (DataRow Row in dtItems.Rows)
            {
                cbxItems.Items.Add(Row["ItemName"]);
            }
        }

        private void _FillUnitsByItemIDInComboBox(int ItemID)
        {
            DataTable dtUnits = new DataTable();
            dtUnits = clsUnit.GetAllUnitsByItemID(ItemID);
            foreach (DataRow Row in dtUnits.Rows)
            {
                cbxUnits.Items.Add(Row["UnitName"]);
            }
        }





        private void _ResetDefaultValue()
        {
            _FillFromStoragesInComboBox();
            _FillToStoragesInComboBox();
            _FillEmployeesInComboBox();
            _FillItemsInComboBox();
            cbxUnits.Enabled = false;   
            txtReasonOperation.Text = "";
       
        }

        private void _LoadData()
        {

     

            //txtAmount.Text = _OperationStorage.Amount.ToString();
            //txtReasonOperation.Text = _OperationStorage.ReasonOperation;

            //cbxStorage2.SelectedIndex = cbxStorage1.FindString(_Person.infoCountry.CountryName);
            //cbxUnits.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);
            //cbxItems.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);
            //cbxTypeOfTransaction.SelectedIndex= cbxCountries.FindString(_Person.infoCountry.CountryName); 
            //cbxEmployee.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);

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
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void ValidateNumericTextBox(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // تحقق إذا كان النص فارغًا أو غير رقم
            if (string.IsNullOrEmpty(textBox.Text.Trim()) || !int.TryParse(textBox.Text.Trim(), out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "الرجاء إدخال رقم صالح!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }
        }

        private void ValidateComboBoxSelection(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // تحقق إذا كانت القيمة المحددة هي القيمة الافتراضية (مثل القيمة الفارغة أو القيمة "الرجاء الاختيار")
            if (comboBox.SelectedIndex == -1 || string.IsNullOrEmpty(comboBox.SelectedItem?.ToString()))
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBox, "الرجاء اختيار قيمة من القائمة!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox, null);
            }
        }





        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // تحقق مما إذا كان المدخل رقم أو Backspace فقط
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // يمنع إدخال الحروف أو الرموز
            }
        }

        private void ConvertBetweenStorages_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int Amount = int.Parse(txtAmount.Text.Trim());
            string ReasonOperation = txtReasonOperation.Text;
            int StorageID1 = clsStorage.Find(cbxStorage1.Text).StorageID;
            int StorageID2 = clsStorage.Find(cbxStorage2.Text).StorageID;
            int ItemID = clsItem.Find(cbxItems.Text).ItemID;
            int UnitID = clsUnit.Find(cbxUnits.Text).UnitID;
            int EmployeeID = clsEmployee.Find(cbxEmployees.Text).EmployeeID;

            int ItemUnitID=0;
            bool resultItemUnits= clsItemUnits.GetUnitItemID(ItemID, UnitID, ref ItemUnitID);

            //_OperationConvertStorgaes.OperationConvertStoragesID = 1;
            _OperationConvertStorgaes.FromStorageID = StorageID1;
            _OperationConvertStorgaes.ToStorageID = StorageID2;
            _OperationConvertStorgaes.ItemUnitID = ItemUnitID;
            _OperationConvertStorgaes.AmountConvert = Amount;
            _OperationConvertStorgaes.ReasonOperation = ReasonOperation;
            _OperationConvertStorgaes.DateOperation = DateTime.Now;
            _OperationConvertStorgaes.EmployeeID = EmployeeID;
            _OperationConvertStorgaes.UserID = clsGlobal.CurrentUser.UserID;





            bool result1= clsStorageContent.IsItemUnitExistInStorages(ItemUnitID, StorageID1);
            if (result1)
            {
                bool result2 = clsStorageContent.IsAmountItemUnitExistInStorage(ItemUnitID, StorageID1, Amount);
                if (result2) {


                    if (_OperationConvertStorgaes.Save())
                    {
                        //lblTitle.Text = "Update Person";
                        //lblPersonID.Text = _Person.PersonID.ToString();
                        _Mode = enMode.UpdateMode;
                        MessageBox.Show("تم حفظ البيانات بنجاح.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //DataBack?.Invoke(this, _Person.PersonID);
                    }

                    else
                    {
                        MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    this.Close();




                }
                else {
                    MessageBox.Show("الكمية غير متوفرة في هذا المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("هذا المنتج/الوحدة غير موجود في هذا المخزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxUnits.Enabled = true;
            cbxUnits.Items.Clear();
            cbxUnits.Text = "";

            if (clsItemUnits.IsUnitIDExist(clsItem.Find(cbxItems.Text).ItemID))
            {
                _FillUnitsByItemIDInComboBox(clsItem.Find(cbxItems.Text).ItemID);
            }
            else
            {
                cbxUnits.Enabled = false;
            }
        }


        private void cbxStorages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
