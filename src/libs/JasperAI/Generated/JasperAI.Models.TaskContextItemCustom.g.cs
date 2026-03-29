
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskContextItemCustom
    {
        /// <summary>
        /// Name/label of custom context item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Question/prompt for the context item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// Value/answer for custom context item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Answer { get; set; }

        /// <summary>
        /// Priority level (higher = more important).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskContextItemCustom" /> class.
        /// </summary>
        /// <param name="name">
        /// Name/label of custom context item.
        /// </param>
        /// <param name="question">
        /// Question/prompt for the context item.
        /// </param>
        /// <param name="answer">
        /// Value/answer for custom context item.
        /// </param>
        /// <param name="priority">
        /// Priority level (higher = more important).<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskContextItemCustom(
            string name,
            string question,
            string answer,
            double? priority)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskContextItemCustom" /> class.
        /// </summary>
        public TaskContextItemCustom()
        {
        }
    }
}