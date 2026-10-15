using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.FaxLine;

/// <summary>
/// The inputs of the FaxLineAddUser operation.
/// </summary>
public sealed record FaxLineAddUserOperationRequest
{
    public required FaxLineAddUserRequest Body { get; init; }
}
