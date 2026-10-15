using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Extensions;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models.AnyOf;

/// <summary>
/// JSON payload delivered for a webhook event. The concrete shape is selected by <c>event.event_type</c>.
/// </summary>
[JsonConverter(typeof(EventCallbackPayload1Converter))]
public record EventCallbackPayload1
{
    private readonly Optional<SignatureRequestViewedEvent> _signatureRequestViewedEventValue;

    private readonly Optional<SignatureRequestSignedEvent> _signatureRequestSignedEventValue;

    private readonly Optional<SignatureRequestSignerRemovedEvent> _signatureRequestSignerRemovedEventValue;

    private readonly Optional<SignatureRequestDownloadableEvent> _signatureRequestDownloadableEventValue;

    private readonly Optional<SignatureRequestSentEvent> _signatureRequestSentEventValue;

    private readonly Optional<SignatureRequestAllSignedEvent> _signatureRequestAllSignedEventValue;

    private readonly Optional<SignatureRequestInvalidEvent> _signatureRequestInvalidEventValue;

    private readonly Optional<SignatureRequestEmailBounceEvent> _signatureRequestEmailBounceEventValue;

    private readonly Optional<SignatureRequestRemindEvent> _signatureRequestRemindEventValue;

    private readonly Optional<SignatureRequestIncompleteQesEvent> _signatureRequestIncompleteQesEventValue;

    private readonly Optional<SignatureRequestDestroyedEvent> _signatureRequestDestroyedEventValue;

    private readonly Optional<SignatureRequestCanceledEvent> _signatureRequestCanceledEventValue;

    private readonly Optional<SignatureRequestDeclinedEvent> _signatureRequestDeclinedEventValue;

    private readonly Optional<SignatureRequestExpiredEvent> _signatureRequestExpiredEventValue;

    private readonly Optional<SignatureRequestReassignedEvent> _signatureRequestReassignedEventValue;

    private readonly Optional<SignatureRequestPreparedEvent> _signatureRequestPreparedEventValue;

    private readonly Optional<AccountConfirmedEvent> _accountConfirmedEventValue;

    private readonly Optional<UnknownErrorEvent> _unknownErrorEventValue;

    private readonly Optional<FileErrorEvent> _fileErrorEventValue;

    private readonly Optional<TemplateCreatedEvent> _templateCreatedEventValue;

    private readonly Optional<TemplateErrorEvent> _templateErrorEventValue;

    private readonly Optional<SignUrlInvalidEvent> _signUrlInvalidEventValue;

    private readonly Optional<CallbackTestEvent> _callbackTestEventValue;

    private readonly Optional<FaxReceivedEvent> _faxReceivedEventValue;

    private readonly Optional<FaxSentEvent> _faxSentEventValue;

    private readonly Optional<FaxOnHoldEvent> _faxOnHoldEventValue;

    private readonly Optional<FaxBusyEvent> _faxBusyEventValue;

    private readonly Optional<FaxNoAnswerEvent> _faxNoAnswerEventValue;

    private readonly Optional<FaxDisconnectedEvent> _faxDisconnectedEventValue;

    private readonly Optional<FaxBlacklistedEvent> _faxBlacklistedEventValue;

