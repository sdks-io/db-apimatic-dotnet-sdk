using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TeamMembersResponse
{
    /// <summary>
    /// Contains a list of team members and their roles for a specific team.
    /// </summary>
    [JsonPropertyName("team_members")]
    public required IReadOnlyList<TeamMemberResponse> TeamMembers { get; init; }

    /// <summary>
    /// Contains pagination information about the data returned.
    /// </summary>
    [JsonPropertyName("list_info")]
    public required ListInfoResponse ListInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<WarningResponse>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
