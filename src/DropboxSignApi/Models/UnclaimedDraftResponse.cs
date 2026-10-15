using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// A group of documents that a user can take ownership of via the claim URL.
/// </summary>
public record UnclaimedDraftResponse
{
    /// <summary>
    /// The ID of the signature request that is represented by this UnclaimedDraft.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature_request_id")]
    public string? SignatureRequestId { get; init; }

    /// <summary>
    /// The URL to be used to claim this UnclaimedDraft.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("claim_url")]
    public string? ClaimUrl { get; init; }

    /// <summary>
    /// The URL you want signers redirected to after they successfully sign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signing_redirect_url")]
    public string? SigningRedirectUrl { get; init; }

    /// <summary>
    /// The URL you want signers redirected to after they successfully request a signature (Will only be returned in the response if it is applicable to the request.).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requesting_redirect_url")]
    public string? RequestingRedirectUrl { get; init; }

    /// <summary>
    /// When the link expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public int? ExpiresAt { get; init; }

    /// <summary>
    /// Whether this is a test draft. Signature requests made from test drafts have no legal value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_mode")]
    public bool? TestMode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
