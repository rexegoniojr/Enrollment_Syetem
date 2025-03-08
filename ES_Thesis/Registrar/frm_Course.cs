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
    public partial class frm_Course : Form
    {
        public frm_Course()
        {
            InitializeComponent();
        }

        List<String> list_year = new List<String>();
        String[] list_sem = { "1st Semester", "2nd Semester" };
        private void display_course()
        {
            list_year.Clear();
            lstCourses.Items.Clear();

            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Course = '{0}' order by Year asc", txtC_Course.Text), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (list_year.Contains(DBMysql.reader.GetString(2)) == false)
                {
                    list_year.Add(DBMysql.reader.GetString(2));
                }
            }
            DBMysql.con.Close();
            try
            {
                for (int i = 0; i < list_year.Count; i++)
                {
                    if (list_year.Count != 0)
                    {
                        for (int x = 0; x < list_sem.Length; x++)
                        {
                            int lec = 0, lab = 0, total = 0;
                            DBMysql.con.Close();
                            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_course_list where Year = '{0}'and Semester = '{1}' and Course = '{2}'",
                            list_year[i], list_sem[x], txtC_Course.Text), DBMysql.con);
                            DBMysql.con.Open();
                            DBMysql.reader = DBMysql.cmd.ExecuteReader();
                            while (DBMysql.reader.Read())
                            {
                                ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                                item.SubItems.Add(DBMysql.reader.GetString(4));
                                item.SubItems.Add(DBMysql.reader.GetString(5));
                                item.SubItems.Add(DBMysql.reader.GetString(6));
                                item.SubItems.Add(DBMysql.reader.GetString(7));
                                item.SubItems.Add(DBMysql.reader.GetString(8));
                                item.SubItems.Add(DBMysql.reader.GetString(2));
                                item.SubItems.Add(DBMysql.reader.GetString(3));
                                lstCourses.Items.Add(item);
                                lec += Convert.ToInt32(DBMysql.reader.GetString(6));
                                lab += Convert.ToInt32(DBMysql.reader.GetString(7));
                            }
                            total = lec + lab;
                            ListViewItem blank = new ListViewItem(new[] { " ", "Total", " ", lec.ToString(), lab.ToString(), total.ToString(), " ", list_sem[x] });
                            blank.BackColor = Color.Silver;
                            lstCourses.Items.Add(blank);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void clear_C()
        {
            txtC_Code.Clear(); txtC_DTitle.Clear(); txtC_LAB.Clear(); txtC_LEC.Clear(); txtC_Req.Clear(); rbC_1st.Checked = false; rbC_2nd.Checked = false; cbC_Year.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String ID = Global.data(20);
            int check_Id = 0;
            String Sem = String.Empty;
            if (rbC_1st.Checked == true) { Sem = "1st Semester"; }
            if (rbC_2nd.Checked == true) { Sem = "2nd Semester"; }
            if (String.IsNullOrEmpty(cbC_Year.Text) || String.IsNullOrWhiteSpace(cbC_Year.Text))
            {
                MessageBox.Show("Please select year to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(Sem) || String.IsNullOrWhiteSpace(Sem))
            {
                MessageBox.Show("Please select Semester to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_Code.Text) || String.IsNullOrWhiteSpace(txtC_Code.Text))
            {
                MessageBox.Show("Please fillup CourseCode to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_DTitle.Text) || String.IsNullOrWhiteSpace(txtC_DTitle.Text))
            {
                MessageBox.Show("Please fillup Descriptive Title to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_LEC.Text) || String.IsNullOrWhiteSpace(txtC_LEC.Text))
            {
                MessageBox.Show("Please fillup LEC to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_LAB.Text) || String.IsNullOrWhiteSpace(txtC_LAB.Text))
            {
                MessageBox.Show("Please fillup LAB to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_Req.Text) || String.IsNullOrWhiteSpace(txtC_Req.Text))
            {
                MessageBox.Show("Please fillup Pre-req to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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

                if (check_Id == 0)
                {
                    DBMysql.SQL(String.Format("insert into tbl_course_list(ID,Course,Year,Semester,Code,Title,LEC,LAB,Req)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                    ID, txtC_Course.Text, cbC_Year.Text, Sem, txtC_Code.Text, txtC_DTitle.Text, txtC_LEC.Text, txtC_LAB.Text, txtC_Req.Text));
                    MessageBox.Show("Course Subject Successfully Added.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_C();
                    Sem = String.Empty;
                    display_course();
                }
            }
        }

        private void txtC_Course_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtC_Course.Text) || String.IsNullOrWhiteSpace(txtC_Course.Text)) { clear_C(); lstCourses.Items.Clear(); }
            else
            {
                display_course();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Sem = String.Empty;
            if (rbC_1st.Checked == true) { Sem = "1st Semester"; }
            if (rbC_2nd.Checked == true) { Sem = "2nd Semester"; }
            if (String.IsNullOrEmpty(cbC_Year.Text) || String.IsNullOrWhiteSpace(cbC_Year.Text))
            {
                MessageBox.Show("Please select year to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(Sem) || String.IsNullOrWhiteSpace(Sem))
            {
                MessageBox.Show("Please select Semester to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_Code.Text) || String.IsNullOrWhiteSpace(txtC_Code.Text))
            {
                MessageBox.Show("Please fillup CourseCode to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_DTitle.Text) || String.IsNullOrWhiteSpace(txtC_DTitle.Text))
            {
                MessageBox.Show("Please fillup Descriptive Title to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_LEC.Text) || String.IsNullOrWhiteSpace(txtC_LEC.Text))
            {
                MessageBox.Show("Please fillup LEC to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_LAB.Text) || String.IsNullOrWhiteSpace(txtC_LAB.Text))
            {
                MessageBox.Show("Please fillup LAB to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtC_Req.Text) || String.IsNullOrWhiteSpace(txtC_Req.Text))
            {
                MessageBox.Show("Please fillup Pre-req to add information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (course_ID != String.Empty)
                {
                    DBMysql.SQL(String.Format("update tbl_course_list set Year = '{0}', Semester = '{1}', Code = '{2}', Title = '{3}', LEC = '{4}', LAB = '{5}', Req = '{6}' where ID = '{7}'",
                    cbC_Year.Text, Sem, txtC_Code.Text, txtC_DTitle.Text, txtC_LEC.Text, txtC_LAB.Text, txtC_Req.Text, course_ID));
                    MessageBox.Show("Course Subject Successfully Updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_C();
                    Sem = String.Empty;
                    display_course();
                }
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (course_ID != String.Empty)
            {
                switch (MessageBox.Show(this, "Are you sure you want to delete this Course Subject?", "Conferm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("delete from tbl_course_list where ID = '{0}'", course_ID));
                        MessageBox.Show("Course Subject Successfully Deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        course_ID = String.Empty;
                        clear_C();
                        display_course();
                        break;

                    default:
                        break;
                }
            }
        }

        String course_ID = String.Empty;
        private void lstCourses_Click(object sender, EventArgs e)
        {
            course_ID = String.Empty;
            if (lstCourses.FocusedItem.SubItems[0].Text != " ")
            {
                course_ID = lstCourses.FocusedItem.SubItems[0].Text;
                txtC_Code.Text = lstCourses.FocusedItem.SubItems[1].Text;
                txtC_DTitle.Text = lstCourses.FocusedItem.SubItems[2].Text;
                txtC_LEC.Text = lstCourses.FocusedItem.SubItems[3].Text;
                txtC_LAB.Text = lstCourses.FocusedItem.SubItems[4].Text;
                txtC_Req.Text = lstCourses.FocusedItem.SubItems[5].Text;
                cbC_Year.Text = lstCourses.FocusedItem.SubItems[6].Text;
                if (lstCourses.FocusedItem.SubItems[7].Text == "1st Semester") { rbC_1st.Checked = true; }
                else { rbC_2nd.Checked = true; }
            }
            else
            {
                clear_C();
            }
        }
    }
}
