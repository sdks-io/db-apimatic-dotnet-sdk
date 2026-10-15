using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// When used together with merge fields, <c>custom_fields</c> allows users to add pre-filled data to their signature requests.
/// <para>
/// Pre-filled data can be used with "send-once" signature requests by adding merge fields with <c>form_fields_per_document</c> or <see href="https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro">Text Tags</see> while passing values back with <c>custom_fields</c> together in one API call.
/// </para>
/// <para>
/// For using pre-filled on repeatable signature requests, merge fields are added to templates in the Dropbox Sign UI or by calling <see href="/api/reference/operation/templateCreateEmbeddedDraft">/template/create_embedded_draft</see> and then passing <c>custom_fields</c> on subsequent signature requests referencing that template.
/// </para>
/// </summary>
public record SubCustomField
{
    /// <summary>
    /// Used to create editable merge fields. When the value matches a role passed in with <c>signers</c>, that role can edit the data that was pre-filled to that field. This field is optional, but required when this custom field object is set to <c>required = true</c>.
    /// <para>
    /// <b>NOTE:</b> Editable merge fields are only supported for single signer requests (or the first signer in ordered signature requests). If used when there are multiple signers in an unordered signature request, the editor value is ignored and the field won't be editable.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editor")]
    public string? Editor { get; init; }

    /// <summary>
    /// The name of a custom field. When working with pre-filled data, the custom field's name must have a matching merge field name or the field will remain empty on the document during signing.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Used to set an editable merge field when working with pre-filled data. When <c>true</c>, the custom field must specify a signer role in <c>editor</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("required")]
    public bool? Required { get; init; } = false;

    /// <summary>
    /// The string that resolves (aka "pre-fills") to the merge field on the final document(s) used for signing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
