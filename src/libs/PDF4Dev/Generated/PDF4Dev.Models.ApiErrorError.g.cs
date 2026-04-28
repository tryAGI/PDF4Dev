
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiErrorError
    {
        /// <summary>
        /// Error category
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.ApiErrorErrorTypeJsonConverter))]
        public global::PDF4Dev.ApiErrorErrorType? Type { get; set; }

        /// <summary>
        /// Machine-readable error code<br/>
        /// Example: missing_parameter
        /// </summary>
        /// <example>missing_parameter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Either template_id or html is required
        /// </summary>
        /// <example>Either template_id or html is required</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiErrorError" /> class.
        /// </summary>
        /// <param name="type">
        /// Error category
        /// </param>
        /// <param name="code">
        /// Machine-readable error code<br/>
        /// Example: missing_parameter
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Either template_id or html is required
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiErrorError(
            global::PDF4Dev.ApiErrorErrorType? type,
            string? code,
            string? message)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiErrorError" /> class.
        /// </summary>
        public ApiErrorError()
        {
        }
    }
}