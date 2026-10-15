using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Fax Transmission Status Code
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusCode>))]
public sealed record StatusCode : OpenStringEnum<StatusCode>
{
    private StatusCode(string value) : base(value)
    {
    }

    public static readonly StatusCode Success = new("success");

    public static readonly StatusCode Transmitting = new("transmitting");

    public static readonly StatusCode ErrorCouldNotFax = new("error_could_not_fax");

    public static readonly StatusCode ErrorUnknown = new("error_unknown");

    public static readonly StatusCode ErrorBusy = new("error_busy");

    public static readonly StatusCode ErrorNoAnswer = new("error_no_answer");

    public static readonly StatusCode ErrorDisconnected = new("error_disconnected");

    public static readonly StatusCode ErrorBadDestination = new("error_bad_destination");

    public TResult Match<TResult>(Func<TResult> onSuccess,
        Func<TResult> onTransmitting,
        Func<TResult> onErrorCouldNotFax,
        Func<TResult> onErrorUnknown,
        Func<TResult> onErrorBusy,
        Func<TResult> onErrorNoAnswer,
        Func<TResult> onErrorDisconnected,
        Func<TResult> onErrorBadDestination,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Transmitting => onTransmitting(),
            _ when this == ErrorCouldNotFax => onErrorCouldNotFax(),
            _ when this == ErrorUnknown => onErrorUnknown(),
            _ when this == ErrorBusy => onErrorBusy(),
            _ when this == ErrorNoAnswer => onErrorNoAnswer(),
            _ when this == ErrorDisconnected => onErrorDisconnected(),
            _ when this == ErrorBadDestination => onErrorBadDestination(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess,
        Action onTransmitting,
        Action onErrorCouldNotFax,
        Action onErrorUnknown,
        Action onErrorBusy,
        Action onErrorNoAnswer,
        Action onErrorDisconnected,
        Action onErrorBadDestination,
        Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Transmitting) onTransmitting();
        else if (this == ErrorCouldNotFax) onErrorCouldNotFax();
        else if (this == ErrorUnknown) onErrorUnknown();
        else if (this == ErrorBusy) onErrorBusy();
        else if (this == ErrorNoAnswer) onErrorNoAnswer();
        else if (this == ErrorDisconnected) onErrorDisconnected();
        else if (this == ErrorBadDestination) onErrorBadDestination();
        else otherwise(Value);
    }
}
