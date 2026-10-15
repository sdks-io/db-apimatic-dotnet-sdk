using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains template id
/// </summary>
public record TemplateUpdateFilesResponseTemplate
{
    /// <summary>
    /// The id of the Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("template_id")]
    public string? TemplateId { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
