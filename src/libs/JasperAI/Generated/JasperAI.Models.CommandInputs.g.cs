
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommandInputs
    {
        /// <summary>
        /// Your instruction for Jasper (e.g., "Write a haiku about rabbits").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// Background information for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// References to knowledge items for content personalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeIds")]
        public global::System.Collections.Generic.IList<string>? KnowledgeIds { get; set; }

        /// <summary>
        /// Style guide identifier for output formatting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleId")]
        public string? StyleId { get; set; }

        /// <summary>
        /// Voice/tone identifier for output character.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toneId")]
        public string? ToneId { get; set; }

        /// <summary>
        /// Target audience identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audienceId")]
        public string? AudienceId { get; set; }

        /// <summary>
        /// External data enhancement method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalAddOn")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.CommandInputsRetrievalAddOnJsonConverter))]
        public global::JasperAI.CommandInputsRetrievalAddOn? RetrievalAddOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandInputs" /> class.
        /// </summary>
        /// <param name="command">
        /// Your instruction for Jasper (e.g., "Write a haiku about rabbits").
        /// </param>
        /// <param name="context">
        /// Background information for the generation.
        /// </param>
        /// <param name="knowledgeIds">
        /// References to knowledge items for content personalization.
        /// </param>
        /// <param name="styleId">
        /// Style guide identifier for output formatting.
        /// </param>
        /// <param name="toneId">
        /// Voice/tone identifier for output character.
        /// </param>
        /// <param name="audienceId">
        /// Target audience identifier.
        /// </param>
        /// <param name="retrievalAddOn">
        /// External data enhancement method.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommandInputs(
            string command,
            string? context,
            global::System.Collections.Generic.IList<string>? knowledgeIds,
            string? styleId,
            string? toneId,
            string? audienceId,
            global::JasperAI.CommandInputsRetrievalAddOn? retrievalAddOn)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Context = context;
            this.KnowledgeIds = knowledgeIds;
            this.StyleId = styleId;
            this.ToneId = toneId;
            this.AudienceId = audienceId;
            this.RetrievalAddOn = retrievalAddOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandInputs" /> class.
        /// </summary>
        public CommandInputs()
        {
        }
    }
}