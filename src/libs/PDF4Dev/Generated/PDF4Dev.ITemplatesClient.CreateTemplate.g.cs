#nullable enable

namespace PDF4Dev
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create a template<br/>
        /// Create a new template. The `name` is required and a URL-safe `slug` is generated from it, unique in the organization. Header and footer components can be set with `header_component_id` / `footer_component_id` or with `&lt;pdf4-header&gt;` / `&lt;pdf4-footer&gt;` tags in `html`: a tag alone sets the matching id. Requires `full_access` API key scope.<br/>
        /// Errors: 400 `invalid_json`, `missing_parameter` (no `name`), `invalid_parameter`, `invalid_pdf_format`, `invalid_sample_data`, `component_not_found`, `component_type_mismatch`.
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
        /// Create a new template. The `name` is required and a URL-safe `slug` is generated from it, unique in the organization. Header and footer components can be set with `header_component_id` / `footer_component_id` or with `&lt;pdf4-header&gt;` / `&lt;pdf4-footer&gt;` tags in `html`: a tag alone sets the matching id. Requires `full_access` API key scope.<br/>
        /// Errors: 400 `invalid_json`, `missing_parameter` (no `name`), `invalid_parameter`, `invalid_pdf_format`, `invalid_sample_data`, `component_not_found`, `component_type_mismatch`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.Template>> CreateTemplateAsResponseAsync(

            global::PDF4Dev.CreateTemplateRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a template<br/>
        /// Create a new template. The `name` is required and a URL-safe `slug` is generated from it, unique in the organization. Header and footer components can be set with `header_component_id` / `footer_component_id` or with `&lt;pdf4-header&gt;` / `&lt;pdf4-footer&gt;` tags in `html`: a tag alone sets the matching id. Requires `full_access` API key scope.<br/>
        /// Errors: 400 `invalid_json`, `missing_parameter` (no `name`), `invalid_parameter`, `invalid_pdf_format`, `invalid_sample_data`, `component_not_found`, `component_type_mismatch`.
        /// </summary>
        /// <param name="name">
        /// Template name. A slug is auto-generated from this.
        /// </param>
        /// <param name="html">
        /// HTML template content. Supports Handlebars `{{variables}}`.
        /// </param>
        /// <param name="plainText">
        /// Plain text version of the template
        /// </param>
        /// <param name="pdfFormat">
        /// Page format configuration. Every field is optional: `preset` defaults to `a4` and each missing margin side to 20mm (top, bottom) or 15mm (left, right). A format replaces the stored or template format as a whole, it is never merged with it. Margins, `width` and `height` take px, pt, pc, mm, cm or in, or a bare number of px; a number is stored as `"&lt;n&gt;px"`, an empty margin is 0. `component_gap` is CSS: any length unit (`em`, `rem`, `%` too) or `calc()`. Presets and alignments are case-insensitive. On a template write, an unknown preset, alignment or footer position, or a length that cannot be read, answers 400 `invalid_pdf_format`; a value sent back exactly as stored is kept. On a render, `format` prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, a number is accepted for a CSS value, and only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`. Unknown keys are ignored.
        /// </param>
        /// <param name="sampleData">
        /// Default sample values for preview. Must be a JSON object (an array answers 400 `invalid_sample_data`).
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
        global::System.Threading.Tasks.Task<global::PDF4Dev.Template> CreateTemplateAsync(
            string name,
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