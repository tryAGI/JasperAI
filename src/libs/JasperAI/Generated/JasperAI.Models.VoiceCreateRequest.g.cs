
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCreateRequest
    {
        /// <summary>
        /// The friendly name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The voice's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Optional key-value pairs.
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
        /// Initializes a new instance of the <see cref="VoiceCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The friendly name of the voice.
        /// </param>
        /// <param name="value">
        /// The voice's description.
        /// </param>
        /// <param name="metadata">
        /// Optional key-value pairs.
        /// </param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCreateRequest(
            string name,
            string value,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::JasperAI.VoiceSettings? settings)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Metadata = metadata;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCreateRequest" /> class.
        /// </summary>
        public VoiceCreateRequest()
        {
        }
    }
}