using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TemplateErrorEvent
{
    [JsonPropertyName("event")]
    public required Event Event { get; init; }

    /// <summary>
    /// Contains information about the templates you and your team have created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("template")]
    public TemplateResponse? Template { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
