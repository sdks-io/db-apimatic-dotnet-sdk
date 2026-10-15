using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Team;

/// <summary>
/// The inputs of the TeamUpdate operation.
/// </summary>
public sealed record TeamUpdateOperationRequest
{
    public required TeamUpdateRequest Body { get; init; }
}
