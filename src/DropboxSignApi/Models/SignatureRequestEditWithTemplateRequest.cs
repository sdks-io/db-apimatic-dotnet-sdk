using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record SignatureRequestEditWithTemplateRequest
{
    /// <summary>
    /// Use <c>template_ids</c> to create a SignatureRequest from one or more templates, in the order in which the template will be used.
    /// </summary>
    [JsonPropertyName("template_ids")]
    public required IReadOnlyList<string> TemplateIds { get; init; }

    /// <summary>
    /// Allows signers to decline to sign a document if <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_decline")]
    public bool? AllowDecline { get; init; } = false;

    /// <summary>
    /// Add CC email recipients. Required when a CC role exists for the Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ccs")]
    public IReadOnlyList<SubCc>? Ccs { get; init; }

    /// <summary>
    /// Client id of the app to associate with the signature request. Used to apply the branding and callback url defined for the app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// An array defining values and options for custom fields. Required when a custom field exists in the Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<SubCustomField>? CustomFields { get; init; }

    /// <summary>
    /// Use <c>files[]</c> to indicate the uploaded file(s) to send for signature.
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("files")]
    public BinaryContent? Files { get; init; }

    /// <summary>
    /// Use <c>file_urls[]</c> to have Dropbox Sign download the file(s) to send for signature.
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file_urls")]
    public IReadOnlyList<string>? FileUrls { get; init; }

    /// <summary>
    /// Send with a value of <c>true</c> if you wish to enable
    /// <see href="https://www.hellosign.com/features/electronic-id">electronic identification (eID)</see>,
    /// which requires the signer to verify their identity with an eID provider to sign a document.&lt;br&gt;
    /// <b>NOTE:</b> You need the eID add-on to use this feature. Please <see href="https://sign.dropbox.com/form/contact-sales">contact sales</see> for more information. Cannot be used in <c>test_mode</c>. Only works on requests with one signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_eid")]
    public bool? IsEid { get; init; } = false;

    /// <summary>
    /// The custom message in the email that will be sent to the signers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    [MaxLength(5000)]
    public string? Message { get; init; }

    /// <summary>
    /// Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer's order number for look up when receiving events for the signature request.
    /// <para>
    /// Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, object>? Metadata { get; init; }

    /// <summary>
    /// Add Signers to your Templated-based Signature Request.
    /// </summary>
    [JsonPropertyName("signers")]
    public required IReadOnlyList<SubSignatureRequestTemplateSigner> Signers { get; init; }

    /// <summary>
    /// This allows the requester to specify the types allowed for creating a signature and specify another signing options.
    /// <para>
    /// <b>NOTE:</b> If <c>signing_options</c> are not defined in the request, the allowed types will default to those specified in the account settings.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> If <c>force_advanced_signature_details</c> is set, allowed types has to be defined too.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signing_options")]
    public SubSigningOptions? SigningOptions { get; init; }

    /// <summary>
    /// The URL you want signers redirected to after they successfully sign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signing_redirect_url")]
    public string? SigningRedirectUrl { get; init; }

    /// <summary>
    /// The subject in the email that will be sent to the signers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subject")]
    [MaxLength(255)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_mode")]
    public bool? TestMode { get; init; } = false;

    /// <summary>
    /// The title you want to assign to the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    [MaxLength(255)]
    public string? Title { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
