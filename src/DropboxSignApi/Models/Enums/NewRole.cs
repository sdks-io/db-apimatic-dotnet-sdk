using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// A new role member will take in a new Team.
/// <para>
/// <b>NOTE:</b> This parameter is used only if <c>new_team_id</c> is provided.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NewRole>))]
public sealed record NewRole : OpenStringEnum<NewRole>
{
    private NewRole(string value) : base(value)
    {
    }

    public static readonly NewRole Member = new("Member");

    public static readonly NewRole Developer = new("Developer");

    public static readonly NewRole TeamManager = new("Team Manager");

    public static readonly NewRole Admin = new("Admin");

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
