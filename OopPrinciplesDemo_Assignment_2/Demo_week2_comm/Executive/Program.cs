using Networking;

namespace Executive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommunicator communicator1 = new TcpCommunicator();
            ICommunicator communicator2 = new HttpCommunicator();
            ICommunicator communicator3 = new RpcCommunicator();
            if (communicator1 != null) {
                communicator1.SendMessage("Hello from TCP", "12.45.4.3");
            }

            if(communicator2 != null)
            {
                communicator2.SendMessage("Hello from HTTP", "12.45.4.3");
            }

            if(communicator3 != null)
            {
                communicator3.SendMessage("Hello from RPC", "12.45.4.3");
            }
        }
    }
}
