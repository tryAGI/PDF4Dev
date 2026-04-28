
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Stats
    {
        /// <summary>
        /// Total number of templates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        public int? Templates { get; set; }

        /// <summary>
        /// Total number of PDF renders
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_renders")]
        public int? TotalRenders { get; set; }

        /// <summary>
        /// Success rate as percentage (0-100)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_rate")]
        public int? SuccessRate { get; set; }

        /// <summary>
        /// Average render duration in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_duration_ms")]
        public int? AvgDurationMs { get; set; }

        /// <summary>
        /// Total size of all generated PDFs in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")]
        public long? TotalSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Stats" /> class.
        /// </summary>
        /// <param name="templates">
        /// Total number of templates
        /// </param>
        /// <param name="totalRenders">
        /// Total number of PDF renders
        /// </param>
        /// <param name="successRate">
        /// Success rate as percentage (0-100)
        /// </param>
        /// <param name="avgDurationMs">
        /// Average render duration in milliseconds
        /// </param>
        /// <param name="totalSizeBytes">
        /// Total size of all generated PDFs in bytes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Stats(
            int? templates,
            int? totalRenders,
            int? successRate,
            int? avgDurationMs,
            long? totalSizeBytes)
        {
            this.Templates = templates;
            this.TotalRenders = totalRenders;
            this.SuccessRate = successRate;
            this.AvgDurationMs = avgDurationMs;
            this.TotalSizeBytes = totalSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stats" /> class.
        /// </summary>
        public Stats()
        {
        }
    }
}