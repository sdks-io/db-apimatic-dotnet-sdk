using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.FaxLine;

/// <summary>
/// The inputs of the FaxLineCreate operation.
/// </summary>
public sealed record FaxLineCreateOperationRequest
{
    public required FaxLineCreateRequest Body { get; init; }
}
