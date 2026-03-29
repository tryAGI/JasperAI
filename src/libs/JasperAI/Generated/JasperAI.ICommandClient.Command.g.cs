#nullable enable

namespace JasperAI
{
    public partial interface ICommandClient
    {
        /// <summary>
        /// Run a command<br/>
        /// Run a command to generate AI content. The command endpoint provides a flexible way to generate content by passing in a command (prompt) and context.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.CommandResponse> CommandAsync(

            global::JasperAI.CommandRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a command<br/>
        /// Run a command to generate AI content. The command endpoint provides a flexible way to generate content by passing in a command (prompt) and context.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.CommandResponse> CommandAsync(
            global::JasperAI.CommandInputs inputs,
            global::JasperAI.CommandOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}