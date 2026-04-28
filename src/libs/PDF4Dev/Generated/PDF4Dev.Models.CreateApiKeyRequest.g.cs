
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// Display name for the key<br/>
        /// Example: Production
        /// </summary>
        /// <example>Production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Permission scope. Defaults to full_access.<br/>
        /// Example: full_access
        /// </summary>
        /// <example>full_access</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.CreateApiKeyRequestPermissionJsonConverter))]
        public global::PDF4Dev.CreateApiKeyRequestPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name for the key<br/>
        /// Example: Production
        /// </param>
        /// <param name="permission">
        /// Permission scope. Defaults to full_access.<br/>
        /// Example: full_access
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyRequest(
            string name,
            global::PDF4Dev.CreateApiKeyRequestPermission? permission)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        public CreateApiKeyRequest()
        {
        }
    }
}