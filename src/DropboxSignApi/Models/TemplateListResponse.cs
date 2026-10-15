using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TemplateListResponse
{
    /// <summary>
    /// List of templates that the API caller has access to.
    /// </summary>
    [JsonPropertyName("templates")]
    public required IReadOnlyList<TemplateResponse> Templates { get; init; }

    /// <summary>
    /// Contains pagination information about the data returned.
    /// </summary>
    [JsonPropertyName("list_info")]
    public required ListInfoResponse ListInfo { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
