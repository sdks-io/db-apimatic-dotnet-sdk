using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SignatureRequestResponseCustomFieldBase</c>.
/// </summary>
public record SignatureRequestResponseCustomFieldCheckboxProperties
{
    /// <summary>
    /// The type of this Custom Field. Only 'text' and 'checkbox' are currently supported.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "checkbox";

    /// <summary>
    /// A true/false for checkbox fields
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
