namespace Storages.Employees
{
    partial class frmAddUpdateEmployee
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
            this.tapEmployeeInfo = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter11 = new People.Controls.ctrlPersonCardWithFilter1();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.rdbNotActive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserNameEmployee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tapEmployeeInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tapEmployeeInfo
            // 
            this.tapEmployeeInfo.Controls.Add(this.tabPersonalInfo);
            this.tapEmployeeInfo.Controls.Add(this.tabEmployee);
            this.tapEmployeeInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tapEmployeeInfo.Location = new System.Drawing.Point(12, 12);
            this.tapEmployeeInfo.Name = "tapEmployeeInfo";
            this.tapEmployeeInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tapEmployeeInfo.RightToLeftLayout = true;
            this.tapEmployeeInfo.SelectedIndex = 0;
            this.tapEmployeeInfo.Size = new System.Drawing.Size(1063, 675);
            this.tapEmployeeInfo.TabIndex = 0;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.tabPersonalInfo.Controls.Add(this.btnNext);
            this.tabPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter11);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(1055, 646);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "المعلومات الشخصية";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(18, 594);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 36);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "التالي";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter11
            // 
            this.ctrlPersonCardWithFilter11.BackColor = System.Drawing.Color.DarkSalmon;
            this.ctrlPersonCardWithFilter11.FilterEnabled = true;
            this.ctrlPersonCardWithFilter11.Location = new System.Drawing.Point(18, 17);
            this.ctrlPersonCardWithFilter11.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCardWithFilter11.Name = "ctrlPersonCardWithFilter11";
            this.ctrlPersonCardWithFilter11.Size = new System.Drawing.Size(1017, 560);
            this.ctrlPersonCardWithFilter11.TabIndex = 0;
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.Color.DarkSalmon;
            this.tabEmployee.Controls.Add(this.rdbNotActive);
            this.tabEmployee.Controls.Add(this.rdbActive);
            this.tabEmployee.Controls.Add(this.label5);
            this.tabEmployee.Controls.Add(this.lblEmployeeID);
            this.tabEmployee.Controls.Add(this.txtConfirmPassword);
            this.tabEmployee.Controls.Add(this.txtPassword);
            this.tabEmployee.Controls.Add(this.txtUserNameEmployee);
            this.tabEmployee.Controls.Add(this.label4);
            this.tabEmployee.Controls.Add(this.label3);
            this.tabEmployee.Controls.Add(this.label2);
            this.tabEmployee.Controls.Add(this.label1);
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1055, 646);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "معلومات الموظف";
            this.tabEmployee.Click += new System.EventHandler(this.tabEmployee_Click);
            // 
            // rdbNotActive
            // 
            this.rdbNotActive.AutoSize = true;
            this.rdbNotActive.Location = new System.Drawing.Point(506, 282);
            this.rdbNotActive.Name = "rdbNotActive";
            this.rdbNotActive.Size = new System.Drawing.Size(78, 21);
            this.rdbNotActive.TabIndex = 50;
            this.rdbNotActive.TabStop = true;
            this.rdbNotActive.Text = "غير نشط";
            this.rdbNotActive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Location = new System.Drawing.Point(632, 282);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(55, 21);
            this.rdbActive.TabIndex = 49;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "نشط";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(790, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "الحالة:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmployeeID.Location = new System.Drawing.Point(637, 80);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(54, 23);
            this.lblEmployeeID.TabIndex = 47;
            this.lblEmployeeID.Text = "????";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(506, 231);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(181, 24);
            this.txtConfirmPassword.TabIndex = 46;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(506, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 24);
            this.txtPassword.TabIndex = 45;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating_1);
            // 
            // txtUserNameEmployee
            // 
            this.txtUserNameEmployee.Location = new System.Drawing.Point(506, 135);
            this.txtUserNameEmployee.Name = "txtUserNameEmployee";
            this.txtUserNameEmployee.Size = new System.Drawing.Size(181, 24);
            this.txtUserNameEmployee.TabIndex = 44;
            this.txtUserNameEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountNumber_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(709, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "تأكيد كلمة السر:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(752, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "كلمة السر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(709, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "اسم المستخدم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(741, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "رقم الموظف:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(982, 702);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(866, 702);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 46);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1083, 750);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tapEmployeeInfo);
            this.Name = "frmAddUpdateEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة-تعديل موظف";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.tapEmployeeInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tapEmployeeInfo;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.Button btnNext;
        private People.Controls.ctrlPersonCardWithFilter1 ctrlPersonCardWithFilter11;
        private System.Windows.Forms.RadioButton rdbNotActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserNameEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}