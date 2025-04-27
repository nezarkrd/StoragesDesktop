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
    public partial class frmAddUpdateStorage : Form
    {

        // Declare a delegate
        //public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        //public event DataBackEventHandler DataBack;




        public enum enMode { AddMode = 0, UpdateMode = 1 };



        private enMode _Mode;
        clsStorage _Storage;
        private int _StorageID = -1;





        public frmAddUpdateStorage()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateStorage(int StorageID)
        {
            InitializeComponent();
            _StorageID = StorageID;
            _Mode = enMode.UpdateMode;

        }




     
        private void _ResetDefaultValue()
        {
        

            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "اضافة مخزن";
                _Storage = new clsStorage();
            }
            else
            {
                lblTitle.Text = "تعديل معلومات مخزن";

            }

       

            txtStorageName.Text = "";
            txtLocationStorage.Text = "";
            txtInfoStorage.Text = "";
 


        }
        private void _LoadData()
        {
            _Storage = clsStorage.Find(_StorageID);
            lblSorageID.Text = _Storage.StorageID.ToString();
            if (_Storage == null)
            {
                MessageBox.Show("لا يوجد مخزن بهذا الرقم" + _StorageID, "المخزن غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtStorageName.Text = _Storage.StorageName;
            txtLocationStorage.Text = _Storage.Location;
            txtInfoStorage.Text = _Storage.Information;
          
   
        }
        private void frmAddUpdateStorage_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
        }


        private void btnCose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      




       
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "الحقل مطلوب");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
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


            _Storage.StorageName = txtStorageName.Text.Trim();
            _Storage.Location = txtLocationStorage.Text.Trim();
            _Storage.Information = txtInfoStorage.Text.Trim();





            if (_Storage.Save())
            {
                lblTitle.Text = "تحديث معلومات المخزن";
                lblSorageID.Text = _Storage.StorageID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم تحديث المعلومات بنجاح.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DataBack?.Invoke(this, _Person.PersonID);
            }

            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





















        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUnitID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
