using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains information about the report request.
/// </summary>
public record ReportResponse
{
    /// <summary>
    /// A message indicating the requested operation's success
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public string? Success { get; init; }

    /// <summary>
    /// The (inclusive) start date for the report data in MM/DD/YYYY format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The (inclusive) end date for the report data in MM/DD/YYYY format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public string? EndDate { get; init; }

    /// <summary>
    /// The type(s) of the report you are requesting. Allowed values are "user_activity" and "document_status". User activity reports contain list of all users and their activity during the specified date range. Document status report contain a list of signature requests created in the specified time range (and their status).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("report_type")]
    public IReadOnlyList<ReportType>? ReportType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
