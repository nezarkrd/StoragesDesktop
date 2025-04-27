using BANK_Desktop.Global_Classes;
using Storages.Properties;
using Storages_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storages
{
    public partial class frmOperationsStorages : Form
    {

        // Declare an event using the delegate
        //public event DataBackEventHandler DataBack;

        public enum enMode { AddMode = 0, UpdateMode = 1 };
       


        private enMode _Mode;
        clsOperationsStorages _OperationStorage;
        private int _OperationStorageID = -1;



        //public delegate void DataBackEventHandler(object sender, int PersonID);


        public frmOperationsStorages()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmOperationsStorages(int OperationStorageID)
        {
            InitializeComponent();
            _OperationStorageID = OperationStorageID;
            _Mode = enMode.UpdateMode;
        }
   

      

   


   

        private void _FillStoragesInComboBox()
        {
            DataTable dtStorages = new DataTable();
            dtStorages = clsStorage.GetAllStorages();
            foreach (DataRow Row in dtStorages.Rows)
            {
                cbxStorages.Items.Add(Row["StorageName"]);
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

        private void _FillUnitsInComboBox()
        {
            DataTable dtUnits = new DataTable();
            dtUnits = clsUnit.GetAllUnits();
            foreach (DataRow Row in dtUnits.Rows)
            {
                cbxUnits.Items.Add(Row["UnitName"]);
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


        private void _FillTypesOfTransactionsInComboBox()
        {
      
            cbxTypeOfTransaction.Items.Add("اضافة");
            cbxTypeOfTransaction.Items.Add("سحب");
        }

        private void _FillEmployeesInComboBox()
        {
            DataTable dtEmployee = new DataTable();
            dtEmployee = clsEmployee.GetAllEmployees();
            foreach (DataRow Row in dtEmployee.Rows)
            {
                cbxEmployee.Items.Add(Row["UserNameEmployee"]);
            }


           

        }



        private void _ResetDefaultValue()
        {
            _FillStoragesInComboBox();
            _FillItemsInComboBox();
            cbxUnits.Enabled = false;
            //_FillUnitsInComboBox();
            _FillTypesOfTransactionsInComboBox();
            _FillEmployeesInComboBox();
            txtAmount.Text = "";
            txtReasonOperation.Text = "";
            if (_Mode == enMode.AddMode)
            {
                //lblTitle.Text = "Add New Person";
                _OperationStorage = new clsOperationsStorages();
            }
            else
            {
                //lblTitle.Text = "Update Person";

            }

    




        }

     
        private void _LoadData()
        {
            
            _OperationStorage = clsOperationsStorages.Find(_OperationStorageID);
            //lblPersonID.Text = _Person.PersonID.ToString();
            if (_OperationStorage == null)
            {
                MessageBox.Show("لا يوجد عملية بهذا الرقم=" + _OperationStorageID, "رقم العملية غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtAmount.Text = _OperationStorage.Amount.ToString();
            txtReasonOperation.Text= _OperationStorage.ReasonOperation;

            //cbxStorages.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);
            //cbxUnits.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);
            //cbxItems.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);
            //cbxTypeOfTransaction.SelectedIndex= cbxCountries.FindString(_Person.infoCountry.CountryName); 
            //cbxEmployee.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);

        }
        private void frmOperationsStorages_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
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







        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            _OperationStorage.Amount = int.Parse(txtAmount.Text.Trim());
            _OperationStorage.ReasonOperation = txtReasonOperation.Text;

            int StorageID = clsStorage.Find(cbxStorages.Text).StorageID;
            int ItemID = clsItem.Find(cbxItems.Text).ItemID;
            int UnitID = clsUnit.Find(cbxUnits.Text).UnitID;
            int EmployeeID = clsEmployee.Find(cbxEmployee.Text).EmployeeID;
            short TypeOfTransaction = 0;

            if (cbxTypeOfTransaction.Text == "اضافة")
            {
                TypeOfTransaction = 1;
            }
            if (cbxTypeOfTransaction.Text == "سحب")
            {
                TypeOfTransaction = 2;
            }

            _OperationStorage.StorageID = StorageID;
            _OperationStorage.TypeOperation = TypeOfTransaction;
            _OperationStorage.DateOperation = DateTime.Now;
            _OperationStorage.EmployeeID = EmployeeID;
            _OperationStorage.UserID = clsGlobal.CurrentUser.UserID;

            //_OperationStorage.ItemUnitID
            int ItemUnitID = 0;
            if (clsOperationsStorages.GetUnitItemID(ItemID, UnitID, ref ItemUnitID))
            {

                _OperationStorage.ItemUnitID = ItemUnitID;


            }
            else
            {

                MessageBox.Show("هذه الوحدة غير موجودة في هذا المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            if (_OperationStorage.Save())
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

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            else {
                cbxUnits.Enabled = false;
            }
        }
    }
}
