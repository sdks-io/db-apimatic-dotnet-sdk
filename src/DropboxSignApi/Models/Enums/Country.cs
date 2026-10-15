using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Country of the area code
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Country>))]
public sealed record Country : OpenStringEnum<Country>
{
    private Country(string value) : base(value)
    {
    }

    public static readonly Country Ca = new("CA");

    public static readonly Country Us = new("US");

    public static readonly Country Uk = new("UK");

    public TResult Match<TResult>(Func<TResult> onCa,
        Func<TResult> onUs,
        Func<TResult> onUk,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ca => onCa(),
            _ when this == Us => onUs(),
            _ when this == Uk => onUk(),
            _ => otherwise(Value)
        };

    public void Match(Action onCa, Action onUs, Action onUk, Action<string> otherwise)
    {
        if (this == Ca) onCa();
        else if (this == Us) onUs();
        else if (this == Uk) onUk();
        else otherwise(Value);
    }
}
