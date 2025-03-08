using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ES_Thesis
{
    public partial class frm_files : Form
    {
        public frm_files()
        {
            InitializeComponent();
            display_files(Global.ID);
        }

        private void display_files(String ID)
        {
            lstfile.Items.Clear();
            DBMysql.con.Close();
            if (ID == "1")
            {
                DBMysql.cmd = new MySqlCommand("select * from tbl_files", DBMysql.con);
            }
            else
            {
                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_files where acc_ID = '{0}'", ID), DBMysql.con);
            }
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                item.SubItems.Add(DBMysql.reader.GetString(2));
                item.SubItems.Add(DBMysql.reader.GetString(3));
                item.SubItems.Add(DBMysql.reader.GetString(4));
                item.SubItems.Add(DBMysql.reader.GetString(6));
                lstfile.Items.Add(item);
            }
            DBMysql.con.Close();
        }

        String ff_ID = String.Empty;
        private void lstfile_Click(object sender, EventArgs e)
        {
            ff_ID = lstfile.FocusedItem.SubItems[0].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to delete this file?", "confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DBMysql.SQL(String.Format("delete from tbl_files where ID = '{0}'", ff_ID));
                    display_files(Global.ID);
                    MessageBox.Show("File successfully deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ff_ID) || String.IsNullOrWhiteSpace(ff_ID))
            {
                MessageBox.Show("Please select file to download.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (fb.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DBMysql.con.Close();
                        DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_files where ID = '{0}'",ff_ID),DBMysql.con);
                        DBMysql.con.Open();
                        DBMysql.reader = DBMysql.cmd.ExecuteReader();
                        while (DBMysql.reader.Read())
                        {
                            File.WriteAllBytes(String.Format(@"{0}\{1}", @fb.SelectedPath, DBMysql.reader.GetString(2)), Convert.FromBase64String(Global.Decompress(DBMysql.reader.GetString(5))));
                            MessageBox.Show("File successfully downloaded.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
    }
}
