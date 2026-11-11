
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Template
    {
        /// <summary>
        /// Unique template ID<br/>
        /// Example: tmpl_a1b2c3d4e5f6
        /// </summary>
        /// <example>tmpl_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Display name<br/>
        /// Example: Invoice
        /// </summary>
        /// <example>Invoice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL-safe identifier, unique per organization. Set at creation from the name and never changed, even when the template is renamed. Can be used as `template_id` in render requests and in place of the ID in `/api/v1/templates/{id}`.<br/>
        /// Example: invoice
        /// </summary>
        /// <example>invoice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// HTML template with Handlebars variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Plain text version of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plain_text")]
        public string? PlainText { get; set; }

        /// <summary>
        /// Page format configuration. Every field is optional: `preset` defaults to `a4` and each missing margin side to 20mm (top, bottom) or 15mm (left, right). A format replaces the stored or template format as a whole, it is never merged with it. Margins, `width` and `height` take px, pt, pc, mm, cm or in, or a bare number of px; a number is stored as `"&lt;n&gt;px"`, an empty margin is 0. `component_gap` is CSS: any length unit (`em`, `rem`, `%` too) or `calc()`. Presets and alignments are case-insensitive. On a template write, an unknown preset, alignment or footer position, or a length that cannot be read, answers 400 `invalid_pdf_format`; a value sent back exactly as stored is kept. On a render, `format` prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, a number is accepted for a CSS value, and only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`. Unknown keys are ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_format")]
        public global::PDF4Dev.PdfFormat? PdfFormat { get; set; }

        /// <summary>
        /// Default sample values for preview. These are NOT used during API rendering: you must pass `data` explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_data")]
        public object? SampleData { get; set; }

        /// <summary>
        /// Header component ID (comp_xxx). Repeats on every page when rendering. Kept in agreement with the `&lt;pdf4-header&gt;` tag in `html`, which is what renders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_component_id")]
        public string? HeaderComponentId { get; set; }

        /// <summary>
        /// Footer component ID (comp_xxx). Repeats on every page when rendering. Kept in agreement with the `&lt;pdf4-footer&gt;` tag in `html`, which is what renders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("footer_component_id")]
        public string? FooterComponentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique template ID<br/>
        /// Example: tmpl_a1b2c3d4e5f6
        /// </param>
        /// <param name="name">
        /// Display name<br/>
        /// Example: Invoice
        /// </param>
        /// <param name="slug">
        /// URL-safe identifier, unique per organization. Set at creation from the name and never changed, even when the template is renamed. Can be used as `template_id` in render requests and in place of the ID in `/api/v1/templates/{id}`.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="html">
        /// HTML template with Handlebars variables
        /// </param>
        /// <param name="plainText">
        /// Plain text version of the template
        /// </param>
        /// <param name="pdfFormat">
        /// Page format configuration. Every field is optional: `preset` defaults to `a4` and each missing margin side to 20mm (top, bottom) or 15mm (left, right). A format replaces the stored or template format as a whole, it is never merged with it. Margins, `width` and `height` take px, pt, pc, mm, cm or in, or a bare number of px; a number is stored as `"&lt;n&gt;px"`, an empty margin is 0. `component_gap` is CSS: any length unit (`em`, `rem`, `%` too) or `calc()`. Presets and alignments are case-insensitive. On a template write, an unknown preset, alignment or footer position, or a length that cannot be read, answers 400 `invalid_pdf_format`; a value sent back exactly as stored is kept. On a render, `format` prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, a number is accepted for a CSS value, and only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`. Unknown keys are ignored.
        /// </param>
        /// <param name="sampleData">
        /// Default sample values for preview. These are NOT used during API rendering: you must pass `data` explicitly.
        /// </param>
        /// <param name="headerComponentId">
        /// Header component ID (comp_xxx). Repeats on every page when rendering. Kept in agreement with the `&lt;pdf4-header&gt;` tag in `html`, which is what renders.
        /// </param>
        /// <param name="footerComponentId">
        /// Footer component ID (comp_xxx). Repeats on every page when rendering. Kept in agreement with the `&lt;pdf4-footer&gt;` tag in `html`, which is what renders.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Template(
            string? id,
            string? name,
            string? slug,
            string? html,
            string? plainText,
            global::PDF4Dev.PdfFormat? pdfFormat,
            object? sampleData,
            string? headerComponentId,
            string? footerComponentId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.Html = html;
            this.PlainText = plainText;
            this.PdfFormat = pdfFormat;
            this.SampleData = sampleData;
            this.HeaderComponentId = headerComponentId;
            this.FooterComponentId = footerComponentId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        public Template()
        {
        }

    }
}