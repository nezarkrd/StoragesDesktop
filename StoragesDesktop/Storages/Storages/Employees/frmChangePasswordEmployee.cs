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
    public partial class frmChangePasswordEmployee : Form
    {

        private int _EmployeeID;
        private clsEmployee _Employee;


        public frmChangePasswordEmployee()
        {
            InitializeComponent();
        }
       

        public frmChangePasswordEmployee(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();

        }
      




        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "لا يمكن أن تكون كلمة المرور فارغة");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
           
            if (_Employee.Password != txtCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "كلمة المرور الحالية خاطئة!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };




        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "لا يمكن أن تكون كلمة المرور الجديدة فارغة");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "تأكيد كلمة المرور لا يتطابق مع كلمة المرور الجديدة!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };

        }
     
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ",
                    "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Employee.Password = txtNewPassword.Text;
            if (_Employee.Save())
            {
                MessageBox.Show("تم تغيير كلمة المرور بنجاح.",
                  "حفظ.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }

            else
            {
                MessageBox.Show("لقد حدث خطأ، ولم يتم تغيير كلمة المرور.",
               "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePasswordEmployee_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _Employee = clsEmployee.Find(_EmployeeID);
            if (_Employee == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("لا يمكن ايجاد موظف بهذ الرقم = " + _EmployeeID,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
            ctrlEmployeeCard1.LoadEmployeeInfo(_EmployeeID);

        }

        private void ctrlEmployeeCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
