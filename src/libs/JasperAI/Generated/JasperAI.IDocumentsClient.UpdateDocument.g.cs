#nullable enable

namespace JasperAI
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Update document<br/>
        /// Update an existing document by its unique identifier.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.DocumentResponse> UpdateDocumentAsync(
            string documentId,

            global::JasperAI.DocumentUpdateRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update document<br/>
        /// Update an existing document by its unique identifier.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.DocumentResponse>> UpdateDocumentAsResponseAsync(
            string documentId,

            global::JasperAI.DocumentUpdateRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update document<br/>
        /// Update an existing document by its unique identifier.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="content">
        /// Updated document content.
        /// </param>
        /// <param name="name">
        /// Updated document name.
        /// </param>
        /// <param name="status">
        /// Updated document status.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.DocumentResponse> UpdateDocumentAsync(
            string documentId,
            string? content = default,
            string? name = default,
            global::JasperAI.DocumentUpdateRequestStatus? status = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}