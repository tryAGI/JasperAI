
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchOptions
    {
        /// <summary>
        /// Sites to exclude from search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siteBlockList")]
        public global::System.Collections.Generic.IList<string>? SiteBlockList { get; set; }

        /// <summary>
        /// Custom search query override.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchQuery")]
        public string? SearchQuery { get; set; }

        /// <summary>
        /// Maximum number of web search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchOptions" /> class.
        /// </summary>
        /// <param name="siteBlockList">
        /// Sites to exclude from search.
        /// </param>
        /// <param name="searchQuery">
        /// Custom search query override.
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of web search results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchOptions(
            global::System.Collections.Generic.IList<string>? siteBlockList,
            string? searchQuery,
            int? maxResults)
        {
            this.SiteBlockList = siteBlockList;
            this.SearchQuery = searchQuery;
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchOptions" /> class.
        /// </summary>
        public WebSearchOptions()
        {
        }
    }
}