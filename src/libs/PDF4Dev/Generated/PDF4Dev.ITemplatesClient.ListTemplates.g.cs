#nullable enable

namespace PDF4Dev
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List templates<br/>
        /// Returns all templates belonging to the authenticated user. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::PDF4Dev.Template>> ListTemplatesAsync(
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}