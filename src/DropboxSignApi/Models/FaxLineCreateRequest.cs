using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record FaxLineCreateRequest
{
    /// <summary>
    /// Area code of the new Fax Line
    /// </summary>
    [JsonPropertyName("area_code")]
    public required int AreaCode { get; init; }

    /// <summary>
    /// Country of the area code
    /// </summary>
    [JsonPropertyName("country")]
    public required Country Country { get; init; }

    /// <summary>
    /// City of the area code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// Account ID of the account that will be assigned this new Fax Line
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
