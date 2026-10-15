using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Specifies the feature used with the <c>sms_phone_number</c>. Default <c>authentication</c>.
/// <para>
/// If <c>authentication</c>, signer is sent a verification code via SMS that is required to access the document.
/// </para>
/// <para>
/// If <c>delivery</c>, a link to complete the signature request is delivered via SMS (_and_ email).
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SmsPhoneNumberType>))]
public sealed record SmsPhoneNumberType : OpenStringEnum<SmsPhoneNumberType>
{
    private SmsPhoneNumberType(string value) : base(value)
    {
    }

    public static readonly SmsPhoneNumberType Authentication = new("authentication");

    public static readonly SmsPhoneNumberType Delivery = new("delivery");

    public TResult Match<TResult>(Func<TResult> onAuthentication,
        Func<TResult> onDelivery,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Authentication => onAuthentication(),
            _ when this == Delivery => onDelivery(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuthentication, Action onDelivery, Action<string> otherwise)
    {
        if (this == Authentication) onAuthentication();
        else if (this == Delivery) onDelivery();
        else otherwise(Value);
    }
}
