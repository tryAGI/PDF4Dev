
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Component type. Headers repeat at the top of every page, footers at the bottom, blocks render inline where placed.
    /// </summary>
    public enum ComponentType
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
    public static class ComponentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComponentType value)
        {
            return value switch
            {
                ComponentType.Block => "block",
                ComponentType.Footer => "footer",
                ComponentType.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComponentType? ToEnum(string value)
        {
            return value switch
            {
                "block" => ComponentType.Block,
                "footer" => ComponentType.Footer,
                "header" => ComponentType.Header,
                _ => null,
            };
        }
    }
}