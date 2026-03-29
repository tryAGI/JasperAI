#nullable enable

namespace JasperAI
{
    public partial interface IAudiencesClient
    {
        /// <summary>
        /// List all audiences<br/>
        /// Retrieve all target audiences defined in the workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AudienceListResponse> GetAudiencesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}