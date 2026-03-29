#nullable enable

namespace JasperAI;

public partial class JasperAIClient
{
    /// <summary>
    /// After Bearer auth is set, convert to X-API-Key header on the HttpClient.
    /// Jasper AI uses X-API-Key header instead of Authorization: Bearer.
    /// </summary>
    partial void Authorized(global::System.Net.Http.HttpClient client)
    {
        var apiKey = Authorizations.FirstOrDefault()?.Value;
        if (apiKey is { Length: > 0 })
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-API-Key", apiKey);
        }
    }
}
