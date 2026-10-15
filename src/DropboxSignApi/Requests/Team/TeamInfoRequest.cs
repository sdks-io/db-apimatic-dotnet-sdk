namespace DropboxSignApi.Requests.Team;

/// <summary>
/// The inputs of the TeamInfo operation.
/// </summary>
public sealed record TeamInfoRequest
{
    /// <summary>
    /// The id of the team.
    /// </summary>
    public string? TeamId { get; init; }
}
