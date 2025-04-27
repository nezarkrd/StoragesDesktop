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

namespace Storages.Categories
{
    public partial class frmListCategories : Form
    {
        public frmListCategories()
        {
            InitializeComponent();
        }

      


        private static DataTable _dtAllCategories = clsCategory.GetAllCategories();

        

        private void _RefreshCategoryList()
        {
          
            _dtAllCategories = clsCategory.GetAllCategories();



            dgvCategories.DataSource = _dtAllCategories;
            lblRecordsCount.Text = dgvCategories.Rows.Count.ToString();
        }



        private void frmListCategories_Load(object sender, EventArgs e)
        {
            dgvCategories.DataSource = _dtAllCategories;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvCategories.Rows.Count.ToString();
            if (dgvCategories.Rows.Count > 0)
            {

                dgvCategories.Columns[0].HeaderText = "رقم الصنف";
                dgvCategories.Columns[0].Width = 110;



                dgvCategories.Columns[1].HeaderText = "اسم الصنف";
                dgvCategories.Columns[1].Width = 130;

                dgvCategories.Columns[2].HeaderText = "الوصف";
                dgvCategories.Columns[2].Width = 160;






            }
        }


        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
                case "رقم الصنف":
                    FilterColumn = "CategoryID";
                    break;

                case "اسم الصنف":
                    FilterColumn = "CategoryName";
                    break;
          
              

                default:
                    FilterColumn = "None";
                    break;

            }



            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllCategories.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllCategories.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "CategoryID")
            {
                _dtAllCategories.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtAllCategories.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            lblRecordsCount.Text = dgvCategories.Rows.Count.ToString();
        }


        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {      
            //only input number for Person ID
            if (cbFilterBy.Text == "رقم الصنف")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }






        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCategory();
            frm.ShowDialog();
            _RefreshCategoryList();
        }



        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "لا شيء");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
       
     

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }







        private void اضافةصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCategory();
            frm.ShowDialog();
            _RefreshCategoryList();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateCategory((int)dgvCategories.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshCategoryList();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCategory.DeleteCategory((int)dgvCategories.CurrentRow.Cells[0].Value);
            _RefreshCategoryList();
        }
    }
}
