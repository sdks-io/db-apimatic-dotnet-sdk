using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// The default type shown (limited to the listed types)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DefaultType>))]
public sealed record DefaultType : OpenStringEnum<DefaultType>
{
    private DefaultType(string value) : base(value)
    {
    }

    public static readonly DefaultType Draw = new("draw");

    public static readonly DefaultType Phone = new("phone");

    public static readonly DefaultType Type = new("type");

    public static readonly DefaultType Upload = new("upload");

    public TResult Match<TResult>(Func<TResult> onDraw,
        Func<TResult> onPhone,
        Func<TResult> onType,
        Func<TResult> onUpload,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Draw => onDraw(),
            _ when this == Phone => onPhone(),
            _ when this == Type => onType(),
            _ when this == Upload => onUpload(),
            _ => otherwise(Value)
        };

    public void Match(Action onDraw, Action onPhone, Action onType, Action onUpload, Action<string> otherwise)
    {
        if (this == Draw) onDraw();
        else if (this == Phone) onPhone();
        else if (this == Type) onType();
        else if (this == Upload) onUpload();
        else otherwise(Value);
    }
}
