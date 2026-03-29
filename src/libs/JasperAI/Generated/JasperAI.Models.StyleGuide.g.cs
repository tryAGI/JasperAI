
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StyleGuide
    {
        /// <summary>
        /// Unique style guide identifier (prefixed with sty_).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Free-form custom instructions for the style guide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customInstructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The user ID of who created the style guide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Term replacement rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms")]
        public global::System.Collections.Generic.IList<global::JasperAI.StyleTerm>? Terms { get; set; }

        /// <summary>
        /// Style rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::JasperAI.StyleRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleGuide" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique style guide identifier (prefixed with sty_).
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="customInstructions">
        /// Free-form custom instructions for the style guide.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy">
        /// The user ID of who created the style guide.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="terms">
        /// Term replacement rules.
        /// </param>
        /// <param name="rules">
        /// Style rules.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleGuide(
            string? id,
            string? name,
            string? description,
            string? customInstructions,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::JasperAI.StyleTerm>? terms,
            global::System.Collections.Generic.IList<global::JasperAI.StyleRule>? rules)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CustomInstructions = customInstructions;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.UpdatedAt = updatedAt;
            this.Terms = terms;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleGuide" /> class.
        /// </summary>
        public StyleGuide()
        {
        }
    }
}