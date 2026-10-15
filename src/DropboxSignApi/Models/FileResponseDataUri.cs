using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FileResponseDataUri
{
    /// <summary>
    /// File as base64 encoded string.
    /// </summary>
    [JsonPropertyName("data_uri")]
    public required string DataUri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
