#nullable enable

namespace PDF4Dev
{
    public partial interface IComponentsClient
    {
        /// <summary>
        /// Create a component<br/>
        /// Create a header, footer or block component. Use {{variables}} for data. In a header or footer, page numbers are written `&lt;span class="pageNumber"&gt;&lt;/span&gt;` / `&lt;span class="totalPages"&gt;&lt;/span&gt;` or `{{pageNumber}}` / `{{totalPages}}`: PDF4.dev stamps them on each page after rendering, and they are not data variables. Errors: 400 `invalid_json`, `missing_parameter`, `invalid_parameter` (an empty name, an unknown type, a non-string html or preview). Requires `full_access` API key scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Component> CreateComponentAsync(

            global::PDF4Dev.CreateComponentRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a component<br/>
        /// Create a header, footer or block component. Use {{variables}} for data. In a header or footer, page numbers are written `&lt;span class="pageNumber"&gt;&lt;/span&gt;` / `&lt;span class="totalPages"&gt;&lt;/span&gt;` or `{{pageNumber}}` / `{{totalPages}}`: PDF4.dev stamps them on each page after rendering, and they are not data variables. Errors: 400 `invalid_json`, `missing_parameter`, `invalid_parameter` (an empty name, an unknown type, a non-string html or preview). Requires `full_access` API key scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.Component>> CreateComponentAsResponseAsync(

            global::PDF4Dev.CreateComponentRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a component<br/>
        /// Create a header, footer or block component. Use {{variables}} for data. In a header or footer, page numbers are written `&lt;span class="pageNumber"&gt;&lt;/span&gt;` / `&lt;span class="totalPages"&gt;&lt;/span&gt;` or `{{pageNumber}}` / `{{totalPages}}`: PDF4.dev stamps them on each page after rendering, and they are not data variables. Errors: 400 `invalid_json`, `missing_parameter`, `invalid_parameter` (an empty name, an unknown type, a non-string html or preview). Requires `full_access` API key scope.
        /// </summary>
        /// <param name="name">
        /// Component name (e.g. Company header)
        /// </param>
        /// <param name="type">
        /// Component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline where placed.
        /// </param>
        /// <param name="html">
        /// HTML with {{handlebars}} variables
        /// </param>
        /// <param name="preview">
        /// Plain text preview (auto-generated from HTML if omitted)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Component> CreateComponentAsync(
            string name,
            global::PDF4Dev.CreateComponentRequestType type,
            string? html = default,
            string? preview = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}