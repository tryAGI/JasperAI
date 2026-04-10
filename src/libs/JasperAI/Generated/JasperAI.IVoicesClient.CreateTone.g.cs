#nullable enable

namespace JasperAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create a voice<br/>
        /// Create a new brand voice/tone for content generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.VoiceResponse> CreateToneAsync(

            global::JasperAI.VoiceCreateRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice<br/>
        /// Create a new brand voice/tone for content generation.
        /// </summary>
        /// <param name="name">
        /// The friendly name of the voice.
        /// </param>
        /// <param name="value">
        /// The voice's description.
        /// </param>
        /// <param name="metadata">
        /// Optional key-value pairs.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.VoiceResponse> CreateToneAsync(
            string name,
            string value,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::JasperAI.VoiceSettings? settings = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}