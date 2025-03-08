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
    public partial class frm_Students : Form
    {
        public frm_Students()
        {
            InitializeComponent();
            display_students();
        }

        List<String> course = new List<String>();
        private void display_students()
        {
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand("select * from tbl_Personal_Info order by Program asc", DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (course.Contains(DBMysql.reader.GetString(4)) == false)
                {
                    course.Add(DBMysql.reader.GetString(4));
                }
            }
            DBMysql.con.Close();
            lstStudents.Items.Clear();
            for (int i = 0; i < course.Count; i++)
            {
                ListViewItem blank = new ListViewItem(new[] { " ", " ", course[i], " ", " ", " ", " " });
                blank.BackColor = Color.Silver;
                lstStudents.Items.Add(blank);
                String[] gen = { "Male", "Female" };
                for (int x = 0; x < gen.Length; x++)
                {
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_Personal_Info where Program = '{0}' and Gender= '{1}' order by LN asc, Program asc",
                    course[i], gen[x]), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader = DBMysql.cmd.ExecuteReader();
                    while (DBMysql.reader.Read())
                    {
                        ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                        item.SubItems.Add(DBMysql.reader.GetString(13));
                        item.SubItems.Add(String.Format("{0}, {1} {2}", DBMysql.reader.GetString(1), DBMysql.reader.GetString(2), DBMysql.reader.GetString(3)));
                        item.SubItems.Add(DBMysql.reader.GetString(4));
                        item.SubItems.Add(DBMysql.reader.GetString(8));
                        item.SubItems.Add(DBMysql.reader.GetString(6));
                        item.SubItems.Add(DBMysql.reader.GetString(10));
                        lstStudents.Items.Add(item);
                    }
                    DBMysql.con.Close();
                }
            }
        }

        private void auto_complete_search()
        {
            txtStudent_Search.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtStudent_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand("select * from tbl_Personal_Info", DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                col.Add(DBMysql.reader.GetString(13));
                col.Add(DBMysql.reader.GetString(1));
                col.Add(DBMysql.reader.GetString(2));
                col.Add(DBMysql.reader.GetString(4));
            }
            DBMysql.con.Close();
            txtStudent_Search.AutoCompleteCustomSource = col;
        }

        Registrar.frm_student_info info;
        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lstStudents.FocusedItem.SubItems[0].Text) || String.IsNullOrWhiteSpace(lstStudents.FocusedItem.SubItems[0].Text))
            {
                //Do Nothing
            }
            else
            {
                if (String.IsNullOrEmpty(Global.stud_info) || String.IsNullOrWhiteSpace(Global.stud_info))
                {
                    Global.stud_info = lstStudents.FocusedItem.SubItems[0].Text;
                    if (info == null || info.IsDisposed)
                    {
                        info = new Registrar.frm_student_info();
                        info.Show();
                    }
                    else
                    {
                        info.BringToFront();
                    }
                }
            }
        }
    }
}
