using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FileResponse
{
    /// <summary>
    /// URL to the file.
    /// </summary>
    [JsonPropertyName("file_url")]
    public required string FileUrl { get; init; }

    /// <summary>
    /// When the link expires.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public required int ExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
