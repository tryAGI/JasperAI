#nullable enable

namespace JasperAI
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Create knowledge item<br/>
        /// Upload a file to create a new knowledge item. Supports txt, pdf, doc, and docx files (max 300MB).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeResponse> UploadKnowledgeDocumentAsync(

            global::JasperAI.UploadKnowledgeDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create knowledge item<br/>
        /// Upload a file to create a new knowledge item. Supports txt, pdf, doc, and docx files (max 300MB).
        /// </summary>
        /// <param name="name">
        /// Friendly name for the knowledge item.
        /// </param>
        /// <param name="file">
        /// File to upload (txt, pdf, doc, docx, max 300MB).
        /// </param>
        /// <param name="filename">
        /// File to upload (txt, pdf, doc, docx, max 300MB).
        /// </param>
        /// <param name="metadata">
        /// JSON string of key-value metadata pairs.
        /// </param>
        /// <param name="settings">
        /// JSON string with appVisibility and autoSummary settings.
        /// </param>
        /// <param name="summary">
        /// Manual knowledge item summary.
        /// </param>
        /// <param name="tags">
        /// Searchable tags.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeResponse> UploadKnowledgeDocumentAsync(
            string name,
            byte[] file,
            string filename,
            string? metadata = default,
            string? settings = default,
            string? summary = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}