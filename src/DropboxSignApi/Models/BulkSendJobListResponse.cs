using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record BulkSendJobListResponse
{
    /// <summary>
    /// Contains a list of BulkSendJobs that the API caller has access to.
    /// </summary>
    [JsonPropertyName("bulk_send_jobs")]
    public required IReadOnlyList<BulkSendJobResponse> BulkSendJobs { get; init; }

    /// <summary>
    /// Contains pagination information about the data returned.
    /// </summary>
    [JsonPropertyName("list_info")]
    public required ListInfoResponse ListInfo { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
