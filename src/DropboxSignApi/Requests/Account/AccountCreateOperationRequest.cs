using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Account;

/// <summary>
/// The inputs of the AccountCreate operation.
/// </summary>
public sealed record AccountCreateOperationRequest
{
    public required AccountCreateRequest Body { get; init; }
}
