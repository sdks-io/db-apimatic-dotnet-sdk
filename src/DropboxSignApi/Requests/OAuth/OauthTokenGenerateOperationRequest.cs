using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.OAuth;

/// <summary>
/// The inputs of the OauthTokenGenerate operation.
/// </summary>
public sealed record OauthTokenGenerateOperationRequest
{
    public required OAuthTokenGenerateRequest Body { get; init; }
}
