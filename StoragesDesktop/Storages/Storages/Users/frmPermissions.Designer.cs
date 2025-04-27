namespace Storages.Users
{
    partial class frmPermissions
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxUnits = new System.Windows.Forms.CheckBox();
            this.cbxCategories = new System.Windows.Forms.CheckBox();
            this.cbxItems = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxConvertBetweenStorages = new System.Windows.Forms.CheckBox();
            this.cbxOperationStorage = new System.Windows.Forms.CheckBox();
            this.cbxStorages = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxPeople = new System.Windows.Forms.CheckBox();
            this.cbxUsers = new System.Windows.Forms.CheckBox();
            this.cbxEmployees = new System.Windows.Forms.CheckBox();
            this.cbxAllPermissions = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxUnits);
            this.groupBox3.Controls.Add(this.cbxCategories);
            this.groupBox3.Controls.Add(this.cbxItems);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.Location = new System.Drawing.Point(12, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 111);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // cbxUnits
            // 
            this.cbxUnits.AutoSize = true;
            this.cbxUnits.Location = new System.Drawing.Point(22, 42);
            this.cbxUnits.Name = "cbxUnits";
            this.cbxUnits.Size = new System.Drawing.Size(81, 23);
            this.cbxUnits.TabIndex = 12;
            this.cbxUnits.Tag = "32";
            this.cbxUnits.Text = "الوحدات";
            this.cbxUnits.UseVisualStyleBackColor = true;
            // 
            // cbxCategories
            // 
            this.cbxCategories.AutoSize = true;
            this.cbxCategories.Location = new System.Drawing.Point(222, 42);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(79, 23);
            this.cbxCategories.TabIndex = 13;
            this.cbxCategories.Tag = "32";
            this.cbxCategories.Text = "الأصناف";
            this.cbxCategories.UseVisualStyleBackColor = true;
            // 
            // cbxItems
            // 
            this.cbxItems.AutoSize = true;
            this.cbxItems.Location = new System.Drawing.Point(395, 42);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(88, 23);
            this.cbxItems.TabIndex = 14;
            this.cbxItems.Tag = "32";
            this.cbxItems.Text = "المنتجات";
            this.cbxItems.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxConvertBetweenStorages);
            this.groupBox2.Controls.Add(this.cbxOperationStorage);
            this.groupBox2.Controls.Add(this.cbxStorages);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // cbxConvertBetweenStorages
            // 
            this.cbxConvertBetweenStorages.AutoSize = true;
            this.cbxConvertBetweenStorages.Location = new System.Drawing.Point(322, 28);
            this.cbxConvertBetweenStorages.Name = "cbxConvertBetweenStorages";
            this.cbxConvertBetweenStorages.Size = new System.Drawing.Size(161, 23);
            this.cbxConvertBetweenStorages.TabIndex = 12;
            this.cbxConvertBetweenStorages.Tag = "8";
            this.cbxConvertBetweenStorages.Text = "التحويل بين المخازن";
            this.cbxConvertBetweenStorages.UseVisualStyleBackColor = true;
            this.cbxConvertBetweenStorages.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxOperationStorage
            // 
            this.cbxOperationStorage.AutoSize = true;
            this.cbxOperationStorage.Location = new System.Drawing.Point(6, 28);
            this.cbxOperationStorage.Name = "cbxOperationStorage";
            this.cbxOperationStorage.Size = new System.Drawing.Size(178, 23);
            this.cbxOperationStorage.TabIndex = 10;
            this.cbxOperationStorage.Tag = "8";
            this.cbxOperationStorage.Text = "العمليات على المخازن";
            this.cbxOperationStorage.UseVisualStyleBackColor = true;
            // 
            // cbxStorages
            // 
            this.cbxStorages.AutoSize = true;
            this.cbxStorages.Location = new System.Drawing.Point(221, 26);
            this.cbxStorages.Name = "cbxStorages";
            this.cbxStorages.Size = new System.Drawing.Size(80, 23);
            this.cbxStorages.TabIndex = 11;
            this.cbxStorages.Tag = "16";
            this.cbxStorages.Text = "المخازن";
            this.cbxStorages.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPeople);
            this.groupBox1.Controls.Add(this.cbxUsers);
            this.groupBox1.Controls.Add(this.cbxEmployees);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // cbxPeople
            // 
            this.cbxPeople.AutoSize = true;
            this.cbxPeople.Location = new System.Drawing.Point(18, 29);
            this.cbxPeople.Name = "cbxPeople";
            this.cbxPeople.Size = new System.Drawing.Size(92, 23);
            this.cbxPeople.TabIndex = 7;
            this.cbxPeople.Tag = "1";
            this.cbxPeople.Text = "الاشحاص";
            this.cbxPeople.UseVisualStyleBackColor = true;
            // 
            // cbxUsers
            // 
            this.cbxUsers.AutoSize = true;
            this.cbxUsers.Location = new System.Drawing.Point(185, 29);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(116, 23);
            this.cbxUsers.TabIndex = 8;
            this.cbxUsers.Tag = "2";
            this.cbxUsers.Text = "المستخدمين";
            this.cbxUsers.UseVisualStyleBackColor = true;
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.AutoSize = true;
            this.cbxEmployees.Location = new System.Drawing.Point(392, 29);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(91, 23);
            this.cbxEmployees.TabIndex = 9;
            this.cbxEmployees.Tag = "4";
            this.cbxEmployees.Text = "الموظفين";
            this.cbxEmployees.UseVisualStyleBackColor = true;
            // 
            // cbxAllPermissions
            // 
            this.cbxAllPermissions.AutoSize = true;
            this.cbxAllPermissions.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxAllPermissions.Location = new System.Drawing.Point(216, 382);
            this.cbxAllPermissions.Name = "cbxAllPermissions";
            this.cbxAllPermissions.Size = new System.Drawing.Size(103, 23);
            this.cbxAllPermissions.TabIndex = 20;
            this.cbxAllPermissions.Text = "كل الاذونات";
            this.cbxAllPermissions.UseVisualStyleBackColor = true;
            this.cbxAllPermissions.CheckedChanged += new System.EventHandler(this.cbxAllPermissions_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(216, 438);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(529, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxAllPermissions);
            this.Controls.Add(this.btnSave);
            this.Name = "frmPermissions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاذونات";
            this.Load += new System.EventHandler(this.frmPermissions_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxUnits;
        private System.Windows.Forms.CheckBox cbxCategories;
        private System.Windows.Forms.CheckBox cbxItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxOperationStorage;
        private System.Windows.Forms.CheckBox cbxStorages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxPeople;
        private System.Windows.Forms.CheckBox cbxUsers;
        private System.Windows.Forms.CheckBox cbxEmployees;
        private System.Windows.Forms.CheckBox cbxAllPermissions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxConvertBetweenStorages;
    }
}