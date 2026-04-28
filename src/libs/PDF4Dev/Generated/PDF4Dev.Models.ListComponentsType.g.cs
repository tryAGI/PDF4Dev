
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListComponentsType
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Footer,
        /// <summary>
        /// 
        /// </summary>
        Header,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListComponentsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComponentsType value)
        {
            return value switch
            {
                ListComponentsType.Block => "block",
                ListComponentsType.Footer => "footer",
                ListComponentsType.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComponentsType? ToEnum(string value)
        {
            return value switch
            {
                "block" => ListComponentsType.Block,
                "footer" => ListComponentsType.Footer,
                "header" => ListComponentsType.Header,
                _ => null,
            };
        }
    }
}