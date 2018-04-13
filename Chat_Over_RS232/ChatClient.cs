using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Computer_RS232_Chat_.NET
{
    public partial class ChatClient : Form
    {
        private bool shiftEntered = false;
        private SerialPort chatPort;

        private Parity parity;
        private int baud;

        public delegate void DataReady(string s);

        public ChatClient()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            PortBx.Items.AddRange(SerialPort.GetPortNames());
            
            if (PortBx.Items.Count != 0)
                PortBx.SelectedIndex = 0;
            else
                PortBx.SelectedIndex = -1;

            ParityBx.Items.Add(Parity.None);
            ParityBx.Items.Add(Parity.Even);
            ParityBx.Items.Add(Parity.Odd);
            ParityBx.SelectedIndex = 0;

            BaudBx.SelectedIndex = BaudBx.Items.IndexOf("9600");
        }

        private void TxtToSendBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
                shiftEntered = true;
            else
                shiftEntered = false;
        }
        private void TxtToSendBx_KeyPress(object sender, KeyPressEventArgs e)
        {                  
            if (e.KeyChar == '\r' && !shiftEntered)
            {
                
                if(chatPort != null && chatPort.IsOpen)
                {
                    char[] toSend = new char[TxtToSendBx.Text.Length]; //how many characters to add to buffer?
                    bool baudSel = baud > 9600;                        //is the baud above a rate where we can reduce the time for this thread to sleep?
                    
                    TxtRecievedBx.Clear();
                    
                    for (int i = 0; i < TxtToSendBx.Text.Length; i++)
                    {
                        toSend[i] = TxtToSendBx.Text[i];
                        chatPort.Write(toSend,i,1);

                        switch (baudSel)
                        {
                            case true:
                                Thread.Sleep(7);
                                break;
                            default:
                                Thread.Sleep(10);
                                break;
                        }
                    }                   
                }
            }
        }

        private void OpenPortBttn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (chatPort == null)
                {
                    chatPort = new ChatPort(PortBx.Text,this);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (chatPort != null)
            {
                if (!chatPort.IsOpen)
                {
                    try
                    {
                        chatPort.Open();
                        BaudBx.Enabled = false;
                        ParityBx.Enabled = false;
                        PortBx.Enabled = false;
                        PortActivePic.BackColor = Color.Green;                        
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                        BaudBx.Enabled = true;
                        ParityBx.Enabled = true;
                        PortBx.Enabled = true;
                        PortActivePic.BackColor = Color.Red;        
                    }
                }
            }
        }       
        private void ClosePortBttn_Click(object sender, EventArgs e)
        {
            if (chatPort != null)
            {
                if (chatPort.IsOpen)
                {
                    try
                    {
                        chatPort.Close();
                        BaudBx.Enabled = true;
                        ParityBx.Enabled = true;
                        PortBx.Enabled = true;
                        PortActivePic.BackColor = Color.Red;
                        chatPort.Dispose();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                        BaudBx.Enabled = false;
                        ParityBx.Enabled = false;
                        PortBx.Enabled = false;
                        PortActivePic.BackColor = Color.Green;        
                    }
                }                
            }
        }

        private void ParityBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            parity = (Parity)ParityBx.Items[ParityBx.SelectedIndex]; //specific Enum is a value type. Object Collection must be cast as such
        }
        private void BaudBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            baud = int.Parse(BaudBx.SelectedItem.ToString());
        }

        public void DataRecieved(string s)
        {
            TxtRecievedBx.Text = TxtRecievedBx.Text + s;           
        }

        public Parity ParitySel
        {
            get { return parity; }
        }
        public int Baud
        {
            get { return baud; }
        }
    }   
}
