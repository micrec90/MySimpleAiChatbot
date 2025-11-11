namespace MySimpleAiChatbot
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //IAiClient client = new OpenAiClient();
            IAiClient client = new OllamaClient();
            while (true)
            {
                Console.Write("User: ");
                var input = Console.ReadLine();

                if (input == null || input.Trim().ToLower() == "exit")
                    break;
                await client.ProcessMessage(input);
            }
        }
    }
}
