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

namespace Storages.Employees
{
    public partial class frmAddUpdateEmployee : Form
    {


        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int ClientID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public enum enMode { AddMode = 0, UpdateMode = 1 };
        private enMode _Mode;
        clsEmployee _Employee;
        private int _EmployeeID = -1;




        public frmAddUpdateEmployee()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
            
        }
        public frmAddUpdateEmployee(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
            _Mode = enMode.UpdateMode;

        }
        private void _ResetDefaultValue()
        {


            if (_Mode == enMode.AddMode)
            {
                //lblTitle.Text = "اضافة موظف جديد";
                this.Text = "اضافة موظف جديد";
                _Employee = new clsEmployee();
                tabEmployee.Enabled = false;
                ctrlPersonCardWithFilter11.Focus();

            }
            else
            {
                //lblTitle.Text = "Update Client";
                this.Text = "تعديل معلومات الموظف";
                tabEmployee.Enabled = true;

                btnSave.Enabled = false;
            }



            lblEmployeeID.Text = "????";
            txtUserNameEmployee.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            rdbActive.Checked = true;











        }
        private void _LoadData()
        {
            _Employee = clsEmployee.Find(_EmployeeID);
            ctrlPersonCardWithFilter11.FilterEnabled = false;
            // lblPersonID.Text = _Person.PersonID.ToString();
            if (_Employee == null)
            {
                MessageBox.Show("لا يوجد موظف بهذا الرقم= " + _EmployeeID, "الموظف غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            lblEmployeeID.Text = _Employee.EmployeeID.ToString();
            txtUserNameEmployee.Text = _Employee.UserNameEmployee;
            txtPassword.Text = _Employee.Password;
            txtConfirmPassword.Text = _Employee.Password;

            if (_Employee.IsActive == true)
            {
                rdbActive.Checked = true;
            }
            else
            {
                rdbNotActive.Checked = true;
            }


            ctrlPersonCardWithFilter11.LoadPersonInfo(_Employee.PersonID);


        }

        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
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
                errorProvider1.SetError(Temp, "هذا الحقل مطلوب!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserNameEmployee.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserNameEmployee, "لا يمكن أن يكون اسم المستخدم للموظف فارغًا");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserNameEmployee, null);
            };

            if (_Mode == enMode.AddMode)
            {


                if (clsEmployee.isEmployeeExist(txtUserNameEmployee.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserNameEmployee, "اسم المستخدم للموظف مستخدم لزبون اخر");
                }
                else
                {
                    errorProvider1.SetError(txtUserNameEmployee, null);
                };


            }
            else
            {

                //incase update make sure not to use anothers user name
                if (_Employee.UserNameEmployee != txtUserNameEmployee.Text.Trim())
                {

                    if (clsEmployee.isEmployeeExist(txtUserNameEmployee.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserNameEmployee, "اسم المستخدم مستخدم لموظف اخر");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserNameEmployee, null);
                    };
                }

            }
        }

        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
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

        private void txtConfirmPassword_Validating_1(object sender, CancelEventArgs e)
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

            _Employee.PersonID = ctrlPersonCardWithFilter11.PersonID;
            _Employee.UserNameEmployee = txtUserNameEmployee.Text.Trim();
            _Employee.Password = txtPassword.Text.Trim();

            if (rdbActive.Checked == true)
            {
                _Employee.IsActive = true;
            }
            else
            {
                _Employee.IsActive = false;
            }




            if (_Employee.Save())
            {
                //lblTitle.Text = "Update User";
                this.Text = "تحديث معلومات الموظف"; ;
                lblEmployeeID.Text = _Employee.EmployeeID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم حفظ البيانات بنجاح.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Employee.EmployeeID);

            }

            else
            {
                MessageBox.Show("خطأ: لم يتم حفظ البيانات بنجاح.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tabEmployee.Enabled = true;
                tapEmployeeInfo.SelectedTab = tapEmployeeInfo.TabPages["tabEmployee"];
                return;
            }
            //incase of add new mode.
            if (ctrlPersonCardWithFilter11.PersonID != -1)
            {

                if (clsEmployee.isEmployeeExistByPersonID(ctrlPersonCardWithFilter11.PersonID))

                {

                    MessageBox.Show("الشخص المحدد لديه عميل بالفعل، اختر عميل آخر.", "اختر شخص اخر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter11.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tabEmployee.Enabled = true;
                    tapEmployeeInfo.SelectedTab = tapEmployeeInfo.TabPages["tabEmployee"];

                }
            }

            else
            {

                MessageBox.Show("الرجاء اختيار شخص", "اختر شخص", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter11.FilterFocus();
            }
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblClientID_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
