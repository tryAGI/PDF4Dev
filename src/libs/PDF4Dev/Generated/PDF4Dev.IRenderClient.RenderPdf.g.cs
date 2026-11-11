#nullable enable

namespace PDF4Dev
{
    public partial interface IRenderClient
    {
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).<br/>
        /// Errors: 400 `invalid_json` (the body is not a JSON object), `invalid_data` (`data` is not an object), `invalid_format` (a `format` margin, or custom width or height, that cannot be read), `template_syntax_error` and `template_runtime_error` (the message names the template, header, footer or block that failed); 413 `request_too_large` for a body over 10 MB, refused before it is read; 422 `render_timeout` when the render takes longer than 60 seconds. With `delivery: "url"`: 413 `render_too_large` for a PDF over the URL-delivery size (base64 delivery takes it), 507 `render_storage_full` with `Retry-After` when stored renders are at their limit, 500 `storage_failed`. A failed render or URL delivery is logged as a failure, with its template and duration; a bad body is not logged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>> RenderPdfAsync(

            global::PDF4Dev.RenderRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).<br/>
        /// Errors: 400 `invalid_json` (the body is not a JSON object), `invalid_data` (`data` is not an object), `invalid_format` (a `format` margin, or custom width or height, that cannot be read), `template_syntax_error` and `template_runtime_error` (the message names the template, header, footer or block that failed); 413 `request_too_large` for a body over 10 MB, refused before it is read; 422 `render_timeout` when the render takes longer than 60 seconds. With `delivery: "url"`: 413 `render_too_large` for a PDF over the URL-delivery size (base64 delivery takes it), 507 `render_storage_full` with `Retry-After` when stored renders are at their limit, 500 `storage_failed`. A failed render or URL delivery is logged as a failure, with its template and duration; a bad body is not logged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>>> RenderPdfAsResponseAsync(

            global::PDF4Dev.RenderRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).<br/>
        /// Errors: 400 `invalid_json` (the body is not a JSON object), `invalid_data` (`data` is not an object), `invalid_format` (a `format` margin, or custom width or height, that cannot be read), `template_syntax_error` and `template_runtime_error` (the message names the template, header, footer or block that failed); 413 `request_too_large` for a body over 10 MB, refused before it is read; 422 `render_timeout` when the render takes longer than 60 seconds. With `delivery: "url"`: 413 `render_too_large` for a PDF over the URL-delivery size (base64 delivery takes it), 507 `render_storage_full` with `Retry-After` when stored renders are at their limit, 500 `storage_failed`. A failed render or URL delivery is logged as a failure, with its template and duration; a bad body is not logged.
        /// </summary>
        /// <param name="templateId">
        /// Template ID (`tmpl_xxx`) or slug. The template must belong to the authenticated user. `null` reads as omitted.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="html">
        /// Raw HTML string. Supports Handlebars `{{variables}}` syntax. Use this for one-off renders without saving a template. `null` reads as omitted.<br/>
        /// Example: &lt;h1&gt;Hello {{name}}&lt;/h1&gt;
        /// </param>
        /// <param name="data">
        /// Data to replace `{{variables}}` in the template. A JSON object: `null`, `""`, `false` and `0` read as omitted, anything else answers 400 `invalid_data`. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
        /// Example: {"name":"World","company":"Acme Corp"}
        /// </param>
        /// <param name="format">
        /// Page format for this render. It replaces the template's format as a whole: missing fields take the defaults (A4 portrait, 20mm top/bottom and 15mm left/right margins), they are not read from the template. It prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, and a `margins` object prints a side it leaves out at 0 (the default margins apply only when `margins` is left out). `null`, `""`, `false` and `0` read as omitted. Only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`.
        /// </param>
        /// <param name="delivery">
        /// How to return the PDF. Omit for a binary `application/pdf` body (the default). `base64` returns JSON with the bytes inline. `url` stores the render and returns a signed URL valid for 24 hours, which is the recommended path for PDFs over 1 MB and for AI agents that cannot hold binary in context. An organization keeps at most 200 stored renders (500 MiB) by default; past that its oldest are deleted first, so a URL can stop working sooner. After expiry the URL answers 404 `render_expired`.<br/>
        /// Example: url
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>> RenderPdfAsync(
            string? templateId = default,
            string? html = default,
            object? data = default,
            global::PDF4Dev.PdfFormat? format = default,
            global::PDF4Dev.RenderRequestDelivery? delivery = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}