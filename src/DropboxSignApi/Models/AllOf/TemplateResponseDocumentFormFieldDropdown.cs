using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentFormFieldBase, TemplateResponseDocumentFormFieldDropdown.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentFormFieldDropdownConverter))]
public record TemplateResponseDocumentFormFieldDropdown
{
    public required TemplateResponseDocumentFormFieldBase TemplateResponseDocumentFormFieldBase { get; init; }

    public required TemplateResponseDocumentFormFieldDropdownProperties TemplateResponseDocumentFormFieldDropdownProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentFormFieldBase templateResponseDocumentFormFieldBase,
        out TemplateResponseDocumentFormFieldDropdownProperties templateResponseDocumentFormFieldDropdownProperties)
    {
        templateResponseDocumentFormFieldBase = TemplateResponseDocumentFormFieldBase;
        templateResponseDocumentFormFieldDropdownProperties = TemplateResponseDocumentFormFieldDropdownProperties;
    }

    public static implicit operator TemplateResponseDocumentFormFieldBase(TemplateResponseDocumentFormFieldDropdown value) =>
        value.TemplateResponseDocumentFormFieldBase;

    public static implicit operator TemplateResponseDocumentFormFieldDropdownProperties(TemplateResponseDocumentFormFieldDropdown value) =>
        value.TemplateResponseDocumentFormFieldDropdownProperties;
}

file class TemplateResponseDocumentFormFieldDropdownConverter : JsonConverter<TemplateResponseDocumentFormFieldDropdown>
{
    public override TemplateResponseDocumentFormFieldDropdown Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentFormFieldBase = root.Deserialize<TemplateResponseDocumentFormFieldBase>(options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldBase");
        var templateResponseDocumentFormFieldDropdownProperties = root.Deserialize<TemplateResponseDocumentFormFieldDropdownProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldDropdownProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentFormFieldBase.AdditionalProperties,
                templateResponseDocumentFormFieldDropdownProperties.AdditionalProperties);
        templateResponseDocumentFormFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentFormFieldDropdownProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentFormFieldDropdown
        {
            TemplateResponseDocumentFormFieldBase = templateResponseDocumentFormFieldBase,
            TemplateResponseDocumentFormFieldDropdownProperties = templateResponseDocumentFormFieldDropdownProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentFormFieldDropdown value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldDropdownProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
