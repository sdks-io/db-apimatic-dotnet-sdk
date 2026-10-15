using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Requests.UnclaimedDraft;

/// <summary>
/// The inputs of the UnclaimedDraftCreate operation.
/// </summary>
public sealed record UnclaimedDraftCreateOperationRequest
{
    /// <summary>
    /// The type of unclaimed draft to create. Use <c>send_document</c> to create a claimable file, and <c>request_signature</c> for a claimable signature request. If the type is <c>request_signature</c> then signers name and email_address are not optional.
    /// </summary>
    public required Type2 Type { get; init; }

    /// <summary>
    /// Use <c>files[]</c> to indicate the uploaded file(s) to send for signature.
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    public BinaryContent? Files { get; init; }

    /// <summary>
    /// Use <c>file_urls[]</c> to have Dropbox Sign download the file(s) to send for signature.
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    public IReadOnlyList<string>? FileUrls { get; init; }

    /// <summary>
    /// Allows signers to decline to sign a document if <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool AllowDecline { get; init; } = false;

    /// <summary>
    /// A list describing the attachments
    /// </summary>
    public IReadOnlyList<SubAttachment>? Attachments { get; init; }

    /// <summary>
    /// The email addresses that should be CCed.
    /// </summary>
    public IReadOnlyList<string>? CcEmailAddresses { get; init; }

    /// <summary>
    /// Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.
    /// </summary>
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
    public IReadOnlyList<SubCustomField>? CustomFields { get; init; }

    /// <summary>
    /// This allows the requester to specify field options for a signature request.
    /// </summary>
    public SubFieldOptions? FieldOptions { get; init; }

    /// <summary>
    /// Group information for fields defined in <c>form_fields_per_document</c>. String-indexed JSON array with <c>group_label</c> and <c>requirement</c> keys. <c>form_fields_per_document</c> must contain fields referencing a group defined in <c>form_field_groups</c>.
    /// </summary>
    public IReadOnlyList<SubFormFieldGroup>? FormFieldGroups { get; init; }

    /// <summary>
    /// Conditional Logic rules for fields defined in <c>form_fields_per_document</c>.
    /// </summary>
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
    public IReadOnlyList<SubFormFieldsPerDocumentBase>? FormFieldsPerDocument { get; init; }

    /// <summary>
    /// Send with a value of <c>true</c> if you wish to enable automatic Text Tag removal. Defaults to <c>false</c>. When using Text Tags it is preferred that you set this to <c>false</c> and hide your tags with white text or something similar because the automatic removal system can cause unwanted clipping. See the <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> walkthrough for more details.
    /// </summary>
    public bool HideTextTags { get; init; } = false;

    /// <summary>
    /// The custom message in the email that will be sent to the signers.
    /// </summary>
    [MaxLength(5000)]
    public string? Message { get; init; }

    /// <summary>
    /// Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer's order number for look up when receiving events for the signature request.
    /// <para>
    /// Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.
    /// </para>
    /// </summary>
    public IReadOnlyDictionary<string, object>? Metadata { get; init; }

    /// <summary>
    /// When only one step remains in the signature request process and this parameter is set to <c>false</c> then the progress stepper will be hidden.
    /// </summary>
    public bool ShowProgressStepper { get; init; } = true;

    /// <summary>
    /// Add Signers to your Unclaimed Draft Signature Request.
    /// </summary>
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
    public SubSigningOptions? SigningOptions { get; init; }

    /// <summary>
    /// The URL you want signers redirected to after they successfully sign.
    /// </summary>
    public string? SigningRedirectUrl { get; init; }

    /// <summary>
    /// The subject in the email that will be sent to the signers.
    /// </summary>
    [MaxLength(200)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request created from this draft will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool TestMode { get; init; } = false;

    /// <summary>
    /// Set <c>use_text_tags</c> to <c>true</c> to enable <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> parsing in your document (defaults to disabled, or <c>false</c>). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the <c>use_preexisting_fields</c> to <c>true</c> (defaults to disabled, or <c>false</c>). Currently we only support use of either <c>use_text_tags</c> or <c>use_preexisting_fields</c> parameter, not both.
    /// </summary>
    public bool UsePreexistingFields { get; init; } = false;

    /// <summary>
    /// Set <c>use_text_tags</c> to <c>true</c> to enable <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> parsing in your document (defaults to disabled, or <c>false</c>). Alternatively, if your PDF contains pre-defined fields, enable the detection of these fields by setting the <c>use_preexisting_fields</c> to <c>true</c> (defaults to disabled, or <c>false</c>). Currently we only support use of either <c>use_text_tags</c> or <c>use_preexisting_fields</c> parameter, not both.
    /// </summary>
    public bool UseTextTags { get; init; } = false;

    /// <summary>
    /// Sent with a value of <c>true</c> to ignore the validation errors from text tags extraction. Defaults to <c>false</c>.
    /// </summary>
    public bool IgnoreTextTagsExtractionErrors { get; init; } = false;

    /// <summary>
    /// When the signature request will expire. Unsigned signatures will be moved to the expired status, and no longer signable. See <see href="https://developers.hellosign.com/docs/signature-request/expiration/">Signature Request Expiration Date</see> for details.
    /// <para>
    /// <b>NOTE:</b> This does not correspond to the <b>expires_at</b> returned in the response.
    /// </para>
    /// </summary>
    public int? ExpiresAt { get; init; }
}
