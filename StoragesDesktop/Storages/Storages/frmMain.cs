using BANK_Desktop.Global_Classes;
using Storages.Categories;
using Storages.Employees;
using Storages.Items;
using Storages.login;
using Storages.People;
using Storages.Storages;
using Storages.Units;
using Storages.Users;
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
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pPeople))
            {
                frmListPeople frm = new frmListPeople();
                frm.ShowDialog();
            }

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pUser))
            {
                
                frmListUsers frm = new frmListUsers();
                frm.ShowDialog();
            }
        }


        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pEmployees))
            {
                frmListEmployees frm = new frmListEmployees();
                frm.ShowDialog();
            }
        }

        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pUnits))
            {
                frmListUnits frm = new frmListUnits();
                frm.ShowDialog();
            }
        }

        private void الأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pCategories))
            {
                frmListCategories frm = new frmListCategories();
                frm.ShowDialog();
            }
        }
        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pItems))
            {
                frmListItems frm = new frmListItems();
                frm.ShowDialog();
            }
        }
        private void storagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pStorages))
            {
                frmListStorages frm = new frmListStorages();
                frm.ShowDialog();
            }
        }

        private void عملياتعلىالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ادخالToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void سجلادخالسحبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pOperationStorages))
            {
                frmListOperationsStorages frm = new frmListOperationsStorages();
                frm.ShowDialog();
            }
        }

        private void ادخالالىالمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pOperationStorages))
            {
                frmOperationsStorages frm = new frmOperationsStorages();
                frm.ShowDialog();
            }
        }



        private void التحويلبينالمخازنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pOperationConvertBetweenStprages)) { 
               frmConvertBetweenStorages frm = new frmConvertBetweenStorages();
               frm.ShowDialog();
            }
        }



        private void سجلالتحويلاتبينالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.CheckPermissions(clsUser.enPermissions.pOperationConvertBetweenStprages))
            {
                frmListOperationsConvertStorages frm = new frmListOperationsConvertStorages();
                frm.ShowDialog();
            }
        }




        private void التحويلبينالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

      

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void معلوماتالمستخدمالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void تغييركلمةالسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }
    }
}
