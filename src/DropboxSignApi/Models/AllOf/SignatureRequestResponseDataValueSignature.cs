using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseDataBase, SignatureRequestResponseDataValueSignature.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseDataValueSignatureConverter))]
public record SignatureRequestResponseDataValueSignature
{
    public required SignatureRequestResponseDataBase SignatureRequestResponseDataBase { get; init; }

    public required SignatureRequestResponseDataValueSignatureProperties SignatureRequestResponseDataValueSignatureProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseDataBase signatureRequestResponseDataBase,
        out SignatureRequestResponseDataValueSignatureProperties signatureRequestResponseDataValueSignatureProperties)
    {
        signatureRequestResponseDataBase = SignatureRequestResponseDataBase;
        signatureRequestResponseDataValueSignatureProperties = SignatureRequestResponseDataValueSignatureProperties;
    }

    public static implicit operator SignatureRequestResponseDataBase(SignatureRequestResponseDataValueSignature value) =>
        value.SignatureRequestResponseDataBase;

    public static implicit operator SignatureRequestResponseDataValueSignatureProperties(SignatureRequestResponseDataValueSignature value) =>
        value.SignatureRequestResponseDataValueSignatureProperties;
}

file class SignatureRequestResponseDataValueSignatureConverter : JsonConverter<SignatureRequestResponseDataValueSignature>
{
    public override SignatureRequestResponseDataValueSignature Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseDataBase = root.Deserialize<SignatureRequestResponseDataBase>(options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataBase");
        var signatureRequestResponseDataValueSignatureProperties = root.Deserialize<SignatureRequestResponseDataValueSignatureProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataValueSignatureProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseDataBase.AdditionalProperties,
                signatureRequestResponseDataValueSignatureProperties.AdditionalProperties);
        signatureRequestResponseDataBase.AdditionalProperties.Clear();
        signatureRequestResponseDataValueSignatureProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseDataValueSignature
        {
            SignatureRequestResponseDataBase = signatureRequestResponseDataBase,
            SignatureRequestResponseDataValueSignatureProperties = signatureRequestResponseDataValueSignatureProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseDataValueSignature value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataValueSignatureProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
