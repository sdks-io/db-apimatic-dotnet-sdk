using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Team;

/// <summary>
/// The inputs of the TeamCreate operation.
/// </summary>
public sealed record TeamCreateOperationRequest
{
    public required TeamCreateRequest Body { get; init; }
}
