
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskRunRequest
    {
        /// <summary>
        /// Array of context items for task execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::JasperAI.TaskContextItemPredefined> ContextItems { get; set; }

        /// <summary>
        /// Agent task version (defaults to latest).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public double? Version { get; set; }

        /// <summary>
        /// Target output language (defaults to EN-US).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toLanguage")]
        public string? ToLanguage { get; set; }

        /// <summary>
        /// Knowledge IDs for context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeIds")]
        public global::System.Collections.Generic.IList<string>? KnowledgeIds { get; set; }

        /// <summary>
        /// Tone ID for brand voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toneId")]
        public string? ToneId { get; set; }

        /// <summary>
        /// Audience ID for customization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audienceId")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// Style Guide ID for writing rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleGuideId")]
        public string? StyleGuideId { get; set; }

        /// <summary>
        /// Tools to enable for execution.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::JasperAI.TaskRunRequestTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRunRequest" /> class.
        /// </summary>
        /// <param name="contextItems">
        /// Array of context items for task execution.
        /// </param>
        /// <param name="version">
        /// Agent task version (defaults to latest).
        /// </param>
        /// <param name="toLanguage">
        /// Target output language (defaults to EN-US).
        /// </param>
        /// <param name="knowledgeIds">
        /// Knowledge IDs for context.
        /// </param>
        /// <param name="toneId">
        /// Tone ID for brand voice.
        /// </param>
        /// <param name="audienceId">
        /// Audience ID for customization.
        /// </param>
        /// <param name="styleGuideId">
        /// Style Guide ID for writing rules.
        /// </param>
        /// <param name="tools">
        /// Tools to enable for execution.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskRunRequest(
            global::System.Collections.Generic.IList<global::JasperAI.TaskContextItemPredefined> contextItems,
            double? version,
            string? toLanguage,
            global::System.Collections.Generic.IList<string>? knowledgeIds,
            string? toneId,
            string? audienceId,
            string? styleGuideId,
            global::System.Collections.Generic.IList<global::JasperAI.TaskRunRequestTool>? tools)
        {
            this.ContextItems = contextItems ?? throw new global::System.ArgumentNullException(nameof(contextItems));
            this.Version = version;
            this.ToLanguage = toLanguage;
            this.KnowledgeIds = knowledgeIds;
            this.ToneId = toneId;
            this.AudienceId = audienceId;
            this.StyleGuideId = styleGuideId;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRunRequest" /> class.
        /// </summary>
        public TaskRunRequest()
        {
        }
    }
}