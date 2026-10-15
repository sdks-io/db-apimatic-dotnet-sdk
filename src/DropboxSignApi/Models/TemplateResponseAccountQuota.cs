using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// An array of the designated CC roles that must be specified when sending a SignatureRequest using this Template.
/// </summary>
public record TemplateResponseAccountQuota
{
    /// <summary>
    /// API templates remaining.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("templates_left")]
    public int? TemplatesLeft { get; init; }

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
    /// SMS verifications remaining.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_verifications_left")]
    public int? SmsVerificationsLeft { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
