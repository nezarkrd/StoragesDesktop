using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storages.Properties;
using Storages_DataAccessLayer;
using Storages_DataAccessLayer.Properties;



namespace Storages.login
{
    public partial class frmSettingsNetwork : Form
    {
        public frmSettingsNetwork()
        {
            InitializeComponent();
        }

        private void cbxConvertBetweenStorages_CheckedChanged(object sender, EventArgs e)
        {

        }

     

        private void frmSettingsNetwork_Load(object sender, EventArgs e)
        {
            clsProps props = new clsProps();
            txtServerName.Text = props.ServerName;
            txtDataBase.Text = props.DataBase;
            txtUserName.Text = props.UserNameDB;
            txtPassword.Text = props.PasswordDB;
            if (props.CheckShow==false)
            {
                cbxShow.Checked=false;
            }

            else
            {
                cbxShow.Checked = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsProps props = new clsProps(txtServerName.Text, txtDataBase.Text, txtUserName.Text, txtPassword.Text, cbxShow.Checked);
            if (props.CheckShow == false)
            {
                props.getcheckshow(false);
            }

            else
            {
                props.getcheckshow(true);
            }
            this.Close();
        }
    }
}
