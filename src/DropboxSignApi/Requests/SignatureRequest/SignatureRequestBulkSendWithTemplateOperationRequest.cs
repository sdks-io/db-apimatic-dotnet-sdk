using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestBulkSendWithTemplate operation.
/// </summary>
public sealed record SignatureRequestBulkSendWithTemplateOperationRequest
{
    /// <summary>
    /// Use <c>template_ids</c> to create a SignatureRequest from one or more templates, in the order in which the template will be used.
    /// </summary>
    public required IReadOnlyList<string> TemplateIds { get; init; }

    /// <summary>
    /// <c>signer_file</c> is a CSV file defining values and options for signer fields. Required unless a <c>signer_list</c> is used, you may not use both. The CSV can have the following columns:
    /// <list type="bullet">
    ///   <item><description><c>name</c>: the name of the signer filling the role of RoleName</description></item>
    ///   <item><description><c>email_address</c>: email address of the signer filling the role of RoleName</description></item>
    ///   <item><description><c>pin</c>: the 4- to 12-character access code that will secure this signer's signature page (optional)</description></item>
    ///   <item><description><c>sms_phone_number</c>: An E.164 formatted phone number that will receive a code via SMS to access this signer's signature page. (optional)</description></item>
    /// </list>
    /// <para>
    ///     By using the feature, you agree you are responsible for obtaining a signer's consent to receive text messages from Dropbox Sign related to this signature request and confirm you have obtained such consent from all signers prior to enabling SMS delivery for this signature request. <see href="https://faq.hellosign.com/hc/en-us/articles/15815316468877-Dropbox-Sign-SMS-tools-add-on">Learn more</see>.
    /// </para>
    /// <para>
    ///     <b>NOTE:</b> Not available in test mode and requires a Standard plan or higher.
    /// - <c>*_field</c>: any column with a _field" suffix will be treated as a custom field (optional)
    /// </para>
    /// <para>
    ///     You may only specify field values here, any other options should be set in the custom_fields request parameter.
    /// </para>
    /// <para>
    /// Example CSV:
    /// </para>
    /// <code>
    /// name, email_address, pin, company_field
    /// George, george@example.com, d79a3td, ABC Corp
    /// Mary, mary@example.com, gd9as5b, 123 LLC
    /// </code>
    /// </summary>
    public BinaryContent? SignerFile { get; init; }

    /// <summary>
    /// <c>signer_list</c> is an array defining values and options for signer fields. Required unless a <c>signer_file</c> is used, you may not use both.
    /// </summary>
    public IReadOnlyList<SubBulkSignerList>? SignerList { get; init; }

    /// <summary>
    /// Allows signers to decline to sign a document if <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool AllowDecline { get; init; } = false;

    /// <summary>
    /// Add CC email recipients. Required when a CC role exists for the Template.
    /// </summary>
    public IReadOnlyList<SubCc>? Ccs { get; init; }

    /// <summary>
    /// The client id of the API App you want to associate with this request. Used to apply the branding and callback url defined for the app.
    /// </summary>
    public string? ClientId { get; init; }

    /// <summary>
    /// When used together with merge fields, <c>custom_fields</c> allows users to add pre-filled data to their signature requests.
    /// <para>
    /// Pre-filled data can be used with "send-once" signature requests by adding merge fields with <c>form_fields_per_document</c> or <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> while passing values back with <c>custom_fields</c> together in one API call.
    /// </para>
    /// <para>
    /// For using pre-filled on repeatable signature requests, merge fields are added to templates in the Dropbox Sign UI or by calling <see href="/api/reference/operation/templateCreateEmbeddedDraft">/template/create_embedded_draft</see> and then passing <c>custom_fields</c> on subsequent signature requests referencing that template.
    /// </para>
    /// </summary>
    public IReadOnlyList<SubCustomField>? CustomFields { get; init; }

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
    /// The URL you want signers redirected to after they successfully sign.
    /// </summary>
    public string? SigningRedirectUrl { get; init; }

    /// <summary>
    /// The subject in the email that will be sent to the signers.
    /// </summary>
    [MaxLength(255)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool TestMode { get; init; } = false;

    /// <summary>
    /// The title you want to assign to the SignatureRequest.
    /// </summary>
    [MaxLength(255)]
    public string? Title { get; init; }

    /// <summary>
    /// When the signature request will expire. Unsigned signatures will be moved to the expired status, and no longer signable. See <see href="https://developers.hellosign.com/docs/signature-request/expiration/">Signature Request Expiration Date</see> for details.
    /// </summary>
    public int? ExpiresAt { get; init; }
}
