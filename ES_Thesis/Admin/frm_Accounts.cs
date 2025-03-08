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
    public partial class frm_Accounts : Form
    {
        public frm_Accounts()
        {
            InitializeComponent();
            display_accounts();
        }

        private void display_accounts()
        {
            lstAccount.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_accounts where ID != '{0}' order by LN, Department",1), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                item.SubItems.Add(String.Format("{0} {3}, {1} {2} ",DBMysql.reader.GetString(3),DBMysql.reader.GetString(1),
                DBMysql.reader.GetString(2),DBMysql.reader.GetString(4)));
                item.SubItems.Add(DBMysql.reader.GetString(5));
                item.SubItems.Add(DBMysql.reader.GetString(6));
                item.SubItems.Add(DBMysql.reader.GetString(7));
                item.SubItems.Add(DBMysql.reader.GetString(8));
                item.SubItems.Add(DBMysql.reader.GetString(9));
                item.SubItems.Add(DBMysql.reader.GetString(10));
                item.SubItems.Add(DBMysql.reader.GetString(11));
                lstAccount.Items.Add(item);
            }
            DBMysql.con.Close();
        }

        private void TxtNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
            txtAge.Clear(); txtBday.ResetText(); txtCon.Clear(); txtFN.Clear(); txtLN.Clear(); txtMI.Clear(); txtPass.Clear(); txtPF.Clear(); txtUser.Clear();
            cb_Dep.ResetText(); user_ID = String.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFN.Text) || String.IsNullOrWhiteSpace(txtFN.Text))
            {
                MessageBox.Show("Please input First Name of the user.","Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtLN.Text) || String.IsNullOrWhiteSpace(txtLN.Text))
            {
                MessageBox.Show("Please input Last Name of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_Dep.Text) || String.IsNullOrWhiteSpace(cb_Dep.Text))
            {
                MessageBox.Show("Please select the department of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_Dep.Text) || String.IsNullOrWhiteSpace(cb_Dep.Text))
            {
                MessageBox.Show("Please input the username the department of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_Dep.Text) || String.IsNullOrWhiteSpace(cb_Dep.Text))
            {
                MessageBox.Show("Please input the password the department of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_status.Text) || String.IsNullOrWhiteSpace(cb_status.Text))
            {
                MessageBox.Show("Please select status for the account of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPass.TextLength <= 7)
            {
                MessageBox.Show("Password length atleast 8 characters.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int check_username = 0;
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_accounts where username = '{0}'", txtUser.Text), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    if (DBMysql.reader.HasRows == true) { check_username = 1; }
                }
                DBMysql.con.Close();

                if (check_username == 1)
                {
                    MessageBox.Show("Username is already taken. Please try other username.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    String ID = Global.data(20);
                    DBMysql.SQL(String.Format("insert into tbl_accounts(ID,FN,MI,LN,PF,Department,Birthday,Age,Contact,username,password,status)values" +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", ID, txtFN.Text, txtMI.Text, txtLN.Text, txtPF.Text, cb_Dep.Text, txtBday.Text, txtAge.Text,
                    txtCon.Text, txtUser.Text, txtPass.Text, cb_status.Text));
                    MessageBox.Show("Account is ready to use.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_text();
                    display_accounts();
                }
            }
        }

        String user_ID = String.Empty;
        private void lstAccount_Click(object sender, EventArgs e)
        {
            user_ID = lstAccount.FocusedItem.SubItems[0].Text;
            display_data(lstAccount.FocusedItem.SubItems[0].Text);
        }

        String user_check = String.Empty;
        private void display_data(String ID)
        {
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_accounts where ID = '{0}'", ID), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                txtFN.Text = DBMysql.reader.GetString(1);
                txtMI.Text = DBMysql.reader.GetString(2);
                txtLN.Text = DBMysql.reader.GetString(3);
                txtPF.Text = DBMysql.reader.GetString(4);
                cb_Dep.Text = DBMysql.reader.GetString(5);
                txtBday.Text = DBMysql.reader.GetString(6);
                txtAge.Text = DBMysql.reader.GetString(7);
                txtCon.Text = DBMysql.reader.GetString(8);
                txtUser.Text = DBMysql.reader.GetString(9);
                txtPass.Text = DBMysql.reader.GetString(10);
                cb_status.Text = DBMysql.reader.GetString(11);
                user_check = DBMysql.reader.GetString(9);
            }
            DBMysql.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user_ID) || String.IsNullOrWhiteSpace(user_ID))
            {
                MessageBox.Show("Select data to update.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtFN.Text) || String.IsNullOrWhiteSpace(txtFN.Text))
            {
                MessageBox.Show("Please input First Name of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtLN.Text) || String.IsNullOrWhiteSpace(txtLN.Text))
            {
                MessageBox.Show("Please input Last Name of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_Dep.Text) || String.IsNullOrWhiteSpace(cb_Dep.Text))
            {
                MessageBox.Show("Please select the department of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_Dep.Text) || String.IsNullOrWhiteSpace(cb_Dep.Text))
            {
                MessageBox.Show("Please input the username the department of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_Dep.Text) || String.IsNullOrWhiteSpace(cb_Dep.Text))
            {
                MessageBox.Show("Please input the password the department of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(cb_status.Text) || String.IsNullOrWhiteSpace(cb_status.Text))
            {
                MessageBox.Show("Please select status for the account of the user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (user_check == txtUser.Text)
                {
                    DBMysql.SQL(String.Format("update tbl_accounts set FN = '{1}', MI = '{2}', LN = '{3}', PF = '{4}', Department = '{5}', Birthday = '{6}', Age = '{7}'," +
                    "Contact = '{8}', username = '{9}', password = '{10}', Status = '{11}' where ID = '{0}'", user_ID, txtFN.Text, txtMI.Text, txtLN.Text, txtPF.Text, cb_Dep.Text, txtBday.Text, txtAge.Text,
                    txtCon.Text, txtUser.Text, txtPass.Text, cb_status.Text));
                    MessageBox.Show("User Account successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_text();
                    display_accounts();
                }
                else
                {
                    int check_username = 0;
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_accounts where username = '{0}'", txtUser.Text), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader = DBMysql.cmd.ExecuteReader();
                    while (DBMysql.reader.Read())
                    {
                        if (DBMysql.reader.HasRows == true) { check_username = 1; }
                    }
                    DBMysql.con.Close();

                    if (check_username == 1)
                    {
                        MessageBox.Show("Username is already taken. Please try other username.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DBMysql.SQL(String.Format("update tbl_accounts set FN = '{1}', MI = '{2}', LN = '{3}', PF = '{4}', Department = '{5}', Birthday = '{6}', Age = '{7}'," +
                        "Contact = '{8}', username = '{9}', password = '{10}', Status = '{11}' where ID = '{0}'", user_ID, txtFN.Text, txtMI.Text, txtLN.Text, txtPF.Text, cb_Dep.Text, txtBday.Text, txtAge.Text,
                        txtCon.Text, txtUser.Text, txtPass.Text, cb_status.Text));
                        MessageBox.Show("User Account successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_text();
                        display_accounts();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user_ID) || String.IsNullOrWhiteSpace(user_ID))
            {
                MessageBox.Show("Select data to update.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch(MessageBox.Show(this,"Are you sure you want to delete this user account?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                         DBMysql.SQL(String.Format("delete from tbl_accounts where ID = '{0}'", user_ID));
                        MessageBox.Show("User Account successfully deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_text();
                        display_accounts();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
