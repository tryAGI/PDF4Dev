
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateComponentRequest
    {
        /// <summary>
        /// Component name (e.g. Company header)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline where placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.CreateComponentRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PDF4Dev.CreateComponentRequestType Type { get; set; }

        /// <summary>
        /// HTML with {{handlebars}} variables
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
        /// Initializes a new instance of the <see cref="CreateComponentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Component name (e.g. Company header)
        /// </param>
        /// <param name="type">
        /// Component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline where placed.
        /// </param>
        /// <param name="html">
        /// HTML with {{handlebars}} variables
        /// </param>
        /// <param name="preview">
        /// Plain text preview (auto-generated from HTML if omitted)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateComponentRequest(
            string name,
            global::PDF4Dev.CreateComponentRequestType type,
            string? html,
            string? preview)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Html = html;
            this.Preview = preview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComponentRequest" /> class.
        /// </summary>
        public CreateComponentRequest()
        {
        }

    }
}