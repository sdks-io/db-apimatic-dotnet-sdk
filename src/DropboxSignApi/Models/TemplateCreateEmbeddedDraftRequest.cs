using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TemplateCreateEmbeddedDraftRequest
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
    /// This allows the requester to specify whether the user is allowed to provide email addresses to CC when creating a template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_ccs")]
    public bool? AllowCcs { get; init; } = true;

    /// <summary>
    /// Allows signers to reassign their signature requests to other signers if set to <c>true</c>. Defaults to <c>false</c>.
    /// <para>
    /// <b>NOTE:</b> Only available for Premium plan and higher.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_reassign")]
    public bool? AllowReassign { get; init; } = false;

    /// <summary>
    /// A list describing the attachments
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachments")]
    public IReadOnlyList<SubAttachment>? Attachments { get; init; }

    /// <summary>
    /// The CC roles that must be assigned when using the template to send a signature request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc_roles")]
    public IReadOnlyList<string>? CcRoles { get; init; }

    /// <summary>
    /// Client id of the app you're using to create this draft. Used to apply the branding and callback url defined for the app.
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; init; }

    /// <summary>
    /// This allows the requester to specify editor options when a preparing a document
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editor_options")]
    public SubEditorOptions? EditorOptions { get; init; }

    /// <summary>
    /// This allows the requester to specify field options for a signature request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_options")]
    public SubFieldOptions? FieldOptions { get; init; }

    /// <summary>
    /// Provide users the ability to review/edit the template signer roles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("force_signer_roles")]
    public bool? ForceSignerRoles { get; init; } = false;

    /// <summary>
    /// Provide users the ability to review/edit the template subject and message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("force_subject_message")]
    public bool? ForceSubjectMessage { get; init; } = false;

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
    /// Add merge fields to the template. Merge fields are placed by the user creating the template and used to pre-fill data by passing values into signature requests with the <c>custom_fields</c> parameter.
    /// If the signature request using that template *does not* pass a value into a merge field, then an empty field remains in the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merge_fields")]
    public IReadOnlyList<SubMergeField>? MergeFields { get; init; }

    /// <summary>
    /// The default template email message.
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
    /// This allows the requester to enable the editor/preview experience.
    /// <list type="bullet">
    ///   <item><description><c>show_preview=true</c>: Allows requesters to enable the editor/preview experience.</description></item>
    ///   <item><description><c>show_preview=false</c>: Allows requesters to disable the editor/preview experience.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_preview")]
    public bool? ShowPreview { get; init; } = false;

    /// <summary>
    /// When only one step remains in the signature request process and this parameter is set to <c>false</c> then the progress stepper will be hidden.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_progress_stepper")]
    public bool? ShowProgressStepper { get; init; } = true;

    /// <summary>
    /// An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer_roles")]
    public IReadOnlyList<SubTemplateRole>? SignerRoles { get; init; }

    /// <summary>
    /// Disables the "Me (Now)" option for the person preparing the document. Does not work with type <c>send_document</c>. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_me_now")]
    public bool? SkipMeNow { get; init; } = false;

    /// <summary>
    /// The template title (alias).
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
    /// The title you want to assign to the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// Enable the detection of predefined PDF fields by setting the <c>use_preexisting_fields</c> to <c>true</c> (defaults to disabled, or <c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("use_preexisting_fields")]
    public bool? UsePreexistingFields { get; init; } = false;

    /// <summary>
    /// Sent with a value of <c>true</c> to ignore the validation errors from text tags extraction. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ignore_text_tags_extraction_errors")]
    public bool? IgnoreTextTagsExtractionErrors { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
