using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SignatureRequestResponseCustomFieldBase</c>.
/// </summary>
public record SignatureRequestResponseCustomFieldTextProperties
{
    /// <summary>
    /// The type of this Custom Field. Only 'text' and 'checkbox' are currently supported.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "text";

    /// <summary>
    /// A text string for text fields
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
