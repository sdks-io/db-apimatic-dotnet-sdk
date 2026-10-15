using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SignatureRequestResponseDataTypeEnum>))]
public sealed record SignatureRequestResponseDataTypeEnum : OpenStringEnum<SignatureRequestResponseDataTypeEnum>
{
    private SignatureRequestResponseDataTypeEnum(string value) : base(value)
    {
    }

    public static readonly SignatureRequestResponseDataTypeEnum Text = new("text");

    public static readonly SignatureRequestResponseDataTypeEnum Checkbox = new("checkbox");

    public static readonly SignatureRequestResponseDataTypeEnum DateSigned = new("date_signed");

    public static readonly SignatureRequestResponseDataTypeEnum Dropdown = new("dropdown");

    public static readonly SignatureRequestResponseDataTypeEnum Initials = new("initials");

    public static readonly SignatureRequestResponseDataTypeEnum Radio = new("radio");

    public static readonly SignatureRequestResponseDataTypeEnum Signature = new("signature");

    public static readonly SignatureRequestResponseDataTypeEnum TextMerge = new("text-merge");

    public static readonly SignatureRequestResponseDataTypeEnum CheckboxMerge = new("checkbox-merge");

    public TResult Match<TResult>(Func<TResult> onText,
        Func<TResult> onCheckbox,
        Func<TResult> onDateSigned,
        Func<TResult> onDropdown,
        Func<TResult> onInitials,
        Func<TResult> onRadio,
        Func<TResult> onSignature,
        Func<TResult> onTextMerge,
        Func<TResult> onCheckboxMerge,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Text => onText(),
            _ when this == Checkbox => onCheckbox(),
            _ when this == DateSigned => onDateSigned(),
            _ when this == Dropdown => onDropdown(),
            _ when this == Initials => onInitials(),
            _ when this == Radio => onRadio(),
            _ when this == Signature => onSignature(),
            _ when this == TextMerge => onTextMerge(),
            _ when this == CheckboxMerge => onCheckboxMerge(),
            _ => otherwise(Value)
        };

    public void Match(Action onText,
        Action onCheckbox,
        Action onDateSigned,
        Action onDropdown,
        Action onInitials,
        Action onRadio,
        Action onSignature,
        Action onTextMerge,
        Action onCheckboxMerge,
        Action<string> otherwise)
    {
        if (this == Text) onText();
        else if (this == Checkbox) onCheckbox();
        else if (this == DateSigned) onDateSigned();
        else if (this == Dropdown) onDropdown();
        else if (this == Initials) onInitials();
        else if (this == Radio) onRadio();
        else if (this == Signature) onSignature();
        else if (this == TextMerge) onTextMerge();
        else if (this == CheckboxMerge) onCheckboxMerge();
        else otherwise(Value);
    }
}
