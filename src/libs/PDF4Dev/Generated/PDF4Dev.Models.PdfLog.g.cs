
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PdfLog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Template name at the time of generation (may differ if template was renamed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        public string? TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.PdfLogStatusJsonConverter))]
        public global::PDF4Dev.PdfLogStatus? Status { get; set; }

        /// <summary>
        /// PDF generation time in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// PDF file size in bytes (null if generation failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Error message (null if successful)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfLog" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="templateId"></param>
        /// <param name="templateName">
        /// Template name at the time of generation (may differ if template was renamed)
        /// </param>
        /// <param name="apiKeyId"></param>
        /// <param name="status"></param>
        /// <param name="durationMs">
        /// PDF generation time in milliseconds
        /// </param>
        /// <param name="sizeBytes">
        /// PDF file size in bytes (null if generation failed)
        /// </param>
        /// <param name="error">
        /// Error message (null if successful)
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PdfLog(
            string? id,
            string? templateId,
            string? templateName,
            string? apiKeyId,
            global::PDF4Dev.PdfLogStatus? status,
            int? durationMs,
            long? sizeBytes,
            string? error,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.TemplateId = templateId;
            this.TemplateName = templateName;
            this.ApiKeyId = apiKeyId;
            this.Status = status;
            this.DurationMs = durationMs;
            this.SizeBytes = sizeBytes;
            this.Error = error;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfLog" /> class.
        /// </summary>
        public PdfLog()
        {
        }
    }
}