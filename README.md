# MySimpleAiChatbot
A simple AI chatbot using OpenAI's model as well as Ollama.

## OpenAI

### 📦 Prerequisites

1. Create an account at [openai.com](https://openai.com/)
2. Generate an API key at [platform.openai.com/api-keys](https://platform.openai.com/api-keys)
3. Set it as an environment variable:
  
    **Linux / macOS:**
    
    ```bash
    export OPENAI_API_KEY="your-key-here"
    ```
    **Windows (PowerShell):**
    ```cmd
    setx OPENAI_API_KEY "your-key-here"
    ```
4. Download and install dotenv.net and OpenAI NuGet packages:

    **Using the .NET CLI:**
    ```bash
    dotnet add package dotenv.net
    dotnet add package OpenAI
    ```
    **Using the Package Manager Console:**
    ```bash
    Install-Package dotenv.net
    Install-Package OpenAI
    ```
    
## Ollama

### 📦 Prerequisites

1. Download Ollama from the official [Ollama download section](https://ollama.com/download)
2. Download and install the OllamaSharp NuGet package:

    **Using the .NET CLI:**
    ```bash
    dotnet add package OllamaSharp
    ```
    **Using the Package Manager Console:**
    ```bash
    Install-Package OllamaSharp
    ```
3. Pull a model of your choice:

    ```bash
    ollama pull llama3
    ```
