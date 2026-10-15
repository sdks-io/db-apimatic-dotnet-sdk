using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DropboxSignApi.Core;
using DropboxSignApi.Core.Authentication;
using DropboxSignApi.Core.Exceptions;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Request;
using DropboxSignApi.Core.Response;
using DropboxSignApi.Errors;
using DropboxSignApi.Models;
using DropboxSignApi.Requests.Account;

namespace DropboxSignApi.Api;

public sealed class Account
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Account(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create Account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new Dropbox Sign Account that is associated with the specified <c>email_address</c>.
    /// </remarks>
    public Task<AccountCreateResponse> AccountCreate(AccountCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/account/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountCreateResponse>(),
            AccountCreateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the properties and settings of your Account.
    /// </remarks>
    public Task<AccountGetResponse> AccountGet(AccountGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/account"),
            [],
            [new Param("account_id", request.AccountId), new Param("email_address", request.EmailAddress)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountGetResponse>(),
            AccountGetError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update Account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the properties and settings of your Account. Currently only allows for updates to the <see href="/api/reference/tag/Callbacks-and-Events">Callback URL</see> and locale.
    /// </remarks>
    public Task<AccountGetResponse> AccountUpdate(AccountUpdateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/account"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountGetResponse>(),
            AccountUpdateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Verify Account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountVerifyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountVerifyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Verifies whether an Dropbox Sign Account exists for the given email address.
    /// </remarks>
    public Task<AccountVerifyResponse> AccountVerify(AccountVerifyOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/account/verify"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountVerifyResponse>(),
            AccountVerifyError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
