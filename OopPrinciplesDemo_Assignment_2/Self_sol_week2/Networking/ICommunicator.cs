namespace Networking
{
    public interface ICommunicator
    {
        void SendMessage(string message, string ip);
    }
}
