
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CursorPaginatedLogs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::PDF4Dev.PdfLog>? Data { get; set; }

        /// <summary>
        /// Whether there are more results after this page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Cursor to pass as `cursor` query parameter to fetch the next page. Null if no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPaginatedLogs" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore">
        /// Whether there are more results after this page
        /// </param>
        /// <param name="nextCursor">
        /// Cursor to pass as `cursor` query parameter to fetch the next page. Null if no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CursorPaginatedLogs(
            global::System.Collections.Generic.IList<global::PDF4Dev.PdfLog>? data,
            bool? hasMore,
            string? nextCursor)
        {
            this.Data = data;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPaginatedLogs" /> class.
        /// </summary>
        public CursorPaginatedLogs()
        {
        }

    }
}