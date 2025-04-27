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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            clsOperationsStorages OperationsStorages = new clsOperationsStorages();
            //.ItemUnitID, this.StorageID,this.OldAmount, this.Amount, this.TypeOperation, this.DateOperation, this.EmployeeID, this.UserID
            OperationsStorages.ItemUnitID =1;
            OperationsStorages.StorageID = 1;
            //OperationsStorages.OldAmount = -1;
            OperationsStorages.Amount = 99; 
            OperationsStorages.TypeOperation = 1;
            //OperationsStorages.NewAmount = -1;  
            OperationsStorages.DateOperation=DateTime.Now;
            OperationsStorages.EmployeeID = -1;
            OperationsStorages.UserID = -1; 


            OperationsStorages.Save();

        }
    }
}
