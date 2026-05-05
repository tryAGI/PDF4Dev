#nullable enable

namespace PDF4Dev
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Delete a template<br/>
        /// Permanently delete a template. This action cannot be undone. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.DeleteTemplateResponse> DeleteTemplateAsync(
            string id,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a template<br/>
        /// Permanently delete a template. This action cannot be undone. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.DeleteTemplateResponse>> DeleteTemplateAsResponseAsync(
            string id,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}