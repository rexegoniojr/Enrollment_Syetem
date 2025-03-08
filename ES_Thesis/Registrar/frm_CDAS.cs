using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace ES_Thesis.Registrar
{
    public partial class frm_CDAS : Form
    {
        public frm_CDAS()
        {
            InitializeComponent();
            auto_complete(Global.cd_ID, Global.cd_Year);
        }

        private void auto_complete(String ID, String SY)
        {
            txtcd_sub.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtcd_sub.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", ID, SY), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                col.Add(DBMysql.reader.GetString(3));
            }
            DBMysql.con.Close();
            txtcd_sub.AutoCompleteCustomSource = col;

            txtat_sub.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtat_sub.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col_at = new AutoCompleteStringCollection();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Course = '{0}'", Global.at_course), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                col_at.Add(DBMysql.reader.GetString(1));
            }
            DBMysql.con.Close();
            txtat_sub.AutoCompleteCustomSource = col_at;
        }

        String ID_cd = String.Empty;
        private void txtcd_sub_Leave(object sender, EventArgs e)
        {
            try
            {
                int total_unit = Convert.ToInt32(DBMysql.data(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", Global.cd_ID, Global.cd_Year), 5))
                + Convert.ToInt32(DBMysql.data(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", Global.cd_ID, Global.cd_Year), 6));
                txtcd_units.Text = total_unit.ToString();
            }
            catch (Exception) { }
            txtcd_days.Text = DBMysql.data(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", Global.cd_ID, Global.cd_Year), 7);
            txtcd_time.Text = DBMysql.data(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", Global.cd_ID, Global.cd_Year), 8);
            txtcd_rooms.Text = DBMysql.data(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", Global.cd_ID, Global.cd_Year), 9);
            ID_cd = DBMysql.data(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", Global.cd_ID, Global.cd_Year), 0);
        }

        private void clear_txt_cd()
        {
            txtcd_days.Clear(); txtcd_rooms.Clear(); txtcd_sub.Clear(); txtcd_time.Clear(); txtcd_units.Clear();
        }

        private void btncd_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcd_sub.Text) || String.IsNullOrWhiteSpace(txtcd_sub.Text))
            {
                MessageBox.Show("Please input the subject to be added.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(lstCD.FindItemWithText(ID_cd) != null)
            {
                MessageBox.Show("Subject already added.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_txt_cd();
            }
            else
            {
                if (lstCD.Items.Count <= 6)
                {
                    ListViewItem item = new ListViewItem(new[] { ID_cd, txtcd_sub.Text, txtcd_units.Text, txtcd_days.Text, txtcd_time.Text, txtcd_rooms.Text });
                    lstCD.Items.Add(item);
                    DBMysql.SQL(String.Format("delete from tbl_reg_sub where ID = '{0}'", ID_cd));
                    clear_txt_cd();
                }
                else
                {
                    MessageBox.Show("You reached the maximum limit of subject to be Changed or Dropped.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btncd_remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstCD.SelectedItems.Count; i++)
            {
                if (lstCD.SelectedItems[i].Selected)
                {
                    int i2 = lstCD.SelectedItems[i].Index;
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Code = '{0}'", lstCD.Items[i2].Text), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader=DBMysql.cmd.ExecuteReader();
                    while(DBMysql.reader.Read())
                    {
                        DBMysql.SQL(String.Format("insert into tbl_reg_sub(ID,Sub_ID,AYear,Code,DTitle,LEC,LAB,Day,Time,Room,Grade)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')"
                        , lstCD.Items[i2].Text, Global.cd_ID, Global.cd_Year, DBMysql.reader.GetString(1), DBMysql.reader.GetString(2), DBMysql.reader.GetString(3), DBMysql.reader.GetString(4),
                        DBMysql.reader.GetString(5), DBMysql.reader.GetString(6), DBMysql.reader.GetString(7), ""));
                    }
                    DBMysql.con.Close();
                }
            }

            foreach (ListViewItem x in lstCD.SelectedItems)
            {
                lstCD.Items.Remove(x);
            }
        }

        private void txtat_sub_Leave(object sender, EventArgs e)
        {
            try
            {
                int total_unit = Convert.ToInt32(DBMysql.data(String.Format("select * from tbl_subject_schedule where Code = '{0}'", txtat_sub.Text), 3)) +
                Convert.ToInt32(DBMysql.data(String.Format("select * from tbl_subject_schedule where Code = '{0}'", txtat_sub.Text), 4));
                txtat_unit.Text = total_unit.ToString();
            }
            catch (Exception) { }
            txtat_days.Text = DBMysql.data(String.Format("select * from tbl_subject_schedule where Code = '{0}'", txtat_sub.Text), 5);
            txtat_time.Text = DBMysql.data(String.Format("select * from tbl_subject_schedule where Code = '{0}'", txtat_sub.Text), 6);
            txtat_rooms.Text = DBMysql.data(String.Format("select * from tbl_subject_schedule where Code = '{0}'", txtat_sub.Text), 7);
        }

        private void clear_txt_at()
        {
            txtat_days.Clear(); txtat_rooms.Clear(); txtat_sub.Clear(); txtat_time.Clear(); txtat_unit.Clear();
        }

        private void btnat_Add_Click(object sender, EventArgs e)
        {
            String check_data = DBMysql.data(String.Format("select * from tbl_reg_sub where Code = '{0}' and Sub_ID = '{1}'", txtat_sub.Text, Global.cd_ID), 3);
            if (String.IsNullOrEmpty(txtat_sub.Text) || String.IsNullOrWhiteSpace(txtat_sub.Text))
            {
                MessageBox.Show("Please input the subject to be added.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lstAT.FindItemWithText(txtat_sub.Text) != null)
            {
                MessageBox.Show("Subject already added.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(check_data) == false || String.IsNullOrWhiteSpace(check_data) == false)
            {
                MessageBox.Show("Subject is already taken.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstAT.Items.Count <= 6)
                {
                    String ID = Global.data(20);
                    ListViewItem item = new ListViewItem(new[] { ID, txtat_sub.Text, txtat_unit.Text, txtat_days.Text, txtat_time.Text, txtat_rooms.Text });
                    lstAT.Items.Add(item);
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_subject_schedule where Code = '{0}'", txtat_sub.Text), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader = DBMysql.cmd.ExecuteReader();
                    while (DBMysql.reader.Read())
                    {
                        DBMysql.SQL(String.Format("insert into tbl_reg_sub(ID,Sub_ID,AYear,Code,DTitle,LEC,LAB,Day,Time,Room,Grade)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')"
                        , ID, Global.cd_ID, Global.cd_Year, DBMysql.reader.GetString(1), DBMysql.reader.GetString(2), DBMysql.reader.GetString(3), DBMysql.reader.GetString(4),
                        DBMysql.reader.GetString(5), DBMysql.reader.GetString(6), DBMysql.reader.GetString(7), ""));
                    }
                    DBMysql.con.Close();
                    clear_txt_at();
                }
                else
                {
                    MessageBox.Show("You reached the maximum limit of subject to be Added or Taken.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnat_Remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstAT.SelectedItems.Count; i++)
            {
                if (lstAT.SelectedItems[i].Selected)
                {
                    int i2 = lstAT.SelectedItems[i].Index;
                    DBMysql.SQL(String.Format("delete from tbl_reg_sub where ID = '{0}'", lstAT.Items[i2].Text));
                }
            }

            foreach (ListViewItem x in lstAT.SelectedItems)
            {
                lstAT.Items.Remove(x);
            }
        }

        private String[,] data_holds(ListView lst)
        {
            int num_rows = lst.Items.Count;
            int num_cols = 0;
            for (int i = 0; i < num_rows; i++)
            {
                if (num_cols < lst.Items[i].SubItems.Count)
                    num_cols = lst.Items[i].SubItems.Count;
            }

            string[,] results = new string[num_rows, num_cols];

            for (int r = 0; r < num_rows; r++)
            {
                for (int c = 0; c < num_cols; c++)
                    results[r, c] = lst.Items[r].SubItems[c].Text;
            }
            return results;
        }

        String[] name = { "a", "b", "c", "d", "e" };
        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch(MessageBox.Show(this,"Are you sure you want to Export this record to MS Word?","Confirm Export",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    if (fb.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            String temp_code = Global.num(5);
                            Global.EndTask("winword");
                            File.Copy(Global.exePath + "\\Docs\\cdas.docx", String.Format("{0}\\{1}[{2}]CDA.docx", @fb.SelectedPath, temp_code, Global.cd_ID), true);
                            object missing = Missing.Value;
                            Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                            Word.Document aDoc = null;
                            object filename = String.Format("{0}\\{1}[{2}]CDA.docx", @fb.SelectedPath, temp_code, Global.cd_ID);
                            if (File.Exists((string)filename))
                            {
                                object readOnly = false;
                                object isVisible = false;
                                wordApp.Visible = false;
                                aDoc = wordApp.Documents.Open(ref filename, ref missing,
                                ref readOnly, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing, ref missing,
                                ref missing, ref isVisible, ref missing, ref missing,
                                ref missing, ref missing);
                                aDoc.Activate();
                                Global.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                                Global.FindAndReplace(wordApp, "<stud_id>", Global.cd_ID);
                                Global.FindAndReplace(wordApp, "<stud_year>", Global.cd_Year);
                                for (int i = 0; i < 6; i++)
                                {
                                    for (int j = 0; j < name.Length; j++)
                                    {
                                        try
                                        {
                                            Global.FindAndReplace(wordApp, String.Format("<{0}{1}>", Convert.ToString(i + 1), name[j]), data_holds(lstCD)[i, j + 1]);
                                            Global.FindAndReplace(wordApp, String.Format("<{0}{1}{1}>", Convert.ToString(i + 1), name[j]), data_holds(lstAT)[i, j + 1]);
                                        }
                                        catch (Exception x)
                                        {
                                            Global.FindAndReplace(wordApp, String.Format("<{0}{1}>", Convert.ToString(i + 1), name[j]), " ");
                                            Global.FindAndReplace(wordApp, String.Format("<{0}{1}{1}>", Convert.ToString(i + 1), name[j]), " ");
                                        }
                                    }
                                }
                                DBMysql.con.Close();
                                DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_personal_info where StudNum = '{0}'", Global.cd_ID), DBMysql.con);
                                DBMysql.con.Open();
                                DBMysql.reader = DBMysql.cmd.ExecuteReader();
                                while (DBMysql.reader.Read())
                                {
                                    Global.FindAndReplace(wordApp, "<stud_name>", String.Format("{0} {1},{2}", DBMysql.reader.GetString(1), DBMysql.reader.GetString(2), DBMysql.reader.GetString(3)));
                                    Global.FindAndReplace(wordApp, "<stud_course>", DBMysql.reader.GetString(4));
                                }
                                DBMysql.con.Close();
                                aDoc.Save();

                                Global.EndTask("winword");
                                MessageBox.Show("Changing, Dropping and Adding Subjects successfully exported.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Global.EndTask("winword");
                                String ID_F = Global.data(20);
                                String fname = String.Format("{0}\\{1}[{2}]CDA.docx", @fb.SelectedPath, temp_code, Global.cd_ID);
                                string[] sizes = { "B", "KB", "MB", "GB" };
                                double len = new FileInfo(fname).Length;
                                int order = 0;
                                while (len >= 1024 && ++order < sizes.Length) { len = len / 1024; }
                                string result = String.Format("{0:0.##} {1}", len, sizes[order]);
                                String name_F = String.Format("{0}[{1}]CDA.docx", temp_code, Global.cd_ID);
                                String type_F = Path.GetExtension(fname);
                                String size_F = result;
                                DBMysql.SQL(String.Format("insert into tbl_files(ID,acc_ID,fname,ftype,fsize,file,Date)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                ID_F, Global.ID, name_F, type_F, size_F, Global.Compress(Convert.ToBase64String(File.ReadAllBytes(fname))), DateTime.Now.ToShortDateString()));
                            }
                        }
                        catch (Exception) { }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
