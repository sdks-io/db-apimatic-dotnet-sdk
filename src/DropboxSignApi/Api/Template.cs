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
using DropboxSignApi.Requests.Template;

namespace DropboxSignApi.Api;

public sealed class Template
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Template(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add User to Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TemplateGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateAddUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gives the specified Account access to the specified Template. The specified Account must be a part of your Team.
    /// </remarks>
    public Task<TemplateGetResponse> TemplateAddUser(TemplateAddUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/add_user/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TemplateGetResponse>(),
            TemplateAddUserError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TemplateCreateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a template that can be used in future signature requests.
    /// <para>
    /// If <c>client_id</c> is provided, the template will be created as an embedded template. Embedded templates can be used for embedded signature requests and can be edited later by generating a new <c>edit_url</c> with <see href="/api/reference/operation/embeddedEditUrl/">/embedded/edit_url/{template_id}</see>.
    /// </para>
    /// <para>
    /// Template creation may complete asynchronously after the initial request is accepted. It is recommended that a callback be implemented to listen for the callback event. A <c>template_created</c> event indicates the template is ready to use, while a <c>template_error</c> event indicates there was a problem while creating the template. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the API dashboard and retry the request if necessary.
    /// </para>
    /// </remarks>
    public Task<TemplateCreateResponse> TemplateCreate(TemplateCreateOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("signer_roles", request.SignerRoles),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_roles", request.CcRoles),
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("merge_fields", request.MergeFields),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("use_preexisting_fields", request.UsePreexistingFields),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors)),
            JsonResponse.Create<TemplateCreateResponse>(),
            TemplateCreateError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create Embedded Template Draft
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TemplateCreateEmbeddedDraftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateCreateEmbeddedDraftError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The first step in an embedded template workflow. Creates a draft template that can then be further set up in the template 'edit' stage.
    /// </remarks>
    public Task<TemplateCreateEmbeddedDraftResponse> TemplateCreateEmbeddedDraft(TemplateCreateEmbeddedDraftOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/create_embedded_draft"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("allow_ccs", request.AllowCcs),
                new MultipartParam("allow_reassign", request.AllowReassign),
                new MultipartParam("attachments", request.Attachments),
                new MultipartParam("cc_roles", request.CcRoles),
                new MultipartParam("editor_options", request.EditorOptions),
                new MultipartParam("field_options", request.FieldOptions),
                new MultipartParam("force_signer_roles", request.ForceSignerRoles),
                new MultipartParam("force_subject_message", request.ForceSubjectMessage),
                new MultipartParam("form_field_groups", request.FormFieldGroups),
                new MultipartParam("form_field_rules", request.FormFieldRules),
                new MultipartParam("form_fields_per_document", request.FormFieldsPerDocument),
                new MultipartParam("merge_fields", request.MergeFields),
                new MultipartParam("message", request.Message),
                new MultipartParam("metadata", request.Metadata),
                new MultipartParam("show_preview", request.ShowPreview),
                new MultipartParam("show_progress_stepper", request.ShowProgressStepper),
                new MultipartParam("signer_roles", request.SignerRoles),
                new MultipartParam("skip_me_now", request.SkipMeNow),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode),
                new MultipartParam("title", request.Title),
                new MultipartParam("use_preexisting_fields", request.UsePreexistingFields),
                new MultipartParam("ignore_text_tags_extraction_errors", request.IgnoreTextTagsExtractionErrors)),
            JsonResponse.Create<TemplateCreateEmbeddedDraftResponse>(),
            TemplateCreateEmbeddedDraftError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completely deletes the template specified from the account.
    /// </remarks>
    public Task<object> TemplateDelete(TemplateDeleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/delete/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            TemplateDeleteError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Template Files
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateFilesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Obtain a copy of the current documents specified by the <c>template_id</c> parameter. Returns a PDF or ZIP file.
    /// <para>
    /// If the files are currently being prepared, a status code of <c>409</c> will be returned instead. In this case please wait for the <c>template_created</c> callback event.
    /// </para>
    /// </remarks>
    public Task TemplateFiles(TemplateFilesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/files/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [new Param("file_type", request.FileType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            TemplateFilesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Template Files as Data Uri
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FileResponseDataUri"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateFilesAsDataUriError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Obtain a copy of the current documents specified by the <c>template_id</c> parameter. Returns a JSON object with a <c>data_uri</c> representing the base64 encoded file (PDFs only).
    /// <para>
    /// If the files are currently being prepared, a status code of <c>409</c> will be returned instead. In this case please wait for the <c>template_created</c> callback event.
    /// </para>
    /// </remarks>
    public Task<FileResponseDataUri> TemplateFilesAsDataUri(TemplateFilesAsDataUriRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/files_as_data_uri/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FileResponseDataUri>(),
            TemplateFilesAsDataUriError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Template Files as File Url
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateFilesAsFileUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Obtain a copy of the current documents specified by the <c>template_id</c> parameter. Returns a JSON object with a url to the file (PDFs only).
    /// <para>
    /// If the files are currently being prepared, a status code of <c>409</c> will be returned instead. In this case please wait for the <c>template_created</c> callback event.
    /// </para>
    /// </remarks>
    public Task<FileResponse> TemplateFilesAsFileUrl(TemplateFilesAsFileUrlRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/files_as_file_url/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [new Param("force_download", request.ForceDownload)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FileResponse>(),
            TemplateFilesAsFileUrlError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TemplateGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the Template specified by the <c>template_id</c> parameter.
    /// </remarks>
    public Task<TemplateGetResponse> TemplateGet(TemplateGetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TemplateGetResponse>(),
            TemplateGetError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List Templates
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TemplateListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of the Templates that are accessible by you.
    /// <para>
    /// Take a look at our <see href="/api/reference/search/">search guide</see> to learn more about querying templates.
    /// </para>
    /// </remarks>
    public Task<TemplateListResponse> TemplateList(TemplateListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/list"),
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
            JsonResponse.Create<TemplateListResponse>(),
            TemplateListError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove User from Template
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TemplateGetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateRemoveUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the specified Account's access to the specified Template.
    /// </remarks>
    public Task<TemplateGetResponse> TemplateRemoveUser(TemplateRemoveUserOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/remove_user/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TemplateGetResponse>(),
            TemplateRemoveUserError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update Template Files
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TemplateUpdateFilesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TemplateUpdateFilesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Overlays a new file with the overlay of an existing template. The new file(s) must:
    /// <list type="number">
    ///   <item><description>have the same or higher page count</description></item>
    ///   <item><description>the same orientation as the file(s) being replaced.</description></item>
    /// </list>
    /// <para>
    /// This will not overwrite or in any way affect the existing template. Both the existing template and new template will be available for use after executing this endpoint. Also note that this will decrement your template quota.
    /// </para>
    /// <para>
    /// Overlaying new files is asynchronous and a successful call to this endpoint will return 200 OK response if the request passes initial validation checks.
    /// </para>
    /// <para>
    /// It is recommended that a callback be implemented to listen for the callback event. A <c>template_created</c> event will be sent when the files are updated or a <c>template_error</c> event will be sent if there was a problem while updating the files. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the API dashboard and retry the request if necessary.
    /// </para>
    /// <para>
    /// If the page orientation or page count is different from the original template document, we will notify you with a <c>template_error</c> <see href="https://app.hellosign.com/api/eventsAndCallbacksWalkthrough">callback event</see>.
    /// </para>
    /// </remarks>
    public Task<TemplateUpdateFilesResponse> TemplateUpdateFiles(TemplateUpdateFilesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/template/update_files/{template_id}"),
            [new TemplateParam("template_id", request.TemplateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("client_id", request.ClientId),
                new MultipartParam("files", request.Files),
                new MultipartParam("file_urls", request.FileUrls),
                new MultipartParam("message", request.Message),
                new MultipartParam("subject", request.Subject),
                new MultipartParam("test_mode", request.TestMode)),
            JsonResponse.Create<TemplateUpdateFilesResponse>(),
            TemplateUpdateFilesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.Oauth2)],
            requestOptions,
            cancellationToken);
}
