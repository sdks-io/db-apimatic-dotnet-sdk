using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentFormFieldBase, TemplateResponseDocumentFormFieldDateSigned.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentFormFieldDateSignedConverter))]
public record TemplateResponseDocumentFormFieldDateSigned
{
    public required TemplateResponseDocumentFormFieldBase TemplateResponseDocumentFormFieldBase { get; init; }

    public required TemplateResponseDocumentFormFieldDateSignedProperties TemplateResponseDocumentFormFieldDateSignedProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentFormFieldBase templateResponseDocumentFormFieldBase,
        out TemplateResponseDocumentFormFieldDateSignedProperties templateResponseDocumentFormFieldDateSignedProperties)
    {
        templateResponseDocumentFormFieldBase = TemplateResponseDocumentFormFieldBase;
        templateResponseDocumentFormFieldDateSignedProperties = TemplateResponseDocumentFormFieldDateSignedProperties;
    }

    public static implicit operator TemplateResponseDocumentFormFieldBase(TemplateResponseDocumentFormFieldDateSigned value) =>
        value.TemplateResponseDocumentFormFieldBase;

    public static implicit operator TemplateResponseDocumentFormFieldDateSignedProperties(TemplateResponseDocumentFormFieldDateSigned value) =>
        value.TemplateResponseDocumentFormFieldDateSignedProperties;
}

file class TemplateResponseDocumentFormFieldDateSignedConverter : JsonConverter<TemplateResponseDocumentFormFieldDateSigned>
{
    public override TemplateResponseDocumentFormFieldDateSigned Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentFormFieldBase = root.Deserialize<TemplateResponseDocumentFormFieldBase>(options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldBase");
        var templateResponseDocumentFormFieldDateSignedProperties = root.Deserialize<TemplateResponseDocumentFormFieldDateSignedProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldDateSignedProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentFormFieldBase.AdditionalProperties,
                templateResponseDocumentFormFieldDateSignedProperties.AdditionalProperties);
        templateResponseDocumentFormFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentFormFieldDateSignedProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentFormFieldDateSigned
        {
            TemplateResponseDocumentFormFieldBase = templateResponseDocumentFormFieldBase,
            TemplateResponseDocumentFormFieldDateSignedProperties = templateResponseDocumentFormFieldDateSignedProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentFormFieldDateSigned value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldDateSignedProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
