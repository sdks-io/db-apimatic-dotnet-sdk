using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentStaticFieldBase, TemplateResponseDocumentStaticFieldHyperlink.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentStaticFieldHyperlinkConverter))]
public record TemplateResponseDocumentStaticFieldHyperlink
{
    public required TemplateResponseDocumentStaticFieldBase TemplateResponseDocumentStaticFieldBase { get; init; }

    public required TemplateResponseDocumentStaticFieldHyperlinkProperties TemplateResponseDocumentStaticFieldHyperlinkProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentStaticFieldBase templateResponseDocumentStaticFieldBase,
        out TemplateResponseDocumentStaticFieldHyperlinkProperties templateResponseDocumentStaticFieldHyperlinkProperties)
    {
        templateResponseDocumentStaticFieldBase = TemplateResponseDocumentStaticFieldBase;
        templateResponseDocumentStaticFieldHyperlinkProperties = TemplateResponseDocumentStaticFieldHyperlinkProperties;
    }

    public static implicit operator TemplateResponseDocumentStaticFieldBase(TemplateResponseDocumentStaticFieldHyperlink value) =>
        value.TemplateResponseDocumentStaticFieldBase;

    public static implicit operator TemplateResponseDocumentStaticFieldHyperlinkProperties(TemplateResponseDocumentStaticFieldHyperlink value) =>
        value.TemplateResponseDocumentStaticFieldHyperlinkProperties;
}

file class TemplateResponseDocumentStaticFieldHyperlinkConverter : JsonConverter<TemplateResponseDocumentStaticFieldHyperlink>
{
    public override TemplateResponseDocumentStaticFieldHyperlink Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentStaticFieldBase = root.Deserialize<TemplateResponseDocumentStaticFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldBase");
        var templateResponseDocumentStaticFieldHyperlinkProperties = root.Deserialize<TemplateResponseDocumentStaticFieldHyperlinkProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldHyperlinkProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentStaticFieldBase.AdditionalProperties,
                templateResponseDocumentStaticFieldHyperlinkProperties.AdditionalProperties);
        templateResponseDocumentStaticFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentStaticFieldHyperlinkProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentStaticFieldHyperlink
        {
            TemplateResponseDocumentStaticFieldBase = templateResponseDocumentStaticFieldBase,
            TemplateResponseDocumentStaticFieldHyperlinkProperties = templateResponseDocumentStaticFieldHyperlinkProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentStaticFieldHyperlink value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldHyperlinkProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
