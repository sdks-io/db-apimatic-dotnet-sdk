using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseDataBase, SignatureRequestResponseDataValueTextMerge.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseDataValueTextMergeConverter))]
public record SignatureRequestResponseDataValueTextMerge
{
    public required SignatureRequestResponseDataBase SignatureRequestResponseDataBase { get; init; }

    public required SignatureRequestResponseDataValueTextMergeProperties SignatureRequestResponseDataValueTextMergeProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseDataBase signatureRequestResponseDataBase,
        out SignatureRequestResponseDataValueTextMergeProperties signatureRequestResponseDataValueTextMergeProperties)
    {
        signatureRequestResponseDataBase = SignatureRequestResponseDataBase;
        signatureRequestResponseDataValueTextMergeProperties = SignatureRequestResponseDataValueTextMergeProperties;
    }

    public static implicit operator SignatureRequestResponseDataBase(SignatureRequestResponseDataValueTextMerge value) =>
        value.SignatureRequestResponseDataBase;

    public static implicit operator SignatureRequestResponseDataValueTextMergeProperties(SignatureRequestResponseDataValueTextMerge value) =>
        value.SignatureRequestResponseDataValueTextMergeProperties;
}

file class SignatureRequestResponseDataValueTextMergeConverter : JsonConverter<SignatureRequestResponseDataValueTextMerge>
{
    public override SignatureRequestResponseDataValueTextMerge Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseDataBase = root.Deserialize<SignatureRequestResponseDataBase>(options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataBase");
        var signatureRequestResponseDataValueTextMergeProperties = root.Deserialize<SignatureRequestResponseDataValueTextMergeProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataValueTextMergeProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseDataBase.AdditionalProperties,
                signatureRequestResponseDataValueTextMergeProperties.AdditionalProperties);
        signatureRequestResponseDataBase.AdditionalProperties.Clear();
        signatureRequestResponseDataValueTextMergeProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseDataValueTextMerge
        {
            SignatureRequestResponseDataBase = signatureRequestResponseDataBase,
            SignatureRequestResponseDataValueTextMergeProperties = signatureRequestResponseDataValueTextMergeProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseDataValueTextMerge value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataValueTextMergeProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
