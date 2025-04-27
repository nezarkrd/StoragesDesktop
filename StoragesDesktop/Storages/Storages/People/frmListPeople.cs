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

namespace Storages.People
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

       

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        
        
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "FirstName", "LastName", "Phone", "Email", "Gendor", "DateBirth", "ImagePath", "Nationality", "NationalNO");

        private void _RefreshPeoplList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();

            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "FirstName", "LastName", "Phone", "Email", "Gendor", "DateBirth", "ImagePath", "Nationality", "NationalNO");

            dgvPeple.DataSource = _dtPeople;
            lblRecordsCount.Text = dgvPeple.Rows.Count.ToString();
        }





      

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvPeple.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPeple.Rows.Count.ToString();
            if (dgvPeple.Rows.Count > 0)
            {

                dgvPeple.Columns[0].HeaderText = "رقم الشخص";
                dgvPeple.Columns[0].Width = 120;



                dgvPeple.Columns[1].HeaderText = "الاسم الأول";
                dgvPeple.Columns[1].Width = 150;

                dgvPeple.Columns[2].HeaderText = "الاسم الاخير";
                dgvPeple.Columns[2].Width = 150;


                dgvPeple.Columns[3].HeaderText = "جوال";
                dgvPeple.Columns[3].Width = 170;


                dgvPeple.Columns[4].HeaderText = "ايميل";
                dgvPeple.Columns[4].Width = 190;


                dgvPeple.Columns[5].HeaderText = "الجنس";
                dgvPeple.Columns[5].Width = 120;

                dgvPeple.Columns[6].HeaderText = "تاريخ الميلاد";
                dgvPeple.Columns[6].Width = 190;


                dgvPeple.Columns[7].HeaderText = "رابط الصورة";
                dgvPeple.Columns[7].Width = 190;

                dgvPeple.Columns[8].HeaderText = "الجنسية";
                dgvPeple.Columns[8].Width = 120;

                dgvPeple.Columns[9].HeaderText = "رقم الهوية";
                dgvPeple.Columns[9].Width = 130;



            }

        }


      
        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
                case "رقم الشخص":
                    FilterColumn = "PersonID";
                    break;

                case "الاسم الأول":
                    FilterColumn = "FirstName";
                    break;
                case "الاسم الاخير":
                    FilterColumn = "LastName";
                    break;
                case "جوال":
                    FilterColumn = "Phone";
                    break;
                case "ايميل":
                    FilterColumn = "Email";
                    break;
                case "الجنس":
                    FilterColumn = "Gendor";
                    break;

                case "الجنسية":
                    FilterColumn = "Nationality";
                    break;
                case "رقم الهوية":
                    FilterColumn = "NationalNO";
                    break;

                default:
                    FilterColumn = "لا شيء";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "لا شيء")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtPeople.Rows.Count.ToString();
                return;

            }

            if (FilterColumn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else { _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim()); }

            lblRecordsCount.Text = dgvPeple.Rows.Count.ToString();

        }





        private void dgvPeple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dgvPeple_DoubleClick_1(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvPeple.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }


        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //only input number for Person ID
            if (cbFilterBy.Text == "رقم الشخص")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();


        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            if (clsPerson.DeletePerson(PersonID))
            {
                MessageBox.Show("تم حذف الشخص بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _RefreshPeoplList();
            }
            else
            {
                MessageBox.Show("لم يتم حذف الشخص لأنه يحتوي على بيانات مرتبطة به.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dgvPeple_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void عرضمعلوماتالشخصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void اضافةشخصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeple.CurrentRow.Cells[0].Value;
            if (clsPerson.DeletePerson(PersonID))
            {
                MessageBox.Show("تم حذف الشخص بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _RefreshPeoplList();
            }
            else
            {
                MessageBox.Show("لم يتم حذف الشخص لأنه يحتوي على بيانات مرتبطة به.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
