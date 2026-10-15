using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseDataBase, SignatureRequestResponseDataValueCheckbox.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseDataValueCheckboxConverter))]
public record SignatureRequestResponseDataValueCheckbox
{
    public required SignatureRequestResponseDataBase SignatureRequestResponseDataBase { get; init; }

    public required SignatureRequestResponseDataValueCheckboxProperties SignatureRequestResponseDataValueCheckboxProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseDataBase signatureRequestResponseDataBase,
        out SignatureRequestResponseDataValueCheckboxProperties signatureRequestResponseDataValueCheckboxProperties)
    {
        signatureRequestResponseDataBase = SignatureRequestResponseDataBase;
        signatureRequestResponseDataValueCheckboxProperties = SignatureRequestResponseDataValueCheckboxProperties;
    }

    public static implicit operator SignatureRequestResponseDataBase(SignatureRequestResponseDataValueCheckbox value) =>
        value.SignatureRequestResponseDataBase;

    public static implicit operator SignatureRequestResponseDataValueCheckboxProperties(SignatureRequestResponseDataValueCheckbox value) =>
        value.SignatureRequestResponseDataValueCheckboxProperties;
}

file class SignatureRequestResponseDataValueCheckboxConverter : JsonConverter<SignatureRequestResponseDataValueCheckbox>
{
    public override SignatureRequestResponseDataValueCheckbox Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseDataBase = root.Deserialize<SignatureRequestResponseDataBase>(options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataBase");
        var signatureRequestResponseDataValueCheckboxProperties = root.Deserialize<SignatureRequestResponseDataValueCheckboxProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseDataValueCheckboxProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseDataBase.AdditionalProperties,
                signatureRequestResponseDataValueCheckboxProperties.AdditionalProperties);
        signatureRequestResponseDataBase.AdditionalProperties.Clear();
        signatureRequestResponseDataValueCheckboxProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseDataValueCheckbox
        {
            SignatureRequestResponseDataBase = signatureRequestResponseDataBase,
            SignatureRequestResponseDataValueCheckboxProperties = signatureRequestResponseDataValueCheckboxProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseDataValueCheckbox value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseDataValueCheckboxProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
