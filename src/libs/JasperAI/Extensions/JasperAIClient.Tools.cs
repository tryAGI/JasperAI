#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace JasperAI;

/// <summary>
/// Extensions for using JasperAIClient as MEAI tools with any IChatClient.
/// </summary>
public static class JasperAIClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that generates content using Jasper AI's command endpoint.
    /// </summary>
    public static AIFunction AsGenerateContentTool(this JasperAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The instruction/prompt for Jasper to generate content (e.g., 'Write a blog post about AI marketing')")] string command,
                   [Description("Optional background context to improve the generated output")] string? context,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Command.CommandAsync(
                    request: new CommandRequest
                    {
                        Inputs = new CommandInputs
                        {
                            Command = command,
                            Context = context,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCommandResponse(response);
            },
            name: "JasperAI_GenerateContent",
            description: "Generate AI marketing content using Jasper AI. Provide a command/prompt and optional context to generate high-quality copywriting, blog posts, ad copy, and more.");
    }

    /// <summary>
    /// Creates an AIFunction tool that searches Jasper's knowledge base.
    /// </summary>
    public static AIFunction AsSearchKnowledgeTool(this JasperAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Natural language search query to find relevant knowledge items")] string query,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Knowledge.SearchKnowledgeAsync(
                    request: new KnowledgeSearchRequest
                    {
                        Query = query,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatKnowledgeSearchResponse(response);
            },
            name: "JasperAI_SearchKnowledge",
            description: "Search Jasper AI's knowledge base using natural language. Returns relevant knowledge items with content chunks ranked by relevance score.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available agent tasks.
    /// </summary>
    public static AIFunction AsListTasksTool(this JasperAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional search term to filter tasks by name, description, or tags")] string? searchTerm,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Tasks.ListTasksAsync(
                    searchTerm: searchTerm,
                    includeCategories: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskListResponse(response);
            },
            name: "JasperAI_ListTasks",
            description: "List available agent tasks in Jasper AI. Tasks are pre-configured content generation workflows that can be run with context items.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists brand voices/tones.
    /// </summary>
    public static AIFunction AsListVoicesTool(this JasperAIClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Voices.GetAllTonesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatVoiceListResponse(response);
            },
            name: "JasperAI_ListVoices",
            description: "List all brand voices/tones available in the Jasper AI workspace. Voices define the tone and personality of generated content.");
    }

    private static string FormatCommandResponse(CommandResponse response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add("Generated Content:");
            foreach (var item in response.Data)
            {
                if (!string.IsNullOrWhiteSpace(item.Text))
                {
                    parts.Add(item.Text);
                }
            }
        }
        else
        {
            parts.Add("No content was generated.");
        }

        return string.Join("\n\n", parts);
    }

    private static string FormatKnowledgeSearchResponse(KnowledgeSearchResponse response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add("Knowledge Results:");
            foreach (var item in response.Data)
            {
                var entry = $"- **{item.Name}**";
                if (!string.IsNullOrWhiteSpace(item.Summary))
                {
                    entry += $": {item.Summary}";
                }

                parts.Add(entry);

                if (item.RelevantChunks is { Count: > 0 })
                {
                    foreach (var chunk in item.RelevantChunks)
                    {
                        if (!string.IsNullOrWhiteSpace(chunk.Content))
                        {
                            parts.Add($"  > {chunk.Content} (relevance: {chunk.Score:F2})");
                        }
                    }
                }
            }
        }
        else
        {
            parts.Add("No knowledge items found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatTaskListResponse(TaskListResponse response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add("Available Tasks:");
            foreach (var task in response.Data)
            {
                var entry = $"- **{task.Name}** (ID: {task.Id})";
                if (!string.IsNullOrWhiteSpace(task.Description))
                {
                    entry += $": {task.Description}";
                }

                parts.Add(entry);
            }

            if (response.Pagination?.TotalRecords is > 0)
            {
                parts.Add($"\nTotal: {response.Pagination.TotalRecords} tasks");
            }
        }
        else
        {
            parts.Add("No tasks found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatVoiceListResponse(VoiceListResponse response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add("Brand Voices:");
            foreach (var voice in response.Data)
            {
                var entry = $"- **{voice.Name}** (ID: {voice.Id})";
                if (!string.IsNullOrWhiteSpace(voice.Value))
                {
                    entry += $": {voice.Value}";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No voices found.");
        }

        return string.Join("\n", parts);
    }
}
