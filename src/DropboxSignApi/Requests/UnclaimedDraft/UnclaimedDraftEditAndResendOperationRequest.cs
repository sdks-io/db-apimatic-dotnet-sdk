using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.UnclaimedDraft;

/// <summary>
/// The inputs of the UnclaimedDraftEditAndResend operation.
/// </summary>
public sealed record UnclaimedDraftEditAndResendOperationRequest
{
    /// <summary>
    /// The ID of the signature request to edit and resend.
    /// </summary>
    public required string SignatureRequestId { get; init; }

    public required UnclaimedDraftEditAndResendRequest Body { get; init; }
}
