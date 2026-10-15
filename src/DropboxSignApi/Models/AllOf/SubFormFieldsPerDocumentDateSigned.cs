using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SubFormFieldsPerDocumentBase, SubFormFieldsPerDocumentDateSigned.
/// </summary>
[JsonConverter(typeof(SubFormFieldsPerDocumentDateSignedConverter))]
public record SubFormFieldsPerDocumentDateSigned
{
    public required SubFormFieldsPerDocumentBase SubFormFieldsPerDocumentBase { get; init; }

    public required SubFormFieldsPerDocumentDateSignedProperties SubFormFieldsPerDocumentDateSignedProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SubFormFieldsPerDocumentBase subFormFieldsPerDocumentBase,
        out SubFormFieldsPerDocumentDateSignedProperties subFormFieldsPerDocumentDateSignedProperties)
    {
        subFormFieldsPerDocumentBase = SubFormFieldsPerDocumentBase;
        subFormFieldsPerDocumentDateSignedProperties = SubFormFieldsPerDocumentDateSignedProperties;
    }

    public static implicit operator SubFormFieldsPerDocumentBase(SubFormFieldsPerDocumentDateSigned value) =>
        value.SubFormFieldsPerDocumentBase;

    public static implicit operator SubFormFieldsPerDocumentDateSignedProperties(SubFormFieldsPerDocumentDateSigned value) =>
        value.SubFormFieldsPerDocumentDateSignedProperties;
}

file class SubFormFieldsPerDocumentDateSignedConverter : JsonConverter<SubFormFieldsPerDocumentDateSigned>
{
    public override SubFormFieldsPerDocumentDateSigned Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var subFormFieldsPerDocumentBase = root.Deserialize<SubFormFieldsPerDocumentBase>(options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentBase");
        var subFormFieldsPerDocumentDateSignedProperties = root.Deserialize<SubFormFieldsPerDocumentDateSignedProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentDateSignedProperties");
        var extras =
            AdditionalProperties.SharedBy(
                subFormFieldsPerDocumentBase.AdditionalProperties,
                subFormFieldsPerDocumentDateSignedProperties.AdditionalProperties);
        subFormFieldsPerDocumentBase.AdditionalProperties.Clear();
        subFormFieldsPerDocumentDateSignedProperties.AdditionalProperties.Clear();
        return new SubFormFieldsPerDocumentDateSigned
        {
            SubFormFieldsPerDocumentBase = subFormFieldsPerDocumentBase,
            SubFormFieldsPerDocumentDateSignedProperties = subFormFieldsPerDocumentDateSignedProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SubFormFieldsPerDocumentDateSigned value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentBase, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentDateSignedProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
