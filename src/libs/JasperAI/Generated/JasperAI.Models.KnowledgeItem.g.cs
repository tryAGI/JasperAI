
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeItem
    {
        /// <summary>
        /// Unique knowledge item identifier (prefixed with kno_).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Friendly name of the knowledge item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Filename or signed URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public string? File { get; set; }

        /// <summary>
        /// Key-value metadata pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::JasperAI.KnowledgeSettings? Settings { get; set; }

        /// <summary>
        /// Knowledge item summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Searchable tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Processing state (e.g., InProgress, Completed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingState")]
        public string? ProcessingState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique knowledge item identifier (prefixed with kno_).
        /// </param>
        /// <param name="name">
        /// Friendly name of the knowledge item.
        /// </param>
        /// <param name="file">
        /// Filename or signed URL.
        /// </param>
        /// <param name="metadata">
        /// Key-value metadata pairs.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="summary">
        /// Knowledge item summary.
        /// </param>
        /// <param name="tags">
        /// Searchable tags.
        /// </param>
        /// <param name="processingState">
        /// Processing state (e.g., InProgress, Completed).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeItem(
            string? id,
            string? name,
            string? file,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::JasperAI.KnowledgeSettings? settings,
            string? summary,
            global::System.Collections.Generic.IList<string>? tags,
            string? processingState,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.File = file;
            this.Metadata = metadata;
            this.Settings = settings;
            this.Summary = summary;
            this.Tags = tags;
            this.ProcessingState = processingState;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeItem" /> class.
        /// </summary>
        public KnowledgeItem()
        {
        }
    }
}