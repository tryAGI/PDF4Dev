#nullable enable

namespace PDF4Dev
{
    public partial interface IRenderClient
    {
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RenderPdfAsync(

            global::PDF4Dev.RenderRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> RenderPdfAsStreamAsync(

            global::PDF4Dev.RenderRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<byte[]>> RenderPdfAsResponseAsync(

            global::PDF4Dev.RenderRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).
        /// </summary>
        /// <param name="templateId">
        /// Template ID (`tmpl_xxx`) or slug. The template must belong to the authenticated user.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="html">
        /// Raw HTML string. Supports Handlebars `{{variables}}` syntax. Use this for one-off renders without saving a template.<br/>
        /// Example: &lt;h1&gt;Hello {{name}}&lt;/h1&gt;
        /// </param>
        /// <param name="data">
        /// Data to replace `{{variables}}` in the template. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
        /// Example: {"name":"World","company":"Acme Corp"}
        /// </param>
        /// <param name="format">
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RenderPdfAsync(
            string? templateId = default,
            string? html = default,
            object? data = default,
            global::PDF4Dev.PdfFormat? format = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}