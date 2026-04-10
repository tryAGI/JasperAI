#nullable enable

namespace JasperAI
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Retrieve knowledge items<br/>
        /// Retrieve knowledge items with optional search and filtering.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="size"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeResponse> GetKnowledgeDocumentsAsync(
            string? search = default,
            int? size = default,
            int? page = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}