namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestFilesAsDataUri operation.
/// </summary>
public sealed record SignatureRequestFilesAsDataUriRequest
{
    /// <summary>
    /// The id of the SignatureRequest to retrieve.
    /// </summary>
    public required string SignatureRequestId { get; init; }
}
