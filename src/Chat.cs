using Chat.src.network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.src
{
    class Chat
    {
        Chat()
        {
            
        }
        public void RunListener()
        {
            while (true)
            {
                string message = MulticastManager.listener.TryToLiesten();


            }
        }

        public void RunSender()
        {
            while (true)
            {
                string message = Console.ReadLine();

                MulticastManager.sender.SendMessage(message);
            }
        }


    }
}
