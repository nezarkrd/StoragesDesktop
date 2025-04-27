using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storages.People
{
    public partial class frmShowPersonInfo : Form
    {
     
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard.LoadPersonInfo(PersonID);
        }

        public frmShowPersonInfo(string NationalNO)
        {
            InitializeComponent();
            ctrlPersonCard.LoadPersonInfo(NationalNO);
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
