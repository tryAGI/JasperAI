#nullable enable

namespace JasperAI
{
    public partial interface IAudiencesClient
    {
        /// <summary>
        /// List all audiences<br/>
        /// Retrieve all target audiences defined in the workspace.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AudienceListResponse> GetAudiencesAsync(
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}