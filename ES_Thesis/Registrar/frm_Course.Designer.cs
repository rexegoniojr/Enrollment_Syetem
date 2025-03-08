namespace ES_Thesis.Registrar
{
    partial class frm_Course
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
            this.rbC_2nd = new System.Windows.Forms.RadioButton();
            this.rbC_1st = new System.Windows.Forms.RadioButton();
            this.label67 = new System.Windows.Forms.Label();
            this.cbC_Year = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtC_Course = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtC_LAB = new System.Windows.Forms.TextBox();
            this.txtC_LEC = new System.Windows.Forms.TextBox();
            this.txtC_Req = new System.Windows.Forms.TextBox();
            this.txtC_DTitle = new System.Windows.Forms.TextBox();
            this.txtC_Code = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbC_2nd
            // 
            this.rbC_2nd.AutoSize = true;
            this.rbC_2nd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbC_2nd.ForeColor = System.Drawing.Color.White;
            this.rbC_2nd.Location = new System.Drawing.Point(337, 83);
            this.rbC_2nd.Name = "rbC_2nd";
            this.rbC_2nd.Size = new System.Drawing.Size(81, 20);
            this.rbC_2nd.TabIndex = 62;
            this.rbC_2nd.TabStop = true;
            this.rbC_2nd.Text = "2nd Sem";
            this.rbC_2nd.UseVisualStyleBackColor = true;
            // 
            // rbC_1st
            // 
            this.rbC_1st.AutoSize = true;
            this.rbC_1st.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbC_1st.ForeColor = System.Drawing.Color.White;
            this.rbC_1st.Location = new System.Drawing.Point(257, 83);
            this.rbC_1st.Name = "rbC_1st";
            this.rbC_1st.Size = new System.Drawing.Size(74, 20);
            this.rbC_1st.TabIndex = 61;
            this.rbC_1st.TabStop = true;
            this.rbC_1st.Text = "1st Sem";
            this.rbC_1st.UseVisualStyleBackColor = true;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(302, 63);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(66, 16);
            this.label67.TabIndex = 77;
            this.label67.Text = "Semester";
            // 
            // cbC_Year
            // 
            this.cbC_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbC_Year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbC_Year.FormattingEnabled = true;
            this.cbC_Year.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.cbC_Year.Location = new System.Drawing.Point(160, 82);
            this.cbC_Year.Name = "cbC_Year";
            this.cbC_Year.Size = new System.Drawing.Size(91, 24);
            this.cbC_Year.TabIndex = 60;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(190, 63);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(38, 16);
            this.label52.TabIndex = 76;
            this.label52.Text = "Year";
            // 
            // txtC_Course
            // 
            this.txtC_Course.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtC_Course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtC_Course.Location = new System.Drawing.Point(63, 82);
            this.txtC_Course.Name = "txtC_Course";
            this.txtC_Course.Size = new System.Drawing.Size(91, 23);
            this.txtC_Course.TabIndex = 59;
            this.txtC_Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtC_Course.TextChanged += new System.EventHandler(this.txtC_Course_TextChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(83, 63);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(53, 16);
            this.label51.TabIndex = 75;
            this.label51.Text = "Course";
            // 
            // lstCourses
            // 
            this.lstCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.lstCourses.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstCourses.FullRowSelect = true;
            this.lstCourses.GridLines = true;
            this.lstCourses.Location = new System.Drawing.Point(17, 145);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(907, 306);
            this.lstCourses.TabIndex = 74;
            this.lstCourses.UseCompatibleStateImageBehavior = false;
            this.lstCourses.View = System.Windows.Forms.View.Details;
            this.lstCourses.Click += new System.EventHandler(this.lstCourses_Click);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ID";
            this.columnHeader16.Width = 0;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "CourseCode";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 128;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Descriptive Title";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 292;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "LEC";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "LAB";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Pre-Req";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader21.Width = 138;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Year";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader22.Width = 95;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Semester";
            this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader23.Width = 126;
            // 
            // txtC_LAB
            // 
            this.txtC_LAB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtC_LAB.Location = new System.Drawing.Point(750, 83);
            this.txtC_LAB.Name = "txtC_LAB";
            this.txtC_LAB.Size = new System.Drawing.Size(40, 23);
            this.txtC_LAB.TabIndex = 66;
            this.txtC_LAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC_LEC
            // 
            this.txtC_LEC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtC_LEC.Location = new System.Drawing.Point(702, 83);
            this.txtC_LEC.Name = "txtC_LEC";
            this.txtC_LEC.Size = new System.Drawing.Size(40, 23);
            this.txtC_LEC.TabIndex = 65;
            this.txtC_LEC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC_Req
            // 
            this.txtC_Req.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtC_Req.Location = new System.Drawing.Point(792, 83);
            this.txtC_Req.Name = "txtC_Req";
            this.txtC_Req.Size = new System.Drawing.Size(85, 23);
            this.txtC_Req.TabIndex = 67;
            this.txtC_Req.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC_DTitle
            // 
            this.txtC_DTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtC_DTitle.Location = new System.Drawing.Point(533, 83);
            this.txtC_DTitle.Name = "txtC_DTitle";
            this.txtC_DTitle.Size = new System.Drawing.Size(166, 23);
            this.txtC_DTitle.TabIndex = 64;
            this.txtC_DTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC_Code
            // 
            this.txtC_Code.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtC_Code.Location = new System.Drawing.Point(440, 83);
            this.txtC_Code.Name = "txtC_Code";
            this.txtC_Code.Size = new System.Drawing.Size(91, 23);
            this.txtC_Code.TabIndex = 63;
            this.txtC_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(754, 64);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(32, 16);
            this.label53.TabIndex = 73;
            this.label53.Text = "LAB";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(707, 64);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(31, 16);
            this.label54.TabIndex = 72;
            this.label54.Text = "LEC";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(802, 64);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(58, 16);
            this.label55.TabIndex = 71;
            this.label55.Text = "Pre-Req";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(723, 45);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(43, 16);
            this.label64.TabIndex = 70;
            this.label64.Text = "UNITS";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(567, 54);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(119, 16);
            this.label65.TabIndex = 69;
            this.label65.Text = "DESCRIPTIVE TITLE";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label66.ForeColor = System.Drawing.Color.White;
            this.label66.Location = new System.Drawing.Point(466, 54);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(45, 16);
            this.label66.TabIndex = 68;
            this.label66.Text = "CODE";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(625, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(711, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(797, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frm_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(941, 463);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbC_2nd);
            this.Controls.Add(this.rbC_1st);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.cbC_Year);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.txtC_Course);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.txtC_LAB);
            this.Controls.Add(this.txtC_LEC);
            this.Controls.Add(this.txtC_Req);
            this.Controls.Add(this.txtC_DTitle);
            this.Controls.Add(this.txtC_Code);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label66);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbC_2nd;
        private System.Windows.Forms.RadioButton rbC_1st;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.ComboBox cbC_Year;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtC_Course;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ListView lstCourses;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.TextBox txtC_LAB;
        private System.Windows.Forms.TextBox txtC_LEC;
        private System.Windows.Forms.TextBox txtC_Req;
        private System.Windows.Forms.TextBox txtC_DTitle;
        private System.Windows.Forms.TextBox txtC_Code;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}