using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record AccountVerifyRequest
{
    /// <summary>
    /// Email address to run the verification for.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string EmailAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
