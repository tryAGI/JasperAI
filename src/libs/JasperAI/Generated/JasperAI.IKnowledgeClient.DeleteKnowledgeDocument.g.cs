#nullable enable

namespace JasperAI
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Delete knowledge item<br/>
        /// Delete a knowledge item by its unique identifier.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteKnowledgeDocumentAsync(
            string knowledgeId,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}