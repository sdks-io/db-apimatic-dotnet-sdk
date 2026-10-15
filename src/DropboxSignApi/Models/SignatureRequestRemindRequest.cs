using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record SignatureRequestRemindRequest
{
    /// <summary>
    /// The email address of the signer to send a reminder to.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string EmailAddress { get; init; }

    /// <summary>
    /// The name of the signer to send a reminder to. Include if two or more signers share an email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
