using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>TemplateResponseDocumentStaticFieldBase</c>
/// </summary>
public record TemplateResponseDocumentStaticFieldDropdownProperties
{
    /// <summary>
    /// The type of this static field. See <see href="/api/reference/constants/#field-types">field types</see>.
    /// <list type="bullet">
    ///   <item><description>Text Field uses <c>TemplateResponseDocumentStaticFieldText</c></description></item>
    ///   <item><description>Dropdown Field uses <c>TemplateResponseDocumentStaticFieldDropdown</c></description></item>
    ///   <item><description>Hyperlink Field uses <c>TemplateResponseDocumentStaticFieldHyperlink</c></description></item>
    ///   <item><description>Checkbox Field uses <c>TemplateResponseDocumentStaticFieldCheckbox</c></description></item>
    ///   <item><description>Radio Field uses <c>TemplateResponseDocumentStaticFieldRadio</c></description></item>
    ///   <item><description>Signature Field uses <c>TemplateResponseDocumentStaticFieldSignature</c></description></item>
    ///   <item><description>Date Signed Field uses <c>TemplateResponseDocumentStaticFieldDateSigned</c></description></item>
    ///   <item><description>Initials Field uses <c>TemplateResponseDocumentStaticFieldInitials</c></description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "dropdown";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
