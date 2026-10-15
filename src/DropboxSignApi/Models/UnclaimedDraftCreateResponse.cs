using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record UnclaimedDraftCreateResponse
{
    /// <summary>
    /// A group of documents that a user can take ownership of via the claim URL.
    /// </summary>
    [JsonPropertyName("unclaimed_draft")]
    public required UnclaimedDraftResponse UnclaimedDraft { get; init; }

    /// <summary>
    /// A list of warnings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
