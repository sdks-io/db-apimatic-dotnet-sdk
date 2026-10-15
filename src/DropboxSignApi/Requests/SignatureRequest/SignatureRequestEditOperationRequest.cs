using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestEdit operation.
/// </summary>
public sealed record SignatureRequestEditOperationRequest
{
    /// <summary>
    /// The id of the SignatureRequest to edit.
    /// </summary>
    public required string SignatureRequestId { get; init; }

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
    /// Add Signers to your Signature Request.
    /// <para>
    /// This endpoint requires either <b>signers</b> or <b>grouped_signers</b>, but not both.
    /// </para>
    /// </summary>
    public IReadOnlyList<SubSignatureRequestSigner>? Signers { get; init; }

    /// <summary>
    /// Add Grouped Signers to your Signature Request.
    /// <para>
    /// This endpoint requires either <b>signers</b> or <b>grouped_signers</b>, but not both.
    /// </para>
    /// </summary>
    public IReadOnlyList<SubSignatureRequestGroupedSigners>? GroupedSigners { get; init; }

    /// <summary>
    /// Allows signers to decline to sign a document if <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool AllowDecline { get; init; } = false;

    /// <summary>
    /// Allows signers to reassign their signature requests to other signers if set to <c>true</c>. Defaults to <c>false</c>.
    /// <para>
    /// <b>NOTE:</b> Only available for Premium plan and higher.
    /// </para>
    /// </summary>
    public bool AllowReassign { get; init; } = false;

    /// <summary>
    /// A list describing the attachments
    /// </summary>
    public IReadOnlyList<SubAttachment>? Attachments { get; init; }

    /// <summary>
    /// The email addresses that should be CCed.
    /// </summary>
    public IReadOnlyList<string>? CcEmailAddresses { get; init; }

    /// <summary>
    /// The client id of the API App you want to associate with this request. Used to apply the branding and callback url defined for the app.
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
    /// Enables automatic Text Tag removal when set to true.
    /// <para>
    /// <b>NOTE:</b> Removing text tags this way can cause unwanted clipping. We recommend leaving this setting on <c>false</c> and instead hiding your text tags using white text or a similar approach. See the <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags Walkthrough</see> for more information.
    /// </para>
    /// </summary>
    public bool HideTextTags { get; init; } = false;

    /// <summary>
    /// Send with a value of <c>true</c> if you wish to enable
    /// <see href="https://www.hellosign.com/features/electronic-id">electronic identification (eID)</see>,
    /// which requires the signer to verify their identity with an eID provider to sign a document.&lt;br&gt;
    /// <b>NOTE:</b> You need the eID add-on to use this feature. Please <see href="https://sign.dropbox.com/form/contact-sales">contact sales</see> for more information. Cannot be used in <c>test_mode</c>. Only works on requests with one signer.
    /// </summary>
    public bool IsEid { get; init; } = false;

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
    [MaxLength(255)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool TestMode { get; init; } = false;

    /// <summary>
    /// The title you want to assign to the SignatureRequest.
    /// </summary>
    [MaxLength(255)]
    public string? Title { get; init; }

    /// <summary>
    /// Send with a value of <c>true</c> if you wish to enable <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> parsing in your document. Defaults to disabled, or <c>false</c>.
    /// </summary>
    public bool UseTextTags { get; init; } = false;

    /// <summary>
    /// Sent with a value of <c>true</c> to ignore the validation errors from text tags extraction. Defaults to <c>false</c>.
    /// </summary>
    public bool IgnoreTextTagsExtractionErrors { get; init; } = false;

    /// <summary>
    /// When the signature request will expire. Unsigned signatures will be moved to the expired status, and no longer signable. See <see href="https://developers.hellosign.com/docs/signature-request/expiration/">Signature Request Expiration Date</see> for details.
    /// </summary>
    public int? ExpiresAt { get; init; }
}
