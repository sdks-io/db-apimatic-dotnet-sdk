using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// An object that contains necessary information to set up embedded signing.
/// </summary>
public record EmbeddedSignUrlResponseEmbedded
{
    /// <summary>
    /// A signature url that can be opened in an iFrame.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sign_url")]
    public string? SignUrl { get; init; }

    /// <summary>
    /// The specific time that the the <c>sign_url</c> link expires, in epoch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public int? ExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
