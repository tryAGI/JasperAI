
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebScraperOptions
    {
        /// <summary>
        /// URLs to scrape for context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebScraperOptions" /> class.
        /// </summary>
        /// <param name="urls">
        /// URLs to scrape for context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebScraperOptions(
            global::System.Collections.Generic.IList<string>? urls)
        {
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebScraperOptions" /> class.
        /// </summary>
        public WebScraperOptions()
        {
        }
    }
}