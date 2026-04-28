
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline where placed.
    /// </summary>
    public enum CreateComponentRequestType
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
    public static class CreateComponentRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComponentRequestType value)
        {
            return value switch
            {
                CreateComponentRequestType.Block => "block",
                CreateComponentRequestType.Footer => "footer",
                CreateComponentRequestType.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComponentRequestType? ToEnum(string value)
        {
            return value switch
            {
                "block" => CreateComponentRequestType.Block,
                "footer" => CreateComponentRequestType.Footer,
                "header" => CreateComponentRequestType.Header,
                _ => null,
            };
        }
    }
}