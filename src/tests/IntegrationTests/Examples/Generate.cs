/* order: 10, title: Generate Content, slug: generate-content */

namespace JasperAI.IntegrationTests.Examples;

[TestClass]
public class GenerateContent
{
    //// Jasper AI's Command endpoint provides a flexible way to generate
    //// marketing content by passing a command (prompt) and optional context.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("JASPERAI_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("JASPERAI_API_KEY environment variable is not found.");

        using var client = new JasperAIClient(apiKey);

        //// The client provides access to all Jasper AI API endpoints
        //// through sub-clients: Command, Tasks, Knowledge, Voices, Styles, Documents, Users, Audiences, Usage.
        Assert.IsNotNull(client.Command);
        Assert.IsNotNull(client.Tasks);
        Assert.IsNotNull(client.Knowledge);
        Assert.IsNotNull(client.Voices);
    }
}
