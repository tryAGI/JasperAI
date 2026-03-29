
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeSearchResult
    {
        /// <summary>
        /// Knowledge item identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Knowledge item name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Knowledge item summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Tags associated with the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Relevant content chunks ordered by relevance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevantChunks")]
        public global::System.Collections.Generic.IList<global::JasperAI.RelevantChunk>? RelevantChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Knowledge item identifier.
        /// </param>
        /// <param name="name">
        /// Knowledge item name.
        /// </param>
        /// <param name="summary">
        /// Knowledge item summary.
        /// </param>
        /// <param name="tags">
        /// Tags associated with the item.
        /// </param>
        /// <param name="relevantChunks">
        /// Relevant content chunks ordered by relevance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeSearchResult(
            string? id,
            string? name,
            string? summary,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::JasperAI.RelevantChunk>? relevantChunks)
        {
            this.Id = id;
            this.Name = name;
            this.Summary = summary;
            this.Tags = tags;
            this.RelevantChunks = relevantChunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSearchResult" /> class.
        /// </summary>
        public KnowledgeSearchResult()
        {
        }
    }
}