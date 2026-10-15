using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentStaticFieldBase, TemplateResponseDocumentStaticFieldText.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentStaticFieldTextConverter))]
public record TemplateResponseDocumentStaticFieldText
{
    public required TemplateResponseDocumentStaticFieldBase TemplateResponseDocumentStaticFieldBase { get; init; }

    public required TemplateResponseDocumentStaticFieldTextProperties TemplateResponseDocumentStaticFieldTextProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentStaticFieldBase templateResponseDocumentStaticFieldBase,
        out TemplateResponseDocumentStaticFieldTextProperties templateResponseDocumentStaticFieldTextProperties)
    {
        templateResponseDocumentStaticFieldBase = TemplateResponseDocumentStaticFieldBase;
        templateResponseDocumentStaticFieldTextProperties = TemplateResponseDocumentStaticFieldTextProperties;
    }

    public static implicit operator TemplateResponseDocumentStaticFieldBase(TemplateResponseDocumentStaticFieldText value) =>
        value.TemplateResponseDocumentStaticFieldBase;

    public static implicit operator TemplateResponseDocumentStaticFieldTextProperties(TemplateResponseDocumentStaticFieldText value) =>
        value.TemplateResponseDocumentStaticFieldTextProperties;
}

file class TemplateResponseDocumentStaticFieldTextConverter : JsonConverter<TemplateResponseDocumentStaticFieldText>
{
    public override TemplateResponseDocumentStaticFieldText Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentStaticFieldBase = root.Deserialize<TemplateResponseDocumentStaticFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldBase");
        var templateResponseDocumentStaticFieldTextProperties = root.Deserialize<TemplateResponseDocumentStaticFieldTextProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldTextProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentStaticFieldBase.AdditionalProperties,
                templateResponseDocumentStaticFieldTextProperties.AdditionalProperties);
        templateResponseDocumentStaticFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentStaticFieldTextProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentStaticFieldText
        {
            TemplateResponseDocumentStaticFieldBase = templateResponseDocumentStaticFieldBase,
            TemplateResponseDocumentStaticFieldTextProperties = templateResponseDocumentStaticFieldTextProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentStaticFieldText value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldTextProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
