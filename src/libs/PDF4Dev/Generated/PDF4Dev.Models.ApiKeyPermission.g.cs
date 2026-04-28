
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Permission scope
    /// </summary>
    public enum ApiKeyPermission
    {
        /// <summary>
        /// 
        /// </summary>
        FullAccess,
        /// <summary>
        /// 
        /// </summary>
        RenderOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyPermission value)
        {
            return value switch
            {
                ApiKeyPermission.FullAccess => "full_access",
                ApiKeyPermission.RenderOnly => "render_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyPermission? ToEnum(string value)
        {
            return value switch
            {
                "full_access" => ApiKeyPermission.FullAccess,
                "render_only" => ApiKeyPermission.RenderOnly,
                _ => null,
            };
        }
    }
}