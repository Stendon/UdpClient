using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace UdpClient
{
    /// <summary>
    /// UDP封装类
    /// </summary>
    class UdpClient
    {
        public delegate void OnReceivceMsg(string msg);
        public event OnReceivceMsg receiveMsg;

        private Socket socket;
        private IPEndPoint localEndPort;
        private IPEndPoint serverEndPort;

        public UdpClient(string serverAddress, int serverPort)
        {
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            localEndPort = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            serverEndPort = new IPEndPoint(IPAddress.Parse(serverAddress), serverPort);

            socket.Bind(localEndPort);
        }

        public void SendMsg(string msg)
        {
            socket.SendTo(Encoding.UTF8.GetBytes(msg), serverEndPort);
        }

        public void Receive()
        {
            EndPoint s = serverEndPort;
            byte []buffer = new byte[1024];
            while(true)
            {
                int length = socket.ReceiveFrom(buffer, ref s);
                if(length > 0)
                {
                    string msg = Encoding.UTF8.GetString(buffer,0,length);
                    receiveMsg(msg);
                }
                else 
                    Thread.Sleep(100);
            }
        }
    }
}
