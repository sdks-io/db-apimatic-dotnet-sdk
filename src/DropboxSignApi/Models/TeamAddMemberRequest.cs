using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record TeamAddMemberRequest
{
    /// <summary>
    /// <c>account_id</c> or <c>email_address</c> is required. If both are provided, the account id prevails.
    /// <para>
    /// Account id of the user to invite to your Team.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// <c>account_id</c> or <c>email_address</c> is required, If both are provided, the account id prevails.
    /// <para>
    /// Email address of the user to invite to your Team.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// A role member will take in a new Team.
    /// <para>
    /// <b>NOTE:</b> This parameter is used only if <c>team_id</c> is provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("role")]
    public Role? Role { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
