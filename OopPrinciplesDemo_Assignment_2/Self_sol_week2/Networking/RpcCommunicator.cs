using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public class RpcCommunicator: ICommunicator
    {
        public void SendMessage(string message, string ip)
        {
            Console.WriteLine($"Sending Message:{message} to device ip:{ip}");
        }
    }
}
