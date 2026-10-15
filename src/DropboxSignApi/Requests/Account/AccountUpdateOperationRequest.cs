using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Account;

/// <summary>
/// The inputs of the AccountUpdate operation.
/// </summary>
public sealed record AccountUpdateOperationRequest
{
    public required AccountUpdateRequest Body { get; init; }
}
