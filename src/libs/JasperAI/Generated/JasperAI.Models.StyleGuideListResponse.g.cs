
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StyleGuideListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Example: styles
        /// </summary>
        /// <example>styles</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::JasperAI.StyleGuide>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleGuideListResponse" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="resource">
        /// Example: styles
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleGuideListResponse(
            string? requestId,
            string? resource,
            global::System.Collections.Generic.IList<global::JasperAI.StyleGuide>? data)
        {
            this.RequestId = requestId;
            this.Resource = resource;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleGuideListResponse" /> class.
        /// </summary>
        public StyleGuideListResponse()
        {
        }
    }
}