using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SubFormFieldsPerDocumentBase, SubFormFieldsPerDocumentTextMerge.
/// </summary>
[JsonConverter(typeof(SubFormFieldsPerDocumentTextMergeConverter))]
public record SubFormFieldsPerDocumentTextMerge
{
    public required SubFormFieldsPerDocumentBase SubFormFieldsPerDocumentBase { get; init; }

    public required SubFormFieldsPerDocumentTextMergeProperties SubFormFieldsPerDocumentTextMergeProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SubFormFieldsPerDocumentBase subFormFieldsPerDocumentBase,
        out SubFormFieldsPerDocumentTextMergeProperties subFormFieldsPerDocumentTextMergeProperties)
    {
        subFormFieldsPerDocumentBase = SubFormFieldsPerDocumentBase;
        subFormFieldsPerDocumentTextMergeProperties = SubFormFieldsPerDocumentTextMergeProperties;
    }

    public static implicit operator SubFormFieldsPerDocumentBase(SubFormFieldsPerDocumentTextMerge value) =>
        value.SubFormFieldsPerDocumentBase;

    public static implicit operator SubFormFieldsPerDocumentTextMergeProperties(SubFormFieldsPerDocumentTextMerge value) =>
        value.SubFormFieldsPerDocumentTextMergeProperties;
}

file class SubFormFieldsPerDocumentTextMergeConverter : JsonConverter<SubFormFieldsPerDocumentTextMerge>
{
    public override SubFormFieldsPerDocumentTextMerge Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var subFormFieldsPerDocumentBase = root.Deserialize<SubFormFieldsPerDocumentBase>(options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentBase");
        var subFormFieldsPerDocumentTextMergeProperties = root.Deserialize<SubFormFieldsPerDocumentTextMergeProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentTextMergeProperties");
        var extras =
            AdditionalProperties.SharedBy(
                subFormFieldsPerDocumentBase.AdditionalProperties,
                subFormFieldsPerDocumentTextMergeProperties.AdditionalProperties);
        subFormFieldsPerDocumentBase.AdditionalProperties.Clear();
        subFormFieldsPerDocumentTextMergeProperties.AdditionalProperties.Clear();
        return new SubFormFieldsPerDocumentTextMerge
        {
            SubFormFieldsPerDocumentBase = subFormFieldsPerDocumentBase,
            SubFormFieldsPerDocumentTextMergeProperties = subFormFieldsPerDocumentTextMergeProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SubFormFieldsPerDocumentTextMerge value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentBase, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentTextMergeProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
