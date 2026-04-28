#nullable enable

namespace PDF4Dev
{
    public partial interface IComponentsClient
    {
        /// <summary>
        /// List components<br/>
        /// Returns all components (headers, footers, blocks). Use header/footer IDs in templates for repeating page elements. Block components are referenced via &lt;pdf4-block&gt; tags in template HTML. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::PDF4Dev.Component>> ListComponentsAsync(
            global::PDF4Dev.ListComponentsType? type = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}