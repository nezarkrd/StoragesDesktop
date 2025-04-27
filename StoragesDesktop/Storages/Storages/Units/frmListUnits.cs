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

namespace Storages.Units
{
    public partial class frmListUnits : Form
    {
        public frmListUnits()
        {
            InitializeComponent();
        }



        

        private static DataTable _dtAllUnits = clsUnit.GetAllUnits();

       

        private void _RefreshUnitsList()
        {
            _dtAllUnits = clsUnit.GetAllUnits();

           

            dgvUnits.DataSource = _dtAllUnits;
            lblRecordsCount.Text = dgvUnits.Rows.Count.ToString();
        }





        private void frmListUnits_Load(object sender, EventArgs e)
        {
            dgvUnits.DataSource = _dtAllUnits;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvUnits.Rows.Count.ToString();
            if (dgvUnits.Rows.Count > 0)
            {

                dgvUnits.Columns[0].HeaderText = "رقم الوحدة";
                dgvUnits.Columns[0].Width = 120;



                dgvUnits.Columns[1].HeaderText = "اسم الوحدة";
                dgvUnits.Columns[1].Width = 150;

                dgvUnits.Columns[2].HeaderText = "اسم الوحدة الأصغر";
                dgvUnits.Columns[2].Width = 150;


                dgvUnits.Columns[3].HeaderText = "عدد محتويات الوحدة";
                dgvUnits.Columns[3].Width = 170;


     

            }
        }



        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
                case "رقم الوحدة":
                    FilterColumn = "UnitID";
                    break;

                case "اسم الوحدة":
                    FilterColumn = "UnitName";
                    break;
                case "اسم الوحدة الأصغر":
                    
                    FilterColumn = "SmallUnitName";
                    break;
                case "عدد محتويات الوحدة":
                    FilterColumn = "NumberOfContent";
                    break;
              

                default:
                    FilterColumn = "None";
                    break;

            }
      

          
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUnits.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtAllUnits.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "UnitID" || FilterColumn== "NumberOfContent")
            {
                _dtAllUnits.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtAllUnits.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            lblRecordsCount.Text = dgvUnits.Rows.Count.ToString();
        }


        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only input number for Person ID
            if (cbFilterBy.Text == "رقم الوحدة" || cbFilterBy.Text == "عدد محتويات الوحدة")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }







        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUnit();
            frm.ShowDialog();
            _RefreshUnitsList();
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




        private void dgvPeple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void dgvUnits_DoubleClick(object sender, EventArgs e)
        {
         

        }

        private void اضافةوحدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUnit();
            frm.ShowDialog();
            _RefreshUnitsList();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUnit((int)dgvUnits.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUnitsList();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUnit.DeleteUnit((int)dgvUnits.CurrentRow.Cells[0].Value);
            _RefreshUnitsList();
        }

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }
    }
}
