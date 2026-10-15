using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record ErrorResponseModel
{
    /// <summary>
    /// Contains information about an error that occurred.
    /// </summary>
    [JsonPropertyName("error")]
    public required ErrorResponseError Error { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
