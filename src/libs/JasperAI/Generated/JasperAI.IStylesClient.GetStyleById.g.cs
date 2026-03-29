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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.StyleGuideResponse> GetStyleByIdAsync(
            string styleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}