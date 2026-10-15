using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains information about the templates you and your team have created.
/// </summary>
public record TemplateResponse
{
    /// <summary>
    /// The id of the Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("template_id")]
    public string? TemplateId { get; init; }

    /// <summary>
    /// The title of the Template. This will also be the default subject of the message sent to signers when using this Template to send a SignatureRequest. This can be overridden when sending the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// The default message that will be sent to signers when using this Template to send a SignatureRequest. This can be overridden when sending the SignatureRequest.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Time the template was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public int? UpdatedAt { get; init; }

    /// <summary>
    /// <c>true</c> if this template was created using an embedded flow, <c>false</c> if it was created on our website. Will be <c>null</c> when you are not the creator of the Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_embedded")]
    public bool? IsEmbedded { get; init; }

    /// <summary>
    /// <c>true</c> if you are the owner of this template, <c>false</c> if it's been shared with you by a team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_creator")]
    public bool? IsCreator { get; init; }

    /// <summary>
    /// Indicates whether edit rights have been granted to you by the owner (always <c>true</c> if that's you).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_edit")]
    public bool? CanEdit { get; init; }

    /// <summary>
    /// Indicates whether the template is locked.
    /// If <c>true</c>, then the template was created outside your quota and can only be used in <c>test_mode</c>.
    /// If <c>false</c>, then the template is within your quota and can be used to create signature requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_locked")]
    public bool? IsLocked { get; init; }

    /// <summary>
    /// The metadata attached to the template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, object>? Metadata { get; init; }

    /// <summary>
    /// An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signer_roles")]
    public IReadOnlyList<TemplateResponseSignerRole>? SignerRoles { get; init; }

    /// <summary>
    /// An array of the designated CC roles that must be specified when sending a SignatureRequest using this Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc_roles")]
    public IReadOnlyList<TemplateResponseCcRole>? CcRoles { get; init; }

    /// <summary>
    /// An array describing each document associated with this Template. Includes form field data for each document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documents")]
    public IReadOnlyList<TemplateResponseDocument>? Documents { get; init; }

    /// <summary>
    /// Deprecated. Use <c>custom_fields</c> inside the <see href="https://developers.hellosign.com/api/reference/operation/templateGet/#!c=200&amp;path=template/documents&amp;t=response">documents</see> array instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<TemplateResponseDocumentCustomFieldBase>? CustomFields { get; init; }

    /// <summary>
    /// Deprecated. Use <c>form_fields</c> inside the <see href="https://developers.hellosign.com/api/reference/operation/templateGet/#!c=200&amp;path=template/documents&amp;t=response">documents</see> array instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("named_form_fields")]
    public IReadOnlyList<TemplateResponseDocumentFormFieldBase>? NamedFormFields { get; init; }

    /// <summary>
    /// An array of the Accounts that can use this Template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<TemplateResponseAccount>? Accounts { get; init; }

    /// <summary>
    /// Signer attachments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachments")]
    public IReadOnlyList<SignatureRequestResponseAttachment>? Attachments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
