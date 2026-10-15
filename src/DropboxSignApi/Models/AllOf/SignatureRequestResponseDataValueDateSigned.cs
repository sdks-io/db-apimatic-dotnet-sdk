using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseDataBase, SignatureRequestResponseDataValueDateSigned.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseDataValueDateSignedConverter))]
public record SignatureRequestResponseDataValueDateSigned
{
    public required SignatureRequestResponseDataBase SignatureRequestResponseDataBase { get; init; }

    public required SignatureRequestResponseDataValueDateSignedProperties SignatureRequestResponseDataValueDateSignedProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseDataBase signatureRequestResponseDataBase,
        out SignatureRequestResponseDataValueDateSignedProperties signatureRequestResponseDataValueDateSignedProperties)
    {
        signatureRequestResponseDataBase = SignatureRequestResponseDataBase;
        signatureRequestResponseDataValueDateSignedProperties = SignatureRequestResponseDataValueDateSignedProperties;
    }

    public static implicit operator SignatureRequestResponseDataBase(SignatureRequestResponseDataValueDateSigned value) =>
        value.SignatureRequestResponseDataBase;

    public static implicit operator SignatureRequestResponseDataValueDateSignedProperties(SignatureRequestResponseDataValueDateSigned value) =>
        value.SignatureRequestResponseDataValueDateSignedProperties;
}

file class SignatureRequestResponseDataValueDateSignedConverter : JsonConverter<SignatureRequestResponseDataValueDateSigned>
{
    public override SignatureRequestResponseDataValueDateSigned Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseDataBase = root.Deserialize<SignatureRequestResponseDataBase>(options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataBase");
        var signatureRequestResponseDataValueDateSignedProperties = root.Deserialize<SignatureRequestResponseDataValueDateSignedProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataValueDateSignedProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseDataBase.AdditionalProperties,
                signatureRequestResponseDataValueDateSignedProperties.AdditionalProperties);
        signatureRequestResponseDataBase.AdditionalProperties.Clear();
        signatureRequestResponseDataValueDateSignedProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseDataValueDateSigned
        {
            SignatureRequestResponseDataBase = signatureRequestResponseDataBase,
            SignatureRequestResponseDataValueDateSignedProperties = signatureRequestResponseDataValueDateSignedProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseDataValueDateSigned value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataValueDateSignedProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
