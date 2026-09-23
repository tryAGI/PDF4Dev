
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace PDF4Dev
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.RenderRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfFormat? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.RenderRequestDelivery? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.RenderUrlResponse? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.RenderBase64Response? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.Template? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.CreateTemplateRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.UpdateTemplateRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.Component? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.ComponentType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.CreateComponentRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.CreateComponentRequestType? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.UpdateComponentRequest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.UpdateComponentRequestType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfFormatPreset? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfFormatMargins? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfFormatTextAlign? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfFormatHorizontalAlign? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfFormatVerticalAlign? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfFormatFooterPosition? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.ApiError? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.ApiErrorError? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.ApiErrorErrorType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfLog? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.PdfLogStatus? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.CursorPaginatedLogs? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PDF4Dev.PdfLog>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.Stats? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.ApiKey? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.ApiKeyPermission? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.CreateApiKeyRequest? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.CreateApiKeyRequestPermission? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.ListComponentsType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.GetLogsStatus? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.GetStatsPeriod? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PDF4Dev.Template>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.DeleteTemplateResponse? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PDF4Dev.Component>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.DeleteComponentResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::PDF4Dev.ApiKey>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.AllOf<global::PDF4Dev.ApiKey, global::PDF4Dev.CreateApiKeyResponse2>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.CreateApiKeyResponse2? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.DeleteApiKeyResponse? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::PDF4Dev.DeleteAccountResponse? Type51 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PDF4Dev.PdfLog>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PDF4Dev.Template>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PDF4Dev.Component>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::PDF4Dev.ApiKey>? ListType3 { get; set; }
    }
}