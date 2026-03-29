
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedContent
    {
        /// <summary>
        /// Unique content identifier (prefixed with txt_).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The generated content text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedContent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique content identifier (prefixed with txt_).
        /// </param>
        /// <param name="text">
        /// The generated content text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedContent(
            string? id,
            string? text)
        {
            this.Id = id;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedContent" /> class.
        /// </summary>
        public GeneratedContent()
        {
        }
    }
}