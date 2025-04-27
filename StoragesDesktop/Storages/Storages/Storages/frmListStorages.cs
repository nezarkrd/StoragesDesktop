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

namespace Storages.Storages
{
    public partial class frmListStorages : Form
    {
        public frmListStorages()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllStorage = clsStorage.GetAllStorages();



        private void _RefreshStoragesList()
        {

            _dtAllStorage = clsStorage.GetAllStorages();



            dgvStorages.DataSource = _dtAllStorage;
            lblRecordsCount.Text = dgvStorages.Rows.Count.ToString();
        }


        private void frmListStorages_Load(object sender, EventArgs e)
        {
            dgvStorages.DataSource = _dtAllStorage;
            cbFilterBy.SelectedIndex = 0;

         
            lblRecordsCount.Text = dgvStorages.Rows.Count.ToString();
            if (dgvStorages.Rows.Count > 0)
            {

                dgvStorages.Columns[0].HeaderText = "رقم المخزن";
                dgvStorages.Columns[0].Width = 110;



                dgvStorages.Columns[1].HeaderText = "اسم المخزن";
                dgvStorages.Columns[1].Width = 130;

                dgvStorages.Columns[2].HeaderText = "الموقع";
                dgvStorages.Columns[2].Width = 160;

                dgvStorages.Columns[3].HeaderText = "معلومات";
                dgvStorages.Columns[3].Width = 160;


            }
        }





        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
                case "رقم المخزن":
                    FilterColumn = "StorageID";
                    break;

                case "اسم المخزن":
                    FilterColumn = "StorageName";
                    break;
               
                case "الموقع":
                    FilterColumn = "Location";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }



            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllStorage.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllStorage.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "StorageID")
            {
                _dtAllStorage.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtAllStorage.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            lblRecordsCount.Text = dgvStorages.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only input number for Person ID
            if (cbFilterBy.Text == "رقم المخزن")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }





        private void btnAddسفخقشلث_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateStorage();
            frm.ShowDialog();
            _RefreshStoragesList();
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

        private void اضافةصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateStorage();
            frm.ShowDialog();
            _RefreshStoragesList();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateStorage((int)dgvStorages.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshStoragesList();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsStorage.DeleteStorage((int)dgvStorages.CurrentRow.Cells[0].Value);
            _RefreshStoragesList();
        }

        private void عرضمحتوياتالمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm=new frmStorageContent((int)dgvStorages.CurrentRow.Cells[0].Value);   
            frm.ShowDialog();
            _RefreshStoragesList();
        }
    }
}
