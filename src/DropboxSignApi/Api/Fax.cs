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
using DropboxSignApi.Requests.Fax;

namespace DropboxSignApi.Api;

public sealed class Fax
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Fax(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete Fax
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified Fax from the system
    /// </remarks>
    public Task FaxDelete(FaxDeleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax/{fax_id}"),
            [new TemplateParam("fax_id", request.FaxId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            FaxDeleteError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Download Fax Files
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxFilesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Downloads files associated with a Fax
    /// </remarks>
    public Task FaxFiles(FaxFilesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax/files/{fax_id}"),
            [new TemplateParam("fax_id", request.FaxId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            FaxFilesError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Fax
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a Fax
    /// </remarks>
    public Task<FaxGetResponse> FaxGet(FaxGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax/{fax_id}"),
            [new TemplateParam("fax_id", request.FaxId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FaxGetResponse>(),
            FaxGetError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Lists Faxes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns properties of multiple Faxes
    /// </remarks>
    public Task<FaxListResponse> FaxList(FaxListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax/list"),
            [],
            [new Param("page", request.Page), new Param("page_size", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FaxListResponse>(),
            FaxListError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Send Fax
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FaxGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FaxSendError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates and sends a new Fax with the submitted file(s)
    /// </remarks>
    public Task<FaxGetResponse> FaxSend(FaxSendOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fax/send"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("recipient", request.Recipient),
                new MultipartParam("sender", request.Sender),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("cover_page_to", request.CoverPageTo),
                new MultipartParam("cover_page_from", request.CoverPageFrom),
                new MultipartParam("cover_page_message", request.CoverPageMessage),
                new MultipartParam("title", request.Title)),
            JsonResponse.Create<FaxGetResponse>(),
            FaxSendError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);
}
