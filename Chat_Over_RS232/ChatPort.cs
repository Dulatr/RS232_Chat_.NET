﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Computer_RS232_Chat_.NET
{
    class ChatPort : SerialPort
    {
        private readonly object noInterupt = new object();

        private ChatClient usingClient;
        //private Type methodChecker = Type.GetType("Computer_RS232_Chat_.NET.ChatClient");
        //private MethodInfo methodInfo;

        public ChatPort( string com, ChatClient client) : base(com)
        {
            Parity = client.ParitySel;

            if (Parity == Parity.None)
                DataBits = 8;
            else
                DataBits = 7;

            BaudRate = client.Baud;
           
            DataReceived += new SerialDataReceivedEventHandler(DataAvailable);

            usingClient = client;

        }
        
        private void DataAvailable(object sender,SerialDataReceivedEventArgs e)
        {
                char[] buffer = new char[1];
                string temp = string.Empty;
                
                Read(buffer,0,1);
            
                temp = temp + buffer[0];
                
                if (usingClient != null)
                    usingClient.BeginInvoke(new ChatClient.DataReady(usingClient.DataRecieved), temp);
                else
                    throw new ArgumentNullException("Client reference passed is null.");
        }
    }
}
