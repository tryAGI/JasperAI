
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeSettings
    {
        /// <summary>
        /// Whether the knowledge item is available in the Jasper app.<br/>
        /// Default Value: visible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appVisibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.KnowledgeSettingsAppVisibilityJsonConverter))]
        public global::JasperAI.KnowledgeSettingsAppVisibility? AppVisibility { get; set; }

        /// <summary>
        /// Whether to auto-generate a summary.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoSummary")]
        public bool? AutoSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSettings" /> class.
        /// </summary>
        /// <param name="appVisibility">
        /// Whether the knowledge item is available in the Jasper app.<br/>
        /// Default Value: visible
        /// </param>
        /// <param name="autoSummary">
        /// Whether to auto-generate a summary.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeSettings(
            global::JasperAI.KnowledgeSettingsAppVisibility? appVisibility,
            bool? autoSummary)
        {
            this.AppVisibility = appVisibility;
            this.AutoSummary = autoSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeSettings" /> class.
        /// </summary>
        public KnowledgeSettings()
        {
        }
    }
}