
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Only provided fields are updated.
    /// </summary>
    public sealed partial class UpdateComponentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Change component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.UpdateComponentRequestTypeJsonConverter))]
        public global::PDF4Dev.UpdateComponentRequestType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Plain text preview (auto-generated from HTML if omitted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public string? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Change component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline.
        /// </param>
        /// <param name="html"></param>
        /// <param name="preview">
        /// Plain text preview (auto-generated from HTML if omitted)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateComponentRequest(
            string? name,
            global::PDF4Dev.UpdateComponentRequestType? type,
            string? html,
            string? preview)
        {
            this.Name = name;
            this.Type = type;
            this.Html = html;
            this.Preview = preview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentRequest" /> class.
        /// </summary>
        public UpdateComponentRequest()
        {
        }

    }
}