#nullable enable

namespace JasperAI
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// List all agent tasks<br/>
        /// Retrieve a paginated list of agent tasks available in your workspace.
        /// </summary>
        /// <param name="size">
        /// Default Value: 100
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="scope"></param>
        /// <param name="includeContextItems">
        /// Default Value: false
        /// </param>
        /// <param name="includeCategories">
        /// Default Value: false
        /// </param>
        /// <param name="searchTerm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.TaskListResponse> ListTasksAsync(
            int? size = default,
            int? page = default,
            global::JasperAI.ListTasksScope? scope = default,
            bool? includeContextItems = default,
            bool? includeCategories = default,
            string? searchTerm = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}