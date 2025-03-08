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

namespace ES_Thesis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 login;
        private void btnBack_Click(object sender, EventArgs e)
        {
            Global.check_confirmation = 0;
            Global.check_form_confirm = 0;
            login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DBSqlite.con.Close();
            DBSqlite.cmd = new SQLiteCommand(String.Format("select * from tbl_database where ID = '{0}'", 1), DBSqlite.con);
            DBSqlite.con.Open();
            DBSqlite.reader = DBSqlite.cmd.ExecuteReader();
            while (DBSqlite.reader.Read())
            {
                txtServer.Text = DBSqlite.reader.GetString(1);
                txtDatabase.Text = DBSqlite.reader.GetString(2);
                txtPort.Text = DBSqlite.reader.GetString(3);
                txtUsername.Text = DBSqlite.reader.GetString(4);
                txtPassword.Text = DBSqlite.reader.GetString(5);
            }
            DBSqlite.con.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int check_error = 0;
            DBMysql.connnect(txtServer.Text, txtDatabase.Text, txtPort.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                DBMysql.con.Open();
                MessageBox.Show("Database successfully CONNECTED.", "CONNECTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check_error = 0;
                DBMysql.con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Handled. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check_error = 1;
                DBMysql.con.Close();
            }

            if (check_error == 0)
            {
                int check_data = 0;
                DBSqlite.con.Close();
                DBSqlite.cmd = new SQLiteCommand(String.Format("select * from tbl_database where ID = '{0}'", 1), DBSqlite.con);
                DBSqlite.con.Open();
                DBSqlite.reader = DBSqlite.cmd.ExecuteReader();
                while (DBSqlite.reader.Read())
                {
                    if (DBSqlite.reader.HasRows == true)
                    {
                        check_data = 1;
                    }
                }
                DBSqlite.con.Close();

                if (check_data == 1)
                {
                    DBSqlite.SQL(String.Format("update tbl_database set server = '{0}', database = '{1}', port = '{2}', username = '{3}', password = '{4}'",
                                    txtServer.Text, txtDatabase.Text, txtPort.Text, txtUsername.Text, txtPassword.Text));
                }
                else
                {
                    DBSqlite.SQL(String.Format("insert into tbl_database(server,database,port,username,password)values('{0}','{1}','{2}','{3}','{4}')",
                    txtServer.Text, txtDatabase.Text, txtPort.Text, txtUsername.Text, txtPassword.Text));
                }
            }
        }

        private void t_check_Tick(object sender, EventArgs e)
        {
            if (Global.check_confirmation == 1)
            {
                txtDatabase.ReadOnly = false; txtDatabase.UseSystemPasswordChar = false;
                txtPassword.ReadOnly = false; txtPassword.UseSystemPasswordChar = false;
                txtPort.ReadOnly = false; txtPort.UseSystemPasswordChar = false;
                txtServer.ReadOnly = false; txtServer.UseSystemPasswordChar = false;
                txtUsername.ReadOnly = false; txtUsername.UseSystemPasswordChar = false;
            }
            else
            {
                txtDatabase.ReadOnly = true; txtDatabase.UseSystemPasswordChar = true;
                txtPassword.ReadOnly = true; txtPassword.UseSystemPasswordChar = true;
                txtPort.ReadOnly = true; txtPort.UseSystemPasswordChar = true;
                txtServer.ReadOnly = true; txtServer.UseSystemPasswordChar = true;
                txtUsername.ReadOnly = true; txtUsername.UseSystemPasswordChar = true;
            }
        }

        Form3 confirmation;
        private void txtServer_Click(object sender, EventArgs e)
        {
            if (Global.check_form_confirm == 0)
            {
                confirmation = new Form3();
                confirmation.ShowDialog();
            }
        }
    }
}
