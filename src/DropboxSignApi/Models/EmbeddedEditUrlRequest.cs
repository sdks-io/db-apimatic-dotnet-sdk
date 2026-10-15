using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record EmbeddedEditUrlRequest
{
    /// <summary>
    /// This allows the requester to enable/disable to add or change CC roles when editing the template.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_edit_ccs")]
    public bool? AllowEditCcs { get; init; } = false;

    /// <summary>
    /// The CC roles that must be assigned when using the template to send a signature request. To remove all CC roles, pass in a single role with no name. For use in a POST request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc_roles")]
    public IReadOnlyList<string>? CcRoles { get; init; }

    /// <summary>
    /// This allows the requester to specify editor options when a preparing a document
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editor_options")]
    public SubEditorOptions? EditorOptions { get; init; }

    /// <summary>
    /// Provide users the ability to review/edit the template signer roles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("force_signer_roles")]
    public bool? ForceSignerRoles { get; init; } = false;

    /// <summary>
    /// Provide users the ability to review/edit the template subject and message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("force_subject_message")]
    public bool? ForceSubjectMessage { get; init; } = false;

    /// <summary>
    /// Add additional merge fields to the template, which can be used used to pre-fill data by passing values into signature requests made with that template.
    /// <para>
    /// Remove all merge fields on the template by passing an empty array <c>[]</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merge_fields")]
    public IReadOnlyList<SubMergeField>? MergeFields { get; init; }

    /// <summary>
    /// This allows the requester to enable the preview experience (i.e. does not allow the requester's end user to add any additional fields via the editor).
    /// <para>
    /// <b>NOTE:</b> This parameter overwrites <c>show_preview=true</c> (if set).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preview_only")]
    public bool? PreviewOnly { get; init; } = false;

    /// <summary>
    /// This allows the requester to enable the editor/preview experience.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_preview")]
    public bool? ShowPreview { get; init; } = false;

    /// <summary>
    /// When only one step remains in the signature request process and this parameter is set to <c>false</c> then the progress stepper will be hidden.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_progress_stepper")]
    public bool? ShowProgressStepper { get; init; } = true;

    /// <summary>
    /// Whether this is a test, locked templates will only be available for editing if this is set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_mode")]
    public bool? TestMode { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
