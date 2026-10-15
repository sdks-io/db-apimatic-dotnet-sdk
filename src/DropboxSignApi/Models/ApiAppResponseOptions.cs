using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// An object with options that override account settings.
/// </summary>
public record ApiAppResponseOptions
{
    /// <summary>
    /// Boolean denoting if signers can "Insert Everywhere" in one click while signing a document
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_insert_everywhere")]
    public bool? CanInsertEverywhere { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
