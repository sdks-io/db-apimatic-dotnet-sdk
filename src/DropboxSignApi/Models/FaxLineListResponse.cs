using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FaxLineListResponse
{
    /// <summary>
    /// Contains pagination information about the data returned.
    /// </summary>
    [JsonPropertyName("list_info")]
    public required ListInfoResponse ListInfo { get; init; }

    [JsonPropertyName("fax_lines")]
    public required IReadOnlyList<FaxLineResponseFaxLine> FaxLines { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public WarningResponse? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
