using Storages.Global_Classes;
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

namespace Storages.People
{
    public partial class frmAddUpdatePerson : Form
    {
       

 

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddMode = 0, UpdateMode = 1 };
        public enum enGendor { Male = 0, Female = 1 }


        private enMode _Mode;
        clsPerson _Person;
        private int _PersonID = -1;


        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;


        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.UpdateMode;
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = new DataTable();
            dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow Row in dtCountries.Rows)
            {
                cbxCountries.Items.Add(Row["CountryName"]);
            }



        }
        private void _ResetDefaultValue()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddMode)
            {
                lblTitle.Text = "اضاف شخص جديد";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "تحديث معلومات الشخص";

            }

            if (rdbMale.Checked)
            {
                pbPicturePerson.Image = Resources.Male_512;
            }
            else
            {
                pbPicturePerson.Image = Resources.Female_512;
            }
            //else
            //{
            //    pbPicturePerson.Image = Resources.Male_512;
            //}

            llRemove.Visible = (pbPicturePerson.ImageLocation != null);



            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);


            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtNationalNO.Text = "";
            //dtpDateOfBirth.Value= DateTime.Now;
            rdbMale.Checked = true;
            cbxCountries.SelectedIndex = cbxCountries.FindString("السعودية");


        }
        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);
            lblPersonID.Text = _Person.PersonID.ToString();
            if (_Person == null)
            {
                MessageBox.Show("لا يوجد شخص برقم " + _PersonID, "الشخص غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtNationalNO.Text = _Person.NationalNO;
            dtpDateOfBirth.Value = _Person.DateBirth;
            if (_Person.Gendor == 0) { rdbMale.Checked = true; pbPicturePerson.Image = Resources.Male_512; }
            else { rdbFemale.Checked = true; pbPicturePerson.Image = Resources.Female_512; }

            cbxCountries.SelectedIndex = cbxCountries.FindString(_Person.infoCountry.CountryName);
            if (_Person.ImagePath != "")
            {
                pbPicturePerson.ImageLocation = _Person.ImagePath;
            }
            llRemove.Visible = (_Person.ImagePath != "");
        }

        private bool _HandlePersonImage()
        {

            if (_Person.ImagePath != pbPicturePerson.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }

                    catch (IOException)
                    {
                        // We could not delete the file.
                    }
                }
                if (pbPicturePerson.ImageLocation != null)
                {
                    string SourceImageFile = pbPicturePerson.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPicturePerson.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("خطأ في نسخ ملف الصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }


            return true;
        }


        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if (_Mode == enMode.UpdateMode)
            {
                _LoadData();

            }
        }

       



        private void rdbMale_Click(object sender, EventArgs e)
        {
            if (pbPicturePerson.ImageLocation == null)
            {
                pbPicturePerson.Image = Resources.Male_512;
            }
        }

        private void rdbFemale_Click(object sender, EventArgs e)
        {
            if (pbPicturePerson.ImageLocation == null)
            {
                pbPicturePerson.Image = Resources.Female_512;
            }
        }



      

        private void llSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selecedFilePath = openFileDialog1.FileName;
                pbPicturePerson.Load(selecedFilePath);
                llRemove.Visible = true;

            }
        }






    

        private void llRemove_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPicturePerson.ImageLocation = null;

            if (rdbMale.Checked) { pbPicturePerson.Image = Resources.Male_512; }
            else { pbPicturePerson.Image = Resources.Female_512; }
            llRemove.Visible = false;
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidations.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "تنسيق الايميل غير صحيح");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNationalNO.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNO, "هذا الحقل مطلوب");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNO, null);
            }

            //Make sure the national number is not used by another person
            if (txtNationalNO.Text.Trim() != _Person.NationalNO && clsPerson.isPersonExist(txtNationalNO.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNO, "الرقم الوطني مستخدم لشخص اخر!");

            }
            else
            {
                errorProvider1.SetError(txtNationalNO, null);
            }
        }






        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {


        }

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("بعض الحقول غير مملوءة, ضع الماوس فوق الأيقونات الحمراء لرؤية الخطأ", "خطأ بالتحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.NationalNO = txtNationalNO.Text.Trim();
            if (pbPicturePerson.ImageLocation != null) { _Person.ImagePath = pbPicturePerson.ImageLocation; }
            else
            {
                _Person.ImagePath = "";
            }
            if (rdbMale.Checked) { _Person.Gendor = (short)enGendor.Male; }
            else { _Person.Gendor = (short)enGendor.Female; }

            int NationalCountryID = clsCountry.Find(cbxCountries.Text).CountryID;
            _Person.NationalCountryID = NationalCountryID;

            _Person.DateBirth = dtpDateOfBirth.Value;

            if (_Person.Save())
            {
                lblTitle.Text = "تعديل معلومات الشخص";
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.UpdateMode;
                MessageBox.Show("تم الحفظ بنجاح.", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);
            }

            else
            {
                MessageBox.Show("خطأ. لم يتم الحفظ بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
