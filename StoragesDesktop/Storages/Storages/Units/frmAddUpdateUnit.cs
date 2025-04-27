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
    public partial class frmAddUpdateUnit : Form
    {
       



        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;



        public enum enMode { AddMode = 0, UpdateMode = 1 };
    
        private enMode _Mode;
        clsUnit _Unit;
        private int _UnitID = -1;

        public frmAddUpdateUnit()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
        }


        public frmAddUpdateUnit(int UnitID)
        {
            InitializeComponent();
            _UnitID = UnitID;
            _Mode = enMode.UpdateMode;
        }

        private void _FillUnitsInComboBox()
        {
            DataTable dtUnits = new DataTable();
            dtUnits = clsUnit.GetAllUnits();
            cbxSmallerUnitID.Items.Add("لا يوجد");
            foreach (DataRow Row in dtUnits.Rows)
            {
                cbxSmallerUnitID.Items.Add(Row["UnitName"]);
            }



        }
        private void _ResetDefaultValue()
        {
            _FillUnitsInComboBox();

            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "اضافة وحدة جديدة";
                _Unit = new clsUnit();
            }
            else
            {
                lblTitle.Text = "تحديث معلومات الوحدة";

            }



            txtUnitName.Text = "";
            txtNumberOfContent.Text = "";
            cbxSmallerUnitID.SelectedIndex = 0;


        }
        private void _LoadData()
        {
            _Unit = clsUnit.Find(_UnitID);
            lblUnitID.Text = _Unit.UnitID.ToString();
            if (_Unit == null)
            {
                MessageBox.Show("لا يوجد بهذا الرقم= " + _UnitID, "الوحدة غير موجودة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtUnitName.Text = _Unit.UnitName;
            if (_Unit.NumberOfContent != -1) { 
                txtNumberOfContent.Text = _Unit.NumberOfContent.ToString();
            }
            else { txtNumberOfContent.Text = ""; }


           _Unit.infoUnit=clsUnit.Find(_Unit.SmallerUnitID);
           if (_Unit.SmallerUnitID != -1) { cbxSmallerUnitID.SelectedIndex = cbxSmallerUnitID.FindString(_Unit.infoUnit.UnitName); }
           else { cbxSmallerUnitID.SelectedIndex = cbxSmallerUnitID.FindString("لا يوجد"); }
           



            
        }


        private void frmAddUpdateUnit_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSmallerUnitID.SelectedIndex == 0)
            {

                txtNumberOfContent.Enabled = false;
                txtNumberOfContent.Text = "لايوجد";


            }
            else
            {
                txtNumberOfContent.Enabled = true;
                if (_Unit.NumberOfContent.ToString() == "-1")
                {
                    txtNumberOfContent.Text = "";
                }
                else
                {
                    txtNumberOfContent.Text = _Unit.NumberOfContent.ToString();
                }
                


            }

        }


        private void btnClose_Click_1(object sender, EventArgs e)
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
                errorProvider1.SetError(Temp, "!هذا الحقل مطلوب");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtNumberOfContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }





        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير صالحة، ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            _Unit.UnitName = txtUnitName.Text.Trim();
            if(cbxSmallerUnitID.SelectedIndex == 0)
            {
                _Unit.NumberOfContent =-1;
            

            }
            else
            {
                _Unit.NumberOfContent = int.Parse(txtNumberOfContent.Text.Trim());
            }




            int SmallerUnitID;
            if (cbxSmallerUnitID.SelectedIndex == 0) { SmallerUnitID = -1; }
            else { SmallerUnitID = clsUnit.Find(cbxSmallerUnitID.Text).UnitID; }
           
            _Unit.SmallerUnitID = SmallerUnitID;

            if (_Unit.Save())
            {
                lblTitle.Text = "تحديث الوحدة";
                lblUnitID.Text = _Unit.UnitID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم حفظ الوحدة بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Unit.UnitID);
            }

            else
            {
                MessageBox.Show("خطأ لم يتم الحفظ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
            


        }

     










        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumberOfContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
