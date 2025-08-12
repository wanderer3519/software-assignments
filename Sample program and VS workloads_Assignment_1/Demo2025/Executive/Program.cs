using Networking;

namespace Executive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TcpCommunicator tcpCommunicator = new TcpCommunicator();
            HttpCommunicator httpCommunicator = new HttpCommunicator();

            // Send a message via HTTP and display the message count.
            httpCommunicator.SendMessage("Hello from http 1", "127.0.0.1");
            int httpMessageCount = httpCommunicator.MessageCount;
            Console.WriteLine($"Total messages sent: {httpMessageCount}");

            // Send a message and display the message count.
            // tcpCommunicator.SendMessage("Hello from here", "127.0.0.1");
            // int tcpMessageCount = tcpCommunicator.MessageCount;
            // Console.WriteLine($"Total messages sent: {tcpMessageCount}");

            // Send another message and display the updated message count.
            // tcpCommunicator.SendMessage("Second message", "127.0.0.1");
            // tcpMessageCount = tcpCommunicator.MessageCount;
            // Console.WriteLine($"Total messages sent: {tcpMessageCount}");

            // Console.WriteLine("Press any key to exit...");
        }
    }
}
