using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;
using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.UnclaimedDraft;

/// <summary>
/// The inputs of the UnclaimedDraftCreateEmbeddedWithTemplate operation.
/// </summary>
public sealed record UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest
{
    /// <summary>
    /// Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.
    /// </summary>
    public required string ClientId { get; init; }

    /// <summary>
    /// The email address of the user that should be designated as the requester of this draft.
    /// </summary>
    [Format(FormatKind.Email)]
    public required string RequesterEmailAddress { get; init; }

    /// <summary>
    /// Use <c>template_ids</c> to create a SignatureRequest from one or more templates, in the order in which the templates will be used.
    /// </summary>
    public required IReadOnlyList<string> TemplateIds { get; init; }

    /// <summary>
    /// Allows signers to decline to sign a document if <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool AllowDecline { get; init; } = false;

    /// <summary>
    /// Allows signers to reassign their signature requests to other signers if set to <c>true</c>. Defaults to <c>false</c>.
    /// <para>
    /// <b>NOTE:</b> Only available for Premium plan and higher.
    /// </para>
    /// </summary>
    public bool AllowReassign { get; init; } = false;

    /// <summary>
    /// Add CC email recipients. Required when a CC role exists for the Template.
    /// </summary>
    public IReadOnlyList<SubCc>? Ccs { get; init; }

    /// <summary>
    /// An array defining values and options for custom fields. Required when a custom field exists in the Template.
    /// </summary>
    public IReadOnlyList<SubCustomField>? CustomFields { get; init; }

    /// <summary>
    /// This allows the requester to specify editor options when a preparing a document
    /// </summary>
    public SubEditorOptions? EditorOptions { get; init; }

    /// <summary>
    /// This allows the requester to specify field options for a signature request.
    /// </summary>
    public SubFieldOptions? FieldOptions { get; init; }

    /// <summary>
    /// Use <c>files[]</c> to append additional files to the signature request being created from the template. Dropbox Sign will parse the files for <see href="https://app.hellosign.com/api/textTagsWalkthrough">text tags</see> and append it to the signature request. Text tags for signers not on the template(s) will be ignored.
    /// <para>
    /// <b>files</b> or <b>file_urls[]</b> is required, but not both.
    /// </para>
    /// </summary>
    public BinaryContent? Files { get; init; }

    /// <summary>
    /// Use file_urls[] to append additional files to the signature request being created from the template. Dropbox Sign will download the file, then parse it for <see href="https://app.hellosign.com/api/textTagsWalkthrough">text tags</see>, and append to the signature request. Text tags for signers not on the template(s) will be ignored.
    /// <para>
    /// <b>files</b> or <b>file_urls[]</b> is required, but not both.
    /// </para>
    /// </summary>
    public IReadOnlyList<string>? FileUrls { get; init; }

    /// <summary>
    /// Provide users the ability to review/edit the template signer roles.
    /// </summary>
    public bool ForceSignerRoles { get; init; } = false;

    /// <summary>
    /// Provide users the ability to review/edit the template subject and message.
    /// </summary>
    public bool ForceSubjectMessage { get; init; } = false;

    /// <summary>
    /// The request from this draft will not automatically send to signers post-claim if set to 1. Requester must <see href="/api/reference/operation/signatureRequestReleaseHold/">release</see> the request from hold when ready to send. Defaults to <c>false</c>.
    /// </summary>
    public bool HoldRequest { get; init; } = false;

    /// <summary>
    /// The request created from this draft will also be signable in embedded mode if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool IsForEmbeddedSigning { get; init; } = false;

    /// <summary>
    /// The custom message in the email that will be sent to the signers.
    /// </summary>
    [MaxLength(5000)]
    public string? Message { get; init; }

    /// <summary>
    /// Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer's order number for look up when receiving events for the signature request.
    /// <para>
    /// Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.
    /// </para>
    /// </summary>
    public IReadOnlyDictionary<string, object>? Metadata { get; init; }

    /// <summary>
    /// This allows the requester to enable the preview experience (i.e. does not allow the requester's end user to add any additional fields via the editor).
    /// <list type="bullet">
    ///   <item><description><c>preview_only=true</c>: Allows requesters to enable the preview only experience.</description></item>
    ///   <item><description><c>preview_only=false</c>: Allows requesters to disable the preview only experience.</description></item>
    /// </list>
    /// <para>
    /// <b>NOTE:</b> This parameter overwrites <c>show_preview=1</c> (if set).
    /// </para>
    /// </summary>
    public bool PreviewOnly { get; init; } = false;

    /// <summary>
    /// The URL you want signers redirected to after they successfully request a signature.
    /// </summary>
    public string? RequestingRedirectUrl { get; init; }

    /// <summary>
    /// This allows the requester to enable the editor/preview experience.
    /// <list type="bullet">
    ///   <item><description><c>show_preview=true</c>: Allows requesters to enable the editor/preview experience.</description></item>
    ///   <item><description><c>show_preview=false</c>: Allows requesters to disable the editor/preview experience.</description></item>
    /// </list>
    /// </summary>
    public bool ShowPreview { get; init; } = false;

    /// <summary>
    /// When only one step remains in the signature request process and this parameter is set to <c>false</c> then the progress stepper will be hidden.
    /// </summary>
    public bool ShowProgressStepper { get; init; } = true;

    /// <summary>
    /// Add Signers to your Templated-based Signature Request.
    /// </summary>
    public IReadOnlyList<SubUnclaimedDraftTemplateSigner>? Signers { get; init; }

    /// <summary>
    /// This allows the requester to specify the types allowed for creating a signature and specify another signing options.
    /// <para>
    /// <b>NOTE:</b> If <c>signing_options</c> are not defined in the request, the allowed types will default to those specified in the account settings.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> If <c>force_advanced_signature_details</c> is set, allowed types has to be defined too.
    /// </para>
    /// </summary>
    public SubSigningOptions? SigningOptions { get; init; }

    /// <summary>
    /// The URL you want signers redirected to after they successfully sign.
    /// </summary>
    public string? SigningRedirectUrl { get; init; }

    /// <summary>
    /// Disables the "Me (Now)" option for the person preparing the document. Does not work with type <c>send_document</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool SkipMeNow { get; init; } = false;

    /// <summary>
    /// The subject in the email that will be sent to the signers.
    /// </summary>
    [MaxLength(255)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request created from this draft will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool TestMode { get; init; } = false;

    /// <summary>
    /// The title you want to assign to the SignatureRequest.
    /// </summary>
    [MaxLength(255)]
    public string? Title { get; init; }

    /// <summary>
    /// Controls whether <see href="https://faq.hellosign.com/hc/en-us/articles/360051467511-Auto-Fill-Fields">auto fill fields</see> can automatically populate a signer's information during signing.
    /// <para>
    /// <b>NOTE:</b> Keep your signer's information safe by ensuring that the _signer on your signature request is the intended party_ before using this feature.
    /// </para>
    /// </summary>
    public bool PopulateAutoFillFields { get; init; } = false;

    /// <summary>
    /// This allows the requester to specify whether the user is allowed to provide email addresses to CC when claiming the draft.
    /// </summary>
    public bool AllowCcs { get; init; } = false;
}
