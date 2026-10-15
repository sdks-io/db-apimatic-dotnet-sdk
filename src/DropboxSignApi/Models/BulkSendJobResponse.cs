using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains information about the BulkSendJob such as when it was created and how many signature requests are queued.
/// </summary>
public record BulkSendJobResponse
{
    /// <summary>
    /// The id of the BulkSendJob.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bulk_send_job_id")]
    public string? BulkSendJobId { get; init; }

    /// <summary>
    /// The total amount of Signature Requests queued for sending.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public int? Total { get; init; }

    /// <summary>
    /// True if you are the owner of this BulkSendJob, false if it's been shared with you by a team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_creator")]
    public bool? IsCreator { get; init; }

    /// <summary>
    /// Time that the BulkSendJob was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public int? CreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
