#nullable enable

namespace JasperAI
{
    public partial interface IAudiencesClient
    {
        /// <summary>
        /// Get audience by ID<br/>
        /// Retrieve a specific target audience by its unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AudienceResponse> GetAudienceByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}