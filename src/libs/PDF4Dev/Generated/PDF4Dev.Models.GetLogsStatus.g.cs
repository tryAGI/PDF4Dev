
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetLogsStatus
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
    public static class GetLogsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLogsStatus value)
        {
            return value switch
            {
                GetLogsStatus.Error => "error",
                GetLogsStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLogsStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetLogsStatus.Error,
                "success" => GetLogsStatus.Success,
                _ => null,
            };
        }
    }
}