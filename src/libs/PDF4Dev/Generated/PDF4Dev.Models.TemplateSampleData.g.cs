
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Default sample values for preview. These are NOT used during API rendering: you must pass `data` explicitly.
    /// </summary>
    public sealed partial class TemplateSampleData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}