#nullable enable

namespace PDF4Dev
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Update a template<br/>
        /// Update a template by ID or slug. Only provided fields are updated; a `pdf_format` replaces the stored format as a whole (missing fields take the defaults, nothing is merged). The slug never changes, even on a rename. Requires `full_access` API key scope.<br/>
        /// Errors: 400 `invalid_json`, `invalid_parameter`, `invalid_pdf_format`, `invalid_sample_data`, `component_not_found`, `component_type_mismatch`. A refused update changes nothing.
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
        /// Update a template by ID or slug. Only provided fields are updated; a `pdf_format` replaces the stored format as a whole (missing fields take the defaults, nothing is merged). The slug never changes, even on a rename. Requires `full_access` API key scope.<br/>
        /// Errors: 400 `invalid_json`, `invalid_parameter`, `invalid_pdf_format`, `invalid_sample_data`, `component_not_found`, `component_type_mismatch`. A refused update changes nothing.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.Template>> UpdateTemplateAsResponseAsync(
            string id,

            global::PDF4Dev.UpdateTemplateRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a template<br/>
        /// Update a template by ID or slug. Only provided fields are updated; a `pdf_format` replaces the stored format as a whole (missing fields take the defaults, nothing is merged). The slug never changes, even on a rename. Requires `full_access` API key scope.<br/>
        /// Errors: 400 `invalid_json`, `invalid_parameter`, `invalid_pdf_format`, `invalid_sample_data`, `component_not_found`, `component_type_mismatch`. A refused update changes nothing.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// New name. The slug does not change.
        /// </param>
        /// <param name="html"></param>
        /// <param name="plainText"></param>
        /// <param name="pdfFormat">
        /// Replaces the stored format as a whole: missing fields take the defaults. `null` resets it to the default format.
        /// </param>
        /// <param name="sampleData">
        /// A JSON object, or `null` to clear it.
        /// </param>
        /// <param name="headerComponentId">
        /// A header component (comp_xxx) of your organization. The `&lt;pdf4-header&gt;` tag in `html` is what renders: setting an ID rewrites a tag that names another component, `null` (or an empty string) clears it and removes the tag, and when omitted the ID follows a tag in the `html` sent (`html` without one keeps the current ID, which still prints). An unknown ID or one of another organization answers 400 `component_not_found`, a component that is not a header 400 `component_type_mismatch`.
        /// </param>
        /// <param name="footerComponentId">
        /// A footer component (comp_xxx) of your organization. The `&lt;pdf4-footer&gt;` tag in `html` is what renders: setting an ID rewrites a tag that names another component, `null` (or an empty string) clears it and removes the tag, and when omitted the ID follows a tag in the `html` sent (`html` without one keeps the current ID, which still prints). An unknown ID or one of another organization answers 400 `component_not_found`, a component that is not a footer 400 `component_type_mismatch`.
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