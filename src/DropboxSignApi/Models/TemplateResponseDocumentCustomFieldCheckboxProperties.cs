using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>TemplateResponseDocumentCustomFieldBase</c>
/// </summary>
public record TemplateResponseDocumentCustomFieldCheckboxProperties
{
    /// <summary>
    /// The type of this Custom Field. Only <c>text</c> and <c>checkbox</c> are currently supported.
    /// <list type="bullet">
    ///   <item><description>Text uses <c>TemplateResponseDocumentCustomFieldText</c></description></item>
    ///   <item><description>Checkbox uses <c>TemplateResponseDocumentCustomFieldCheckbox</c></description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "checkbox";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
