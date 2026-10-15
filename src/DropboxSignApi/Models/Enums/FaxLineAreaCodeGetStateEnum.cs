using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FaxLineAreaCodeGetStateEnum>))]
public sealed record FaxLineAreaCodeGetStateEnum : OpenStringEnum<FaxLineAreaCodeGetStateEnum>
{
    private FaxLineAreaCodeGetStateEnum(string value) : base(value)
    {
    }

    public static readonly FaxLineAreaCodeGetStateEnum Ak = new("AK");

    public static readonly FaxLineAreaCodeGetStateEnum Al = new("AL");

    public static readonly FaxLineAreaCodeGetStateEnum Ar = new("AR");

    public static readonly FaxLineAreaCodeGetStateEnum Az = new("AZ");

    public static readonly FaxLineAreaCodeGetStateEnum Ca = new("CA");

    public static readonly FaxLineAreaCodeGetStateEnum Co = new("CO");

    public static readonly FaxLineAreaCodeGetStateEnum Ct = new("CT");

    public static readonly FaxLineAreaCodeGetStateEnum Dc = new("DC");

    public static readonly FaxLineAreaCodeGetStateEnum De = new("DE");

    public static readonly FaxLineAreaCodeGetStateEnum Fl = new("FL");

    public static readonly FaxLineAreaCodeGetStateEnum Ga = new("GA");

    public static readonly FaxLineAreaCodeGetStateEnum Hi = new("HI");

    public static readonly FaxLineAreaCodeGetStateEnum Ia = new("IA");

    public static readonly FaxLineAreaCodeGetStateEnum Id = new("ID");

    public static readonly FaxLineAreaCodeGetStateEnum Il = new("IL");

    public static readonly FaxLineAreaCodeGetStateEnum In = new("IN");

    public static readonly FaxLineAreaCodeGetStateEnum Ks = new("KS");

    public static readonly FaxLineAreaCodeGetStateEnum Ky = new("KY");

    public static readonly FaxLineAreaCodeGetStateEnum La = new("LA");

    public static readonly FaxLineAreaCodeGetStateEnum Ma = new("MA");

    public static readonly FaxLineAreaCodeGetStateEnum Md = new("MD");

    public static readonly FaxLineAreaCodeGetStateEnum Me = new("ME");

    public static readonly FaxLineAreaCodeGetStateEnum Mi = new("MI");

    public static readonly FaxLineAreaCodeGetStateEnum Mn = new("MN");

    public static readonly FaxLineAreaCodeGetStateEnum Mo = new("MO");

    public static readonly FaxLineAreaCodeGetStateEnum Ms = new("MS");

    public static readonly FaxLineAreaCodeGetStateEnum Mt = new("MT");

    public static readonly FaxLineAreaCodeGetStateEnum Nc = new("NC");

    public static readonly FaxLineAreaCodeGetStateEnum Nd = new("ND");

    public static readonly FaxLineAreaCodeGetStateEnum Ne = new("NE");

    public static readonly FaxLineAreaCodeGetStateEnum Nh = new("NH");

    public static readonly FaxLineAreaCodeGetStateEnum Nj = new("NJ");

    public static readonly FaxLineAreaCodeGetStateEnum Nm = new("NM");

    public static readonly FaxLineAreaCodeGetStateEnum Nv = new("NV");

    public static readonly FaxLineAreaCodeGetStateEnum Ny = new("NY");

    public static readonly FaxLineAreaCodeGetStateEnum Oh = new("OH");

    public static readonly FaxLineAreaCodeGetStateEnum Ok = new("OK");

    public static readonly FaxLineAreaCodeGetStateEnum Or = new("OR");

    public static readonly FaxLineAreaCodeGetStateEnum Pa = new("PA");

    public static readonly FaxLineAreaCodeGetStateEnum Ri = new("RI");

    public static readonly FaxLineAreaCodeGetStateEnum Sc = new("SC");

    public static readonly FaxLineAreaCodeGetStateEnum Sd = new("SD");

    public static readonly FaxLineAreaCodeGetStateEnum Tn = new("TN");

    public static readonly FaxLineAreaCodeGetStateEnum Tx = new("TX");

    public static readonly FaxLineAreaCodeGetStateEnum Ut = new("UT");

    public static readonly FaxLineAreaCodeGetStateEnum Va = new("VA");

    public static readonly FaxLineAreaCodeGetStateEnum Vt = new("VT");

    public static readonly FaxLineAreaCodeGetStateEnum Wa = new("WA");

    public static readonly FaxLineAreaCodeGetStateEnum Wi = new("WI");

    public static readonly FaxLineAreaCodeGetStateEnum Wv = new("WV");

    public static readonly FaxLineAreaCodeGetStateEnum Wy = new("WY");

