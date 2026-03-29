#nullable enable

namespace JasperAI
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Retrieve knowledge item by ID<br/>
        /// Retrieve a specific knowledge item by its unique identifier.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.KnowledgeItemResponse> GetKnowledgeDocumentAsync(
            string knowledgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}