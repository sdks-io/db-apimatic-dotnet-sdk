using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentCheckboxMergeProperties
{
    /// <summary>
    /// A checkbox field that has default value set using pre-filled data. Use the <c>SubFormFieldsPerDocumentCheckboxMerge</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "checkbox-merge";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
