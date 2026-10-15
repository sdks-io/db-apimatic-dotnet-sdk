namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestReleaseHold operation.
/// </summary>
public sealed record SignatureRequestReleaseHoldRequest
{
    /// <summary>
    /// The id of the SignatureRequest to release.
    /// </summary>
    public required string SignatureRequestId { get; init; }
}
