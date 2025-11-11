namespace MySimpleAiChatbot
{
    public interface IAiClient
    {
        Task ProcessMessage(string input);
    }
}
