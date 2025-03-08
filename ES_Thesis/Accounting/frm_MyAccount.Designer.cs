namespace ES_Thesis.Accounting
{
    partial class frm_MyAccount
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
            this.lblChecker = new System.Windows.Forms.Label();
            this.btnSave_acc = new System.Windows.Forms.Button();
            this.txtAcc_oldPass = new System.Windows.Forms.TextBox();
            this.txtAcc_conPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAcc_newPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.BackColor = System.Drawing.Color.Transparent;
            this.lblChecker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecker.ForeColor = System.Drawing.Color.Black;
            this.lblChecker.Location = new System.Drawing.Point(207, 173);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(31, 17);
            this.lblChecker.TabIndex = 116;
            this.lblChecker.Text = "Test";
            this.lblChecker.Visible = false;
            // 
            // btnSave_acc
            // 
            this.btnSave_acc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave_acc.Location = new System.Drawing.Point(345, 198);
            this.btnSave_acc.Name = "btnSave_acc";
            this.btnSave_acc.Size = new System.Drawing.Size(121, 43);
            this.btnSave_acc.TabIndex = 115;
            this.btnSave_acc.Text = "Save";
            this.btnSave_acc.UseVisualStyleBackColor = true;
            this.btnSave_acc.Click += new System.EventHandler(this.btnSave_acc_Click);
            // 
            // txtAcc_oldPass
            // 
            this.txtAcc_oldPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAcc_oldPass.Location = new System.Drawing.Point(210, 89);
            this.txtAcc_oldPass.Name = "txtAcc_oldPass";
            this.txtAcc_oldPass.Size = new System.Drawing.Size(256, 23);
            this.txtAcc_oldPass.TabIndex = 112;
            this.txtAcc_oldPass.UseSystemPasswordChar = true;
            // 
            // txtAcc_conPass
            // 
            this.txtAcc_conPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAcc_conPass.Location = new System.Drawing.Point(210, 147);
            this.txtAcc_conPass.Name = "txtAcc_conPass";
            this.txtAcc_conPass.Size = new System.Drawing.Size(256, 23);
            this.txtAcc_conPass.TabIndex = 114;
            this.txtAcc_conPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 109;
            this.label6.Text = "Old Password:";
            // 
            // txtAcc_newPass
            // 
            this.txtAcc_newPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAcc_newPass.Location = new System.Drawing.Point(210, 118);
            this.txtAcc_newPass.Name = "txtAcc_newPass";
            this.txtAcc_newPass.Size = new System.Drawing.Size(256, 23);
            this.txtAcc_newPass.TabIndex = 113;
            this.txtAcc_newPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 110;
            this.label7.Text = "New Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(63, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 18);
            this.label8.TabIndex = 111;
            this.label8.Text = "Confirm Password:";
            // 
            // frm_MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(529, 331);
            this.Controls.Add(this.lblChecker);
            this.Controls.Add(this.btnSave_acc);
            this.Controls.Add(this.txtAcc_oldPass);
            this.Controls.Add(this.txtAcc_conPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAcc_newPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MyAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChecker;
        private System.Windows.Forms.Button btnSave_acc;
        private System.Windows.Forms.TextBox txtAcc_oldPass;
        private System.Windows.Forms.TextBox txtAcc_conPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAcc_newPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}