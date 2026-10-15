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
using DropboxSignApi.Requests.Embedded;

namespace DropboxSignApi.Api;

public sealed class Embedded
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Embedded(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Embedded Template Edit URL
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EmbeddedEditUrlResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EmbeddedEditUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an embedded object containing a template url that can be opened in an iFrame. Note that only templates created via the embedded template process are available to be edited with this endpoint.
    /// </remarks>
    public Task<EmbeddedEditUrlResponse> EmbeddedEditUrl(EmbeddedEditUrlOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/embedded/edit_url/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EmbeddedEditUrlResponse>(),
            EmbeddedEditUrlError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Embedded Sign URL
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EmbeddedSignUrlResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EmbeddedSignUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an embedded object containing a signature url that can be opened in an iFrame. Note that templates created via the embedded template process will only be accessible through the API.
    /// </remarks>
    public Task<EmbeddedSignUrlResponse> EmbeddedSignUrl(EmbeddedSignUrlRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/embedded/sign_url/{signature_id}"),
            [new TemplateParam("signature_id", request.SignatureId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EmbeddedSignUrlResponse>(),
            EmbeddedSignUrlError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