    public TResult Match<TResult>(Func<TResult> onAk,
        Func<TResult> onAl,
        Func<TResult> onAr,
        Func<TResult> onAz,
        Func<TResult> onCa,
        Func<TResult> onCo,
        Func<TResult> onCt,
        Func<TResult> onDc,
        Func<TResult> onDe,
        Func<TResult> onFl,
        Func<TResult> onGa,
        Func<TResult> onHi,
        Func<TResult> onIa,
        Func<TResult> onId,
        Func<TResult> onIl,
        Func<TResult> onIn,
        Func<TResult> onKs,
        Func<TResult> onKy,
        Func<TResult> onLa,
        Func<TResult> onMa,
        Func<TResult> onMd,
        Func<TResult> onMe,
        Func<TResult> onMi,
        Func<TResult> onMn,
        Func<TResult> onMo,
        Func<TResult> onMs,
        Func<TResult> onMt,
        Func<TResult> onNc,
        Func<TResult> onNd,
        Func<TResult> onNe,
        Func<TResult> onNh,
        Func<TResult> onNj,
        Func<TResult> onNm,
        Func<TResult> onNv,
        Func<TResult> onNy,
        Func<TResult> onOh,
        Func<TResult> onOk,
        Func<TResult> onOr,
        Func<TResult> onPa,
        Func<TResult> onRi,
        Func<TResult> onSc,
        Func<TResult> onSd,
        Func<TResult> onTn,
        Func<TResult> onTx,
        Func<TResult> onUt,
        Func<TResult> onVa,
        Func<TResult> onVt,
        Func<TResult> onWa,
        Func<TResult> onWi,
        Func<TResult> onWv,
        Func<TResult> onWy,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ak => onAk(),
            _ when this == Al => onAl(),
            _ when this == Ar => onAr(),
            _ when this == Az => onAz(),
            _ when this == Ca => onCa(),
            _ when this == Co => onCo(),
            _ when this == Ct => onCt(),
            _ when this == Dc => onDc(),
            _ when this == De => onDe(),
            _ when this == Fl => onFl(),
            _ when this == Ga => onGa(),
            _ when this == Hi => onHi(),
            _ when this == Ia => onIa(),
            _ when this == Id => onId(),
            _ when this == Il => onIl(),
            _ when this == In => onIn(),
            _ when this == Ks => onKs(),
            _ when this == Ky => onKy(),
            _ when this == La => onLa(),
            _ when this == Ma => onMa(),
            _ when this == Md => onMd(),
            _ when this == Me => onMe(),
            _ when this == Mi => onMi(),
            _ when this == Mn => onMn(),
            _ when this == Mo => onMo(),
            _ when this == Ms => onMs(),
            _ when this == Mt => onMt(),
            _ when this == Nc => onNc(),
            _ when this == Nd => onNd(),
            _ when this == Ne => onNe(),
            _ when this == Nh => onNh(),
            _ when this == Nj => onNj(),
            _ when this == Nm => onNm(),
            _ when this == Nv => onNv(),
            _ when this == Ny => onNy(),
            _ when this == Oh => onOh(),
            _ when this == Ok => onOk(),
            _ when this == Or => onOr(),
            _ when this == Pa => onPa(),
            _ when this == Ri => onRi(),
            _ when this == Sc => onSc(),
            _ when this == Sd => onSd(),
            _ when this == Tn => onTn(),
            _ when this == Tx => onTx(),
            _ when this == Ut => onUt(),
            _ when this == Va => onVa(),
            _ when this == Vt => onVt(),
            _ when this == Wa => onWa(),
            _ when this == Wi => onWi(),
            _ when this == Wv => onWv(),
            _ when this == Wy => onWy(),
            _ => otherwise(Value)
        };

    public void Match(Action onAk,
        Action onAl,
        Action onAr,
        Action onAz,
        Action onCa,
        Action onCo,
        Action onCt,
        Action onDc,
        Action onDe,
        Action onFl,
        Action onGa,
        Action onHi,
        Action onIa,
        Action onId,
        Action onIl,
        Action onIn,
        Action onKs,
        Action onKy,
        Action onLa,
        Action onMa,
        Action onMd,
        Action onMe,
        Action onMi,
        Action onMn,
        Action onMo,
        Action onMs,
        Action onMt,
        Action onNc,
        Action onNd,
        Action onNe,
        Action onNh,
        Action onNj,
        Action onNm,
        Action onNv,
        Action onNy,
        Action onOh,
        Action onOk,
        Action onOr,
        Action onPa,
        Action onRi,
        Action onSc,
        Action onSd,
        Action onTn,
        Action onTx,
        Action onUt,
        Action onVa,
        Action onVt,
        Action onWa,
        Action onWi,
        Action onWv,
        Action onWy,
        Action<string> otherwise)
    {
        if (this == Ak) onAk();
        else if (this == Al) onAl();
        else if (this == Ar) onAr();
        else if (this == Az) onAz();
        else if (this == Ca) onCa();
        else if (this == Co) onCo();
        else if (this == Ct) onCt();
        else if (this == Dc) onDc();
        else if (this == De) onDe();
        else if (this == Fl) onFl();
        else if (this == Ga) onGa();
        else if (this == Hi) onHi();
        else if (this == Ia) onIa();
        else if (this == Id) onId();
        else if (this == Il) onIl();
        else if (this == In) onIn();
        else if (this == Ks) onKs();
        else if (this == Ky) onKy();
        else if (this == La) onLa();
        else if (this == Ma) onMa();
        else if (this == Md) onMd();
        else if (this == Me) onMe();
        else if (this == Mi) onMi();
        else if (this == Mn) onMn();
        else if (this == Mo) onMo();
        else if (this == Ms) onMs();
        else if (this == Mt) onMt();
        else if (this == Nc) onNc();
        else if (this == Nd) onNd();
        else if (this == Ne) onNe();
        else if (this == Nh) onNh();
        else if (this == Nj) onNj();
        else if (this == Nm) onNm();
        else if (this == Nv) onNv();
        else if (this == Ny) onNy();
        else if (this == Oh) onOh();
        else if (this == Ok) onOk();
        else if (this == Or) onOr();
        else if (this == Pa) onPa();
        else if (this == Ri) onRi();
        else if (this == Sc) onSc();
        else if (this == Sd) onSd();
        else if (this == Tn) onTn();
        else if (this == Tx) onTx();
        else if (this == Ut) onUt();
        else if (this == Va) onVa();
        else if (this == Vt) onVt();
        else if (this == Wa) onWa();
        else if (this == Wi) onWi();
        else if (this == Wv) onWv();
        else if (this == Wy) onWy();
        else otherwise(Value);
    }
}
