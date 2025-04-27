namespace Storages.Storages
{
    partial class frmListStorages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.اضافةصنفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضمحتوياتالمخزنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStorages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvStorages = new System.Windows.Forms.DataGridView();
            this.btnAddسفخقشلث = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsStorages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleDescription = "ؤ";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(543, 183);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 29);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "ادارة المخازن";
            // 
            // اضافةصنفToolStripMenuItem
            // 
            this.اضافةصنفToolStripMenuItem.AccessibleDescription = "ؤ";
            this.اضافةصنفToolStripMenuItem.Name = "اضافةصنفToolStripMenuItem";
            this.اضافةصنفToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.اضافةصنفToolStripMenuItem.Text = "اضافة مخزن";
            this.اضافةصنفToolStripMenuItem.Click += new System.EventHandler(this.اضافةصنفToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.AccessibleDescription = "ؤ";
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.AccessibleDescription = "ؤ";
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // عرضمحتوياتالمخزنToolStripMenuItem
            // 
            this.عرضمحتوياتالمخزنToolStripMenuItem.AccessibleDescription = "ؤ";
            this.عرضمحتوياتالمخزنToolStripMenuItem.Name = "عرضمحتوياتالمخزنToolStripMenuItem";
            this.عرضمحتوياتالمخزنToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.عرضمحتوياتالمخزنToolStripMenuItem.Text = "عرض محتويات المخزن";
            this.عرضمحتوياتالمخزنToolStripMenuItem.Click += new System.EventHandler(this.عرضمحتوياتالمخزنToolStripMenuItem_Click);
            // 
            // cmsStorages
            // 
            this.cmsStorages.AccessibleDescription = "ؤ";
            this.cmsStorages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةصنفToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.عرضمحتوياتالمخزنToolStripMenuItem});
            this.cmsStorages.Name = "cmsCategories";
            this.cmsStorages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsStorages.Size = new System.Drawing.Size(185, 92);
            // 
            // dgvStorages
            // 
            this.dgvStorages.AccessibleDescription = "ؤ";
            this.dgvStorages.AllowUserToAddRows = false;
            this.dgvStorages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStorages.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStorages.ContextMenuStrip = this.cmsStorages;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStorages.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStorages.Location = new System.Drawing.Point(8, 319);
            this.dgvStorages.Name = "dgvStorages";
            this.dgvStorages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStorages.Size = new System.Drawing.Size(1254, 355);
            this.dgvStorages.TabIndex = 33;
            // 
            // btnAddسفخقشلث
            // 
            this.btnAddسفخقشلث.AccessibleDescription = "ؤ";
            this.btnAddسفخقشلث.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddسفخقشلث.Location = new System.Drawing.Point(1149, 267);
            this.btnAddسفخقشلث.Name = "btnAddسفخقشلث";
            this.btnAddسفخقشلث.Size = new System.Drawing.Size(115, 37);
            this.btnAddسفخقشلث.TabIndex = 34;
            this.btnAddسفخقشلث.Text = "اضافة مخزن";
            this.btnAddسفخقشلث.UseVisualStyleBackColor = true;
            this.btnAddسفخقشلث.Click += new System.EventHandler(this.btnAddسفخقشلث_Click);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "ؤ";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "فلترة باستخدام";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AccessibleDescription = "ؤ";
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtFilterValue.Location = new System.Drawing.Point(339, 267);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterValue.Size = new System.Drawing.Size(254, 30);
            this.txtFilterValue.TabIndex = 36;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.AccessibleDescription = "ؤ";
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "لا شيء",
            "رقم المخزن",
            "اسم المخزن",
            "الموقع"});
            this.cbFilterBy.Location = new System.Drawing.Point(111, 266);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(208, 31);
            this.cbFilterBy.TabIndex = 37;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "ؤ";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(10, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "عدد المخازن:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AccessibleDescription = "ؤ";
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblRecordsCount.Location = new System.Drawing.Point(166, 695);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(28, 23);
            this.lblRecordsCount.TabIndex = 39;
            this.lblRecordsCount.Text = "??";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "ؤ";
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Location = new System.Drawing.Point(1191, 689);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 37);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Storages.Properties.Resources.storage;
            this.pictureBox1.Location = new System.Drawing.Point(511, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmListStorages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1274, 744);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddسفخقشلث);
            this.Controls.Add(this.dgvStorages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmListStorages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المخازن";
            this.Load += new System.EventHandler(this.frmListStorages_Load);
            this.cmsStorages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem اضافةصنفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضمحتوياتالمخزنToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsStorages;
        private System.Windows.Forms.DataGridView dgvStorages;
        private System.Windows.Forms.Button btnAddسفخقشلث;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
    }
}