using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record SubAttachment
{
    /// <summary>
    /// The instructions for uploading the attachment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instructions")]
    public string? Instructions { get; init; }

    /// <summary>
    /// The name of attachment.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Determines if the attachment must be uploaded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("required")]
    public bool? Required { get; init; } = false;

    /// <summary>
    /// The signer's index in the <c>signers</c> parameter (0-based indexing).
    /// <para>
    /// <b>NOTE:</b> Only one signer can be assigned per attachment.
    /// </para>
    /// </summary>
    [JsonPropertyName("signer_index")]
    public required int SignerIndex { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
