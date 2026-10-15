using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SubFormFieldsPerDocumentBase, SubFormFieldsPerDocumentRadio.
/// </summary>
[JsonConverter(typeof(SubFormFieldsPerDocumentRadioConverter))]
public record SubFormFieldsPerDocumentRadio
{
    public required SubFormFieldsPerDocumentBase SubFormFieldsPerDocumentBase { get; init; }

    public required SubFormFieldsPerDocumentRadioProperties SubFormFieldsPerDocumentRadioProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SubFormFieldsPerDocumentBase subFormFieldsPerDocumentBase,
        out SubFormFieldsPerDocumentRadioProperties subFormFieldsPerDocumentRadioProperties)
    {
        subFormFieldsPerDocumentBase = SubFormFieldsPerDocumentBase;
        subFormFieldsPerDocumentRadioProperties = SubFormFieldsPerDocumentRadioProperties;
    }

    public static implicit operator SubFormFieldsPerDocumentBase(SubFormFieldsPerDocumentRadio value) =>
        value.SubFormFieldsPerDocumentBase;

    public static implicit operator SubFormFieldsPerDocumentRadioProperties(SubFormFieldsPerDocumentRadio value) =>
        value.SubFormFieldsPerDocumentRadioProperties;
}

file class SubFormFieldsPerDocumentRadioConverter : JsonConverter<SubFormFieldsPerDocumentRadio>
{
    public override SubFormFieldsPerDocumentRadio Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var subFormFieldsPerDocumentBase = root.Deserialize<SubFormFieldsPerDocumentBase>(options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentBase");
        var subFormFieldsPerDocumentRadioProperties = root.Deserialize<SubFormFieldsPerDocumentRadioProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentRadioProperties");
        var extras =
            AdditionalProperties.SharedBy(
                subFormFieldsPerDocumentBase.AdditionalProperties,
                subFormFieldsPerDocumentRadioProperties.AdditionalProperties);
        subFormFieldsPerDocumentBase.AdditionalProperties.Clear();
        subFormFieldsPerDocumentRadioProperties.AdditionalProperties.Clear();
        return new SubFormFieldsPerDocumentRadio
        {
            SubFormFieldsPerDocumentBase = subFormFieldsPerDocumentBase,
            SubFormFieldsPerDocumentRadioProperties = subFormFieldsPerDocumentRadioProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SubFormFieldsPerDocumentRadio value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentBase, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentRadioProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
