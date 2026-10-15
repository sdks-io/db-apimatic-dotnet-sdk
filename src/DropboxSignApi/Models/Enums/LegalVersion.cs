using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<LegalVersion>))]
public sealed record LegalVersion : OpenStringEnum<LegalVersion>
{
    private LegalVersion(string value) : base(value)
    {
    }

    public static readonly LegalVersion Terms1 = new("terms1");

    public static readonly LegalVersion Terms2 = new("terms2");

    public TResult Match<TResult>(Func<TResult> onTerms1, Func<TResult> onTerms2, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Terms1 => onTerms1(),
            _ when this == Terms2 => onTerms2(),
            _ => otherwise(Value)
        };

    public void Match(Action onTerms1, Action onTerms2, Action<string> otherwise)
    {
        if (this == Terms1) onTerms1();
        else if (this == Terms2) onTerms2();
        else otherwise(Value);
    }
}
