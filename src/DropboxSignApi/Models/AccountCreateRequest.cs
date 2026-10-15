using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record AccountCreateRequest
{
    /// <summary>
    /// Used when creating a new account with OAuth authorization.
    /// <para>
    /// See <see href="https://app.hellosign.com/api/oauthWalkthrough#OAuthAuthorization">OAuth 2.0 Authorization</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Used when creating a new account with OAuth authorization.
    /// <para>
    /// See <see href="https://app.hellosign.com/api/oauthWalkthrough#OAuthAuthorization">OAuth 2.0 Authorization</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; init; }

    /// <summary>
    /// The email address which will be associated with the new Account.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string EmailAddress { get; init; }

    /// <summary>
    /// The locale used in this Account. Check out the list of <see href="/api/reference/constants/#supported-locales">supported locales</see> to learn more about the possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
