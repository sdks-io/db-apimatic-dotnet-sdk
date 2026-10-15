using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.OAuth;

/// <summary>
/// The inputs of the OauthTokenRefresh operation.
/// </summary>
public sealed record OauthTokenRefreshOperationRequest
{
    public required OAuthTokenRefreshRequest Body { get; init; }
}
