using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains information about your team and its members
/// </summary>
public record TeamResponse
{
    /// <summary>
    /// The name of your Team
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<AccountResponse>? Accounts { get; init; }

    /// <summary>
    /// A list of all Accounts that have an outstanding invitation to join your Team. Note that this response is a subset of the response parameters found in <c>GET /account</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invited_accounts")]
    public IReadOnlyList<AccountResponse>? InvitedAccounts { get; init; }

    /// <summary>
    /// A list of email addresses that have an outstanding invitation to join your Team and do not yet have a Dropbox Sign account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invited_emails")]
    public IReadOnlyList<string>? InvitedEmails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
