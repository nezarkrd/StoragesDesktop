namespace Storages
{
    partial class frmAddUpdateItem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapItemDetails = new System.Windows.Forms.TabPage();
            this.btnSaveItem1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemInfo = new System.Windows.Forms.TextBox();
            this.cbxItemCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.tapUnitesPrices = new System.Windows.Forms.TabPage();
            this.btnAddUnitItem = new System.Windows.Forms.Button();
            this.dgvUnitsItems = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemUnitSellPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemUnitBuyPrice = new System.Windows.Forms.TextBox();
            this.btnUnit = new System.Windows.Forms.Button();
            this.cbxUnits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmsUnitsItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tapItemDetails.SuspendLayout();
            this.tapUnitesPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.cmsUnitsItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapItemDetails);
            this.tabControl1.Controls.Add(this.tapUnitesPrices);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tapItemDetails
            // 
            this.tapItemDetails.BackColor = System.Drawing.Color.DarkSalmon;
            this.tapItemDetails.Controls.Add(this.btnSaveItem1);
            this.tapItemDetails.Controls.Add(this.lblTitle);
            this.tapItemDetails.Controls.Add(this.lblItemID);
            this.tapItemDetails.Controls.Add(this.label10);
            this.tapItemDetails.Controls.Add(this.btnNext);
            this.tapItemDetails.Controls.Add(this.label3);
            this.tapItemDetails.Controls.Add(this.txtItemInfo);
            this.tapItemDetails.Controls.Add(this.cbxItemCategory);
            this.tapItemDetails.Controls.Add(this.label2);
            this.tapItemDetails.Controls.Add(this.label1);
            this.tapItemDetails.Controls.Add(this.txtItemName);
            this.tapItemDetails.Location = new System.Drawing.Point(4, 32);
            this.tapItemDetails.Name = "tapItemDetails";
            this.tapItemDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tapItemDetails.Size = new System.Drawing.Size(835, 423);
            this.tapItemDetails.TabIndex = 0;
            this.tapItemDetails.Text = "نفاصيل المنتج";
            this.tapItemDetails.Click += new System.EventHandler(this.tapItemDetails_Click);
            // 
            // btnSaveItem1
            // 
            this.btnSaveItem1.Location = new System.Drawing.Point(578, 365);
            this.btnSaveItem1.Name = "btnSaveItem1";
            this.btnSaveItem1.Size = new System.Drawing.Size(81, 33);
            this.btnSaveItem1.TabIndex = 30;
            this.btnSaveItem1.Text = "حفظ";
            this.btnSaveItem1.UseVisualStyleBackColor = true;
            this.btnSaveItem1.Click += new System.EventHandler(this.btnSaveItem1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(317, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 33);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "اضافة منتج جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblItemID.ForeColor = System.Drawing.Color.Red;
            this.lblItemID.Location = new System.Drawing.Point(576, 116);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(52, 27);
            this.lblItemID.TabIndex = 28;
            this.lblItemID.Text = "؟؟؟؟";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.Location = new System.Drawing.Point(668, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 27);
            this.label10.TabIndex = 27;
            this.label10.Text = "رقم المنتج :";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(702, 364);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 34);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "التالي";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "معلومات عن المنتج";
            // 
            // txtItemInfo
            // 
            this.txtItemInfo.Location = new System.Drawing.Point(78, 166);
            this.txtItemInfo.Multiline = true;
            this.txtItemInfo.Name = "txtItemInfo";
            this.txtItemInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtItemInfo.Size = new System.Drawing.Size(250, 167);
            this.txtItemInfo.TabIndex = 4;
            this.txtItemInfo.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // cbxItemCategory
            // 
            this.cbxItemCategory.FormattingEnabled = true;
            this.cbxItemCategory.Location = new System.Drawing.Point(494, 291);
            this.cbxItemCategory.Name = "cbxItemCategory";
            this.cbxItemCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxItemCategory.Size = new System.Drawing.Size(165, 31);
            this.cbxItemCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "اختيار الصنف:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المنتج :";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(494, 200);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtItemName.Size = new System.Drawing.Size(165, 30);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tapUnitesPrices
            // 
            this.tapUnitesPrices.BackColor = System.Drawing.Color.DarkSalmon;
            this.tapUnitesPrices.Controls.Add(this.btnAddUnitItem);
            this.tapUnitesPrices.Controls.Add(this.dgvUnitsItems);
            this.tapUnitesPrices.Controls.Add(this.label6);
            this.tapUnitesPrices.Controls.Add(this.txtItemUnitSellPrice);
            this.tapUnitesPrices.Controls.Add(this.label5);
            this.tapUnitesPrices.Controls.Add(this.txtItemUnitBuyPrice);
            this.tapUnitesPrices.Controls.Add(this.btnUnit);
            this.tapUnitesPrices.Controls.Add(this.cbxUnits);
            this.tapUnitesPrices.Controls.Add(this.label4);
            this.tapUnitesPrices.Location = new System.Drawing.Point(4, 32);
            this.tapUnitesPrices.Name = "tapUnitesPrices";
            this.tapUnitesPrices.Size = new System.Drawing.Size(835, 423);
            this.tapUnitesPrices.TabIndex = 1;
            this.tapUnitesPrices.Text = "الوحدات والاسعار";
            // 
            // btnAddUnitItem
            // 
            this.btnAddUnitItem.Location = new System.Drawing.Point(317, 201);
            this.btnAddUnitItem.Name = "btnAddUnitItem";
            this.btnAddUnitItem.Size = new System.Drawing.Size(186, 35);
            this.btnAddUnitItem.TabIndex = 13;
            this.btnAddUnitItem.Text = "اضافة الوحدة للمنتج";
            this.btnAddUnitItem.UseVisualStyleBackColor = true;
            this.btnAddUnitItem.Click += new System.EventHandler(this.btnAddUnitItem_Click);
            // 
            // dgvUnitsItems
            // 
            this.dgvUnitsItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnitsItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitsItems.ContextMenuStrip = this.cmsUnitsItem;
            this.dgvUnitsItems.Location = new System.Drawing.Point(39, 254);
            this.dgvUnitsItems.Name = "dgvUnitsItems";
            this.dgvUnitsItems.Size = new System.Drawing.Size(765, 150);
            this.dgvUnitsItems.TabIndex = 12;
            this.dgvUnitsItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitsItems_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "اضافة سعر شراء الوحدة للمنتج";
            // 
            // txtItemUnitSellPrice
            // 
            this.txtItemUnitSellPrice.Location = new System.Drawing.Point(187, 152);
            this.txtItemUnitSellPrice.Name = "txtItemUnitSellPrice";
            this.txtItemUnitSellPrice.Size = new System.Drawing.Size(165, 30);
            this.txtItemUnitSellPrice.TabIndex = 10;
            this.txtItemUnitSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfContent_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "اضافة سعر بيع الوحدة للمنتج";
            // 
            // txtItemUnitBuyPrice
            // 
            this.txtItemUnitBuyPrice.Location = new System.Drawing.Point(187, 93);
            this.txtItemUnitBuyPrice.Name = "txtItemUnitBuyPrice";
            this.txtItemUnitBuyPrice.Size = new System.Drawing.Size(165, 30);
            this.txtItemUnitBuyPrice.TabIndex = 8;
            this.txtItemUnitBuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfContent_KeyPress);
            // 
            // btnUnit
            // 
            this.btnUnit.Location = new System.Drawing.Point(187, 35);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(125, 34);
            this.btnUnit.TabIndex = 7;
            this.btnUnit.Text = "اضافة وحدة جديدة";
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // cbxUnits
            // 
            this.cbxUnits.FormattingEnabled = true;
            this.cbxUnits.Location = new System.Drawing.Point(352, 35);
            this.cbxUnits.Name = "cbxUnits";
            this.cbxUnits.Size = new System.Drawing.Size(165, 31);
            this.cbxUnits.TabIndex = 5;
            this.cbxUnits.Text = "اختر الوحدة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "اختر الوحدة";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(773, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "اغلاق";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmsUnitsItem
            // 
            this.cmsUnitsItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.cmsUnitsItem.Name = "cmsUnitsItem";
            this.cmsUnitsItem.Size = new System.Drawing.Size(104, 48);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // frmAddUpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(867, 523);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddUpdateItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/تعديل منتج";
            this.Load += new System.EventHandler(this.frmAddUpdateItem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tapItemDetails.ResumeLayout(false);
            this.tapItemDetails.PerformLayout();
            this.tapUnitesPrices.ResumeLayout(false);
            this.tapUnitesPrices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.cmsUnitsItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapItemDetails;
        private System.Windows.Forms.TabPage tapUnitesPrices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemInfo;
        private System.Windows.Forms.ComboBox cbxItemCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.ComboBox cbxUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemUnitSellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemUnitBuyPrice;
        private System.Windows.Forms.DataGridView dgvUnitsItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddUnitItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSaveItem1;
        private System.Windows.Forms.ContextMenuStrip cmsUnitsItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}