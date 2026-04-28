
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Change component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline.
    /// </summary>
    public enum UpdateComponentRequestType
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
    public static class UpdateComponentRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateComponentRequestType value)
        {
            return value switch
            {
                UpdateComponentRequestType.Block => "block",
                UpdateComponentRequestType.Footer => "footer",
                UpdateComponentRequestType.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateComponentRequestType? ToEnum(string value)
        {
            return value switch
            {
                "block" => UpdateComponentRequestType.Block,
                "footer" => UpdateComponentRequestType.Footer,
                "header" => UpdateComponentRequestType.Header,
                _ => null,
            };
        }
    }
}