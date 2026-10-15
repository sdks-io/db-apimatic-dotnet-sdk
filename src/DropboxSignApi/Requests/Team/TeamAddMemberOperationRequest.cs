using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Team;

/// <summary>
/// The inputs of the TeamAddMember operation.
/// </summary>
public sealed record TeamAddMemberOperationRequest
{
    /// <summary>
    /// The id of the team.
    /// </summary>
    public string? TeamId { get; init; }

    public required TeamAddMemberRequest Body { get; init; }
}
