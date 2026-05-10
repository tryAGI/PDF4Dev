
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Data to replace `{{variables}}` in the template. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
    /// Example: {"name":"World","company":"Acme Corp"}
    /// </summary>
    public sealed partial class RenderRequestData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}