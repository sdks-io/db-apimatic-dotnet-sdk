using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.FaxLine;

/// <summary>
/// The inputs of the FaxLineRemoveUser operation.
/// </summary>
public sealed record FaxLineRemoveUserOperationRequest
{
    public required FaxLineRemoveUserRequest Body { get; init; }
}
