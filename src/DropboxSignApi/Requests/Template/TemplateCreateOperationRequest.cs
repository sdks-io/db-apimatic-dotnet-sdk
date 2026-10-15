using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateCreate operation.
/// </summary>
public sealed record TemplateCreateOperationRequest
{
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
    public required IReadOnlyList<SubFormFieldsPerDocumentBase> FormFieldsPerDocument { get; init; }

    /// <summary>
    /// An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template.
    /// </summary>
    public required IReadOnlyList<SubTemplateRole> SignerRoles { get; init; }

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
    /// The CC roles that must be assigned when using the template to send a signature request
    /// </summary>
    public IReadOnlyList<string>? CcRoles { get; init; }

    /// <summary>
    /// Client id of the app you're using to create this draft. Used to apply the branding and callback url defined for the app.
    /// </summary>
    public string? ClientId { get; init; }

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
    /// Add merge fields to the template. Merge fields are placed by the user creating the template and used to pre-fill data by passing values into signature requests with the <c>custom_fields</c> parameter.
    /// If the signature request using that template *does not* pass a value into a merge field, then an empty field remains in the document.
    /// </summary>
    public IReadOnlyList<SubMergeField>? MergeFields { get; init; }

    /// <summary>
    /// The default template email message.
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
    /// The template title (alias).
    /// </summary>
    [MaxLength(200)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request created from this draft will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool TestMode { get; init; } = false;

    /// <summary>
    /// The title you want to assign to the SignatureRequest.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// Enable the detection of predefined PDF fields by setting the <c>use_preexisting_fields</c> to <c>true</c> (defaults to disabled, or <c>false</c>).
    /// </summary>
    public bool UsePreexistingFields { get; init; } = false;

    /// <summary>
    /// Sent with a value of <c>true</c> to ignore the validation errors from text tags extraction. Defaults to <c>false</c>.
    /// </summary>
    public bool IgnoreTextTagsExtractionErrors { get; init; } = false;
}
