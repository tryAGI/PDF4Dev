
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Only provided fields are updated.
    /// </summary>
    public sealed partial class UpdateTemplateRequest
    {
        /// <summary>
        /// New name. The slug does not change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plain_text")]
        public string? PlainText { get; set; }

        /// <summary>
        /// Replaces the stored format as a whole: missing fields take the defaults. `null` resets it to the default format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_format")]
        public global::PDF4Dev.PdfFormat? PdfFormat { get; set; }

        /// <summary>
        /// A JSON object, or `null` to clear it.
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
        /// Initializes a new instance of the <see cref="UpdateTemplateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name. The slug does not change.
        /// </param>
        /// <param name="html"></param>
        /// <param name="plainText"></param>
        /// <param name="pdfFormat">
        /// Replaces the stored format as a whole: missing fields take the defaults. `null` resets it to the default format.
        /// </param>
        /// <param name="sampleData">
        /// A JSON object, or `null` to clear it.
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
        public UpdateTemplateRequest(
            string? name,
            string? html,
            string? plainText,
            global::PDF4Dev.PdfFormat? pdfFormat,
            object? sampleData,
            string? headerComponentId,
            string? footerComponentId)
        {
            this.Name = name;
            this.Html = html;
            this.PlainText = plainText;
            this.PdfFormat = pdfFormat;
            this.SampleData = sampleData;
            this.HeaderComponentId = headerComponentId;
            this.FooterComponentId = footerComponentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTemplateRequest" /> class.
        /// </summary>
        public UpdateTemplateRequest()
        {
        }

    }
}