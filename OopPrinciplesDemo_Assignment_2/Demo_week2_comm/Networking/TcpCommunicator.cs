using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public class TcpCommunicator: ProtocolBase, ICommunicator
    {
        public void SendMessage(string message, string ip)
        {
            // Implementation for sending a message over TCP
            // Console.WriteLine($"Sending message over TCP: {message}");
            OpenSocket();
            SetProtocol();
            SetHandShake();
            SendData(message, ip);
            CloseSocket();
        }

        protected override void SetProtocol()
        {
            // Implementation for setting the protocol for TCP communication
            Console.WriteLine("Setting TCP protocol.");
        }

        protected override void SendData(string data, string ipAddress)
        {
            Console.WriteLine($"Sending data to {ipAddress} via TCP: {data}");
        }

    }
}
