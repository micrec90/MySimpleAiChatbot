using OllamaSharp;
using OllamaSharp.Models.Chat;

namespace MySimpleAiChatbot
{
    public class OllamaClient : IAiClient
    {
        OllamaApiClient ollama;
        List<Message> history;
        public OllamaClient()
        {
            ollama = new OllamaApiClient(new Uri("http://localhost:11434"), "llama3");
            history = new List<Message>();
            history.Add(new Message { Role = "assistant", Content = "Hello! It's nice to meet you. Is there something I can help you with, or would you like to chat?" });
            Console.WriteLine(history[0].Content);
        }

        public async Task ProcessMessage(string input)
        {
            history.Add(new Message { Role = "user", Content = input });
            ChatRequest request = new ChatRequest { Messages = history };

            Message? lastMessage = null;

            Console.Write("Ollama assistant: ");
            await foreach (var response in ollama.ChatAsync(request))
            {
                if(lastMessage == null)
                {
                    lastMessage = new Message { Role = "assistant", Content = "" };
                    history.Add(lastMessage);
                }
                lastMessage.Content += response.Message?.Content;
                Console.Write(response.Message?.Content);
            }
            Console.WriteLine();
        }
    }
}
