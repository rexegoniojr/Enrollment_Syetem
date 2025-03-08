namespace ES_Thesis.Registrar
{
    partial class frm_CDAS
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btncd_Add = new System.Windows.Forms.Button();
            this.btncd_remove = new System.Windows.Forms.Button();
            this.txtcd_rooms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcd_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcd_days = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcd_units = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcd_sub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnat_Add = new System.Windows.Forms.Button();
            this.btnat_Remove = new System.Windows.Forms.Button();
            this.txtat_rooms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtat_time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtat_days = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtat_unit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtat_sub = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstAT = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.fb = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage1.Controls.Add(this.btncd_Add);
            this.tabPage1.Controls.Add(this.btncd_remove);
            this.tabPage1.Controls.Add(this.txtcd_rooms);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtcd_time);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtcd_days);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcd_units);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtcd_sub);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstCD);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Subject/s to be Changed/Dropped";
            // 
            // btncd_Add
            // 
            this.btncd_Add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncd_Add.Location = new System.Drawing.Point(315, 64);
            this.btncd_Add.Name = "btncd_Add";
            this.btncd_Add.Size = new System.Drawing.Size(91, 35);
            this.btncd_Add.TabIndex = 75;
            this.btncd_Add.Text = "Add";
            this.btncd_Add.UseVisualStyleBackColor = true;
            this.btncd_Add.Click += new System.EventHandler(this.btncd_Add_Click);
            // 
            // btncd_remove
            // 
            this.btncd_remove.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncd_remove.Location = new System.Drawing.Point(405, 64);
            this.btncd_remove.Name = "btncd_remove";
            this.btncd_remove.Size = new System.Drawing.Size(91, 35);
            this.btncd_remove.TabIndex = 74;
            this.btncd_remove.Text = "Remove";
            this.btncd_remove.UseVisualStyleBackColor = true;
            this.btncd_remove.Click += new System.EventHandler(this.btncd_remove_Click);
            // 
            // txtcd_rooms
            // 
            this.txtcd_rooms.Location = new System.Drawing.Point(400, 37);
            this.txtcd_rooms.Name = "txtcd_rooms";
            this.txtcd_rooms.ReadOnly = true;
            this.txtcd_rooms.Size = new System.Drawing.Size(96, 23);
            this.txtcd_rooms.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(419, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rooms";
            // 
            // txtcd_time
            // 
            this.txtcd_time.Location = new System.Drawing.Point(318, 37);
            this.txtcd_time.Name = "txtcd_time";
            this.txtcd_time.ReadOnly = true;
            this.txtcd_time.Size = new System.Drawing.Size(82, 23);
            this.txtcd_time.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(341, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time";
            // 
            // txtcd_days
            // 
            this.txtcd_days.Location = new System.Drawing.Point(233, 37);
            this.txtcd_days.Name = "txtcd_days";
            this.txtcd_days.ReadOnly = true;
            this.txtcd_days.Size = new System.Drawing.Size(85, 23);
            this.txtcd_days.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(257, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days";
            // 
            // txtcd_units
            // 
            this.txtcd_units.Location = new System.Drawing.Point(174, 37);
            this.txtcd_units.Name = "txtcd_units";
            this.txtcd_units.ReadOnly = true;
            this.txtcd_units.Size = new System.Drawing.Size(59, 23);
            this.txtcd_units.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Units";
            // 
            // txtcd_sub
            // 
            this.txtcd_sub.Location = new System.Drawing.Point(8, 37);
            this.txtcd_sub.Name = "txtcd_sub";
            this.txtcd_sub.Size = new System.Drawing.Size(166, 23);
            this.txtcd_sub.TabIndex = 2;
            this.txtcd_sub.Leave += new System.EventHandler(this.txtcd_sub_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // lstCD
            // 
            this.lstCD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstCD.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstCD.FullRowSelect = true;
            this.lstCD.GridLines = true;
            this.lstCD.Location = new System.Drawing.Point(8, 105);
            this.lstCD.Name = "lstCD";
            this.lstCD.Size = new System.Drawing.Size(488, 263);
            this.lstCD.TabIndex = 0;
            this.lstCD.UseCompatibleStateImageBehavior = false;
            this.lstCD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Units";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Days";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Room";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage2.Controls.Add(this.btnat_Add);
            this.tabPage2.Controls.Add(this.btnat_Remove);
            this.tabPage2.Controls.Add(this.txtat_rooms);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtat_time);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtat_days);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtat_unit);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtat_sub);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lstAT);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subject/s to be Added/Taken";
            // 
            // btnat_Add
            // 
            this.btnat_Add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnat_Add.Location = new System.Drawing.Point(315, 64);
            this.btnat_Add.Name = "btnat_Add";
            this.btnat_Add.Size = new System.Drawing.Size(91, 35);
            this.btnat_Add.TabIndex = 77;
            this.btnat_Add.Text = "Add";
            this.btnat_Add.UseVisualStyleBackColor = true;
            this.btnat_Add.Click += new System.EventHandler(this.btnat_Add_Click);
            // 
            // btnat_Remove
            // 
            this.btnat_Remove.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnat_Remove.Location = new System.Drawing.Point(405, 64);
            this.btnat_Remove.Name = "btnat_Remove";
            this.btnat_Remove.Size = new System.Drawing.Size(91, 35);
            this.btnat_Remove.TabIndex = 76;
            this.btnat_Remove.Text = "Remove";
            this.btnat_Remove.UseVisualStyleBackColor = true;
            this.btnat_Remove.Click += new System.EventHandler(this.btnat_Remove_Click);
            // 
            // txtat_rooms
            // 
            this.txtat_rooms.Location = new System.Drawing.Point(400, 37);
            this.txtat_rooms.Name = "txtat_rooms";
            this.txtat_rooms.ReadOnly = true;
            this.txtat_rooms.Size = new System.Drawing.Size(96, 23);
            this.txtat_rooms.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(419, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Rooms";
            // 
            // txtat_time
            // 
            this.txtat_time.Location = new System.Drawing.Point(318, 37);
            this.txtat_time.Name = "txtat_time";
            this.txtat_time.ReadOnly = true;
            this.txtat_time.Size = new System.Drawing.Size(82, 23);
            this.txtat_time.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(341, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Time";
            // 
            // txtat_days
            // 
            this.txtat_days.Location = new System.Drawing.Point(233, 37);
            this.txtat_days.Name = "txtat_days";
            this.txtat_days.ReadOnly = true;
            this.txtat_days.Size = new System.Drawing.Size(85, 23);
            this.txtat_days.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(257, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Days";
            // 
            // txtat_unit
            // 
            this.txtat_unit.Location = new System.Drawing.Point(174, 37);
            this.txtat_unit.Name = "txtat_unit";
            this.txtat_unit.ReadOnly = true;
            this.txtat_unit.Size = new System.Drawing.Size(59, 23);
            this.txtat_unit.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(185, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Units";
            // 
            // txtat_sub
            // 
            this.txtat_sub.Location = new System.Drawing.Point(8, 37);
            this.txtat_sub.Name = "txtat_sub";
            this.txtat_sub.Size = new System.Drawing.Size(166, 23);
            this.txtat_sub.TabIndex = 12;
            this.txtat_sub.Leave += new System.EventHandler(this.txtat_sub_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(58, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Subject";
            // 
            // lstAT
            // 
            this.lstAT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstAT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstAT.FullRowSelect = true;
            this.lstAT.GridLines = true;
            this.lstAT.Location = new System.Drawing.Point(8, 105);
            this.lstAT.Name = "lstAT";
            this.lstAT.Size = new System.Drawing.Size(488, 263);
            this.lstAT.TabIndex = 1;
            this.lstAT.UseCompatibleStateImageBehavior = false;
            this.lstAT.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Subject";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 164;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Units";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Days";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 85;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Time";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 82;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Room";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 82;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(417, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 53);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Export to MS Word";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frm_CDAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(512, 465);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CDAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changing, Dropping and Adding Subjects Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstCD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lstAT;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtcd_rooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcd_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcd_days;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcd_units;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcd_sub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtat_rooms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtat_time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtat_days;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtat_unit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtat_sub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncd_Add;
        private System.Windows.Forms.Button btncd_remove;
        private System.Windows.Forms.Button btnat_Add;
        private System.Windows.Forms.Button btnat_Remove;
        private System.Windows.Forms.FolderBrowserDialog fb;
    }
}