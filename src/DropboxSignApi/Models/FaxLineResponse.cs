using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FaxLineResponse
{
    [JsonPropertyName("fax_line")]
    public required FaxLineResponseFaxLine FaxLine { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public WarningResponse? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
