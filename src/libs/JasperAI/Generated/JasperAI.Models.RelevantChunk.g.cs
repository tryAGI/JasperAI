
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelevantChunk
    {
        /// <summary>
        /// The content of the relevant chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Relevance score (0-1, where 1 is most relevant).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevantChunk" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the relevant chunk.
        /// </param>
        /// <param name="score">
        /// Relevance score (0-1, where 1 is most relevant).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelevantChunk(
            string? content,
            double? score)
        {
            this.Content = content;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelevantChunk" /> class.
        /// </summary>
        public RelevantChunk()
        {
        }
    }
}