#nullable enable

namespace JasperAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update voice by ID<br/>
        /// Update an existing brand voice by its unique identifier.
        /// </summary>
        /// <param name="toneId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.VoiceResponse> UpdateToneAsync(
            string toneId,

            global::JasperAI.VoiceUpdateRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice by ID<br/>
        /// Update an existing brand voice by its unique identifier.
        /// </summary>
        /// <param name="toneId"></param>
        /// <param name="name">
        /// Updated voice name.
        /// </param>
        /// <param name="value">
        /// Updated voice description.
        /// </param>
        /// <param name="metadata">
        /// Updated metadata.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.VoiceResponse> UpdateToneAsync(
            string toneId,
            string? name = default,
            string? value = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::JasperAI.VoiceSettings? settings = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}