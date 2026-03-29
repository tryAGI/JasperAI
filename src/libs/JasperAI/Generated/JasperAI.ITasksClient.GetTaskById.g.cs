#nullable enable

namespace JasperAI
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get agent task by ID<br/>
        /// Retrieve a specific agent task by its unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.TaskGetResponse> GetTaskByIdAsync(
            string id,
            double? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}