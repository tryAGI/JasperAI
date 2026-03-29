
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeUpdateRequest
    {
        /// <summary>
        /// Updated name (max 100 chars).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated metadata key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::JasperAI.KnowledgeSettings? Settings { get; set; }

        /// <summary>
        /// Updated summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Updated tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name (max 100 chars).
        /// </param>
        /// <param name="metadata">
        /// Updated metadata key-value pairs.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="summary">
        /// Updated summary.
        /// </param>
        /// <param name="tags">
        /// Updated tags.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeUpdateRequest(
            string? name,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::JasperAI.KnowledgeSettings? settings,
            string? summary,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name;
            this.Metadata = metadata;
            this.Settings = settings;
            this.Summary = summary;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeUpdateRequest" /> class.
        /// </summary>
        public KnowledgeUpdateRequest()
        {
        }
    }
}