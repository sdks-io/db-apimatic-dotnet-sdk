namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestCancel operation.
/// </summary>
public sealed record SignatureRequestCancelRequest
{
    /// <summary>
    /// The id of the incomplete SignatureRequest to cancel.
    /// </summary>
    public required string SignatureRequestId { get; init; }
}
