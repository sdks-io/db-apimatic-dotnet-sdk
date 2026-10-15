using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SubFormFieldsPerDocumentBase, SubFormFieldsPerDocumentHyperlink.
/// </summary>
[JsonConverter(typeof(SubFormFieldsPerDocumentHyperlinkConverter))]
public record SubFormFieldsPerDocumentHyperlink
{
    public required SubFormFieldsPerDocumentBase SubFormFieldsPerDocumentBase { get; init; }

    public required SubFormFieldsPerDocumentHyperlinkProperties SubFormFieldsPerDocumentHyperlinkProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SubFormFieldsPerDocumentBase subFormFieldsPerDocumentBase,
        out SubFormFieldsPerDocumentHyperlinkProperties subFormFieldsPerDocumentHyperlinkProperties)
    {
        subFormFieldsPerDocumentBase = SubFormFieldsPerDocumentBase;
        subFormFieldsPerDocumentHyperlinkProperties = SubFormFieldsPerDocumentHyperlinkProperties;
    }

    public static implicit operator SubFormFieldsPerDocumentBase(SubFormFieldsPerDocumentHyperlink value) =>
        value.SubFormFieldsPerDocumentBase;

    public static implicit operator SubFormFieldsPerDocumentHyperlinkProperties(SubFormFieldsPerDocumentHyperlink value) =>
        value.SubFormFieldsPerDocumentHyperlinkProperties;
}

file class SubFormFieldsPerDocumentHyperlinkConverter : JsonConverter<SubFormFieldsPerDocumentHyperlink>
{
    public override SubFormFieldsPerDocumentHyperlink Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var subFormFieldsPerDocumentBase = root.Deserialize<SubFormFieldsPerDocumentBase>(options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentBase");
        var subFormFieldsPerDocumentHyperlinkProperties = root.Deserialize<SubFormFieldsPerDocumentHyperlinkProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SubFormFieldsPerDocumentHyperlinkProperties");
        var extras =
            AdditionalProperties.SharedBy(
                subFormFieldsPerDocumentBase.AdditionalProperties,
                subFormFieldsPerDocumentHyperlinkProperties.AdditionalProperties);
        subFormFieldsPerDocumentBase.AdditionalProperties.Clear();
        subFormFieldsPerDocumentHyperlinkProperties.AdditionalProperties.Clear();
        return new SubFormFieldsPerDocumentHyperlink
        {
            SubFormFieldsPerDocumentBase = subFormFieldsPerDocumentBase,
            SubFormFieldsPerDocumentHyperlinkProperties = subFormFieldsPerDocumentHyperlinkProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SubFormFieldsPerDocumentHyperlink value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentBase, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SubFormFieldsPerDocumentHyperlinkProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
