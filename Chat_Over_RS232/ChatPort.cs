using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace Computer_RS232_Chat_.NET
{
    class ChatPort : SerialPort
    {
        private ChatClient usingClient;

        public ChatPort( string com, ChatClient client) : base(com)
        {
            Parity = client.ParitySel;

            if (Parity == Parity.None)
                DataBits = 8;
            else
                DataBits = 7;

            if (client.Baud != 0)
                BaudRate = client.Baud;
            else if (client.Baud == 0)
                BaudRate = 9600;
            else
                throw new MissingFieldException();

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
