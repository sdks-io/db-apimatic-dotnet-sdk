using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record SubUnclaimedDraftTemplateSigner
{
    /// <summary>
    /// Must match an existing role in chosen Template(s).
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; init; }

    /// <summary>
    /// The name of the signer filling the role of <c>role</c>.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The email address of the signer filling the role of <c>role</c>.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string EmailAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
