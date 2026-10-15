using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Specific metadata about the event.
/// </summary>
public record EventCallbackRequestEventMetadata
{
    /// <summary>
    /// Signature ID for a specific signer. Applicable to <c>signature_request_signed</c> and <c>signature_request_viewed</c> events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("related_signature_id")]
    public string? RelatedSignatureId { get; init; }

    /// <summary>
    /// Account ID the event was reported for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reported_for_account_id")]
    public string? ReportedForAccountId { get; init; }

    /// <summary>
    /// App ID the event was reported for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reported_for_app_id")]
    public string? ReportedForAppId { get; init; }

    /// <summary>
    /// Message about a declined or failed (due to error) signature flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_message")]
    public string? EventMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
