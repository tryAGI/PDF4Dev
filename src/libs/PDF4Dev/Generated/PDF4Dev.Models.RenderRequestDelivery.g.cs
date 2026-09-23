
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// How to return the PDF. Omit for a binary `application/pdf` body (the default). `base64` returns JSON with the bytes inline. `url` stores the render and returns a signed URL valid for 24 hours, which is the recommended path for PDFs over 1 MB and for AI agents that cannot hold binary in context.<br/>
    /// Example: url
    /// </summary>
    public enum RenderRequestDelivery
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenderRequestDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderRequestDelivery value)
        {
            return value switch
            {
                RenderRequestDelivery.Base64 => "base64",
                RenderRequestDelivery.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderRequestDelivery? ToEnum(string value)
        {
            return value switch
            {
                "base64" => RenderRequestDelivery.Base64,
                "url" => RenderRequestDelivery.Url,
                _ => null,
            };
        }
    }
}