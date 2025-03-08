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

namespace ES_Thesis.Accounting
{
    public partial class frm_Payment : Form
    {
        public frm_Payment()
        {
            InitializeComponent();
            load_data(PaymentData.id, PaymentData.sy);
            lblName.Text = "Name: " + PaymentData.name;
            lblsem.Text = "Semester: " + PaymentData.semester;
            lblID.Text = "ID: " + PaymentData.id;
            lblCourse.Text = "Course: " + PaymentData.course;
            lblStatus.Text = "Status: " + PaymentData.status;
            lblSy.Text = "SY: " + PaymentData.sy;
        }

        private void load_data(String sub_ID, String AYear)
        {
            lst_subject_input.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_reg_sub where Sub_ID = '{0}' and AYear = '{1}'", sub_ID, AYear), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                item.SubItems.Add(DBMysql.reader.GetString(3));
                item.SubItems.Add(DBMysql.reader.GetString(4));
                item.SubItems.Add(DBMysql.reader.GetString(5));
                item.SubItems.Add(DBMysql.reader.GetString(6));
                item.SubItems.Add(DBMysql.reader.GetString(7));
                item.SubItems.Add(DBMysql.reader.GetString(8));
                item.SubItems.Add(DBMysql.reader.GetString(9));
                lst_subject_input.Items.Add(item);
            }
            DBMysql.con.Close();

            payment_transaction();
            payment_info();

