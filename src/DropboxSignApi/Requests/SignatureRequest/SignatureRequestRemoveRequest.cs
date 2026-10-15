namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestRemove operation.
/// </summary>
public sealed record SignatureRequestRemoveRequest
{
    /// <summary>
    /// The id of the SignatureRequest to remove.
    /// </summary>
    public required string SignatureRequestId { get; init; }
}
