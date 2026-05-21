#nullable enable

namespace JasperAI
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Run an agent task<br/>
        /// Execute an agent task with provided context items.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.TaskRunResponse> RunTaskAsync(
            string id,

            global::JasperAI.TaskRunRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run an agent task<br/>
        /// Execute an agent task with provided context items.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.TaskRunResponse>> RunTaskAsResponseAsync(
            string id,

            global::JasperAI.TaskRunRequest request,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run an agent task<br/>
        /// Execute an agent task with provided context items.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contextItems">
        /// Array of context items for task execution.
        /// </param>
        /// <param name="version">
        /// Agent task version (defaults to latest).
        /// </param>
        /// <param name="toLanguage">
        /// Target output language (defaults to EN-US).
        /// </param>
        /// <param name="knowledgeIds">
        /// Knowledge IDs for context.
        /// </param>
        /// <param name="toneId">
        /// Tone ID for brand voice.
        /// </param>
        /// <param name="audienceId">
        /// Audience ID for customization.
        /// </param>
        /// <param name="styleGuideId">
        /// Style Guide ID for writing rules.
        /// </param>
        /// <param name="tools">
        /// Tools to enable for execution.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::JasperAI.TaskRunResponse> RunTaskAsync(
            string id,
            global::System.Collections.Generic.IList<global::JasperAI.TaskContextItemPredefined> contextItems,
            double? version = default,
            string? toLanguage = default,
            global::System.Collections.Generic.IList<string>? knowledgeIds = default,
            string? toneId = default,
            string? audienceId = default,
            string? styleGuideId = default,
            global::System.Collections.Generic.IList<global::JasperAI.TaskRunRequestTool>? tools = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}