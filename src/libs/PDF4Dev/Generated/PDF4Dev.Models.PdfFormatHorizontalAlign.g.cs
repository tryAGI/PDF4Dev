
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Horizontal content alignment on the page<br/>
    /// Example: left
    /// </summary>
    public enum PdfFormatHorizontalAlign
    {
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfFormatHorizontalAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfFormatHorizontalAlign value)
        {
            return value switch
            {
                PdfFormatHorizontalAlign.Center => "center",
                PdfFormatHorizontalAlign.Left => "left",
                PdfFormatHorizontalAlign.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfFormatHorizontalAlign? ToEnum(string value)
        {
            return value switch
            {
                "center" => PdfFormatHorizontalAlign.Center,
                "left" => PdfFormatHorizontalAlign.Left,
                "right" => PdfFormatHorizontalAlign.Right,
                _ => null,
            };
        }
    }
}