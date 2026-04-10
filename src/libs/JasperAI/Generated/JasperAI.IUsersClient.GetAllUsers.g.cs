#nullable enable

namespace JasperAI
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve users<br/>
        /// Retrieve a paginated list of users in the workspace.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.UserListResponse> GetAllUsersAsync(
            int? limit = default,
            int? page = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}