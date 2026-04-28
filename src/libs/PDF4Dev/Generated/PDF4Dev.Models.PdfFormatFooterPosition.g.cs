
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Footer position mode. "after-content" (default) places the footer right after the last content row. "page-bottom" pins the footer to the bottom of every page, including the last page.<br/>
    /// Example: after-content
    /// </summary>
    public enum PdfFormatFooterPosition
    {
        /// <summary>
        /// 
        /// </summary>
        AfterContent,
        /// <summary>
        /// 
        /// </summary>
        PageBottom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfFormatFooterPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfFormatFooterPosition value)
        {
            return value switch
            {
                PdfFormatFooterPosition.AfterContent => "after-content",
                PdfFormatFooterPosition.PageBottom => "page-bottom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfFormatFooterPosition? ToEnum(string value)
        {
            return value switch
            {
                "after-content" => PdfFormatFooterPosition.AfterContent,
                "page-bottom" => PdfFormatFooterPosition.PageBottom,
                _ => null,
            };
        }
    }
}