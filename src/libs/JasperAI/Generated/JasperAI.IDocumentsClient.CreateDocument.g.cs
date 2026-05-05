#nullable enable

namespace JasperAI
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Create document<br/>
        /// Create a new document in the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.DocumentResponse> CreateDocumentAsync(

            global::JasperAI.DocumentCreateRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create document<br/>
        /// Create a new document in the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.DocumentResponse>> CreateDocumentAsResponseAsync(

            global::JasperAI.DocumentCreateRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create document<br/>
        /// Create a new document in the workspace.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user creating the document.
        /// </param>
        /// <param name="content">
        /// The content of the document.
        /// </param>
        /// <param name="name">
        /// The name of the document.
        /// </param>
        /// <param name="status">
        /// The status of the document.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.DocumentResponse> CreateDocumentAsync(
            string userId,
            string content,
            string name,
            global::JasperAI.DocumentCreateRequestStatus? status = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}