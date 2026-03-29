
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadKnowledgeDocumentRequest
    {
        /// <summary>
        /// Friendly name for the knowledge item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// File to upload (txt, pdf, doc, docx, max 300MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// File to upload (txt, pdf, doc, docx, max 300MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// JSON string of key-value metadata pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// JSON string with appVisibility and autoSummary settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public string? Settings { get; set; }

        /// <summary>
        /// Manual knowledge item summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Searchable tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadKnowledgeDocumentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Friendly name for the knowledge item.
        /// </param>
        /// <param name="file">
        /// File to upload (txt, pdf, doc, docx, max 300MB).
        /// </param>
        /// <param name="filename">
        /// File to upload (txt, pdf, doc, docx, max 300MB).
        /// </param>
        /// <param name="metadata">
        /// JSON string of key-value metadata pairs.
        /// </param>
        /// <param name="settings">
        /// JSON string with appVisibility and autoSummary settings.
        /// </param>
        /// <param name="summary">
        /// Manual knowledge item summary.
        /// </param>
        /// <param name="tags">
        /// Searchable tags.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadKnowledgeDocumentRequest(
            string name,
            byte[] file,
            string filename,
            string? metadata,
            string? settings,
            string? summary,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Metadata = metadata;
            this.Settings = settings;
            this.Summary = summary;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadKnowledgeDocumentRequest" /> class.
        /// </summary>
        public UploadKnowledgeDocumentRequest()
        {
        }
    }
}