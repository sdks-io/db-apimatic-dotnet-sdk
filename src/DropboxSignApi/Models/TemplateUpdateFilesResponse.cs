using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TemplateUpdateFilesResponse
{
    /// <summary>
    /// Contains template id
    /// </summary>
    [JsonPropertyName("template")]
    public required TemplateUpdateFilesResponseTemplate Template { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
