#nullable enable

namespace PDF4Dev
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// List PDF generation logs<br/>
        /// Returns logs of all PDF generations with cursor-based pagination. Filter by status, template, or date range. Requires `full_access` API key scope.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="status"></param>
        /// <param name="templateId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.CursorPaginatedLogs> GetLogsAsync(
            int? limit = default,
            string? cursor = default,
            global::PDF4Dev.GetLogsStatus? status = default,
            string? templateId = default,
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}