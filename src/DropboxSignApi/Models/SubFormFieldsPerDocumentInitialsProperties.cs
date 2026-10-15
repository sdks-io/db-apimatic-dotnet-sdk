using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentInitialsProperties
{
    /// <summary>
    /// An input field for initials. Use the <c>SubFormFieldsPerDocumentInitials</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "initials";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
