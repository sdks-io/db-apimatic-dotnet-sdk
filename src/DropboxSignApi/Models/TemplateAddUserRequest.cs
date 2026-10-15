using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record TemplateAddUserRequest
{
    /// <summary>
    /// The id of the Account to give access to the Template.
    /// <b>NOTE:</b> The account id prevails if email address is also provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// The email address of the Account to give access to the Template.
    /// <b>NOTE:</b> The account id prevails if it is also provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// If set to <c>true</c>, the user does not receive an email notification when a template has been shared with them. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_notification")]
    public bool? SkipNotification { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
