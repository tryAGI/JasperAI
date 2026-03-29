namespace JasperAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static JasperAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("JASPERAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("JASPERAI_API_KEY environment variable is not found.");

        var client = new JasperAIClient(apiKey);

        return client;
    }
}
