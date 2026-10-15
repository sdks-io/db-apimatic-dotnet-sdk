using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record SignatureRequestUpdateRequest
{
    /// <summary>
    /// The new email address for the recipient.
    /// <para>
    /// This will generate a new <c>signature_id</c> value.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> Optional if <c>name</c> is provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The new name for the recipient.
    /// <para>
    /// <b>NOTE:</b> Optional if <c>email_address</c> is provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The signature ID for the recipient.
    /// </summary>
    [JsonPropertyName("signature_id")]
    public required string SignatureId { get; init; }

    /// <summary>
    /// The new time when the signature request will expire. Unsigned signatures will be moved to the expired status, and no longer signable. See <see href="https://developers.hellosign.com/docs/signature-request/expiration/">Signature Request Expiration Date</see> for details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public int? ExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
