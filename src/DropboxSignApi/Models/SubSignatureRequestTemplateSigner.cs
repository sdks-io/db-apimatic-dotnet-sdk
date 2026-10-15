using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record SubSignatureRequestTemplateSigner
{
    /// <summary>
    /// Must match an existing role in chosen Template(s). It's case-sensitive.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; init; }

    /// <summary>
    /// The name of the signer.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The email address of the signer.
    /// </summary>
    [JsonPropertyName("email_address")]
    [Format(FormatKind.Email)]
    public required string EmailAddress { get; init; }

    /// <summary>
    /// The 4- to 12-character access code that will secure this signer's signature page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pin")]
    [StringLength(12, MinimumLength = 4)]
    public string? Pin { get; init; }

    /// <summary>
    /// An E.164 formatted phone number.
    /// <para>
    /// By using the feature, you agree you are responsible for obtaining a signer's consent to receive text messages from Dropbox Sign related to this signature request and confirm you have obtained such consent from all signers prior to enabling SMS delivery for this signature request. <see href="https://faq.hellosign.com/hc/en-us/articles/15815316468877-Dropbox-Sign-SMS-tools-add-on">Learn more</see>.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> Not available in test mode and requires a Standard plan or higher.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_phone_number")]
    public string? SmsPhoneNumber { get; init; }

    /// <summary>
    /// Specifies the feature used with the <c>sms_phone_number</c>. Default <c>authentication</c>.
    /// <para>
    /// If <c>authentication</c>, signer is sent a verification code via SMS that is required to access the document.
    /// </para>
    /// <para>
    /// If <c>delivery</c>, a link to complete the signature request is delivered via SMS (_and_ email).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_phone_number_type")]
    public SmsPhoneNumberType? SmsPhoneNumberType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
