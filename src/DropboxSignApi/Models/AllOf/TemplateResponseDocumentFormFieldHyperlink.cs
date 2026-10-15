using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentFormFieldBase, TemplateResponseDocumentFormFieldHyperlink.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentFormFieldHyperlinkConverter))]
public record TemplateResponseDocumentFormFieldHyperlink
{
    public required TemplateResponseDocumentFormFieldBase TemplateResponseDocumentFormFieldBase { get; init; }

    public required TemplateResponseDocumentFormFieldHyperlinkProperties TemplateResponseDocumentFormFieldHyperlinkProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentFormFieldBase templateResponseDocumentFormFieldBase,
        out TemplateResponseDocumentFormFieldHyperlinkProperties templateResponseDocumentFormFieldHyperlinkProperties)
    {
        templateResponseDocumentFormFieldBase = TemplateResponseDocumentFormFieldBase;
        templateResponseDocumentFormFieldHyperlinkProperties = TemplateResponseDocumentFormFieldHyperlinkProperties;
    }

    public static implicit operator TemplateResponseDocumentFormFieldBase(TemplateResponseDocumentFormFieldHyperlink value) =>
        value.TemplateResponseDocumentFormFieldBase;

    public static implicit operator TemplateResponseDocumentFormFieldHyperlinkProperties(TemplateResponseDocumentFormFieldHyperlink value) =>
        value.TemplateResponseDocumentFormFieldHyperlinkProperties;
}

file class TemplateResponseDocumentFormFieldHyperlinkConverter : JsonConverter<TemplateResponseDocumentFormFieldHyperlink>
{
    public override TemplateResponseDocumentFormFieldHyperlink Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentFormFieldBase = root.Deserialize<TemplateResponseDocumentFormFieldBase>(options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldBase");
        var templateResponseDocumentFormFieldHyperlinkProperties = root.Deserialize<TemplateResponseDocumentFormFieldHyperlinkProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldHyperlinkProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentFormFieldBase.AdditionalProperties,
                templateResponseDocumentFormFieldHyperlinkProperties.AdditionalProperties);
        templateResponseDocumentFormFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentFormFieldHyperlinkProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentFormFieldHyperlink
        {
            TemplateResponseDocumentFormFieldBase = templateResponseDocumentFormFieldBase,
            TemplateResponseDocumentFormFieldHyperlinkProperties = templateResponseDocumentFormFieldHyperlinkProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentFormFieldHyperlink value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldHyperlinkProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
