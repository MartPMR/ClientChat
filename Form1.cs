using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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



        public Form1()
        {
            InitializeComponent();
        }
    }
}
