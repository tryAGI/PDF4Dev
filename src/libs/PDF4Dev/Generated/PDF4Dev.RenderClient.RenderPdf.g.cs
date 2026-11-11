
#nullable enable

namespace PDF4Dev
{
    public partial class RenderClient
    {


        private static readonly global::PDF4Dev.EndPointSecurityRequirement s_RenderPdfSecurityRequirement0 =
            new global::PDF4Dev.EndPointSecurityRequirement
            {
                Authorizations = new global::PDF4Dev.EndPointAuthorizationRequirement[]
                {                    new global::PDF4Dev.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::PDF4Dev.EndPointSecurityRequirement[] s_RenderPdfSecurityRequirements =
            new global::PDF4Dev.EndPointSecurityRequirement[]
            {                s_RenderPdfSecurityRequirement0,
            };
        partial void PrepareRenderPdfArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::PDF4Dev.RenderRequest request);
        partial void PrepareRenderPdfRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::PDF4Dev.RenderRequest request);
        partial void ProcessRenderPdfResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRenderPdfResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).<br/>
        /// Errors: 400 `invalid_json` (the body is not a JSON object), `invalid_data` (`data` is not an object), `invalid_format` (a `format` margin, or custom width or height, that cannot be read), `template_syntax_error` and `template_runtime_error` (the message names the template, header, footer or block that failed); 413 `request_too_large` for a body over 10 MB, refused before it is read; 422 `render_timeout` when the render takes longer than 60 seconds. With `delivery: "url"`: 413 `render_too_large` for a PDF over the URL-delivery size (base64 delivery takes it), 507 `render_storage_full` with `Retry-After` when stored renders are at their limit, 500 `storage_failed`. A failed render or URL delivery is logged as a failure, with its template and duration; a bad body is not logged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>> RenderPdfAsync(

