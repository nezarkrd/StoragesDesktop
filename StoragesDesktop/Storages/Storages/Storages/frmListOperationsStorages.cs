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
    public partial class frmListOperationsStorages : Form
    {

        private static DataTable _dtAllOperationsStorages= clsOperationsStorages.GetAllOperationsStorages();

       


        public frmListOperationsStorages()
        {
            InitializeComponent();
        }


        private void _RefreshOperationsStoragesList()
        {



            _dtAllOperationsStorages = clsOperationsStorages.GetAllOperationsStorages();
          


            dgvOperationsStorages.DataSource = _dtAllOperationsStorages;
            lblRecordsCount.Text = dgvOperationsStorages.Rows.Count.ToString();


        }
     

        private void frmListOperationsStorages_Load(object sender, EventArgs e)
        {
            _RefreshOperationsStoragesList();
            dgvOperationsStorages.DataSource = _dtAllOperationsStorages;
            cbFilterBy.SelectedIndex = 0;


            lblRecordsCount.Text = dgvOperationsStorages.Rows.Count.ToString();
            if (dgvOperationsStorages.Rows.Count > 0)
            {

                dgvOperationsStorages.Columns[0].HeaderText = "رقم العملية";
                dgvOperationsStorages.Columns[0].Width = 110;



                dgvOperationsStorages.Columns[1].HeaderText = "اسم المنتج";
                dgvOperationsStorages.Columns[1].Width = 130;

                dgvOperationsStorages.Columns[2].HeaderText = "اسم الوحدة";
                dgvOperationsStorages.Columns[2].Width = 130;

                dgvOperationsStorages.Columns[3].HeaderText = "اسم المخزن";
                dgvOperationsStorages.Columns[3].Width = 130;



                dgvOperationsStorages.Columns[4].HeaderText = "الكمية القديمة";
                dgvOperationsStorages.Columns[4].Width = 130;

             

                dgvOperationsStorages.Columns[5].HeaderText = "الكمية";
                dgvOperationsStorages.Columns[5].Width = 130;


                dgvOperationsStorages.Columns[6].HeaderText = "نوع العملية";
                dgvOperationsStorages.Columns[6].Width = 130;

                dgvOperationsStorages.Columns[7].HeaderText = "الكمية الجديدة";
                dgvOperationsStorages.Columns[7].Width = 130;

                dgvOperationsStorages.Columns[8].HeaderText = "تاريخ العملية";
                dgvOperationsStorages.Columns[8].Width = 160;

                dgvOperationsStorages.Columns[9].HeaderText = "السبب";
                dgvOperationsStorages.Columns[9].Width = 160;

                dgvOperationsStorages.Columns[10].HeaderText = "اسم الموظف";
                dgvOperationsStorages.Columns[10].Width = 130;

                dgvOperationsStorages.Columns[11].HeaderText = "اسم المستخدم";
                dgvOperationsStorages.Columns[11].Width = 130;
            }
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

       
        
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
                case "رقم العملية":
                    FilterColumn = "OperationStorageID";
                    break;


                case "اسم المنتج":
                    FilterColumn = "ItemName";
                    break;

                case "اسم الوحدة":
                    FilterColumn = "UnitName";
                    break;

                case "اسم المخزن":
                    FilterColumn = "StorageName";
                    break;



                case "نوع العملية":
                    FilterColumn = "TypeOperation";
                    break;

                case "السبب":
                    FilterColumn = "ReasonOperation";
                    break;

                case "اسم الموظف":
                    FilterColumn = "FullNameEmployee";
                    break;

                case "اسم المستخدم":
                    FilterColumn = "UserName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }



            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllOperationsStorages.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllOperationsStorages.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "OperationStorageID")
            {
                _dtAllOperationsStorages.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtAllOperationsStorages.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            lblRecordsCount.Text = _dtAllOperationsStorages.Rows.Count.ToString();
        }



        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only input number for Person ID
            if (cbFilterBy.Text == "رقم العملية")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }

    }
}
