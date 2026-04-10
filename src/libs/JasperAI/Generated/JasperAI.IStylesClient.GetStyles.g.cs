#nullable enable

namespace JasperAI
{
    public partial interface IStylesClient
    {
        /// <summary>
        /// Retrieve all style guides<br/>
        /// Returns a list of style guides available in your workspace, sorted from most recently created.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.StyleGuideListResponse> GetStylesAsync(
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}