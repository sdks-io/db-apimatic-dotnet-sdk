using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Subset of configured settings
/// </summary>
public record AccountResponseSettings
{
    /// <summary>
    /// Returns <c>true</c> if _Custom access codes_ is enabled in Admin Console. <see href="https://developers.hellosign.com/docs/sms-tools/walkthrough">Read more</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer_access_codes")]
    public bool? SignerAccessCodes { get; init; }

    /// <summary>
    /// Returns <c>true</c> if _Text message_ is enabled in Admin Console. <see href="https://developers.hellosign.com/docs/sms-tools/walkthrough">Read more</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_delivery")]
    public bool? SmsDelivery { get; init; }

    /// <summary>
    /// Returns <c>true</c> if _Signer authentication_ is enabled in Admin Console. <see href="https://developers.hellosign.com/docs/sms-tools/walkthrough">Read more</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_authentication")]
    public bool? SmsAuthentication { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
