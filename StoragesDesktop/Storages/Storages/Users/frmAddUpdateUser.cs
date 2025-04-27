using Storages.People.Controls;
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

namespace Storages.Users
{
    public partial class frmAddUpdateUser : Form
    {

        public enum enMode { AddMode = 0, UpdateMode = 1 };


        private enMode _Mode;
        clsUser _User;
        private int _UserID = -1;


        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.UpdateMode;
        }
        private void _ResetDefaultValue()
        {


            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "اضافة مستخدم جديد";
                this.Text = "اضافة مستخدم جديد";
                _User = new clsUser();
                tapLoginInfo.Enabled = false;
                ctrlPersonCardWithFilter11.Focus();
            }
            else
            {
                lblTitle.Text = "تعديل معلومات المستخدم";
                this.Text = "تعديل معلومات المستخدم";
                tapLoginInfo.Enabled = true;
                btnSave.Enabled = false;
            }



            lblUserID.Text = "????";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            // rdbAllPermmissions.Checked = true;
            chxIsActive.Checked = true;



        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            ctrlPersonCardWithFilter11.FilterEnabled = false;
            // lblPersonID.Text = _Person.PersonID.ToString();
            if (_User == null)
            {
                MessageBox.Show("لا يوجد مستخدم بهذا الرقم= " + _UserID, "المستخدم غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            //rdbAllPermmissions.Checked = true;
            chxIsActive.Checked = true;
            ctrlPersonCardWithFilter11.LoadPersonInfo(_User.PersonID);




        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
        }


        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "لا يمكن أن تكون كلمة المرور فارغة");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "تأكيد كلمة المرور لا يتطابق مع كلمة المرور!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "لا يمكن أن يكون اسم المستخدم فارغًا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };

            if (_Mode == enMode.AddMode)
            {
                if (clsUser.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "اسم المستخدم يستخدمه مستخدم آخر");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };


            }
            else
            {

                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.isUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "اسم المستخدم يستخدمه مستخدم آخر");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }

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
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }



   
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tapLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tapLoginInfo"];
                return;
            }
            //incase of add new mode.
            if (ctrlPersonCardWithFilter11.PersonID != -1)
            {

                if (clsUser.isUserExistByPersonID(ctrlPersonCardWithFilter11.PersonID))
                {

                    MessageBox.Show("الشخص المحدد لديه مستخدم بالفعل، اختر مستخدمًا آخر.", "اخر شخصا اخر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter11.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tapLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tapLoginInfo"];

                }
            }

            else
            {

                MessageBox.Show("الرجاء اختيار شخص", "اختر شخصا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter11.FilterFocus();
            }
        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter11.FilterFocus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.PersonID = ctrlPersonCardWithFilter11.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            // if (rdbAllPermmissions.Checked) { _User.Permission = -1; }
            //else { 



            //    _User.Permission = 0; 


            //}
            _User.IsActive = chxIsActive.Checked;




            if (_User.Save())
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User"; ;
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم حفظ البيانات بنجاح.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPermissions_DataBack(object sender, short Permissions)
        {

            _User.Permission = Permissions;
        }

        private void ctrlPersonCardWithFilter11_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectPermmissions_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                frmPermissions frm = new frmPermissions(_UserID);
                frm.DataBack += frmPermissions_DataBack;
                frm.ShowDialog();
            }
              
           
          
        }

        private void chxIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
