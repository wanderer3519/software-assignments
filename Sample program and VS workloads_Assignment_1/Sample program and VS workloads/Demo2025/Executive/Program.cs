using Networking;

namespace Executive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpCommunicator communicator = new TcpCommunicator();

            // Send a message and display the message count.
            communicator.SendMessage("Hello from here", "127.0.0.1");
            int messageCount = communicator.MessageCount;
            Console.WriteLine($"Total messages sent: {messageCount}");

            // Send another message and display the updated message count.
            communicator.SendMessage("Second message", "127.0.0.1");
            messageCount = communicator.MessageCount;
            Console.WriteLine($"Total messages sent: {messageCount}");

            Console.WriteLine("Press any key to exit...");
        }
    }
}
