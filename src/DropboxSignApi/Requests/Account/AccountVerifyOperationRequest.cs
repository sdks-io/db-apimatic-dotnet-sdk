using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Account;

/// <summary>
/// The inputs of the AccountVerify operation.
/// </summary>
public sealed record AccountVerifyOperationRequest
{
    public required AccountVerifyRequest Body { get; init; }
}
