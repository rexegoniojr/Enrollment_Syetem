using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace ES_Thesis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public void EndTask(string taskname)
        {
            string processName = taskname;
            string fixstring = taskname.Replace(".exe", "");

            if (taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(fixstring))
                {
                    process.Kill();
                }
            }
            else if (!taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                }
            }
        }

        ES_Thesis.Admin.frm_Admin admin;
        Registrar.frm_Registrar regist;
        Accounting.frm_Accounting acc;
        private void button1_Click(object sender, EventArgs e)
        {
            DBMysql.con_cmd();
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Please input your Username.";
                lblError.ForeColor = Color.Red;
                lblError.Visible = true;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Please input your Password.";
                lblError.ForeColor = Color.Red;
                lblError.Visible = true;
            }
            else
            {
                String department = String.Empty, status = String.Empty;
                int check_account = 0;
                DBMysql.con.Close();
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_accounts where username = '{0}' and password = '{1}'",
                    txtUsername.Text, txtPassword.Text), DBMysql.con);
                DBMysql.con.Open();
                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                while (DBMysql.reader.Read())
                {
                    if (DBMysql.reader.HasRows == true)
                    {
                        check_account = 1;
                        department = DBMysql.reader.GetString(5);
                        Global.ID = DBMysql.reader.GetString(0);
                        status = DBMysql.reader.GetString(11);
                        Global.FName = DBMysql.reader.GetString(1);
                    }
                }
                DBMysql.con.Close();

                if (check_account == 1)
                {
                    lblError.Visible = false;
                    if (status == "Activate")
                    {
                        if (department == "Administrator")
                        {
                            admin = new ES_Thesis.Admin.frm_Admin();
                            admin.Show();
                            this.Hide();
                        }
                        else if (department == "Registrar")
                        {
                            regist = new Registrar.frm_Registrar();
                            regist.Show();
                            this.Hide();
                        }
                        else
                        {
                            acc = new Accounting.frm_Accounting();
                            acc.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        lblError.Text = "Your account is deactivated.";
                        lblError.ForeColor = Color.Turquoise;
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "You entered an invalid account.";
                    lblError.ForeColor = Color.Red;
                    lblError.Visible = true;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DBMysql.SQL(String.Format("update tbl_chat_stat set status = '{0}', IP = '{1}' where ID = '{2}'", "0", " ", 1));
                    EndTask("Server");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        Form2 config_DBMysql;
        private void lblConfig_Click(object sender, EventArgs e)
        {
            config_DBMysql = new Form2();
            config_DBMysql.Show();
            this.Hide();
        }
    }
}
