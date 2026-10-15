using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentCustomFieldBase, TemplateResponseDocumentCustomFieldText.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentCustomFieldTextConverter))]
public record TemplateResponseDocumentCustomFieldText
{
    public required TemplateResponseDocumentCustomFieldBase TemplateResponseDocumentCustomFieldBase { get; init; }

    public required TemplateResponseDocumentCustomFieldTextProperties TemplateResponseDocumentCustomFieldTextProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentCustomFieldBase templateResponseDocumentCustomFieldBase,
        out TemplateResponseDocumentCustomFieldTextProperties templateResponseDocumentCustomFieldTextProperties)
    {
        templateResponseDocumentCustomFieldBase = TemplateResponseDocumentCustomFieldBase;
        templateResponseDocumentCustomFieldTextProperties = TemplateResponseDocumentCustomFieldTextProperties;
    }

    public static implicit operator TemplateResponseDocumentCustomFieldBase(TemplateResponseDocumentCustomFieldText value) =>
        value.TemplateResponseDocumentCustomFieldBase;

    public static implicit operator TemplateResponseDocumentCustomFieldTextProperties(TemplateResponseDocumentCustomFieldText value) =>
        value.TemplateResponseDocumentCustomFieldTextProperties;
}

file class TemplateResponseDocumentCustomFieldTextConverter : JsonConverter<TemplateResponseDocumentCustomFieldText>
{
    public override TemplateResponseDocumentCustomFieldText Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentCustomFieldBase = root.Deserialize<TemplateResponseDocumentCustomFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentCustomFieldBase");
        var templateResponseDocumentCustomFieldTextProperties = root.Deserialize<TemplateResponseDocumentCustomFieldTextProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentCustomFieldTextProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentCustomFieldBase.AdditionalProperties,
                templateResponseDocumentCustomFieldTextProperties.AdditionalProperties);
        templateResponseDocumentCustomFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentCustomFieldTextProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentCustomFieldText
        {
            TemplateResponseDocumentCustomFieldBase = templateResponseDocumentCustomFieldBase,
            TemplateResponseDocumentCustomFieldTextProperties = templateResponseDocumentCustomFieldTextProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentCustomFieldText value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentCustomFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentCustomFieldTextProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
