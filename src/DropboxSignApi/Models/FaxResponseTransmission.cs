using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record FaxResponseTransmission
{
    /// <summary>
    /// Fax Transmission Recipient
    /// </summary>
    [JsonPropertyName("recipient")]
    public required string Recipient { get; init; }

    /// <summary>
    /// Fax Transmission Status Code
    /// </summary>
    [JsonPropertyName("status_code")]
    public required StatusCode StatusCode { get; init; }

    /// <summary>
    /// Fax Transmission Sent Timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sent_at")]
    public int? SentAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
