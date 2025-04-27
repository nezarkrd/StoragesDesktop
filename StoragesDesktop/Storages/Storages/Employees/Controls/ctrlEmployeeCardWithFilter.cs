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
    public partial class ctrlEmployeeCardWithFilter : UserControl
    {
        public ctrlEmployeeCardWithFilter()
        {
            InitializeComponent();
        }
        // Define a custom event handler delegate with parameters
        public event Action<int> OnEmployeeSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void EmployeeSelected(int EmployeeID)
        {
            Action<int> handler = OnEmployeeSelected;
            if (handler != null)
            {
                handler(EmployeeID); // Raise the event with the parameter
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                cbFilterBy.Enabled = _FilterEnabled;
            }
        }


        private int _EmployeeID = -1;
        public int EmployeeID { get { return ctrlEmployeeCard1.SelectEmployeeInfo.EmployeeID; } }

        public clsEmployee SelectEmployeeInfo { get { return ctrlEmployeeCard1.SelectEmployeeInfo; } }

        

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "هذا الحقل مطلوب");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }


        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }



        public void FindNow()
        {

            switch (cbFilterBy.Text)
            {
                case "رقم الموظف":
                    ctrlEmployeeCard1.LoadEmployeeInfo(int.Parse(txtFilterValue.Text));
                   
                    break;


                case "اسم المستخدم الموظف":

                    ctrlEmployeeCard1.LoadEmployeeInfo(txtFilterValue.Text);
                    break;


                default:
                    break;


            }

            if (OnEmployeeSelected != null && FilterEnabled)
            {

                if (ctrlEmployeeCard1.SelectEmployeeInfo != null)
                    EmployeeSelected(ctrlEmployeeCard1.SelectEmployeeInfo.EmployeeID);
                   

            }



        }


        public void LoadEmployeeInfo(int EmployeeID)
        {

            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = EmployeeID.ToString();
            FindNow();

        }


        private void ctrlEmployeeCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if Client id is selected
            if (cbFilterBy.Text == "رقم الموظف")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DataBackEvent(object sender, int ClientID)
        {
            // Handle the data received

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = EmployeeID.ToString();
            ctrlEmployeeCard1.LoadEmployeeInfo(EmployeeID);
        }


        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

        }








        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }


    

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void ctrlEmployeeCard1_Load(object sender, EventArgs e)
        {

        }

    
    }
}
