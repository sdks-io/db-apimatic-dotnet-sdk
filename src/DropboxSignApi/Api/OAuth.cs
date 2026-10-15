using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DropboxSignApi.Core;
using DropboxSignApi.Core.Exceptions;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Request;
using DropboxSignApi.Core.Response;
using DropboxSignApi.Errors;
using DropboxSignApi.Models;
using DropboxSignApi.Requests.OAuth;

namespace DropboxSignApi.Api;

public sealed class OAuth
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal OAuth(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// OAuth Token Generate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OAuthTokenResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="OauthTokenGenerateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.
    /// </remarks>
    public Task<OAuthTokenResponse> OauthTokenGenerate(OauthTokenGenerateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth/token"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OAuthTokenResponse>(),
            OauthTokenGenerateError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// OAuth Token Refresh
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OAuthTokenResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="OauthTokenRefreshError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see <c>expires_in</c>), along with a refresh token that can be used to acquire a new access token after the current one has expired.
    /// </remarks>
    public Task<OAuthTokenResponse> OauthTokenRefresh(OauthTokenRefreshOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth/token?refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OAuthTokenResponse>(),
            OauthTokenRefreshError.Response,
            [],
            requestOptions,
            cancellationToken);
}
