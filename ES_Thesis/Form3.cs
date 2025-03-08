using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ES_Thesis
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please input the password", "Security", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int check_key = 0;
                DBSqlite.con.Close();
                DBSqlite.cmd = new SQLiteCommand(String.Format("select * from tbl_encrypt where Passkey = '{0}'",txtPassword.Text), DBSqlite.con);
                DBSqlite.con.Open();
                DBSqlite.reader = DBSqlite.cmd.ExecuteReader();
                while (DBSqlite.reader.Read())
                {
                    if (DBSqlite.reader.HasRows == true) { check_key = 1; }
                }
                DBSqlite.con.Close();

                if (check_key == 1)
                {
                    Global.check_confirmation = 1;
                    Global.check_form_confirm = 1;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Passkey.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
