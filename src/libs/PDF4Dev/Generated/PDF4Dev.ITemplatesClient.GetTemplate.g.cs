#nullable enable

namespace PDF4Dev
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get a template<br/>
        /// Retrieve a single template by ID or slug. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Template> GetTemplateAsync(
            string id,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a template<br/>
        /// Retrieve a single template by ID or slug. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.Template>> GetTemplateAsResponseAsync(
            string id,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}