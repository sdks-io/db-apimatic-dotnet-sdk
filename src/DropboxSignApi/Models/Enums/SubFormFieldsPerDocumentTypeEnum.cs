using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SubFormFieldsPerDocumentTypeEnum>))]
public sealed record SubFormFieldsPerDocumentTypeEnum : OpenStringEnum<SubFormFieldsPerDocumentTypeEnum>
{
    private SubFormFieldsPerDocumentTypeEnum(string value) : base(value)
    {
    }

    public static readonly SubFormFieldsPerDocumentTypeEnum Checkbox = new("checkbox");

    public static readonly SubFormFieldsPerDocumentTypeEnum CheckboxMerge = new("checkbox-merge");

    public static readonly SubFormFieldsPerDocumentTypeEnum DateSigned = new("date_signed");

    public static readonly SubFormFieldsPerDocumentTypeEnum Dropdown = new("dropdown");

    public static readonly SubFormFieldsPerDocumentTypeEnum Hyperlink = new("hyperlink");

    public static readonly SubFormFieldsPerDocumentTypeEnum Initials = new("initials");

    public static readonly SubFormFieldsPerDocumentTypeEnum Signature = new("signature");

    public static readonly SubFormFieldsPerDocumentTypeEnum Radio = new("radio");

    public static readonly SubFormFieldsPerDocumentTypeEnum Text = new("text");

    public static readonly SubFormFieldsPerDocumentTypeEnum TextMerge = new("text-merge");

    public TResult Match<TResult>(Func<TResult> onCheckbox,
        Func<TResult> onCheckboxMerge,
        Func<TResult> onDateSigned,
        Func<TResult> onDropdown,
        Func<TResult> onHyperlink,
        Func<TResult> onInitials,
        Func<TResult> onSignature,
        Func<TResult> onRadio,
        Func<TResult> onText,
        Func<TResult> onTextMerge,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Checkbox => onCheckbox(),
            _ when this == CheckboxMerge => onCheckboxMerge(),
            _ when this == DateSigned => onDateSigned(),
            _ when this == Dropdown => onDropdown(),
            _ when this == Hyperlink => onHyperlink(),
            _ when this == Initials => onInitials(),
            _ when this == Signature => onSignature(),
            _ when this == Radio => onRadio(),
            _ when this == Text => onText(),
            _ when this == TextMerge => onTextMerge(),
            _ => otherwise(Value)
        };

    public void Match(Action onCheckbox,
        Action onCheckboxMerge,
        Action onDateSigned,
        Action onDropdown,
        Action onHyperlink,
        Action onInitials,
        Action onSignature,
        Action onRadio,
        Action onText,
        Action onTextMerge,
        Action<string> otherwise)
    {
        if (this == Checkbox) onCheckbox();
        else if (this == CheckboxMerge) onCheckboxMerge();
        else if (this == DateSigned) onDateSigned();
        else if (this == Dropdown) onDropdown();
        else if (this == Hyperlink) onHyperlink();
        else if (this == Initials) onInitials();
        else if (this == Signature) onSignature();
        else if (this == Radio) onRadio();
        else if (this == Text) onText();
        else if (this == TextMerge) onTextMerge();
        else otherwise(Value);
    }
}
