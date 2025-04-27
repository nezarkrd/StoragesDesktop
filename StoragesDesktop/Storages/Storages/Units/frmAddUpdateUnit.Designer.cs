namespace Storages
{
    partial class frmAddUpdateUnit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSmallerUnitID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(313, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 33);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "اضافة وحدة جديدة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblUnitID.ForeColor = System.Drawing.Color.Red;
            this.lblUnitID.Location = new System.Drawing.Point(170, 79);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(52, 27);
            this.lblUnitID.TabIndex = 5;
            this.lblUnitID.Text = "؟؟؟؟";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.Location = new System.Drawing.Point(30, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "رقم الوحدة:";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtUnitName.Location = new System.Drawing.Point(163, 146);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(187, 33);
            this.txtUnitName.TabIndex = 7;
            this.txtUnitName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(30, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم الوحدة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(423, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "الوحدة الأصغر:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumberOfContent
            // 
            this.txtNumberOfContent.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtNumberOfContent.Location = new System.Drawing.Point(469, 217);
            this.txtNumberOfContent.Name = "txtNumberOfContent";
            this.txtNumberOfContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumberOfContent.Size = new System.Drawing.Size(187, 33);
            this.txtNumberOfContent.TabIndex = 10;
            this.txtNumberOfContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberOfContent.TextChanged += new System.EventHandler(this.txtNumberOfContent_TextChanged);
            this.txtNumberOfContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfContent_KeyPress);
            this.txtNumberOfContent.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(128, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "عدد الوحدات الاصغر داخل الوحدة:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSmallerUnitID
            // 
            this.cbxSmallerUnitID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxSmallerUnitID.FormattingEnabled = true;
            this.cbxSmallerUnitID.Location = new System.Drawing.Point(583, 148);
            this.cbxSmallerUnitID.Name = "cbxSmallerUnitID";
            this.cbxSmallerUnitID.Size = new System.Drawing.Size(187, 31);
            this.cbxSmallerUnitID.TabIndex = 12;
            this.cbxSmallerUnitID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(358, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(830, 344);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxSmallerUnitID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumberOfContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUnitID);
            this.Controls.Add(this.label10);
            this.Name = "frmAddUpdateUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/ تعديل وحدة";
            this.Load += new System.EventHandler(this.frmAddUpdateUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSmallerUnitID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}