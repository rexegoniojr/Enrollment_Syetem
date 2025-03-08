 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ES_Thesis.Accounting
{
    public partial class frm_Students : Form
    {
        public frm_Students()
        {
            InitializeComponent();
            load_SY_data();
        }

        public void load_SY_data()
        {
            cb_AYear.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_Student_fee order by SY"), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (cb_AYear.Items.Contains(DBMysql.reader.GetString(16)) == false) { cb_AYear.Items.Add(DBMysql.reader.GetString(16)); }
            }
            DBMysql.con.Close();
        }

        private void TxtNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        frm_Payment py;
        String ID = String.Empty, stud_ID = String.Empty;
        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lstStudents.FocusedItem.SubItems[0].Text) == false || String.IsNullOrWhiteSpace(lstStudents.FocusedItem.SubItems[0].Text) == false)
            {
                ID = lstStudents.FocusedItem.SubItems[0].Text;
                stud_ID = lstStudents.FocusedItem.SubItems[1].Text;
                PaymentData.id = lstStudents.FocusedItem.SubItems[1].Text;
                PaymentData.name = lstStudents.FocusedItem.SubItems[2].Text;
                PaymentData.course = lstStudents.FocusedItem.SubItems[3].Text;
                PaymentData.semester = lstStudents.FocusedItem.SubItems[5].Text;
                PaymentData.sy = cb_AYear.Text;
                PaymentData.status = DBMysql.data(String.Format("select * from tbl_reg_form where Sub_ID = '{0}' and AYear = '{1}' and Semester = '{2}'",
                lstStudents.FocusedItem.SubItems[1].Text, cb_AYear.Text, lstStudents.FocusedItem.SubItems[5].Text), 5);
                PaymentData.year = DBMysql.data(String.Format("select * from tbl_reg_form where AYear = '{0}' and Semester = '{1}' and Sub_ID = '{2}'", cb_AYear.Text,
                lstStudents.FocusedItem.SubItems[5].Text, lstStudents.FocusedItem.SubItems[1].Text), 6);
                py = new frm_Payment();
                py.Show();
            }
        }

        private void cb_AYear_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudent_Search.Text) || String.IsNullOrWhiteSpace(txtStudent_Search.Text))
            {
                display();
            }
            else
            {
                lstStudents.Items.Clear();
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_Student_fee where SY = '{0}' and stud_Name like '%{1}%' or stud_ID like '%{1}%'"
                + " order by stud_Name, course, year, semester", cb_AYear.Text, txtStudent_Search.Text), DBMysql.con);
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
                    item.SubItems.Add(DBMysql.reader.GetString(16));
                    item.SubItems.Add(DBMysql.reader.GetString(15));
                    lstStudents.Items.Add(item);
                    if (cb_AYear.Items.Contains(DBMysql.reader.GetString(16)) == false) { cb_AYear.Items.Add(DBMysql.reader.GetString(16)); }
                }
                DBMysql.con.Close();
            }
        }

        List<String> course = new List<String>();
        private void display()
        {
            lstStudents.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_Student_fee where SY = '{0}' order by stud_Name, course, year, semester", cb_AYear.Text), DBMysql.con);
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
                item.SubItems.Add(DBMysql.reader.GetString(16));
                item.SubItems.Add(DBMysql.reader.GetString(15));
                lstStudents.Items.Add(item);
                if (cb_AYear.Items.Contains(DBMysql.reader.GetString(16)) == false) { cb_AYear.Items.Add(DBMysql.reader.GetString(16)); }
            }
            DBMysql.con.Close();
        }
    }
}
