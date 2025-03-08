using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Configuration;

namespace ES_Thesis
{
    public class DBSqlite
    {
        public static SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);
        public static SQLiteCommand cmd;
        public static SQLiteDataReader reader;
        public static SQLiteDataAdapter adapter;

        public static void SQL(String command)
        {
            con.Close();
            cmd = new SQLiteCommand(command, con);
            con.Open();
            reader = cmd.ExecuteReader();
            con.Close();
        }
    }
}
