
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Permission scope. Defaults to full_access.<br/>
    /// Example: full_access
    /// </summary>
    public enum CreateApiKeyRequestPermission
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
    public static class CreateApiKeyRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyRequestPermission value)
        {
            return value switch
            {
                CreateApiKeyRequestPermission.FullAccess => "full_access",
                CreateApiKeyRequestPermission.RenderOnly => "render_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "full_access" => CreateApiKeyRequestPermission.FullAccess,
                "render_only" => CreateApiKeyRequestPermission.RenderOnly,
                _ => null,
            };
        }
    }
}