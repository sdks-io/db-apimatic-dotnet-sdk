using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains information about an error that occurred.
/// </summary>
public record ErrorResponseError
{
    /// <summary>
    /// Message describing an error.
    /// </summary>
    [JsonPropertyName("error_msg")]
    public required string ErrorMsg { get; init; }

    /// <summary>
    /// Path at which an error occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_path")]
    public string? ErrorPath { get; init; }

    /// <summary>
    /// Name of the error. See the <c>x-error-codes</c> catalog in openapi file for a complete list of possible error codes with detailed information including HTTP status codes, causes, remediation steps, and retry guidance.
    /// </summary>
    [JsonPropertyName("error_name")]
    public required string ErrorName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
