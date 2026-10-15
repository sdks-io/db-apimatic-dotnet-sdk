using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TemplateResponseAccount
{
    /// <summary>
    /// The id of the Account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// The email address associated with the Account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// Returns <c>true</c> if the user has been locked out of their account by a team admin.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_locked")]
    public bool? IsLocked { get; init; }

    /// <summary>
    /// Returns <c>true</c> if the user has a paid Dropbox Sign account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_paid_hs")]
    public bool? IsPaidHs { get; init; }

    /// <summary>
    /// Returns <c>true</c> if the user has a paid HelloFax account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_paid_hf")]
    public bool? IsPaidHf { get; init; }

    /// <summary>
    /// An array of the designated CC roles that must be specified when sending a SignatureRequest using this Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quotas")]
    public TemplateResponseAccountQuota? Quotas { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
