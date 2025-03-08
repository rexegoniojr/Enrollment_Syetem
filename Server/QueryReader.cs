﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Server
{
    class QueryReader
    {
        List<String> messageQuery;
        List<TCPComms> listenerList;
        Boolean done;
        Mutex mutex;

        /// <summary>
        /// Method  :   constructor for object
        /// </summary>
        /// <param name="query">Message list from the users</param>
        /// <param name="listeners">List of clients</param>
        public QueryReader(List<String> query, List<TCPComms> listeners, Mutex mut)
        {
            messageQuery = query;
            listenerList = listeners;
            mutex = mut;
            done = false;
        }

        /// <summary>
        /// Method  :   Run
        /// This method runs in an infinite loop
        /// It checks for any new messages appearing in a list of messages,
        /// and send it out to every client on the list.
        /// </summary>
        public void Run()
        {
            while (done == false)
            {
                mutex.WaitOne();
                for (int i = 0; i < listenerList.Count; i++)
                {
                    if (listenerList[i].Connected == false)
                    {
                        listenerList.RemoveAt(i);
                    }
                }

                if (messageQuery.Count > 0)
                {
                    foreach (TCPComms listener in listenerList)
                    {
                        listener.send_Msg(messageQuery[0]);
                    }
                    messageQuery.RemoveAt(0);
                    Thread.Sleep(10);
                }
                mutex.ReleaseMutex();
            }
        }
    }
}