    private EventCallbackPayload1(Optional<SignatureRequestViewedEvent> signatureRequestViewedEventValue,
        Optional<SignatureRequestSignedEvent> signatureRequestSignedEventValue,
        Optional<SignatureRequestSignerRemovedEvent> signatureRequestSignerRemovedEventValue,
        Optional<SignatureRequestDownloadableEvent> signatureRequestDownloadableEventValue,
        Optional<SignatureRequestSentEvent> signatureRequestSentEventValue,
        Optional<SignatureRequestAllSignedEvent> signatureRequestAllSignedEventValue,
        Optional<SignatureRequestInvalidEvent> signatureRequestInvalidEventValue,
        Optional<SignatureRequestEmailBounceEvent> signatureRequestEmailBounceEventValue,
        Optional<SignatureRequestRemindEvent> signatureRequestRemindEventValue,
        Optional<SignatureRequestIncompleteQesEvent> signatureRequestIncompleteQesEventValue,
        Optional<SignatureRequestDestroyedEvent> signatureRequestDestroyedEventValue,
        Optional<SignatureRequestCanceledEvent> signatureRequestCanceledEventValue,
        Optional<SignatureRequestDeclinedEvent> signatureRequestDeclinedEventValue,
        Optional<SignatureRequestExpiredEvent> signatureRequestExpiredEventValue,
        Optional<SignatureRequestReassignedEvent> signatureRequestReassignedEventValue,
        Optional<SignatureRequestPreparedEvent> signatureRequestPreparedEventValue,
        Optional<AccountConfirmedEvent> accountConfirmedEventValue,
        Optional<UnknownErrorEvent> unknownErrorEventValue,
        Optional<FileErrorEvent> fileErrorEventValue,
        Optional<TemplateCreatedEvent> templateCreatedEventValue,
        Optional<TemplateErrorEvent> templateErrorEventValue,
        Optional<SignUrlInvalidEvent> signUrlInvalidEventValue,
        Optional<CallbackTestEvent> callbackTestEventValue,
        Optional<FaxReceivedEvent> faxReceivedEventValue,
        Optional<FaxSentEvent> faxSentEventValue,
        Optional<FaxOnHoldEvent> faxOnHoldEventValue,
        Optional<FaxBusyEvent> faxBusyEventValue,
        Optional<FaxNoAnswerEvent> faxNoAnswerEventValue,
        Optional<FaxDisconnectedEvent> faxDisconnectedEventValue,
        Optional<FaxBlacklistedEvent> faxBlacklistedEventValue)
    {
        _signatureRequestViewedEventValue = signatureRequestViewedEventValue;
        _signatureRequestSignedEventValue = signatureRequestSignedEventValue;
        _signatureRequestSignerRemovedEventValue = signatureRequestSignerRemovedEventValue;
        _signatureRequestDownloadableEventValue = signatureRequestDownloadableEventValue;
        _signatureRequestSentEventValue = signatureRequestSentEventValue;
        _signatureRequestAllSignedEventValue = signatureRequestAllSignedEventValue;
        _signatureRequestInvalidEventValue = signatureRequestInvalidEventValue;
        _signatureRequestEmailBounceEventValue = signatureRequestEmailBounceEventValue;
        _signatureRequestRemindEventValue = signatureRequestRemindEventValue;
        _signatureRequestIncompleteQesEventValue = signatureRequestIncompleteQesEventValue;
        _signatureRequestDestroyedEventValue = signatureRequestDestroyedEventValue;
        _signatureRequestCanceledEventValue = signatureRequestCanceledEventValue;
        _signatureRequestDeclinedEventValue = signatureRequestDeclinedEventValue;
        _signatureRequestExpiredEventValue = signatureRequestExpiredEventValue;
        _signatureRequestReassignedEventValue = signatureRequestReassignedEventValue;
        _signatureRequestPreparedEventValue = signatureRequestPreparedEventValue;
        _accountConfirmedEventValue = accountConfirmedEventValue;
        _unknownErrorEventValue = unknownErrorEventValue;
        _fileErrorEventValue = fileErrorEventValue;
        _templateCreatedEventValue = templateCreatedEventValue;
        _templateErrorEventValue = templateErrorEventValue;
        _signUrlInvalidEventValue = signUrlInvalidEventValue;
        _callbackTestEventValue = callbackTestEventValue;
        _faxReceivedEventValue = faxReceivedEventValue;
        _faxSentEventValue = faxSentEventValue;
        _faxOnHoldEventValue = faxOnHoldEventValue;
        _faxBusyEventValue = faxBusyEventValue;
        _faxNoAnswerEventValue = faxNoAnswerEventValue;
        _faxDisconnectedEventValue = faxDisconnectedEventValue;
        _faxBlacklistedEventValue = faxBlacklistedEventValue;
    }

