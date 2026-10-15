using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Average text length in this field.
/// </summary>
public record TemplateResponseFieldAvgTextLength
{
    /// <summary>
    /// Number of lines.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_lines")]
    public int? NumLines { get; init; }

    /// <summary>
    /// Number of characters per line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_chars_per_line")]
    public int? NumCharsPerLine { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
