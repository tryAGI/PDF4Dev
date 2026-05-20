
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Only provided fields are updated.
    /// </summary>
    public sealed partial class UpdateTemplateRequest
    {
        /// <summary>
        /// 
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
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_format")]
        public global::PDF4Dev.PdfFormat? PdfFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_data")]
        public object? SampleData { get; set; }

        /// <summary>
        /// Header component ID or null to remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_component_id")]
        public string? HeaderComponentId { get; set; }

        /// <summary>
        /// Footer component ID or null to remove
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
        /// <param name="name"></param>
        /// <param name="html"></param>
        /// <param name="plainText"></param>
        /// <param name="pdfFormat">
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </param>
        /// <param name="sampleData"></param>
        /// <param name="headerComponentId">
        /// Header component ID or null to remove
        /// </param>
        /// <param name="footerComponentId">
        /// Footer component ID or null to remove
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