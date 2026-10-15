using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Different field types allow different <c>operator</c> values:
/// - Field type of <b>text</b>:
///   - <b>is</b>: exact match
///   - <b>not</b>: not exact match
///   - <b>match</b>: regular expression, without /. Example:
///     - OK <c>[a-zA-Z0-9]</c>
///     - Not OK <c>/[a-zA-Z0-9]/</c>
/// - Field type of <b>dropdown</b>:
///   - <b>is</b>: exact match, single value
///   - <b>not</b>: not exact match, single value
///   - <b>any</b>: exact match, array of values.
///   - <b>none</b>: not exact match, array of values.
/// - Field type of <b>checkbox</b>:
///   - <b>is</b>: exact match, single value
///   - <b>not</b>: not exact match, single value
/// - Field type of <b>radio</b>:
///   - <b>is</b>: exact match, single value
///   - <b>not</b>: not exact match, single value
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Operator>))]
public sealed record Operator : OpenStringEnum<Operator>
{
    private Operator(string value) : base(value)
    {
    }

    public static readonly Operator Any = new("any");

    public static readonly Operator IsMember = new("is");

    public static readonly Operator MatchMember = new("match");

    public static readonly Operator None = new("none");

    public static readonly Operator Not = new("not");

    public TResult Match<TResult>(Func<TResult> onAny,
        Func<TResult> onIsMember,
        Func<TResult> onMatchMember,
        Func<TResult> onNone,
        Func<TResult> onNot,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Any => onAny(),
            _ when this == IsMember => onIsMember(),
            _ when this == MatchMember => onMatchMember(),
            _ when this == None => onNone(),
            _ when this == Not => onNot(),
            _ => otherwise(Value)
        };

    public void Match(Action onAny,
        Action onIsMember,
        Action onMatchMember,
        Action onNone,
        Action onNot,
        Action<string> otherwise)
    {
        if (this == Any) onAny();
        else if (this == IsMember) onIsMember();
        else if (this == MatchMember) onMatchMember();
        else if (this == None) onNone();
        else if (this == Not) onNot();
        else otherwise(Value);
    }
}
