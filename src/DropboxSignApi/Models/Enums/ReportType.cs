using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReportType>))]
public sealed record ReportType : OpenStringEnum<ReportType>
{
    private ReportType(string value) : base(value)
    {
    }

    public static readonly ReportType UserActivity = new("user_activity");

    public static readonly ReportType DocumentStatus = new("document_status");

    public static readonly ReportType SmsActivity = new("sms_activity");

    public static readonly ReportType FaxUsage = new("fax_usage");

    public TResult Match<TResult>(Func<TResult> onUserActivity,
        Func<TResult> onDocumentStatus,
        Func<TResult> onSmsActivity,
        Func<TResult> onFaxUsage,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UserActivity => onUserActivity(),
            _ when this == DocumentStatus => onDocumentStatus(),
            _ when this == SmsActivity => onSmsActivity(),
            _ when this == FaxUsage => onFaxUsage(),
            _ => otherwise(Value)
        };

    public void Match(Action onUserActivity,
        Action onDocumentStatus,
        Action onSmsActivity,
        Action onFaxUsage,
        Action<string> otherwise)
    {
        if (this == UserActivity) onUserActivity();
        else if (this == DocumentStatus) onDocumentStatus();
        else if (this == SmsActivity) onSmsActivity();
        else if (this == FaxUsage) onFaxUsage();
        else otherwise(Value);
    }
}
