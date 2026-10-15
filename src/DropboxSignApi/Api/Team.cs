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
using DropboxSignApi.Requests.Team;

namespace DropboxSignApi.Api;

public sealed class Team
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Team(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add User to Team
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamAddMemberError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invites a user (specified using the <c>email_address</c> parameter) to your Team. If the user does not currently have a Dropbox Sign Account, a new one will be created for them. If a user is already a part of another Team, a <c>team_invite_failed</c> error will be returned.
    /// </remarks>
    public Task<TeamGetResponse> TeamAddMember(TeamAddMemberOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/add_member"),
            [],
            [new Param("team_id", request.TeamId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TeamGetResponse>(),
            TeamAddMemberError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create Team
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new Team and makes you a member. You must not currently belong to a Team to invoke.
    /// </remarks>
    public Task<TeamGetResponse> TeamCreate(TeamCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TeamGetResponse>(),
            TeamCreateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete Team
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes your Team. Can only be invoked when you have a Team with only one member (yourself).
    /// </remarks>
    public Task TeamDelete(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/destroy"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            TeamDeleteError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Team
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about your Team as well as a list of its members. If you do not belong to a Team, a 404 error with an error_name of "not_found" will be returned.
    /// </remarks>
    public Task<TeamGetResponse> TeamGet(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamGetResponse>(),
            TeamGetError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Team Info
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamGetInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamInfoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides information about a team.
    /// </remarks>
    public Task<TeamGetInfoResponse> TeamInfo(TeamInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/info"),
            [],
            [new Param("team_id", request.TeamId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamGetInfoResponse>(),
            TeamInfoError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Team Invites
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamInvitesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamInvitesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides a list of team invites (and their roles).
    /// </remarks>
    public Task<TeamInvitesResponse> TeamInvites(TeamInvitesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/invites"),
            [],
            [new Param("email_address", request.EmailAddress)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamInvitesResponse>(),
            TeamInvitesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Team Members
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamMembersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamMembersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides a paginated list of members (and their roles) that belong to a given team.
    /// </remarks>
    public Task<TeamMembersResponse> TeamMembers(TeamMembersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/members/{team_id}"),
            [new TemplateParam("team_id", request.TeamId)],
            [new Param("page", request.Page), new Param("page_size", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamMembersResponse>(),
            TeamMembersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove User from Team
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamRemoveMemberError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the provided user Account from your Team. If the Account had an outstanding invitation to your Team, the invitation will be expired. If you choose to transfer documents from the removed Account to an Account provided in the <c>new_owner_email_address</c> parameter (available only for Enterprise plans), the response status code will be 201, which indicates that your request has been queued but not fully executed.
    /// </remarks>
    public Task<TeamGetResponse> TeamRemoveMember(TeamRemoveMemberOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/remove_member"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TeamGetResponse>(),
            TeamRemoveMemberError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Sub Teams
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamSubTeamsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamSubTeamsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides a paginated list of sub teams that belong to a given team.
    /// </remarks>
    public Task<TeamSubTeamsResponse> TeamSubTeams(TeamSubTeamsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team/sub_teams/{team_id}"),
            [new TemplateParam("team_id", request.TeamId)],
            [new Param("page", request.Page), new Param("page_size", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamSubTeamsResponse>(),
            TeamSubTeamsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update Team
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TeamUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the name of your Team.
    /// </remarks>
    public Task<TeamGetResponse> TeamUpdate(TeamUpdateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/team"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TeamGetResponse>(),
            TeamUpdateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
