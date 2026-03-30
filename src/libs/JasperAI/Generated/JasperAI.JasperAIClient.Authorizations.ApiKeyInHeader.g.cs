
#nullable enable

namespace JasperAI
{
    public sealed partial class JasperAIClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::JasperAI.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-Key",
                Value = apiKey,
            });
        }
    }
}