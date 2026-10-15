using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : OpenStringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 ChangeFieldVisibility = new("change-field-visibility");

    public static readonly Type1 ChangeGroupVisibility = new("change-group-visibility");

    public TResult Match<TResult>(Func<TResult> onChangeFieldVisibility,
        Func<TResult> onChangeGroupVisibility,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ChangeFieldVisibility => onChangeFieldVisibility(),
            _ when this == ChangeGroupVisibility => onChangeGroupVisibility(),
            _ => otherwise(Value)
        };

    public void Match(Action onChangeFieldVisibility, Action onChangeGroupVisibility, Action<string> otherwise)
    {
        if (this == ChangeFieldVisibility) onChangeFieldVisibility();
        else if (this == ChangeGroupVisibility) onChangeGroupVisibility();
        else otherwise(Value);
    }
}
