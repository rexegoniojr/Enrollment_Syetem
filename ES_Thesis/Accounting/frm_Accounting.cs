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

namespace ES_Thesis.Accounting
{
    public partial class frm_Accounting : Form
    {
        public frm_Accounting()
        {
            InitializeComponent();
        }

        private void frm_Accounting_Load(object sender, EventArgs e)
        {

        }

        private void frm_Accounting_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                default:
                    break;
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

        frm_Students fstud;
        private void btnEForm_Click(object sender, EventArgs e)
        {
            if (fstud == null || fstud.IsDisposed)
            {
                fstud = new frm_Students();
                fstud.Show();
            }
            else
            {
                fstud.BringToFront();
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

        frm_MyAccount acc;
        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            if (acc == null || acc.IsDisposed)
            {
                acc = new frm_MyAccount();
                acc.Show();
            }
            else
            {
                acc.BringToFront();
            }
        }
    }
}
