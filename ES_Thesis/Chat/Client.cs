using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace ES_Thesis.Chat
{
    public partial class Client : Form
    {

        private int port = 01337;
        String username;
        String IPAddress;
        Boolean connected;
        Socket sender;
        Listener listeners;
        Thread t;

        List<String> messageQuery = new List<String>();  

        public Client()
        {
            InitializeComponent();
            username = Global.FName;
            IPAddress = GetLocalIP();
            connected = false;
        }

        private void connect()
        {
            try
            {
                System.IO.File.AppendAllText("log.txt", "");
                sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(IPAddress, port);
                sendMsg(username + " connected");
                listeners = new Listener(sender, messageQuery);
                t = new Thread(new ThreadStart(listeners.Run));
                t.Start();
                timer1.Start();
                connected = true;
            }
            catch (SocketException se)
            {
                using (System.IO.StreamWriter dataFile = new System.IO.StreamWriter("log.txt", true))
                {
                    dataFile.WriteLine(String.Format("{0} | {1}\n", DateTime.Now, se));
                }
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter dataFile = new System.IO.StreamWriter("log.txt", true))
                {
                    dataFile.WriteLine(String.Format("{0} | {1}\n", DateTime.Now, e));
                }
            }
        }

        private void disconnect()
        {
            try
            {
                sendMsg(username + " disconnected");
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                timer1.Stop();
                connected = false;
            }
            catch (SocketException se)
            {
                using (System.IO.StreamWriter dataFile = new System.IO.StreamWriter("log.txt", true))
                {
                    dataFile.WriteLine(String.Format("{0} | {1}\n", DateTime.Now, se));
                }
            }
            catch (Exception e)
            {
                using (System.IO.StreamWriter dataFile = new System.IO.StreamWriter("log.txt", true))
                {
                    dataFile.WriteLine(String.Format("{0} | {1}\n", DateTime.Now, e));
                }
            }
        }

        private void sendMsg(String data)
        {
            byte[] msg = Encoding.ASCII.GetBytes(data);
            int bytesSent = sender.Send(msg);
        }

        private string GetLocalIP()
        {

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)

                    return ip.ToString();

            }
            return "127.0.0.1";

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (messageQuery.Count > 0)
            {
                messageList.Items.Add(messageQuery[0] + '\n');
                messageQuery.RemoveAt(0);
            }

            if (connected == true)
            {
                if (listeners.Connected == false)
                {
                    disconnect();
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendMsg(String.Format("{0} : {1}\n", username, inputBox.Text));              //Send message
            inputBox.Text = "";
        }

        private void btnConDis_Click(object sender, EventArgs e)
        {
            int chat = 0;
            DBMysql.con.Close();
            DBMysql.cmd = new MySqlCommand(String.Format("select * from tbl_chat_stat where ID = '{0}'", 1), DBMysql.con);
            DBMysql.con.Open();
            DBMysql.reader = DBMysql.cmd.ExecuteReader();
            while (DBMysql.reader.Read())
            {
                if (DBMysql.reader.HasRows == true) { chat = Convert.ToInt32(DBMysql.reader.GetString(1)); }
            }
            DBMysql.con.Close();

            if (chat == 1)
            {
                if (btnConDis.Text == "Connect")
                {
                    btnConDis.Text = "Disconnect";
                    sendButton.Enabled = true;
                    inputBox.Enabled = true;
                    connect();
                }
                else
                {
                    btnConDis.Text = "Connect";
                    sendButton.Enabled = false;
                    inputBox.Enabled = false;
                    disconnect();
                }
            }
            else
            {
                MessageBox.Show("The Server is offline.", "Unable to Connect", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
