using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Allows requester to specify the date format (see list of allowed <see href="/api/reference/constants/#date-formats">formats</see>)
/// <para>
/// <b>NOTE:</b> Only available for Premium and higher.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DateFormat>))]
public sealed record DateFormat : OpenStringEnum<DateFormat>
{
    private DateFormat(string value) : base(value)
    {
    }

    public static readonly DateFormat Mmddyyyy = new("MM / DD / YYYY");

    public static readonly DateFormat MmDdYyyy = new("MM - DD - YYYY");

    public static readonly DateFormat Ddmmyyyy = new("DD / MM / YYYY");

    public static readonly DateFormat DdMmYyyy = new("DD - MM - YYYY");

    public static readonly DateFormat Yyyymmdd = new("YYYY / MM / DD");

    public static readonly DateFormat YyyyMmDd = new("YYYY - MM - DD");

    public TResult Match<TResult>(Func<TResult> onMmddyyyy,
        Func<TResult> onMmDdYyyy,
        Func<TResult> onDdmmyyyy,
        Func<TResult> onDdMmYyyy,
        Func<TResult> onYyyymmdd,
        Func<TResult> onYyyyMmDd,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mmddyyyy => onMmddyyyy(),
            _ when this == MmDdYyyy => onMmDdYyyy(),
            _ when this == Ddmmyyyy => onDdmmyyyy(),
            _ when this == DdMmYyyy => onDdMmYyyy(),
            _ when this == Yyyymmdd => onYyyymmdd(),
            _ when this == YyyyMmDd => onYyyyMmDd(),
            _ => otherwise(Value)
        };

    public void Match(Action onMmddyyyy,
        Action onMmDdYyyy,
        Action onDdmmyyyy,
        Action onDdMmYyyy,
        Action onYyyymmdd,
        Action onYyyyMmDd,
        Action<string> otherwise)
    {
        if (this == Mmddyyyy) onMmddyyyy();
        else if (this == MmDdYyyy) onMmDdYyyy();
        else if (this == Ddmmyyyy) onDdmmyyyy();
        else if (this == DdMmYyyy) onDdMmYyyy();
        else if (this == Yyyymmdd) onYyyymmdd();
        else if (this == YyyyMmDd) onYyyyMmDd();
        else otherwise(Value);
    }
}
