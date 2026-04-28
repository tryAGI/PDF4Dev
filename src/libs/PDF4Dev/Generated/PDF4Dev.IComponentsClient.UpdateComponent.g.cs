#nullable enable

namespace PDF4Dev
{
    public partial interface IComponentsClient
    {
        /// <summary>
        /// Update a component<br/>
        /// Update a component's name or HTML. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Component> UpdateComponentAsync(
            string id,

            global::PDF4Dev.UpdateComponentRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a component<br/>
        /// Update a component's name or HTML. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Change component type. Headers repeat on every page (via &lt;thead&gt;), footers repeat on every page (via &lt;tfoot&gt;), blocks render inline.
        /// </param>
        /// <param name="html"></param>
        /// <param name="preview">
        /// Plain text preview (auto-generated from HTML if omitted)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Component> UpdateComponentAsync(
            string id,
            string? name = default,
            global::PDF4Dev.UpdateComponentRequestType? type = default,
            string? html = default,
            string? preview = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}