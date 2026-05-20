
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Either `template_id` or `html` is required. If both are provided, `template_id` takes precedence.
    /// </summary>
    public sealed partial class RenderRequest
    {
        /// <summary>
        /// Template ID (`tmpl_xxx`) or slug. The template must belong to the authenticated user.<br/>
        /// Example: invoice
        /// </summary>
        /// <example>invoice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Raw HTML string. Supports Handlebars `{{variables}}` syntax. Use this for one-off renders without saving a template.<br/>
        /// Example: &lt;h1&gt;Hello {{name}}&lt;/h1&gt;
        /// </summary>
        /// <example>&lt;h1&gt;Hello {{name}}&lt;/h1&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Data to replace `{{variables}}` in the template. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
        /// Example: {"name":"World","company":"Acme Corp"}
        /// </summary>
        /// <example>{"name":"World","company":"Acme Corp"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::PDF4Dev.PdfFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderRequest" /> class.
        /// </summary>
        /// <param name="templateId">
        /// Template ID (`tmpl_xxx`) or slug. The template must belong to the authenticated user.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="html">
        /// Raw HTML string. Supports Handlebars `{{variables}}` syntax. Use this for one-off renders without saving a template.<br/>
        /// Example: &lt;h1&gt;Hello {{name}}&lt;/h1&gt;
        /// </param>
        /// <param name="data">
        /// Data to replace `{{variables}}` in the template. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
        /// Example: {"name":"World","company":"Acme Corp"}
        /// </param>
        /// <param name="format">
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderRequest(
            string? templateId,
            string? html,
            object? data,
            global::PDF4Dev.PdfFormat? format)
        {
            this.TemplateId = templateId;
            this.Html = html;
            this.Data = data;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderRequest" /> class.
        /// </summary>
        public RenderRequest()
        {
        }

    }
}