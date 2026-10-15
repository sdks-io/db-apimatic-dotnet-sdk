using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentStaticFieldBase, TemplateResponseDocumentStaticFieldCheckbox.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentStaticFieldCheckboxConverter))]
public record TemplateResponseDocumentStaticFieldCheckbox
{
    public required TemplateResponseDocumentStaticFieldBase TemplateResponseDocumentStaticFieldBase { get; init; }

    public required TemplateResponseDocumentStaticFieldCheckboxProperties TemplateResponseDocumentStaticFieldCheckboxProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentStaticFieldBase templateResponseDocumentStaticFieldBase,
        out TemplateResponseDocumentStaticFieldCheckboxProperties templateResponseDocumentStaticFieldCheckboxProperties)
    {
        templateResponseDocumentStaticFieldBase = TemplateResponseDocumentStaticFieldBase;
        templateResponseDocumentStaticFieldCheckboxProperties = TemplateResponseDocumentStaticFieldCheckboxProperties;
    }

    public static implicit operator TemplateResponseDocumentStaticFieldBase(TemplateResponseDocumentStaticFieldCheckbox value) =>
        value.TemplateResponseDocumentStaticFieldBase;

    public static implicit operator TemplateResponseDocumentStaticFieldCheckboxProperties(TemplateResponseDocumentStaticFieldCheckbox value) =>
        value.TemplateResponseDocumentStaticFieldCheckboxProperties;
}

file class TemplateResponseDocumentStaticFieldCheckboxConverter : JsonConverter<TemplateResponseDocumentStaticFieldCheckbox>
{
    public override TemplateResponseDocumentStaticFieldCheckbox Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentStaticFieldBase = root.Deserialize<TemplateResponseDocumentStaticFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldBase");
        var templateResponseDocumentStaticFieldCheckboxProperties = root.Deserialize<TemplateResponseDocumentStaticFieldCheckboxProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentStaticFieldCheckboxProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentStaticFieldBase.AdditionalProperties,
                templateResponseDocumentStaticFieldCheckboxProperties.AdditionalProperties);
        templateResponseDocumentStaticFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentStaticFieldCheckboxProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentStaticFieldCheckbox
        {
            TemplateResponseDocumentStaticFieldBase = templateResponseDocumentStaticFieldBase,
            TemplateResponseDocumentStaticFieldCheckboxProperties = templateResponseDocumentStaticFieldCheckboxProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentStaticFieldCheckbox value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentStaticFieldCheckboxProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
