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

namespace ES_Thesis.Registrar
{
    public partial class frm_Registrar : Form
    {
        public frm_Registrar()
        {
            InitializeComponent();
        }

        frm_EForm eform;
        private void btnEForm_Click(object sender, EventArgs e)
        {
            if (eform == null || eform.IsDisposed)
            {
                eform = new frm_EForm();
                eform.Show();
            }
            else
            {
                eform.BringToFront();
            }
        }

        Form1 login;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            switch(MessageBox.Show(this,"Are you sure you want to logout?","Confirm Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
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

        frm_Students stud;
        private void btnStudents_Click(object sender, EventArgs e)
        {
            if (stud == null || stud.IsDisposed)
            {
                stud = new frm_Students();
                stud.Show();
            }
            else
            {
                stud.BringToFront();
            }
        }

        frm_Course course;
        private void btnCourse_Click(object sender, EventArgs e)
        {
            if (course == null || course.IsDisposed)
            {
                course = new frm_Course();
                course.Show();
            }
            else
            {
                course.BringToFront();
            }
        }

        frm_MyAccount myaccount;
        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            if (myaccount == null || myaccount.IsDisposed)
            {
                myaccount = new frm_MyAccount();
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

        private void frm_Registrar_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_Registrar_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
