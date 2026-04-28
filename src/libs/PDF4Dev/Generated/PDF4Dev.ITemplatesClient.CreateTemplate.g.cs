#nullable enable

namespace PDF4Dev
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create a template<br/>
        /// Create a new template. The `name` is required and a URL-safe `slug` is auto-generated from it. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Template> CreateTemplateAsync(

            global::PDF4Dev.CreateTemplateRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a template<br/>
        /// Create a new template. The `name` is required and a URL-safe `slug` is auto-generated from it. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="name">
        /// Template name. A slug is auto-generated from this.
        /// </param>
        /// <param name="html">
        /// HTML template content. Supports Handlebars `{{variables}}`.
        /// </param>
        /// <param name="pdfFormat">
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </param>
        /// <param name="sampleData">
        /// Default sample values for preview
        /// </param>
        /// <param name="headerComponentId">
        /// Header component ID (comp_xxx)
        /// </param>
        /// <param name="footerComponentId">
        /// Footer component ID (comp_xxx)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Template> CreateTemplateAsync(
            string name,
            string? html = default,
            global::PDF4Dev.PdfFormat? pdfFormat = default,
            object? sampleData = default,
            string? headerComponentId = default,
            string? footerComponentId = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}