using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentCheckboxProperties
{
    /// <summary>
    /// A yes/no checkbox. Use the <c>SubFormFieldsPerDocumentCheckbox</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "checkbox";

    /// <summary>
    /// String referencing group defined in <c>form_field_groups</c> parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public string? Group { get; init; }

    /// <summary>
    /// <c>true</c> for checking the checkbox field by default, otherwise <c>false</c>.
    /// </summary>
    [JsonPropertyName("is_checked")]
    public required bool IsChecked { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
