#nullable enable

namespace JasperAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Retrieve all voices<br/>
        /// Retrieve all brand voices/tones available in your workspace.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.VoiceListResponse> GetAllTonesAsync(
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all voices<br/>
        /// Retrieve all brand voices/tones available in your workspace.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.VoiceListResponse>> GetAllTonesAsResponseAsync(
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}