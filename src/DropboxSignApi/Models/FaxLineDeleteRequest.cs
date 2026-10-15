using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FaxLineDeleteRequest
{
    /// <summary>
    /// The Fax Line number
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
