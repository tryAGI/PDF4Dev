#nullable enable

namespace PDF4Dev.JsonConverters
{
    /// <inheritdoc />
    public sealed class PdfFormatPresetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PDF4Dev.PdfFormatPreset?>
    {
        /// <inheritdoc />
        public override global::PDF4Dev.PdfFormatPreset? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::PDF4Dev.PdfFormatPresetExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PDF4Dev.PdfFormatPreset)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PDF4Dev.PdfFormatPreset?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PDF4Dev.PdfFormatPreset? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::PDF4Dev.PdfFormatPresetExtensions.ToValueString(value.Value));
            }
        }
    }
}
