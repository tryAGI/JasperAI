#nullable enable

namespace JasperAI
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve user by ID<br/>
        /// Retrieve a specific user by their unique identifier.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.UserResponse> GetUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}