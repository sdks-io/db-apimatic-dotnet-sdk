using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TeamInvitesResponse
{
    /// <summary>
    /// Contains a list of team invites and their roles.
    /// </summary>
    [JsonPropertyName("team_invites")]
    public required IReadOnlyList<TeamInviteResponse> TeamInvites { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