            global::PDF4Dev.RenderRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RenderPdfAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).<br/>
        /// Errors: 400 `invalid_json` (the body is not a JSON object), `invalid_data` (`data` is not an object), `invalid_format` (a `format` margin, or custom width or height, that cannot be read), `template_syntax_error` and `template_runtime_error` (the message names the template, header, footer or block that failed); 413 `request_too_large` for a body over 10 MB, refused before it is read; 422 `render_timeout` when the render takes longer than 60 seconds. With `delivery: "url"`: 413 `render_too_large` for a PDF over the URL-delivery size (base64 delivery takes it), 507 `render_storage_full` with `Retry-After` when stored renders are at their limit, 500 `storage_failed`. A failed render or URL delivery is logged as a failure, with its template and duration; a bad body is not logged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PDF4Dev.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>>> RenderPdfAsResponseAsync(

            global::PDF4Dev.RenderRequest request,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRenderPdfArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::PDF4Dev.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RenderPdfSecurityRequirements,
                operationName: "RenderPdfAsync");

            using var __timeoutCancellationTokenSource = global::PDF4Dev.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::PDF4Dev.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::PDF4Dev.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::PDF4Dev.PathBuilder(
                                path: "/api/v1/render",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::PDF4Dev.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "application/json");

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::PDF4Dev.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareRenderPdfRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::PDF4Dev.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::PDF4Dev.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RenderPdf",
                                methodName: "RenderPdfAsync",
                                pathTemplate: "\"/api/v1/render\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::PDF4Dev.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::PDF4Dev.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::PDF4Dev.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RenderPdf",
                                methodName: "RenderPdfAsync",
                                pathTemplate: "\"/api/v1/render\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::PDF4Dev.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::PDF4Dev.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::PDF4Dev.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::PDF4Dev.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::PDF4Dev.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RenderPdf",
                                methodName: "RenderPdfAsync",
                                pathTemplate: "\"/api/v1/render\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::PDF4Dev.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessRenderPdfResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::PDF4Dev.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::PDF4Dev.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RenderPdf",
                                methodName: "RenderPdfAsync",
                                pathTemplate: "\"/api/v1/render\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::PDF4Dev.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::PDF4Dev.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RenderPdf",
                                methodName: "RenderPdfAsync",
                                pathTemplate: "\"/api/v1/render\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad request: the body is not a JSON object (`invalid_json`), or a parameter is missing (`missing_parameter`) or invalid (`invalid_parameter`, `invalid_pdf_format`, `invalid_sample_data`, `component_not_found`, `component_type_mismatch`). The message names the field.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::PDF4Dev.ApiError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::PDF4Dev.ApiError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::PDF4Dev.ApiError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::PDF4Dev.ApiException<global::PDF4Dev.ApiError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized: missing or invalid API key
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::PDF4Dev.ApiError? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::PDF4Dev.ApiError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::PDF4Dev.ApiError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::PDF4Dev.ApiException<global::PDF4Dev.ApiError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Resource not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::PDF4Dev.ApiError? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::PDF4Dev.ApiError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::PDF4Dev.ApiError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::PDF4Dev.ApiException<global::PDF4Dev.ApiError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The request body is over 10 MB (`request_too_large`), or, with `delivery: "url"`, the PDF is over the URL-delivery size (`render_too_large`): use base64 delivery.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::PDF4Dev.ApiError? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::PDF4Dev.ApiError.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::PDF4Dev.ApiError.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::PDF4Dev.ApiException<global::PDF4Dev.ApiError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The render did not finish within 60 seconds (`render_timeout`).
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::PDF4Dev.ApiError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::PDF4Dev.ApiError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::PDF4Dev.ApiError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::PDF4Dev.ApiException<global::PDF4Dev.ApiError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // With `delivery: "url"`: stored renders are at their limit (`render_storage_full`). Retry after the `Retry-After` seconds, or use base64 delivery.
                            if ((int)__response.StatusCode == 507)
                            {
                                string? __content_507 = null;
                                global::System.Exception? __exception_507 = null;
                                global::PDF4Dev.ApiError? __value_507 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_507 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_507 = global::PDF4Dev.ApiError.FromJson(__content_507, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_507 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_507 = global::PDF4Dev.ApiError.FromJson(__content_507, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_507 = __ex;
                                }


                                throw global::PDF4Dev.ApiException<global::PDF4Dev.ApiError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_507 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_507,
                                    responseBody: __content_507,
                                    responseObject: __value_507,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessRenderPdfResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::PDF4Dev.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::PDF4Dev.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::PDF4Dev.AutoSDKHttpResponse<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::PDF4Dev.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::PDF4Dev.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Generate a PDF<br/>
        /// Render a PDF from a saved template or raw HTML. Pass `template_id` to use a saved template, or `html` for one-off renders. Variables in `{{handlebars}}` syntax are replaced with values from `data`. Returns the PDF as binary data (`application/pdf`).<br/>
        /// Errors: 400 `invalid_json` (the body is not a JSON object), `invalid_data` (`data` is not an object), `invalid_format` (a `format` margin, or custom width or height, that cannot be read), `template_syntax_error` and `template_runtime_error` (the message names the template, header, footer or block that failed); 413 `request_too_large` for a body over 10 MB, refused before it is read; 422 `render_timeout` when the render takes longer than 60 seconds. With `delivery: "url"`: 413 `render_too_large` for a PDF over the URL-delivery size (base64 delivery takes it), 507 `render_storage_full` with `Retry-After` when stored renders are at their limit, 500 `storage_failed`. A failed render or URL delivery is logged as a failure, with its template and duration; a bad body is not logged.
        /// </summary>
        /// <param name="templateId">
        /// Template ID (`tmpl_xxx`) or slug. The template must belong to the authenticated user. `null` reads as omitted.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="html">
        /// Raw HTML string. Supports Handlebars `{{variables}}` syntax. Use this for one-off renders without saving a template. `null` reads as omitted.<br/>
        /// Example: &lt;h1&gt;Hello {{name}}&lt;/h1&gt;
        /// </param>
        /// <param name="data">
        /// Data to replace `{{variables}}` in the template. A JSON object: `null`, `""`, `false` and `0` read as omitted, anything else answers 400 `invalid_data`. Supports strings, numbers, booleans, nested objects, and arrays (for `{{#each}}` blocks).<br/>
        /// Example: {"name":"World","company":"Acme Corp"}
        /// </param>
        /// <param name="format">
        /// Page format for this render. It replaces the template's format as a whole: missing fields take the defaults (A4 portrait, 20mm top/bottom and 15mm left/right margins), they are not read from the template. It prints as renders always have: an unknown preset prints a4, an unknown alignment or footer position is ignored, and a `margins` object prints a side it leaves out at 0 (the default margins apply only when `margins` is left out). `null`, `""`, `false` and `0` read as omitted. Only a margin (or a custom width or height) that cannot be read answers 400 `invalid_format`.
        /// </param>
        /// <param name="delivery">
        /// How to return the PDF. Omit for a binary `application/pdf` body (the default). `base64` returns JSON with the bytes inline. `url` stores the render and returns a signed URL valid for 24 hours, which is the recommended path for PDFs over 1 MB and for AI agents that cannot hold binary in context. An organization keeps at most 200 stored renders (500 MiB) by default; past that its oldest are deleted first, so a URL can stop working sooner. After expiry the URL answers 404 `render_expired`.<br/>
        /// Example: url
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::PDF4Dev.OneOf<global::PDF4Dev.RenderUrlResponse, global::PDF4Dev.RenderBase64Response>> RenderPdfAsync(
            string? templateId = default,
            string? html = default,
            object? data = default,
            global::PDF4Dev.PdfFormat? format = default,
            global::PDF4Dev.RenderRequestDelivery? delivery = default,
            global::PDF4Dev.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::PDF4Dev.RenderRequest
            {
                TemplateId = templateId,
                Html = html,
                Data = data,
                Format = format,
                Delivery = delivery,
            };

            return await RenderPdfAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}