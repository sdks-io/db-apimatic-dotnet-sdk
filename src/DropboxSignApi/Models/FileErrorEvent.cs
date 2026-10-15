using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FileErrorEvent
{
    [JsonPropertyName("event")]
    public required Event Event { get; init; }

    /// <summary>
    /// Contains information about a signature request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature_request")]
    public SignatureRequestResponse? SignatureRequest { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
