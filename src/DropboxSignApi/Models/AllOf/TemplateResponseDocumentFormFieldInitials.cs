using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentFormFieldBase, TemplateResponseDocumentFormFieldInitials.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentFormFieldInitialsConverter))]
public record TemplateResponseDocumentFormFieldInitials
{
    public required TemplateResponseDocumentFormFieldBase TemplateResponseDocumentFormFieldBase { get; init; }

    public required TemplateResponseDocumentFormFieldInitialsProperties TemplateResponseDocumentFormFieldInitialsProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentFormFieldBase templateResponseDocumentFormFieldBase,
        out TemplateResponseDocumentFormFieldInitialsProperties templateResponseDocumentFormFieldInitialsProperties)
    {
        templateResponseDocumentFormFieldBase = TemplateResponseDocumentFormFieldBase;
        templateResponseDocumentFormFieldInitialsProperties = TemplateResponseDocumentFormFieldInitialsProperties;
    }

    public static implicit operator TemplateResponseDocumentFormFieldBase(TemplateResponseDocumentFormFieldInitials value) =>
        value.TemplateResponseDocumentFormFieldBase;

    public static implicit operator TemplateResponseDocumentFormFieldInitialsProperties(TemplateResponseDocumentFormFieldInitials value) =>
        value.TemplateResponseDocumentFormFieldInitialsProperties;
}

file class TemplateResponseDocumentFormFieldInitialsConverter : JsonConverter<TemplateResponseDocumentFormFieldInitials>
{
    public override TemplateResponseDocumentFormFieldInitials Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentFormFieldBase = root.Deserialize<TemplateResponseDocumentFormFieldBase>(options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldBase");
        var templateResponseDocumentFormFieldInitialsProperties = root.Deserialize<TemplateResponseDocumentFormFieldInitialsProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldInitialsProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentFormFieldBase.AdditionalProperties,
                templateResponseDocumentFormFieldInitialsProperties.AdditionalProperties);
        templateResponseDocumentFormFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentFormFieldInitialsProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentFormFieldInitials
        {
            TemplateResponseDocumentFormFieldBase = templateResponseDocumentFormFieldBase,
            TemplateResponseDocumentFormFieldInitialsProperties = templateResponseDocumentFormFieldInitialsProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentFormFieldInitials value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldInitialsProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
