using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ES_Thesis.Admin
{
    public partial class frm_Schedule : Form
    {
        public frm_Schedule()
        {
            InitializeComponent();
            auto_complete_schedule();
            display_subject_time();
        }

        private void auto_complete_schedule()
        {
            String Sem = String.Empty;
            if (rbSch_1stSem.Checked == true) { Sem = "1st Semester"; }
            if (rbSch_2ndSem.Checked == true) { Sem = "2nd Semester"; }

            txtSch_Code.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSch_Code.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Semester = '{0}' and Course = '{1}'", Sem, txtSch_Course.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                col.Add(DBMysql.reader.GetString(4));
            }
            DBMysql.con.Close();
            txtSch_Code.AutoCompleteCustomSource = col;
        }

        private void clear_Sch()
        {
            txtSch_Title.Clear(); txtSch_Time.Clear(); txtSch_Room.Clear(); txtSch_Lec.Clear(); txtSch_Lab.Clear(); txtSch_Day.Clear();
            txtSch_Code.Clear(); cbSch_Year.Clear(); txtSch_Code.Clear();
        }

        private void rbSch_1stSem_CheckedChanged(object sender, EventArgs e)
        {
            auto_complete_schedule();
            display_subject_time();
        }

        List<String> list_course = new List<String>();
        private void display_subject_time()
        {
            lstSch_Schedule.Items.Clear();
            list_course.Clear();

            String Sem = String.Empty;
            if (rbSch_1stSem.Checked == true) { Sem = "1st Semester"; }
            if (rbSch_2ndSem.Checked == true) { Sem = "2nd Semester"; }

            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where AYear = '{0}' and Semester = '{1}' order by Course", txtSch_Year.Text, Sem), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (list_course.Contains(DBMysql.reader.GetString(10)) == false)
                {
                    list_course.Add(DBMysql.reader.GetString(10));
                }
            }
            DBMysql.con.Close();

            for (int i = 0; i < list_course.Count; i++)
            {
                ListViewItem blank = new ListViewItem(new[] { " ", " ", list_course[i], " ", " ", " ", " " });
                blank.BackColor = Color.Silver;
                lstSch_Schedule.Items.Add(blank);

                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Course = '{0}' and AYear = '{1}' and Semester = '{2}'" +
                " order by Year asc", list_course[i], txtSch_Year.Text, Sem), DBMysql.con);
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
                    item.SubItems.Add(DBMysql.reader.GetString(11));
                    lstSch_Schedule.Items.Add(item);
                }
                DBMysql.con.Close();
            }
        }

        String ID_Sch_Schedule = String.Empty;
        private void lstSch_Schedule_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lstSch_Schedule.FocusedItem.SubItems[0].Text) || String.IsNullOrWhiteSpace(lstSch_Schedule.FocusedItem.SubItems[0].Text))
            {
                clear_Sch();
            }
            else
            {
                ID_Sch_Schedule = lstSch_Schedule.FocusedItem.SubItems[0].Text;
                txtSch_Code.Text = lstSch_Schedule.FocusedItem.SubItems[1].Text;
                txtSch_Title.Text = lstSch_Schedule.FocusedItem.SubItems[2].Text;
                txtSch_Lec.Text = lstSch_Schedule.FocusedItem.SubItems[3].Text;
                txtSch_Lab.Text = lstSch_Schedule.FocusedItem.SubItems[4].Text;
                txtSch_Day.Text = lstSch_Schedule.FocusedItem.SubItems[5].Text;
                txtSch_Time.Text = lstSch_Schedule.FocusedItem.SubItems[6].Text;
                txtSch_Room.Text = lstSch_Schedule.FocusedItem.SubItems[7].Text;
                cbSch_Year.Text = lstSch_Schedule.FocusedItem.SubItems[8].Text;
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Code = '{0}'", lstSch_Schedule.FocusedItem.SubItems[1].Text), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    txtSch_Course.Text = DBMysql.reader.GetString(1);
                }
                DBMysql.con.Close();
            }
        }

        private void tbnSch_Add_Click(object sender, EventArgs e)
        {
            String Sem = String.Empty;
            if (rbSch_1stSem.Checked == true) { Sem = "1st Semester"; }
            if (rbSch_2ndSem.Checked == true) { Sem = "2nd Semester"; }
            if (String.IsNullOrEmpty(txtSch_Code.Text) || String.IsNullOrWhiteSpace(txtSch_Code.Text))
            {
                MessageBox.Show("Please Fillup the CourseCode to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrWhiteSpace(txtSch_Title.Text) || String.IsNullOrWhiteSpace(txtSch_Title.Text))
            {
                MessageBox.Show("Please fillup Descriptive Title to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtSch_Time.Text) || String.IsNullOrWhiteSpace(txtSch_Time.Text))
            {
                MessageBox.Show("Please fillup Time to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtSch_Year.Text) || String.IsNullOrWhiteSpace(txtSch_Year.Text))
            {
                MessageBox.Show("Please fillup Year to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(Sem) || String.IsNullOrWhiteSpace(Sem))
            {
                MessageBox.Show("Please select Semester to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtSch_Course.Text) || String.IsNullOrWhiteSpace(txtSch_Course.Text))
            {
                MessageBox.Show("Please fillup Course to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cbSch_Year.Text) || String.IsNullOrWhiteSpace(cbSch_Year.Text))
            {
                MessageBox.Show("Please select Year to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int check_schedule = 0;
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Code = '{0}' and AYear = '{1}'", txtSch_Code.Text, txtSch_Year.Text), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    if (DBMysql.reader.HasRows == true) { check_schedule = 1; }
                }
                DBMysql.con.Close();

                if (check_schedule == 1) { MessageBox.Show("Subject already inserted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information); clear_Sch(); }
                else
                {
                    String ID = Global.data(20);
                    DBMysql.SQL(String.Format("insert into tbl_subject_schedule(ID,Code,Title,LEC,LAB,Day,Time,Room,AYear,Semester,Course,Year)values('{0}','{1}','{2}','{3}','{4}','{5}'," +
                    "'{6}','{7}','{8}','{9}','{10}','{11}')", ID, txtSch_Code.Text, txtSch_Title.Text, txtSch_Lec.Text, txtSch_Lab.Text, txtSch_Day.Text, txtSch_Time.Text, txtSch_Room.Text,
                    txtSch_Year.Text, Sem, txtSch_Course.Text, cbSch_Year.Text));
                    MessageBox.Show("Subject Schedule successfully inserted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display_subject_time();
                    clear_Sch();
                }
            }
        }

        private void btnSch_Update_Click(object sender, EventArgs e)
        {
            String Sem = String.Empty;
            if (rbSch_1stSem.Checked == true) { Sem = "1st Semester"; }
            if (rbSch_2ndSem.Checked == true) { Sem = "2nd Semester"; }
            if (String.IsNullOrEmpty(txtSch_Code.Text) || String.IsNullOrWhiteSpace(txtSch_Code.Text))
            {
                MessageBox.Show("Please Fillup the CourseCode to update information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrWhiteSpace(txtSch_Title.Text) || String.IsNullOrWhiteSpace(txtSch_Title.Text))
            {
                MessageBox.Show("Please fillup Descriptive Title to update information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtSch_Time.Text) || String.IsNullOrWhiteSpace(txtSch_Time.Text))
            {
                MessageBox.Show("Please fillup Time to update information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtSch_Year.Text) || String.IsNullOrWhiteSpace(txtSch_Year.Text))
            {
                MessageBox.Show("Please fillup Year to update information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(Sem) || String.IsNullOrWhiteSpace(Sem))
            {
                MessageBox.Show("Please select Semester to update information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtSch_Course.Text) || String.IsNullOrWhiteSpace(txtSch_Course.Text))
            {
                MessageBox.Show("Please fillup Course to update information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DBMysql.SQL(String.Format("update tbl_subject_schedule set Code = '{0}', Title = '{1}', LEC = '{2}', LAB = '{3}', Day = '{4}'," +
                    " Time = '{5}', Room = '{6}', Year = '{7}' where ID = '{8}'", txtSch_Code.Text, txtSch_Title.Text, txtSch_Lec.Text, txtSch_Lab.Text, txtSch_Day.Text, txtSch_Time.Text,
                    txtSch_Room.Text, cbSch_Year.Text, ID_Sch_Schedule));
                MessageBox.Show("Subject Schedule successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_Sch();
                display_subject_time();
            }
        }

        private void btnSch_Delete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID_Sch_Schedule) || String.IsNullOrWhiteSpace(ID_Sch_Schedule))
            {
                MessageBox.Show("Select information to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (MessageBox.Show(this, "Are you sure you want to delete this Schedule?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("delete from tbl_subject_schedule where ID = '{0}'", ID_Sch_Schedule));
                        MessageBox.Show("Schedule successfully deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        display_subject_time();
                        clear_Sch();
                        break;

                    default:
                        break;
                }
            }
        }

        private void txtSch_Code_Leave(object sender, EventArgs e)
        {
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Code = '{0}'",txtSch_Code.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                txtSch_Title.Text = DBMysql.reader.GetString(5);
                txtSch_Lec.Text = DBMysql.reader.GetString(6);
                txtSch_Lab.Text = DBMysql.reader.GetString(7);
                cbSch_Year.Text = DBMysql.reader.GetString(2);
            }
            DBMysql.con.Close();
        }
    }
}
