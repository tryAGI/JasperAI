
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StyleTerm
    {
        /// <summary>
        /// Term type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The term to match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        public string? Term { get; set; }

        /// <summary>
        /// The replacement text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaceWith")]
        public string? ReplaceWith { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleTerm" /> class.
        /// </summary>
        /// <param name="type">
        /// Term type.
        /// </param>
        /// <param name="term">
        /// The term to match.
        /// </param>
        /// <param name="replaceWith">
        /// The replacement text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleTerm(
            string? type,
            string? term,
            string? replaceWith)
        {
            this.Type = type;
            this.Term = term;
            this.ReplaceWith = replaceWith;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleTerm" /> class.
        /// </summary>
        public StyleTerm()
        {
        }
    }
}