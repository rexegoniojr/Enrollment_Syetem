﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ES_Thesis.Chat
{
    class Listener
    {
        private List<String> query;     //Message query
        private Socket handler;         //Connection socket
        //Connected status properti
        public Boolean Connected { get { return handler.Connected; } }

        //Set socket and query to entered values
        public Listener(Socket socket, List<String> stringList)
        {
            handler = socket;
            query = stringList;
        }

        public void Run()
        {
            //Do while connected
            while (handler.Connected)
            {
                try
                {
                    byte[] bytes = new Byte[1024];

                    //Receive sequence of bytes
                    int bytesRecv = handler.Receive(bytes);

                    //Add message to query
                    query.Add(Encoding.ASCII.GetString(bytes, 0, bytesRecv));
                }
                catch (SocketException)
                {
                    using (System.IO.StreamWriter dataFile = new System.IO.StreamWriter("log.txt", true))
                    {
                        dataFile.WriteLine(DateTime.Now + " | Disconnected\n");
                    }
                }
            }
        }
    }
}
