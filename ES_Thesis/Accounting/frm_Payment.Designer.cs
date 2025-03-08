namespace ES_Thesis.Accounting
{
    partial class frm_Payment
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
            this.lst_subject_input = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTAA = new System.Windows.Forms.TextBox();
            this.txtLess = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNSTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.lstPayment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSub_amount = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblsem = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSy = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnHB = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.fb = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lst_subject_input
            // 
            this.lst_subject_input.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader16});
            this.lst_subject_input.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lst_subject_input.FullRowSelect = true;
            this.lst_subject_input.GridLines = true;
            this.lst_subject_input.Location = new System.Drawing.Point(18, 83);
            this.lst_subject_input.Name = "lst_subject_input";
            this.lst_subject_input.Size = new System.Drawing.Size(516, 169);
            this.lst_subject_input.TabIndex = 56;
            this.lst_subject_input.UseCompatibleStateImageBehavior = false;
            this.lst_subject_input.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CODE";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DESCRIPTIVE TITLE";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 276;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "LEC";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "LAB";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DAY";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TIME";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 106;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ROOM";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 122;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(256, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 16);
            this.label11.TabIndex = 76;
            this.label11.Text = "Total Assessed Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(256, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "Less:";
            // 
            // txtTAA
            // 
            this.txtTAA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAA.Location = new System.Drawing.Point(422, 374);
            this.txtTAA.Name = "txtTAA";
            this.txtTAA.ReadOnly = true;
            this.txtTAA.Size = new System.Drawing.Size(114, 23);
            this.txtTAA.TabIndex = 74;
            this.txtTAA.Text = "0";
            this.txtTAA.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // txtLess
            // 
            this.txtLess.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLess.Location = new System.Drawing.Point(422, 345);
            this.txtLess.Name = "txtLess";
            this.txtLess.Size = new System.Drawing.Size(114, 23);
            this.txtLess.TabIndex = 67;
            this.txtLess.Text = "0";
            this.txtLess.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(256, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "Total Assessment:";
            // 
            // txtTA
            // 
            this.txtTA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTA.Location = new System.Drawing.Point(422, 316);
            this.txtTA.Name = "txtTA";
            this.txtTA.ReadOnly = true;
            this.txtTA.Size = new System.Drawing.Size(114, 23);
            this.txtTA.TabIndex = 68;
            this.txtTA.Text = "0";
            this.txtTA.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "Others:";
            // 
            // txtOthers
            // 
            this.txtOthers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOthers.Location = new System.Drawing.Point(136, 346);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(114, 23);
            this.txtOthers.TabIndex = 61;
            this.txtOthers.Text = "0";
            this.txtOthers.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(256, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Labosatory:";
            // 
            // txtLab
            // 
            this.txtLab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab.Location = new System.Drawing.Point(422, 287);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(114, 23);
            this.txtLab.TabIndex = 66;
            this.txtLab.Text = "0";
            this.txtLab.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "PE:";
            // 
            // txtPE
            // 
            this.txtPE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPE.Location = new System.Drawing.Point(136, 316);
            this.txtPE.Name = "txtPE";
            this.txtPE.Size = new System.Drawing.Size(114, 23);
            this.txtPE.TabIndex = 60;
            this.txtPE.Text = "0";
            this.txtPE.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(256, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "NSTP:";
            // 
            // txtNSTP
            // 
            this.txtNSTP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSTP.Location = new System.Drawing.Point(422, 258);
            this.txtNSTP.Name = "txtNSTP";
            this.txtNSTP.Size = new System.Drawing.Size(114, 23);
            this.txtNSTP.TabIndex = 64;
            this.txtNSTP.Text = "0";
            this.txtNSTP.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Miscellaneous:";
            // 
            // txtMis
            // 
            this.txtMis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMis.Location = new System.Drawing.Point(136, 287);
            this.txtMis.Name = "txtMis";
            this.txtMis.Size = new System.Drawing.Size(114, 23);
            this.txtMis.TabIndex = 58;
            this.txtMis.Text = "0";
            this.txtMis.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tuition:";
            // 
            // txtTui
            // 
            this.txtTui.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTui.Location = new System.Drawing.Point(136, 375);
            this.txtTui.Name = "txtTui";
            this.txtTui.Size = new System.Drawing.Size(114, 23);
            this.txtTui.TabIndex = 62;
            this.txtTui.Text = "0";
            this.txtTui.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Registration:";
            // 
            // txtReg
            // 
            this.txtReg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReg.Location = new System.Drawing.Point(136, 258);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(114, 23);
            this.txtReg.TabIndex = 57;
            this.txtReg.Text = "0";
            this.txtReg.Leave += new System.EventHandler(this.txtReg_Leave);
            // 
            // lstPayment
            // 
            this.lstPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader10});
            this.lstPayment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstPayment.FullRowSelect = true;
            this.lstPayment.GridLines = true;
            this.lstPayment.Location = new System.Drawing.Point(20, 481);
            this.lstPayment.Name = "lstPayment";
            this.lstPayment.Size = new System.Drawing.Size(516, 215);
            this.lstPayment.TabIndex = 77;
            this.lstPayment.UseCompatibleStateImageBehavior = false;
            this.lstPayment.View = System.Windows.Forms.View.Details;
            this.lstPayment.Click += new System.EventHandler(this.lstPayment_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 267;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(100, 444);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(316, 26);
            this.txtBalance.TabIndex = 78;
            this.txtBalance.Text = "0";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(422, 403);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 35);
            this.btnSubmit.TabIndex = 80;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(18, 712);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 82;
            this.label12.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(93, 709);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(245, 26);
            this.txtAmount.TabIndex = 81;
            this.txtAmount.Text = "0";
            // 
            // btnSub_amount
            // 
            this.btnSub_amount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSub_amount.Location = new System.Drawing.Point(344, 706);
            this.btnSub_amount.Name = "btnSub_amount";
            this.btnSub_amount.Size = new System.Drawing.Size(92, 32);
            this.btnSub_amount.TabIndex = 83;
            this.btnSub_amount.Text = "Submit";
            this.btnSub_amount.UseVisualStyleBackColor = true;
            this.btnSub_amount.Click += new System.EventHandler(this.btnSub_amount_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(18, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 16);
            this.lblName.TabIndex = 84;
            this.lblName.Text = "Name: ";
            // 
            // lblsem
            // 
            this.lblsem.AutoSize = true;
            this.lblsem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsem.ForeColor = System.Drawing.Color.White;
            this.lblsem.Location = new System.Drawing.Point(366, 9);
            this.lblsem.Name = "lblsem";
            this.lblsem.Size = new System.Drawing.Size(70, 16);
            this.lblsem.TabIndex = 85;
            this.lblsem.Text = "Semester:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(366, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 16);
            this.lblID.TabIndex = 86;
            this.lblID.Text = "ID:";
            // 
            // lblSy
            // 
            this.lblSy.AutoSize = true;
            this.lblSy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSy.ForeColor = System.Drawing.Color.White;
            this.lblSy.Location = new System.Drawing.Point(18, 25);
            this.lblSy.Name = "lblSy";
            this.lblSy.Size = new System.Drawing.Size(27, 16);
            this.lblSy.TabIndex = 87;
            this.lblSy.Text = "SY:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.White;
            this.lblCourse.Location = new System.Drawing.Point(18, 41);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(57, 16);
            this.lblCourse.TabIndex = 88;
            this.lblCourse.Text = "Course:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(442, 706);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(366, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 90;
            this.lblStatus.Text = "Status:";
            // 
            // btnHB
            // 
            this.btnHB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHB.Location = new System.Drawing.Point(422, 440);
            this.btnHB.Name = "btnHB";
            this.btnHB.Size = new System.Drawing.Size(114, 35);
            this.btnHB.TabIndex = 91;
            this.btnHB.Text = "History Balance";
            this.btnHB.UseVisualStyleBackColor = true;
            this.btnHB.Click += new System.EventHandler(this.btnHB_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.Location = new System.Drawing.Point(302, 403);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(114, 35);
            this.btnExport.TabIndex = 92;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frm_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 750);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(569, 527);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnHB);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblSy);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblsem);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSub_amount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lstPayment);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTAA);
            this.Controls.Add(this.txtLess);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNSTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.lst_subject_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_subject_input;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTAA;
        private System.Windows.Forms.TextBox txtLess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNSTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.ListView lstPayment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSub_amount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblsem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSy;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnHB;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FolderBrowserDialog fb;
    }
}