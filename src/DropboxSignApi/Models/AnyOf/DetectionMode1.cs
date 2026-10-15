using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;

namespace DropboxSignApi.Models.AnyOf;

/// <summary>
/// The field detection method used to analyze the document: <c>annotations</c> or <c>text_tags</c>.
/// </summary>
[JsonConverter(typeof(DetectionMode1Converter))]
public record DetectionMode1
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<string> _string2Value;

    private DetectionMode1(Optional<string> stringValue, Optional<string> string2Value)
    {
        _stringValue = stringValue;
        _string2Value = string2Value;
    }

    public static DetectionMode1 String(string value) => new(Optional<string>.Some(value), default);

    public static DetectionMode1 String2(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetString2(out string value) => _string2Value.TryGetValue(out value);
}

file sealed class DetectionMode1Converter : JsonConverter<DetectionMode1>
{
    public override DetectionMode1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            if (value.MatchesPattern("^annotations$"))
            {
                return DetectionMode1.String(value);
            }
            if (value.MatchesPattern("^text_tags$"))
            {
                return DetectionMode1.String2(value);
            }
        }
        throw new JsonException($"JSON does not match string or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DetectionMode1 value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetString2(out var string2Value))
        {
            JsonSerializer.Serialize(writer, string2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DetectionMode1)} contains no valid value to serialize.");
        }
    }
}
