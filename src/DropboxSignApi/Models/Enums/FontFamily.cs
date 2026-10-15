using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Font family for the field.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FontFamily>))]
public sealed record FontFamily : OpenStringEnum<FontFamily>
{
    private FontFamily(string value) : base(value)
    {
    }

    public static readonly FontFamily Helvetica = new("helvetica");

    public static readonly FontFamily Arial = new("arial");

    public static readonly FontFamily Courier = new("courier");

    public static readonly FontFamily Calibri = new("calibri");

    public static readonly FontFamily Cambria = new("cambria");

    public static readonly FontFamily Georgia = new("georgia");

    public static readonly FontFamily Times = new("times");

    public static readonly FontFamily Trebuchet = new("trebuchet");

    public static readonly FontFamily Verdana = new("verdana");

    public static readonly FontFamily Roboto = new("roboto");

    public static readonly FontFamily RobotoMono = new("robotoMono");

    public static readonly FontFamily NotoSans = new("notoSans");

    public static readonly FontFamily NotoSerif = new("notoSerif");

    public static readonly FontFamily NotoCjkJpRegular = new("notoCJK-JP-Regular");

    public static readonly FontFamily NotoHebrewRegular = new("notoHebrew-Regular");

    public static readonly FontFamily NotoSanThaiMerged = new("notoSanThaiMerged");

    public TResult Match<TResult>(Func<TResult> onHelvetica,
        Func<TResult> onArial,
        Func<TResult> onCourier,
        Func<TResult> onCalibri,
        Func<TResult> onCambria,
        Func<TResult> onGeorgia,
        Func<TResult> onTimes,
        Func<TResult> onTrebuchet,
        Func<TResult> onVerdana,
        Func<TResult> onRoboto,
        Func<TResult> onRobotoMono,
        Func<TResult> onNotoSans,
        Func<TResult> onNotoSerif,
        Func<TResult> onNotoCjkJpRegular,
        Func<TResult> onNotoHebrewRegular,
        Func<TResult> onNotoSanThaiMerged,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Helvetica => onHelvetica(),
            _ when this == Arial => onArial(),
            _ when this == Courier => onCourier(),
            _ when this == Calibri => onCalibri(),
            _ when this == Cambria => onCambria(),
            _ when this == Georgia => onGeorgia(),
            _ when this == Times => onTimes(),
            _ when this == Trebuchet => onTrebuchet(),
            _ when this == Verdana => onVerdana(),
            _ when this == Roboto => onRoboto(),
            _ when this == RobotoMono => onRobotoMono(),
            _ when this == NotoSans => onNotoSans(),
            _ when this == NotoSerif => onNotoSerif(),
            _ when this == NotoCjkJpRegular => onNotoCjkJpRegular(),
            _ when this == NotoHebrewRegular => onNotoHebrewRegular(),
            _ when this == NotoSanThaiMerged => onNotoSanThaiMerged(),
            _ => otherwise(Value)
        };

    public void Match(Action onHelvetica,
        Action onArial,
        Action onCourier,
        Action onCalibri,
        Action onCambria,
        Action onGeorgia,
        Action onTimes,
        Action onTrebuchet,
        Action onVerdana,
        Action onRoboto,
        Action onRobotoMono,
        Action onNotoSans,
        Action onNotoSerif,
        Action onNotoCjkJpRegular,
        Action onNotoHebrewRegular,
        Action onNotoSanThaiMerged,
        Action<string> otherwise)
    {
        if (this == Helvetica) onHelvetica();
        else if (this == Arial) onArial();
        else if (this == Courier) onCourier();
        else if (this == Calibri) onCalibri();
        else if (this == Cambria) onCambria();
        else if (this == Georgia) onGeorgia();
        else if (this == Times) onTimes();
        else if (this == Trebuchet) onTrebuchet();
        else if (this == Verdana) onVerdana();
        else if (this == Roboto) onRoboto();
        else if (this == RobotoMono) onRobotoMono();
        else if (this == NotoSans) onNotoSans();
        else if (this == NotoSerif) onNotoSerif();
        else if (this == NotoCjkJpRegular) onNotoCjkJpRegular();
        else if (this == NotoHebrewRegular) onNotoHebrewRegular();
        else if (this == NotoSanThaiMerged) onNotoSanThaiMerged();
        else otherwise(Value);
    }
}
