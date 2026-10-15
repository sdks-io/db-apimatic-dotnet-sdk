using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Scope>))]
public sealed record Scope : OpenStringEnum<Scope>
{
    private Scope(string value) : base(value)
    {
    }

    public static readonly Scope RequestSignature = new("request_signature");

    public static readonly Scope BasicAccountInfo = new("basic_account_info");

    public static readonly Scope AccountAccess = new("account_access");

    public static readonly Scope SignatureRequestAccess = new("signature_request_access");

    public static readonly Scope TemplateAccess = new("template_access");

    public static readonly Scope TeamAccess = new("team_access");

    public static readonly Scope ApiAppAccess = new("api_app_access");

    public TResult Match<TResult>(Func<TResult> onRequestSignature,
        Func<TResult> onBasicAccountInfo,
        Func<TResult> onAccountAccess,
        Func<TResult> onSignatureRequestAccess,
        Func<TResult> onTemplateAccess,
        Func<TResult> onTeamAccess,
        Func<TResult> onApiAppAccess,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RequestSignature => onRequestSignature(),
            _ when this == BasicAccountInfo => onBasicAccountInfo(),
            _ when this == AccountAccess => onAccountAccess(),
            _ when this == SignatureRequestAccess => onSignatureRequestAccess(),
            _ when this == TemplateAccess => onTemplateAccess(),
            _ when this == TeamAccess => onTeamAccess(),
            _ when this == ApiAppAccess => onApiAppAccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onRequestSignature,
        Action onBasicAccountInfo,
        Action onAccountAccess,
        Action onSignatureRequestAccess,
        Action onTemplateAccess,
        Action onTeamAccess,
        Action onApiAppAccess,
        Action<string> otherwise)
    {
        if (this == RequestSignature) onRequestSignature();
        else if (this == BasicAccountInfo) onBasicAccountInfo();
        else if (this == AccountAccess) onAccountAccess();
        else if (this == SignatureRequestAccess) onSignatureRequestAccess();
        else if (this == TemplateAccess) onTemplateAccess();
        else if (this == TeamAccess) onTeamAccess();
        else if (this == ApiAppAccess) onApiAppAccess();
        else otherwise(Value);
    }
}
