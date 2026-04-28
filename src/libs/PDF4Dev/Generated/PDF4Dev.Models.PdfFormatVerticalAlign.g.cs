
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Vertical content alignment on the page (useful for single-page documents like certificates)<br/>
    /// Example: top
    /// </summary>
    public enum PdfFormatVerticalAlign
    {
        /// <summary>
        /// 
        /// </summary>
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfFormatVerticalAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfFormatVerticalAlign value)
        {
            return value switch
            {
                PdfFormatVerticalAlign.Bottom => "bottom",
                PdfFormatVerticalAlign.Center => "center",
                PdfFormatVerticalAlign.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfFormatVerticalAlign? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => PdfFormatVerticalAlign.Bottom,
                "center" => PdfFormatVerticalAlign.Center,
                "top" => PdfFormatVerticalAlign.Top,
                _ => null,
            };
        }
    }
}