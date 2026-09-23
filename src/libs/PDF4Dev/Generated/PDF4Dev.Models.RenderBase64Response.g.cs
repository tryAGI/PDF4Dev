
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Returned when `delivery` is `base64`.
    /// </summary>
    public sealed partial class RenderBase64Response
    {
        /// <summary>
        /// The PDF bytes, base64 encoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_base64")]
        public string? PdfBase64 { get; set; }

        /// <summary>
        /// Example: 48213
        /// </summary>
        /// <example>48213</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Example: 287
        /// </summary>
        /// <example>287</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderBase64Response" /> class.
        /// </summary>
        /// <param name="pdfBase64">
        /// The PDF bytes, base64 encoded.
        /// </param>
        /// <param name="sizeBytes">
        /// Example: 48213
        /// </param>
        /// <param name="durationMs">
        /// Example: 287
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderBase64Response(
            string? pdfBase64,
            long? sizeBytes,
            int? durationMs)
        {
            this.PdfBase64 = pdfBase64;
            this.SizeBytes = sizeBytes;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderBase64Response" /> class.
        /// </summary>
        public RenderBase64Response()
        {
        }

    }
}