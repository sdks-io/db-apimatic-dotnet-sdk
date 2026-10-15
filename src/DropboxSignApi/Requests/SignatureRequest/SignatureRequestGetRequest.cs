namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestGet operation.
/// </summary>
public sealed record SignatureRequestGetRequest
{
    /// <summary>
    /// The id of the SignatureRequest to retrieve.
    /// </summary>
    public required string SignatureRequestId { get; init; }
}
