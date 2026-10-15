using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SignatureRequestResponseCustomFieldTypeEnum>))]
public sealed record SignatureRequestResponseCustomFieldTypeEnum : OpenStringEnum<SignatureRequestResponseCustomFieldTypeEnum>
{
    private SignatureRequestResponseCustomFieldTypeEnum(string value) : base(value)
    {
    }

    public static readonly SignatureRequestResponseCustomFieldTypeEnum Text = new("text");

    public static readonly SignatureRequestResponseCustomFieldTypeEnum Checkbox = new("checkbox");

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
