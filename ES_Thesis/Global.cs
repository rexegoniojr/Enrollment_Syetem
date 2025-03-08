using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace ES_Thesis
{
    public class Global
    {
        public static string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public static int check_confirmation = 0;
        public static int check_form_confirm = 0;
        public static String ID = String.Empty;
        public static int chat_stat = 0;
        public static String stud_info = String.Empty;
        public static String SY_hold = String.Empty;
        public static String current_bal = String.Empty;
        public static String ID_Pay = String.Empty;
        public static String cd_ID = String.Empty;
        public static String cd_Year = String.Empty;
        public static String at_course = String.Empty;
        public static String ID_new = String.Empty;
        public static String SY_new = String.Empty;
        public static int pay_break = 0;
        public static String[,] data_hold = new String[13, 7];

        public static string ToSentenceCase(string strSen)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(strSen);
        }

        static Random rands = new Random((int)DateTime.Now.Ticks);
        public static string data(int sizes)
        {
            String inputs = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder builds = new StringBuilder();
            char chs;
            for (int i = 0; i < sizes; i++)
            {
                chs = inputs[rands.Next(0, inputs.Length)];
                builds.Append(chs);
            }
            return builds.ToString();
        }

        public static string num(int sizes)
        {
            String inputer = "0123456789";
            StringBuilder builds = new StringBuilder();
            char chs;
            for (int i = 0; i < sizes; i++)
            {
                chs = inputer[rands.Next(0, inputer.Length)];
                builds.Append(chs);
            }
            return builds.ToString();
        }
        public static Socket sk;
        public static EndPoint epLocal, epRemote;
        public static String FName = String.Empty;

        public static void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp,
            object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            wordApp.Selection.Find.Execute(ref findText, ref matchCase,
                ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
                ref matchAllWordForms, ref forward, ref wrap, ref format,
                ref replaceText, ref replace, ref matchKashida,
                        ref matchDiacritics,
                ref matchAlefHamza, ref matchControl);
        }

        public static void EndTask(string taskname)
        {
            string processName = taskname;
            string fixstring = taskname.Replace(".exe", "");

            if (taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(fixstring))
                {
                    process.Kill();
                }
            }
            else if (!taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                }
            }
        }

        public static string Compress(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }

        public static string Decompress(string compressedText)
        {
            byte[] gzBuffer = Convert.FromBase64String(compressedText);
            using (MemoryStream ms = new MemoryStream())
            {
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
                {
                    zip.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }
    }
}
