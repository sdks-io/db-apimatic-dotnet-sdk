using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentSignatureProperties
{
    /// <summary>
    /// A signature input field. Use the <c>SubFormFieldsPerDocumentSignature</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "signature";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
