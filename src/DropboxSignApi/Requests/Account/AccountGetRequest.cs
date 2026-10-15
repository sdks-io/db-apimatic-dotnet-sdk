namespace DropboxSignApi.Requests.Account;

/// <summary>
/// The inputs of the AccountGet operation.
/// </summary>
public sealed record AccountGetRequest
{
    /// <summary>
    /// <c>account_id</c> or <c>email_address</c> is required. If both are provided, the account id prevails.
    /// <para>
    /// The ID of the Account.
    /// </para>
    /// </summary>
    public string? AccountId { get; init; }

    /// <summary>
    /// <c>account_id</c> or <c>email_address</c> is required, If both are provided, the account id prevails.
    /// <para>
    /// The email address of the Account.
    /// </para>
    /// </summary>
    public string? EmailAddress { get; init; }
}
