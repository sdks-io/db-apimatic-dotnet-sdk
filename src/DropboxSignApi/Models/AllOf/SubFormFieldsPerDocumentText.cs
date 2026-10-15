using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SubFormFieldsPerDocumentBase, SubFormFieldsPerDocumentText.
/// </summary>
[JsonConverter(typeof(SubFormFieldsPerDocumentTextConverter))]
public record SubFormFieldsPerDocumentText
{
    public required SubFormFieldsPerDocumentBase SubFormFieldsPerDocumentBase { get; init; }

    public required SubFormFieldsPerDocumentTextProperties SubFormFieldsPerDocumentTextProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SubFormFieldsPerDocumentBase subFormFieldsPerDocumentBase,
        out SubFormFieldsPerDocumentTextProperties subFormFieldsPerDocumentTextProperties)
    {
        subFormFieldsPerDocumentBase = SubFormFieldsPerDocumentBase;
        subFormFieldsPerDocumentTextProperties = SubFormFieldsPerDocumentTextProperties;
    }

    public static implicit operator SubFormFieldsPerDocumentBase(SubFormFieldsPerDocumentText value) =>
        value.SubFormFieldsPerDocumentBase;

    public static implicit operator SubFormFieldsPerDocumentTextProperties(SubFormFieldsPerDocumentText value) =>
        value.SubFormFieldsPerDocumentTextProperties;
}

file class SubFormFieldsPerDocumentTextConverter : JsonConverter<SubFormFieldsPerDocumentText>
{
    public override SubFormFieldsPerDocumentText Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var subFormFieldsPerDocumentBase = root.Deserialize<SubFormFieldsPerDocumentBase>(options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentBase");
        var subFormFieldsPerDocumentTextProperties = root.Deserialize<SubFormFieldsPerDocumentTextProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentTextProperties");
        var extras =
            AdditionalProperties.SharedBy(
                subFormFieldsPerDocumentBase.AdditionalProperties,
                subFormFieldsPerDocumentTextProperties.AdditionalProperties);
        subFormFieldsPerDocumentBase.AdditionalProperties.Clear();
        subFormFieldsPerDocumentTextProperties.AdditionalProperties.Clear();
        return new SubFormFieldsPerDocumentText
        {
            SubFormFieldsPerDocumentBase = subFormFieldsPerDocumentBase,
            SubFormFieldsPerDocumentTextProperties = subFormFieldsPerDocumentTextProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer, SubFormFieldsPerDocumentText value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentBase, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentTextProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
