
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetStatsPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x24h,
        /// <summary>
        /// 
        /// </summary>
        x30d,
        /// <summary>
        /// 
        /// </summary>
        x7d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStatsPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStatsPeriod value)
        {
            return value switch
            {
                GetStatsPeriod.x1h => "1h",
                GetStatsPeriod.x24h => "24h",
                GetStatsPeriod.x30d => "30d",
                GetStatsPeriod.x7d => "7d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStatsPeriod? ToEnum(string value)
        {
            return value switch
            {
                "1h" => GetStatsPeriod.x1h,
                "24h" => GetStatsPeriod.x24h,
                "30d" => GetStatsPeriod.x30d,
                "7d" => GetStatsPeriod.x7d,
                _ => null,
            };
        }
    }
}