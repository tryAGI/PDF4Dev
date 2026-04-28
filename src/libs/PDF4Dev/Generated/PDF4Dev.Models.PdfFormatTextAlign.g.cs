
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Default text alignment for the page<br/>
    /// Example: left
    /// </summary>
    public enum PdfFormatTextAlign
    {
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Justify,
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
    public static class PdfFormatTextAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfFormatTextAlign value)
        {
            return value switch
            {
                PdfFormatTextAlign.Center => "center",
                PdfFormatTextAlign.Justify => "justify",
                PdfFormatTextAlign.Left => "left",
                PdfFormatTextAlign.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfFormatTextAlign? ToEnum(string value)
        {
            return value switch
            {
                "center" => PdfFormatTextAlign.Center,
                "justify" => PdfFormatTextAlign.Justify,
                "left" => PdfFormatTextAlign.Left,
                "right" => PdfFormatTextAlign.Right,
                _ => null,
            };
        }
    }
}