using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record BulkSendJobSendResponse
{
    /// <summary>
    /// Contains information about the BulkSendJob such as when it was created and how many signature requests are queued.
    /// </summary>
    [JsonPropertyName("bulk_send_job")]
    public required BulkSendJobResponse BulkSendJob { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
