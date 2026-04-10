#nullable enable

namespace JasperAI
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Update knowledge item<br/>
        /// Update an existing knowledge item by its ID.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeItemResponse> UpdateKnowledgeDocumentAsync(
            string knowledgeId,

            global::JasperAI.KnowledgeUpdateRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update knowledge item<br/>
        /// Update an existing knowledge item by its ID.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="name">
        /// Updated name (max 100 chars).
        /// </param>
        /// <param name="metadata">
        /// Updated metadata key-value pairs.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="summary">
        /// Updated summary.
        /// </param>
        /// <param name="tags">
        /// Updated tags.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeItemResponse> UpdateKnowledgeDocumentAsync(
            string knowledgeId,
            string? name = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::JasperAI.KnowledgeSettings? settings = default,
            string? summary = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}