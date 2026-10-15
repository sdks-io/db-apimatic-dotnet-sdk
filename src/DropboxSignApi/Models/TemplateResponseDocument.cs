using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TemplateResponseDocument
{
    /// <summary>
    /// Name of the associated file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Document ordering, the lowest index is displayed first and the highest last (0-based indexing).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("index")]
    public int? Index { get; init; }

    /// <summary>
    /// An array of Form Field Group objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_groups")]
    public IReadOnlyList<TemplateResponseDocumentFieldGroup>? FieldGroups { get; init; }

    /// <summary>
    /// An array of Form Field objects containing the name and type of each named field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form_fields")]
    public IReadOnlyList<TemplateResponseDocumentFormFieldBase>? FormFields { get; init; }

    /// <summary>
    /// An array of Form Field objects containing the name and type of each named field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<TemplateResponseDocumentCustomFieldBase>? CustomFields { get; init; }

    /// <summary>
    /// An array describing static overlay fields. <b>NOTE:</b> Only available for certain subscriptions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("static_fields")]
    public IReadOnlyList<TemplateResponseDocumentStaticFieldBase>? StaticFields { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
