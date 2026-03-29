
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pagination
    {
        /// <summary>
        /// Total available records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRecords")]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Current page number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Records per page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Next page indicator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Previous page indicator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev")]
        public string? Prev { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="totalRecords">
        /// Total available records.
        /// </param>
        /// <param name="page">
        /// Current page number.
        /// </param>
        /// <param name="pageSize">
        /// Records per page.
        /// </param>
        /// <param name="next">
        /// Next page indicator.
        /// </param>
        /// <param name="prev">
        /// Previous page indicator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pagination(
            int? totalRecords,
            int? page,
            int? pageSize,
            string? next,
            string? prev)
        {
            this.TotalRecords = totalRecords;
            this.Page = page;
            this.PageSize = pageSize;
            this.Next = next;
            this.Prev = prev;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        public Pagination()
        {
        }
    }
}