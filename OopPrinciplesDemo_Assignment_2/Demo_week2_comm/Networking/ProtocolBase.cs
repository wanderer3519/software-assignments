using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public abstract class ProtocolBase
    {
        
        protected void OpenSocket()
        {
            // Implementation for opening a socket
            Console.WriteLine("Opening socket.");
        }

        protected void CloseSocket()
        {
            // Implementation for closing a socket
            Console.WriteLine("Closing socket.");
        }

        protected void SetHandShake()
        {
            // Implementation for setting handshake
            Console.WriteLine("Setting handshake.");
        }

        protected abstract void SendData(string data, string ipAddress);

        protected abstract void SetProtocol();
    }
}
