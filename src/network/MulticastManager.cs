using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat.src.network
{
    class MulticastManager
    {
        private static string ipAddress = "239.0.0.222";

        private static IPAddress multicastAddress;
        private static int port = 2222;

        public static MulticastListener listener;
        public static MulticastSender sender;

        static MulticastManager()
        {
            multicastAddress = IPAddress.Parse(ipAddress);
            listener = new MulticastListener(multicastAddress, port);
            sender = new MulticastSender(multicastAddress, port);
        }        
    }
}
