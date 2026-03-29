#nullable enable

namespace JasperAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Retrieve voice by ID<br/>
        /// Retrieve a specific brand voice by its unique identifier.
        /// </summary>
        /// <param name="toneId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.VoiceResponse> GetToneAsync(
            string toneId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}