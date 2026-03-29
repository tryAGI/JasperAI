
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Example: tasks
        /// </summary>
        /// <example>tasks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::JasperAI.Task>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::JasperAI.Pagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListResponse" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="resource">
        /// Example: tasks
        /// </param>
        /// <param name="data"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskListResponse(
            string? requestId,
            string? resource,
            global::System.Collections.Generic.IList<global::JasperAI.Task>? data,
            global::JasperAI.Pagination? pagination)
        {
            this.RequestId = requestId;
            this.Resource = resource;
            this.Data = data;
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListResponse" /> class.
        /// </summary>
        public TaskListResponse()
        {
        }
    }
}