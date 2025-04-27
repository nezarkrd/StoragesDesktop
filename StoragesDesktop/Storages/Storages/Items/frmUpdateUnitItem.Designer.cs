namespace Storages.Items
{
    partial class frmUpdateUnitItem
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
            this.btnAddUnitItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemUnitSellPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemUnitBuyPrice = new System.Windows.Forms.TextBox();
            this.btnUnit = new System.Windows.Forms.Button();
            this.cbxUnits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUnitItem
            // 
            this.btnAddUnitItem.Location = new System.Drawing.Point(271, 252);
            this.btnAddUnitItem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddUnitItem.Name = "btnAddUnitItem";
            this.btnAddUnitItem.Size = new System.Drawing.Size(156, 47);
            this.btnAddUnitItem.TabIndex = 21;
            this.btnAddUnitItem.Text = "تعديل";
            this.btnAddUnitItem.UseVisualStyleBackColor = true;
            this.btnAddUnitItem.Click += new System.EventHandler(this.btnAddUnitItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "اضافة سعر شراء الوحدة للمنتج";
            // 
            // txtItemUnitSellPrice
            // 
            this.txtItemUnitSellPrice.Location = new System.Drawing.Point(325, 188);
            this.txtItemUnitSellPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemUnitSellPrice.Name = "txtItemUnitSellPrice";
            this.txtItemUnitSellPrice.Size = new System.Drawing.Size(272, 30);
            this.txtItemUnitSellPrice.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "اضافة سعر بيع الوحدة للمنتج";
            // 
            // txtItemUnitBuyPrice
            // 
            this.txtItemUnitBuyPrice.Location = new System.Drawing.Point(325, 127);
            this.txtItemUnitBuyPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemUnitBuyPrice.Name = "txtItemUnitBuyPrice";
            this.txtItemUnitBuyPrice.Size = new System.Drawing.Size(272, 30);
            this.txtItemUnitBuyPrice.TabIndex = 17;
            // 
            // btnUnit
            // 
            this.btnUnit.Location = new System.Drawing.Point(503, 46);
            this.btnUnit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(173, 31);
            this.btnUnit.TabIndex = 16;
            this.btnUnit.Text = "اضافة وحدة جديدة";
            this.btnUnit.UseVisualStyleBackColor = true;
            // 
            // cbxUnits
            // 
            this.cbxUnits.FormattingEnabled = true;
            this.cbxUnits.Location = new System.Drawing.Point(175, 46);
            this.cbxUnits.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxUnits.Name = "cbxUnits";
            this.cbxUnits.Size = new System.Drawing.Size(272, 31);
            this.cbxUnits.TabIndex = 15;
            this.cbxUnits.Text = "اختر الوحدة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "اختر الوحدة";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateUnitItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(703, 325);
            this.Controls.Add(this.btnAddUnitItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemUnitSellPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemUnitBuyPrice);
            this.Controls.Add(this.btnUnit);
            this.Controls.Add(this.cbxUnits);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmUpdateUnitItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل وحدة/منتج";
            this.Load += new System.EventHandler(this.frmUpdateUnitItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUnitItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemUnitSellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemUnitBuyPrice;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.ComboBox cbxUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}