using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestUpdate operation.
/// </summary>
public sealed record SignatureRequestUpdateOperationRequest
{
    /// <summary>
    /// The id of the SignatureRequest to update.
    /// </summary>
    public required string SignatureRequestId { get; init; }

    public required SignatureRequestUpdateRequest Body { get; init; }
}
