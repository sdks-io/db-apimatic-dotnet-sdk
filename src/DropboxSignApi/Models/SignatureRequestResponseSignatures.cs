using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// An array of signature objects, 1 for each signer.
/// </summary>
public record SignatureRequestResponseSignatures
{
    /// <summary>
    /// Signature identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature_id")]
    public string? SignatureId { get; init; }

    /// <summary>
    /// Signer Group GUID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer_group_guid")]
    public string? SignerGroupGuid { get; init; }

    /// <summary>
    /// The email address of the signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer_email_address")]
    public string? SignerEmailAddress { get; init; }

    /// <summary>
    /// The name of the signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer_name")]
    public string? SignerName { get; init; }

    /// <summary>
    /// The role of the signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer_role")]
    public string? SignerRole { get; init; }

    /// <summary>
    /// If signer order is assigned this is the 0-based index for this signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public int? Order { get; init; }

    /// <summary>
    /// The current status of the signature. eg: awaiting_signature, signed, declined.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status_code")]
    public string? StatusCode { get; init; }

    /// <summary>
    /// The reason provided by the signer for declining the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decline_reason")]
    public string? DeclineReason { get; init; }

    /// <summary>
    /// Time that the document was signed or null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signed_at")]
    public int? SignedAt { get; init; }

    /// <summary>
    /// The time that the document was last viewed by this signer or null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_viewed_at")]
    public int? LastViewedAt { get; init; }

    /// <summary>
    /// The time the last reminder email was sent to the signer or null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_reminded_at")]
    public int? LastRemindedAt { get; init; }

    /// <summary>
    /// Boolean to indicate whether this signature requires a PIN to access.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_pin")]
    public bool? HasPin { get; init; }

    /// <summary>
    /// Boolean to indicate whether this signature has SMS authentication enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_sms_auth")]
    public bool? HasSmsAuth { get; init; }

    /// <summary>
    /// Boolean to indicate whether this signature has SMS delivery enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_sms_delivery")]
    public bool? HasSmsDelivery { get; init; }

    /// <summary>
    /// The SMS phone number used for authentication or signature request delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_phone_number")]
    public string? SmsPhoneNumber { get; init; }

    /// <summary>
    /// Email address of original signer who reassigned to this signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reassigned_by")]
    public string? ReassignedBy { get; init; }

    /// <summary>
    /// Reason provided by original signer who reassigned to this signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reassignment_reason")]
    public string? ReassignmentReason { get; init; }

    /// <summary>
    /// Previous signature identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reassigned_from")]
    public string? ReassignedFrom { get; init; }

    /// <summary>
    /// Error message pertaining to this signer, or null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public string? Error { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
