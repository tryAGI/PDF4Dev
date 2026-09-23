
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Returned when `delivery` is `url`.
    /// </summary>
    public sealed partial class RenderUrlResponse
    {
        /// <summary>
        /// Signed URL to `GET /api/v1/renders/{id}`. Needs no API key: the token carries its own expiry.<br/>
        /// Example: https://pdf4.dev/api/v1/renders/render_a1b2c3d4e5f6a7b8?token=1758531600000.AbCdEf
        /// </summary>
        /// <example>https://pdf4.dev/api/v1/renders/render_a1b2c3d4e5f6a7b8?token=1758531600000.AbCdEf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// When the URL stops resolving.<br/>
        /// Example: 2026-09-24T09:00:00.000Z
        /// </summary>
        /// <example>2026-09-24T09:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

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
        /// Initializes a new instance of the <see cref="RenderUrlResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// Signed URL to `GET /api/v1/renders/{id}`. Needs no API key: the token carries its own expiry.<br/>
        /// Example: https://pdf4.dev/api/v1/renders/render_a1b2c3d4e5f6a7b8?token=1758531600000.AbCdEf
        /// </param>
        /// <param name="expiresAt">
        /// When the URL stops resolving.<br/>
        /// Example: 2026-09-24T09:00:00.000Z
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
        public RenderUrlResponse(
            string? url,
            global::System.DateTime? expiresAt,
            long? sizeBytes,
            int? durationMs)
        {
            this.Url = url;
            this.ExpiresAt = expiresAt;
            this.SizeBytes = sizeBytes;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderUrlResponse" /> class.
        /// </summary>
        public RenderUrlResponse()
        {
        }

    }
}