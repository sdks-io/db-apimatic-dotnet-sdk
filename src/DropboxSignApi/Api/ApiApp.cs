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
using DropboxSignApi.Requests.ApiApp;

namespace DropboxSignApi.Api;

public sealed class ApiApp
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiApp(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create API App
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ApiAppCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new API App.
    /// </remarks>
    public Task<ApiAppGetResponse> ApiAppCreate(ApiAppCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api_app"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("domains", request.Domains),
                new MultipartParam("name", request.Name),
                new MultipartParam("callback_url", request.CallbackUrl),
                new MultipartParam("custom_logo_file", request.CustomLogoFile),
                new MultipartParam("oauth", request.Oauth),
                new MultipartParam("options", request.Options),
                new MultipartParam("white_labeling_options", request.WhiteLabelingOptions)),
            JsonResponse.Create<ApiAppGetResponse>(),
            ApiAppCreateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete API App
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ApiAppDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an API App. Can only be invoked for apps you own.
    /// </remarks>
    public Task ApiAppDelete(ApiAppDeleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api_app/{client_id}"),
            [new TemplateParam("client_id", request.ClientId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            ApiAppDeleteError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get API App
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ApiAppGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an object with information about an API App.
    /// </remarks>
    public Task<ApiAppGetResponse> ApiAppGet(ApiAppGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api_app/{client_id}"),
            [new TemplateParam("client_id", request.ClientId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiAppGetResponse>(),
            ApiAppGetError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List API Apps
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ApiAppListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of API Apps that are accessible by you. If you are on a team with an Admin or Developer role, this list will include apps owned by teammates.
    /// </remarks>
    public Task<ApiAppListResponse> ApiAppList(ApiAppListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api_app/list"),
            [],
            [new Param("page", request.Page), new Param("page_size", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiAppListResponse>(),
            ApiAppListError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update API App
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ApiAppUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing API App. Can only be invoked for apps you own. Only the fields you provide will be updated. If you wish to clear an existing optional field, provide an empty string.
    /// </remarks>
    public Task<ApiAppGetResponse> ApiAppUpdate(ApiAppUpdateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api_app/{client_id}"),
            [new TemplateParam("client_id", request.ClientId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormRequest.Create(
                new MultipartParam("callback_url", request.CallbackUrl),
                new MultipartParam("custom_logo_file", request.CustomLogoFile),
                new MultipartParam("domains", request.Domains),
                new MultipartParam("name", request.Name),
                new MultipartParam("oauth", request.Oauth),
                new MultipartParam("options", request.Options),
                new MultipartParam("white_labeling_options", request.WhiteLabelingOptions)),
            JsonResponse.Create<ApiAppGetResponse>(),
            ApiAppUpdateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
