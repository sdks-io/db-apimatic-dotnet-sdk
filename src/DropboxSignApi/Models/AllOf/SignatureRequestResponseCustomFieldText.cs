using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseCustomFieldBase, SignatureRequestResponseCustomFieldText.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseCustomFieldTextConverter))]
public record SignatureRequestResponseCustomFieldText
{
    public required SignatureRequestResponseCustomFieldBase SignatureRequestResponseCustomFieldBase { get; init; }

    public required SignatureRequestResponseCustomFieldTextProperties SignatureRequestResponseCustomFieldTextProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseCustomFieldBase signatureRequestResponseCustomFieldBase,
        out SignatureRequestResponseCustomFieldTextProperties signatureRequestResponseCustomFieldTextProperties)
    {
        signatureRequestResponseCustomFieldBase = SignatureRequestResponseCustomFieldBase;
        signatureRequestResponseCustomFieldTextProperties = SignatureRequestResponseCustomFieldTextProperties;
    }

    public static implicit operator SignatureRequestResponseCustomFieldBase(SignatureRequestResponseCustomFieldText value) =>
        value.SignatureRequestResponseCustomFieldBase;

    public static implicit operator SignatureRequestResponseCustomFieldTextProperties(SignatureRequestResponseCustomFieldText value) =>
        value.SignatureRequestResponseCustomFieldTextProperties;
}

file class SignatureRequestResponseCustomFieldTextConverter : JsonConverter<SignatureRequestResponseCustomFieldText>
{
    public override SignatureRequestResponseCustomFieldText Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseCustomFieldBase = root.Deserialize<SignatureRequestResponseCustomFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseCustomFieldBase");
        var signatureRequestResponseCustomFieldTextProperties = root.Deserialize<SignatureRequestResponseCustomFieldTextProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseCustomFieldTextProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseCustomFieldBase.AdditionalProperties,
                signatureRequestResponseCustomFieldTextProperties.AdditionalProperties);
        signatureRequestResponseCustomFieldBase.AdditionalProperties.Clear();
        signatureRequestResponseCustomFieldTextProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseCustomFieldText
        {
            SignatureRequestResponseCustomFieldBase = signatureRequestResponseCustomFieldBase,
            SignatureRequestResponseCustomFieldTextProperties = signatureRequestResponseCustomFieldTextProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseCustomFieldText value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseCustomFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseCustomFieldTextProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
