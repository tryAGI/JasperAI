#nullable enable

namespace JasperAI
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Retrieve usage<br/>
        /// Retrieve API usage metrics for your workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.UsageResponse> GetUsageAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}