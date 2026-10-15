using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// The type of merge field.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Text = new("text");

    public static readonly TypeEnum Checkbox = new("checkbox");

    public TResult Match<TResult>(Func<TResult> onText, Func<TResult> onCheckbox, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Text => onText(),
            _ when this == Checkbox => onCheckbox(),
            _ => otherwise(Value)
        };

    public void Match(Action onText, Action onCheckbox, Action<string> otherwise)
    {
        if (this == Text) onText();
        else if (this == Checkbox) onCheckbox();
        else otherwise(Value);
    }
}
