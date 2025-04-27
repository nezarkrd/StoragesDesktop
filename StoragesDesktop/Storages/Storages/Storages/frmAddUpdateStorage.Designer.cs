namespace Storages
{
    partial class frmAddUpdateStorage
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfoStorage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStorageName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSorageID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocationStorage = new System.Windows.Forms.TextBox();
            this.btnCose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(349, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(21, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "معلومات المخزن:";
            // 
            // txtInfoStorage
            // 
            this.txtInfoStorage.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtInfoStorage.Location = new System.Drawing.Point(193, 277);
            this.txtInfoStorage.Multiline = true;
            this.txtInfoStorage.Name = "txtInfoStorage";
            this.txtInfoStorage.Size = new System.Drawing.Size(260, 86);
            this.txtInfoStorage.TabIndex = 20;
            this.txtInfoStorage.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(54, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "موقع المخزن:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(54, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "اسم المخزن:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStorageName
            // 
            this.txtStorageName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtStorageName.Location = new System.Drawing.Point(193, 144);
            this.txtStorageName.Name = "txtStorageName";
            this.txtStorageName.Size = new System.Drawing.Size(260, 33);
            this.txtStorageName.TabIndex = 17;
            this.txtStorageName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
            this.txtStorageName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(187, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 33);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "اضافة مخزن جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSorageID
            // 
            this.lblSorageID.AutoSize = true;
            this.lblSorageID.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblSorageID.ForeColor = System.Drawing.Color.Red;
            this.lblSorageID.Location = new System.Drawing.Point(193, 75);
            this.lblSorageID.Name = "lblSorageID";
            this.lblSorageID.Size = new System.Drawing.Size(52, 27);
            this.lblSorageID.TabIndex = 15;
            this.lblSorageID.Text = "؟؟؟؟";
            this.lblSorageID.Click += new System.EventHandler(this.lblUnitID_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.Location = new System.Drawing.Point(65, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 27);
            this.label10.TabIndex = 14;
            this.label10.Text = "رقم المخزن:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtLocationStorage
            // 
            this.txtLocationStorage.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtLocationStorage.Location = new System.Drawing.Point(193, 209);
            this.txtLocationStorage.Name = "txtLocationStorage";
            this.txtLocationStorage.Size = new System.Drawing.Size(260, 33);
            this.txtLocationStorage.TabIndex = 24;
            this.txtLocationStorage.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // btnCose
            // 
            this.btnCose.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCose.Location = new System.Drawing.Point(193, 383);
            this.btnCose.Name = "btnCose";
            this.btnCose.Size = new System.Drawing.Size(104, 42);
            this.btnCose.TabIndex = 25;
            this.btnCose.Text = "اغلاق";
            this.btnCose.UseVisualStyleBackColor = true;
            this.btnCose.Click += new System.EventHandler(this.btnCose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(501, 449);
            this.Controls.Add(this.btnCose);
            this.Controls.Add(this.txtLocationStorage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInfoStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStorageName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSorageID);
            this.Controls.Add(this.label10);
            this.Name = "frmAddUpdateStorage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/ تعديل مخزن";
            this.Load += new System.EventHandler(this.frmAddUpdateStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfoStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStorageName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSorageID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLocationStorage;
        private System.Windows.Forms.Button btnCose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

