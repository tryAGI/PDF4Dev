
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Page size preset. Use `custom` with `width`/`height` for arbitrary dimensions.<br/>
    /// Example: a4
    /// </summary>
    public enum PdfFormatPreset
    {
        /// <summary>
        /// 
        /// </summary>
        A4,
        /// <summary>
        /// 
        /// </summary>
        A4Landscape,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Letter,
        /// <summary>
        /// 
        /// </summary>
        LetterLandscape,
        /// <summary>
        /// 
        /// </summary>
        Square,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfFormatPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfFormatPreset value)
        {
            return value switch
            {
                PdfFormatPreset.A4 => "a4",
                PdfFormatPreset.A4Landscape => "a4-landscape",
                PdfFormatPreset.Custom => "custom",
                PdfFormatPreset.Letter => "letter",
                PdfFormatPreset.LetterLandscape => "letter-landscape",
                PdfFormatPreset.Square => "square",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfFormatPreset? ToEnum(string value)
        {
            return value switch
            {
                "a4" => PdfFormatPreset.A4,
                "a4-landscape" => PdfFormatPreset.A4Landscape,
                "custom" => PdfFormatPreset.Custom,
                "letter" => PdfFormatPreset.Letter,
                "letter-landscape" => PdfFormatPreset.LetterLandscape,
                "square" => PdfFormatPreset.Square,
                _ => null,
            };
        }
    }
}