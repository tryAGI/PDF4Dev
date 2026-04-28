
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Error category
    /// </summary>
    public enum ApiErrorErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiError,
        /// <summary>
        /// 
        /// </summary>
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequestError,
        /// <summary>
        /// 
        /// </summary>
        NotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiErrorErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiErrorErrorType value)
        {
            return value switch
            {
                ApiErrorErrorType.ApiError => "api_error",
                ApiErrorErrorType.AuthenticationError => "authentication_error",
                ApiErrorErrorType.InvalidRequestError => "invalid_request_error",
                ApiErrorErrorType.NotFoundError => "not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiErrorErrorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => ApiErrorErrorType.ApiError,
                "authentication_error" => ApiErrorErrorType.AuthenticationError,
                "invalid_request_error" => ApiErrorErrorType.InvalidRequestError,
                "not_found_error" => ApiErrorErrorType.NotFoundError,
                _ => null,
            };
        }
    }
}