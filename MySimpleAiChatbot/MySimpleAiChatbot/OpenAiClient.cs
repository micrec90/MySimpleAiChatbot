using dotenv.net;
using OpenAI.Chat;

namespace MySimpleAiChatbot
{
    public class OpenAiClient : IAiClient
    {
        private ChatClient chatClient;
        private List<ChatMessage> messages;
        public OpenAiClient()
        {
            DotEnv.Load();
            var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            if (string.IsNullOrEmpty(apiKey))
                throw new InvalidOperationException("Missing environment variable: OPENAI_API_KEY.");
            chatClient = new ChatClient("gpt-5", apiKey);
            messages = new List<ChatMessage>();
            messages.Add(new AssistantChatMessage("Hello! Ask me anything."));
            Console.WriteLine(messages[0].Content[0].Text);
        }
        public async Task ProcessMessage(string input)
        {
            messages.Add(new UserChatMessage(input));
            ChatCompletion completion = await chatClient.CompleteChatAsync(messages);
            string response = completion.Content[0].Text;
            messages.Add(new AssistantChatMessage(response));
            Console.WriteLine("OpenAI assistant: " + response);
        }
    }
}
