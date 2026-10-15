using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation.Attributes;
using DropboxSignApi.Models.AnyOf;

namespace DropboxSignApi.Models;

public record DocumentFieldDetectionResponseDetectionResult
{
    /// <summary>
    /// The SHA-256 hash of the analyzed document.
    /// </summary>
    [JsonPropertyName("document_hash")]
    [StringLength(64, MinimumLength = 64)]
    public required string DocumentHash { get; init; }

    /// <summary>
    /// The field detection method used to analyze the document: <c>annotations</c> or <c>text_tags</c>.
    /// </summary>
    [JsonPropertyName("detection_mode")]
    public required DetectionMode1 DetectionMode { get; init; }

    /// <summary>
    /// The total number of pages in the document.
    /// </summary>
    [JsonPropertyName("page_count")]
    [Minimum(0)]
    public required int PageCount { get; init; }

    /// <summary>
    /// The zero-based page indexes analyzed, represented by the requested <c>page_range</c>, or <c>all</c> when every page was analyzed.
    /// </summary>
    [JsonPropertyName("pages_analyzed")]
    public required string PagesAnalyzed { get; init; }

    /// <summary>
    /// The Unix timestamp when the field detection result was generated.
    /// </summary>
    [JsonPropertyName("detected_at")]
    public required long DetectedAt { get; init; }

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
    [JsonPropertyName("form_fields_per_document")]
    public required IReadOnlyList<SubFormFieldsPerDocumentBase> FormFieldsPerDocument { get; init; }

    /// <summary>
    /// Group information for fields defined in <c>form_fields_per_document</c>. String-indexed JSON array with <c>group_label</c> and <c>requirement</c> keys. <c>form_fields_per_document</c> must contain fields referencing a group defined in <c>form_field_groups</c>.
    /// </summary>
    [JsonPropertyName("form_field_groups")]
    public required IReadOnlyList<SubFormFieldGroup> FormFieldGroups { get; init; }

    /// <summary>
    /// Non-fatal issues encountered during field detection.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<WarningResponse> Warnings { get; init; }

    /// <summary>
    /// Errors encountered during field detection. Successfully detected fields may still be included in the response.
    /// </summary>
    [JsonPropertyName("errors")]
    public required IReadOnlyList<ErrorResponseError> Errors { get; init; }

    /// <summary>
    /// Suggestions for improving the field detection results.
    /// </summary>
    [JsonPropertyName("suggestions")]
    public required IReadOnlyList<string> Suggestions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
