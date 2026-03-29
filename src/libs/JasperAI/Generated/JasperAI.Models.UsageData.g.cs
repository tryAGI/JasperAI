
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageData
    {
        /// <summary>
        /// Total words generated in the period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordsGenerated")]
        public int? WordsGenerated { get; set; }

        /// <summary>
        /// Total API requests in the period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestCount")]
        public int? RequestCount { get; set; }

        /// <summary>
        /// Start of the usage period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodStart")]
        public global::System.DateTime? PeriodStart { get; set; }

        /// <summary>
        /// End of the usage period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodEnd")]
        public global::System.DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageData" /> class.
        /// </summary>
        /// <param name="wordsGenerated">
        /// Total words generated in the period.
        /// </param>
        /// <param name="requestCount">
        /// Total API requests in the period.
        /// </param>
        /// <param name="periodStart">
        /// Start of the usage period.
        /// </param>
        /// <param name="periodEnd">
        /// End of the usage period.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageData(
            int? wordsGenerated,
            int? requestCount,
            global::System.DateTime? periodStart,
            global::System.DateTime? periodEnd)
        {
            this.WordsGenerated = wordsGenerated;
            this.RequestCount = requestCount;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageData" /> class.
        /// </summary>
        public UsageData()
        {
        }
    }
}