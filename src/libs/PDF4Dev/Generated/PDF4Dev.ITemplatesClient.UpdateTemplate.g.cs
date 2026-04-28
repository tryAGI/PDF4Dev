#nullable enable

namespace PDF4Dev
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Update a template<br/>
        /// Update a template's HTML, format, or sample data. Only provided fields are updated. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Template> UpdateTemplateAsync(
            string id,

            global::PDF4Dev.UpdateTemplateRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a template<br/>
        /// Update a template's HTML, format, or sample data. Only provided fields are updated. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="html"></param>
        /// <param name="plainText"></param>
        /// <param name="pdfFormat">
        /// Page format configuration. If omitted, defaults to A4 portrait with 20mm top/bottom and 15mm left/right margins.
        /// </param>
        /// <param name="sampleData"></param>
        /// <param name="headerComponentId">
        /// Header component ID or null to remove
        /// </param>
        /// <param name="footerComponentId">
        /// Footer component ID or null to remove
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Template> UpdateTemplateAsync(
            string id,
            string? name = default,
            string? html = default,
            string? plainText = default,
            global::PDF4Dev.PdfFormat? pdfFormat = default,
            object? sampleData = default,
            string? headerComponentId = default,
            string? footerComponentId = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}