using System;
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
        private Type methodChecker = Type.GetType("Computer_RS232_Chat_.NET.ChatClient");
        private MethodInfo methodInfo;

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

            methodInfo = methodChecker.GetMethod("DataRecieved");
            //MessageBox.Show(String.Format("method signature <{0}> {1}(string s)", methodInfo.ReturnType.ToString(), methodInfo.Name));
        }
        
        private void DataAvailable(object sender,SerialDataReceivedEventArgs e)
        {
                char[] buffer = new char[1];
                string temp = "";
                //IntPtr myMethod = methodInfo.MethodHandle.GetFunctionPointer();

                Read(buffer,0,1);
            
                for(int i = 0;i<buffer.Length;i++){
                    temp = temp + buffer[i];
                }
                
                if (usingClient != null)
                    usingClient.BeginInvoke(new ChatClient.DataReady(usingClient.DataRecieved), temp);
                else if(usingClient == null)
                    throw new ArgumentNullException("Client reference passed is null.");
                //else if (methodInfo == null) 
                //    throw new MissingMethodException(String.Format("Missing Client method of signature {0} {1} (string s)",methodInfo.ReturnType.ToString(),methodInfo.Name));        

        }
    }
}
