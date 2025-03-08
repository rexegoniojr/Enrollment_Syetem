using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Diagnostics;


namespace ES_Thesis.Registrar
{
    public partial class frm_student_info : Form
    {
        public frm_student_info()
        {
            InitializeComponent();
            display_info(Global.stud_info);
            auto_complete_reg_form(Global.stud_info);
            subject_display(ID_holder);
        }

        private void frm_student_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.stud_info = String.Empty;
        }

        String ID_holder = String.Empty;
        private void display_info(String ID)
        {
            String stud_ID = String.Empty;
            #region Student Information
            txtPI_LN.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 1);
            txtPI_FN.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 2);
            txtPI_MN.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 3);
            txtPI_Program.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 4);
            txtPI_AYear.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 5);

            try
            {
                txtPI_BD.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 6);
            }
            catch (Exception)
            {
                String[] dates = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 6).Split('/');
                txtPI_BD.Text = String.Format("{0}/{1}/{2}", dates[1], dates[0], dates[2]);
            }

            txtPI_PBirth.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 7);
            if (DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 8) == "Male") { rbPI_Male.Checked = true; }
            if (DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 8) == "Female") { rbPI_Female.Checked = true; }
            txtPI_Religion.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 9);
            txtPI_Address.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 10);
            txtPI_Mobile.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 11);
            txtPI_Email.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 12);
            txtPI_StudNum.Text = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 13);
            stud_ID = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 13);
            ID_holder = DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 13);
            #endregion
            #region Parents and Guardian Inforamtion
            txtF_LN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 2);
            txtF_FN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 3);
            txtF_MN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 4);
            txtF_Occ.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 5);
            txtF_MNo.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 6);
            txtF_Add.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 7);

            txtPM_LN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 8);
            txtPM_FN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 9);
            txtPM_MN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 10);
            txtPM_Occ.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 11);
            txtPM_Mobile.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 12);
            txtPM_Address.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 13);

            txtPG_LN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 14);
            txtPG_FN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 15);
            txtPG_MN.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 16);
            txtPG_Occ.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 17);
            txtPG_Mobile.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 18);
            txtPG_Address.Text = DBMysql.data(String.Format("select * from tbl_parent_guardian where ID = '{0}'", ID), 19);
            #endregion
            #region High School Information
            txtHS_SName.Text = DBMysql.data(String.Format("select * from tbl_hsinformation where ID = '{0}'", ID), 1);
            txtHS_Address.Text = DBMysql.data(String.Format("select * from tbl_hsinformation where ID = '{0}'", ID), 2);
            try
            {
                txtHS_DGraduation.Text = DBMysql.data(String.Format("select * from tbl_hsinformation where ID = '{0}'", ID), 3);
            }
            catch (Exception)
            {
                String[] dates = DBMysql.data(String.Format("select * from tbl_hsinformation where ID = '{0}'", ID), 3).Split('/');
                txtPI_BD.Text = String.Format("{0}/{1}/{2}", dates[1], dates[0], dates[2]);
            }

            txtHS_TStrand.Text = DBMysql.data(String.Format("select * from tbl_hsinformation where ID = '{0}'", ID), 4);
            #endregion
            #region Transferees Information
            txtTrans_NSLA.Text = DBMysql.data(String.Format("select * from tbl_transferees where ID = '{0}'", ID), 1);
            txtTrans_Program.Text = DBMysql.data(String.Format("select * from tbl_transferees where ID = '{0}'", ID), 2);
            txtTrans_AYear.Text = DBMysql.data(String.Format("select * from tbl_transferees where ID = '{0}'", ID), 3);
            #endregion
            #region Add-ons
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_reg_form where Sub_ID = '{0}'", stud_ID), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (DBMysql.reader.GetString(6) == "1st Year") { cb1st.Checked = true; }
                if (DBMysql.reader.GetString(6) == "2nd Year") { cb2nd.Checked = true; cb1st.Checked = true; }
                if (DBMysql.reader.GetString(6) == "3rd Year") { cb3rd.Checked = true; cb2nd.Checked = true; cb1st.Checked = true; }
                if (DBMysql.reader.GetString(6) == "4th Year") { cb4th.Checked = true; cb3rd.Checked = true; cb2nd.Checked = true; cb1st.Checked = true; }
            }

            String stat = DBMysql.data(String.Format("select * from tbl_reg_form where Sub_ID = '{0}'", stud_ID), 5);
            if (stat.ToUpper() == "REGULAR") { rbRF_Reg.Checked = true; }
            else { rbRF_Irr.Checked = true; }
            #endregion
        }

        private void subject_display(String Id)
        {
            lstdata.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select reg.ID, reg.Code, reg.DTitle, reg.LEC, reg.LAB, reg.Grade, cr.Semester, cr.Year, reg.Sub_ID from tbl_reg_sub reg " +
            "left join tbl_course_list cr on reg.Code = cr.Code where reg.Sub_ID = '{0}' order by cr.Semester, cr.Year", Id), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                item.SubItems.Add(DBMysql.reader.GetString(1));
                item.SubItems.Add(DBMysql.reader.GetString(2));
                item.SubItems.Add(DBMysql.reader.GetString(3));
                item.SubItems.Add(DBMysql.reader.GetString(4));
                item.SubItems.Add(DBMysql.reader.GetString(5));
                item.SubItems.Add(DBMysql.reader.GetString(6));
                item.SubItems.Add(DBMysql.reader.GetString(7));
                lstdata.Items.Add(item);

            }
            DBMysql.con.Close();
        }

        private void auto_complete_reg_form(String ID)
        {
            txtReg_C1.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtReg_C1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            txtReg_C1_Des.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtReg_C1_Des.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Course = '{0}'", DBMysql.data(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), 4)), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                col.Add(DBMysql.reader.GetString(4));
                col1.Add(DBMysql.reader.GetString(5));
            }
            DBMysql.con.Close();

            txtReg_C1.AutoCompleteCustomSource = col;
            txtReg_C1_Des.AutoCompleteCustomSource = col1;
        }

        private void capital_Leave(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox user = (System.Windows.Forms.TextBox)sender;
                user.Text = Global.ToSentenceCase(user.Text);
            }
            catch (Exception) { }
        }

        private void TxtNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtReg_C1_Leave(object sender, EventArgs e)
        {
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Code = '{0}'", txtReg_C1.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                txtReg_C1_Des.Text = DBMysql.reader.GetString(5);
                txtReg_C1_LEC.Text = DBMysql.reader.GetString(6);
                txtReg_C1_LAB.Text = DBMysql.reader.GetString(7);
            }
            DBMysql.con.Close();
        }

        private void txtReg_C1_Des_Leave(object sender, EventArgs e)
        {
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Title = '{0}'", txtReg_C1_Des.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                txtReg_C1.Text = DBMysql.reader.GetString(4);
                txtReg_C1_LEC.Text = DBMysql.reader.GetString(6);
                txtReg_C1_LAB.Text = DBMysql.reader.GetString(7);
            }
            DBMysql.con.Close();
        }

        private void btn_PI_Submit_Click(object sender, EventArgs e)
        {
            String gender = String.Empty;
            if (rbPI_Male.Checked == true) { gender = "Male"; }
            if (rbPI_Female.Checked == true) { gender = "Female"; }
            DateTime ctr_bday = Convert.ToDateTime(txtPI_BD.Text);
            DateTime ctr_now = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            int computed_birth = ctr_now.Year - ctr_bday.Year;

            if (String.IsNullOrEmpty(txtPI_FN.Text) || String.IsNullOrWhiteSpace(txtPI_FN.Text))
            {
                MessageBox.Show("Please input your First Name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtPI_LN.Text) || String.IsNullOrWhiteSpace(txtPI_LN.Text))
            {
                MessageBox.Show("Please input your Last Name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtPI_LN.Text) || String.IsNullOrWhiteSpace(txtPI_LN.Text))
            {
                MessageBox.Show("Please input your Place of Birth.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(gender) || String.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select your Gender.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtPI_Address.Text) || String.IsNullOrWhiteSpace(txtPI_Address.Text))
            {
                MessageBox.Show("Please input your Place of Birth.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ctr_bday >= ctr_now || computed_birth <= 8)
            {
                MessageBox.Show("Please check your Date of Birth.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch(MessageBox.Show(this,"Save changes?","Notice",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("update tbl_personal_info set LN = '{0}', FN = '{1}', MN = '{2}', Program = '{3}', Academic_Year = '{4}'," +
                        "BDAY = '{5}', PBirth = '{6}', Gender = '{7}', Religion = '{8}', Address = '{9}', Mobile = '{10}', Email = '{11}' where StudNum = '{12}'",
                        txtPI_LN.Text, txtPI_FN.Text, txtPI_MN.Text, txtPI_Program.Text, txtPI_AYear.Text, txtPI_BD.Text, txtPI_PBirth.Text, gender, txtPI_Religion.Text,
                        txtPI_Address.Text, txtPI_Mobile.Text, txtPI_Email.Text, txtPI_StudNum.Text));
                        MessageBox.Show("Personal Information successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnPG_Submit_Click(object sender, EventArgs e)
        {
            int empty_text = 0;
            foreach (Control control in tabPage2.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (String.IsNullOrEmpty(txtBox.Text) || String.IsNullOrWhiteSpace(txtBox.Text))
                    {
                        empty_text = 0;
                    }
                    else
                    {
                        empty_text = 1;
                    }
                }
            }

            if (empty_text == 1)
            {
                switch (MessageBox.Show(this, "Save changes?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("update tbl_parent_guardian set FLN = '{0}', FFN = '{1}', FMN = '{2}', FOcc = '{3}', FMobile = '{4}', FAddress = '{5}',"
                        + "MLN = '{6}', MFN = '{7}', MMN = '{8}', MOcc = '{9}', MMobile = '{10}', MAddress = '{11}', GLN = '{12}', GFN = '{13}', GMN = '{14}', GOcc = '{15}',"
                        + "GMobile = '{16}', GAddress = '{17}' where ID = '{18}'", txtF_LN.Text, txtF_FN.Text, txtF_MN.Text, txtF_Occ.Text, txtF_MNo.Text, txtF_Add.Text,
                        txtPM_LN.Text, txtPM_FN.Text, txtPM_MN.Text, txtPM_Occ.Text, txtPM_Mobile.Text, txtPM_Address.Text, txtPG_LN.Text, txtPG_FN.Text, txtPG_MN.Text,
                        txtPG_Occ.Text, txtPG_Mobile.Text, txtPG_Address.Text, Global.stud_info));
                        MessageBox.Show("Parents and Guardian Information successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please fill up all empty spaces.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHS_Submit_Click(object sender, EventArgs e)
        {
            int empty_text = 0;
            foreach (Control control in tabPage3.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (String.IsNullOrEmpty(txtBox.Text) || String.IsNullOrWhiteSpace(txtBox.Text))
                    {
                        empty_text = 0;
                    }
                    else
                    {
                        empty_text = 1;
                    }
                }
            }

            if (empty_text == 1)
            {
                switch (MessageBox.Show(this, "Save changes?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("update hsinformation set SName = '{0}', Address = '{1}', DateGraduated = '{2}', TStrand = '{3}' where ID = '{4}'",
                        txtHS_SName.Text, txtHS_Address.Text, txtHS_DGraduation.Text, txtHS_TStrand.Text, Global.stud_info));
                        MessageBox.Show("High School Information successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please fill up all empty spaces.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTI_Submit_Click(object sender, EventArgs e)
        {
            int empty_text = 0;
            foreach (Control control in tabPage3.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (String.IsNullOrEmpty(txtBox.Text) || String.IsNullOrWhiteSpace(txtBox.Text))
                    {
                        empty_text = 0;
                    }
                    else
                    {
                        empty_text = 1;
                    }
                }
            }

            if (empty_text == 1)
            {
                switch (MessageBox.Show(this, "Save changes?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("update tbl_transferees set NSLA = '{0}', Program = '{1}', AYear = '{2}' where ID = '{3}'", txtTrans_NSLA.Text,
                        txtTrans_Program.Text, txtTrans_AYear.Text, Global.stud_info));
                        MessageBox.Show("Parents and Guardian Information successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please fill up all empty spaces.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String ID_Subject = Global.data(20);
            if (String.IsNullOrEmpty(txtReg_C1.Text) || String.IsNullOrWhiteSpace(txtReg_C1.Text) ||
                String.IsNullOrEmpty(txtReg_C1_Des.Text) || String.IsNullOrWhiteSpace(txtReg_C1_Des.Text))
            {
                MessageBox.Show("Please input the subject code or descriptive title to add.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DBMysql.SQL(String.Format("insert into tbl_reg_sub(ID,Sub_ID,AYear,Code,DTitle,LEC,LAB,Day,Time,Room,Grade)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                ID_Subject, ID_holder, "-", txtReg_C1.Text, txtReg_C1_Des.Text, txtReg_C1_LEC.Text, txtReg_C1_LAB.Text, "-", "-", "-", txtGrade.Text));
                subject_display(ID_holder);
                MessageBox.Show("Subject successfully added.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID_sub) == false || String.IsNullOrWhiteSpace(ID_sub) == false)
            {
                switch (MessageBox.Show(this, "Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("delete from tbl_reg_sub where ID = '{0}'", ID_sub));
                        ID_sub = String.Empty;
                        subject_display(ID_holder);
                        break;
                    default:
                        break;
                }
            }
        }

        String ID_sub = String.Empty;
        private void lstdata_Click(object sender, EventArgs e)
        {
            ID_sub = lstdata.FocusedItem.SubItems[0].Text;
        }

        private void btnExMS_Click(object sender, EventArgs e)
        {
            String gender = String.Empty;
            if (rbPI_Male.Checked == true) { gender = "Male"; }
            if (rbPI_Female.Checked == true) { gender = "Female"; }

            if (fb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String temp_code = Global.num(5);
                    Global.EndTask("winword");
                    File.Copy(Global.exePath + "\\Docs\\af.docx", String.Format("{0}\\{1}[{2}]StudentInfo.docx", @fb.SelectedPath, temp_code, Global.stud_info), true);
                    object missing = Missing.Value;
                    Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Word.Document aDoc = null;
                    object filename = String.Format("{0}\\{1}[{2}]StudentInfo.docx", @fb.SelectedPath, temp_code, Global.stud_info);
                    if (File.Exists((string)filename))
                    {
                        object readOnly = false;
                        object isVisible = false;
                        wordApp.Visible = false;
                        aDoc = wordApp.Documents.Open(ref filename, ref missing,
                        ref readOnly, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref isVisible, ref missing, ref missing,
                        ref missing, ref missing);
                        aDoc.Activate();
                        Global.FindAndReplace(wordApp, "<std_LN>", txtPI_LN.Text);
                        Global.FindAndReplace(wordApp, "<std_FN>", txtPI_FN.Text);
                        Global.FindAndReplace(wordApp, "<std_MN>", txtPI_MN.Text);
                        Global.FindAndReplace(wordApp, "<program>", txtPI_Program.Text);
                        Global.FindAndReplace(wordApp, "<AY", txtPI_AYear.Text);
                        Global.FindAndReplace(wordApp, "<DB>", txtPI_BD.Text);
                        Global.FindAndReplace(wordApp, "<PB>", txtPI_PBirth.Text);
                        Global.FindAndReplace(wordApp, "<G>", gender);
                        Global.FindAndReplace(wordApp, "<Rel>", txtPI_Religion.Text);
                        Global.FindAndReplace(wordApp, "<ADD>", txtPI_Address.Text);
                        Global.FindAndReplace(wordApp, "<MN>", txtPI_Mobile.Text);
                        Global.FindAndReplace(wordApp, "<EA>", txtPI_Email.Text);

                        Global.FindAndReplace(wordApp, "<FLN>", txtF_LN.Text);
                        Global.FindAndReplace(wordApp, "<FFN>", txtF_FN.Text);
                        Global.FindAndReplace(wordApp, "<FMN>", txtF_MN.Text);
                        Global.FindAndReplace(wordApp, "<FOCC>", txtF_Occ.Text);
                        Global.FindAndReplace(wordApp, "<FMNo>", txtF_MNo.Text);
                        Global.FindAndReplace(wordApp, "<FADD>", txtF_Add.Text);

                        Global.FindAndReplace(wordApp, "<MLN>", txtPM_LN.Text);
                        Global.FindAndReplace(wordApp, "<MFN>", txtPM_FN.Text);
                        Global.FindAndReplace(wordApp, "<MMN>", txtPM_MN.Text);
                        Global.FindAndReplace(wordApp, "<MOCC>", txtPM_Occ.Text);
                        Global.FindAndReplace(wordApp, "<MMNo>", txtPM_Mobile.Text);
                        Global.FindAndReplace(wordApp, "<MADD>", txtPM_Address.Text);

                        Global.FindAndReplace(wordApp, "<GLN>", txtPG_LN.Text);
                        Global.FindAndReplace(wordApp, "<GFN>", txtPG_FN.Text);
                        Global.FindAndReplace(wordApp, "<GMN>", txtPG_MN.Text);
                        Global.FindAndReplace(wordApp, "<GOCC>", txtPG_Occ.Text);
                        Global.FindAndReplace(wordApp, "<GMNo>", txtPG_Mobile.Text);
                        Global.FindAndReplace(wordApp, "<GADD>", txtPG_Address.Text);

                        Global.FindAndReplace(wordApp, "<Sch_Name>", txtHS_SName.Text);
                        Global.FindAndReplace(wordApp, "<Sch_Add>", txtHS_Address.Text);
                        Global.FindAndReplace(wordApp, "<DT_Sch>", txtHS_DGraduation.Text);
                        Global.FindAndReplace(wordApp, "<TS>", txtHS_TStrand.Text);

                        Global.FindAndReplace(wordApp, "<Sch_LA>", txtTrans_NSLA.Text);
                        Global.FindAndReplace(wordApp, "<LA_Program>", txtTrans_Program.Text);
                        Global.FindAndReplace(wordApp, "<sch_AY>", txtTrans_AYear.Text);
                        aDoc.Save();

                        Global.EndTask("winword");
                        MessageBox.Show("Student Information successfully exported.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Global.EndTask("winword");
                        String ID_F = Global.data(20);
                        String fname = String.Format("{0}\\{1}[{2}]StudentInfo.docx", @fb.SelectedPath, temp_code, Global.stud_info);
                        string[] sizes = { "B", "KB", "MB", "GB" };
                        double len = new FileInfo(fname).Length;
                        int order = 0;
                        while (len >= 1024 && ++order < sizes.Length) { len = len / 1024; }
                        string result = String.Format("{0:0.##} {1}", len, sizes[order]);
                        String name_F = String.Format("{0}[{1}]CDA.docx", temp_code, Global.cd_ID);
                        String type_F = Path.GetExtension(fname);
                        String size_F = result;
                        DBMysql.SQL(String.Format("insert into tbl_files(ID,acc_ID,fname,ftype,fsize,file,Date)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                        ID_F, Global.ID, name_F, type_F, size_F, Global.Compress(Convert.ToBase64String(File.ReadAllBytes(fname))), DateTime.Now.ToShortDateString()));
                    }
                    else
                    {
                        MessageBox.Show("File does not exist.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Global.EndTask("winword");
                    }
                }
                catch (Exception x) { MessageBox.Show(this, x.Message, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        frm_CDAS cdas;
        private void btnCDAS_Click(object sender, EventArgs e)
        {
            Global.cd_ID = txtPI_StudNum.Text;
            Global.cd_Year = txtPI_AYear.Text;
            Global.at_course = txtPI_Program.Text;
            if (cdas == null || cdas.IsDisposed)
            {
                cdas = new frm_CDAS();
                cdas.Show();
            }
            else
            {
                cdas.BringToFront();
            }
        }
    }
}
