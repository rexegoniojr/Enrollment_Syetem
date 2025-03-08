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
    public partial class frm_MyAccount : Form
    {
        public frm_MyAccount()
        {
            InitializeComponent();
        }

        private void btnSave_acc_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAcc_oldPass.Text) || String.IsNullOrWhiteSpace(txtAcc_oldPass.Text))
            {
                lblChecker.Text = "Please input your old password.";
                lblChecker.ForeColor = Color.Red;
                lblChecker.Visible = true;
            }
            else if (String.IsNullOrEmpty(txtAcc_newPass.Text) || String.IsNullOrWhiteSpace(txtAcc_newPass.Text))
            {
                lblChecker.Text = "Please input your new password.";
                lblChecker.ForeColor = Color.Red;
                lblChecker.Visible = true;
            }
            else if (txtAcc_newPass.Text != txtAcc_conPass.Text)
            {
                lblChecker.Text = "Password did'nt match. Please try again.";
                lblChecker.ForeColor = Color.Red;
                lblChecker.Visible = true;
            }
            else if(txtAcc_newPass.TextLength <= 7 || txtAcc_conPass.TextLength <= 7)
            {
                lblChecker.Text = "Password length atleast 8 characters.";
                lblChecker.ForeColor = Color.Red;
                lblChecker.Visible = true;
            }
            else
            {
                int check_password = 0;
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_accounts where ID = '{0}' and password = '{1}'", Global.ID, txtAcc_oldPass.Text), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    if (DBMysql.reader.HasRows == true) { check_password = 1; }
                }
                DBMysql.con.Close();

                if (check_password == 0)
                {
                    lblChecker.Text = "Old password did'nt match. Please try again.";
                    lblChecker.ForeColor = Color.Red;
                    lblChecker.Visible = true;
                }
                else
                {
                    DBMysql.SQL(String.Format("update tbl_accounts set password = '{0}' where ID = '{1}'", txtAcc_newPass.Text, Global.ID));
                    txtAcc_conPass.Clear(); txtAcc_newPass.Clear(); txtAcc_oldPass.Clear();
                    lblChecker.Text = "Password successfully updated.";
                    lblChecker.ForeColor = Color.Green;
                    lblChecker.Visible = true;
                }
            }
        }
    }
}
