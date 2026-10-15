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
using DropboxSignApi.Requests.FaxLine;

namespace DropboxSignApi.Api;

public sealed class FaxLine
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FaxLine(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add Fax Line User
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxLineResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxLineAddUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Grants a user access to the specified Fax Line.
    /// </remarks>
    public Task<FaxLineResponse> FaxLineAddUser(FaxLineAddUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax_line/add_user"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FaxLineResponse>(),
            FaxLineAddUserError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Available Fax Line Area Codes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxLineAreaCodeGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxLineAreaCodeGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of available area codes for a given state/province and city
    /// </remarks>
    public Task<FaxLineAreaCodeGetResponse> FaxLineAreaCodeGet(FaxLineAreaCodeGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax_line/area_codes"),
            [],
            [
                new Param("country", request.Country),
                new Param("state", request.State),
                new Param("province", request.Province),
                new Param("city", request.City),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FaxLineAreaCodeGetResponse>(),
            FaxLineAreaCodeGetError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Purchase Fax Line
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxLineResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxLineCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Purchases a new Fax Line
    /// </remarks>
    public Task<FaxLineResponse> FaxLineCreate(FaxLineCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax_line/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FaxLineResponse>(),
            FaxLineCreateError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete Fax Line
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxLineDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified Fax Line from the subscription.
    /// </remarks>
    public Task<object> FaxLineDelete(FaxLineDeleteOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax_line"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<object>(),
            FaxLineDeleteError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Fax Line
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxLineResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxLineGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the properties and settings of a Fax Line.
    /// </remarks>
    public Task<FaxLineResponse> FaxLineGet(FaxLineGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax_line"),
            [],
            [new Param("number", request.Number)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FaxLineResponse>(),
            FaxLineGetError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Fax Lines
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxLineListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxLineListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the properties and settings of multiple Fax Lines.
    /// </remarks>
    public Task<FaxLineListResponse> FaxLineList(FaxLineListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax_line/list"),
            [],
            [
                new Param("account_id", request.AccountId),
                new Param("page", request.Page),
                new Param("page_size", request.PageSize),
                new Param("show_team_lines", request.ShowTeamLines),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FaxLineListResponse>(),
            FaxLineListError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove Fax Line Access
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxLineResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxLineRemoveUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a user's access to the specified Fax Line
    /// </remarks>
    public Task<FaxLineResponse> FaxLineRemoveUser(FaxLineRemoveUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax_line/remove_user"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FaxLineResponse>(),
            FaxLineRemoveUserError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);
}
