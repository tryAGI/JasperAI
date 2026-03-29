
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommandOptions
    {
        /// <summary>
        /// Number of outputs to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        /// Language for the generated output.<br/>
        /// Default Value: English
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputLanguage")]
        public string? OutputLanguage { get; set; }

        /// <summary>
        /// Language of the input command.<br/>
        /// Default Value: English
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputLanguage")]
        public string? InputLanguage { get; set; }

        /// <summary>
        /// Formality level of the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageFormality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.CommandOptionsLanguageFormalityJsonConverter))]
        public global::JasperAI.CommandOptionsLanguageFormality? LanguageFormality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webScraper")]
        public global::JasperAI.WebScraperOptions? WebScraper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webSearch")]
        public global::JasperAI.WebSearchOptions? WebSearch { get; set; }

        /// <summary>
        /// Completion quality trade-off.<br/>
        /// Default Value: performance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.CommandOptionsCompletionTypeJsonConverter))]
        public global::JasperAI.CommandOptionsCompletionType? CompletionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandOptions" /> class.
        /// </summary>
        /// <param name="outputCount">
        /// Number of outputs to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="outputLanguage">
        /// Language for the generated output.<br/>
        /// Default Value: English
        /// </param>
        /// <param name="inputLanguage">
        /// Language of the input command.<br/>
        /// Default Value: English
        /// </param>
        /// <param name="languageFormality">
        /// Formality level of the output.
        /// </param>
        /// <param name="webScraper"></param>
        /// <param name="webSearch"></param>
        /// <param name="completionType">
        /// Completion quality trade-off.<br/>
        /// Default Value: performance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommandOptions(
            int? outputCount,
            string? outputLanguage,
            string? inputLanguage,
            global::JasperAI.CommandOptionsLanguageFormality? languageFormality,
            global::JasperAI.WebScraperOptions? webScraper,
            global::JasperAI.WebSearchOptions? webSearch,
            global::JasperAI.CommandOptionsCompletionType? completionType)
        {
            this.OutputCount = outputCount;
            this.OutputLanguage = outputLanguage;
            this.InputLanguage = inputLanguage;
            this.LanguageFormality = languageFormality;
            this.WebScraper = webScraper;
            this.WebSearch = webSearch;
            this.CompletionType = completionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandOptions" /> class.
        /// </summary>
        public CommandOptions()
        {
        }
    }
}