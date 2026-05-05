#nullable enable

namespace JasperAI
{
    public partial interface IStylesClient
    {
        /// <summary>
        /// Retrieve style guide by ID<br/>
        /// Retrieve a specific style guide by its unique identifier.
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.StyleGuideResponse> GetStyleByIdAsync(
            string styleId,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve style guide by ID<br/>
        /// Retrieve a specific style guide by its unique identifier.
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.StyleGuideResponse>> GetStyleByIdAsResponseAsync(
            string styleId,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}