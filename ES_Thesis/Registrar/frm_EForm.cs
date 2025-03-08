using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ES_Thesis.Registrar
{
    public partial class frm_EForm : Form
    {
        public frm_EForm()
        {
            InitializeComponent();
            auto_complete_RF();
        }

        private void auto_complete_RF()
        {
            txtReg_SNum.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtReg_SNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            txtReg_NM.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtReg_NM.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();

            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand("select * from tbl_Personal_Info", DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                col.Add(DBMysql.reader.GetString(13));
                col1.Add(DBMysql.reader.GetString(1));
                col1.Add(DBMysql.reader.GetString(2));
            }
            DBMysql.con.Close();
            txtReg_SNum.AutoCompleteCustomSource = col;
            txtReg_NM.AutoCompleteCustomSource = col1;
        }

        private void auto_complete_reg_form()
        {
            txtReg_C1.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtReg_C1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            txtReg_C1_Des.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtReg_C1_Des.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();

            String Sem = String.Empty;
            if (rbRF_FS.Checked == true) { Sem = "1st Semester"; }
            if (rbRF_SS.Checked == true) { Sem = "2nd Semester"; }
            if (rbRF_Summer.Checked == true) { Sem = "Summer"; }
            String status = String.Empty;
            if (rbRF_Reg.Checked == true) { status = "Regular"; }
            if (rbRF_Irr.Checked == true) { status = "Irregular"; }

            if (Sem == "Summer")
            {
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Course = '{0}' and Year = '{1}'",
                txtReg_Course.Text, cbRF_Year.Text), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    col.Add(DBMysql.reader.GetString(1));
                    col1.Add(DBMysql.reader.GetString(2));
                }
                DBMysql.con.Close();
            }
            else
            {
                if (Sem == "Regular")
                {
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Course = '{0}' and Year = '{1}' and Semester = '{2}'"
                    , txtReg_Course.Text, cbRF_Year.Text, Sem), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader = DBMysql.cmd.ExecuteReader();
                    while (DBMysql.reader.Read())
                    {
                        col.Add(DBMysql.reader.GetString(1));
                        col1.Add(DBMysql.reader.GetString(2));
                    }
                    DBMysql.con.Close();
                }
                else
                {
                    String[] courses = { "1st Year", "2nd Year", "3rd Year", "4th Year" };
                    for (int i = 0; i < cbRF_Year.SelectedIndex + 1; i++)
                    {
                        DBMysql.con.Close();
                        DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Course = '{0}' and Year = '{1}' and Semester = '{2}'"
                        , txtReg_Course.Text, courses[i], Sem), DBMysql.con);
                        DBMysql.con.Open();
                        DBMysql.reader = DBMysql.cmd.ExecuteReader();
                        while (DBMysql.reader.Read())
                        {
                            col.Add(DBMysql.reader.GetString(1));
                            col1.Add(DBMysql.reader.GetString(2));
                        }
                        DBMysql.con.Close();
                    }
                }
            }
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

        private void clear_text()
        {
            txtHS_Address.Clear(); txtHS_DGraduation.ResetText(); txtHS_SName.Clear(); txtHS_TStrand.Clear(); txtPF_Address.Clear(); txtPF_FN.Clear(); txtPF_LN.Clear();
            txtPF_MN.Clear(); txtPF_Mobile.Clear(); txtPF_Occ.Clear(); txtPG_Address.Clear(); txtPG_FN.Clear(); txtPG_LN.Clear(); txtPG_MN.Clear(); txtPG_Mobile.Clear();
            txtPG_Occ.Clear(); txtPI_Address.Clear(); txtPI_AYear.Clear(); txtPI_BD.ResetText(); txtPI_Email.Clear(); txtPI_FN.Clear(); txtPI_LN.Clear(); txtPI_MN.Clear();
            txtPI_Mobile.Clear(); txtPI_PBirth.Clear(); txtPI_Program.Clear(); txtPI_Religion.Clear(); txtPM_Address.Clear(); txtPM_FN.Clear(); txtPM_LN.Clear();
            txtPM_MN.Clear(); txtPM_Mobile.Clear(); txtPM_Occ.Clear(); txtTrans_AYear.Clear(); txtTrans_NSLA.Clear(); txtTrans_Program.Clear(); txtPI_StudNum.Clear();
            rbPI_Female.Checked = false; rbPI_Male.Checked = false;
        }

        private void clear_Reg()
        {
            txtReg_SNum.Clear(); txtReg_NM.Clear(); txtReg_Course.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String gender = String.Empty;
            String ID = Global.data(20);
            int check_Id = 0;
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
            else if (String.IsNullOrEmpty(txtPI_PBirth.Text) || String.IsNullOrWhiteSpace(txtPI_PBirth.Text))
            {
                MessageBox.Show("Please input your Place of Birth.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(gender) || String.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select your Gender.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtPI_Address.Text) || String.IsNullOrWhiteSpace(txtPI_Address.Text))
            {
                MessageBox.Show("Please input your Address.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ctr_bday >= ctr_now || computed_birth <= 8)
            {
                MessageBox.Show("Please check your Date of Birth.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<String> data = new List<String>();
                foreach (Control control in groupBox2.Controls)
                {
                    string controlType = control.GetType().ToString();
                    if (controlType == "System.Windows.Forms.TextBox")
                    {
                        TextBox txtBox = (TextBox)control;
                        if (String.IsNullOrEmpty(txtBox.Text) || String.IsNullOrWhiteSpace(txtBox.Text))
                        {
                            txtBox.Text = " ";
                        }
                    }
                }

                foreach (Control control in groupBox3.Controls)
                {
                    string controlType = control.GetType().ToString();
                    if (controlType == "System.Windows.Forms.TextBox")
                    {
                        TextBox txtBox = (TextBox)control;
                        if (String.IsNullOrEmpty(txtBox.Text) || String.IsNullOrWhiteSpace(txtBox.Text))
                        {
                            data.Add("0");
                        }
                        else
                        {
                            data.Add("1");
                        }
                    }
                }

                if (data.Contains("1"))
                {
                    do
                    {
                        check_Id = 0;
                        DBMysql.con.Close();
                        DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_Personal_Info where ID = '{0}'", ID), DBMysql.con);
                        DBMysql.con.Open();
                        DBMysql.reader = DBMysql.cmd.ExecuteReader();
                        while (DBMysql.reader.Read())
                        {
                            if (DBMysql.reader.HasRows == true) { check_Id = 1; }
                        }
                        DBMysql.con.Close();
                        if (check_Id == 1) { ID = Global.data(20); }
                    }
                    while (check_Id != 0);
                    try
                    {
                        if (check_Id == 0)
                        {
                            DBMysql.SQL(String.Format("insert into tbl_Personal_Info(ID,LN,FN,MN,Program,Academic_Year,BDAY,PBirth,Gender,Religion,Address,Mobile,Email,StudNum)values" +
                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", ID, txtPI_LN.Text, txtPI_FN.Text, txtPI_MN.Text, txtPI_Program.Text,
                            txtPI_AYear.Text, txtPI_BD.Text, txtPI_PBirth.Text, gender, txtPI_Religion.Text, txtPI_Address.Text, txtPI_Mobile.Text, txtPI_Email.Text, txtPI_StudNum.Text));

                            DBMysql.SQL(String.Format("insert into tbl_Parent_Guardian(ID,stud_ID,FLN,FFN,FMN,FOcc,FMobile,FAddress,MLN,MFN,MMN,MOcc,MMobile,MAddress,GLN,GFN,GMN,GOcc,GMobile,GAddress)values" +
                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}')", ID, txtPI_StudNum.Text, txtPF_LN.Text, txtPF_FN.Text,
                            txtPF_MN.Text, txtPF_Occ.Text, txtPF_Mobile.Text, txtPF_Address.Text, txtPM_LN.Text, txtPM_FN.Text, txtPM_MN.Text, txtPM_Occ.Text, txtPM_Mobile.Text, txtPM_Address.Text,
                            txtPG_LN.Text, txtPG_FN.Text, txtPG_MN.Text, txtPG_Occ.Text, txtPG_Mobile.Text, txtPG_Address.Text));

                            DBMysql.SQL(String.Format("insert into tbl_HSInformation(ID,SName,Address,DateGraduated,TStrand)values('{0}','{1}','{2}','{3}','{4}')", ID, txtHS_SName.Text,
                                txtHS_Address.Text, txtHS_DGraduation.Text, txtHS_TStrand.Text));

                            if (String.IsNullOrEmpty(txtTrans_NSLA.Text) == false || String.IsNullOrWhiteSpace(txtTrans_NSLA.Text) == false)
                            {
                                DBMysql.SQL(string.Format("insert into tbl_Transferees(ID,NSLA,Program,AYear)values('{0}','{1}','{2}','{3}')", ID, txtTrans_NSLA.Text, txtTrans_Program.Text, txtTrans_AYear.Text));
                            }
                            MessageBox.Show("Information Successfully Registered.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear_text(); data.Clear();
                        }
                    }
                    catch (Exception z) { MessageBox.Show(z.Message); }
                }
                else
                {
                    MessageBox.Show("Please fill up all empty spaces.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Clear();
                }
            }
        }

        private void txtReg_NM_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtReg_NM.Text) || String.IsNullOrWhiteSpace(txtReg_NM.Text))
            {
                clear_Reg();
            }
            else
            {
                try
                {
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_Personal_Info where LN = '{0}' or FN = '{0}'", txtReg_NM.Text), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader = DBMysql.cmd.ExecuteReader();
                    while (DBMysql.reader.Read())
                    {
                        txtReg_NM.Text = String.Format("{0}, {1} {2}", DBMysql.reader.GetString(1), DBMysql.reader.GetString(2), DBMysql.reader.GetString(3));
                        txtReg_Course.Text = DBMysql.reader.GetString(4);
                        txtReg_SNum.Text = DBMysql.reader.GetString(13);
                    }
                    DBMysql.con.Close();
                    load_data(txtReg_SNum.Text, txtReg_AYear.Text);
                }
                catch (Exception) { }
            }
        }

        private void txtReg_SNum_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtReg_SNum.Text) || String.IsNullOrWhiteSpace(txtReg_SNum.Text))
            {
                clear_Reg();
            }
            else
            {
                try
                {
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_Personal_Info where StudNum = '{0}'", txtReg_SNum.Text), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader = DBMysql.cmd.ExecuteReader();
                    while (DBMysql.reader.Read())
                    {
                        txtReg_NM.Text = String.Format("{0}, {1} {2}", DBMysql.reader.GetString(1), DBMysql.reader.GetString(2), DBMysql.reader.GetString(3));
                        txtReg_Course.Text = DBMysql.reader.GetString(4);
                    }
                    DBMysql.con.Close();
                    load_data(txtReg_SNum.Text, txtReg_AYear.Text);
                }
                catch (Exception) { }
            }
        }

        private void reg_data()
        {
            int check = 0;
            String sem = String.Empty;
            if (rbRF_FS.Checked == true) { sem = rbRF_FS.Text; }
            if (rbRF_SS.Checked == true) { sem = rbRF_SS.Text; }
            if (rbRF_Summer.Checked == true) { sem = rbRF_Summer.Text; }
            String stat = String.Empty;
            if (rbRF_Reg.Checked == true) { stat = rbRF_Reg.Text; }
            if (rbRF_Irr.Checked == true) { stat = rbRF_Irr.Text; }

            if (String.IsNullOrEmpty(sem) == false && String.IsNullOrWhiteSpace(sem) == false
              && String.IsNullOrEmpty(cbRF_Year.Text) == false && String.IsNullOrWhiteSpace(cbRF_Year.Text) == false)
            {
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_reg_form where Sub_ID = '{0}' and Semester = '{1}' and Year = '{2}'",
                txtReg_SNum.Text, sem, cbRF_Year.Text), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    if (DBMysql.reader.HasRows == true) { check = 1; }
                }
                DBMysql.con.Close();

                if (check == 0)
                {
                    if (String.IsNullOrEmpty(txtReg_NM.Text) == false && String.IsNullOrWhiteSpace(txtReg_NM.Text) == false
                     && String.IsNullOrEmpty(txtReg_Course.Text) == false && String.IsNullOrWhiteSpace(txtReg_Course.Text) == false
                     && String.IsNullOrEmpty(txtReg_AYear.Text) == false && String.IsNullOrWhiteSpace(txtReg_AYear.Text) == false
                     && String.IsNullOrEmpty(sem) == false && String.IsNullOrWhiteSpace(sem) == false
                     && String.IsNullOrEmpty(stat) == false && String.IsNullOrWhiteSpace(stat) == false
                     && String.IsNullOrEmpty(cbRF_Year.Text) == false && String.IsNullOrWhiteSpace(cbRF_Year.Text) == false
                     && String.IsNullOrEmpty(txtReg_SNum.Text) == false && String.IsNullOrWhiteSpace(txtReg_SNum.Text) == false)
                    {
                        String ID = Global.data(20);
                        DBMysql.SQL(String.Format("insert into tbl_reg_form(ID,Name,Course,AYear,Semester,Stat,Year,Sub_ID)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                        ID, txtReg_NM.Text, txtReg_Course.Text, txtReg_AYear.Text, sem, stat, cbRF_Year.Text, txtReg_SNum.Text));
                    }
                }
            }
        }

        private void load_data(String sub_ID, String AYear)
        {
            lst_subject_input.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", sub_ID, AYear), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                item.SubItems.Add(DBMysql.reader.GetString(3));
                item.SubItems.Add(DBMysql.reader.GetString(4));
                item.SubItems.Add(DBMysql.reader.GetString(5));
                item.SubItems.Add(DBMysql.reader.GetString(6));
                item.SubItems.Add(DBMysql.reader.GetString(7));
                item.SubItems.Add(DBMysql.reader.GetString(8));
                item.SubItems.Add(DBMysql.reader.GetString(9));
                lst_subject_input.Items.Add(item);
            }
            DBMysql.con.Close();
        }

        private void rbRF_Reg_CheckedChanged(object sender, EventArgs e)
        {
            auto_complete_reg_form();
        }

        private void rbRF_FS_CheckedChanged(object sender, EventArgs e)
        {
            auto_complete_reg_form();
        }

        private void txtReg_Course_TextChanged(object sender, EventArgs e)
        {
            auto_complete_reg_form();
        }

        private void txtReg_C1_Des_Leave(object sender, EventArgs e)
        {
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Title = '{0}'", txtReg_C1_Des.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while(DBMysql.reader.Read())
            {
                txtReg_C1.Text = DBMysql.reader.GetString(1);
                txtReg_C1_LEC.Text = DBMysql.reader.GetString(3);
                txtReg_C1_LAB.Text = DBMysql.reader.GetString(4);
                txtReg_C1_Day.Text = DBMysql.reader.GetString(5);
                txtReg_C1_Time.Text = DBMysql.reader.GetString(6);
                txtReg_C1_Room.Text = DBMysql.reader.GetString(7);
            }
            DBMysql.con.Close();
        }

        private void txtReg_C1_Leave(object sender, EventArgs e)
        {
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Code = '{0}'", txtReg_C1.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                txtReg_C1_Des.Text = DBMysql.reader.GetString(2);
                txtReg_C1_LEC.Text = DBMysql.reader.GetString(3);
                txtReg_C1_LAB.Text = DBMysql.reader.GetString(4);
                txtReg_C1_Day.Text = DBMysql.reader.GetString(5);
                txtReg_C1_Time.Text = DBMysql.reader.GetString(6);
                txtReg_C1_Room.Text = DBMysql.reader.GetString(7);
            }
            DBMysql.con.Close();
        }

        String ID_sub = String.Empty;
        private void lst_subject_input_Click(object sender, EventArgs e)
        {
            ID_sub = lst_subject_input.FocusedItem.SubItems[0].Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int check_sub = 0;
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}' and Code = '{2}' and DTitle = '{3}'",
            txtReg_SNum.Text, txtReg_AYear.Text, txtReg_C1.Text, txtReg_C1_Des.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (DBMysql.reader.HasRows == true) { check_sub = 1; }
            }
            DBMysql.con.Close();

            if (check_sub == 0)
            {
                String ID = Global.data(20);
                ListViewItem item = new ListViewItem(new[] { ID, txtReg_C1.Text, txtReg_C1_Des.Text, txtReg_C1_LEC.Text,  txtReg_C1_LAB.Text,
                txtReg_C1_Day.Text, txtReg_C1_Time.Text, txtReg_C1_Room.Text });
                lst_subject_input.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Subject is already taken.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_subject_input.SelectedItems.Count; i++)
            {
                if (lst_subject_input.SelectedItems[i].Selected)
                {
                    int i2 = lst_subject_input.SelectedItems[i].Index;
                    DBMysql.SQL(String.Format("delete from tbl_reg_sub where ID = '{0}'", lst_subject_input.Items[i2].Text));
                }
            }

            foreach (ListViewItem x in lst_subject_input.SelectedItems) 
            { 
                lst_subject_input.Items.Remove(x);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_subject_input.Items.Count; i++)
            {
                DBMysql.SQL(String.Format("delete from tbl_reg_sub where ID = '{0}'",lst_subject_input.Items[0].Text));
            }
            lst_subject_input.Items.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            String sem = String.Empty;
            reg_data();
            foreach(ListViewItem i in lst_subject_input.Items)
            {
                DBMysql.SQL(String.Format("insert into tbl_reg_sub(ID,Sub_ID,AYear,Code,DTitle,LEC,LAB,Day,Time,Room,Grade)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                i.SubItems[0].Text, txtReg_SNum.Text, txtReg_AYear.Text, i.SubItems[1].Text, i.SubItems[2].Text, i.SubItems[3].Text, i.SubItems[4].Text, i.SubItems[5].Text, i.SubItems[6].Text,
                i.SubItems[7].Text, String.Empty));
            }
            if (rbRF_FS.Checked == true) { sem = rbRF_FS.Text; }
            if (rbRF_SS.Checked == true) { sem = rbRF_SS.Text; }
            if (rbRF_Summer.Checked == true) { sem = rbRF_Summer.Text; }

            int check_account = 0;

            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_student_fee where stud_ID = '{0}' and stud_Name = '{1}' and Course = '{2}' and Year = '{3}' and semester = '{4}' and SY = '{5}'",
            txtReg_SNum.Text, txtReg_NM.Text, txtReg_Course.Text, cbRF_Year.Text, sem, txtReg_AYear.Text),DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (DBMysql.reader.HasRows == true) { check_account = 1; }
            }
            DBMysql.con.Close();
            if (check_account == 0)
            {
                DBMysql.con.Close();
                DBMysql.SQL(String.Format("insert into tbl_student_fee(ID,stud_ID,stud_Name,Course,Year,semester,reg,mis,pe,oth,tuition,nstp,labosatory,total_assessment,"
                + "lss,taa,SY)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{6}','{6}','{6}','{6}','{6}','{6}','{6}','{6}','{6}','{7}')",
                Global.data(20), txtReg_SNum.Text, txtReg_NM.Text, txtReg_Course.Text, cbRF_Year.Text, sem, "0", txtReg_AYear.Text));
            }
            load_data(txtReg_SNum.Text, txtReg_AYear.Text);
            MessageBox.Show("Subjects successfully Enroll.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRF_Clear_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to clear all fields?", "Conferm Clearing Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    lst_subject_input.Items.Clear();
                    txtReg_C1.Clear(); txtReg_C1_Day.Clear(); txtReg_C1_Des.Clear(); txtReg_C1_LAB.Clear(); txtReg_C1_LEC.Clear(); txtReg_C1_Room.Clear();
                    txtReg_C1_Time.Clear(); txtReg_Course.Clear(); txtReg_NM.Clear(); txtReg_SNum.Clear(); txtReg_AYear.Clear(); cbRF_Year.ResetText();
                    rbRF_Irr.Checked = false; rbRF_Reg.Checked = false; rbRF_FS.Checked = false; rbRF_SS.Checked = false; rbRF_Summer.Checked = false;
                    break;
                default:
                    break;
            }
        }
    }
}
