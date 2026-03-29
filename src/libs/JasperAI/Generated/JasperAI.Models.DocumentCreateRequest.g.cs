
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentCreateRequest
    {
        /// <summary>
        /// The ID of the user creating the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The content of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The name of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The status of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.DocumentCreateRequestStatusJsonConverter))]
        public global::JasperAI.DocumentCreateRequestStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCreateRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user creating the document.
        /// </param>
        /// <param name="content">
        /// The content of the document.
        /// </param>
        /// <param name="name">
        /// The name of the document.
        /// </param>
        /// <param name="status">
        /// The status of the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentCreateRequest(
            string userId,
            string content,
            string name,
            global::JasperAI.DocumentCreateRequestStatus? status)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCreateRequest" /> class.
        /// </summary>
        public DocumentCreateRequest()
        {
        }
    }
}