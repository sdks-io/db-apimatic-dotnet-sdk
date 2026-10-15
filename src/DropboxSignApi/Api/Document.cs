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
using DropboxSignApi.Requests.Document;

namespace DropboxSignApi.Api;

public sealed class Document
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Document(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Detect Document Fields
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DocumentFieldDetectionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DocumentDetectFieldsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Detects form fields in a PDF document using either PDF form annotations or Dropbox Sign text tags.
    /// </remarks>
    public Task<DocumentFieldDetectionResponse> DocumentDetectFields(DocumentDetectFieldsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/document/detect_fields"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("detection_mode", request.DetectionMode),
                new MultipartParam("file", request.File),
                new MultipartParam("file_url", request.FileUrl),
                new MultipartParam("page_range", request.PageRange)),
            JsonResponse.Create<DocumentFieldDetectionResponse>(),
            DocumentDetectFieldsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
