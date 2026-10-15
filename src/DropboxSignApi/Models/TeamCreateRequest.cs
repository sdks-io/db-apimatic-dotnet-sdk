using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TeamCreateRequest
{
    /// <summary>
    /// The name of your Team.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; } = "Untitled Team";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
