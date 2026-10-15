using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of TemplateResponseDocumentFormFieldBase, TemplateResponseDocumentFormFieldCheckbox.
/// </summary>
[JsonConverter(typeof(TemplateResponseDocumentFormFieldCheckboxConverter))]
public record TemplateResponseDocumentFormFieldCheckbox
{
    public required TemplateResponseDocumentFormFieldBase TemplateResponseDocumentFormFieldBase { get; init; }

    public required TemplateResponseDocumentFormFieldCheckboxProperties TemplateResponseDocumentFormFieldCheckboxProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out TemplateResponseDocumentFormFieldBase templateResponseDocumentFormFieldBase,
        out TemplateResponseDocumentFormFieldCheckboxProperties templateResponseDocumentFormFieldCheckboxProperties)
    {
        templateResponseDocumentFormFieldBase = TemplateResponseDocumentFormFieldBase;
        templateResponseDocumentFormFieldCheckboxProperties = TemplateResponseDocumentFormFieldCheckboxProperties;
    }

    public static implicit operator TemplateResponseDocumentFormFieldBase(TemplateResponseDocumentFormFieldCheckbox value) =>
        value.TemplateResponseDocumentFormFieldBase;

    public static implicit operator TemplateResponseDocumentFormFieldCheckboxProperties(TemplateResponseDocumentFormFieldCheckbox value) =>
        value.TemplateResponseDocumentFormFieldCheckboxProperties;
}

file class TemplateResponseDocumentFormFieldCheckboxConverter : JsonConverter<TemplateResponseDocumentFormFieldCheckbox>
{
    public override TemplateResponseDocumentFormFieldCheckbox Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var templateResponseDocumentFormFieldBase = root.Deserialize<TemplateResponseDocumentFormFieldBase>(options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldBase");
        var templateResponseDocumentFormFieldCheckboxProperties = root.Deserialize<TemplateResponseDocumentFormFieldCheckboxProperties>(
            options) ??
            throw new JsonException("Failed to deserialize TemplateResponseDocumentFormFieldCheckboxProperties");
        var extras =
            AdditionalProperties.SharedBy(
                templateResponseDocumentFormFieldBase.AdditionalProperties,
                templateResponseDocumentFormFieldCheckboxProperties.AdditionalProperties);
        templateResponseDocumentFormFieldBase.AdditionalProperties.Clear();
        templateResponseDocumentFormFieldCheckboxProperties.AdditionalProperties.Clear();
        return new TemplateResponseDocumentFormFieldCheckbox
        {
            TemplateResponseDocumentFormFieldBase = templateResponseDocumentFormFieldBase,
            TemplateResponseDocumentFormFieldCheckboxProperties = templateResponseDocumentFormFieldCheckboxProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        TemplateResponseDocumentFormFieldCheckbox value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.TemplateResponseDocumentFormFieldCheckboxProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
