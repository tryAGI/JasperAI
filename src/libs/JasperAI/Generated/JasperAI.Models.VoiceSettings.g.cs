
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSettings
    {
        /// <summary>
        /// Whether the voice is available in the Jasper app.<br/>
        /// Default Value: visible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appVisibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.VoiceSettingsAppVisibilityJsonConverter))]
        public global::JasperAI.VoiceSettingsAppVisibility? AppVisibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettings" /> class.
        /// </summary>
        /// <param name="appVisibility">
        /// Whether the voice is available in the Jasper app.<br/>
        /// Default Value: visible
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSettings(
            global::JasperAI.VoiceSettingsAppVisibility? appVisibility)
        {
            this.AppVisibility = appVisibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettings" /> class.
        /// </summary>
        public VoiceSettings()
        {
        }
    }
}