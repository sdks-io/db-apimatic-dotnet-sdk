using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TemplateCreateEmbeddedDraftResponse
{
    /// <summary>
    /// Template object with parameters: <c>template_id</c>, <c>edit_url</c>, <c>expires_at</c>.
    /// </summary>
    [JsonPropertyName("template")]
    public required TemplateCreateEmbeddedDraftResponseTemplate Template { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