            double total_paid = 0;
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where stud_ID = '{0}' and SY = '{1}' and Sem = '{2}' and year = '{3}'",
            PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                total_paid += Convert.ToDouble(DBMysql.reader.GetString(3));
            }
            DBMysql.con.Close();
            txtBalance.Text = Convert.ToString(Convert.ToDouble(Global.current_bal) - total_paid);
            int check = 0;
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_stud_bal where stud_ID = '{0}' and SY = '{1}' and Sem = '{2}' and Year = '{3}'",
            PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (DBMysql.reader.HasRows == true) { check = 1; }
            }
            DBMysql.con.Close();

            switch (check)
            {
                case 0:
                    String ID = Global.data(20);
                    DBMysql.SQL(String.Format("insert into tbl_stud_bal(ID,stud_ID,SY,balance,Sem,Year)values('{0}','{1}','{2}','{3}','{4}','{5}')", ID, PaymentData.id, PaymentData.sy,
                    txtBalance.Text, PaymentData.semester, PaymentData.year));
                    break;
                default:
                    DBMysql.SQL(String.Format("update tbl_stud_bal set balance = '{0}' where stud_ID = '{1}' and SY = '{2}' and Sem = '{3}' and Year = '{4}'",
                    txtBalance.Text, PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year));
                    break;
            }
        }

        private void payment_transaction()
        {
            lstPayment.Items.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where stud_ID = '{0}'and SY = '{1}' and Sem = '{2}' and Year = '{3}'", PaymentData.id,
            PaymentData.sy, PaymentData.semester, PaymentData.year), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                ListViewItem item = new ListViewItem(DBMysql.reader.GetString(0));
                item.SubItems.Add(DBMysql.reader.GetString(3));
                item.SubItems.Add(DBMysql.reader.GetString(4));
                lstPayment.Items.Add(item);
            }
            DBMysql.con.Close();
        }

        private void payment_info()
        {
            txtReg.Clear(); txtMis.Clear(); txtPE.Clear(); txtOthers.Clear(); txtTui.Clear(); txtNSTP.Clear(); txtLab.Clear(); txtTA.Clear(); txtLess.Clear(); txtTAA.Clear();
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_student_fee where stud_ID = '{0}' and semester = '{1}' and SY = '{2}' and Year = '{3}'", PaymentData.id,
            PaymentData.semester, PaymentData.sy, PaymentData.year), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                txtReg.Text = DBMysql.reader.GetString(6);
                txtMis.Text = DBMysql.reader.GetString(7);
                txtPE.Text = DBMysql.reader.GetString(8);
                txtOthers.Text = DBMysql.reader.GetString(9);
                txtTui.Text = DBMysql.reader.GetString(10);
                txtNSTP.Text = DBMysql.reader.GetString(11);
                txtLab.Text = DBMysql.reader.GetString(12);
                txtTA.Text = DBMysql.reader.GetString(13);
                txtLess.Text = DBMysql.reader.GetString(14);
                txtTAA.Text = DBMysql.reader.GetString(15);
                Global.current_bal = DBMysql.reader.GetString(15);
            }
            DBMysql.con.Close();
        }

        private void TxtNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to save this record?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    DBMysql.SQL(String.Format("update tbl_student_fee set reg = '{0}', mis = '{1}', pe = '{2}', oth = '{3}', tuition = '{4}', nstp = '{5}'," +
                    "labosatory = '{6}', total_assessment = '{7}', lss = '{8}', taa = '{9}' where stud_ID = '{10}'", txtReg.Text, txtMis.Text, txtPE.Text, txtOthers.Text, txtTui.Text,
                    txtNSTP.Text, txtLab.Text, txtTA.Text, txtLess.Text, txtTAA.Text, PaymentData.id));

                    double total_paid = 0;
                    DBMysql.con.Close();
                    DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where stud_ID = '{0}' and SY = '{1}' and Sem = '{2}' and Year = '{3}'",
                    PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year), DBMysql.con);
                    DBMysql.con.Open();
                    DBMysql.reader = DBMysql.cmd.ExecuteReader();
                    while (DBMysql.reader.Read())
                    {
                        total_paid += Convert.ToDouble(DBMysql.reader.GetString(3));
                    }
                    DBMysql.con.Close();
                    double bal = Convert.ToDouble(txtTAA.Text) - total_paid;
                    DBMysql.SQL(String.Format("update tbl_stud_bal set balance = '{0}' where stud_ID = '{1}' and SY = '{2}' and Sem = '{3}' and Year = '{4}'", bal.ToString(),
                    PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year));
                    txtBalance.Text = bal.ToString();
                    MessageBox.Show("Student fee successfully updated.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    payment_info();
                    break;
            }
        }

        private void txtReg_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtReg.Text) || String.IsNullOrWhiteSpace(txtReg.Text)) { txtReg.Text = "0"; }
            if (String.IsNullOrEmpty(txtMis.Text) || String.IsNullOrWhiteSpace(txtMis.Text)) { txtMis.Text = "0"; }
            if (String.IsNullOrEmpty(txtPE.Text) || String.IsNullOrWhiteSpace(txtPE.Text)) { txtPE.Text = "0"; }
            if (String.IsNullOrEmpty(txtOthers.Text) || String.IsNullOrWhiteSpace(txtOthers.Text)) { txtOthers.Text = "0"; }
            if (String.IsNullOrEmpty(txtTui.Text) || String.IsNullOrWhiteSpace(txtTui.Text)) { txtTui.Text = "0"; }
            if (String.IsNullOrEmpty(txtNSTP.Text) || String.IsNullOrWhiteSpace(txtNSTP.Text)) { txtNSTP.Text = "0"; }
            if (String.IsNullOrEmpty(txtLab.Text) || String.IsNullOrWhiteSpace(txtLab.Text)) { txtLab.Text = "0"; }
            if (String.IsNullOrEmpty(txtLess.Text) || String.IsNullOrWhiteSpace(txtLess.Text)) { txtLess.Text = "0"; }

            double total_assessment = Convert.ToDouble(txtReg.Text) + Convert.ToDouble(txtMis.Text) + Convert.ToDouble(txtPE.Text) + Convert.ToDouble(txtOthers.Text)
                + Convert.ToDouble(txtTui.Text) + Convert.ToDouble(txtNSTP.Text) + Convert.ToDouble(txtLab.Text);
            txtTA.Text = total_assessment.ToString();
            double total_taa = total_assessment - Convert.ToDouble(txtLess.Text);
            txtTAA.Text = total_taa.ToString();
        }

        private void btnSub_amount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAmount.Text) || String.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please amount to submit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToDouble(txtAmount.Text) == 0 || Convert.ToDouble(txtAmount.Text) == 0.0)
            {
                MessageBox.Show("Zero value cannot be submit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (MessageBox.Show(this, "Are you sure you want to submit this data?", "Confirm Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DBMysql.SQL(String.Format("insert into tbl_payment_history(ID,stud_ID,SY,amount,Date,Sem,Year)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Global.data(20),
                        PaymentData.id, PaymentData.sy, txtAmount.Text, DateTime.Now.ToShortDateString(), PaymentData.semester, PaymentData.year));
                        double bal = Convert.ToDouble(txtTAA.Text) - Convert.ToDouble(txtAmount.Text);
                        DBMysql.SQL(String.Format("update tbl_stud_bal set balance = '{0}' where stud_ID = '{1}' and SY = '{2}' and Sem = '{3}' and Year = '{4}'", bal.ToString(),
                        PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year));
                        txtBalance.Text = bal.ToString();
                        payment_transaction();
                        txtAmount.Text = "0";
                        break;
                    default:
                        break;
                }
            }
        }

        String ID_amount = String.Empty;
        private void lstPayment_Click(object sender, EventArgs e)
        {
            ID_amount = lstPayment.FocusedItem.SubItems[0].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID_amount) || String.IsNullOrWhiteSpace(ID_amount))
            {
                MessageBox.Show("Select data first before clicking delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (MessageBox.Show(this, "Are you sure you want to delete this data?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        // double del_amount = Convert.ToDouble(DBMysql.data(String.Format("select * from tbl_payment_history where ID = '{0}'", ID_amount), 3));
                        DBMysql.SQL(String.Format("delete from tbl_payment_history where ID = '{0}'", ID_amount));
                        double total_paid = 0;
                        DBMysql.con.Close();
                        DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_payment_history where stud_ID = '{0}' and SY = '{1}' and Sem = '{2}' and Year = '{3}'",
                        PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year), DBMysql.con);
                        DBMysql.con.Open();
                        DBMysql.reader = DBMysql.cmd.ExecuteReader();
                        while (DBMysql.reader.Read())
                        {
                            total_paid += Convert.ToDouble(DBMysql.reader.GetString(3));
                        }
                        DBMysql.con.Close();
                        double bal = Convert.ToDouble(txtTAA.Text) - total_paid;
                        DBMysql.SQL(String.Format("update tbl_stud_bal set balance = '{0}' where stud_ID = '{1}' and SY = '{2}' and Sem = '{3}' and Year = '{4}'", bal.ToString(),
                        PaymentData.id, PaymentData.sy, PaymentData.semester, PaymentData.year));
                        txtBalance.Text = bal.ToString();
                        payment_transaction();
                        MessageBox.Show("Data successfully deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
        }

        frm_history hs;
        private void btnHB_Click(object sender, EventArgs e)
        {
            hs = new frm_history();
            hs.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (fb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String temp_code = Global.num(5);
                    Global.EndTask("winword");
                    File.Copy(Global.exePath + "\\Docs\\rf_front.docx", String.Format("{0}\\{1}[{2}]RegForm.docx", @fb.SelectedPath, temp_code, Global.stud_info), true);
                    object missing = Missing.Value;
                    Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Word.Document aDoc = null;
                    object filename = String.Format("{0}\\{1}[{2}]RegForm.docx", @fb.SelectedPath, temp_code, Global.stud_info);
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
                        int unit_total = 0;
                        String[] letters = { "", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" };
                        for (int x = 0; x < lst_subject_input.Items.Count; x++)
                        {
                            for (int i = 1; i <= 7; i++)
                            {
                                Global.FindAndReplace(wordApp, String.Format("<{0}{1}>", letters[x + 1], i.ToString()), lst_subject_input.Items[x].SubItems[i].Text);
                                if (i == 3 || i == 4)
                                {
                                    unit_total += Convert.ToInt32(lst_subject_input.Items[x].SubItems[i].Text);
                                }
                            }
                        }

                        for (int x = lst_subject_input.Items.Count; x <= 13; x++)
                        {
                            for (int i = 1; i <= 7; i++)
                            {
                                Global.FindAndReplace(wordApp, String.Format("<{0}{1}>", letters[x], i.ToString()), "");
                            }
                        }
                        Global.FindAndReplace(wordApp, "<unit_total>", unit_total.ToString());
                        Global.FindAndReplace(wordApp, "<NM>", PaymentData.name);
                        Global.FindAndReplace(wordApp, "<std_num>", PaymentData.id);
                        Global.FindAndReplace(wordApp, "<StdYear>", PaymentData.year);
                        Global.FindAndReplace(wordApp, "<SY>", PaymentData.sy);
                        Global.FindAndReplace(wordApp, "<course>", PaymentData.course);

                        Global.FindAndReplace(wordApp, "<reg>", txtReg.Text);
                        Global.FindAndReplace(wordApp, "<tui>", txtTui.Text);
                        Global.FindAndReplace(wordApp, "<mis>", txtMis.Text);
                        Global.FindAndReplace(wordApp, "<nstp>", txtNSTP.Text);
                        Global.FindAndReplace(wordApp, "<pe>", txtPE.Text);
                        Global.FindAndReplace(wordApp, "<lab>", txtLab.Text);
                        Global.FindAndReplace(wordApp, "<other>", txtOthers.Text);
                        Global.FindAndReplace(wordApp, "<ta>", txtTA.Text);
                        Global.FindAndReplace(wordApp, "<less>", txtLess.Text);
                        Global.FindAndReplace(wordApp, "<taa>", txtTAA.Text);

                        DBMysql.con.Close();
                        DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_parent_guardian where stud_ID = '{0}'", PaymentData.id), DBMysql.con);
                        DBMysql.con.Open();
                        DBMysql.reader = DBMysql.cmd.ExecuteReader();
                        while (DBMysql.reader.Read())
                        {
                           Global.FindAndReplace(wordApp, "<f_nm>", String.Format("{0} {1},{2}", DBMysql.reader.GetString(2), DBMysql.reader.GetString(3), DBMysql.reader.GetString(4)));
                           Global.FindAndReplace(wordApp, "<f_occ>", DBMysql.reader.GetString(5));
                           Global.FindAndReplace(wordApp, "<f_no>", DBMysql.reader.GetString(6));

                           Global.FindAndReplace(wordApp, "<m_nm>", String.Format("{0} {1},{2}", DBMysql.reader.GetString(8), DBMysql.reader.GetString(9), DBMysql.reader.GetString(10)));
                           Global.FindAndReplace(wordApp, "<m_occ>", DBMysql.reader.GetString(11));
                           Global.FindAndReplace(wordApp, "<m_no>", DBMysql.reader.GetString(12));

                           Global.FindAndReplace(wordApp, "<g_nm>", String.Format("{0} {1},{2}", DBMysql.reader.GetString(14), DBMysql.reader.GetString(15), DBMysql.reader.GetString(16)));
                           Global.FindAndReplace(wordApp, "<g_occ>", DBMysql.reader.GetString(17));
                           Global.FindAndReplace(wordApp, "<g_no>", DBMysql.reader.GetString(18));
                        }
                        DBMysql.con.Close();

                        DBMysql.con.Close();
                        DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_personal_info where StudNum = '{0}'", PaymentData.id), DBMysql.con);
                        DBMysql.con.Open();
                        DBMysql.reader = DBMysql.cmd.ExecuteReader();
                        while (DBMysql.reader.Read())
                        {
                            Global.FindAndReplace(wordApp, "<con_no>", DBMysql.reader.GetString(11));
                            Global.FindAndReplace(wordApp, "<address>", DBMysql.reader.GetString(10));
                        }
                        DBMysql.con.Close();

                        aDoc.Save();

                        Global.EndTask("winword");
                        MessageBox.Show("Student Information successfully exported.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Global.EndTask("winword");
                        String ID_F = Global.data(20);
                        String fname = String.Format("{0}\\{1}[{2}]RegForm.docx", @fb.SelectedPath, temp_code, Global.stud_info);
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
                    else
                    {
                        MessageBox.Show("File does not exist.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Global.EndTask("winword");
                    }
                }
                catch (Exception x) { MessageBox.Show(this, x.Message, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
