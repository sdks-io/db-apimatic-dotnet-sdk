using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DropboxSignApi.Core;
using DropboxSignApi.Core.Authentication;
using DropboxSignApi.Core.Exceptions;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Request;
using DropboxSignApi.Core.Response;
using DropboxSignApi.Errors;
using DropboxSignApi.Models;
using DropboxSignApi.Requests.UnclaimedDraft;

namespace DropboxSignApi.Api;

public sealed class UnclaimedDraft
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UnclaimedDraft(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create Unclaimed Draft
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UnclaimedDraftCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UnclaimedDraftCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new Draft that can be claimed using the claim URL. The first authenticated user to access the URL will claim the Draft and will be shown either the "Sign and send" or the "Request signature" page with the Draft loaded. Subsequent access to the claim URL will result in a 404.
    /// </remarks>
    public Task<UnclaimedDraftCreateResponse> UnclaimedDraftCreate(UnclaimedDraftCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/unclaimed_draft/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("type", request.Type),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_email_addresses", request.CcEmailAddresses),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("hide_text_tags", request.HideTextTags),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("show_progress_stepper", request.ShowProgressStepper),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("use_preexisting_fields", request.UsePreexistingFields),
                new MultipartParam("use_text_tags", request.UseTextTags),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<UnclaimedDraftCreateResponse>(),
            UnclaimedDraftCreateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create Embedded Unclaimed Draft
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UnclaimedDraftCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UnclaimedDraftCreateEmbeddedError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new Draft that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the "Request signature" page with the Draft loaded. Subsequent access to the claim URL will result in a <c>404</c>. For this embedded endpoint the <c>requester_email_address</c> parameter is required.
    /// <para>
    /// <b>NOTE:</b> Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.
    /// </para>
    /// </remarks>
    public Task<UnclaimedDraftCreateResponse> UnclaimedDraftCreateEmbedded(UnclaimedDraftCreateEmbeddedOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/unclaimed_draft/create_embedded"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("requester_email_address", request.RequesterEmailAddress),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("allow_ccs", request.AllowCcs),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_email_addresses", request.CcEmailAddresses),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("editor_options", request.EditorOptions),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("force_signer_page", request.ForceSignerPage),
                new MultipartParam("force_subject_message", request.ForceSubjectMessage),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("hide_text_tags", request.HideTextTags),
                new MultipartParam("hold_request", request.HoldRequest),
                new MultipartParam("is_for_embedded_signing", request.IsForEmbeddedSigning),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("requesting_redirect_url", request.RequestingRedirectUrl),
                new MultipartParam("show_preview", request.ShowPreview),
                new MultipartParam("show_progress_stepper", request.ShowProgressStepper),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("skip_me_now", request.SkipMeNow),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("type", request.Type),
                new MultipartParam("use_preexisting_fields", request.UsePreexistingFields),
                new MultipartParam("use_text_tags", request.UseTextTags),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors),
                new MultipartParam("populate_auto_fill_fields", request.PopulateAutoFillFields),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<UnclaimedDraftCreateResponse>(),
            UnclaimedDraftCreateEmbeddedError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create Embedded Unclaimed Draft with Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UnclaimedDraftCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UnclaimedDraftCreateEmbeddedWithTemplateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new Draft with a previously saved template(s) that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the "Request signature" page with the Draft loaded. Subsequent access to the claim URL will result in a <c>404</c>. For this embedded endpoint the <c>requester_email_address</c> parameter is required.
    /// <para>
    /// <b>NOTE:</b> Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.
    /// </para>
    /// </remarks>
    public Task<UnclaimedDraftCreateResponse> UnclaimedDraftCreateEmbeddedWithTemplate(UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/unclaimed_draft/create_embedded_with_template"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("requester_email_address", request.RequesterEmailAddress),
                new MultipartParam("template_ids", request.TemplateIds),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("ccs", request.Ccs),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("editor_options", request.EditorOptions),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("force_signer_roles", request.ForceSignerRoles),
                new MultipartParam("force_subject_message", request.ForceSubjectMessage),
                new MultipartParam("hold_request", request.HoldRequest),
                new MultipartParam("is_for_embedded_signing", request.IsForEmbeddedSigning),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("preview_only", request.PreviewOnly),
                new MultipartParam("requesting_redirect_url", request.RequestingRedirectUrl),
                new MultipartParam("show_preview", request.ShowPreview),
                new MultipartParam("show_progress_stepper", request.ShowProgressStepper),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("skip_me_now", request.SkipMeNow),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("populate_auto_fill_fields", request.PopulateAutoFillFields),
                new MultipartParam("allow_ccs", request.AllowCcs)),
            JsonResponse.Create<UnclaimedDraftCreateResponse>(),
            UnclaimedDraftCreateEmbeddedWithTemplateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Edit and Resend Unclaimed Draft
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UnclaimedDraftCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UnclaimedDraftEditAndResendError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new signature request from an embedded request that can be edited prior to being sent to the recipients. Parameter <c>test_mode</c> can be edited prior to request. Signers can be edited in embedded editor. Requester's email address will remain unchanged if <c>requester_email_address</c> parameter is not set.
    /// <para>
    /// <b>NOTE:</b> Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.
    /// </para>
    /// </remarks>
    public Task<UnclaimedDraftCreateResponse> UnclaimedDraftEditAndResend(UnclaimedDraftEditAndResendOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/unclaimed_draft/edit_and_resend/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UnclaimedDraftCreateResponse>(),
            UnclaimedDraftEditAndResendError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
