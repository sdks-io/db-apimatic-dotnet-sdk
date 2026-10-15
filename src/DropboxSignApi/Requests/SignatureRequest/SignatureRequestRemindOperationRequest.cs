using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestRemind operation.
/// </summary>
public sealed record SignatureRequestRemindOperationRequest
{
    /// <summary>
    /// The id of the SignatureRequest to send a reminder for.
    /// </summary>
    public required string SignatureRequestId { get; init; }

    public required SignatureRequestRemindRequest Body { get; init; }
}
