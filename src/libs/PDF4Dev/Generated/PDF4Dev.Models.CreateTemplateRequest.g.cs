
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
        /// Default sample values for preview. Must be a JSON object (an array answers 400 `invalid_sample_data`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_data")]
        public object? SampleData { get; set; }

        /// <summary>
        /// A header component (comp_xxx) of your organization. The `&lt;pdf4-header&gt;` tag in `html` is what renders: setting an ID rewrites a tag that names another component, `null` (or an empty string) clears it and removes the tag, and when omitted the ID follows a tag in the `html` sent (`html` without one keeps the current ID, which still prints). An unknown ID or one of another organization answers 400 `component_not_found`, a component that is not a header 400 `component_type_mismatch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_component_id")]
        public string? HeaderComponentId { get; set; }

        /// <summary>
        /// A footer component (comp_xxx) of your organization. The `&lt;pdf4-footer&gt;` tag in `html` is what renders: setting an ID rewrites a tag that names another component, `null` (or an empty string) clears it and removes the tag, and when omitted the ID follows a tag in the `html` sent (`html` without one keeps the current ID, which still prints). An unknown ID or one of another organization answers 400 `component_not_found`, a component that is not a footer 400 `component_type_mismatch`.
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
        /// <param name="plainText">
        /// Plain text version of the template
        /// </param>
        /// <param name="pdfFormat">
        /// Page format configuration. Every field is optional: `preset` defaults to `a4` and each missing margin side to 20mm (top, bottom) or 15mm (left, right). A format replaces the stored or template format as a whole, it is never merged with it. Margins, `width` and `height` take px, pt, pc, mm, cm or in, or a bare number of px; a number is stored as `"&lt;n&gt;px"`, an empty margin is 0. `component_gap` is CSS: any length unit (`em`, `rem`, `%` too) or `calc()`. Presets and alignments are case-insensitive. On a template write, an unknown preset, alignment or footer position, or a length that cannot be read, answers 400 `invalid_pdf_format`; a value sent back exactly as stored is kept. On a render, `format` prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, a number is accepted for a CSS value, and only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`. Unknown keys are ignored.
        /// </param>
        /// <param name="sampleData">
        /// Default sample values for preview. Must be a JSON object (an array answers 400 `invalid_sample_data`).
        /// </param>
        /// <param name="headerComponentId">
        /// A header component (comp_xxx) of your organization. The `&lt;pdf4-header&gt;` tag in `html` is what renders: setting an ID rewrites a tag that names another component, `null` (or an empty string) clears it and removes the tag, and when omitted the ID follows a tag in the `html` sent (`html` without one keeps the current ID, which still prints). An unknown ID or one of another organization answers 400 `component_not_found`, a component that is not a header 400 `component_type_mismatch`.
        /// </param>
        /// <param name="footerComponentId">
        /// A footer component (comp_xxx) of your organization. The `&lt;pdf4-footer&gt;` tag in `html` is what renders: setting an ID rewrites a tag that names another component, `null` (or an empty string) clears it and removes the tag, and when omitted the ID follows a tag in the `html` sent (`html` without one keeps the current ID, which still prints). An unknown ID or one of another organization answers 400 `component_not_found`, a component that is not a footer 400 `component_type_mismatch`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTemplateRequest(
            string name,
            string? html,
            string? plainText,
            global::PDF4Dev.PdfFormat? pdfFormat,
            object? sampleData,
            string? headerComponentId,
            string? footerComponentId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Html = html;
            this.PlainText = plainText;
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