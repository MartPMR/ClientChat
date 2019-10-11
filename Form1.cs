using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private string _IP;
        public string IP { get { return _IP; } set { _IP = textBoxIP.Text.ToString(); } }
        private int _Port;
        public int Port { get { return _Port; } set {_Port = Convert.ToInt32(textBoxPort.Text} }
        private string _Nick;
        public string Nick { get {return _Nick; } set { _Nick = textBoxNick.Text.ToString(); } }
            
        private string _Chat;
        public string Chat { get { return _Chat; }set { _Chat = textBoxChat.Text.ToString(); } }
        private string _Message;
        public string Message { get { return _Message; }set {_Message = textBoxMessage.Text.ToString(); } }

        TcpClient client;
        StreamWriter sw;
        StreamReader sr;

        public Form1()
        {
            
            InitializeComponent();
            IP = "192.168.0.102";
            Port = 5050;
            Nick = "Bob";

            Task.Factory.StartNew(() =>
            {
                while(true)
                {
                    try
                    {
                        if (client?.Connect == true)
                        {
                            var line = sr.ReadLine();

                            if(line !=null)
                            {
                                Chat += line + "\n";
                            }
                            else
                            {
                                client.Close();
                                Chat += "Connected error" + "\n";
                            }
                        }
                        Task.Delay(10).Wait();
                    }
                    catch(Exception)
                    {

                    }
                }
            });
        }
        public AsyncCommand ConnectCommand
        {

        }
    }
}
