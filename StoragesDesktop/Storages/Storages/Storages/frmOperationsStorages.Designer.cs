namespace Storages
{
    partial class frmOperationsStorages
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxStorages = new System.Windows.Forms.ComboBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.cbxUnits = new System.Windows.Forms.ComboBox();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.cbxTypeOfTransaction = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtReasonOperation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(720, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "اختر المستودع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(720, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "اختر المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(302, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "اختر الوحدة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(302, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "اختر الموظف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.Location = new System.Drawing.Point(299, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "نوع العملية";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.Location = new System.Drawing.Point(520, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "الكمية";
            // 
            // cbxStorages
            // 
            this.cbxStorages.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxStorages.FormattingEnabled = true;
            this.cbxStorages.Location = new System.Drawing.Point(494, 43);
            this.cbxStorages.Name = "cbxStorages";
            this.cbxStorages.Size = new System.Drawing.Size(220, 31);
            this.cbxStorages.TabIndex = 6;
            this.cbxStorages.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // cbxItems
            // 
            this.cbxItems.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(494, 103);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(220, 31);
            this.cbxItems.TabIndex = 7;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            // 
            // cbxUnits
            // 
            this.cbxUnits.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxUnits.FormattingEnabled = true;
            this.cbxUnits.Location = new System.Drawing.Point(50, 108);
            this.cbxUnits.Name = "cbxUnits";
            this.cbxUnits.Size = new System.Drawing.Size(236, 31);
            this.cbxUnits.TabIndex = 8;
            this.cbxUnits.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(50, 39);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(236, 31);
            this.cbxEmployee.TabIndex = 9;
            this.cbxEmployee.SelectedIndexChanged += new System.EventHandler(this.cbxEmployee_SelectedIndexChanged);
            this.cbxEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // cbxTypeOfTransaction
            // 
            this.cbxTypeOfTransaction.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxTypeOfTransaction.FormattingEnabled = true;
            this.cbxTypeOfTransaction.Location = new System.Drawing.Point(50, 40);
            this.cbxTypeOfTransaction.Name = "cbxTypeOfTransaction";
            this.cbxTypeOfTransaction.Size = new System.Drawing.Size(236, 31);
            this.cbxTypeOfTransaction.TabIndex = 10;
            this.cbxTypeOfTransaction.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtAmount.Location = new System.Drawing.Point(336, 170);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(163, 30);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNumericTextBox);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(399, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(102, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "تنفيذ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(330, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "اضافة / سحب من المخزن ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtReasonOperation
            // 
            this.txtReasonOperation.Location = new System.Drawing.Point(494, 26);
            this.txtReasonOperation.Multiline = true;
            this.txtReasonOperation.Name = "txtReasonOperation";
            this.txtReasonOperation.Size = new System.Drawing.Size(220, 59);
            this.txtReasonOperation.TabIndex = 14;
            this.txtReasonOperation.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label8.Location = new System.Drawing.Point(720, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "السبب:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStorages);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxItems);
            this.groupBox1.Controls.Add(this.cbxTypeOfTransaction);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxUnits);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 216);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات العملية ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReasonOperation);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxEmployee);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات اضافية";
            // 
            // frmOperationsStorages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(899, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Name = "frmOperationsStorages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/سحب من المخزن";
            this.Load += new System.EventHandler(this.frmOperationsStorages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxStorages;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.ComboBox cbxUnits;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.ComboBox cbxTypeOfTransaction;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReasonOperation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}