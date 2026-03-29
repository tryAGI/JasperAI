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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.UserListResponse> GetAllUsersAsync(
            int? limit = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}