    public static EventCallbackPayload1 SignatureRequestViewedEvent(SignatureRequestViewedEvent value) =>
        new(
            Optional<SignatureRequestViewedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestSignedEvent(SignatureRequestSignedEvent value) =>
        new(
            default,
            Optional<SignatureRequestSignedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestSignerRemovedEvent(SignatureRequestSignerRemovedEvent value) =>
        new(
            default,
            default,
            Optional<SignatureRequestSignerRemovedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestDownloadableEvent(SignatureRequestDownloadableEvent value) =>
        new(
            default,
            default,
            default,
            Optional<SignatureRequestDownloadableEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestSentEvent(SignatureRequestSentEvent value) =>
        new(
            default,
            default,
            default,
            default,
            Optional<SignatureRequestSentEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestAllSignedEvent(SignatureRequestAllSignedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestAllSignedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestInvalidEvent(SignatureRequestInvalidEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestInvalidEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestEmailBounceEvent(SignatureRequestEmailBounceEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestEmailBounceEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestRemindEvent(SignatureRequestRemindEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestRemindEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestIncompleteQesEvent(SignatureRequestIncompleteQesEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestIncompleteQesEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestDestroyedEvent(SignatureRequestDestroyedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestDestroyedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestCanceledEvent(SignatureRequestCanceledEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestCanceledEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestDeclinedEvent(SignatureRequestDeclinedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestDeclinedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestExpiredEvent(SignatureRequestExpiredEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestExpiredEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestReassignedEvent(SignatureRequestReassignedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestReassignedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignatureRequestPreparedEvent(SignatureRequestPreparedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignatureRequestPreparedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 AccountConfirmedEvent(AccountConfirmedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<AccountConfirmedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 UnknownErrorEvent(UnknownErrorEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<UnknownErrorEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 FileErrorEvent(FileErrorEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FileErrorEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 TemplateCreatedEvent(TemplateCreatedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<TemplateCreatedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 TemplateErrorEvent(TemplateErrorEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<TemplateErrorEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 SignUrlInvalidEvent(SignUrlInvalidEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<SignUrlInvalidEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 CallbackTestEvent(CallbackTestEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<CallbackTestEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 FaxReceivedEvent(FaxReceivedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FaxReceivedEvent>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 FaxSentEvent(FaxSentEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FaxSentEvent>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 FaxOnHoldEvent(FaxOnHoldEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FaxOnHoldEvent>.Some(value),
            default,
            default,
            default,
            default);

    public static EventCallbackPayload1 FaxBusyEvent(FaxBusyEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FaxBusyEvent>.Some(value),
            default,
            default,
            default);

    public static EventCallbackPayload1 FaxNoAnswerEvent(FaxNoAnswerEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FaxNoAnswerEvent>.Some(value),
            default,
            default);

    public static EventCallbackPayload1 FaxDisconnectedEvent(FaxDisconnectedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FaxDisconnectedEvent>.Some(value),
            default);

    public static EventCallbackPayload1 FaxBlacklistedEvent(FaxBlacklistedEvent value) =>
        new(
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<FaxBlacklistedEvent>.Some(value));

    public bool TryGetSignatureRequestViewedEvent(out SignatureRequestViewedEvent value) =>
        _signatureRequestViewedEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestSignedEvent(out SignatureRequestSignedEvent value) =>
        _signatureRequestSignedEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestSignerRemovedEvent(out SignatureRequestSignerRemovedEvent value) =>
        _signatureRequestSignerRemovedEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestDownloadableEvent(out SignatureRequestDownloadableEvent value) =>
        _signatureRequestDownloadableEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestSentEvent(out SignatureRequestSentEvent value) =>
        _signatureRequestSentEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestAllSignedEvent(out SignatureRequestAllSignedEvent value) =>
        _signatureRequestAllSignedEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestInvalidEvent(out SignatureRequestInvalidEvent value) =>
        _signatureRequestInvalidEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestEmailBounceEvent(out SignatureRequestEmailBounceEvent value) =>
        _signatureRequestEmailBounceEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestRemindEvent(out SignatureRequestRemindEvent value) =>
        _signatureRequestRemindEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestIncompleteQesEvent(out SignatureRequestIncompleteQesEvent value) =>
        _signatureRequestIncompleteQesEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestDestroyedEvent(out SignatureRequestDestroyedEvent value) =>
        _signatureRequestDestroyedEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestCanceledEvent(out SignatureRequestCanceledEvent value) =>
        _signatureRequestCanceledEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestDeclinedEvent(out SignatureRequestDeclinedEvent value) =>
        _signatureRequestDeclinedEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestExpiredEvent(out SignatureRequestExpiredEvent value) =>
        _signatureRequestExpiredEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestReassignedEvent(out SignatureRequestReassignedEvent value) =>
        _signatureRequestReassignedEventValue.TryGetValue(out value);

    public bool TryGetSignatureRequestPreparedEvent(out SignatureRequestPreparedEvent value) =>
        _signatureRequestPreparedEventValue.TryGetValue(out value);

    public bool TryGetAccountConfirmedEvent(out AccountConfirmedEvent value) =>
        _accountConfirmedEventValue.TryGetValue(out value);

    public bool TryGetUnknownErrorEvent(out UnknownErrorEvent value) => _unknownErrorEventValue.TryGetValue(out value);

    public bool TryGetFileErrorEvent(out FileErrorEvent value) => _fileErrorEventValue.TryGetValue(out value);

    public bool TryGetTemplateCreatedEvent(out TemplateCreatedEvent value) =>
        _templateCreatedEventValue.TryGetValue(out value);

    public bool TryGetTemplateErrorEvent(out TemplateErrorEvent value) =>
        _templateErrorEventValue.TryGetValue(out value);

    public bool TryGetSignUrlInvalidEvent(out SignUrlInvalidEvent value) =>
        _signUrlInvalidEventValue.TryGetValue(out value);

    public bool TryGetCallbackTestEvent(out CallbackTestEvent value) => _callbackTestEventValue.TryGetValue(out value);

    public bool TryGetFaxReceivedEvent(out FaxReceivedEvent value) => _faxReceivedEventValue.TryGetValue(out value);

    public bool TryGetFaxSentEvent(out FaxSentEvent value) => _faxSentEventValue.TryGetValue(out value);

    public bool TryGetFaxOnHoldEvent(out FaxOnHoldEvent value) => _faxOnHoldEventValue.TryGetValue(out value);

    public bool TryGetFaxBusyEvent(out FaxBusyEvent value) => _faxBusyEventValue.TryGetValue(out value);

    public bool TryGetFaxNoAnswerEvent(out FaxNoAnswerEvent value) => _faxNoAnswerEventValue.TryGetValue(out value);

    public bool TryGetFaxDisconnectedEvent(out FaxDisconnectedEvent value) =>
        _faxDisconnectedEventValue.TryGetValue(out value);

    public bool TryGetFaxBlacklistedEvent(out FaxBlacklistedEvent value) =>
        _faxBlacklistedEventValue.TryGetValue(out value);

    public static implicit operator EventCallbackPayload1(SignatureRequestViewedEvent value) =>
        SignatureRequestViewedEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestSignedEvent value) =>
        SignatureRequestSignedEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestSignerRemovedEvent value) =>
        SignatureRequestSignerRemovedEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestDownloadableEvent value) =>
        SignatureRequestDownloadableEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestSentEvent value) =>
        SignatureRequestSentEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestAllSignedEvent value) =>
        SignatureRequestAllSignedEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestInvalidEvent value) =>
        SignatureRequestInvalidEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestEmailBounceEvent value) =>
        SignatureRequestEmailBounceEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestRemindEvent value) =>
        SignatureRequestRemindEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestIncompleteQesEvent value) =>
        SignatureRequestIncompleteQesEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestDestroyedEvent value) =>
        SignatureRequestDestroyedEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestCanceledEvent value) =>
        SignatureRequestCanceledEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestDeclinedEvent value) =>
        SignatureRequestDeclinedEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestExpiredEvent value) =>
        SignatureRequestExpiredEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestReassignedEvent value) =>
        SignatureRequestReassignedEvent(value);

    public static implicit operator EventCallbackPayload1(SignatureRequestPreparedEvent value) =>
        SignatureRequestPreparedEvent(value);

    public static implicit operator EventCallbackPayload1(AccountConfirmedEvent value) => AccountConfirmedEvent(value);

    public static implicit operator EventCallbackPayload1(UnknownErrorEvent value) => UnknownErrorEvent(value);

    public static implicit operator EventCallbackPayload1(FileErrorEvent value) => FileErrorEvent(value);

    public static implicit operator EventCallbackPayload1(TemplateCreatedEvent value) => TemplateCreatedEvent(value);

    public static implicit operator EventCallbackPayload1(TemplateErrorEvent value) => TemplateErrorEvent(value);

    public static implicit operator EventCallbackPayload1(SignUrlInvalidEvent value) => SignUrlInvalidEvent(value);

    public static implicit operator EventCallbackPayload1(CallbackTestEvent value) => CallbackTestEvent(value);

    public static implicit operator EventCallbackPayload1(FaxReceivedEvent value) => FaxReceivedEvent(value);

    public static implicit operator EventCallbackPayload1(FaxSentEvent value) => FaxSentEvent(value);

    public static implicit operator EventCallbackPayload1(FaxOnHoldEvent value) => FaxOnHoldEvent(value);

    public static implicit operator EventCallbackPayload1(FaxBusyEvent value) => FaxBusyEvent(value);

    public static implicit operator EventCallbackPayload1(FaxNoAnswerEvent value) => FaxNoAnswerEvent(value);

    public static implicit operator EventCallbackPayload1(FaxDisconnectedEvent value) => FaxDisconnectedEvent(value);

    public static implicit operator EventCallbackPayload1(FaxBlacklistedEvent value) => FaxBlacklistedEvent(value);
}

file sealed class EventCallbackPayload1Converter : JsonConverter<EventCallbackPayload1>
{
    public override EventCallbackPayload1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SignatureRequestViewedEvent>(
            root,
            options,
            out var signatureRequestViewedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestViewedEvent(signatureRequestViewedEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestSignedEvent>(
            root,
            options,
            out var signatureRequestSignedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestSignedEvent(signatureRequestSignedEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestSignerRemovedEvent>(
            root,
            options,
            out var signatureRequestSignerRemovedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestSignerRemovedEvent(signatureRequestSignerRemovedEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestDownloadableEvent>(
            root,
            options,
            out var signatureRequestDownloadableEventValue))
        {
            return EventCallbackPayload1.SignatureRequestDownloadableEvent(signatureRequestDownloadableEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestSentEvent>(
            root,
            options,
            out var signatureRequestSentEventValue))
        {
            return EventCallbackPayload1.SignatureRequestSentEvent(signatureRequestSentEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestAllSignedEvent>(
            root,
            options,
            out var signatureRequestAllSignedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestAllSignedEvent(signatureRequestAllSignedEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestInvalidEvent>(
            root,
            options,
            out var signatureRequestInvalidEventValue))
        {
            return EventCallbackPayload1.SignatureRequestInvalidEvent(signatureRequestInvalidEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestEmailBounceEvent>(
            root,
            options,
            out var signatureRequestEmailBounceEventValue))
        {
            return EventCallbackPayload1.SignatureRequestEmailBounceEvent(signatureRequestEmailBounceEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestRemindEvent>(
            root,
            options,
            out var signatureRequestRemindEventValue))
        {
            return EventCallbackPayload1.SignatureRequestRemindEvent(signatureRequestRemindEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestIncompleteQesEvent>(
            root,
            options,
            out var signatureRequestIncompleteQesEventValue))
        {
            return EventCallbackPayload1.SignatureRequestIncompleteQesEvent(signatureRequestIncompleteQesEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestDestroyedEvent>(
            root,
            options,
            out var signatureRequestDestroyedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestDestroyedEvent(signatureRequestDestroyedEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestCanceledEvent>(
            root,
            options,
            out var signatureRequestCanceledEventValue))
        {
            return EventCallbackPayload1.SignatureRequestCanceledEvent(signatureRequestCanceledEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestDeclinedEvent>(
            root,
            options,
            out var signatureRequestDeclinedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestDeclinedEvent(signatureRequestDeclinedEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestExpiredEvent>(
            root,
            options,
            out var signatureRequestExpiredEventValue))
        {
            return EventCallbackPayload1.SignatureRequestExpiredEvent(signatureRequestExpiredEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestReassignedEvent>(
            root,
            options,
            out var signatureRequestReassignedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestReassignedEvent(signatureRequestReassignedEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignatureRequestPreparedEvent>(
            root,
            options,
            out var signatureRequestPreparedEventValue))
        {
            return EventCallbackPayload1.SignatureRequestPreparedEvent(signatureRequestPreparedEventValue);
        }
        if (JsonSerializer.TryDeserialize<AccountConfirmedEvent>(root, options, out var accountConfirmedEventValue))
        {
            return EventCallbackPayload1.AccountConfirmedEvent(accountConfirmedEventValue);
        }
        if (JsonSerializer.TryDeserialize<UnknownErrorEvent>(root, options, out var unknownErrorEventValue))
        {
            return EventCallbackPayload1.UnknownErrorEvent(unknownErrorEventValue);
        }
        if (JsonSerializer.TryDeserialize<FileErrorEvent>(root, options, out var fileErrorEventValue))
        {
            return EventCallbackPayload1.FileErrorEvent(fileErrorEventValue);
        }
        if (JsonSerializer.TryDeserialize<TemplateCreatedEvent>(root, options, out var templateCreatedEventValue))
        {
            return EventCallbackPayload1.TemplateCreatedEvent(templateCreatedEventValue);
        }
        if (JsonSerializer.TryDeserialize<TemplateErrorEvent>(root, options, out var templateErrorEventValue))
        {
            return EventCallbackPayload1.TemplateErrorEvent(templateErrorEventValue);
        }
        if (JsonSerializer.TryDeserialize<SignUrlInvalidEvent>(root, options, out var signUrlInvalidEventValue))
        {
            return EventCallbackPayload1.SignUrlInvalidEvent(signUrlInvalidEventValue);
        }
        if (JsonSerializer.TryDeserialize<CallbackTestEvent>(root, options, out var callbackTestEventValue))
        {
            return EventCallbackPayload1.CallbackTestEvent(callbackTestEventValue);
        }
        if (JsonSerializer.TryDeserialize<FaxReceivedEvent>(root, options, out var faxReceivedEventValue))
        {
            return EventCallbackPayload1.FaxReceivedEvent(faxReceivedEventValue);
        }
        if (JsonSerializer.TryDeserialize<FaxSentEvent>(root, options, out var faxSentEventValue))
        {
            return EventCallbackPayload1.FaxSentEvent(faxSentEventValue);
        }
        if (JsonSerializer.TryDeserialize<FaxOnHoldEvent>(root, options, out var faxOnHoldEventValue))
        {
            return EventCallbackPayload1.FaxOnHoldEvent(faxOnHoldEventValue);
        }
        if (JsonSerializer.TryDeserialize<FaxBusyEvent>(root, options, out var faxBusyEventValue))
        {
            return EventCallbackPayload1.FaxBusyEvent(faxBusyEventValue);
        }
        if (JsonSerializer.TryDeserialize<FaxNoAnswerEvent>(root, options, out var faxNoAnswerEventValue))
        {
            return EventCallbackPayload1.FaxNoAnswerEvent(faxNoAnswerEventValue);
        }
        if (JsonSerializer.TryDeserialize<FaxDisconnectedEvent>(root, options, out var faxDisconnectedEventValue))
        {
            return EventCallbackPayload1.FaxDisconnectedEvent(faxDisconnectedEventValue);
        }
        if (JsonSerializer.TryDeserialize<FaxBlacklistedEvent>(root, options, out var faxBlacklistedEventValue))
        {
            return EventCallbackPayload1.FaxBlacklistedEvent(faxBlacklistedEventValue);
        }
        throw new JsonException(
            $"JSON does not match SignatureRequestViewedEvent or SignatureRequestSignedEvent or SignatureRequestSignerRemovedEvent or SignatureRequestDownloadableEvent or SignatureRequestSentEvent or SignatureRequestAllSignedEvent or SignatureRequestInvalidEvent or SignatureRequestEmailBounceEvent or SignatureRequestRemindEvent or SignatureRequestIncompleteQesEvent or SignatureRequestDestroyedEvent or SignatureRequestCanceledEvent or SignatureRequestDeclinedEvent or SignatureRequestExpiredEvent or SignatureRequestReassignedEvent or SignatureRequestPreparedEvent or AccountConfirmedEvent or UnknownErrorEvent or FileErrorEvent or TemplateCreatedEvent or TemplateErrorEvent or SignUrlInvalidEvent or CallbackTestEvent or FaxReceivedEvent or FaxSentEvent or FaxOnHoldEvent or FaxBusyEvent or FaxNoAnswerEvent or FaxDisconnectedEvent or FaxBlacklistedEvent schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EventCallbackPayload1 value, JsonSerializerOptions options)
    {
        if (value.TryGetSignatureRequestViewedEvent(out var signatureRequestViewedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestViewedEventValue, options);
        }
        else if (value.TryGetSignatureRequestSignedEvent(out var signatureRequestSignedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestSignedEventValue, options);
        }
        else if (value.TryGetSignatureRequestSignerRemovedEvent(out var signatureRequestSignerRemovedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestSignerRemovedEventValue, options);
        }
        else if (value.TryGetSignatureRequestDownloadableEvent(out var signatureRequestDownloadableEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestDownloadableEventValue, options);
        }
        else if (value.TryGetSignatureRequestSentEvent(out var signatureRequestSentEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestSentEventValue, options);
        }
        else if (value.TryGetSignatureRequestAllSignedEvent(out var signatureRequestAllSignedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestAllSignedEventValue, options);
        }
        else if (value.TryGetSignatureRequestInvalidEvent(out var signatureRequestInvalidEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestInvalidEventValue, options);
        }
        else if (value.TryGetSignatureRequestEmailBounceEvent(out var signatureRequestEmailBounceEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestEmailBounceEventValue, options);
        }
        else if (value.TryGetSignatureRequestRemindEvent(out var signatureRequestRemindEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestRemindEventValue, options);
        }
        else if (value.TryGetSignatureRequestIncompleteQesEvent(out var signatureRequestIncompleteQesEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestIncompleteQesEventValue, options);
        }
        else if (value.TryGetSignatureRequestDestroyedEvent(out var signatureRequestDestroyedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestDestroyedEventValue, options);
        }
        else if (value.TryGetSignatureRequestCanceledEvent(out var signatureRequestCanceledEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestCanceledEventValue, options);
        }
        else if (value.TryGetSignatureRequestDeclinedEvent(out var signatureRequestDeclinedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestDeclinedEventValue, options);
        }
        else if (value.TryGetSignatureRequestExpiredEvent(out var signatureRequestExpiredEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestExpiredEventValue, options);
        }
        else if (value.TryGetSignatureRequestReassignedEvent(out var signatureRequestReassignedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestReassignedEventValue, options);
        }
        else if (value.TryGetSignatureRequestPreparedEvent(out var signatureRequestPreparedEventValue))
        {
            JsonSerializer.Serialize(writer, signatureRequestPreparedEventValue, options);
        }
        else if (value.TryGetAccountConfirmedEvent(out var accountConfirmedEventValue))
        {
            JsonSerializer.Serialize(writer, accountConfirmedEventValue, options);
        }
        else if (value.TryGetUnknownErrorEvent(out var unknownErrorEventValue))
        {
            JsonSerializer.Serialize(writer, unknownErrorEventValue, options);
        }
        else if (value.TryGetFileErrorEvent(out var fileErrorEventValue))
        {
            JsonSerializer.Serialize(writer, fileErrorEventValue, options);
        }
        else if (value.TryGetTemplateCreatedEvent(out var templateCreatedEventValue))
        {
            JsonSerializer.Serialize(writer, templateCreatedEventValue, options);
        }
        else if (value.TryGetTemplateErrorEvent(out var templateErrorEventValue))
        {
            JsonSerializer.Serialize(writer, templateErrorEventValue, options);
        }
        else if (value.TryGetSignUrlInvalidEvent(out var signUrlInvalidEventValue))
        {
            JsonSerializer.Serialize(writer, signUrlInvalidEventValue, options);
        }
        else if (value.TryGetCallbackTestEvent(out var callbackTestEventValue))
        {
            JsonSerializer.Serialize(writer, callbackTestEventValue, options);
        }
        else if (value.TryGetFaxReceivedEvent(out var faxReceivedEventValue))
        {
            JsonSerializer.Serialize(writer, faxReceivedEventValue, options);
        }
        else if (value.TryGetFaxSentEvent(out var faxSentEventValue))
        {
            JsonSerializer.Serialize(writer, faxSentEventValue, options);
        }
        else if (value.TryGetFaxOnHoldEvent(out var faxOnHoldEventValue))
        {
            JsonSerializer.Serialize(writer, faxOnHoldEventValue, options);
        }
        else if (value.TryGetFaxBusyEvent(out var faxBusyEventValue))
        {
            JsonSerializer.Serialize(writer, faxBusyEventValue, options);
        }
        else if (value.TryGetFaxNoAnswerEvent(out var faxNoAnswerEventValue))
        {
            JsonSerializer.Serialize(writer, faxNoAnswerEventValue, options);
        }
        else if (value.TryGetFaxDisconnectedEvent(out var faxDisconnectedEventValue))
        {
            JsonSerializer.Serialize(writer, faxDisconnectedEventValue, options);
        }
        else if (value.TryGetFaxBlacklistedEvent(out var faxBlacklistedEventValue))
        {
            JsonSerializer.Serialize(writer, faxBlacklistedEventValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EventCallbackPayload1)} contains no valid value to serialize.");
        }
    }
}
