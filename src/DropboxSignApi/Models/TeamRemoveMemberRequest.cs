using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record TeamRemoveMemberRequest
{
    /// <summary>
    /// <b>account_id</b> or <b>email_address</b> is required. If both are provided, the account id prevails.
    /// <para>
    /// Account id to remove from your Team.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    /// <summary>
    /// <b>account_id</b> or <b>email_address</b> is required. If both are provided, the account id prevails.
    /// <para>
    /// Email address of the Account to remove from your Team.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The email address of an Account on this Team to receive all documents, templates, and API apps (if applicable) from the removed Account. If not provided, and on an Enterprise plan, this data will remain with the removed Account.
    /// <para>
    /// <b>NOTE:</b> Only available for Enterprise plans.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_owner_email_address")]
    [Format(FormatKind.Email)]
    public string? NewOwnerEmailAddress { get; init; }

    /// <summary>
    /// Id of the new Team.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_team_id")]
    public string? NewTeamId { get; init; }

    /// <summary>
    /// A new role member will take in a new Team.
    /// <para>
    /// <b>NOTE:</b> This parameter is used only if <c>new_team_id</c> is provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_role")]
    public NewRole? NewRole { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
