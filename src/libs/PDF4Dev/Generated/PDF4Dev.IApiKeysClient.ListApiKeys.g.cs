#nullable enable

namespace PDF4Dev
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List API keys<br/>
        /// Returns all API keys for the authenticated user. Only key prefix is shown, not the full token. Session auth only.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::PDF4Dev.ApiKey>> ListApiKeysAsync(
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}