namespace Storages.People
{
    partial class frmFindPersoncs
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
            this.ctrlPersonCardWithFilter11 = new People.Controls.ctrlPersonCardWithFilter1();
            this.SuspendLayout();
            // 
            // ctrlPersonCardWithFilter11
            // 
            this.ctrlPersonCardWithFilter11.BackColor = System.Drawing.Color.DarkSalmon;
            this.ctrlPersonCardWithFilter11.FilterEnabled = true;
            this.ctrlPersonCardWithFilter11.Location = new System.Drawing.Point(5, 16);
            this.ctrlPersonCardWithFilter11.Name = "ctrlPersonCardWithFilter11";
            this.ctrlPersonCardWithFilter11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlPersonCardWithFilter11.Size = new System.Drawing.Size(873, 474);
            this.ctrlPersonCardWithFilter11.TabIndex = 0;
            // 
            // frmFindPersoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(890, 502);
            this.Controls.Add(this.ctrlPersonCardWithFilter11);
            this.Name = "frmFindPersoncs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث عن شخص";
            this.Load += new System.EventHandler(this.frmFindPersoncs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlPersonCardWithFilter1 ctrlPersonCardWithFilter11;
    }
}