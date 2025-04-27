namespace Storages
{
    partial class frmAddUpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateCategory));
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCateograyDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCateograyDescription
            // 
            resources.ApplyResources(this.txtCateograyDescription, "txtCateograyDescription");
            this.errorProvider1.SetError(this.txtCateograyDescription, resources.GetString("txtCateograyDescription.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCateograyDescription, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCateograyDescription.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCateograyDescription, ((int)(resources.GetObject("txtCateograyDescription.IconPadding"))));
            this.txtCateograyDescription.Name = "txtCateograyDescription";
            this.txtCateograyDescription.TextChanged += new System.EventHandler(this.txtCateograyDescription_TextChanged);
            this.txtCateograyDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCategoryName
            // 
            resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
            this.errorProvider1.SetError(this.txtCategoryName, resources.GetString("txtCategoryName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCategoryName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCategoryName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCategoryName, ((int)(resources.GetObject("txtCategoryName.IconPadding"))));
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            this.txtCategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.errorProvider1.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.errorProvider1.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.lblTitle.Name = "lblTitle";
            // 
            // lblCategoryID
            // 
            resources.ApplyResources(this.lblCategoryID, "lblCategoryID");
            this.errorProvider1.SetError(this.lblCategoryID, resources.GetString("lblCategoryID.Error"));
            this.lblCategoryID.ForeColor = System.Drawing.Color.Red;
            this.errorProvider1.SetIconAlignment(this.lblCategoryID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCategoryID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblCategoryID, ((int)(resources.GetObject("lblCategoryID.IconPadding"))));
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Click += new System.EventHandler(this.lblCategoryID_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmAddUpdateCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCateograyDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.label10);
            this.Name = "frmAddUpdateCategory";
            this.Load += new System.EventHandler(this.frmAddUpdateCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCateograyDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}