using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat.src.network
{
    class MulticastSender
    {
        private UdpClient udpClient;
        IPEndPoint endPoint;
        public MulticastSender(IPAddress ip, int port)
        {
            udpClient = new UdpClient();
            udpClient.JoinMulticastGroup(ip);

            endPoint = new IPEndPoint(ip, port);
        }
        public void SendMessage(string message)
        {
            Byte[] buffer = Encoding.Unicode.GetBytes(message.Trim());

            udpClient.Send(buffer,
                buffer.Length, endPoint);
        }

        //public void RunSender()
        //{
        //    while (true)
        //    {
        //        string line = Console.ReadLine();



        //        if (line != null)
        //        {
        //            SendMessage(Program.nickname + ": "+ line);
        //        }
        //    }            
        //}

        //public void RegisterNickname(string nickname)
        //{
        //    SendMessage("NICK " + nickname);
        //}

        //public void NicknameIsBusyNotify()
        //{
        //    SendMessage("NICK " + Program.nickname + " BUSY");
        //}
    }
}
