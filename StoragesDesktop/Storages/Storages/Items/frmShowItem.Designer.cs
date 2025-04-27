namespace Storages.Items
{
    partial class frmShowItem
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
            this.lblItemID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.dgvUnitsItems = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStorageContent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblItemID.ForeColor = System.Drawing.Color.Red;
            this.lblItemID.Location = new System.Drawing.Point(191, 57);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(52, 27);
            this.lblItemID.TabIndex = 30;
            this.lblItemID.Text = "؟؟؟؟";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.Location = new System.Drawing.Point(48, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 27);
            this.label10.TabIndex = 29;
            this.label10.Text = "رقم المنتج:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(48, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "اسم المنتج:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblItemName.ForeColor = System.Drawing.Color.Red;
            this.lblItemName.Location = new System.Drawing.Point(191, 141);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(52, 27);
            this.lblItemName.TabIndex = 32;
            this.lblItemName.Text = "؟؟؟؟";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(47, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "اسم الصنف:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblCategory.ForeColor = System.Drawing.Color.Red;
            this.lblCategory.Location = new System.Drawing.Point(190, 221);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 27);
            this.lblCategory.TabIndex = 34;
            this.lblCategory.Text = "؟؟؟؟";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(355, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "معلومات اضافية:";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDiscription.Location = new System.Drawing.Point(548, 64);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.ReadOnly = true;
            this.txtDiscription.Size = new System.Drawing.Size(253, 184);
            this.txtDiscription.TabIndex = 36;
            this.txtDiscription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvUnitsItems
            // 
            this.dgvUnitsItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnitsItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitsItems.Location = new System.Drawing.Point(53, 337);
            this.dgvUnitsItems.Name = "dgvUnitsItems";
            this.dgvUnitsItems.Size = new System.Drawing.Size(748, 150);
            this.dgvUnitsItems.TabIndex = 37;
            this.dgvUnitsItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitsItems_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.Location = new System.Drawing.Point(355, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 27);
            this.label4.TabIndex = 38;
            this.label4.Text = "وحدات المنتج";
            // 
            // btnStorageContent
            // 
            this.btnStorageContent.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnStorageContent.Location = new System.Drawing.Point(308, 514);
            this.btnStorageContent.Name = "btnStorageContent";
            this.btnStorageContent.Size = new System.Drawing.Size(243, 38);
            this.btnStorageContent.TabIndex = 39;
            this.btnStorageContent.Text = "كميات المنتج في المخازن";
            this.btnStorageContent.UseVisualStyleBackColor = true;
            this.btnStorageContent.Click += new System.EventHandler(this.btnStorageContent_Click);
            // 
            // frmShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(837, 588);
            this.Controls.Add(this.btnStorageContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvUnitsItems);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.label10);
            this.Name = "frmShowItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض معلومات المنتج";
            this.Load += new System.EventHandler(this.frmShowItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.DataGridView dgvUnitsItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStorageContent;
    }
}