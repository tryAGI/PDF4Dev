
#nullable enable

namespace PDF4Dev
{
    /// <summary>
    /// Generate PDFs from HTML templates with Handlebars variables. Create templates in the dashboard, then render them via API with dynamic data.<br/>
    /// ## Authentication<br/>
    /// All API requests require a Bearer token. Create an API key in **Settings** and include it in the `Authorization` header:<br/>
    /// ```<br/>
    /// Authorization: Bearer p4_live_xxx...<br/>
    /// ```<br/>
    /// ## Quick Start<br/>
    /// 1. Create a template in the dashboard or via API<br/>
    /// 2. Generate an API key in Settings<br/>
    /// 3. Call `POST /api/v1/render` with your template ID and data<br/>
    /// ```bash<br/>
    /// curl -X POST https://pdf4.dev/api/v1/render \<br/>
    ///   -H "Authorization: Bearer p4_live_xxx" \<br/>
    ///   -H "Content-Type: application/json" \<br/>
    ///   -d '{"template_id": "invoice", "data": {"company": "Acme"}}' \<br/>
    ///   --output invoice.pdf<br/>
    /// ```<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IPDF4DevClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::PDF4Dev.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::PDF4Dev.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// Reusable HTML fragments: headers (repeat at top of every page), footers (repeat at bottom), and blocks (render inline). Attach header/footer to templates via header_component_id and footer_component_id. Reference blocks via &lt;pdf4-block&gt; tags in template HTML. Requires `full_access` API key scope.
        /// </summary>
        public ComponentsClient Components { get; }

        /// <summary>
        /// View PDF generation history. Each render (success or error) is logged with duration, file size, and metadata. Requires `full_access` API key scope.
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// Generate PDFs from templates or raw HTML. This is the core endpoint: most integrations only need this.
        /// </summary>
        public RenderClient Render { get; }

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats { get; }

        /// <summary>
        /// CRUD operations for HTML templates. Templates support Handlebars `{{variables}}` and can be referenced by ID or slug in render requests. Requires `full_access` API key scope.
        /// </summary>
        public TemplatesClient Templates { get; }

    }
}