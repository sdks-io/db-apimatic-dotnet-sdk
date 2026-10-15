using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AllOf;

/// <summary>
/// All Of SignatureRequestResponseCustomFieldBase, SignatureRequestResponseCustomFieldCheckbox.
/// </summary>
[JsonConverter(typeof(SignatureRequestResponseCustomFieldCheckboxConverter))]
public record SignatureRequestResponseCustomFieldCheckbox
{
    public required SignatureRequestResponseCustomFieldBase SignatureRequestResponseCustomFieldBase { get; init; }

    public required SignatureRequestResponseCustomFieldCheckboxProperties SignatureRequestResponseCustomFieldCheckboxProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out SignatureRequestResponseCustomFieldBase signatureRequestResponseCustomFieldBase,
        out SignatureRequestResponseCustomFieldCheckboxProperties signatureRequestResponseCustomFieldCheckboxProperties)
    {
        signatureRequestResponseCustomFieldBase = SignatureRequestResponseCustomFieldBase;
        signatureRequestResponseCustomFieldCheckboxProperties = SignatureRequestResponseCustomFieldCheckboxProperties;
    }

    public static implicit operator SignatureRequestResponseCustomFieldBase(SignatureRequestResponseCustomFieldCheckbox value) =>
        value.SignatureRequestResponseCustomFieldBase;

    public static implicit operator SignatureRequestResponseCustomFieldCheckboxProperties(SignatureRequestResponseCustomFieldCheckbox value) =>
        value.SignatureRequestResponseCustomFieldCheckboxProperties;
}

file class SignatureRequestResponseCustomFieldCheckboxConverter : JsonConverter<SignatureRequestResponseCustomFieldCheckbox>
{
    public override SignatureRequestResponseCustomFieldCheckbox Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var signatureRequestResponseCustomFieldBase = root.Deserialize<SignatureRequestResponseCustomFieldBase>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseCustomFieldBase");
        var signatureRequestResponseCustomFieldCheckboxProperties = root.Deserialize<SignatureRequestResponseCustomFieldCheckboxProperties>(
            options) ??
            throw new JsonException("Failed to deserialize SignatureRequestResponseCustomFieldCheckboxProperties");
        var extras =
            AdditionalProperties.SharedBy(
                signatureRequestResponseCustomFieldBase.AdditionalProperties,
                signatureRequestResponseCustomFieldCheckboxProperties.AdditionalProperties);
        signatureRequestResponseCustomFieldBase.AdditionalProperties.Clear();
        signatureRequestResponseCustomFieldCheckboxProperties.AdditionalProperties.Clear();
        return new SignatureRequestResponseCustomFieldCheckbox
        {
            SignatureRequestResponseCustomFieldBase = signatureRequestResponseCustomFieldBase,
            SignatureRequestResponseCustomFieldCheckboxProperties = signatureRequestResponseCustomFieldCheckboxProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SignatureRequestResponseCustomFieldCheckbox value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseCustomFieldBase, options),
            written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.SignatureRequestResponseCustomFieldCheckboxProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
