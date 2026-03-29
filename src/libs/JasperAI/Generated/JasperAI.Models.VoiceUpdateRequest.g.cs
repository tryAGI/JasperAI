
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceUpdateRequest
    {
        /// <summary>
        /// Updated voice name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated voice description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Updated metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::JasperAI.VoiceSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated voice name.
        /// </param>
        /// <param name="value">
        /// Updated voice description.
        /// </param>
        /// <param name="metadata">
        /// Updated metadata.
        /// </param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceUpdateRequest(
            string? name,
            string? value,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::JasperAI.VoiceSettings? settings)
        {
            this.Name = name;
            this.Value = value;
            this.Metadata = metadata;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUpdateRequest" /> class.
        /// </summary>
        public VoiceUpdateRequest()
        {
        }
    }
}