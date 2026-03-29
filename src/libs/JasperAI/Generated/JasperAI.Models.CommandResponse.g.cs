
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommandResponse
    {
        /// <summary>
        /// Unique request identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// Example: content
        /// </summary>
        /// <example>content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::JasperAI.GeneratedContent>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier.
        /// </param>
        /// <param name="resource">
        /// Example: content
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommandResponse(
            global::System.Guid? requestId,
            string? resource,
            global::System.Collections.Generic.IList<global::JasperAI.GeneratedContent>? data)
        {
            this.RequestId = requestId;
            this.Resource = resource;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandResponse" /> class.
        /// </summary>
        public CommandResponse()
        {
        }
    }
}