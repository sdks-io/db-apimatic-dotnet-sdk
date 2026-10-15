using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Signer attachments.
/// </summary>
public record SignatureRequestResponseAttachment
{
    /// <summary>
    /// The unique ID for this attachment.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The Signer this attachment is assigned to.
    /// </summary>
    [JsonPropertyName("signer")]
    public required string Signer { get; init; }

    /// <summary>
    /// The name of this attachment.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A boolean value denoting if this attachment is required.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    /// <summary>
    /// Instructions for Signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instructions")]
    public string? Instructions { get; init; }

    /// <summary>
    /// Timestamp when attachment was uploaded by Signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uploaded_at")]
    public int? UploadedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
