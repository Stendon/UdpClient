using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UdpClient
{
    public partial class MainForm : Form
    {
        private UdpClient udpClient;
        private Thread recvThread;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            udpClient = new UdpClient("127.0.0.1", 44000);
            udpClient.receiveMsg += OnUpdateRecvMessage;
            recvThread = new Thread(udpClient.Receive);
            recvThread.Start();
        }

        private void OnSendMsgButtonClick(object sender, EventArgs e)
        {
            udpClient.SendMsg(MessageTextBox.Text);
            MessageDisplayTextBox.AppendText(MessageTextBox.Text + "\r\n");
            MessageDisplayTextBox.Refresh();
            MessageTextBox.Clear();
        }

        private void OnCloseWindowButtonClick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void OnUpdateRecvMessage(string msg)
        {
            if(MessageDisplayTextBox.InvokeRequired)
            {
                UdpClient.OnReceivceMsg recvMessage = new UdpClient.OnReceivceMsg(OnUpdateRecvMessage);
                this.Invoke(recvMessage, msg);
            }
            else
            {
                MessageDisplayTextBox.AppendText(msg+ "\r\n");
                MessageDisplayTextBox.Refresh();
            }
        }

        private void CloseWindow()
        {
            if (recvThread.IsAlive)
                recvThread.Join();

            this.Close();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                udpClient.SendMsg(MessageTextBox.Text);
                MessageDisplayTextBox.AppendText(MessageTextBox.Text + "\r\n");
                MessageDisplayTextBox.Refresh();
                MessageTextBox.Clear();
            }
        }
    }
}
