using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FaxLineAreaCodeGetProvinceEnum>))]
public sealed record FaxLineAreaCodeGetProvinceEnum : OpenStringEnum<FaxLineAreaCodeGetProvinceEnum>
{
    private FaxLineAreaCodeGetProvinceEnum(string value) : base(value)
    {
    }

    public static readonly FaxLineAreaCodeGetProvinceEnum Ab = new("AB");

    public static readonly FaxLineAreaCodeGetProvinceEnum Bc = new("BC");

    public static readonly FaxLineAreaCodeGetProvinceEnum Mb = new("MB");

    public static readonly FaxLineAreaCodeGetProvinceEnum Nb = new("NB");

    public static readonly FaxLineAreaCodeGetProvinceEnum Nl = new("NL");

    public static readonly FaxLineAreaCodeGetProvinceEnum Nt = new("NT");

    public static readonly FaxLineAreaCodeGetProvinceEnum Ns = new("NS");

    public static readonly FaxLineAreaCodeGetProvinceEnum Nu = new("NU");

    public static readonly FaxLineAreaCodeGetProvinceEnum On = new("ON");

    public static readonly FaxLineAreaCodeGetProvinceEnum Pe = new("PE");

    public static readonly FaxLineAreaCodeGetProvinceEnum Qc = new("QC");

    public static readonly FaxLineAreaCodeGetProvinceEnum Sk = new("SK");

    public static readonly FaxLineAreaCodeGetProvinceEnum Yt = new("YT");

    public TResult Match<TResult>(Func<TResult> onAb,
        Func<TResult> onBc,
        Func<TResult> onMb,
        Func<TResult> onNb,
        Func<TResult> onNl,
        Func<TResult> onNt,
        Func<TResult> onNs,
        Func<TResult> onNu,
        Func<TResult> onOn,
        Func<TResult> onPe,
        Func<TResult> onQc,
        Func<TResult> onSk,
        Func<TResult> onYt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ab => onAb(),
            _ when this == Bc => onBc(),
            _ when this == Mb => onMb(),
            _ when this == Nb => onNb(),
            _ when this == Nl => onNl(),
            _ when this == Nt => onNt(),
            _ when this == Ns => onNs(),
            _ when this == Nu => onNu(),
            _ when this == On => onOn(),
            _ when this == Pe => onPe(),
            _ when this == Qc => onQc(),
            _ when this == Sk => onSk(),
            _ when this == Yt => onYt(),
            _ => otherwise(Value)
        };

    public void Match(Action onAb,
        Action onBc,
        Action onMb,
        Action onNb,
        Action onNl,
        Action onNt,
        Action onNs,
        Action onNu,
        Action onOn,
        Action onPe,
        Action onQc,
        Action onSk,
        Action onYt,
        Action<string> otherwise)
    {
        if (this == Ab) onAb();
        else if (this == Bc) onBc();
        else if (this == Mb) onMb();
        else if (this == Nb) onNb();
        else if (this == Nl) onNl();
        else if (this == Nt) onNt();
        else if (this == Ns) onNs();
        else if (this == Nu) onNu();
        else if (this == On) onOn();
        else if (this == Pe) onPe();
        else if (this == Qc) onQc();
        else if (this == Sk) onSk();
        else if (this == Yt) onYt();
        else otherwise(Value);
    }
}
