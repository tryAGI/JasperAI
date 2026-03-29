#nullable enable

namespace JasperAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Retrieve all voices<br/>
        /// Retrieve all brand voices/tones available in your workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.VoiceListResponse> GetAllTonesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}