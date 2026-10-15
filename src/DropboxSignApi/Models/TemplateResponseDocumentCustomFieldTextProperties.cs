using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>TemplateResponseDocumentCustomFieldBase</c>
/// </summary>
public record TemplateResponseDocumentCustomFieldTextProperties
{
    /// <summary>
    /// The type of this Custom Field. Only <c>text</c> and <c>checkbox</c> are currently supported.
    /// <list type="bullet">
    ///   <item><description>Text uses <c>TemplateResponseDocumentCustomFieldText</c></description></item>
    ///   <item><description>Checkbox uses <c>TemplateResponseDocumentCustomFieldCheckbox</c></description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "text";

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
