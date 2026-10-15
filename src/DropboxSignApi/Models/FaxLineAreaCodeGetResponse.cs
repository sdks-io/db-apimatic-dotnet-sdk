using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FaxLineAreaCodeGetResponse
{
    [JsonPropertyName("area_codes")]
    public required IReadOnlyList<int> AreaCodes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
