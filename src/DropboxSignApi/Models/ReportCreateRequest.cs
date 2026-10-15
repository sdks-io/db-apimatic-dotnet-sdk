using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record ReportCreateRequest
{
    /// <summary>
    /// The (inclusive) end date for the report data in <c>MM/DD/YYYY</c> format.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required string EndDate { get; init; }

    /// <summary>
    /// The type(s) of the report you are requesting. Allowed values are <c>user_activity</c> and <c>document_status</c>. User activity reports contain list of all users and their activity during the specified date range. Document status report contain a list of signature requests created in the specified time range (and their status).
    /// </summary>
    [JsonPropertyName("report_type")]
    [MinLength(1)]
    [MaxLength(2)]
    public required IReadOnlyList<ReportType> ReportType { get; init; }

    /// <summary>
    /// The (inclusive) start date for the report data in <c>MM/DD/YYYY</c> format.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required string StartDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
