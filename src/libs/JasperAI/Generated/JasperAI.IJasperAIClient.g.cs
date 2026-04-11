
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Jasper AI is a marketing AI content generation platform. The API provides access to<br/>
    /// AI-powered content generation, agent tasks, knowledge management, brand voice/tone control,<br/>
    /// style guides, documents, image processing, audiences, and usage tracking.<br/>
    /// Authentication uses the X-API-Key header with your API key.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IJasperAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::JasperAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::JasperAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AudiencesClient Audiences { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommandClient Command { get; }

        /// <summary>
        /// 
        /// </summary>
        public DocumentsClient Documents { get; }

        /// <summary>
        /// 
        /// </summary>
        public KnowledgeClient Knowledge { get; }

        /// <summary>
        /// 
        /// </summary>
        public StylesClient Styles { get; }

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices { get; }

    }
}