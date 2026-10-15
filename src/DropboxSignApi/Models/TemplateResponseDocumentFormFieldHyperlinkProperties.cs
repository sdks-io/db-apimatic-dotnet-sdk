using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>TemplateResponseDocumentFormFieldBase</c>
/// </summary>
public record TemplateResponseDocumentFormFieldHyperlinkProperties
{
    /// <summary>
    /// The type of this form field. See <see href="/api/reference/constants/#field-types">field types</see>.
    /// <list type="bullet">
    ///   <item><description>Text Field uses <c>TemplateResponseDocumentFormFieldText</c></description></item>
    ///   <item><description>Dropdown Field uses <c>TemplateResponseDocumentFormFieldDropdown</c></description></item>
    ///   <item><description>Hyperlink Field uses <c>TemplateResponseDocumentFormFieldHyperlink</c></description></item>
    ///   <item><description>Checkbox Field uses <c>TemplateResponseDocumentFormFieldCheckbox</c></description></item>
    ///   <item><description>Radio Field uses <c>TemplateResponseDocumentFormFieldRadio</c></description></item>
    ///   <item><description>Signature Field uses <c>TemplateResponseDocumentFormFieldSignature</c></description></item>
    ///   <item><description>Date Signed Field uses <c>TemplateResponseDocumentFormFieldDateSigned</c></description></item>
    ///   <item><description>Initials Field uses <c>TemplateResponseDocumentFormFieldInitials</c></description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "hyperlink";

    /// <summary>
    /// Average text length in this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avg_text_length")]
    public TemplateResponseFieldAvgTextLength? AvgTextLength { get; init; }

    /// <summary>
    /// Whether this form field is multiline text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isMultiline")]
    public bool? IsMultiline { get; init; }

    /// <summary>
    /// Original font size used in this form field's text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalFontSize")]
    public int? OriginalFontSize { get; init; }

    /// <summary>
    /// Font family used in this form field's text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; init; }

    /// <summary>
    /// The name of the group this field is in. If this field is not a group, this defaults to <c>null</c> except for Radio fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public string? Group { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
