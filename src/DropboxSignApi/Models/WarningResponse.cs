using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// A list of warnings.
/// </summary>
public record WarningResponse
{
    /// <summary>
    /// Warning message
    /// </summary>
    [JsonPropertyName("warning_msg")]
    public required string WarningMsg { get; init; }

    /// <summary>
    /// Warning name
    /// </summary>
    [JsonPropertyName("warning_name")]
    public required string WarningName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
