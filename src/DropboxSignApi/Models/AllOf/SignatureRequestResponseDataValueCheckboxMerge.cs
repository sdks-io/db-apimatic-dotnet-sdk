using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseDataBase, SignatureRequestResponseDataValueCheckboxMerge.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseDataValueCheckboxMergeConverter))]
public record SignatureRequestResponseDataValueCheckboxMerge
{
    public required SignatureRequestResponseDataBase SignatureRequestResponseDataBase { get; init; }

    public required SignatureRequestResponseDataValueCheckboxMergeProperties SignatureRequestResponseDataValueCheckboxMergeProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseDataBase signatureRequestResponseDataBase,
        out SignatureRequestResponseDataValueCheckboxMergeProperties signatureRequestResponseDataValueCheckboxMergeProperties)
    {
        signatureRequestResponseDataBase = SignatureRequestResponseDataBase;
        signatureRequestResponseDataValueCheckboxMergeProperties =
            SignatureRequestResponseDataValueCheckboxMergeProperties;
    }

    public static implicit operator SignatureRequestResponseDataBase(SignatureRequestResponseDataValueCheckboxMerge value) =>
        value.SignatureRequestResponseDataBase;

    public static implicit operator SignatureRequestResponseDataValueCheckboxMergeProperties(SignatureRequestResponseDataValueCheckboxMerge value) =>
        value.SignatureRequestResponseDataValueCheckboxMergeProperties;
}

file class SignatureRequestResponseDataValueCheckboxMergeConverter : JsonConverter<SignatureRequestResponseDataValueCheckboxMerge>
{
    public override SignatureRequestResponseDataValueCheckboxMerge Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseDataBase = root.Deserialize<SignatureRequestResponseDataBase>(options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataBase");
        var signatureRequestResponseDataValueCheckboxMergeProperties = root.Deserialize<SignatureRequestResponseDataValueCheckboxMergeProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataValueCheckboxMergeProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseDataBase.AdditionalProperties,
                signatureRequestResponseDataValueCheckboxMergeProperties.AdditionalProperties);
        signatureRequestResponseDataBase.AdditionalProperties.Clear();
        signatureRequestResponseDataValueCheckboxMergeProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseDataValueCheckboxMerge
        {
            SignatureRequestResponseDataBase = signatureRequestResponseDataBase,
            SignatureRequestResponseDataValueCheckboxMergeProperties = signatureRequestResponseDataValueCheckboxMergeProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseDataValueCheckboxMerge value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataValueCheckboxMergeProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
