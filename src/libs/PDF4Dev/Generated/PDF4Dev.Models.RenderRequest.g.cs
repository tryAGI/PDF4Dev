
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Either `template_id` or `html` is required. If both are provided, `template_id` takes precedence. Header and footer components come from the `&lt;pdf4-header&gt;` / `&lt;pdf4-footer&gt;` tags in the HTML: a tag wins, and one whose component does not exist renders nothing. The template's `header_component_id` / `footer_component_id` is used when the HTML has no tag for that slot, and also by a template saved before writes kept the two in sync whose tag names another component: it keeps printing its stored one until it is saved again.
    /// </summary>
    public sealed partial class RenderRequest
    {
        /// <summary>
        /// Template ID (`tmpl_xxx`) or slug. The template must belong to the authenticated user. `null` reads as omitted.<br/>
        /// Example: invoice
        /// </summary>
        /// <example>invoice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Raw HTML string. Supports Handlebars `{{variables}}` syntax. Use this for one-off renders without saving a template. `null` reads as omitted.<br/>
        /// Example: &lt;h1&gt;Hello {{name}}&lt;/h1&gt;
        /// </summary>
        /// <example>&lt;h1&gt;Hello {{name}}&lt;/h1&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Data to replace `{{variables}}` in the template. A JSON object: `null`, `""`, `false` and `0` read as omitted, anything else answers 400 `invalid_data`. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
        /// Example: {"name":"World","company":"Acme Corp"}
        /// </summary>
        /// <example>{"name":"World","company":"Acme Corp"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Page format for this render. It replaces the template's format as a whole: missing fields take the defaults (A4 portrait, 20mm top/bottom and 15mm left/right margins), they are not read from the template. It prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, and a `margins` object prints a side it leaves out at 0 (the default margins apply only when `margins` is left out). `null`, `""`, `false` and `0` read as omitted. Only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::PDF4Dev.PdfFormat? Format { get; set; }

        /// <summary>
        /// How to return the PDF. Omit for a binary `application/pdf` body (the default). `base64` returns JSON with the bytes inline. `url` stores the render and returns a signed URL valid for 24 hours, which is the recommended path for PDFs over 1 MB and for AI agents that cannot hold binary in context. An organization keeps at most 200 stored renders (500 MiB) by default; past that its oldest are deleted first, so a URL can stop working sooner. After expiry the URL answers 404 `render_expired`.<br/>
        /// Example: url
        /// </summary>
        /// <example>url</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.RenderRequestDeliveryJsonConverter))]
        public global::PDF4Dev.RenderRequestDelivery? Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderRequest" /> class.
        /// </summary>
        /// <param name="templateId">
        /// Template ID (`tmpl_xxx`) or slug. The template must belong to the authenticated user. `null` reads as omitted.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="html">
        /// Raw HTML string. Supports Handlebars `{{variables}}` syntax. Use this for one-off renders without saving a template. `null` reads as omitted.<br/>
        /// Example: &lt;h1&gt;Hello {{name}}&lt;/h1&gt;
        /// </param>
        /// <param name="data">
        /// Data to replace `{{variables}}` in the template. A JSON object: `null`, `""`, `false` and `0` read as omitted, anything else answers 400 `invalid_data`. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
        /// Example: {"name":"World","company":"Acme Corp"}
        /// </param>
        /// <param name="format">
        /// Page format for this render. It replaces the template's format as a whole: missing fields take the defaults (A4 portrait, 20mm top/bottom and 15mm left/right margins), they are not read from the template. It prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, and a `margins` object prints a side it leaves out at 0 (the default margins apply only when `margins` is left out). `null`, `""`, `false` and `0` read as omitted. Only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`.
        /// </param>
        /// <param name="delivery">
        /// How to return the PDF. Omit for a binary `application/pdf` body (the default). `base64` returns JSON with the bytes inline. `url` stores the render and returns a signed URL valid for 24 hours, which is the recommended path for PDFs over 1 MB and for AI agents that cannot hold binary in context. An organization keeps at most 200 stored renders (500 MiB) by default; past that its oldest are deleted first, so a URL can stop working sooner. After expiry the URL answers 404 `render_expired`.<br/>
        /// Example: url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderRequest(
            string? templateId,
            string? html,
            object? data,
            global::PDF4Dev.PdfFormat? format,
            global::PDF4Dev.RenderRequestDelivery? delivery)
        {
            this.TemplateId = templateId;
            this.Html = html;
            this.Data = data;
            this.Format = format;
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderRequest" /> class.
        /// </summary>
        public RenderRequest()
        {
        }

    }
}