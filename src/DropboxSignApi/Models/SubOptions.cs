using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Additional options supported by API App.
/// </summary>
public record SubOptions
{
    /// <summary>
    /// Determines if signers can use "Insert Everywhere" when signing a document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_insert_everywhere")]
    public bool? CanInsertEverywhere { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
