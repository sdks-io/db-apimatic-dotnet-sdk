using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FileType>))]
public sealed record FileType : OpenStringEnum<FileType>
{
    private FileType(string value) : base(value)
    {
    }

    public static readonly FileType Pdf = new("pdf");

    public static readonly FileType Zip = new("zip");

    public TResult Match<TResult>(Func<TResult> onPdf, Func<TResult> onZip, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pdf => onPdf(),
            _ when this == Zip => onZip(),
            _ => otherwise(Value)
        };

    public void Match(Action onPdf, Action onZip, Action<string> otherwise)
    {
        if (this == Pdf) onPdf();
        else if (this == Zip) onZip();
        else otherwise(Value);
    }
}
