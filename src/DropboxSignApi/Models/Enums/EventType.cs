using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// Type of callback event that was triggered.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EventType>))]
public sealed record EventType : OpenStringEnum<EventType>
{
    private EventType(string value) : base(value)
    {
    }

    public static readonly EventType AccountConfirmed = new("account_confirmed");

    public static readonly EventType UnknownError = new("unknown_error");

    public static readonly EventType FileError = new("file_error");

    public static readonly EventType SignUrlInvalid = new("sign_url_invalid");

    public static readonly EventType SignatureRequestViewed = new("signature_request_viewed");

    public static readonly EventType SignatureRequestSigned = new("signature_request_signed");

    public static readonly EventType SignatureRequestSent = new("signature_request_sent");

    public static readonly EventType SignatureRequestAllSigned = new("signature_request_all_signed");

    public static readonly EventType SignatureRequestEmailBounce = new("signature_request_email_bounce");

    public static readonly EventType SignatureRequestRemind = new("signature_request_remind");

    public static readonly EventType SignatureRequestIncompleteQes = new("signature_request_incomplete_qes");

    public static readonly EventType SignatureRequestDestroyed = new("signature_request_destroyed");

    public static readonly EventType SignatureRequestCanceled = new("signature_request_canceled");

    public static readonly EventType SignatureRequestDownloadable = new("signature_request_downloadable");

    public static readonly EventType SignatureRequestDeclined = new("signature_request_declined");

    public static readonly EventType SignatureRequestReassigned = new("signature_request_reassigned");

    public static readonly EventType SignatureRequestInvalid = new("signature_request_invalid");

    public static readonly EventType SignatureRequestPrepared = new("signature_request_prepared");

    public static readonly EventType SignatureRequestExpired = new("signature_request_expired");

    public static readonly EventType TemplateCreated = new("template_created");

    public static readonly EventType TemplateError = new("template_error");

    public static readonly EventType CallbackTest = new("callback_test");

    public static readonly EventType SignatureRequestSignerRemoved = new("signature_request_signer_removed");

    public static readonly EventType FaxReceived = new("fax_received");

    public static readonly EventType FaxSent = new("fax_sent");

    public static readonly EventType FaxOnHold = new("fax_on_hold");

    public static readonly EventType FaxBusy = new("fax_busy");

    public static readonly EventType FaxNoAnswer = new("fax_no_answer");

    public static readonly EventType FaxDisconnected = new("fax_disconnected");

    public static readonly EventType FaxBlacklisted = new("fax_blacklisted");

