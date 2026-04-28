
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace PDF4Dev
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::PDF4Dev.JsonConverters.ComponentTypeJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.ComponentTypeNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.CreateComponentRequestTypeJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.CreateComponentRequestTypeNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.UpdateComponentRequestTypeJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.UpdateComponentRequestTypeNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatPresetJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatPresetNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatTextAlignJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatTextAlignNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatHorizontalAlignJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatHorizontalAlignNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatVerticalAlignJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatVerticalAlignNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatFooterPositionJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfFormatFooterPositionNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.ApiErrorErrorTypeJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.ApiErrorErrorTypeNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfLogStatusJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.PdfLogStatusNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.ApiKeyPermissionJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.ApiKeyPermissionNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.CreateApiKeyRequestPermissionJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.CreateApiKeyRequestPermissionNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.ListComponentsTypeJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.ListComponentsTypeNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.GetLogsStatusJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.GetLogsStatusNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.GetStatsPeriodJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.GetStatsPeriodNullableJsonConverter),

            typeof(global::PDF4Dev.JsonConverters.AllOfJsonConverter<global::PDF4Dev.ApiKey, global::PDF4Dev.CreateApiKeyResponse2>),

            typeof(global::PDF4Dev.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.RenderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.CreateTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.UpdateTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.Component))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.ComponentType), TypeInfoPropertyName = "ComponentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.CreateComponentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.CreateComponentRequestType), TypeInfoPropertyName = "CreateComponentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.UpdateComponentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.UpdateComponentRequestType), TypeInfoPropertyName = "UpdateComponentRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfFormatPreset), TypeInfoPropertyName = "PdfFormatPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfFormatMargins))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfFormatTextAlign), TypeInfoPropertyName = "PdfFormatTextAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfFormatHorizontalAlign), TypeInfoPropertyName = "PdfFormatHorizontalAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfFormatVerticalAlign), TypeInfoPropertyName = "PdfFormatVerticalAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfFormatFooterPosition), TypeInfoPropertyName = "PdfFormatFooterPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.ApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.ApiErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.ApiErrorErrorType), TypeInfoPropertyName = "ApiErrorErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.PdfLogStatus), TypeInfoPropertyName = "PdfLogStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.CursorPaginatedLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PDF4Dev.PdfLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.Stats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.ApiKeyPermission), TypeInfoPropertyName = "ApiKeyPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.CreateApiKeyRequestPermission), TypeInfoPropertyName = "CreateApiKeyRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.ListComponentsType), TypeInfoPropertyName = "ListComponentsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.GetLogsStatus), TypeInfoPropertyName = "GetLogsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.GetStatsPeriod), TypeInfoPropertyName = "GetStatsPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PDF4Dev.Template>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.DeleteTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PDF4Dev.Component>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.DeleteComponentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PDF4Dev.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.AllOf<global::PDF4Dev.ApiKey, global::PDF4Dev.CreateApiKeyResponse2>), TypeInfoPropertyName = "AllOfApiKeyCreateApiKeyResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.CreateApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.DeleteApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PDF4Dev.DeleteAccountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PDF4Dev.PdfLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PDF4Dev.Template>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PDF4Dev.Component>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PDF4Dev.ApiKey>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}