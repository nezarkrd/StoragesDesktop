namespace Storages.Employees.Controls
{
    partial class ctrlEmployeeCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonCard1 = new People.Controls.ctrlPersonCard();
            this.gbxInfoClient = new System.Windows.Forms.GroupBox();
            this.lblStatusEmployee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserNameEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxInfoClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.DarkSalmon;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(857, 345);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // gbxInfoClient
            // 
            this.gbxInfoClient.Controls.Add(this.lblStatusEmployee);
            this.gbxInfoClient.Controls.Add(this.label2);
            this.gbxInfoClient.Controls.Add(this.lblUserNameEmployee);
            this.gbxInfoClient.Controls.Add(this.lblEmployeeID);
            this.gbxInfoClient.Controls.Add(this.label4);
            this.gbxInfoClient.Controls.Add(this.label1);
            this.gbxInfoClient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbxInfoClient.Location = new System.Drawing.Point(17, 354);
            this.gbxInfoClient.Name = "gbxInfoClient";
            this.gbxInfoClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxInfoClient.Size = new System.Drawing.Size(834, 114);
            this.gbxInfoClient.TabIndex = 3;
            this.gbxInfoClient.TabStop = false;
            this.gbxInfoClient.Text = "معلومات الموظف";
            // 
            // lblStatusEmployee
            // 
            this.lblStatusEmployee.AutoSize = true;
            this.lblStatusEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEmployee.Location = new System.Drawing.Point(114, 40);
            this.lblStatusEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusEmployee.Name = "lblStatusEmployee";
            this.lblStatusEmployee.Size = new System.Drawing.Size(39, 20);
            this.lblStatusEmployee.TabIndex = 152;
            this.lblStatusEmployee.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "الحالة:";
            // 
            // lblUserNameEmployee
            // 
            this.lblUserNameEmployee.AutoSize = true;
            this.lblUserNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameEmployee.Location = new System.Drawing.Point(373, 40);
            this.lblUserNameEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserNameEmployee.Name = "lblUserNameEmployee";
            this.lblUserNameEmployee.Size = new System.Drawing.Size(39, 20);
            this.lblUserNameEmployee.TabIndex = 150;
            this.lblUserNameEmployee.Text = "???";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(650, 40);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(39, 20);
            this.lblEmployeeID.TabIndex = 149;
            this.lblEmployeeID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "رقم الموظف:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 147;
            this.label1.Text = "اسم المستخدم:";
            // 
            // ctrlEmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.gbxInfoClient);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlEmployeeCard";
            this.Size = new System.Drawing.Size(867, 496);
            this.Load += new System.EventHandler(this.ctrlEmployeeCard_Load);
            this.gbxInfoClient.ResumeLayout(false);
            this.gbxInfoClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbxInfoClient;
        private System.Windows.Forms.Label lblStatusEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserNameEmployee;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
