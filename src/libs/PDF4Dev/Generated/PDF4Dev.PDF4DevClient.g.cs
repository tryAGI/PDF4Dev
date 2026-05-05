
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
    public sealed partial class PDF4DevClient : global::PDF4Dev.IPDF4DevClient, global::System.IDisposable
    {
        /// <summary>
        /// Current server
        /// </summary>
        public const string DefaultBaseUrl = "https://pdf4.dev/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::PDF4Dev.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::PDF4Dev.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::PDF4Dev.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public AccountClient Account => new AccountClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Reusable HTML fragments: headers (repeat at top of every page), footers (repeat at bottom), and blocks (render inline). Attach header/footer to templates via header_component_id and footer_component_id. Reference blocks via &lt;pdf4-block&gt; tags in template HTML. Requires `full_access` API key scope.
        /// </summary>
        public ComponentsClient Components => new ComponentsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// View PDF generation history. Each render (success or error) is logged with duration, file size, and metadata. Requires `full_access` API key scope.
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Generate PDFs from templates or raw HTML. This is the core endpoint: most integrations only need this.
        /// </summary>
        public RenderClient Render => new RenderClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats => new StatsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// CRUD operations for HTML templates. Templates support Handlebars `{{variables}}` and can be referenced by ID or slug in render requests. Requires `full_access` API key scope.
        /// </summary>
        public TemplatesClient Templates => new TemplatesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the PDF4DevClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PDF4DevClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::PDF4Dev.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the PDF4DevClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public PDF4DevClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::PDF4Dev.EndPointAuthorization>? authorizations,
            global::PDF4Dev.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::PDF4Dev.EndPointAuthorization>();
            Options = options ?? new global::PDF4Dev.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}