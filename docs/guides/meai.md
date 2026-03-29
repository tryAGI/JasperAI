# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The JasperAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Jasper's content generation, knowledge base search, task listing, and brand voice management.

## Installation

```bash
dotnet add package JasperAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsGenerateContentTool()` | `JasperAI_GenerateContent` | Generate AI marketing content from a command/prompt with optional context |
| `AsSearchKnowledgeTool()` | `JasperAI_SearchKnowledge` | Search the knowledge base with natural language |
| `AsListTasksTool()` | `JasperAI_ListTasks` | List available agent tasks with optional search |
| `AsListVoicesTool()` | `JasperAI_ListVoices` | List brand voices/tones in the workspace |

## Usage

```csharp
using JasperAI;
using Microsoft.Extensions.AI;

var jasperClient = new JasperAIClient(
    apiKey: Environment.GetEnvironmentVariable("JASPERAI_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        jasperClient.AsGenerateContentTool(),
        jasperClient.AsSearchKnowledgeTool(),
        jasperClient.AsListTasksTool(),
        jasperClient.AsListVoicesTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Generate a blog post introduction about AI in healthcare."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
