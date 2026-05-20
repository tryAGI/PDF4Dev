
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyResponse2
    {
        /// <summary>
        /// Full API key token (shown only once)<br/>
        /// Example: p4_live_abc123...
        /// </summary>
        /// <example>p4_live_abc123...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse2" /> class.
        /// </summary>
        /// <param name="key">
        /// Full API key token (shown only once)<br/>
        /// Example: p4_live_abc123...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyResponse2(
            string? key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse2" /> class.
        /// </summary>
        public CreateApiKeyResponse2()
        {
        }

    }
}