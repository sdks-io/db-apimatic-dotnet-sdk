using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentStaticFieldBase, TemplateResponseDocumentStaticFieldDateSigned.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentStaticFieldDateSignedConverter))]
public record TemplateResponseDocumentStaticFieldDateSigned
{
    public required TemplateResponseDocumentStaticFieldBase TemplateResponseDocumentStaticFieldBase { get; init; }

    public required TemplateResponseDocumentStaticFieldDateSignedProperties TemplateResponseDocumentStaticFieldDateSignedProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentStaticFieldBase templateResponseDocumentStaticFieldBase,
        out TemplateResponseDocumentStaticFieldDateSignedProperties templateResponseDocumentStaticFieldDateSignedProperties)
    {
        templateResponseDocumentStaticFieldBase = TemplateResponseDocumentStaticFieldBase;
        templateResponseDocumentStaticFieldDateSignedProperties =
            TemplateResponseDocumentStaticFieldDateSignedProperties;
    }

    public static implicit operator TemplateResponseDocumentStaticFieldBase(TemplateResponseDocumentStaticFieldDateSigned value) =>
        value.TemplateResponseDocumentStaticFieldBase;

    public static implicit operator TemplateResponseDocumentStaticFieldDateSignedProperties(TemplateResponseDocumentStaticFieldDateSigned value) =>
        value.TemplateResponseDocumentStaticFieldDateSignedProperties;
}

file class TemplateResponseDocumentStaticFieldDateSignedConverter : JsonConverter<TemplateResponseDocumentStaticFieldDateSigned>
{
    public override TemplateResponseDocumentStaticFieldDateSigned Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentStaticFieldBase = root.Deserialize<TemplateResponseDocumentStaticFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldBase");
        var templateResponseDocumentStaticFieldDateSignedProperties = root.Deserialize<TemplateResponseDocumentStaticFieldDateSignedProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldDateSignedProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentStaticFieldBase.AdditionalProperties,
                templateResponseDocumentStaticFieldDateSignedProperties.AdditionalProperties);
        templateResponseDocumentStaticFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentStaticFieldDateSignedProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentStaticFieldDateSigned
        {
            TemplateResponseDocumentStaticFieldBase = templateResponseDocumentStaticFieldBase,
            TemplateResponseDocumentStaticFieldDateSignedProperties = templateResponseDocumentStaticFieldDateSignedProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentStaticFieldDateSigned value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldDateSignedProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
