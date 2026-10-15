using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;

namespace DropboxSignApi.Models.AnyOf;

/// <summary>
/// The field detection method to use. Set to <c>annotations</c> to detect PDF form annotations or <c>text_tags</c> to detect Dropbox Sign text tags.
/// </summary>
[JsonConverter(typeof(DetectionModeConverter))]
public record DetectionMode
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<string> _string2Value;

    private DetectionMode(Optional<string> stringValue, Optional<string> string2Value)
    {
        _stringValue = stringValue;
        _string2Value = string2Value;
    }

    public static DetectionMode String(string value) => new(Optional<string>.Some(value), default);

    public static DetectionMode String2(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetString2(out string value) => _string2Value.TryGetValue(out value);
}

file sealed class DetectionModeConverter : JsonConverter<DetectionMode>
{
    public override DetectionMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            if (value.MatchesPattern("^annotations$"))
            {
                return DetectionMode.String(value);
            }
            if (value.MatchesPattern("^text_tags$"))
            {
                return DetectionMode.String2(value);
            }
        }
        throw new JsonException($"JSON does not match string or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DetectionMode value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(DetectionMode)} contains no valid value to serialize.");
        }
    }
}
