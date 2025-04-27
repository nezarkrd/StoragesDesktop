using Storages.Employees.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storages.Employees
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        private int _EmployeeID = -1;



        public frmEmployeeInfo(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
        }


        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            ctrlEmployeeCard1.LoadEmployeeInfo(_EmployeeID);
          
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

   

        
    }
}
