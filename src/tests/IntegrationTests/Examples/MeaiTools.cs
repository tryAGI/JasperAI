/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace JasperAI.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// Jasper AI provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("JASPERAI_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("JASPERAI_API_KEY environment variable is not found.");

        using var client = new JasperAIClient(apiKey);

        //// Create tools for content generation, knowledge search, task listing, and voice listing.
        var generateContentTool = client.AsGenerateContentTool();
        var searchKnowledgeTool = client.AsSearchKnowledgeTool();
        var listTasksTool = client.AsListTasksTool();
        var listVoicesTool = client.AsListVoicesTool();

        Assert.AreEqual("JasperAI_GenerateContent", generateContentTool.Name);
        Assert.AreEqual("JasperAI_SearchKnowledge", searchKnowledgeTool.Name);
        Assert.AreEqual("JasperAI_ListTasks", listTasksTool.Name);
        Assert.AreEqual("JasperAI_ListVoices", listVoicesTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { generateContentTool, searchKnowledgeTool, listTasksTool, listVoicesTool };
        Assert.AreEqual(4, tools.Length);
    }
}
