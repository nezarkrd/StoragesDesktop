using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storages.login
{
    public partial class frmCode : Form
    {
        public frmCode()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "123456789")
            {
                Form frm = new frmSettingsNetwork();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("الكود غير صحيح", "تأكيد");
            }
        }

        private void frmCode_Load(object sender, EventArgs e)
        {

        }
    }
}
