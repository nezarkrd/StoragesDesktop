using Storages.Properties;
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
using System.IO;

namespace Storages.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        private clsPerson _Person;
        private int _PersonID = -1;

        public int PersonID
        {

            get { return _PersonID; }
        }

        public clsPerson SelectPersonInfo
        {

            get { return _Person; }
        }


        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0) { pbPerson.Image = Resources.Male_512; }
            else { pbPerson.Image = Resources.Female_512; }
            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath)) { pbPerson.ImageLocation = ImagePath; }
                else
                {
                    MessageBox.Show("لم يتم العثور على هذه الصورة: = " + ImagePath, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }




        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblNationalNO.Text = _Person.NationalNO;
            if (_Person.Gendor == 0) { lblGendor.Text = "ذكر"; }
            else { lblGendor.Text = "أنثى"; }
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateBirth.ToString();
            lblCountryName.Text = clsCountry.Find(_Person.NationalCountryID).CountryName;
            llEditPersonInfo.Visible = true;
            _LoadPersonImage();

        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblNationalNO.Text = "[????]";
            lblCountryName.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblGendor.Text = "[????]";
            pbPerson.Image = Resources.Male_512;




        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("لا يوجد شخص بهذا الرقم=" + PersonID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();




        }
        public void LoadPersonInfo(string NationalNO)
        {
            _Person = clsPerson.Find(NationalNO);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("لا يوجد شخص لديه معرف الشخص = " + PersonID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();




        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void llEditPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
