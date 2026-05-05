
#nullable enable

namespace JasperAI
{
    public partial class DocumentsClient
    {


        private static readonly global::JasperAI.EndPointSecurityRequirement s_GetAllDocumentsSecurityRequirement0 =
            new global::JasperAI.EndPointSecurityRequirement
            {
                Authorizations = new global::JasperAI.EndPointAuthorizationRequirement[]
                {                    new global::JasperAI.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::JasperAI.EndPointSecurityRequirement[] s_GetAllDocumentsSecurityRequirements =
            new global::JasperAI.EndPointSecurityRequirement[]
            {                s_GetAllDocumentsSecurityRequirement0,
            };
        partial void PrepareGetAllDocumentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? userId,
            ref int? size,
            ref int? page,
            ref global::JasperAI.GetAllDocumentsSort? sort,
            ref string? name,
            ref string? statuses,
            ref global::System.DateTime? createdAtStart,
            ref global::System.DateTime? createdAtEnd);
        partial void PrepareGetAllDocumentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? userId,
            int? size,
            int? page,
            global::JasperAI.GetAllDocumentsSort? sort,
            string? name,
            string? statuses,
            global::System.DateTime? createdAtStart,
            global::System.DateTime? createdAtEnd);
        partial void ProcessGetAllDocumentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAllDocumentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve documents<br/>
        /// Retrieve a paginated list of documents from your workspace.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="size">
        /// Default Value: 50
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort"></param>
        /// <param name="name"></param>
        /// <param name="statuses"></param>
        /// <param name="createdAtStart"></param>
        /// <param name="createdAtEnd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::JasperAI.DocumentListResponse> GetAllDocumentsAsync(
            string? userId = default,
            int? size = default,
            int? page = default,
            global::JasperAI.GetAllDocumentsSort? sort = default,
            string? name = default,
            string? statuses = default,
            global::System.DateTime? createdAtStart = default,
            global::System.DateTime? createdAtEnd = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAllDocumentsAsResponseAsync(
                userId: userId,
                size: size,
                page: page,
                sort: sort,
                name: name,
                statuses: statuses,
                createdAtStart: createdAtStart,
                createdAtEnd: createdAtEnd,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Retrieve documents<br/>
        /// Retrieve a paginated list of documents from your workspace.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="size">
        /// Default Value: 50
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort"></param>
        /// <param name="name"></param>
        /// <param name="statuses"></param>
        /// <param name="createdAtStart"></param>
        /// <param name="createdAtEnd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::JasperAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::JasperAI.AutoSDKHttpResponse<global::JasperAI.DocumentListResponse>> GetAllDocumentsAsResponseAsync(
            string? userId = default,
            int? size = default,
            int? page = default,
            global::JasperAI.GetAllDocumentsSort? sort = default,
            string? name = default,
            string? statuses = default,
            global::System.DateTime? createdAtStart = default,
            global::System.DateTime? createdAtEnd = default,
            global::JasperAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAllDocumentsArguments(
                httpClient: HttpClient,
                userId: ref userId,
                size: ref size,
                page: ref page,
                sort: ref sort,
                name: ref name,
                statuses: ref statuses,
                createdAtStart: ref createdAtStart,
                createdAtEnd: ref createdAtEnd);


            var __authorizations = global::JasperAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAllDocumentsSecurityRequirements,
                operationName: "GetAllDocumentsAsync");

            using var __timeoutCancellationTokenSource = global::JasperAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::JasperAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::JasperAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::JasperAI.PathBuilder(
                                path: "/documents",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("userId", userId)
                                .AddOptionalParameter("size", size?.ToString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("sort", sort?.ToValueString())
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("statuses", statuses)
                                .AddOptionalParameter("createdAtStart", createdAtStart?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("createdAtEnd", createdAtEnd?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::JasperAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::JasperAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetAllDocumentsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    userId: userId,
                    size: size,
                    page: page,
                    sort: sort,
                    name: name,
                    statuses: statuses,
                    createdAtStart: createdAtStart,
                    createdAtEnd: createdAtEnd);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::JasperAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::JasperAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetAllDocuments",
                                methodName: "GetAllDocumentsAsync",
                                pathTemplate: "\"/documents\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::JasperAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::JasperAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::JasperAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetAllDocuments",
                                methodName: "GetAllDocumentsAsync",
                                pathTemplate: "\"/documents\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::JasperAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::JasperAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::JasperAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::JasperAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::JasperAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetAllDocuments",
                                methodName: "GetAllDocumentsAsync",
                                pathTemplate: "\"/documents\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::JasperAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetAllDocumentsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::JasperAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::JasperAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetAllDocuments",
                                methodName: "GetAllDocumentsAsync",
                                pathTemplate: "\"/documents\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::JasperAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::JasperAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetAllDocuments",
                                methodName: "GetAllDocumentsAsync",
                                pathTemplate: "\"/documents\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Internal server error.
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::JasperAI.ErrorResponse? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::JasperAI.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetAllDocumentsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::JasperAI.DocumentListResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::JasperAI.AutoSDKHttpResponse<global::JasperAI.DocumentListResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::JasperAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::JasperAI.DocumentListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::JasperAI.AutoSDKHttpResponse<global::JasperAI.DocumentListResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::JasperAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}