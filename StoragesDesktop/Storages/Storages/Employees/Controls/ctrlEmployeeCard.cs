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

namespace Storages.Employees.Controls
{
    public partial class ctrlEmployeeCard : UserControl
    {
        public ctrlEmployeeCard()
        {
            InitializeComponent();
        }

        private int _EmployeeID = -1;
        private clsEmployee _Employee;

        public int EmployeeID
        {
            get { return _EmployeeID; }
        }

        public clsEmployee SelectEmployeeInfo
        {

            get { return _Employee; }
        }


       


        private void _FillEmployeeInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_Employee.PersonID);
            
            lblEmployeeID.Text = _Employee.EmployeeID.ToString();
            lblUserNameEmployee.Text = _Employee.UserNameEmployee;
            lblStatusEmployee.Text = _Employee.IsActive.ToString();

        }


        private void _ResetEmployeeInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblEmployeeID.Text = "????";
            lblUserNameEmployee.Text = "????";
            lblStatusEmployee.Text = "????";


        }

        public void LoadEmployeeInfo(int EmplyeeID)
        {
            _Employee = clsEmployee.Find(EmplyeeID);
            
            if (_Employee == null)
            {
                _ResetEmployeeInfo();
                MessageBox.Show("لا يوجد موظف بهذا الرقم = " + EmployeeID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _FillEmployeeInfo();

        }
        public void LoadEmployeeInfo(string UserNameEmployee)
        {
            _Employee=clsEmployee.Find(UserNameEmployee);   
         
            if (_Employee == null)
            {
                _ResetEmployeeInfo();
                MessageBox.Show("لا يوجد موظف باسم مستخدم=" + EmployeeID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillEmployeeInfo();




        }








        private void ctrlEmployeeCard_Load(object sender, EventArgs e)
        {

        }
    }
}
