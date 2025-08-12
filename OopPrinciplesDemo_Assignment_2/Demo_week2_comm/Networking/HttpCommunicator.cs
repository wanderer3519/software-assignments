using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public class HttpCommunicator : ProtocolBase, ICommunicator
    {
        public void SendMessage(string message, string ip)
        {
            OpenSocket();
            SetProtocol();
            SetHandShake();
            SendData(message, ip);
            CloseSocket();
        }

        protected override void SetProtocol()
        {
            Console.WriteLine("Setting HTTP protocol.");
        }

        protected override void SendData(string data, string ipAddress)
        {
            // Implementation for sending data over HTTP
            Console.WriteLine($"Sending data to {ipAddress} via HTTP: {data}");
        }
    }
}
