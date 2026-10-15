using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// An array of Form Field objects containing the name and type of each named field.
/// </summary>
public record TemplateResponseDocumentCustomFieldBase
{
    /// <summary>
    /// The unique ID for this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_id")]
    public string? ApiId { get; init; }

    /// <summary>
    /// The name of the Custom Field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The signer of the Custom Field. Can be <c>null</c> if field is a merge field (assigned to Sender).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer")]
    public string? Signer { get; init; }

    /// <summary>
    /// The horizontal offset in pixels for this form field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("x")]
    public int? X { get; init; }

    /// <summary>
    /// The vertical offset in pixels for this form field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("y")]
    public int? Y { get; init; }

    /// <summary>
    /// The width in pixels of this form field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("width")]
    public int? Width { get; init; }

    /// <summary>
    /// The height in pixels of this form field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("height")]
    public int? Height { get; init; }

    /// <summary>
    /// Boolean showing whether or not this field is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("required")]
    public bool? Required { get; init; }

    /// <summary>
    /// The name of the group this field is in. If this field is not a group, this defaults to <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public string? Group { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
