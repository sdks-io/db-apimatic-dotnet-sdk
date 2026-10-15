using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record AccountVerifyResponseAccount
{
    /// <summary>
    /// The email address associated with the Account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
