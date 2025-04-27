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

namespace Storages.Items
{
    public partial class frmListItems : Form
    {
        public frmListItems()
        {
            InitializeComponent();
        }

       

        private static DataTable _dtAllItems = clsItem.GetAllItems();



        private void _RefreshItemsList()
        {

            _dtAllItems = clsItem.GetAllItems();



            dgvItems.DataSource = _dtAllItems;
            lblRecordsCount.Text = dgvItems.Rows.Count.ToString();
        }


        private void frmListItems_Load(object sender, EventArgs e)
        {
            dgvItems.DataSource = _dtAllItems;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvItems.Rows.Count.ToString();
            if (dgvItems.Rows.Count > 0)
            {

                dgvItems.Columns[0].HeaderText = "رقم المنتج";
                dgvItems.Columns[0].Width = 110;



                dgvItems.Columns[1].HeaderText = "اسم المنتج";
                dgvItems.Columns[1].Width = 130;


                dgvItems.Columns[2].HeaderText = "الوصف";
                dgvItems.Columns[2].Width = 160;


                dgvItems.Columns[3].HeaderText = "الصنف";
                dgvItems.Columns[3].Width = 160;


            }
        }



        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
                case "رقم المنتج":
                    FilterColumn = "ItemID";
                    break;

                case "اسم المنتج":
                    FilterColumn = "ItemName";
                    break;
                case "الوصف":
                    FilterColumn = "Description";
                    break;
                case "الصنف":
                    FilterColumn = "CategoryName";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }



            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllItems.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllItems.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "ItemID")
            {
                _dtAllItems.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtAllItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            lblRecordsCount.Text = dgvItems.Rows.Count.ToString();
        }
        



        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only input number for Person ID
            if (cbFilterBy.Text == "رقم المنتج")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }




        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "لا شيء");
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateItem();
            frm.ShowDialog();
            _RefreshItemsList();
        }

        private void اضافةصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateItem();
            frm.ShowDialog();
            _RefreshItemsList();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateItem((int)dgvItems.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshItemsList();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsItem.DeleteItem((int)dgvItems.CurrentRow.Cells[0].Value);
            _RefreshItemsList();
        }

        private void عرضمعلوماتالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm=new frmShowItem((int)dgvItems.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshItemsList();
        }

        private void منتجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
