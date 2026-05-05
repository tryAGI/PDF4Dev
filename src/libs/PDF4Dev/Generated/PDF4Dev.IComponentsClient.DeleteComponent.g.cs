#nullable enable

namespace PDF4Dev
{
    public partial interface IComponentsClient
    {
        /// <summary>
        /// Delete a component<br/>
        /// Permanently delete a component. Templates using it will no longer show it. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.DeleteComponentResponse> DeleteComponentAsync(
            string id,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a component<br/>
        /// Permanently delete a component. Templates using it will no longer show it. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.DeleteComponentResponse>> DeleteComponentAsResponseAsync(
            string id,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}