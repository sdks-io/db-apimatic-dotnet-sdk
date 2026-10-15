using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Details concerning monthly usage
/// </summary>
public record AccountResponseUsage
{
    /// <summary>
    /// Number of fax pages sent
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fax_pages_sent")]
    public int? FaxPagesSent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
