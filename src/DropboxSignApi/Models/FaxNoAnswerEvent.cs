using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FaxNoAnswerEvent
{
    [JsonPropertyName("event")]
    public required Event Event { get; init; }

    /// <summary>
    /// Contains information about a signature request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transmission")]
    public SignatureRequestResponse? Transmission { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
