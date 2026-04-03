
#nullable enable

namespace JasperAI
{
    public partial class TasksClient
    {
        partial void PrepareListTasksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? size,
            ref int? page,
            ref global::JasperAI.ListTasksScope? scope,
            ref bool? includeContextItems,
            ref bool? includeCategories,
            ref string? searchTerm);
        partial void PrepareListTasksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? size,
            int? page,
            global::JasperAI.ListTasksScope? scope,
            bool? includeContextItems,
            bool? includeCategories,
            string? searchTerm);
        partial void ProcessListTasksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTasksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::JasperAI.TaskListResponse> ListTasksAsync(
            int? size = default,
            int? page = default,
            global::JasperAI.ListTasksScope? scope = default,
            bool? includeContextItems = default,
            bool? includeCategories = default,
            string? searchTerm = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListTasksArguments(
                httpClient: HttpClient,
                size: ref size,
                page: ref page,
                scope: ref scope,
                includeContextItems: ref includeContextItems,
                includeCategories: ref includeCategories,
                searchTerm: ref searchTerm);

            var __pathBuilder = new global::JasperAI.PathBuilder(
                path: "/tasks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("size", size?.ToString())
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("scope", scope?.ToValueString())
                .AddOptionalParameter("includeContextItems", includeContextItems?.ToString().ToLowerInvariant())
                .AddOptionalParameter("includeCategories", includeCategories?.ToString().ToLowerInvariant())
                .AddOptionalParameter("searchTerm", searchTerm) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListTasksRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                size: size,
                page: page,
                scope: scope,
                includeContextItems: includeContextItems,
                includeCategories: includeCategories,
                searchTerm: searchTerm);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListTasksResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Internal server error.
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::JasperAI.ErrorResponse? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::JasperAI.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::JasperAI.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::JasperAI.ApiException<global::JasperAI.ErrorResponse>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListTasksResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::JasperAI.TaskListResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::JasperAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::JasperAI.TaskListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::JasperAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}