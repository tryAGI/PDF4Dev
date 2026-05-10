
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Page margins
    /// </summary>
    public sealed partial class PdfFormatMargins
    {
        /// <summary>
        /// Example: 20mm
        /// </summary>
        /// <example>20mm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        public string? Top { get; set; }

        /// <summary>
        /// Example: 20mm
        /// </summary>
        /// <example>20mm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom")]
        public string? Bottom { get; set; }

        /// <summary>
        /// Example: 15mm
        /// </summary>
        /// <example>15mm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        public string? Left { get; set; }

        /// <summary>
        /// Example: 15mm
        /// </summary>
        /// <example>15mm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        public string? Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFormatMargins" /> class.
        /// </summary>
        /// <param name="top">
        /// Example: 20mm
        /// </param>
        /// <param name="bottom">
        /// Example: 20mm
        /// </param>
        /// <param name="left">
        /// Example: 15mm
        /// </param>
        /// <param name="right">
        /// Example: 15mm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PdfFormatMargins(
            string? top,
            string? bottom,
            string? left,
            string? right)
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfFormatMargins" /> class.
        /// </summary>
        public PdfFormatMargins()
        {
        }

    }
}