using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record UnclaimedDraftCreateRequest
{
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
    /// Allows signers to decline to sign a document if <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_decline")]
    public bool? AllowDecline { get; init; } = false;

    /// <summary>
    /// A list describing the attachments
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachments")]
    public IReadOnlyList<SubAttachment>? Attachments { get; init; }

    /// <summary>
    /// The email addresses that should be CCed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc_email_addresses")]
    public IReadOnlyList<string>? CcEmailAddresses { get; init; }

    /// <summary>
    /// Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// When used together with merge fields, <c>custom_fields</c> allows users to add pre-filled data to their signature requests.
    /// <para>
    /// Pre-filled data can be used with "send-once" signature requests by adding merge fields with <c>form_fields_per_document</c> or <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> while passing values back with <c>custom_fields</c> together in one API call.
    /// </para>
    /// <para>
    /// For using pre-filled on repeatable signature requests, merge fields are added to templates in the Dropbox Sign UI or by calling <see href="/api/reference/operation/templateCreateEmbeddedDraft">/template/create_embedded_draft</see> and then passing <c>custom_fields</c> on subsequent signature requests referencing that template.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<SubCustomField>? CustomFields { get; init; }

    /// <summary>
    /// This allows the requester to specify field options for a signature request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_options")]
    public SubFieldOptions? FieldOptions { get; init; }

    /// <summary>
    /// Group information for fields defined in <c>form_fields_per_document</c>. String-indexed JSON array with <c>group_label</c> and <c>requirement</c> keys. <c>form_fields_per_document</c> must contain fields referencing a group defined in <c>form_field_groups</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form_field_groups")]
    public IReadOnlyList<SubFormFieldGroup>? FormFieldGroups { get; init; }

    /// <summary>
    /// Conditional Logic rules for fields defined in <c>form_fields_per_document</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form_field_rules")]
    public IReadOnlyList<SubFormFieldRule>? FormFieldRules { get; init; }

    /// <summary>
    /// The fields that should appear on the document, expressed as an array of objects. (For more details you can read about it here: <see href="/docs/openapi/form-fields-per-document">Using Form Fields per Document</see>.)
    /// <para>
    /// <b>NOTE:</b> Fields like <b>text</b>, <b>dropdown</b>, <b>checkbox</b>, <b>radio</b>, and <b>hyperlink</b> have additional required and optional parameters. Check out the list of <see href="/api/reference/constants/#form-fields-per-document">additional parameters</see> for these field types.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Text Field use <c>SubFormFieldsPerDocumentText</c></description></item>
    ///   <item><description>Dropdown Field use <c>SubFormFieldsPerDocumentDropdown</c></description></item>
    ///   <item><description>Hyperlink Field use <c>SubFormFieldsPerDocumentHyperlink</c></description></item>
    ///   <item><description>Checkbox Field use <c>SubFormFieldsPerDocumentCheckbox</c></description></item>
    ///   <item><description>Radio Field use <c>SubFormFieldsPerDocumentRadio</c></description></item>
    ///   <item><description>Signature Field use <c>SubFormFieldsPerDocumentSignature</c></description></item>
    ///   <item><description>Date Signed Field use <c>SubFormFieldsPerDocumentDateSigned</c></description></item>
    ///   <item><description>Initials Field use <c>SubFormFieldsPerDocumentInitials</c></description></item>
    ///   <item><description>Text Merge Field use <c>SubFormFieldsPerDocumentTextMerge</c></description></item>
    ///   <item><description>Checkbox Merge Field use <c>SubFormFieldsPerDocumentCheckboxMerge</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form_fields_per_document")]
    public IReadOnlyList<SubFormFieldsPerDocumentBase>? FormFieldsPerDocument { get; init; }

    /// <summary>
    /// Send with a value of <c>true</c> if you wish to enable automatic Text Tag removal. Defaults to <c>false</c>. When using Text Tags it is preferred that you set this to <c>false</c> and hide your tags with white text or something similar because the automatic removal system can cause unwanted clipping. See the <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> walkthrough for more details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hide_text_tags")]
    public bool? HideTextTags { get; init; } = false;

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
    /// When only one step remains in the signature request process and this parameter is set to <c>false</c> then the progress stepper will be hidden.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_progress_stepper")]
    public bool? ShowProgressStepper { get; init; } = true;

    /// <summary>
    /// Add Signers to your Unclaimed Draft Signature Request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signers")]
    public IReadOnlyList<SubUnclaimedDraftSigner>? Signers { get; init; }

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
    [MaxLength(200)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request created from this draft will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_mode")]
    public bool? TestMode { get; init; } = false;

    /// <summary>
    /// The type of unclaimed draft to create. Use <c>send_document</c> to create a claimable file, and <c>request_signature</c> for a claimable signature request. If the type is <c>request_signature</c> then signers name and email_address are not optional.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type2 Type { get; init; }

    /// <summary>
    /// Set <c>use_text_tags</c> to <c>true</c> to enable <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> parsing in your document (defaults to disabled, or <c>false</c>). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the <c>use_preexisting_fields</c> to <c>true</c> (defaults to disabled, or <c>false</c>). Currently we only support use of either <c>use_text_tags</c> or <c>use_preexisting_fields</c> parameter, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("use_preexisting_fields")]
    public bool? UsePreexistingFields { get; init; } = false;

    /// <summary>
    /// Set <c>use_text_tags</c> to <c>true</c> to enable <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> parsing in your document (defaults to disabled, or <c>false</c>). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the <c>use_preexisting_fields</c> to <c>true</c> (defaults to disabled, or <c>false</c>). Currently we only support use of either <c>use_text_tags</c> or <c>use_preexisting_fields</c> parameter, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("use_text_tags")]
    public bool? UseTextTags { get; init; } = false;

    /// <summary>
    /// Sent with a value of <c>true</c> to ignore the validation errors from text tags extraction. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ignore_text_tags_extraction_errors")]
    public bool? IgnoreTextTagsExtractionErrors { get; init; } = false;

    /// <summary>
    /// When the signature request will expire. Unsigned signatures will be moved to the expired status, and no longer signable. See <see href="https://developers.hellosign.com/docs/signature-request/expiration/">Signature Request Expiration Date</see> for details.
    /// <para>
    /// <b>NOTE:</b> This does not correspond to the <b>expires_at</b> returned in the response.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public int? ExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
