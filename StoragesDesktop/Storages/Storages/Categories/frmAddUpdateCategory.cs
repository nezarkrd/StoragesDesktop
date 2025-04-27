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
    public partial class frmAddUpdateCategory : Form
    {


        public enum enMode { AddMode = 0, UpdateMode = 1 };

        private enMode _Mode;
        clsCategory _Category;
        private int _CategoryID = -1;



        public frmAddUpdateCategory()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateCategory(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;
            _Mode = enMode.UpdateMode;
        }

   









        private void _ResetDefaultValue()
        {


            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "اضافة صنف";
                _Category = new clsCategory();
            }
            else
            {
                lblTitle.Text = "تعديل معلومات الصنف";

            }



            txtCategoryName.Text = "";
            txtCateograyDescription.Text = "";
   



        }
        private void _LoadData()
        {
            _Category = clsCategory.Find(_CategoryID);
            lblCategoryID.Text = _Category.CategoryID.ToString();
            if (_Category == null)
            {
                MessageBox.Show("لا يوجد فئة بهذا الرقم=" + _CategoryID, "الفئة غير موجودة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtCategoryName.Text = _Category.CategoryName;
            txtCateograyDescription.Text = _Category.Description;
          


        }
        private void frmAddUpdateCategory_Load(object sender, EventArgs e)
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
                errorProvider1.SetError(Temp, "هذا الحقل مطلوب");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ تحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            _Category.CategoryName = txtCategoryName.Text.Trim();
            _Category.Description = txtCateograyDescription.Text.Trim();
    





            if (_Category.Save())
            {
                lblTitle.Text = "تحديث معلومات الصنف";
                lblCategoryID.Text = _Category.CategoryID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم حفظ الصنف بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DataBack?.Invoke(this, _Person.PersonID);
            }

            else
            {
                MessageBox.Show("خطأ: لم يتم الحفظ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCateograyDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoryID_Click(object sender, EventArgs e)
        {

        }
    }
}
