
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTemplateRequest
    {
        /// <summary>
        /// Template name. A slug is auto-generated from this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// HTML template content. Supports Handlebars `{{variables}}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_format")]
        public global::PDF4Dev.PdfFormat? PdfFormat { get; set; }

        /// <summary>
        /// Default sample values for preview
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_data")]
        public object? SampleData { get; set; }

        /// <summary>
        /// Header component ID (comp_xxx)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_component_id")]
        public string? HeaderComponentId { get; set; }

        /// <summary>
        /// Footer component ID (comp_xxx)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("footer_component_id")]
        public string? FooterComponentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Template name. A slug is auto-generated from this.
        /// </param>
        /// <param name="html">
        /// HTML template content. Supports Handlebars `{{variables}}`.
        /// </param>
        /// <param name="pdfFormat">
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </param>
        /// <param name="sampleData">
        /// Default sample values for preview
        /// </param>
        /// <param name="headerComponentId">
        /// Header component ID (comp_xxx)
        /// </param>
        /// <param name="footerComponentId">
        /// Footer component ID (comp_xxx)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTemplateRequest(
            string name,
            string? html,
            global::PDF4Dev.PdfFormat? pdfFormat,
            object? sampleData,
            string? headerComponentId,
            string? footerComponentId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Html = html;
            this.PdfFormat = pdfFormat;
            this.SampleData = sampleData;
            this.HeaderComponentId = headerComponentId;
            this.FooterComponentId = footerComponentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateRequest" /> class.
        /// </summary>
        public CreateTemplateRequest()
        {
        }
    }
}