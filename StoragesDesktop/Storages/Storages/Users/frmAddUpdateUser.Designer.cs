namespace Storages.Users
{
    partial class frmAddUpdateUser
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
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tapLoginInfo = new System.Windows.Forms.TabPage();
            this.btnSelectPermmissions = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.chxIsActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCardWithFilter11 = new People.Controls.ctrlPersonCardWithFilter1();
            this.tcUserInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tapLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tabPersonalInfo);
            this.tcUserInfo.Controls.Add(this.tapLoginInfo);
            this.tcUserInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tcUserInfo.Location = new System.Drawing.Point(12, 92);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.RightToLeftLayout = true;
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1050, 657);
            this.tcUserInfo.TabIndex = 0;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.tabPersonalInfo.Controls.Add(this.btnNext);
            this.tabPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter11);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(1042, 628);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "المعلومات الشخصية";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(35, 585);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "التالي";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // tapLoginInfo
            // 
            this.tapLoginInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.tapLoginInfo.Controls.Add(this.btnSelectPermmissions);
            this.tapLoginInfo.Controls.Add(this.lblUserID);
            this.tapLoginInfo.Controls.Add(this.chxIsActive);
            this.tapLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tapLoginInfo.Controls.Add(this.txtPassword);
            this.tapLoginInfo.Controls.Add(this.txtUserName);
            this.tapLoginInfo.Controls.Add(this.label4);
            this.tapLoginInfo.Controls.Add(this.label3);
            this.tapLoginInfo.Controls.Add(this.label2);
            this.tapLoginInfo.Controls.Add(this.label1);
            this.tapLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tapLoginInfo.Name = "tapLoginInfo";
            this.tapLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tapLoginInfo.Size = new System.Drawing.Size(1042, 628);
            this.tapLoginInfo.TabIndex = 1;
            this.tapLoginInfo.Text = "معلومات الدخول";
            // 
            // btnSelectPermmissions
            // 
            this.btnSelectPermmissions.Location = new System.Drawing.Point(660, 305);
            this.btnSelectPermmissions.Name = "btnSelectPermmissions";
            this.btnSelectPermmissions.Size = new System.Drawing.Size(181, 31);
            this.btnSelectPermmissions.TabIndex = 26;
            this.btnSelectPermmissions.Text = "اختر الاذونات";
            this.btnSelectPermmissions.UseVisualStyleBackColor = true;
            this.btnSelectPermmissions.Click += new System.EventHandler(this.btnSelectPermmissions_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserID.Location = new System.Drawing.Point(791, 89);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(54, 23);
            this.lblUserID.TabIndex = 25;
            this.lblUserID.Text = "????";
            // 
            // chxIsActive
            // 
            this.chxIsActive.AutoSize = true;
            this.chxIsActive.Location = new System.Drawing.Point(788, 381);
            this.chxIsActive.Name = "chxIsActive";
            this.chxIsActive.Size = new System.Drawing.Size(53, 21);
            this.chxIsActive.TabIndex = 24;
            this.chxIsActive.Text = "فعال";
            this.chxIsActive.UseVisualStyleBackColor = true;
            this.chxIsActive.CheckedChanged += new System.EventHandler(this.chxIsActive_CheckedChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(661, 234);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(181, 24);
            this.txtConfirmPassword.TabIndex = 23;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(661, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 24);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(660, 134);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(181, 24);
            this.txtUserName.TabIndex = 21;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(867, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "تأكيد كلمة السر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(867, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "كلمة السر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(867, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "اسم المستخدم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(867, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "رقم المستخدم :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClose.Location = new System.Drawing.Point(942, 755);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(790, 755);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(410, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 27);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "تعديل معلومات المستخدم";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter11
            // 
            this.ctrlPersonCardWithFilter11.BackColor = System.Drawing.Color.DarkSalmon;
            this.ctrlPersonCardWithFilter11.FilterEnabled = true;
            this.ctrlPersonCardWithFilter11.Location = new System.Drawing.Point(16, 19);
            this.ctrlPersonCardWithFilter11.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCardWithFilter11.Name = "ctrlPersonCardWithFilter11";
            this.ctrlPersonCardWithFilter11.Size = new System.Drawing.Size(998, 568);
            this.ctrlPersonCardWithFilter11.TabIndex = 0;
            this.ctrlPersonCardWithFilter11.Load += new System.EventHandler(this.ctrlPersonCardWithFilter11_Load);
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1081, 803);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUserInfo);
            this.Name = "frmAddUpdateUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/تعديل مستخدم";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tcUserInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tapLoginInfo.ResumeLayout(false);
            this.tapLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.TabPage tapLoginInfo;
        private System.Windows.Forms.Button btnNext;
        private People.Controls.ctrlPersonCardWithFilter1 ctrlPersonCardWithFilter11;
        private System.Windows.Forms.Button btnSelectPermmissions;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.CheckBox chxIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}