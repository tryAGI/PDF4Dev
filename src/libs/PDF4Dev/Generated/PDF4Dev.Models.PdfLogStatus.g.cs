
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public enum PdfLogStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfLogStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfLogStatus value)
        {
            return value switch
            {
                PdfLogStatus.Error => "error",
                PdfLogStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfLogStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PdfLogStatus.Error,
                "success" => PdfLogStatus.Success,
                _ => null,
            };
        }
    }
}