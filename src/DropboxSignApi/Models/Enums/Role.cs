using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// A role member will take in a new Team.
/// <para>
/// <b>NOTE:</b> This parameter is used only if <c>team_id</c> is provided.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Role>))]
public sealed record Role : OpenStringEnum<Role>
{
    private Role(string value) : base(value)
    {
    }

    public static readonly Role Member = new("Member");

    public static readonly Role Developer = new("Developer");

    public static readonly Role TeamManager = new("Team Manager");

    public static readonly Role Admin = new("Admin");

    public TResult Match<TResult>(Func<TResult> onMember,
        Func<TResult> onDeveloper,
        Func<TResult> onTeamManager,
        Func<TResult> onAdmin,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Member => onMember(),
            _ when this == Developer => onDeveloper(),
            _ when this == TeamManager => onTeamManager(),
            _ when this == Admin => onAdmin(),
            _ => otherwise(Value)
        };

    public void Match(Action onMember,
        Action onDeveloper,
        Action onTeamManager,
        Action onAdmin,
        Action<string> otherwise)
    {
        if (this == Member) onMember();
        else if (this == Developer) onDeveloper();
        else if (this == TeamManager) onTeamManager();
        else if (this == Admin) onAdmin();
        else otherwise(Value);
    }
}
