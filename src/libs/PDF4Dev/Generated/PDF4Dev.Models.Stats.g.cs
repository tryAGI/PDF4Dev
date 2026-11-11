
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
        /// Success rate as a percentage (0-100), rounded down; 100 when nothing was rendered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_rate")]
        public int? SuccessRate { get; set; }

        /// <summary>
        /// Average duration of successful renders, in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_duration_ms")]
        public int? AvgDurationMs { get; set; }

        /// <summary>
        /// Total size of all generated PDFs in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")]
        public long? TotalSizeBytes { get; set; }

        /// <summary>
        /// Number of successful renders
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_count")]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Number of failed renders
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        public int? ErrorCount { get; set; }

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
        /// Success rate as a percentage (0-100), rounded down; 100 when nothing was rendered
        /// </param>
        /// <param name="avgDurationMs">
        /// Average duration of successful renders, in milliseconds
        /// </param>
        /// <param name="totalSizeBytes">
        /// Total size of all generated PDFs in bytes
        /// </param>
        /// <param name="successCount">
        /// Number of successful renders
        /// </param>
        /// <param name="errorCount">
        /// Number of failed renders
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Stats(
            int? templates,
            int? totalRenders,
            int? successRate,
            int? avgDurationMs,
            long? totalSizeBytes,
            int? successCount,
            int? errorCount)
        {
            this.Templates = templates;
            this.TotalRenders = totalRenders;
            this.SuccessRate = successRate;
            this.AvgDurationMs = avgDurationMs;
            this.TotalSizeBytes = totalSizeBytes;
            this.SuccessCount = successCount;
            this.ErrorCount = errorCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stats" /> class.
        /// </summary>
        public Stats()
        {
        }

    }
}