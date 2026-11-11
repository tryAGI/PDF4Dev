#nullable enable

namespace PDF4Dev
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Delete account<br/>
        /// Permanently delete the user account. Teams where the user is the only member are deleted with their data (templates, components, API keys, logs). In a team shared with others, what the user created is handed to the oldest other admin (else the oldest other member) and the team keeps it. This action cannot be undone. Session auth only.<br/>
        /// Errors: 409 `last_admin` when the user is the last admin of a team that has other members (nothing is deleted: make another member an admin first); 500 `deletion_failed`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.DeleteAccountResponse> DeleteAccountAsync(
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete account<br/>
        /// Permanently delete the user account. Teams where the user is the only member are deleted with their data (templates, components, API keys, logs). In a team shared with others, what the user created is handed to the oldest other admin (else the oldest other member) and the team keeps it. This action cannot be undone. Session auth only.<br/>
        /// Errors: 409 `last_admin` when the user is the last admin of a team that has other members (nothing is deleted: make another member an admin first); 500 `deletion_failed`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.DeleteAccountResponse>> DeleteAccountAsResponseAsync(
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}