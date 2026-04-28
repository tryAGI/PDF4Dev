
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
    /// </summary>
    public sealed partial class PdfFormat
    {
        /// <summary>
        /// Page size preset. Use `custom` with `width`/`height` for arbitrary dimensions.<br/>
        /// Example: a4
        /// </summary>
        /// <example>a4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.PdfFormatPresetJsonConverter))]
        public global::PDF4Dev.PdfFormatPreset? Preset { get; set; }

        /// <summary>
        /// Custom width (only used when preset is `custom`)<br/>
        /// Example: 210mm
        /// </summary>
        /// <example>210mm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public string? Width { get; set; }

        /// <summary>
        /// Custom height (only used when preset is `custom`)<br/>
        /// Example: 297mm
        /// </summary>
        /// <example>297mm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public string? Height { get; set; }

        /// <summary>
        /// Page margins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margins")]
        public global::PDF4Dev.PdfFormatMargins? Margins { get; set; }

        /// <summary>
        /// Page background color (CSS value)<br/>
        /// Example: #ffffff
        /// </summary>
        /// <example>#ffffff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Default font family injected into the page<br/>
        /// Example: Inter, sans-serif
        /// </summary>
        /// <example>Inter, sans-serif</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_family")]
        public string? FontFamily { get; set; }

        /// <summary>
        /// Default font size injected into the page<br/>
        /// Example: 14px
        /// </summary>
        /// <example>14px</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_size")]
        public string? FontSize { get; set; }

        /// <summary>
        /// Default text alignment for the page<br/>
        /// Example: left
        /// </summary>
        /// <example>left</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_align")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.PdfFormatTextAlignJsonConverter))]
        public global::PDF4Dev.PdfFormatTextAlign? TextAlign { get; set; }

        /// <summary>
        /// Horizontal content alignment on the page<br/>
        /// Example: left
        /// </summary>
        /// <example>left</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal_align")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.PdfFormatHorizontalAlignJsonConverter))]
        public global::PDF4Dev.PdfFormatHorizontalAlign? HorizontalAlign { get; set; }

        /// <summary>
        /// Vertical content alignment on the page (useful for single-page documents like certificates)<br/>
        /// Example: top
        /// </summary>
        /// <example>top</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical_align")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.PdfFormatVerticalAlignJsonConverter))]
        public global::PDF4Dev.PdfFormatVerticalAlign? VerticalAlign { get; set; }

        /// <summary>
        /// Google Fonts URL or any @import-compatible CSS URL. Loads in &lt;head&gt;, available to template and all components.<br/>
        /// Example: https://fonts.googleapis.com/css2?family=Roboto&amp;display=swap
        /// </summary>
        /// <example>https://fonts.googleapis.com/css2?family=Roboto&amp;display=swap</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_fonts_url")]
        public string? GoogleFontsUrl { get; set; }

        /// <summary>
        /// Default text color injected into the page<br/>
        /// Example: #333333
        /// </summary>
        /// <example>#333333</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Default line-height injected into the page<br/>
        /// Example: 1.5
        /// </summary>
        /// <example>1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_height")]
        public string? LineHeight { get; set; }

        /// <summary>
        /// Gap between header/footer components and page content. Applied as padding between the repeated header/footer and the body content.<br/>
        /// Example: 5mm
        /// </summary>
        /// <example>5mm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("component_gap")]
        public string? ComponentGap { get; set; }

        /// <summary>
        /// Footer position mode. "after-content" (default) places the footer right after the last content row. "page-bottom" pins the footer to the bottom of every page, including the last page.<br/>
        /// Example: after-content
        /// </summary>
        /// <example>after-content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("footer_position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.PdfFormatFooterPositionJsonConverter))]
        public global::PDF4Dev.PdfFormatFooterPosition? FooterPosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFormat" /> class.
        /// </summary>
        /// <param name="preset">
        /// Page size preset. Use `custom` with `width`/`height` for arbitrary dimensions.<br/>
        /// Example: a4
        /// </param>
        /// <param name="width">
        /// Custom width (only used when preset is `custom`)<br/>
        /// Example: 210mm
        /// </param>
        /// <param name="height">
        /// Custom height (only used when preset is `custom`)<br/>
        /// Example: 297mm
        /// </param>
        /// <param name="margins">
        /// Page margins
        /// </param>
        /// <param name="backgroundColor">
        /// Page background color (CSS value)<br/>
        /// Example: #ffffff
        /// </param>
        /// <param name="fontFamily">
        /// Default font family injected into the page<br/>
        /// Example: Inter, sans-serif
        /// </param>
        /// <param name="fontSize">
        /// Default font size injected into the page<br/>
        /// Example: 14px
        /// </param>
        /// <param name="textAlign">
        /// Default text alignment for the page<br/>
        /// Example: left
        /// </param>
        /// <param name="horizontalAlign">
        /// Horizontal content alignment on the page<br/>
        /// Example: left
        /// </param>
        /// <param name="verticalAlign">
        /// Vertical content alignment on the page (useful for single-page documents like certificates)<br/>
        /// Example: top
        /// </param>
        /// <param name="googleFontsUrl">
        /// Google Fonts URL or any @import-compatible CSS URL. Loads in &lt;head&gt;, available to template and all components.<br/>
        /// Example: https://fonts.googleapis.com/css2?family=Roboto&amp;display=swap
        /// </param>
        /// <param name="color">
        /// Default text color injected into the page<br/>
        /// Example: #333333
        /// </param>
        /// <param name="lineHeight">
        /// Default line-height injected into the page<br/>
        /// Example: 1.5
        /// </param>
        /// <param name="componentGap">
        /// Gap between header/footer components and page content. Applied as padding between the repeated header/footer and the body content.<br/>
        /// Example: 5mm
        /// </param>
        /// <param name="footerPosition">
        /// Footer position mode. "after-content" (default) places the footer right after the last content row. "page-bottom" pins the footer to the bottom of every page, including the last page.<br/>
        /// Example: after-content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PdfFormat(
            global::PDF4Dev.PdfFormatPreset? preset,
            string? width,
            string? height,
            global::PDF4Dev.PdfFormatMargins? margins,
            string? backgroundColor,
            string? fontFamily,
            string? fontSize,
            global::PDF4Dev.PdfFormatTextAlign? textAlign,
            global::PDF4Dev.PdfFormatHorizontalAlign? horizontalAlign,
            global::PDF4Dev.PdfFormatVerticalAlign? verticalAlign,
            string? googleFontsUrl,
            string? color,
            string? lineHeight,
            string? componentGap,
            global::PDF4Dev.PdfFormatFooterPosition? footerPosition)
        {
            this.Preset = preset;
            this.Width = width;
            this.Height = height;
            this.Margins = margins;
            this.BackgroundColor = backgroundColor;
            this.FontFamily = fontFamily;
            this.FontSize = fontSize;
            this.TextAlign = textAlign;
            this.HorizontalAlign = horizontalAlign;
            this.VerticalAlign = verticalAlign;
            this.GoogleFontsUrl = googleFontsUrl;
            this.Color = color;
            this.LineHeight = lineHeight;
            this.ComponentGap = componentGap;
            this.FooterPosition = footerPosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFormat" /> class.
        /// </summary>
        public PdfFormat()
        {
        }
    }
}