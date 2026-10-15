using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentStaticFieldBase, TemplateResponseDocumentStaticFieldDropdown.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentStaticFieldDropdownConverter))]
public record TemplateResponseDocumentStaticFieldDropdown
{
    public required TemplateResponseDocumentStaticFieldBase TemplateResponseDocumentStaticFieldBase { get; init; }

    public required TemplateResponseDocumentStaticFieldDropdownProperties TemplateResponseDocumentStaticFieldDropdownProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentStaticFieldBase templateResponseDocumentStaticFieldBase,
        out TemplateResponseDocumentStaticFieldDropdownProperties templateResponseDocumentStaticFieldDropdownProperties)
    {
        templateResponseDocumentStaticFieldBase = TemplateResponseDocumentStaticFieldBase;
        templateResponseDocumentStaticFieldDropdownProperties = TemplateResponseDocumentStaticFieldDropdownProperties;
    }

    public static implicit operator TemplateResponseDocumentStaticFieldBase(TemplateResponseDocumentStaticFieldDropdown value) =>
        value.TemplateResponseDocumentStaticFieldBase;

    public static implicit operator TemplateResponseDocumentStaticFieldDropdownProperties(TemplateResponseDocumentStaticFieldDropdown value) =>
        value.TemplateResponseDocumentStaticFieldDropdownProperties;
}

file class TemplateResponseDocumentStaticFieldDropdownConverter : JsonConverter<TemplateResponseDocumentStaticFieldDropdown>
{
    public override TemplateResponseDocumentStaticFieldDropdown Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentStaticFieldBase = root.Deserialize<TemplateResponseDocumentStaticFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldBase");
        var templateResponseDocumentStaticFieldDropdownProperties = root.Deserialize<TemplateResponseDocumentStaticFieldDropdownProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldDropdownProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentStaticFieldBase.AdditionalProperties,
                templateResponseDocumentStaticFieldDropdownProperties.AdditionalProperties);
        templateResponseDocumentStaticFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentStaticFieldDropdownProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentStaticFieldDropdown
        {
            TemplateResponseDocumentStaticFieldBase = templateResponseDocumentStaticFieldBase,
            TemplateResponseDocumentStaticFieldDropdownProperties = templateResponseDocumentStaticFieldDropdownProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentStaticFieldDropdown value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldDropdownProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
