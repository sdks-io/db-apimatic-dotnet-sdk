using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// An embedded template object.
/// </summary>
public record EmbeddedEditUrlResponseEmbedded
{
    /// <summary>
    /// A template url that can be opened in an iFrame.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edit_url")]
    public string? EditUrl { get; init; }

    /// <summary>
    /// The specific time that the the <c>edit_url</c> link expires, in epoch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public int? ExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
