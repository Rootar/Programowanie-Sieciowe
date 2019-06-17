using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat.src.network
{
    class MulticastListener
    {
        UdpClient udpClient;
        IPEndPoint endPoint;
        public MulticastListener(IPAddress ip, int port)
        {
            udpClient = new UdpClient();
            udpClient.ExclusiveAddressUse = false;
            udpClient.Client.SetSocketOption(SocketOptionLevel.Socket,
                SocketOptionName.ReuseAddress, true);
            udpClient.ExclusiveAddressUse = false;


            endPoint = new IPEndPoint(IPAddress.Any, port);

            udpClient.Client.Bind(endPoint);
            udpClient.JoinMulticastGroup(ip);            
        }

        //public bool CheckIfNicknameIsAvailable()
        //{
        //    udpClient.Client.ReceiveTimeout = 10000;
        //    var result = udpClient.ReceiveAsync();
        //    result.Wait(10000);
        //    Console.WriteLine( result.Result.ToString());
        //    //string answer =
        //    //    Encoding.Unicode.GetString(udpClient.ReceiveAsync();

        //    //if (answer == null)
        //    //    return true;
        //    return false;
        //}

        public string TryToLiesten()
        {
            string message =
                Encoding.Unicode.GetString(udpClient.Receive(ref endPoint));

            return message;
            //if (message.StartsWith("NICK"))
            //{
            //    if(message.Split(' ')[1].Equals(Program.nickname))
            //    {
            //        Program.multicastSender.NicknameIsBusyNotify();
            //    }
            //} else
            //{
            //    Console.WriteLine(message);
            //}
        }

        //public void RunListener()
        //{
        //    while (true)
        //    {
        //        TryToLiesten();
        //    }
        //}
    }
}
