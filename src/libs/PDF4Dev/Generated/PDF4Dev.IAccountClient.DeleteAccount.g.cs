#nullable enable

namespace PDF4Dev
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Delete account<br/>
        /// Permanently delete the user account and all associated data (templates, API keys, logs). This action cannot be undone. Session auth only.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.DeleteAccountResponse> DeleteAccountAsync(
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}