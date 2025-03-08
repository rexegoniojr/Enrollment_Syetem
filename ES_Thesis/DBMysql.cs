using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ES_Thesis
{
    public class DBMysql
    {
        public static MySqlCommand cmd;
        public static MySqlConnection con;
        public static MySqlDataReader reader;

        public static void connnect(String server,String database,String port,String username,String password)
        {
            con = new MySqlConnection(String.Format("server = {0}; database = {1}; port = {2}; username = {3}; password = {4}"
            ,server,database,port,username,password));
        }

        public static void con_cmd()
        {
            DBSqlite.con.Close();
            DBSqlite.cmd = new SQLiteCommand(String.Format("select * from tbl_database where ID = '{0}'", 1), DBSqlite.con);
            DBSqlite.con.Open();
            DBSqlite.reader = DBSqlite.cmd.ExecuteReader();
            while (DBSqlite.reader.Read())
            {
                DBMysql.connnect(DBSqlite.reader.GetString(1), DBSqlite.reader.GetString(2), DBSqlite.reader.GetString(3),
                DBSqlite.reader.GetString(4), DBSqlite.reader.GetString(5));
                try
                {
                    DBMysql.con.Open();
                    DBMysql.con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Handled. Please check your database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DBMysql.con.Close();
                }
            }
            DBSqlite.con.Close();
        }

        public static void SQL(String code)
        {
            con_cmd();
            con.Close();
            cmd = new MySqlCommand(code, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static String data(String cmd_control, int location)
        {
            String data_hold = String.Empty;
            con_cmd();
            con.Close();
            cmd = new MySqlCommand(cmd_control,con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                data_hold = reader.GetString(location);
            }
            con.Close();
            return data_hold;
        }
    }
}
