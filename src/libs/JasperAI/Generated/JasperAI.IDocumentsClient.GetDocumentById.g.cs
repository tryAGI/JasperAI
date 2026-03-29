#nullable enable

namespace JasperAI
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Retrieve document by ID<br/>
        /// Retrieve a specific document by its unique identifier.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.DocumentResponse> GetDocumentByIdAsync(
            string documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}