namespace Storages.Storages
{
    partial class frmStorageContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSumTotalBuy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStoragesContent = new System.Windows.Forms.DataGridView();
            this.lblSumTotalSell = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoragesContent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Storages.Properties.Resources.storage;
            this.pictureBox1.Location = new System.Drawing.Point(516, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleDescription = "";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(541, 208);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 29);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "محتوى المخزن";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "ؤ";
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Location = new System.Drawing.Point(1213, 710);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 37);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSumTotalBuy
            // 
            this.lblSumTotalBuy.AccessibleDescription = "";
            this.lblSumTotalBuy.AutoSize = true;
            this.lblSumTotalBuy.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblSumTotalBuy.Location = new System.Drawing.Point(299, 716);
            this.lblSumTotalBuy.Name = "lblSumTotalBuy";
            this.lblSumTotalBuy.Size = new System.Drawing.Size(28, 23);
            this.lblSumTotalBuy.TabIndex = 49;
            this.lblSumTotalBuy.Text = "??";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "ؤ";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(26, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "الاجمالي بسعر الشراء:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.AccessibleDescription = "ؤ";
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "لا شيء",
            "اسم المنتج"});
            this.cbFilterBy.Location = new System.Drawing.Point(133, 279);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(208, 31);
            this.cbFilterBy.TabIndex = 47;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged_1);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AccessibleDescription = "ؤ";
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtFilterValue.Location = new System.Drawing.Point(361, 280);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterValue.Size = new System.Drawing.Size(254, 30);
            this.txtFilterValue.TabIndex = 46;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "ؤ";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "فلترة باستخدام";
            // 
            // dgvStoragesContent
            // 
            this.dgvStoragesContent.AccessibleDescription = "";
            this.dgvStoragesContent.AllowUserToAddRows = false;
            this.dgvStoragesContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoragesContent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoragesContent.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoragesContent.Location = new System.Drawing.Point(30, 332);
            this.dgvStoragesContent.Name = "dgvStoragesContent";
            this.dgvStoragesContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStoragesContent.Size = new System.Drawing.Size(1254, 355);
            this.dgvStoragesContent.TabIndex = 43;
            // 
            // lblSumTotalSell
            // 
            this.lblSumTotalSell.AccessibleDescription = "";
            this.lblSumTotalSell.AutoSize = true;
            this.lblSumTotalSell.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblSumTotalSell.Location = new System.Drawing.Point(733, 716);
            this.lblSumTotalSell.Name = "lblSumTotalSell";
            this.lblSumTotalSell.Size = new System.Drawing.Size(28, 23);
            this.lblSumTotalSell.TabIndex = 51;
            this.lblSumTotalSell.Text = "??";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "ؤ";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(450, 716);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "الاجمالي بسعر البيع:";
            // 
            // frmStorageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1312, 765);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSumTotalSell);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSumTotalBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStoragesContent);
            this.Name = "frmStorageContent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محتويات المخزن";
            this.Load += new System.EventHandler(this.frmStorageContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoragesContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSumTotalBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStoragesContent;
        private System.Windows.Forms.Label lblSumTotalSell;
        private System.Windows.Forms.Label label3;
    }
}