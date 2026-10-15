using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseDataBase, SignatureRequestResponseDataValueText.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseDataValueTextConverter))]
public record SignatureRequestResponseDataValueText
{
    public required SignatureRequestResponseDataBase SignatureRequestResponseDataBase { get; init; }

    public required SignatureRequestResponseDataValueTextProperties SignatureRequestResponseDataValueTextProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseDataBase signatureRequestResponseDataBase,
        out SignatureRequestResponseDataValueTextProperties signatureRequestResponseDataValueTextProperties)
    {
        signatureRequestResponseDataBase = SignatureRequestResponseDataBase;
        signatureRequestResponseDataValueTextProperties = SignatureRequestResponseDataValueTextProperties;
    }

    public static implicit operator SignatureRequestResponseDataBase(SignatureRequestResponseDataValueText value) =>
        value.SignatureRequestResponseDataBase;

    public static implicit operator SignatureRequestResponseDataValueTextProperties(SignatureRequestResponseDataValueText value) =>
        value.SignatureRequestResponseDataValueTextProperties;
}

file class SignatureRequestResponseDataValueTextConverter : JsonConverter<SignatureRequestResponseDataValueText>
{
    public override SignatureRequestResponseDataValueText Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseDataBase = root.Deserialize<SignatureRequestResponseDataBase>(options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataBase");
        var signatureRequestResponseDataValueTextProperties = root.Deserialize<SignatureRequestResponseDataValueTextProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataValueTextProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseDataBase.AdditionalProperties,
                signatureRequestResponseDataValueTextProperties.AdditionalProperties);
        signatureRequestResponseDataBase.AdditionalProperties.Clear();
        signatureRequestResponseDataValueTextProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseDataValueText
        {
            SignatureRequestResponseDataBase = signatureRequestResponseDataBase,
            SignatureRequestResponseDataValueTextProperties = signatureRequestResponseDataValueTextProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseDataValueText value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataValueTextProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
