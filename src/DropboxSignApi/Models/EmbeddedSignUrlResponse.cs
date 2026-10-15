using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record EmbeddedSignUrlResponse
{
    /// <summary>
    /// An object that contains necessary information to set up embedded signing.
    /// </summary>
    [JsonPropertyName("embedded")]
    public required EmbeddedSignUrlResponseEmbedded Embedded { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
