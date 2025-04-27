namespace Storages
{
    partial class frmConvertBetweenStorages
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtReasonOperation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbxEmployees = new System.Windows.Forms.ComboBox();
            this.cbxUnits = new System.Windows.Forms.ComboBox();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.cbxStorage2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStorage1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label8.Location = new System.Drawing.Point(727, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "السبب:";
            // 
            // txtReasonOperation
            // 
            this.txtReasonOperation.Location = new System.Drawing.Point(462, 40);
            this.txtReasonOperation.Multiline = true;
            this.txtReasonOperation.Name = "txtReasonOperation";
            this.txtReasonOperation.Size = new System.Drawing.Size(248, 73);
            this.txtReasonOperation.TabIndex = 30;
            this.txtReasonOperation.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(380, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "التحويل بين المخازن";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(401, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(127, 33);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "تحويل";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtAmount.Location = new System.Drawing.Point(332, 98);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(163, 30);
            this.txtAmount.TabIndex = 27;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNumericTextBox);
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.Location = new System.Drawing.Point(24, 40);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(216, 31);
            this.cbxEmployees.TabIndex = 25;
            this.cbxEmployees.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // cbxUnits
            // 
            this.cbxUnits.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxUnits.FormattingEnabled = true;
            this.cbxUnits.Location = new System.Drawing.Point(26, 37);
            this.cbxUnits.Name = "cbxUnits";
            this.cbxUnits.Size = new System.Drawing.Size(276, 31);
            this.cbxUnits.TabIndex = 24;
            this.cbxUnits.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // cbxItems
            // 
            this.cbxItems.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(462, 37);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(248, 31);
            this.cbxItems.TabIndex = 23;
            this.cbxItems.SelectedIndexChanged += new System.EventHandler(this.cbxItems_SelectedIndexChanged);
            this.cbxItems.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // cbxStorage2
            // 
            this.cbxStorage2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxStorage2.FormattingEnabled = true;
            this.cbxStorage2.Location = new System.Drawing.Point(26, 44);
            this.cbxStorage2.Name = "cbxStorage2";
            this.cbxStorage2.Size = new System.Drawing.Size(276, 31);
            this.cbxStorage2.TabIndex = 22;
            this.cbxStorage2.SelectedIndexChanged += new System.EventHandler(this.cbxStorages_SelectedIndexChanged);
            this.cbxStorage2.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(246, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "اختر الموظف المسؤول:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.Location = new System.Drawing.Point(510, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "الكمية:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(308, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "اختر الوحدة:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(727, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "اختر المنتج:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(308, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "الى المستودع:";
            // 
            // cbxStorage1
            // 
            this.cbxStorage1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxStorage1.FormattingEnabled = true;
            this.cbxStorage1.Location = new System.Drawing.Point(462, 44);
            this.cbxStorage1.Name = "cbxStorage1";
            this.cbxStorage1.Size = new System.Drawing.Size(248, 31);
            this.cbxStorage1.TabIndex = 33;
            this.cbxStorage1.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateComboBoxSelection);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label9.Location = new System.Drawing.Point(727, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "من المستودع:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxStorage1);
            this.groupBox1.Controls.Add(this.cbxStorage2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(21, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "التحويل";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxItems);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxUnits);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(21, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 148);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحديد البضاعة المراد تحويلها";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReasonOperation);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbxEmployees);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.Location = new System.Drawing.Point(21, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 144);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "معلومات أخرى";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConvertBetweenStorages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(907, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Name = "ConvertBetweenStorages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التحويل بين المخازن";
            this.Load += new System.EventHandler(this.ConvertBetweenStorages_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReasonOperation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbxEmployees;
        private System.Windows.Forms.ComboBox cbxUnits;
        private System.Windows.Forms.ComboBox cbxItems;
        private System.Windows.Forms.ComboBox cbxStorage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStorage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}