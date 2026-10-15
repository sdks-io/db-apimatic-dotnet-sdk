namespace DropboxSignApi.Requests.Team;

/// <summary>
/// The inputs of the TeamInvites operation.
/// </summary>
public sealed record TeamInvitesRequest
{
    /// <summary>
    /// The email address for which to display the team invites.
    /// </summary>
    public string? EmailAddress { get; init; }
}
