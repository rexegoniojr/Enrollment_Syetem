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
    public partial class frm_history : Form
    {
        public frm_history()
        {
            InitializeComponent();
            data_cb();
            lblName.Text = "Name: " + PaymentData.name;
            lblsem.Text = "Semester: " + PaymentData.semester;
            lblID.Text = "ID: " + PaymentData.id;
            lblCourse.Text = "Course: " + PaymentData.course;
            lblStatus.Text = "Status: " + PaymentData.status;
            lblSy.Text = "SY: " + PaymentData.sy;
        }

        private double amount_bal()
        {
            double total = 0;if (cb_Year.Text != String.Empty)
            {
                total = Convert.ToDouble(DBMysql.data(String.Format("select * from tbl_stud_bal where stud_ID = '{0}' and Year = '{1}'",
                PaymentData.id, cb_Year.Text), 3));
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where Year = '{0}' and stud_ID = '{1}'", PaymentData.year, PaymentData.id)
                , DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    total += Convert.ToDouble(DBMysql.reader.GetString(3));
                }
                DBMysql.con.Close();
            }

            return total;
        }

        private void data_cb()
        {
            cb_Year.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_reg_form where Sub_ID ='{0}'", PaymentData.id), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (cb_Year.Items.Contains(DBMysql.reader.GetString(6)) == false) { cb_Year.Items.Add(DBMysql.reader.GetString(6)); }
            }
            DBMysql.con.Close();
        }

        private void cb_AYear_TextChanged(object sender, EventArgs e)
        {
            if (cb_Year.Text != String.Empty)
            {
                double x = Convert.ToDouble(DBMysql.data(String.Format("select * from tbl_stud_bal where stud_ID = '{0}' and Year = '{1}'",
                PaymentData.id, cb_Year.Text), 3));
                double total_amount = 0;
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where SY = '{0}' and Year = '{1}' and stud_ID = '{2}'"
                , PaymentData.sy, PaymentData.year, PaymentData.id), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    total_amount += Convert.ToDouble(DBMysql.reader.GetString(3));
                }
                DBMysql.con.Close();
                x += total_amount;
                lstHistory.Items.Clear();
                ListViewItem blank = new ListViewItem(new[] { " ", "Total Payment", " ", x.ToString()," "," "});
                blank.BackColor = Color.Silver;
                lstHistory.Items.Add(blank);
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where SY = '{0}' and Year = '{1}' and stud_ID = '{2}'"
                , PaymentData.sy, PaymentData.year, PaymentData.id), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                    item.SubItems.Add(DBMysql.reader.GetString(4));
                    item.SubItems.Add(DBMysql.reader.GetString(3));
                    item.SubItems.Add(Convert.ToString(x-=Convert.ToDouble(DBMysql.reader.GetString(3))));
                    lstHistory.Items.Add(item);
                }
                DBMysql.con.Close();
            }
            else if (cb_Year.Text != String.Empty)
            {
                lstHistory.Items.Clear();
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where Year = '{0}' and stud_ID = '{1}'", PaymentData.year, PaymentData.id)
                , DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                    item.SubItems.Add(DBMysql.reader.GetString(4));
                    item.SubItems.Add(DBMysql.reader.GetString(3));
                    item.SubItems.Add(DBMysql.reader.GetString(4));
                }
                DBMysql.con.Close();
            }
            else
            {
                lstHistory.Items.Clear();
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where stud_ID = '{0}'", PaymentData.id), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                    item.SubItems.Add(DBMysql.reader.GetString(4));
                    item.SubItems.Add(DBMysql.reader.GetString(3));
                    item.SubItems.Add(DBMysql.reader.GetString(4));
                }
                DBMysql.con.Close();
            }
        }
    }
}
