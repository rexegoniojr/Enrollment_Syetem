using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ES_Thesis.Chat;
using System.Diagnostics;


namespace ES_Thesis.Admin
{
    public partial class frm_Admin : Form
    {

        public frm_Admin()
        {
            InitializeComponent();
        }
        frm_Students stud;
        private void btnStudent_Click(object sender, EventArgs e)
        {
            stud = new Admin.frm_Students();
            if (stud == null || stud.IsDisposed || !stud.Visible)
            {
                stud.Show();
            }
            else
            {
                stud.BringToFront();
            }
        }

        frm_Schedule sched;
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sched = new Admin.frm_Schedule();
            if (sched == null || sched.IsDisposed || !sched.Visible)
            {
                sched.Show();
            }
            else
            {
                sched.BringToFront();
            }
        }

        frm_Accounts acc;
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            acc = new Admin.frm_Accounts();
            if (acc == null || acc.IsDisposed || !acc.Visible)
            {
                acc.Show();
            }
            else
            {
                acc.BringToFront();
            }
        }

        frm_MyAccount myaccount;
        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            myaccount = new Admin.frm_MyAccount();
            if (myaccount == null || myaccount.IsDisposed || !myaccount.Visible)
            {
                myaccount.Show();
            }
            else
            {
                myaccount.BringToFront();
            }
        }

        frm_files ff;
        private void btnMS_Click(object sender, EventArgs e)
        {
            if (ff == null || ff.IsDisposed)
            {
                ff = new frm_files();
                ff.Show();
            }
            else
            {
                ff.BringToFront();
            }
        }

        Form1 login;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    login = new Form1();
                    login.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
        }

        private void frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DBMysql.SQL(String.Format("update tbl_chat_stat set status = '{0}', IP = '{1}' where ID = '{2}'", "0", " ", 1));
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