    public TResult Match<TResult>(Func<TResult> onAccountConfirmed,
        Func<TResult> onUnknownError,
        Func<TResult> onFileError,
        Func<TResult> onSignUrlInvalid,
        Func<TResult> onSignatureRequestViewed,
        Func<TResult> onSignatureRequestSigned,
        Func<TResult> onSignatureRequestSent,
        Func<TResult> onSignatureRequestAllSigned,
        Func<TResult> onSignatureRequestEmailBounce,
        Func<TResult> onSignatureRequestRemind,
        Func<TResult> onSignatureRequestIncompleteQes,
        Func<TResult> onSignatureRequestDestroyed,
        Func<TResult> onSignatureRequestCanceled,
        Func<TResult> onSignatureRequestDownloadable,
        Func<TResult> onSignatureRequestDeclined,
        Func<TResult> onSignatureRequestReassigned,
        Func<TResult> onSignatureRequestInvalid,
        Func<TResult> onSignatureRequestPrepared,
        Func<TResult> onSignatureRequestExpired,
        Func<TResult> onTemplateCreated,
        Func<TResult> onTemplateError,
        Func<TResult> onCallbackTest,
        Func<TResult> onSignatureRequestSignerRemoved,
        Func<TResult> onFaxReceived,
        Func<TResult> onFaxSent,
        Func<TResult> onFaxOnHold,
        Func<TResult> onFaxBusy,
        Func<TResult> onFaxNoAnswer,
        Func<TResult> onFaxDisconnected,
        Func<TResult> onFaxBlacklisted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountConfirmed => onAccountConfirmed(),
            _ when this == UnknownError => onUnknownError(),
            _ when this == FileError => onFileError(),
            _ when this == SignUrlInvalid => onSignUrlInvalid(),
            _ when this == SignatureRequestViewed => onSignatureRequestViewed(),
            _ when this == SignatureRequestSigned => onSignatureRequestSigned(),
            _ when this == SignatureRequestSent => onSignatureRequestSent(),
            _ when this == SignatureRequestAllSigned => onSignatureRequestAllSigned(),
            _ when this == SignatureRequestEmailBounce => onSignatureRequestEmailBounce(),
            _ when this == SignatureRequestRemind => onSignatureRequestRemind(),
            _ when this == SignatureRequestIncompleteQes => onSignatureRequestIncompleteQes(),
            _ when this == SignatureRequestDestroyed => onSignatureRequestDestroyed(),
            _ when this == SignatureRequestCanceled => onSignatureRequestCanceled(),
            _ when this == SignatureRequestDownloadable => onSignatureRequestDownloadable(),
            _ when this == SignatureRequestDeclined => onSignatureRequestDeclined(),
            _ when this == SignatureRequestReassigned => onSignatureRequestReassigned(),
            _ when this == SignatureRequestInvalid => onSignatureRequestInvalid(),
            _ when this == SignatureRequestPrepared => onSignatureRequestPrepared(),
            _ when this == SignatureRequestExpired => onSignatureRequestExpired(),
            _ when this == TemplateCreated => onTemplateCreated(),
            _ when this == TemplateError => onTemplateError(),
            _ when this == CallbackTest => onCallbackTest(),
            _ when this == SignatureRequestSignerRemoved => onSignatureRequestSignerRemoved(),
            _ when this == FaxReceived => onFaxReceived(),
            _ when this == FaxSent => onFaxSent(),
            _ when this == FaxOnHold => onFaxOnHold(),
            _ when this == FaxBusy => onFaxBusy(),
            _ when this == FaxNoAnswer => onFaxNoAnswer(),
            _ when this == FaxDisconnected => onFaxDisconnected(),
            _ when this == FaxBlacklisted => onFaxBlacklisted(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountConfirmed,
        Action onUnknownError,
        Action onFileError,
        Action onSignUrlInvalid,
        Action onSignatureRequestViewed,
        Action onSignatureRequestSigned,
        Action onSignatureRequestSent,
        Action onSignatureRequestAllSigned,
        Action onSignatureRequestEmailBounce,
        Action onSignatureRequestRemind,
        Action onSignatureRequestIncompleteQes,
        Action onSignatureRequestDestroyed,
        Action onSignatureRequestCanceled,
        Action onSignatureRequestDownloadable,
        Action onSignatureRequestDeclined,
        Action onSignatureRequestReassigned,
        Action onSignatureRequestInvalid,
        Action onSignatureRequestPrepared,
        Action onSignatureRequestExpired,
        Action onTemplateCreated,
        Action onTemplateError,
        Action onCallbackTest,
        Action onSignatureRequestSignerRemoved,
        Action onFaxReceived,
        Action onFaxSent,
        Action onFaxOnHold,
        Action onFaxBusy,
        Action onFaxNoAnswer,
        Action onFaxDisconnected,
        Action onFaxBlacklisted,
        Action<string> otherwise)
    {
        if (this == AccountConfirmed) onAccountConfirmed();
        else if (this == UnknownError) onUnknownError();
        else if (this == FileError) onFileError();
        else if (this == SignUrlInvalid) onSignUrlInvalid();
        else if (this == SignatureRequestViewed) onSignatureRequestViewed();
        else if (this == SignatureRequestSigned) onSignatureRequestSigned();
        else if (this == SignatureRequestSent) onSignatureRequestSent();
        else if (this == SignatureRequestAllSigned) onSignatureRequestAllSigned();
        else if (this == SignatureRequestEmailBounce) onSignatureRequestEmailBounce();
        else if (this == SignatureRequestRemind) onSignatureRequestRemind();
        else if (this == SignatureRequestIncompleteQes) onSignatureRequestIncompleteQes();
        else if (this == SignatureRequestDestroyed) onSignatureRequestDestroyed();
        else if (this == SignatureRequestCanceled) onSignatureRequestCanceled();
        else if (this == SignatureRequestDownloadable) onSignatureRequestDownloadable();
        else if (this == SignatureRequestDeclined) onSignatureRequestDeclined();
        else if (this == SignatureRequestReassigned) onSignatureRequestReassigned();
        else if (this == SignatureRequestInvalid) onSignatureRequestInvalid();
        else if (this == SignatureRequestPrepared) onSignatureRequestPrepared();
        else if (this == SignatureRequestExpired) onSignatureRequestExpired();
        else if (this == TemplateCreated) onTemplateCreated();
        else if (this == TemplateError) onTemplateError();
        else if (this == CallbackTest) onCallbackTest();
        else if (this == SignatureRequestSignerRemoved) onSignatureRequestSignerRemoved();
        else if (this == FaxReceived) onFaxReceived();
        else if (this == FaxSent) onFaxSent();
        else if (this == FaxOnHold) onFaxOnHold();
        else if (this == FaxBusy) onFaxBusy();
        else if (this == FaxNoAnswer) onFaxNoAnswer();
        else if (this == FaxDisconnected) onFaxDisconnected();
        else if (this == FaxBlacklisted) onFaxBlacklisted();
        else otherwise(Value);
    }
}
