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
using DropboxSignApi.Requests.BulkSendJob;

namespace DropboxSignApi.Api;

public sealed class BulkSendJob
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal BulkSendJob(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Bulk Send Job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkSendJobGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BulkSendJobGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the status of the BulkSendJob and its SignatureRequests specified by the <c>bulk_send_job_id</c> parameter.
    /// </remarks>
    public Task<BulkSendJobGetResponse> BulkSendJobGet(BulkSendJobGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/bulk_send_job/{bulk_send_job_id}"),
            [new TemplateParam("bulk_send_job_id", request.BulkSendJobId)],
            [new Param("page", request.Page), new Param("page_size", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BulkSendJobGetResponse>(),
            BulkSendJobGetError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Bulk Send Jobs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkSendJobListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BulkSendJobListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of BulkSendJob that you can access.
    /// </remarks>
    public Task<BulkSendJobListResponse> BulkSendJobList(BulkSendJobListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/bulk_send_job/list"),
            [],
            [new Param("page", request.Page), new Param("page_size", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BulkSendJobListResponse>(),
            BulkSendJobListError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
