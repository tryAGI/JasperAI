
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskOutput
    {
        /// <summary>
        /// Output item type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.TaskOutputTypeJsonConverter))]
        public global::JasperAI.TaskOutputType? Type { get; set; }

        /// <summary>
        /// Output content value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Output item type.
        /// </param>
        /// <param name="value">
        /// Output content value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskOutput(
            global::JasperAI.TaskOutputType? type,
            string? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOutput" /> class.
        /// </summary>
        public TaskOutput()
        {
        }
    }
}