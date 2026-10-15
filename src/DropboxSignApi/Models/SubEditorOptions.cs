using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// This allows the requester to specify editor options when a preparing a document
/// </summary>
public record SubEditorOptions
{
    /// <summary>
    /// Allows requesters to edit the list of signers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_edit_signers")]
    public bool? AllowEditSigners { get; init; } = false;

    /// <summary>
    /// Allows requesters to edit documents, including delete and add
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_edit_documents")]
    public bool? AllowEditDocuments { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
