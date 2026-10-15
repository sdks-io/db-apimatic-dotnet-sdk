using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseDataBase, SignatureRequestResponseDataValueRadio.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseDataValueRadioConverter))]
public record SignatureRequestResponseDataValueRadio
{
    public required SignatureRequestResponseDataBase SignatureRequestResponseDataBase { get; init; }

    public required SignatureRequestResponseDataValueRadioProperties SignatureRequestResponseDataValueRadioProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseDataBase signatureRequestResponseDataBase,
        out SignatureRequestResponseDataValueRadioProperties signatureRequestResponseDataValueRadioProperties)
    {
        signatureRequestResponseDataBase = SignatureRequestResponseDataBase;
        signatureRequestResponseDataValueRadioProperties = SignatureRequestResponseDataValueRadioProperties;
    }

    public static implicit operator SignatureRequestResponseDataBase(SignatureRequestResponseDataValueRadio value) =>
        value.SignatureRequestResponseDataBase;

    public static implicit operator SignatureRequestResponseDataValueRadioProperties(SignatureRequestResponseDataValueRadio value) =>
        value.SignatureRequestResponseDataValueRadioProperties;
}

file class SignatureRequestResponseDataValueRadioConverter : JsonConverter<SignatureRequestResponseDataValueRadio>
{
    public override SignatureRequestResponseDataValueRadio Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseDataBase = root.Deserialize<SignatureRequestResponseDataBase>(options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataBase");
        var signatureRequestResponseDataValueRadioProperties = root.Deserialize<SignatureRequestResponseDataValueRadioProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataValueRadioProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseDataBase.AdditionalProperties,
                signatureRequestResponseDataValueRadioProperties.AdditionalProperties);
        signatureRequestResponseDataBase.AdditionalProperties.Clear();
        signatureRequestResponseDataValueRadioProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseDataValueRadio
        {
            SignatureRequestResponseDataBase = signatureRequestResponseDataBase,
            SignatureRequestResponseDataValueRadioProperties = signatureRequestResponseDataValueRadioProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseDataValueRadio value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataValueRadioProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
