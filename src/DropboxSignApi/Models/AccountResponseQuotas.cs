using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Details concerning remaining monthly quotas.
/// </summary>
public record AccountResponseQuotas
{
    /// <summary>
    /// API signature requests remaining.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_signature_requests_left")]
    public int? ApiSignatureRequestsLeft { get; init; }

    /// <summary>
    /// Signature requests remaining.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documents_left")]
    public int? DocumentsLeft { get; init; }

    /// <summary>
    /// Total API templates allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("templates_total")]
    public int? TemplatesTotal { get; init; }

    /// <summary>
    /// API templates remaining.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("templates_left")]
    public int? TemplatesLeft { get; init; }

    /// <summary>
    /// SMS verifications remaining.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_verifications_left")]
    public int? SmsVerificationsLeft { get; init; }

    /// <summary>
    /// Number of fax pages left
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_fax_pages_left")]
    public int? NumFaxPagesLeft { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
