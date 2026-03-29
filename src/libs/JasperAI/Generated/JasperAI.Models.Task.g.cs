
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Task
    {
        /// <summary>
        /// Unique task identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Task display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Brief task description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Required input fields for execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextItems")]
        public global::System.Collections.Generic.IList<global::JasperAI.TaskContextItem>? ContextItems { get; set; }

        /// <summary>
        /// Version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public double? Version { get; set; }

        /// <summary>
        /// Task visibility scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::JasperAI.JsonConverters.TaskScopeJsonConverter))]
        public global::JasperAI.TaskScope? Scope { get; set; }

        /// <summary>
        /// ISO timestamp of last update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ISO timestamp of creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Extended markdown description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longDescription")]
        public string? LongDescription { get; set; }

        /// <summary>
        /// ISO timestamp when published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        public string? PublishedAt { get; set; }

        /// <summary>
        /// Associated category tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Custom metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customFields")]
        public object? CustomFields { get; set; }

        /// <summary>
        /// Theme identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        public string? Theme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique task identifier.
        /// </param>
        /// <param name="name">
        /// Task display name.
        /// </param>
        /// <param name="description">
        /// Brief task description.
        /// </param>
        /// <param name="contextItems">
        /// Required input fields for execution.
        /// </param>
        /// <param name="version">
        /// Version number.
        /// </param>
        /// <param name="scope">
        /// Task visibility scope.
        /// </param>
        /// <param name="updatedAt">
        /// ISO timestamp of last update.
        /// </param>
        /// <param name="createdAt">
        /// ISO timestamp of creation.
        /// </param>
        /// <param name="longDescription">
        /// Extended markdown description.
        /// </param>
        /// <param name="publishedAt">
        /// ISO timestamp when published.
        /// </param>
        /// <param name="categories">
        /// Associated category tags.
        /// </param>
        /// <param name="customFields">
        /// Custom metadata.
        /// </param>
        /// <param name="theme">
        /// Theme identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Task(
            string? id,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::JasperAI.TaskContextItem>? contextItems,
            double? version,
            global::JasperAI.TaskScope? scope,
            global::System.DateTime? updatedAt,
            global::System.DateTime? createdAt,
            string? longDescription,
            string? publishedAt,
            global::System.Collections.Generic.IList<string>? categories,
            object? customFields,
            string? theme)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ContextItems = contextItems;
            this.Version = version;
            this.Scope = scope;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.LongDescription = longDescription;
            this.PublishedAt = publishedAt;
            this.Categories = categories;
            this.CustomFields = customFields;
            this.Theme = theme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        public Task()
        {
        }
    }
}