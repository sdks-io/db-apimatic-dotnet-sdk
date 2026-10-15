using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.FaxLine;

/// <summary>
/// The inputs of the FaxLineDelete operation.
/// </summary>
public sealed record FaxLineDeleteOperationRequest
{
    public required FaxLineDeleteRequest Body { get; init; }
}
