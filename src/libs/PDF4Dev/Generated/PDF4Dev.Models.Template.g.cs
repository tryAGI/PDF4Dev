
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
        /// URL-safe identifier, unique per user. Can be used as `template_id` in render requests.<br/>
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
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_format")]
        public global::PDF4Dev.PdfFormat? PdfFormat { get; set; }

        /// <summary>
        /// Default sample values for preview. These are NOT used during API rendering: you must pass `data` explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_data")]
        public object? SampleData { get; set; }

        /// <summary>
        /// Header component ID (comp_xxx). Repeats on every page when rendering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_component_id")]
        public string? HeaderComponentId { get; set; }

        /// <summary>
        /// Footer component ID (comp_xxx). Repeats on every page when rendering.
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
        /// URL-safe identifier, unique per user. Can be used as `template_id` in render requests.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="html">
        /// HTML template with Handlebars variables
        /// </param>
        /// <param name="plainText">
        /// Plain text version of the template
        /// </param>
        /// <param name="pdfFormat">
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </param>
        /// <param name="sampleData">
        /// Default sample values for preview. These are NOT used during API rendering: you must pass `data` explicitly.
        /// </param>
        /// <param name="headerComponentId">
        /// Header component ID (comp_xxx). Repeats on every page when rendering.
        /// </param>
        /// <param name="footerComponentId">
        /// Footer component ID (comp_xxx). Repeats on every page when rendering.
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