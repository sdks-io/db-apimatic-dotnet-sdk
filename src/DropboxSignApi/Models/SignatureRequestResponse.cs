using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains information about a signature request.
/// </summary>
public record SignatureRequestResponse
{
    /// <summary>
    /// Whether this is a test signature request. Test requests have no legal value. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_mode")]
    public bool? TestMode { get; init; } = false;

    /// <summary>
    /// The id of the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature_request_id")]
    public string? SignatureRequestId { get; init; }

    /// <summary>
    /// The email address of the initiator of the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requester_email_address")]
    public string? RequesterEmailAddress { get; init; }

    /// <summary>
    /// The title the specified Account uses for the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// Default Label for account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; init; }

    /// <summary>
    /// The subject in the email that was initially sent to the signers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    /// <summary>
    /// The custom message in the email that was initially sent to the signers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// The metadata attached to the signature request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, object>? Metadata { get; init; }

    /// <summary>
    /// Time the signature request was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public int? CreatedAt { get; init; }

    /// <summary>
    /// The time when the signature request will expire unsigned signatures. See <see href="https://developers.hellosign.com/docs/signature-request/expiration/">Signature Request Expiration Date</see> for details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public int? ExpiresAt { get; init; }

    /// <summary>
    /// Whether or not the SignatureRequest has been fully executed by all signers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_complete")]
    public bool? IsComplete { get; init; }

    /// <summary>
    /// Whether or not the SignatureRequest has been declined by a signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_declined")]
    public bool? IsDeclined { get; init; }

    /// <summary>
    /// Whether or not an error occurred (either during the creation of the SignatureRequest or during one of the signings).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_error")]
    public bool? HasError { get; init; }

    /// <summary>
    /// The URL where a copy of the request's documents can be downloaded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("files_url")]
    public string? FilesUrl { get; init; }

    /// <summary>
    /// The URL where a signer, after authenticating, can sign the documents. This should only be used by users with existing Dropbox Sign accounts as they will be required to log in before signing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signing_url")]
    public string? SigningUrl { get; init; }

    /// <summary>
    /// The URL where the requester and the signers can view the current status of the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details_url")]
    public string? DetailsUrl { get; init; }

    /// <summary>
    /// A list of email addresses that were CCed on the SignatureRequest. They will receive a copy of the final PDF once all the signers have signed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc_email_addresses")]
    public IReadOnlyList<string>? CcEmailAddresses { get; init; }

    /// <summary>
    /// The URL you want the signer redirected to after they successfully sign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signing_redirect_url")]
    public string? SigningRedirectUrl { get; init; }

    /// <summary>
    /// The path where the completed document can be downloaded
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("final_copy_uri")]
    public string? FinalCopyUri { get; init; }

    /// <summary>
    /// Templates IDs used in this SignatureRequest (if any).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("template_ids")]
    public IReadOnlyList<string>? TemplateIds { get; init; }

    /// <summary>
    /// An array of Custom Field objects containing the name and type of each custom field.
    /// <list type="bullet">
    ///   <item><description>Text Field uses <c>SignatureRequestResponseCustomFieldText</c></description></item>
    ///   <item><description>Checkbox Field uses <c>SignatureRequestResponseCustomFieldCheckbox</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<SignatureRequestResponseCustomFieldBase>? CustomFields { get; init; }

    /// <summary>
    /// Signer attachments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachments")]
    public IReadOnlyList<SignatureRequestResponseAttachment>? Attachments { get; init; }

    /// <summary>
    /// An array of form field objects containing the name, value, and type of each textbox or checkmark field filled in by the signers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_data")]
    public IReadOnlyList<SignatureRequestResponseDataBase>? ResponseData { get; init; }

    /// <summary>
    /// An array of signature objects, 1 for each signer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signatures")]
    public IReadOnlyList<SignatureRequestResponseSignatures>? Signatures { get; init; }

    /// <summary>
    /// The ID of the Bulk Send job which sent the signature request, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bulk_send_job_id")]
    public string? BulkSendJobId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
