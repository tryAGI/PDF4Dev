
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// API key ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Display name<br/>
        /// Example: Production
        /// </summary>
        /// <example>Production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Key prefix for identification<br/>
        /// Example: p4_live_abc...
        /// </summary>
        /// <example>p4_live_abc...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Permission scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.ApiKeyPermissionJsonConverter))]
        public global::PDF4Dev.ApiKeyPermission? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// API key ID
        /// </param>
        /// <param name="name">
        /// Display name<br/>
        /// Example: Production
        /// </param>
        /// <param name="prefix">
        /// Key prefix for identification<br/>
        /// Example: p4_live_abc...
        /// </param>
        /// <param name="permission">
        /// Permission scope
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKey(
            string? id,
            string? name,
            string? prefix,
            global::PDF4Dev.ApiKeyPermission? permission,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.Prefix = prefix;
            this.Permission = permission;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }
    }
}