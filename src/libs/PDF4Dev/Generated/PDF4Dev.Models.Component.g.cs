
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Component
    {
        /// <summary>
        /// Unique component ID<br/>
        /// Example: comp_a1b2c3d4e5f6
        /// </summary>
        /// <example>comp_a1b2c3d4e5f6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Display name<br/>
        /// Example: Company header
        /// </summary>
        /// <example>Company header</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Component type. Headers repeat at the top of every page, footers at the bottom, blocks render inline where placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PDF4Dev.JsonConverters.ComponentTypeJsonConverter))]
        public global::PDF4Dev.ComponentType? Type { get; set; }

        /// <summary>
        /// HTML with Handlebars variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Plain text preview (auto-generated from HTML if omitted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public string? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Component" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique component ID<br/>
        /// Example: comp_a1b2c3d4e5f6
        /// </param>
        /// <param name="name">
        /// Display name<br/>
        /// Example: Company header
        /// </param>
        /// <param name="type">
        /// Component type. Headers repeat at the top of every page, footers at the bottom, blocks render inline where placed.
        /// </param>
        /// <param name="html">
        /// HTML with Handlebars variables
        /// </param>
        /// <param name="preview">
        /// Plain text preview (auto-generated from HTML if omitted)
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Component(
            string? id,
            string? name,
            global::PDF4Dev.ComponentType? type,
            string? html,
            string? preview,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Html = html;
            this.Preview = preview;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Component" /> class.
        /// </summary>
        public Component()
        {
        }

    }
}