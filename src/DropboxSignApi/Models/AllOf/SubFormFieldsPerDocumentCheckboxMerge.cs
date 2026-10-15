using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SubFormFieldsPerDocumentBase, SubFormFieldsPerDocumentCheckboxMerge.
/// </summary>
[JsonConverter(typeof(SubFormFieldsPerDocumentCheckboxMergeConverter))]
public record SubFormFieldsPerDocumentCheckboxMerge
{
    public required SubFormFieldsPerDocumentBase SubFormFieldsPerDocumentBase { get; init; }

    public required SubFormFieldsPerDocumentCheckboxMergeProperties SubFormFieldsPerDocumentCheckboxMergeProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SubFormFieldsPerDocumentBase subFormFieldsPerDocumentBase,
        out SubFormFieldsPerDocumentCheckboxMergeProperties subFormFieldsPerDocumentCheckboxMergeProperties)
    {
        subFormFieldsPerDocumentBase = SubFormFieldsPerDocumentBase;
        subFormFieldsPerDocumentCheckboxMergeProperties = SubFormFieldsPerDocumentCheckboxMergeProperties;
    }

    public static implicit operator SubFormFieldsPerDocumentBase(SubFormFieldsPerDocumentCheckboxMerge value) =>
        value.SubFormFieldsPerDocumentBase;

    public static implicit operator SubFormFieldsPerDocumentCheckboxMergeProperties(SubFormFieldsPerDocumentCheckboxMerge value) =>
        value.SubFormFieldsPerDocumentCheckboxMergeProperties;
}

file class SubFormFieldsPerDocumentCheckboxMergeConverter : JsonConverter<SubFormFieldsPerDocumentCheckboxMerge>
{
    public override SubFormFieldsPerDocumentCheckboxMerge Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var subFormFieldsPerDocumentBase = root.Deserialize<SubFormFieldsPerDocumentBase>(options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentBase");
        var subFormFieldsPerDocumentCheckboxMergeProperties = root.Deserialize<SubFormFieldsPerDocumentCheckboxMergeProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentCheckboxMergeProperties");
        var extras =
            AdditionalProperties.SharedBy(
                subFormFieldsPerDocumentBase.AdditionalProperties,
                subFormFieldsPerDocumentCheckboxMergeProperties.AdditionalProperties);
        subFormFieldsPerDocumentBase.AdditionalProperties.Clear();
        subFormFieldsPerDocumentCheckboxMergeProperties.AdditionalProperties.Clear();
        return new SubFormFieldsPerDocumentCheckboxMerge
        {
            SubFormFieldsPerDocumentBase = subFormFieldsPerDocumentBase,
            SubFormFieldsPerDocumentCheckboxMergeProperties = subFormFieldsPerDocumentCheckboxMergeProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SubFormFieldsPerDocumentCheckboxMerge value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentBase, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentCheckboxMergeProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
