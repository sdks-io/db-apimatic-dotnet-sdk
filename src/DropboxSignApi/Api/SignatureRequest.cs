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
using DropboxSignApi.Requests.SignatureRequest;

namespace DropboxSignApi.Api;

public sealed class SignatureRequest
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SignatureRequest(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Embedded Bulk Send with Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkSendJobSendResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestBulkCreateEmbeddedWithTemplateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates BulkSendJob which sends up to 250 SignatureRequests in bulk based off of the provided Template(s) specified with the <c>template_ids</c> parameter to be signed in an embedded iFrame. These embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.
    /// <para>
    /// <b>NOTE:</b> Only available for Standard plan and higher.
    /// </para>
    /// </remarks>
    public Task<BulkSendJobSendResponse> SignatureRequestBulkCreateEmbeddedWithTemplate(SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/bulk_create_embedded_with_template"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("template_ids", request.TemplateIds),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("signer_file", request.SignerFile),
                new MultipartParam("signer_list", request.SignerList),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("ccs", request.Ccs),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<BulkSendJobSendResponse>(),
            SignatureRequestBulkCreateEmbeddedWithTemplateError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Bulk Send with Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkSendJobSendResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestBulkSendWithTemplateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates BulkSendJob which sends up to 250 SignatureRequests in bulk based off of the provided Template(s) specified with the <c>template_ids</c> parameter.
    /// <para>
    /// <b>NOTE:</b> Only available for Standard plan and higher.
    /// </para>
    /// </remarks>
    public Task<BulkSendJobSendResponse> SignatureRequestBulkSendWithTemplate(SignatureRequestBulkSendWithTemplateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/bulk_send_with_template"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("template_ids", request.TemplateIds),
                new MultipartParam("signer_file", request.SignerFile),
                new MultipartParam("signer_list", request.SignerList),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("ccs", request.Ccs),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<BulkSendJobSendResponse>(),
            SignatureRequestBulkSendWithTemplateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel Incomplete Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an incomplete signature request. This action is <b>not reversible</b>.
    /// <para>
    /// The request will be canceled and signers will no longer be able to sign. If they try to access the signature request they will receive a HTTP 410 status code indicating that the resource has been deleted. Cancelation is asynchronous and a successful call to this endpoint will return an empty 200 OK response if the signature request is eligible to be canceled and has been successfully queued.
    /// </para>
    /// <para>
    /// This 200 OK response does not indicate a successful cancelation of the signature request itself. The cancelation is confirmed via the <c>signature_request_canceled</c> event. It is recommended that a <see href="/api/reference/tag/Callbacks-and-Events">callback handler</see> be implemented to listen for the <c>signature_request_canceled</c> event. This callback will be sent only when the cancelation has completed successfully. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the <see href="https://app.hellosign.com/apidashboard">API Dashboard</see> and retry the cancelation if necessary.
    /// </para>
    /// <para>
    /// To be eligible for cancelation, a signature request must have been sent successfully, must not yet have been signed by all signers, and you must either be the sender or own the API app under which it was sent. A partially signed signature request can be canceled.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> To remove your access to a completed signature request, use the endpoint: <c>POST /signature_request/remove/[:signature_request_id]</c>.
    /// </para>
    /// </remarks>
    public Task<object> SignatureRequestCancel(SignatureRequestCancelRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/cancel/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            SignatureRequestCancelError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create Embedded Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestCreateEmbeddedError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new SignatureRequest with the submitted documents to be signed in an embedded iFrame. If form_fields_per_document is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestCreateEmbedded(SignatureRequestCreateEmbeddedOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/create_embedded"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("grouped_signers", request.GroupedSigners),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_email_addresses", request.CcEmailAddresses),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("hide_text_tags", request.HideTextTags),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("use_text_tags", request.UseTextTags),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors),
                new MultipartParam("populate_auto_fill_fields", request.PopulateAutoFillFields),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestCreateEmbeddedError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create Embedded Signature Request with Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestCreateEmbeddedWithTemplateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new SignatureRequest based on the given Template(s) to be signed in an embedded iFrame. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestCreateEmbeddedWithTemplate(SignatureRequestCreateEmbeddedWithTemplateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/create_embedded_with_template"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("template_ids", request.TemplateIds),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("ccs", request.Ccs),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("populate_auto_fill_fields", request.PopulateAutoFillFields),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestCreateEmbeddedWithTemplateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Edit Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestEditError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Edits and sends a SignatureRequest with the submitted documents. If <c>form_fields_per_document</c> is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents.
    /// <para>
    /// <b>NOTE:</b> Edit and resend *will* deduct your signature request quota.
    /// </para>
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestEdit(SignatureRequestEditOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/edit/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormRequest.Create(
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("grouped_signers", request.GroupedSigners),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_email_addresses", request.CcEmailAddresses),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("hide_text_tags", request.HideTextTags),
                new MultipartParam("is_eid", request.IsEid),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("use_text_tags", request.UseTextTags),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestEditError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Edit Embedded Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestEditEmbeddedError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Edits a SignatureRequest with the submitted documents to be signed in an embedded iFrame. If form_fields_per_document is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.
    /// <para>
    /// <b>NOTE:</b> Edit and resend *will* deduct your signature request quota.
    /// </para>
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestEditEmbedded(SignatureRequestEditEmbeddedOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/edit_embedded/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormRequest.Create(
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("grouped_signers", request.GroupedSigners),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_email_addresses", request.CcEmailAddresses),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("hide_text_tags", request.HideTextTags),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("use_text_tags", request.UseTextTags),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors),
                new MultipartParam("populate_auto_fill_fields", request.PopulateAutoFillFields),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestEditEmbeddedError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Edit Embedded Signature Request with Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestEditEmbeddedWithTemplateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Edits a SignatureRequest based on the given Template(s) to be signed in an embedded iFrame. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.
    /// <para>
    /// <b>NOTE:</b> Edit and resend *will* deduct your signature request quota.
    /// </para>
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestEditEmbeddedWithTemplate(SignatureRequestEditEmbeddedWithTemplateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/edit_embedded_with_template/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormRequest.Create(
                new MultipartParam("template_ids", request.TemplateIds),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("ccs", request.Ccs),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("populate_auto_fill_fields", request.PopulateAutoFillFields)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestEditEmbeddedWithTemplateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Edit Signature Request With Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestEditWithTemplateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Edits and sends a SignatureRequest based off of the Template(s) specified with the template_ids parameter.
    /// <para>
    /// <b>NOTE:</b> Edit and resend *will* deduct your signature request quota.
    /// </para>
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestEditWithTemplate(SignatureRequestEditWithTemplateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/edit_with_template/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormRequest.Create(
                new MultipartParam("template_ids", request.TemplateIds),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("ccs", request.Ccs),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("is_eid", request.IsEid),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestEditWithTemplateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Download Files
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestFilesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Obtain a copy of the current documents specified by the <c>signature_request_id</c> parameter. Returns a PDF or ZIP file.
    /// <para>
    /// If the files are currently being prepared, a status code of <c>409</c> will be returned instead.
    /// </para>
    /// </remarks>
    public Task SignatureRequestFiles(SignatureRequestFilesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/files/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [new Param("file_type", request.FileType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SignatureRequestFilesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Download Files as Data Uri
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FileResponseDataUri"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestFilesAsDataUriError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Obtain a copy of the current documents specified by the <c>signature_request_id</c> parameter. Returns a JSON object with a <c>data_uri</c> representing the base64 encoded file (PDFs only).
    /// <para>
    /// If the files are currently being prepared, a status code of <c>409</c> will be returned instead.
    /// </para>
    /// </remarks>
    public Task<FileResponseDataUri> SignatureRequestFilesAsDataUri(SignatureRequestFilesAsDataUriRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/files_as_data_uri/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FileResponseDataUri>(),
            SignatureRequestFilesAsDataUriError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Download Files as File Url
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestFilesAsFileUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Obtain a copy of the current documents specified by the <c>signature_request_id</c> parameter. Returns a JSON object with a url to the file (PDFs only).
    /// <para>
    /// If the files are currently being prepared, a status code of <c>409</c> will be returned instead.
    /// </para>
    /// </remarks>
    public Task<FileResponse> SignatureRequestFilesAsFileUrl(SignatureRequestFilesAsFileUrlRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/files_as_file_url/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [new Param("force_download", request.ForceDownload)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FileResponse>(),
            SignatureRequestFilesAsFileUrlError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the status of the SignatureRequest specified by the <c>signature_request_id</c> parameter.
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestGet(SignatureRequestGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestGetError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Signature Requests
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of SignatureRequests that you can access. This includes SignatureRequests you have sent as well as received, but not ones that you have been CCed on.
    /// <para>
    /// Take a look at our <see href="/api/reference/search/">search guide</see> to learn more about querying signature requests.
    /// </para>
    /// </remarks>
    public Task<SignatureRequestListResponse> SignatureRequestList(SignatureRequestListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/list"),
            [],
            [
                new Param("account_id", request.AccountId),
                new Param("page", request.Page),
                new Param("page_size", request.PageSize),
                new Param("query", request.Query),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SignatureRequestListResponse>(),
            SignatureRequestListError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Release On-Hold Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestReleaseHoldError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Releases a held SignatureRequest that was claimed and prepared from an <see href="/api/reference/tag/Unclaimed-Draft">UnclaimedDraft</see>. The owner of the Draft must indicate at Draft creation that the SignatureRequest created from the Draft should be held. Releasing the SignatureRequest will send requests to all signers.
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestReleaseHold(SignatureRequestReleaseHoldRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/release_hold/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestReleaseHoldError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Send Request Reminder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestRemindError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends an email to the signer reminding them to sign the signature request. You cannot send a reminder within 1 hour of the last reminder that was sent. This includes manual AND automatic reminders.
    /// <para>
    /// <b>NOTE:</b> This action can <b>not</b> be used with embedded signature requests.
    /// </para>
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestRemind(SignatureRequestRemindOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/remind/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestRemindError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove Signature Request Access
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestRemoveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes your access to a completed signature request. This action is <b>not reversible</b>.
    /// <para>
    /// The signature request must be fully executed by all parties (signed or declined to sign). Other parties will continue to maintain access to the completed signature request document(s).
    /// </para>
    /// <para>
    /// Unlike /signature_request/cancel, this endpoint is synchronous and your access will be immediately removed. Upon successful removal, this endpoint will return a 200 OK response.
    /// </para>
    /// </remarks>
    public Task<object> SignatureRequestRemove(SignatureRequestRemoveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/remove/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            SignatureRequestRemoveError.Response,
            [_auth.ApiKey],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Send Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestSendError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates and sends a new SignatureRequest with the submitted documents. If <c>form_fields_per_document</c> is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents.
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestSend(SignatureRequestSendOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/send"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("grouped_signers", request.GroupedSigners),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_email_addresses", request.CcEmailAddresses),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("hide_text_tags", request.HideTextTags),
                new MultipartParam("is_eid", request.IsEid),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("use_text_tags", request.UseTextTags),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestSendError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Send with Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestSendWithTemplateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates and sends a new SignatureRequest based off of the Template(s) specified with the <c>template_ids</c> parameter.
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestSendWithTemplate(SignatureRequestSendWithTemplateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/send_with_template"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("template_ids", request.TemplateIds),
                new MultipartParam("signers", request.Signers),
                new MultipartParam("allow_decline", request.AllowDecline),
                new MultipartParam("ccs", request.Ccs),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("custom_fields", request.CustomFields),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("is_eid", request.IsEid),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("signing_options", request.SigningOptions),
                new MultipartParam("signing_redirect_url", request.SigningRedirectUrl),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("expires_at", request.ExpiresAt)),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestSendWithTemplateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update Signature Request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignatureRequestGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SignatureRequestUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the email address and/or the name for a given signer on a signature request. You can listen for the <c>signature_request_email_bounce</c> event on your app or account to detect bounced emails, and respond with this method.
    /// <para>
    /// Updating the email address of a signer will generate a new <c>signature_id</c> value.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> This action cannot be performed on a signature request with an appended signature page.
    /// </para>
    /// </remarks>
    public Task<SignatureRequestGetResponse> SignatureRequestUpdate(SignatureRequestUpdateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/signature_request/update/{signature_request_id}"),
            [new TemplateParam("signature_request_id", request.SignatureRequestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SignatureRequestGetResponse>(),
            SignatureRequestUpdateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
