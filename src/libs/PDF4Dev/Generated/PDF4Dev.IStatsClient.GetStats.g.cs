#nullable enable

namespace PDF4Dev
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Get usage statistics<br/>
        /// Returns aggregated usage statistics including template count, total renders, success rate, average duration, and total size. Optionally filter by time period. Session auth only.
        /// </summary>
        /// <param name="period"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.Stats> GetStatsAsync(
            global::PDF4Dev.GetStatsPeriod? period = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage statistics<br/>
        /// Returns aggregated usage statistics including template count, total renders, success rate, average duration, and total size. Optionally filter by time period. Session auth only.
        /// </summary>
        /// <param name="period"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.Stats>> GetStatsAsResponseAsync(
            global::PDF4Dev.GetStatsPeriod? period = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}