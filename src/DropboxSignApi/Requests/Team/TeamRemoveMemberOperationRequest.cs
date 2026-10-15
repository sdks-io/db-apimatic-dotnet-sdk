using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Team;

/// <summary>
/// The inputs of the TeamRemoveMember operation.
/// </summary>
public sealed record TeamRemoveMemberOperationRequest
{
    public required TeamRemoveMemberRequest Body { get; init; }
}
