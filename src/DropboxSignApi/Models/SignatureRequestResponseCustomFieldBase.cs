using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// An array of Custom Field objects containing the name and type of each custom field.
/// <list type="bullet">
///   <item><description>Text Field uses <c>SignatureRequestResponseCustomFieldText</c></description></item>
///   <item><description>Checkbox Field uses <c>SignatureRequestResponseCustomFieldCheckbox</c></description></item>
/// </list>
/// </summary>
public record SignatureRequestResponseCustomFieldBase
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The name of the Custom Field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A boolean value denoting if this field is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("required")]
    public bool? Required { get; init; }

    /// <summary>
    /// The unique ID for this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_id")]
    public string? ApiId { get; init; }

    /// <summary>
    /// The name of the Role that is able to edit this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editor")]
    public string? Editor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
