using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// Basic information about the event that occurred.
/// </summary>
public record EventCallbackRequestEvent
{
    /// <summary>
    /// Time the event was created (using Unix time).
    /// </summary>
    [JsonPropertyName("event_time")]
    public required string EventTime { get; init; }

    /// <summary>
    /// Type of callback event that was triggered.
    /// </summary>
    [JsonPropertyName("event_type")]
    public required EventType EventType { get; init; }

    /// <summary>
    /// Generated hash used to verify source of event data.
    /// </summary>
    [JsonPropertyName("event_hash")]
    public required string EventHash { get; init; }

    /// <summary>
    /// Specific metadata about the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_metadata")]
    public EventCallbackRequestEventMetadata? EventMetadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
