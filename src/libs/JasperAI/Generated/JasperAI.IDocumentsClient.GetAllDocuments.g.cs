#nullable enable

namespace JasperAI
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Retrieve documents<br/>
        /// Retrieve a paginated list of documents from your workspace.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="size">
        /// Default Value: 50
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort"></param>
        /// <param name="name"></param>
        /// <param name="statuses"></param>
        /// <param name="createdAtStart"></param>
        /// <param name="createdAtEnd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.DocumentListResponse> GetAllDocumentsAsync(
            string? userId = default,
            int? size = default,
            int? page = default,
            global::JasperAI.GetAllDocumentsSort? sort = default,
            string? name = default,
            string? statuses = default,
            global::System.DateTime? createdAtStart = default,
            global::System.DateTime? createdAtEnd = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve documents<br/>
        /// Retrieve a paginated list of documents from your workspace.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="size">
        /// Default Value: 50
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort"></param>
        /// <param name="name"></param>
        /// <param name="statuses"></param>
        /// <param name="createdAtStart"></param>
        /// <param name="createdAtEnd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.DocumentListResponse>> GetAllDocumentsAsResponseAsync(
            string? userId = default,
            int? size = default,
            int? page = default,
            global::JasperAI.GetAllDocumentsSort? sort = default,
            string? name = default,
            string? statuses = default,
            global::System.DateTime? createdAtStart = default,
            global::System.DateTime? createdAtEnd = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}