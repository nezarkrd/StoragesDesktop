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
    public partial class frmPermissions : Form
    {
        public delegate void DataBackEventHandler(object sender, short Permission);
        public event DataBackEventHandler DataBack;
        public short Permission = 0;
        private int _UserID;
        private clsUser _User;

        public frmPermissions(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }
        public frmPermissions()
        {
            _UserID =-1;
            InitializeComponent();
        }
        private void frmPermissions_Load(object sender, EventArgs e)
        {
           
            _User = clsUser.Find(_UserID);

            if (_User.Permission == -1 || _User.Permission == 255)
            {

                cbxPeople.Checked = true;
                cbxUsers.Checked = true;
                cbxEmployees.Checked = true;
                cbxUnits.Checked = true;
                cbxCategories.Checked = true;
                cbxItems.Checked = true;
                cbxStorages.Checked = true;
                cbxOperationStorage.Checked = true;
                cbxConvertBetweenStorages.Checked = true;
            }
            if (_User.Permission == 0)
            {

                cbxPeople.Checked = false;
                cbxUsers.Checked = false;
                cbxEmployees.Checked = false;
                cbxUnits.Checked = false;
                cbxCategories.Checked = false;
                cbxItems.Checked = false;
                cbxStorages.Checked = false;
                cbxOperationStorage.Checked = false;
                cbxConvertBetweenStorages.Checked = false;
            }
            else
            {
                if (_User.CheckPermissions(clsUser.enPermissions.pPeople))
                {
                    cbxPeople.Checked = true;
                }

                if (_User.CheckPermissions(clsUser.enPermissions.pUser))
                {
                    cbxUsers.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pEmployees))
                {
                    cbxEmployees.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pUnits))
                {
                    cbxUnits.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pCategories))
                {
                    cbxCategories.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pItems))
                {
                    cbxItems.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pStorages))
                {
                    cbxStorages.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pOperationStorages))
                {
                    cbxOperationStorage.Checked = true;
                }
                if (_User.CheckPermissions(clsUser.enPermissions.pOperationConvertBetweenStprages))
                {
                    cbxConvertBetweenStorages.Checked = true;
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxAllPermissions.Checked) { Permission = -1; }
            else
            {

                if (cbxPeople.Checked) { Permission += (short)clsUser.enPermissions.pPeople; }
                if (cbxUsers.Checked) { Permission += (short)clsUser.enPermissions.pUser; }
                if (cbxEmployees.Checked) { Permission += (short)clsUser.enPermissions.pEmployees; }
                if (cbxUnits.Checked) { Permission += (short)clsUser.enPermissions.pUnits; }
                if (cbxCategories.Checked) { Permission += (short)clsUser.enPermissions.pCategories; }
                if (cbxItems.Checked) { Permission += (short)clsUser.enPermissions.pItems; }
                if (cbxStorages.Checked) { Permission += (short)clsUser.enPermissions.pStorages; }
                if (cbxOperationStorage.Checked) { Permission += (short)clsUser.enPermissions.pOperationStorages; }
                if (cbxConvertBetweenStorages.Checked) { Permission += (short)clsUser.enPermissions.pOperationConvertBetweenStprages; }



            }

            DataBack?.Invoke(this, Permission);
            this.Close();
        }

        private void cbxAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAllPermissions.Checked)
            {

                cbxPeople.Checked = true;
                cbxUsers.Checked = true;
                cbxEmployees.Checked = true;
                cbxUnits.Checked = true;
                cbxCategories.Checked = true;
                cbxItems.Checked = true;
                cbxStorages.Checked = true;
                cbxOperationStorage.Checked = true;
                cbxConvertBetweenStorages.Checked = true;

            }
            else
            {
                cbxPeople.Checked = false;
                cbxUsers.Checked = false;
                cbxEmployees.Checked = false;
                cbxUnits.Checked = false;
                cbxCategories.Checked = false;
                cbxItems.Checked = false;
                cbxStorages.Checked = false;
                cbxOperationStorage.Checked = false;
                cbxConvertBetweenStorages.Checked = false;


            }
        }



    }
}
