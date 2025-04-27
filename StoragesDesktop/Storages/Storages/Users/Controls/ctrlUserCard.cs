using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storages_BuisnessLayer;

namespace Storages.Users
{
    public partial class ctrlUserCard : UserControl
    {

        private int _UserID = -1;
        private clsUser _User;


        public int UserID
        {
            get { return _UserID; }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }


        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            if (_User.IsActive) { lblIsActive.Text = "Active"; }
            else { lblIsActive.Text = "Not Active"; }



        }


        private void _ResetPersonInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "????";
            lblUserName.Text = "????";
            lblIsActive.Text = "????";


        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _FillUserInfo();

        }
        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
