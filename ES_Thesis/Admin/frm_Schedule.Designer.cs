namespace ES_Thesis.Admin
{
    partial class frm_Schedule
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
            this.cbSch_Year = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.txtSch_Course = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.rbSch_2ndSem = new System.Windows.Forms.RadioButton();
            this.rbSch_1stSem = new System.Windows.Forms.RadioButton();
            this.label80 = new System.Windows.Forms.Label();
            this.txtSch_Year = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.lstSch_Schedule = new System.Windows.Forms.ListView();
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSch_Lab = new System.Windows.Forms.TextBox();
            this.txtSch_Lec = new System.Windows.Forms.TextBox();
            this.txtSch_Day = new System.Windows.Forms.TextBox();
            this.txtSch_Time = new System.Windows.Forms.TextBox();
            this.txtSch_Room = new System.Windows.Forms.TextBox();
            this.txtSch_Title = new System.Windows.Forms.TextBox();
            this.txtSch_Code = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.tbnSch_Add = new System.Windows.Forms.Button();
            this.btnSch_Update = new System.Windows.Forms.Button();
            this.btnSch_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSch_Year
            // 
            this.cbSch_Year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbSch_Year.Location = new System.Drawing.Point(125, 129);
            this.cbSch_Year.Name = "cbSch_Year";
            this.cbSch_Year.ReadOnly = true;
            this.cbSch_Year.Size = new System.Drawing.Size(91, 23);
            this.cbSch_Year.TabIndex = 114;
            this.cbSch_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label81.ForeColor = System.Drawing.Color.White;
            this.label81.Location = new System.Drawing.Point(155, 109);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(38, 16);
            this.label81.TabIndex = 113;
            this.label81.Text = "Year";
            // 
            // txtSch_Course
            // 
            this.txtSch_Course.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSch_Course.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Course.Location = new System.Drawing.Point(125, 81);
            this.txtSch_Course.Name = "txtSch_Course";
            this.txtSch_Course.Size = new System.Drawing.Size(91, 23);
            this.txtSch_Course.TabIndex = 111;
            this.txtSch_Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(142, 52);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(53, 16);
            this.label82.TabIndex = 112;
            this.label82.Text = "Course";
            // 
            // rbSch_2ndSem
            // 
            this.rbSch_2ndSem.AutoSize = true;
            this.rbSch_2ndSem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbSch_2ndSem.ForeColor = System.Drawing.Color.White;
            this.rbSch_2ndSem.Location = new System.Drawing.Point(436, 132);
            this.rbSch_2ndSem.Name = "rbSch_2ndSem";
            this.rbSch_2ndSem.Size = new System.Drawing.Size(81, 20);
            this.rbSch_2ndSem.TabIndex = 110;
            this.rbSch_2ndSem.TabStop = true;
            this.rbSch_2ndSem.Text = "2nd Sem";
            this.rbSch_2ndSem.UseVisualStyleBackColor = true;
            this.rbSch_2ndSem.CheckedChanged += new System.EventHandler(this.rbSch_1stSem_CheckedChanged);
            // 
            // rbSch_1stSem
            // 
            this.rbSch_1stSem.AutoSize = true;
            this.rbSch_1stSem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbSch_1stSem.ForeColor = System.Drawing.Color.White;
            this.rbSch_1stSem.Location = new System.Drawing.Point(356, 132);
            this.rbSch_1stSem.Name = "rbSch_1stSem";
            this.rbSch_1stSem.Size = new System.Drawing.Size(74, 20);
            this.rbSch_1stSem.TabIndex = 109;
            this.rbSch_1stSem.TabStop = true;
            this.rbSch_1stSem.Text = "1st Sem";
            this.rbSch_1stSem.UseVisualStyleBackColor = true;
            this.rbSch_1stSem.CheckedChanged += new System.EventHandler(this.rbSch_1stSem_CheckedChanged);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(403, 110);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(66, 16);
            this.label80.TabIndex = 108;
            this.label80.Text = "Semester";
            // 
            // txtSch_Year
            // 
            this.txtSch_Year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Year.Location = new System.Drawing.Point(219, 129);
            this.txtSch_Year.Name = "txtSch_Year";
            this.txtSch_Year.Size = new System.Drawing.Size(114, 23);
            this.txtSch_Year.TabIndex = 106;
            this.txtSch_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(222, 110);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(110, 16);
            this.label79.TabIndex = 107;
            this.label79.Text = "Academic Year";
            // 
            // lstSch_Schedule
            // 
            this.lstSch_Schedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32});
            this.lstSch_Schedule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstSch_Schedule.FullRowSelect = true;
            this.lstSch_Schedule.GridLines = true;
            this.lstSch_Schedule.Location = new System.Drawing.Point(12, 158);
            this.lstSch_Schedule.Name = "lstSch_Schedule";
            this.lstSch_Schedule.Size = new System.Drawing.Size(917, 262);
            this.lstSch_Schedule.TabIndex = 105;
            this.lstSch_Schedule.UseCompatibleStateImageBehavior = false;
            this.lstSch_Schedule.View = System.Windows.Forms.View.Details;
            this.lstSch_Schedule.Click += new System.EventHandler(this.lstSch_Schedule_Click);
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "ID";
            this.columnHeader24.Width = 0;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "CODE";
            this.columnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader25.Width = 91;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "DESCRIPTIVE TITLE";
            this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader26.Width = 302;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "LEC";
            this.columnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "LAB";
            this.columnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "DAY";
            this.columnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader29.Width = 120;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "TIME";
            this.columnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader30.Width = 106;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "ROOM";
            this.columnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader31.Width = 85;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Year";
            this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader32.Width = 88;
            // 
            // txtSch_Lab
            // 
            this.txtSch_Lab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Lab.Location = new System.Drawing.Point(529, 81);
            this.txtSch_Lab.Name = "txtSch_Lab";
            this.txtSch_Lab.ReadOnly = true;
            this.txtSch_Lab.Size = new System.Drawing.Size(40, 23);
            this.txtSch_Lab.TabIndex = 93;
            this.txtSch_Lab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSch_Lec
            // 
            this.txtSch_Lec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Lec.Location = new System.Drawing.Point(481, 81);
            this.txtSch_Lec.Name = "txtSch_Lec";
            this.txtSch_Lec.ReadOnly = true;
            this.txtSch_Lec.Size = new System.Drawing.Size(40, 23);
            this.txtSch_Lec.TabIndex = 92;
            this.txtSch_Lec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSch_Day
            // 
            this.txtSch_Day.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSch_Day.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Day.Location = new System.Drawing.Point(571, 81);
            this.txtSch_Day.Name = "txtSch_Day";
            this.txtSch_Day.Size = new System.Drawing.Size(85, 23);
            this.txtSch_Day.TabIndex = 94;
            this.txtSch_Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSch_Time
            // 
            this.txtSch_Time.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Time.Location = new System.Drawing.Point(659, 81);
            this.txtSch_Time.Name = "txtSch_Time";
            this.txtSch_Time.Size = new System.Drawing.Size(85, 23);
            this.txtSch_Time.TabIndex = 95;
            this.txtSch_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSch_Room
            // 
            this.txtSch_Room.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Room.Location = new System.Drawing.Point(746, 81);
            this.txtSch_Room.Name = "txtSch_Room";
            this.txtSch_Room.Size = new System.Drawing.Size(85, 23);
            this.txtSch_Room.TabIndex = 96;
            this.txtSch_Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSch_Title
            // 
            this.txtSch_Title.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Title.Location = new System.Drawing.Point(312, 81);
            this.txtSch_Title.Name = "txtSch_Title";
            this.txtSch_Title.ReadOnly = true;
            this.txtSch_Title.Size = new System.Drawing.Size(166, 23);
            this.txtSch_Title.TabIndex = 91;
            this.txtSch_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSch_Code
            // 
            this.txtSch_Code.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSch_Code.Location = new System.Drawing.Point(219, 81);
            this.txtSch_Code.Name = "txtSch_Code";
            this.txtSch_Code.Size = new System.Drawing.Size(91, 23);
            this.txtSch_Code.TabIndex = 90;
            this.txtSch_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSch_Code.Leave += new System.EventHandler(this.txtSch_Code_Leave);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(533, 62);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(32, 16);
            this.label71.TabIndex = 104;
            this.label71.Text = "LAB";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(486, 62);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(31, 16);
            this.label72.TabIndex = 103;
            this.label72.Text = "LEC";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(764, 62);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(50, 16);
            this.label73.TabIndex = 102;
            this.label73.Text = "ROOM";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(683, 62);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(37, 16);
            this.label74.TabIndex = 101;
            this.label74.Text = "TIME";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(597, 62);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(35, 16);
            this.label75.TabIndex = 100;
            this.label75.Text = "DAY";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(502, 43);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(43, 16);
            this.label76.TabIndex = 99;
            this.label76.Text = "UNITS";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(346, 52);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(119, 16);
            this.label77.TabIndex = 98;
            this.label77.Text = "DESCRIPTIVE TITLE";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(246, 52);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(45, 16);
            this.label78.TabIndex = 97;
            this.label78.Text = "CODE";
            // 
            // tbnSch_Add
            // 
            this.tbnSch_Add.ForeColor = System.Drawing.Color.Black;
            this.tbnSch_Add.Location = new System.Drawing.Point(579, 110);
            this.tbnSch_Add.Name = "tbnSch_Add";
            this.tbnSch_Add.Size = new System.Drawing.Size(80, 42);
            this.tbnSch_Add.TabIndex = 115;
            this.tbnSch_Add.Text = "Add";
            this.tbnSch_Add.UseVisualStyleBackColor = true;
            this.tbnSch_Add.Click += new System.EventHandler(this.tbnSch_Add_Click);
            // 
            // btnSch_Update
            // 
            this.btnSch_Update.ForeColor = System.Drawing.Color.Black;
            this.btnSch_Update.Location = new System.Drawing.Point(665, 110);
            this.btnSch_Update.Name = "btnSch_Update";
            this.btnSch_Update.Size = new System.Drawing.Size(80, 42);
            this.btnSch_Update.TabIndex = 116;
            this.btnSch_Update.Text = "Update";
            this.btnSch_Update.UseVisualStyleBackColor = true;
            this.btnSch_Update.Click += new System.EventHandler(this.btnSch_Update_Click);
            // 
            // btnSch_Delete
            // 
            this.btnSch_Delete.ForeColor = System.Drawing.Color.Black;
            this.btnSch_Delete.Location = new System.Drawing.Point(751, 110);
            this.btnSch_Delete.Name = "btnSch_Delete";
            this.btnSch_Delete.Size = new System.Drawing.Size(80, 42);
            this.btnSch_Delete.TabIndex = 117;
            this.btnSch_Delete.Text = "Delete";
            this.btnSch_Delete.UseVisualStyleBackColor = true;
            this.btnSch_Delete.Click += new System.EventHandler(this.btnSch_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 118;
            this.label1.Text = "click data to update/delete";
            // 
            // frm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(941, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSch_Delete);
            this.Controls.Add(this.btnSch_Update);
            this.Controls.Add(this.tbnSch_Add);
            this.Controls.Add(this.cbSch_Year);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.txtSch_Course);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.rbSch_2ndSem);
            this.Controls.Add(this.rbSch_1stSem);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.txtSch_Year);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.lstSch_Schedule);
            this.Controls.Add(this.txtSch_Lab);
            this.Controls.Add(this.txtSch_Lec);
            this.Controls.Add(this.txtSch_Day);
            this.Controls.Add(this.txtSch_Time);
            this.Controls.Add(this.txtSch_Room);
            this.Controls.Add(this.txtSch_Title);
            this.Controls.Add(this.txtSch_Code);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label78);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Schedule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cbSch_Year;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox txtSch_Course;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.RadioButton rbSch_2ndSem;
        private System.Windows.Forms.RadioButton rbSch_1stSem;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox txtSch_Year;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.ListView lstSch_Schedule;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.TextBox txtSch_Lab;
        private System.Windows.Forms.TextBox txtSch_Lec;
        private System.Windows.Forms.TextBox txtSch_Day;
        private System.Windows.Forms.TextBox txtSch_Time;
        private System.Windows.Forms.TextBox txtSch_Room;
        private System.Windows.Forms.TextBox txtSch_Title;
        private System.Windows.Forms.TextBox txtSch_Code;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Button tbnSch_Add;
        private System.Windows.Forms.Button btnSch_Update;
        private System.Windows.Forms.Button btnSch_Delete;
        private System.Windows.Forms.Label label1;
    }
}