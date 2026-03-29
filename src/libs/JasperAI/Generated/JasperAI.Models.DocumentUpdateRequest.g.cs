
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentUpdateRequest
    {
        /// <summary>
        /// Updated document content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Updated document name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated document status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.DocumentUpdateRequestStatusJsonConverter))]
        public global::JasperAI.DocumentUpdateRequestStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdateRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// Updated document content.
        /// </param>
        /// <param name="name">
        /// Updated document name.
        /// </param>
        /// <param name="status">
        /// Updated document status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentUpdateRequest(
            string? content,
            string? name,
            global::JasperAI.DocumentUpdateRequestStatus? status)
        {
            this.Content = content;
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdateRequest" /> class.
        /// </summary>
        public DocumentUpdateRequest()
        {
        }
    }
}