using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentRadioProperties
{
    /// <summary>
    /// An input field for radios. Use the <c>SubFormFieldsPerDocumentRadio</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "radio";

    /// <summary>
    /// String referencing group defined in <c>form_field_groups</c> parameter.
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; init; }

    /// <summary>
    /// <c>true</c> for checking the radio field by default, otherwise <c>false</c>. Only one radio field per group can be <c>true</c>.
    /// </summary>
    [JsonPropertyName("is_checked")]
    public required bool IsChecked { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
