using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Each text field may contain a <c>validation_type</c> parameter. Check out the list of <see href="https://faq.hellosign.com/hc/en-us/articles/217115577">validation types</see> to learn more about the possible values.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ValidationType1>))]
public sealed record ValidationType1 : OpenStringEnum<ValidationType1>
{
    private ValidationType1(string value) : base(value)
    {
    }

    public static readonly ValidationType1 NumbersOnly = new("numbers_only");

    public static readonly ValidationType1 LettersOnly = new("letters_only");

    public static readonly ValidationType1 PhoneNumber = new("phone_number");

    public static readonly ValidationType1 BankRoutingNumber = new("bank_routing_number");

    public static readonly ValidationType1 BankAccountNumber = new("bank_account_number");

    public static readonly ValidationType1 EmailAddress = new("email_address");

    public static readonly ValidationType1 ZipCode = new("zip_code");

    public static readonly ValidationType1 SocialSecurityNumber = new("social_security_number");

    public static readonly ValidationType1 EmployerIdentificationNumber = new("employer_identification_number");

    public static readonly ValidationType1 CustomRegex = new("custom_regex");

    public TResult Match<TResult>(Func<TResult> onNumbersOnly,
        Func<TResult> onLettersOnly,
        Func<TResult> onPhoneNumber,
        Func<TResult> onBankRoutingNumber,
        Func<TResult> onBankAccountNumber,
        Func<TResult> onEmailAddress,
        Func<TResult> onZipCode,
        Func<TResult> onSocialSecurityNumber,
        Func<TResult> onEmployerIdentificationNumber,
        Func<TResult> onCustomRegex,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NumbersOnly => onNumbersOnly(),
            _ when this == LettersOnly => onLettersOnly(),
            _ when this == PhoneNumber => onPhoneNumber(),
            _ when this == BankRoutingNumber => onBankRoutingNumber(),
            _ when this == BankAccountNumber => onBankAccountNumber(),
            _ when this == EmailAddress => onEmailAddress(),
            _ when this == ZipCode => onZipCode(),
            _ when this == SocialSecurityNumber => onSocialSecurityNumber(),
            _ when this == EmployerIdentificationNumber => onEmployerIdentificationNumber(),
            _ when this == CustomRegex => onCustomRegex(),
            _ => otherwise(Value)
        };

    public void Match(Action onNumbersOnly,
        Action onLettersOnly,
        Action onPhoneNumber,
        Action onBankRoutingNumber,
        Action onBankAccountNumber,
        Action onEmailAddress,
        Action onZipCode,
        Action onSocialSecurityNumber,
        Action onEmployerIdentificationNumber,
        Action onCustomRegex,
        Action<string> otherwise)
    {
        if (this == NumbersOnly) onNumbersOnly();
        else if (this == LettersOnly) onLettersOnly();
        else if (this == PhoneNumber) onPhoneNumber();
        else if (this == BankRoutingNumber) onBankRoutingNumber();
        else if (this == BankAccountNumber) onBankAccountNumber();
        else if (this == EmailAddress) onEmailAddress();
        else if (this == ZipCode) onZipCode();
        else if (this == SocialSecurityNumber) onSocialSecurityNumber();
        else if (this == EmployerIdentificationNumber) onEmployerIdentificationNumber();
        else if (this == CustomRegex) onCustomRegex();
        else otherwise(Value);
    }
}
