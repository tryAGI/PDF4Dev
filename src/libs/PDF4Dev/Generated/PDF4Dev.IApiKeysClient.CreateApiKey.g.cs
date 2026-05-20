#nullable enable

namespace PDF4Dev
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create an API key<br/>
        /// Create a new API key. The full token is returned only once in the response: store it securely. Session auth only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AllOf<global::PDF4Dev.ApiKey, global::PDF4Dev.CreateApiKeyResponse2>> CreateApiKeyAsync(

            global::PDF4Dev.CreateApiKeyRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an API key<br/>
        /// Create a new API key. The full token is returned only once in the response: store it securely. Session auth only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.AllOf<global::PDF4Dev.ApiKey, global::PDF4Dev.CreateApiKeyResponse2>>> CreateApiKeyAsResponseAsync(

            global::PDF4Dev.CreateApiKeyRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an API key<br/>
        /// Create a new API key. The full token is returned only once in the response: store it securely. Session auth only.
        /// </summary>
        /// <param name="name">
        /// Display name for the key<br/>
        /// Example: Production
        /// </param>
        /// <param name="permission">
        /// Permission scope. Defaults to full_access.<br/>
        /// Example: full_access
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AllOf<global::PDF4Dev.ApiKey, global::PDF4Dev.CreateApiKeyResponse2>> CreateApiKeyAsync(
            string name,
            global::PDF4Dev.CreateApiKeyRequestPermission? permission = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}