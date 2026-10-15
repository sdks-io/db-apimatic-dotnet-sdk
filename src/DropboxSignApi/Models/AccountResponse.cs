using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record AccountResponse
{
    /// <summary>
    /// The ID of the Account
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
    /// Details concerning remaining monthly quotas.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quotas")]
    public AccountResponseQuotas? Quotas { get; init; }

    /// <summary>
    /// The URL that Dropbox Sign events will <c>POST</c> to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback_url")]
    public string? CallbackUrl { get; init; }

    /// <summary>
    /// The membership role for the team.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("role_code")]
    public string? RoleCode { get; init; }

    /// <summary>
    /// The id of the team account belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_id")]
    public string? TeamId { get; init; }

    /// <summary>
    /// The locale used in this Account. Check out the list of <see href="/api/reference/constants/#supported-locales">supported locales</see> to learn more about the possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// Details concerning monthly usage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage")]
    public AccountResponseUsage? Usage { get; init; }

    /// <summary>
    /// Subset of configured settings
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public AccountResponseSettings? Settings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
