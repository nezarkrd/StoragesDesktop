﻿using System;
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
    public partial class frmUserInfo : Form
    {

        private int _UserID = -1;
        public frmUserInfo()
        {
            InitializeComponent();
        }

        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
