using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record SubCc
{
    /// <summary>
    /// Must match an existing CC role in chosen Template(s). Multiple CC recipients cannot share the same CC role.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; init; }

    /// <summary>
    /// The email address of the CC recipient.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string EmailAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
