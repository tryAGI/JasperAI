#nullable enable

namespace JasperAI
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Search knowledge base<br/>
        /// Search the knowledge base using natural language queries. Returns relevant knowledge items with content chunks ranked by relevance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeSearchResponse> SearchKnowledgeAsync(

            global::JasperAI.KnowledgeSearchRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search knowledge base<br/>
        /// Search the knowledge base using natural language queries. Returns relevant knowledge items with content chunks ranked by relevance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.KnowledgeSearchResponse>> SearchKnowledgeAsResponseAsync(

            global::JasperAI.KnowledgeSearchRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search knowledge base<br/>
        /// Search the knowledge base using natural language queries. Returns relevant knowledge items with content chunks ranked by relevance.
        /// </summary>
        /// <param name="query">
        /// Natural language search query.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeSearchResponse> SearchKnowledgeAsync(
            string query,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}