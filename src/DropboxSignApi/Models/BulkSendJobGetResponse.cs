using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record BulkSendJobGetResponse
{
    /// <summary>
    /// Contains information about the BulkSendJob such as when it was created and how many signature requests are queued.
    /// </summary>
    [JsonPropertyName("bulk_send_job")]
    public required BulkSendJobResponse BulkSendJob { get; init; }

    /// <summary>
    /// Contains pagination information about the data returned.
    /// </summary>
    [JsonPropertyName("list_info")]
    public required ListInfoResponse ListInfo { get; init; }

    /// <summary>
    /// Contains information about the Signature Requests sent in bulk.
    /// </summary>
    [JsonPropertyName("signature_requests")]
    public required IReadOnlyList<BulkSendJobGetResponseSignatureRequests> SignatureRequests { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
