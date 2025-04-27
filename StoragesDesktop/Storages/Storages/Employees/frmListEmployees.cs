using Storages.People;
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

namespace Storages.Employees
{
    public partial class frmListEmployees : Form
    {
        public frmListEmployees()
        {
            InitializeComponent();
        }





        private static DataTable _dtEmployees;


        private void frmListEmployees_Load(object sender, EventArgs e)
        {
            _dtEmployees = clsEmployee.GetAllEmployees();
            dgvEmployees.DataSource = _dtEmployees;

            cbxFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();

            if (_dtEmployees.Rows.Count == 0)
            {

                MessageBox.Show("لا يوجد موظفين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else
            {
                dgvEmployees.Columns[0].HeaderText = "رقم الموظف";
                dgvEmployees.Columns[0].Width = 110;

                dgvEmployees.Columns[1].HeaderText = "رقم الشخص";
                dgvEmployees.Columns[1].Width = 110;



                dgvEmployees.Columns[2].HeaderText = "اسم المستخدم";
                dgvEmployees.Columns[2].Width = 140;





                dgvEmployees.Columns[3].HeaderText = "الحالة";
                dgvEmployees.Columns[3].Width = 140;

            }

          


        }



        private void cbxFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            txtFilterValue.Visible = (cbxFilterBy.Text != "لا شيء");

            if (cbxFilterBy.Text == "لا شيء")
            {
                txtFilterValue.Enabled = false;
            }

            else
            {
                txtFilterValue.Enabled = true;

            }

            txtFilterValue.Focus();
            txtFilterValue.Text = "";

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbxFilterBy.Text)
            {

                case "رقم الموظف":
                    FilterColumn = "EmployeeID";
                    break;

                case "رقم الشخص":
                    FilterColumn = "PersonID";
                    break;

                case "اسم المستخدم":
                    FilterColumn = "UserNameEmployee";
                    break;

                case "الحالة":
                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "لا شيء";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "لا شيء")
            {
                _dtEmployees.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();
                return;

            }
            if (FilterColumn != "UserNameEmployee")
            {
                _dtEmployees.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else
            {
                _dtEmployees.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvEmployees.Rows.Count.ToString();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();
            frm.ShowDialog();

            frmListEmployees_Load(null, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbxFilterBy.Text == "رقم الشخص" || cbxFilterBy.Text == "رقم الموظف")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

























        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void dgvClints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void عرضالتفاصيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo frm = new frmEmployeeInfo((int)dgvEmployees.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void اضافةموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();
            frm.ShowDialog();

            frmListEmployees_Load(null, null);
        }

        private void جديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee((int)dgvEmployees.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListEmployees_Load(null, null);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsEmployee.DeleteEmployee((int)dgvEmployees.CurrentRow.Cells[0].Value);
            frmListEmployees_Load(null, null);
        }

        private void تغييركلمةالسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePasswordEmployee frm = new frmChangePasswordEmployee((int)dgvEmployees.CurrentRow.Cells[0].Value);    
            frm.ShowDialog();
            frmListEmployees_Load(null, null);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
