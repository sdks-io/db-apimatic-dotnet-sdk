using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentCustomFieldBase, TemplateResponseDocumentCustomFieldCheckbox.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentCustomFieldCheckboxConverter))]
public record TemplateResponseDocumentCustomFieldCheckbox
{
    public required TemplateResponseDocumentCustomFieldBase TemplateResponseDocumentCustomFieldBase { get; init; }

    public required TemplateResponseDocumentCustomFieldCheckboxProperties TemplateResponseDocumentCustomFieldCheckboxProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentCustomFieldBase templateResponseDocumentCustomFieldBase,
        out TemplateResponseDocumentCustomFieldCheckboxProperties templateResponseDocumentCustomFieldCheckboxProperties)
    {
        templateResponseDocumentCustomFieldBase = TemplateResponseDocumentCustomFieldBase;
        templateResponseDocumentCustomFieldCheckboxProperties = TemplateResponseDocumentCustomFieldCheckboxProperties;
    }

    public static implicit operator TemplateResponseDocumentCustomFieldBase(TemplateResponseDocumentCustomFieldCheckbox value) =>
        value.TemplateResponseDocumentCustomFieldBase;

    public static implicit operator TemplateResponseDocumentCustomFieldCheckboxProperties(TemplateResponseDocumentCustomFieldCheckbox value) =>
        value.TemplateResponseDocumentCustomFieldCheckboxProperties;
}

file class TemplateResponseDocumentCustomFieldCheckboxConverter : JsonConverter<TemplateResponseDocumentCustomFieldCheckbox>
{
    public override TemplateResponseDocumentCustomFieldCheckbox Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentCustomFieldBase = root.Deserialize<TemplateResponseDocumentCustomFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentCustomFieldBase");
        var templateResponseDocumentCustomFieldCheckboxProperties = root.Deserialize<TemplateResponseDocumentCustomFieldCheckboxProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentCustomFieldCheckboxProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentCustomFieldBase.AdditionalProperties,
                templateResponseDocumentCustomFieldCheckboxProperties.AdditionalProperties);
        templateResponseDocumentCustomFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentCustomFieldCheckboxProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentCustomFieldCheckbox
        {
            TemplateResponseDocumentCustomFieldBase = templateResponseDocumentCustomFieldBase,
            TemplateResponseDocumentCustomFieldCheckboxProperties = templateResponseDocumentCustomFieldCheckboxProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentCustomFieldCheckbox value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentCustomFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentCustomFieldCheckboxProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
